#addin "Cake.FileHelpers"
#addin "CsvHelper"

using System.Linq;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;
using CsvHelper;
using CsvHelper.Configuration.Attributes;

public class Mapping
{
    [Name("Support .NET namespace")]
    public string SupportNamespace { get; set; }

    [Name("Support .NET type name")]
    public string SupportType { get; set; }

    [Ignore]
    public string SupportFullName => $"{SupportNamespace}.{SupportType}";

    [Name("AndroidX .NET namespace")]
    public string AndroidXNamespace { get; set; }

    [Name("AndroidX .NET type name")]
    public string AndroidXType { get; set; }

    [Ignore]
    public string AndroidXFullName => $"{AndroidXNamespace}.{AndroidXType}";
}

// generate the API infos
if (!FileExists("assemblies/AndroidSupport.Merged.api-info.xml")) {
    Information("Generating API info for Android Support...");
    StartProcess("api-tools", "api-info assemblies/AndroidSupport.Merged.dll");
}
if (!FileExists("assemblies/AndroidX.Merged.api-info.xml")) {
    Information("Generating API info for Android X...");
    StartProcess("api-tools", "api-info assemblies/AndroidX.Merged.dll");
}

// load the data
Information("Loading migration data...");
var csv = new CsvReader(new StreamReader("mappings/androidx-mapping.csv"));
var mappings = csv.GetRecords<Mapping>().ToList();

string Map(string fullname)
{
    if (fullname.EndsWith("[]")) {
        fullname = fullname.Substring(0, fullname.Length - 2);
        return Map(fullname) + "[]";
    }

    if (fullname.StartsWith("System.Collections.Generic.IList`1[") && fullname.EndsWith("]")) {
        fullname = fullname.Substring(35, (fullname.Length - 35) - 1);
        return "System.Collections.Generic.IList`1[" + Map(fullname) + "]";
    }

    if (fullname.StartsWith("System.Collections.Generic.ICollection`1[") && fullname.EndsWith("]")) {
        fullname = fullname.Substring(41, (fullname.Length - 41) - 1);
        return "System.Collections.Generic.ICollection`1[" + Map(fullname) + "]";
    }

    if (fullname.StartsWith("System.Collections.Generic.IDictionary`2[") && fullname.EndsWith("]")) {
        fullname = fullname.Substring(41, (fullname.Length - 41) - 1);
        var fnparts = fullname.Split(',');
        return "System.Collections.Generic.IDictionary`2[" + Map(fnparts[0]) + "," + Map(fnparts[1]) + "]";
    }

    var parts = fullname.Split('+');
    var map = mappings.FirstOrDefault(m => m.SupportFullName == parts[0]);
    if (map == null)
        return fullname;

    parts[0] = map.AndroidXFullName;
    return string.Join('+', parts);
}

// start the process
var support = XDocument.Load("assemblies/AndroidSupport.Merged.api-info.xml");
var androidx = XDocument.Load("assemblies/AndroidX.Merged.api-info.xml");

// base
Information("Mapping base classes...");
var xclasses = support.XPathSelectElements("//class").ToList();
foreach (var xclass in xclasses) {
    var xbase = xclass.Attribute("base");
    if (xbase != null)
        xbase.Value = Map(xbase.Value);
}

// interfaces
Information("Mapping base interfaces...");
var xinterfaces = support.XPathSelectElements("//interface").ToList();
foreach (var xiface in xinterfaces) {
    var xtype = xiface.Attribute("name");
    if (xtype != null)
        xtype.Value = Map(xtype.Value);

    // remove the new generator interface
    if (xtype.Value == "Java.Interop.IJavaPeerable")
        xiface.Remove();
}

// clean up the androidx as well
xinterfaces = androidx.XPathSelectElements("//interface").ToList();
foreach (var xiface in xinterfaces) {
    var xtype = xiface.Attribute("name");

    // remove the new generator interface
    if (xtype.Value == "Java.Interop.IJavaPeerable")
        xiface.Remove();
}


// ctor + methods
Information("Mapping constructors and methods...");
var xmethods =
    support.XPathSelectElements("//constructor").Union(
    support.XPathSelectElements("//method")).ToList();
foreach (var xmethod in xmethods) {
    var xreturn = xmethod.Attribute("returntype");
    if (xreturn != null)
        xreturn.Value = Map(xreturn.Value);

    var xname = xmethod.Attribute("name");
    var parts = xname.Value.Split('(', ')');
    var name = parts[0];
    var param = parts.Length > 1
        ? parts[1].Split(", ")
        : new string[0];

    var p = string.Join(", ", param.Select(Map));
    xname.Value = $"{name}({p})";
}

// parameters (for ctors + methods)
Information("Mapping constructor and method parameters...");
var xparameters = support.XPathSelectElements("//parameter").ToList();
foreach (var xparam in xparameters) {
    var xtype = xparam.Attribute("type");
    if (xtype != null)
        xtype.Value = Map(xtype.Value);
}

// properties
Information("Mapping properties...");
var xproperties = support.XPathSelectElements("//property").ToList();
foreach (var xprop in xproperties) {
    var xtype = xprop.Attribute("ptype");
    if (xtype != null)
        xtype.Value = Map(xtype.Value);

    // remove the new generator property
    if (xtype?.Value == "Java.Interop.JniPeerMembers")
        xprop.Remove();
}

// clean up the androidx as well
xproperties = androidx.XPathSelectElements("//property").ToList();
foreach (var xprop in xproperties) {
    var xtype = xprop.Attribute("ptype");

    // remove the new generator property
    if (xtype?.Value == "Java.Interop.JniPeerMembers")
        xprop.Remove();
}

// namespaces
Information("Mapping type namespaces...");
var mapped = new Dictionary<string, List<XElement>>();
var xtypes = support.XPathSelectElements("/assemblies/assembly/namespaces/namespace/classes/class").ToList();
foreach (var xclass in xtypes) {
    var xns = xclass.Parent.Parent.Attribute("name");
    var xname = xclass.Attribute("name");
    var fn = $"{xns.Value}.{xname.Value}";
    var map = mappings.FirstOrDefault(m => m.SupportFullName == fn);
    var ns = map?.AndroidXNamespace ?? xns.Value;
    if (!mapped.TryGetValue(ns, out var list)) {
        list = new List<XElement>();
        mapped[ns] = list;
    }
    list.Add(xclass);
}

var xnamespaces = support.XPathSelectElement("/assemblies/assembly/namespaces");
xnamespaces.Elements("namespace").Remove();

foreach (var map in mapped) {
    xnamespaces.Add(new XElement("namespace", new XAttribute("name", map.Key),
        new XElement("classes",
            map.Value)));
}

Information("Saving output...");
EnsureDirectoryExists("output");
support.Save("output/AndroidSupport.api-info.xml");
androidx.Save("output/AndroidX.api-info.xml");

Information("Generating diff...");
StartProcess("api-tools", "diff output/AndroidSupport.api-info.xml output/AndroidX.api-info.xml --ignore-param-names --ignore-virtual --output output/Diff.md");
StartProcess("api-tools", "diff output/AndroidSupport.api-info.xml output/AndroidX.api-info.xml --ignore-param-names --ignore-virtual --ignore-nonbreaking --output output/Diff.breaking.md");
