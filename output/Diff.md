# API diff: AndroidX.Merged.dll

## AndroidX.Merged.dll

### Namespace AndroidX.Lifecycle

#### Type Changed: AndroidX.Lifecycle.CompositeGeneratedAdaptersObserver

Removed interface:

```csharp
IGenericLifecycleObserver
```

Added interface:

```csharp
ILifecycleEventObserver
```


#### Type Changed: AndroidX.Lifecycle.IGenericLifecycleObserver

Added interface:

```csharp
ILifecycleEventObserver
```

Removed method:

```csharp
public virtual void OnStateChanged (ILifecycleOwner, Lifecycle.Event);
```


#### Type Changed: AndroidX.Lifecycle.LifecycleRegistry

Obsoleted methods:

```diff
 [Obsolete ("deprecated")]
 public virtual void MarkState (Lifecycle.State);
```

Added method:

```csharp
public virtual void SetCurrentState (Lifecycle.State);
```


#### Type Changed: AndroidX.Lifecycle.Lifecycling

Removed constructor:

```csharp
public Lifecycling ();
```


#### Type Changed: AndroidX.Lifecycle.LiveData

Added constructor:

```csharp
public LiveData (Java.Lang.Object);
```

#### Type Changed: AndroidX.Lifecycle.LiveData.LifecycleBoundObserver

Removed interface:

```csharp
IGenericLifecycleObserver
```

Added interface:

```csharp
ILifecycleEventObserver
```



#### Type Changed: AndroidX.Lifecycle.MutableLiveData

Added constructor:

```csharp
public MutableLiveData (Java.Lang.Object);
```


#### Type Changed: AndroidX.Lifecycle.SingleGeneratedAdapterObserver

Removed interface:

```csharp
IGenericLifecycleObserver
```

Added interface:

```csharp
ILifecycleEventObserver
```


#### Type Changed: AndroidX.Lifecycle.Transformations

Added method:

```csharp
public static LiveData DistinctUntilChanged (LiveData);
```


#### Type Changed: AndroidX.Lifecycle.ViewModelProvider

#### New Type: AndroidX.Lifecycle.ViewModelProvider.KeyedFactory

```csharp
public abstract class KeyedFactory : Java.Lang.Object, Android.Runtime.IJavaObject, ViewModelProvider.IFactory, System.IDisposable {
	// constructors
	protected ViewModelProvider.KeyedFactory (IntPtr, Android.Runtime.JniHandleOwnership);
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public virtual Java.Lang.Object Create (Java.Lang.Class);
	public virtual Java.Lang.Object Create (string, Java.Lang.Class);
}
```


#### Type Changed: AndroidX.Lifecycle.ViewModelStores

Obsoleted methods:

```diff
 [Obsolete ("deprecated")]
 public static ViewModelStore Of (AndroidX.Fragment.App.Fragment);
 [Obsolete ("deprecated")]
 public static ViewModelStore Of (AndroidX.Fragment.App.FragmentActivity);
```


#### New Type: AndroidX.Lifecycle.ILifecycleEventObserver

```csharp
public interface ILifecycleEventObserver : Android.Runtime.IJavaObject, ILifecycleObserver, System.IDisposable {
	// methods
	public virtual void OnStateChanged (ILifecycleOwner, Lifecycle.Event);
}
```


### Namespace AndroidX.Room

#### Type Changed: AndroidX.Room.ColumnInfo

Added field:

```csharp
public static const string ValueUnspecified = "[value-unspecified]";
```


#### Type Changed: AndroidX.Room.ColumnInfoAttribute

Added property:

```csharp
public string DefaultValue { get; set; }
```


#### Type Changed: AndroidX.Room.DatabaseAttribute

Added property:

```csharp
public Java.Lang.Class[] Views { get; set; }
```


#### Type Changed: AndroidX.Room.DatabaseConfiguration

Removed constructor:

```csharp
public DatabaseConfiguration (Android.Content.Context, string, AndroidX.Sqlite.Db.ISupportSQLiteOpenHelperFactory, RoomDatabase.MigrationContainer, System.Collections.Generic.IList<RoomDatabase.Callback>, bool, RoomDatabase.JournalMode, bool, System.Collections.Generic.ICollection<Java.Lang.Integer>);
```

Added constructors:

```csharp

[Obsolete ("deprecated")]
public DatabaseConfiguration (Android.Content.Context, string, AndroidX.Sqlite.Db.ISupportSQLiteOpenHelperFactory, RoomDatabase.MigrationContainer, System.Collections.Generic.IList<RoomDatabase.Callback>, bool, RoomDatabase.JournalMode, Java.Util.Concurrent.IExecutor, bool, System.Collections.Generic.ICollection<Java.Lang.Integer>);

[Obsolete ("deprecated")]
public DatabaseConfiguration (Android.Content.Context, string, AndroidX.Sqlite.Db.ISupportSQLiteOpenHelperFactory, RoomDatabase.MigrationContainer, System.Collections.Generic.IList<RoomDatabase.Callback>, bool, RoomDatabase.JournalMode, Java.Util.Concurrent.IExecutor, Java.Util.Concurrent.IExecutor, bool, bool, bool, System.Collections.Generic.ICollection<Java.Lang.Integer>);
```

Added properties:

```csharp
public bool AllowDestructiveMigrationOnDowngrade { get; set; }
public string CopyFromAssetPath { get; set; }
public Java.IO.File CopyFromFile { get; set; }
public bool MultiInstanceInvalidation { get; set; }
public Java.Util.Concurrent.IExecutor QueryExecutor { get; set; }
public Java.Util.Concurrent.IExecutor TransactionExecutor { get; set; }
```

Obsoleted methods:

```diff
 [Obsolete ("deprecated")]
 public virtual bool IsMigrationRequiredFrom (int);
```

Added method:

```csharp
public virtual bool IsMigrationRequired (int, int);
```


#### Type Changed: AndroidX.Room.DeleteAttribute

Added property:

```csharp
public Java.Lang.Class Entity { get; set; }
```


#### Type Changed: AndroidX.Room.EntityAttribute

Added property:

```csharp
public string[] IgnoredColumns { get; set; }
```


#### Type Changed: AndroidX.Room.IColumnInfo

Added method:

```csharp
public virtual string DefaultValue ();
```


#### Type Changed: AndroidX.Room.IDatabase

Added method:

```csharp
public virtual Java.Lang.Class[] Views ();
```


#### Type Changed: AndroidX.Room.IDelete

Added method:

```csharp
public virtual Java.Lang.Class Entity ();
```


#### Type Changed: AndroidX.Room.IEntity

Added method:

```csharp
public virtual string[] IgnoredColumns ();
```


#### Type Changed: AndroidX.Room.IInsert

Added method:

```csharp
public virtual Java.Lang.Class Entity ();
```


#### Type Changed: AndroidX.Room.IRelation

Added method:

```csharp
public virtual IJunction AssociateBy ();
```


#### Type Changed: AndroidX.Room.IUpdate

Added method:

```csharp
public virtual Java.Lang.Class Entity ();
```


#### Type Changed: AndroidX.Room.InsertAttribute

Added property:

```csharp
public Java.Lang.Class Entity { get; set; }
```


#### Type Changed: AndroidX.Room.InvalidationTracker

Added constructor:

```csharp
public InvalidationTracker (RoomDatabase, System.Collections.Generic.IDictionary<System.String,System.String>, System.Collections.Generic.IDictionary<System.String,System.Collections.Generic.ICollection<string>>, string[]);
```

Added method:

```csharp
public virtual void NotifyObserversByTableNames (string[]);
```


#### Type Changed: AndroidX.Room.OnConflictStrategy

Obsoleted fields:

```diff
 [Obsolete ("deprecated")]
 public static const int Fail;
 [Obsolete ("deprecated")]
 public static const int Rollback;
```


#### Type Changed: AndroidX.Room.Room

Obsoleted constructors:

```diff
 [Obsolete ("deprecated")]
 public Room ();
```


#### Type Changed: AndroidX.Room.RoomDatabase

Added properties:

```csharp
public Java.Util.Concurrent.IExecutor QueryExecutor { get; }
public Java.Util.Concurrent.IExecutor TransactionExecutor { get; }
```

Obsoleted methods:

```diff
 [Obsolete ("deprecated")]
 public virtual void BeginTransaction ();
 [Obsolete ("deprecated")]
 public virtual void EndTransaction ();
 [Obsolete ("deprecated")]
 public virtual void SetTransactionSuccessful ();
```

Added methods:

```csharp
public virtual void AssertNotSuspendingTransaction ();
public virtual Android.Database.ICursor Query (AndroidX.Sqlite.Db.ISupportSQLiteQuery, Android.OS.CancellationSignal);
```

#### Type Changed: AndroidX.Room.RoomDatabase.Builder

Added methods:

```csharp
public virtual RoomDatabase.Builder CreateFromAsset (string);
public virtual RoomDatabase.Builder CreateFromFile (Java.IO.File);
public virtual RoomDatabase.Builder EnableMultiInstanceInvalidation ();
public virtual RoomDatabase.Builder FallbackToDestructiveMigrationOnDowngrade ();
public virtual RoomDatabase.Builder SetQueryExecutor (Java.Util.Concurrent.IExecutor);
public virtual RoomDatabase.Builder SetTransactionExecutor (Java.Util.Concurrent.IExecutor);
```


#### Type Changed: AndroidX.Room.RoomDatabase.Callback

Added method:

```csharp
public virtual void OnDestructiveMigration (AndroidX.Sqlite.Db.ISupportSQLiteDatabase);
```



#### Type Changed: AndroidX.Room.RoomMasterTable

Removed constructor:

```csharp
public RoomMasterTable ();
```


#### Type Changed: AndroidX.Room.RoomOpenHelper

#### Type Changed: AndroidX.Room.RoomOpenHelper.HelperDelegate

Obsoleted methods:

```diff
 [Obsolete ("deprecated")]
 protected virtual void ValidateMigration (AndroidX.Sqlite.Db.ISupportSQLiteDatabase);
```

Added methods:

```csharp
protected virtual void OnPostMigrate (AndroidX.Sqlite.Db.ISupportSQLiteDatabase);
protected virtual void OnPreMigrate (AndroidX.Sqlite.Db.ISupportSQLiteDatabase);
protected virtual RoomOpenHelper.ValidationResult OnValidateSchema (AndroidX.Sqlite.Db.ISupportSQLiteDatabase);
```


#### New Type: AndroidX.Room.RoomOpenHelper.ValidationResult

```csharp
public class ValidationResult : Java.Lang.Object {
	// constructors
	public RoomOpenHelper.ValidationResult (bool, string);
	protected RoomOpenHelper.ValidationResult (IntPtr, Android.Runtime.JniHandleOwnership);
	// properties
	public string ExpectedFoundMsg { get; set; }
	public bool IsValid { get; set; }
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
}
```


#### Type Changed: AndroidX.Room.RoomWarnings

Obsoleted constructors:

```diff
 [Obsolete ("deprecated")]
 public RoomWarnings ();
```


#### Type Changed: AndroidX.Room.UpdateAttribute

Added property:

```csharp
public Java.Lang.Class Entity { get; set; }
```


#### New Type: AndroidX.Room.DatabaseViewAttribute

```csharp
public class DatabaseViewAttribute : System.Attribute {
	// constructors
	public DatabaseViewAttribute ();
	// properties
	public string Value { get; set; }
	public string ViewName { get; set; }
}
```

#### New Type: AndroidX.Room.Fts3Attribute

```csharp
public class Fts3Attribute : System.Attribute {
	// constructors
	public Fts3Attribute ();
	// properties
	public string Tokenizer { get; set; }
	public string[] TokenizerArgs { get; set; }
}
```

#### New Type: AndroidX.Room.Fts4Attribute

```csharp
public class Fts4Attribute : System.Attribute {
	// constructors
	public Fts4Attribute ();
	// properties
	public Java.Lang.Class ContentEntity { get; set; }
	public string LanguageId { get; set; }
	public string[] NotIndexed { get; set; }
	public int[] Prefix { get; set; }
	public string Tokenizer { get; set; }
	public string[] TokenizerArgs { get; set; }
}
```

#### New Type: AndroidX.Room.FtsOptions

```csharp
public class FtsOptions : Java.Lang.Object {
	// constructors
	protected FtsOptions (IntPtr, Android.Runtime.JniHandleOwnership);
	// fields
	public static const string TokenizerIcu = "icu";
	public static const string TokenizerPorter = "porter";
	public static const string TokenizerSimple = "simple";
	public static const string TokenizerUnicode61 = "unicode61";
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }

	// inner types
	public sealed class MatchInfo : Java.Lang.Enum {
		// properties
		public static FtsOptions.MatchInfo Fts3 { get; }
		public static FtsOptions.MatchInfo Fts4 { get; }
		protected IntPtr ThresholdClass { get; }
		protected System.Type ThresholdType { get; }
		// methods
		public static FtsOptions.MatchInfo ValueOf (string);
		public static FtsOptions.MatchInfo[] Values ();
	}
	public sealed class Order : Java.Lang.Enum {
		// properties
		public static FtsOptions.Order Asc { get; }
		public static FtsOptions.Order Desc { get; }
		protected IntPtr ThresholdClass { get; }
		protected System.Type ThresholdType { get; }
		// methods
		public static FtsOptions.Order ValueOf (string);
		public static FtsOptions.Order[] Values ();
	}
}
```

#### New Type: AndroidX.Room.IDatabaseView

```csharp
public interface IDatabaseView : Android.Runtime.IJavaObject, Java.Lang.Annotation.IAnnotation, System.IDisposable {
	// methods
	public virtual string Value ();
	public virtual string ViewName ();
}
```

#### New Type: AndroidX.Room.IFts3

```csharp
public interface IFts3 : Android.Runtime.IJavaObject, Java.Lang.Annotation.IAnnotation, System.IDisposable {
	// methods
	public virtual string Tokenizer ();
	public virtual string[] TokenizerArgs ();
}
```

#### New Type: AndroidX.Room.IFts4

```csharp
public interface IFts4 : Android.Runtime.IJavaObject, Java.Lang.Annotation.IAnnotation, System.IDisposable {
	// methods
	public virtual Java.Lang.Class ContentEntity ();
	public virtual string LanguageId ();
	public virtual FtsOptions.MatchInfo MatchInfo ();
	public virtual string[] NotIndexed ();
	public virtual FtsOptions.Order Order ();
	public virtual int[] Prefix ();
	public virtual string Tokenizer ();
	public virtual string[] TokenizerArgs ();
}
```

#### New Type: AndroidX.Room.IJunction

```csharp
public interface IJunction : Android.Runtime.IJavaObject, Java.Lang.Annotation.IAnnotation, System.IDisposable {
	// methods
	public virtual string EntityColumn ();
	public virtual string ParentColumn ();
	public virtual Java.Lang.Class Value ();
}
```

#### New Type: AndroidX.Room.IMultiInstanceInvalidationCallback

```csharp
public interface IMultiInstanceInvalidationCallback : Android.OS.IInterface, Android.Runtime.IJavaObject, System.IDisposable {
	// methods
	public virtual void OnInvalidation (string[]);
}
```

#### New Type: AndroidX.Room.IMultiInstanceInvalidationService

```csharp
public interface IMultiInstanceInvalidationService : Android.OS.IInterface, Android.Runtime.IJavaObject, System.IDisposable {
	// methods
	public virtual void BroadcastInvalidation (int, string[]);
	public virtual int RegisterCallback (IMultiInstanceInvalidationCallback, string);
	public virtual void UnregisterCallback (IMultiInstanceInvalidationCallback, int);
}
```

#### New Type: AndroidX.Room.JunctionAttribute

```csharp
public class JunctionAttribute : System.Attribute {
	// constructors
	public JunctionAttribute ();
	// properties
	public string EntityColumn { get; set; }
	public string ParentColumn { get; set; }
	public Java.Lang.Class Value { get; set; }
}
```

#### New Type: AndroidX.Room.MultiInstanceInvalidationCallbackStub

```csharp
public abstract class MultiInstanceInvalidationCallbackStub : Android.OS.Binder, Android.OS.IInterface, Android.Runtime.IJavaObject, IMultiInstanceInvalidationCallback, System.IDisposable {
	// constructors
	public MultiInstanceInvalidationCallbackStub ();
	protected MultiInstanceInvalidationCallbackStub (IntPtr, Android.Runtime.JniHandleOwnership);
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public virtual Android.OS.IBinder AsBinder ();
	public static IMultiInstanceInvalidationCallback AsInterface (Android.OS.IBinder);
	public virtual void OnInvalidation (string[]);
	public virtual bool OnTransact (int, Android.OS.Parcel, Android.OS.Parcel, int);
}
```

#### New Type: AndroidX.Room.MultiInstanceInvalidationService

```csharp
public class MultiInstanceInvalidationService : Android.App.Service {
	// constructors
	public MultiInstanceInvalidationService ();
	protected MultiInstanceInvalidationService (IntPtr, Android.Runtime.JniHandleOwnership);
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public override Android.OS.IBinder OnBind (Android.Content.Intent);
}
```

#### New Type: AndroidX.Room.MultiInstanceInvalidationServiceStub

```csharp
public abstract class MultiInstanceInvalidationServiceStub : Android.OS.Binder, Android.OS.IInterface, Android.Runtime.IJavaObject, IMultiInstanceInvalidationService, System.IDisposable {
	// constructors
	public MultiInstanceInvalidationServiceStub ();
	protected MultiInstanceInvalidationServiceStub (IntPtr, Android.Runtime.JniHandleOwnership);
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public virtual Android.OS.IBinder AsBinder ();
	public static IMultiInstanceInvalidationService AsInterface (Android.OS.IBinder);
	public virtual void BroadcastInvalidation (int, string[]);
	public virtual bool OnTransact (int, Android.OS.Parcel, Android.OS.Parcel, int);
	public virtual int RegisterCallback (IMultiInstanceInvalidationCallback, string);
	public virtual void UnregisterCallback (IMultiInstanceInvalidationCallback, int);
}
```


### Namespace AndroidX.Room.Util

#### Type Changed: AndroidX.Room.Util.StringUtil

Removed constructor:

```csharp
public StringUtil ();
```


#### Type Changed: AndroidX.Room.Util.TableInfo

Added fields:

```csharp
public static const int CreatedFromDatabase;
public static const int CreatedFromEntity;
public static const int CreatedFromUnknown;
```

#### Type Changed: AndroidX.Room.Util.TableInfo.Column

Obsoleted constructors:

```diff
 [Obsolete ("deprecated")]
 public TableInfo.Column (string, string, bool, int);
```

Added constructor:

```csharp
public TableInfo.Column (string, string, bool, int, string, int);
```

Added property:

```csharp
public string DefaultValue { get; set; }
```



#### New Type: AndroidX.Room.Util.CopyLock

```csharp
public class CopyLock : Java.Lang.Object {
	// constructors
	protected CopyLock (IntPtr, Android.Runtime.JniHandleOwnership);
	public CopyLock (string, Java.IO.File, bool);
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public virtual void Lock ();
	public virtual void Unlock ();
}
```

#### New Type: AndroidX.Room.Util.CursorUtil

```csharp
public class CursorUtil : Java.Lang.Object {
	// constructors
	protected CursorUtil (IntPtr, Android.Runtime.JniHandleOwnership);
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public static Android.Database.ICursor CopyAndClose (Android.Database.ICursor);
	public static int GetColumnIndex (Android.Database.ICursor, string);
	public static int GetColumnIndexOrThrow (Android.Database.ICursor, string);
}
```

#### New Type: AndroidX.Room.Util.DBUtil

```csharp
public class DBUtil : Java.Lang.Object {
	// constructors
	protected DBUtil (IntPtr, Android.Runtime.JniHandleOwnership);
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public static Android.OS.CancellationSignal CreateCancellationSignal ();
	public static void DropFtsSyncTriggers (AndroidX.Sqlite.Db.ISupportSQLiteDatabase);

	[Obsolete ("deprecated")]
public static Android.Database.ICursor Query (AndroidX.Room.RoomDatabase, AndroidX.Sqlite.Db.ISupportSQLiteQuery, bool);
	public static Android.Database.ICursor Query (AndroidX.Room.RoomDatabase, AndroidX.Sqlite.Db.ISupportSQLiteQuery, bool, Android.OS.CancellationSignal);
	public static int ReadVersion (Java.IO.File);
}
```

#### New Type: AndroidX.Room.Util.FileUtil

```csharp
public class FileUtil : Java.Lang.Object {
	// constructors
	protected FileUtil (IntPtr, Android.Runtime.JniHandleOwnership);
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public static void Copy (Java.Nio.Channels.IReadableByteChannel, Java.Nio.Channels.FileChannel);
}
```

#### New Type: AndroidX.Room.Util.FtsTableInfo

```csharp
public class FtsTableInfo : Java.Lang.Object {
	// constructors
	protected FtsTableInfo (IntPtr, Android.Runtime.JniHandleOwnership);
	public FtsTableInfo (string, System.Collections.Generic.ICollection<string>, System.Collections.Generic.ICollection<string>);
	public FtsTableInfo (string, System.Collections.Generic.ICollection<string>, string);
	// properties
	public System.Collections.ICollection Columns { get; set; }
	public string Name { get; set; }
	public System.Collections.ICollection Options { get; set; }
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public static FtsTableInfo Read (AndroidX.Sqlite.Db.ISupportSQLiteDatabase, string);
}
```

#### New Type: AndroidX.Room.Util.SneakyThrow

```csharp
public class SneakyThrow : Java.Lang.Object {
	// constructors
	protected SneakyThrow (IntPtr, Android.Runtime.JniHandleOwnership);
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public static void ReThrow (Java.Lang.Exception);
}
```

#### New Type: AndroidX.Room.Util.ViewInfo

```csharp
public class ViewInfo : Java.Lang.Object {
	// constructors
	protected ViewInfo (IntPtr, Android.Runtime.JniHandleOwnership);
	public ViewInfo (string, string);
	// properties
	public string Name { get; set; }
	public string Sql { get; set; }
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public static ViewInfo Read (AndroidX.Sqlite.Db.ISupportSQLiteDatabase, string);
}
```


### Namespace AndroidX.Annotations

#### Type Changed: AndroidX.Annotations.IIntDef

Added method:

```csharp
public virtual bool Open ();
```


#### Type Changed: AndroidX.Annotations.ILongDef

Added method:

```csharp
public virtual bool Open ();
```


#### Type Changed: AndroidX.Annotations.IStringDef

Added method:

```csharp
public virtual bool Open ();
```


#### Type Changed: AndroidX.Annotations.IntDefAttribute

Added property:

```csharp
public bool Open { get; set; }
```


#### Type Changed: AndroidX.Annotations.LongDefAttribute

Added property:

```csharp
public bool Open { get; set; }
```


#### Type Changed: AndroidX.Annotations.RestrictToScope

Added property:

```csharp
public static RestrictToScope LibraryGroupPrefix { get; }
```


#### Type Changed: AndroidX.Annotations.StringDefAttribute

Added property:

```csharp
public bool Open { get; set; }
```


#### New Type: AndroidX.Annotations.ContentViewAttribute

```csharp
public class ContentViewAttribute : System.Attribute {
	// constructors
	public ContentViewAttribute ();
}
```

#### New Type: AndroidX.Annotations.IContentView

```csharp
public interface IContentView : Android.Runtime.IJavaObject, Java.Lang.Annotation.IAnnotation, System.IDisposable {
}
```

#### New Type: AndroidX.Annotations.IInspectableProperty

```csharp
public interface IInspectableProperty : Android.Runtime.IJavaObject, Java.Lang.Annotation.IAnnotation, System.IDisposable {
	// properties
	public bool HasAttributeId { get; }
	// methods
	public virtual int AttributeId ();
	public virtual IInspectablePropertyEnumEntry[] EnumMapping ();
	public virtual IInspectablePropertyFlagEntry[] FlagMapping ();
	public virtual string Name ();
	public virtual InspectablePropertyValueType ValueType ();
}
```

#### New Type: AndroidX.Annotations.IInspectablePropertyEnumEntry

```csharp
public interface IInspectablePropertyEnumEntry : Android.Runtime.IJavaObject, Java.Lang.Annotation.IAnnotation, System.IDisposable {
	// methods
	public virtual string Name ();
	public virtual int Value ();
}
```

#### New Type: AndroidX.Annotations.IInspectablePropertyFlagEntry

```csharp
public interface IInspectablePropertyFlagEntry : Android.Runtime.IJavaObject, Java.Lang.Annotation.IAnnotation, System.IDisposable {
	// methods
	public virtual int Mask ();
	public virtual string Name ();
	public virtual int Target ();
}
```

#### New Type: AndroidX.Annotations.InspectablePropertyAttribute

```csharp
public class InspectablePropertyAttribute : System.Attribute {
	// constructors
	public InspectablePropertyAttribute ();
	// properties
	public int AttributeId { get; set; }
	public string Name { get; set; }
}
```

#### New Type: AndroidX.Annotations.InspectablePropertyValueType

```csharp
public sealed class InspectablePropertyValueType : Java.Lang.Enum {
	// properties
	public static InspectablePropertyValueType Color { get; }
	public static InspectablePropertyValueType Gravity { get; }
	public static InspectablePropertyValueType Inferred { get; }
	public static InspectablePropertyValueType IntEnum { get; }
	public static InspectablePropertyValueType IntFlag { get; }
	public static InspectablePropertyValueType None { get; }
	public static InspectablePropertyValueType ResourceId { get; }
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public static InspectablePropertyValueType ValueOf (string);
	public static InspectablePropertyValueType[] Values ();
}
```


### Namespace AndroidX.ConstraintLayout.Widget

#### Type Changed: AndroidX.ConstraintLayout.Widget.Barrier

Added methods:

```csharp
public virtual bool AllowsGoneWidget ();
public virtual void SetAllowsGoneWidget (bool);
```


#### Type Changed: AndroidX.ConstraintLayout.Widget.ConstraintLayout

Modified fields:

```diff
-public const string Version = "ConstraintLayout-1.1.0";
+public const string Version = "ConstraintLayout-1.1.3";
```


#### Type Changed: AndroidX.ConstraintLayout.Widget.ConstraintSet

Added method:

```csharp
public virtual Java.Lang.Object GetParameters (int);
```



### Namespace AndroidX.ConstraintLayout.Solver

#### Type Changed: AndroidX.ConstraintLayout.Solver.ArrayRow

Removed interfaces:

```csharp
Android.Runtime.IJavaObject
LinearSystem.IRow
System.IDisposable
```


#### Type Changed: AndroidX.ConstraintLayout.Solver.GoalRow

Removed interfaces:

```csharp
Android.Runtime.IJavaObject
LinearSystem.IRow
System.IDisposable
```



### Namespace AndroidX.ConstraintLayout.Solver.Widgets

#### Type Changed: AndroidX.ConstraintLayout.Solver.Widgets.Barrier

Added method:

```csharp
public virtual bool AllowsGoneWidget ();
```


#### Type Changed: AndroidX.ConstraintLayout.Solver.Widgets.ConstraintWidget

Added field:

```csharp
public static const int MatchConstraintRatioResolved;
```

Obsoleted properties:

```diff
 [Obsolete ("Use MNextChainWidget instead.")]
 protected System.Collections.Generic.IList<ConstraintWidget> MListNextVisibleWidget { get; set; }
```

Added property:

```csharp
protected System.Collections.Generic.IList<ConstraintWidget> MNextChainWidget { get; set; }
```

Added methods:

```csharp
public virtual void CreateObjectVariables (AndroidX.ConstraintLayout.Solver.LinearSystem);
public virtual float GetBiasPercent (int);
public virtual ConstraintWidget.DimensionBehaviour GetDimensionBehaviour (int);
public virtual int GetLength (int);
public virtual void SetFrame (int, int, int);
public virtual void SetLength (int, int);
```


#### Type Changed: AndroidX.ConstraintLayout.Solver.Widgets.ConstraintWidgetContainer

Added properties:

```csharp
public bool MGroupsWrapOptimized { get; set; }
public bool MHorizontalWrapOptimized { get; set; }
public bool MSkipSolver { get; set; }
public bool MVerticalWrapOptimized { get; set; }
public System.Collections.IList MWidgetGroups { get; set; }
public int MWrapFixedHeight { get; set; }
public int MWrapFixedWidth { get; set; }
public System.Collections.Generic.IList<ConstraintWidgetGroup> WidgetGroups { get; }
```


#### Type Changed: AndroidX.ConstraintLayout.Solver.Widgets.Optimizer

Modified fields:

```diff
-public const int OptimizationStandard = 3;
+public const int OptimizationStandard = 7;
```

Added field:

```csharp
public static const int OptimizationGroups;
```


#### Type Changed: AndroidX.ConstraintLayout.Solver.Widgets.WidgetContainer

Added method:

```csharp
public virtual void Add (ConstraintWidget[]);
```


#### New Type: AndroidX.ConstraintLayout.Solver.Widgets.Analyzer

```csharp
public class Analyzer : Java.Lang.Object {
	// constructors
	protected Analyzer (IntPtr, Android.Runtime.JniHandleOwnership);
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public static void DetermineGroups (ConstraintWidgetContainer);
	public static void SetPosition (System.Collections.Generic.IList<ConstraintWidgetGroup>, int, int);
}
```

#### New Type: AndroidX.ConstraintLayout.Solver.Widgets.ChainHead

```csharp
public class ChainHead : Java.Lang.Object {
	// constructors
	protected ChainHead (IntPtr, Android.Runtime.JniHandleOwnership);
	public ChainHead (ConstraintWidget, int, bool);
	// properties
	public ConstraintWidget First { get; }
	public ConstraintWidget FirstMatchConstraintWidget { get; }
	public ConstraintWidget FirstVisibleWidget { get; }
	public ConstraintWidget Head { get; }
	public ConstraintWidget Last { get; }
	public ConstraintWidget LastMatchConstraintWidget { get; }
	public ConstraintWidget LastVisibleWidget { get; }
	protected ConstraintWidget MFirst { get; set; }
	protected ConstraintWidget MFirstMatchConstraintWidget { get; set; }
	protected ConstraintWidget MFirstVisibleWidget { get; set; }
	protected bool MHasComplexMatchWeights { get; set; }
	protected bool MHasDefinedWeights { get; set; }
	protected bool MHasUndefinedWeights { get; set; }
	protected ConstraintWidget MHead { get; set; }
	protected ConstraintWidget MLast { get; set; }
	protected ConstraintWidget MLastMatchConstraintWidget { get; set; }
	protected ConstraintWidget MLastVisibleWidget { get; set; }
	protected float MTotalWeight { get; set; }
	protected System.Collections.IList MWeightedMatchConstraintsWidgets { get; set; }
	protected int MWidgetsCount { get; set; }
	protected int MWidgetsMatchCount { get; set; }
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	public float TotalWeight { get; }
	// methods
	public virtual void Define ();
}
```

#### New Type: AndroidX.ConstraintLayout.Solver.Widgets.ConstraintWidgetGroup

```csharp
public class ConstraintWidgetGroup : Java.Lang.Object {
	// constructors
	protected ConstraintWidgetGroup (IntPtr, Android.Runtime.JniHandleOwnership);
	// properties
	public System.Collections.IList MConstrainedGroup { get; set; }
	public System.Collections.Generic.IList<int> MGroupDimensions { get; set; }
	public bool MSkipSolver { get; set; }
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public virtual System.Collections.Generic.IList<ConstraintWidget> GetStartWidgets (int);
}
```


### Namespace Google.Android.Material.Animation

#### Type Changed: Google.Android.Material.Animation.ChildrenAlphaProperty

Added methods:

```csharp
public virtual Java.Lang.Float Get (Android.Views.ViewGroup);
public override void Set (Java.Lang.Object, Java.Lang.Object);
```


#### Type Changed: Google.Android.Material.Animation.DrawableAlphaProperty

Added methods:

```csharp
public virtual Java.Lang.Integer Get (Android.Graphics.Drawables.Drawable);
public override void Set (Java.Lang.Object, Java.Lang.Object);
```


#### Type Changed: Google.Android.Material.Animation.ImageMatrixProperty

Added methods:

```csharp
public virtual Android.Graphics.Matrix Get (Android.Widget.ImageView);
public override void Set (Java.Lang.Object, Java.Lang.Object);
```



### Namespace Google.Android.Material.Chip

#### Type Changed: Google.Android.Material.Chip.Chip

Added interface:

```csharp
AndroidX.Core.View.ITintableBackgroundView
```



### Namespace Google.Android.Material.CircularReveal

#### Type Changed: Google.Android.Material.CircularReveal.CircularRevealFrameLayout

Removed interface:

```csharp
CircularRevealHelper.IDelegate
```


#### Type Changed: Google.Android.Material.CircularReveal.CircularRevealGridLayout

Removed interface:

```csharp
CircularRevealHelper.IDelegate
```


#### Type Changed: Google.Android.Material.CircularReveal.CircularRevealLinearLayout

Removed interface:

```csharp
CircularRevealHelper.IDelegate
```


#### Type Changed: Google.Android.Material.CircularReveal.CircularRevealRelativeLayout

Removed interface:

```csharp
CircularRevealHelper.IDelegate
```


#### Type Changed: Google.Android.Material.CircularReveal.ICircularRevealWidget

Removed interface:

```csharp
CircularRevealHelper.IDelegate
```

Added methods:

```csharp
public virtual void ActualDraw (Android.Graphics.Canvas);
public virtual bool ActualIsOpaque ();
```


#### New Type: Google.Android.Material.CircularReveal.CircularRevealWidgetCircularRevealProperty

```csharp
public class CircularRevealWidgetCircularRevealProperty : Android.Util.Property {
	// constructors
	protected CircularRevealWidgetCircularRevealProperty (IntPtr, Android.Runtime.JniHandleOwnership);
	// properties
	public static Android.Util.Property CircularReveal { get; }
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public virtual CircularRevealWidgetRevealInfo Get (ICircularRevealWidget);
	public override Java.Lang.Object Get (Java.Lang.Object);
	public virtual void Set (ICircularRevealWidget, CircularRevealWidgetRevealInfo);
	public override void Set (Java.Lang.Object, Java.Lang.Object);
}
```

#### New Type: Google.Android.Material.CircularReveal.CircularRevealWidgetCircularRevealScrimColorProperty

```csharp
public class CircularRevealWidgetCircularRevealScrimColorProperty : Android.Util.Property {
	// constructors
	protected CircularRevealWidgetCircularRevealScrimColorProperty (IntPtr, Android.Runtime.JniHandleOwnership);
	// properties
	public static Android.Util.Property CircularRevealScrimColor { get; }
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public virtual Java.Lang.Integer Get (ICircularRevealWidget);
	public override Java.Lang.Object Get (Java.Lang.Object);
	public virtual void Set (ICircularRevealWidget, Java.Lang.Integer);
	public override void Set (Java.Lang.Object, Java.Lang.Object);
}
```


### Namespace Google.Android.Material.CircularReveal.CardView

#### Type Changed: Google.Android.Material.CircularReveal.CardView.CircularRevealCardView

Removed interface:

```csharp
Google.Android.Material.CircularReveal.CircularRevealHelper.IDelegate
```



### Namespace Google.Android.Material.CircularReveal.CoordinatorLayout

#### Type Changed: Google.Android.Material.CircularReveal.CoordinatorLayout.CircularRevealCoordinatorLayout

Removed interface:

```csharp
Google.Android.Material.CircularReveal.CircularRevealHelper.IDelegate
```

Added interface:

```csharp
AndroidX.Core.View.INestedScrollingParent3
```



### Namespace Google.Android.Material.Internal

#### Type Changed: Google.Android.Material.Internal.NavigationMenuView

Added interface:

```csharp
AndroidX.Core.View.INestedScrollingChild3
```


#### New Type: Google.Android.Material.Internal.NavigationMenuPresenter

```csharp
public class NavigationMenuPresenter : Java.Lang.Object, Android.Runtime.IJavaObject, AndroidX.AppCompat.View.Menu.IMenuPresenter, System.IDisposable {
	// constructors
	public NavigationMenuPresenter ();
	protected NavigationMenuPresenter (IntPtr, Android.Runtime.JniHandleOwnership);
	// properties
	public AndroidX.AppCompat.View.Menu.MenuItemImpl CheckedItem { get; set; }
	public int HeaderCount { get; }
	public int Id { get; set; }
	public Android.Graphics.Drawables.Drawable ItemBackground { get; set; }
	public int ItemHorizontalPadding { get; set; }
	public int ItemIconPadding { get; set; }
	public Android.Content.Res.ColorStateList ItemTextColor { get; set; }
	public Android.Content.Res.ColorStateList ItemTintList { get; }
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public virtual void AddHeaderView (Android.Views.View);
	public virtual bool CollapseItemActionView (AndroidX.AppCompat.View.Menu.MenuBuilder, AndroidX.AppCompat.View.Menu.MenuItemImpl);
	public virtual void DispatchApplyWindowInsets (AndroidX.Core.View.WindowInsetsCompat);
	public virtual bool ExpandItemActionView (AndroidX.AppCompat.View.Menu.MenuBuilder, AndroidX.AppCompat.View.Menu.MenuItemImpl);
	public virtual bool FlagActionItems ();
	public virtual Android.Views.View GetHeaderView (int);
	public virtual AndroidX.AppCompat.View.Menu.IMenuView GetMenuView (Android.Views.ViewGroup);
	public virtual Android.Views.View InflateHeaderView (int);
	public virtual void InitForMenu (Android.Content.Context, AndroidX.AppCompat.View.Menu.MenuBuilder);
	public virtual void OnCloseMenu (AndroidX.AppCompat.View.Menu.MenuBuilder, bool);
	public virtual void OnRestoreInstanceState (Android.OS.IParcelable);
	public virtual Android.OS.IParcelable OnSaveInstanceState ();
	public virtual bool OnSubMenuSelected (AndroidX.AppCompat.View.Menu.SubMenuBuilder);
	public virtual void RemoveHeaderView (Android.Views.View);
	public virtual void SetCallback (AndroidX.AppCompat.View.Menu.IMenuPresenterCallback);
	public virtual void SetItemIconTintList (Android.Content.Res.ColorStateList);
	public virtual void SetItemTextAppearance (int);
	public virtual void SetUpdateSuspended (bool);
	public virtual void UpdateMenuView (bool);
}
```


### Namespace Google.Android.Material.Snackbar

#### Type Changed: Google.Android.Material.Snackbar.BaseTransientBottomBar

#### Type Changed: Google.Android.Material.Snackbar.BaseTransientBottomBar.Behavior

Added method:

```csharp
public override bool OnInterceptTouchEvent (AndroidX.CoordinatorLayout.Widget.CoordinatorLayout, Java.Lang.Object, Android.Views.MotionEvent);
```




### Namespace Google.Android.Material.Transformation

#### Type Changed: Google.Android.Material.Transformation.TransformationChildCard

Removed interface:

```csharp
Google.Android.Material.CircularReveal.CircularRevealHelper.IDelegate
```


#### Type Changed: Google.Android.Material.Transformation.TransformationChildLayout

Removed interface:

```csharp
Google.Android.Material.CircularReveal.CircularRevealHelper.IDelegate
```



### Namespace Google.Android.Material.AppBar

#### Type Changed: Google.Android.Material.AppBar.HeaderScrollingViewBehavior

Removed method:

```csharp
public virtual bool OnMeasureChild (AndroidX.CoordinatorLayout.Widget.CoordinatorLayout, Android.Views.View, int, int, int, int);
```

Added method:

```csharp
protected override void LayoutChild (AndroidX.CoordinatorLayout.Widget.CoordinatorLayout, Java.Lang.Object, int);
```


#### Type Changed: Google.Android.Material.AppBar.ViewOffsetBehavior

Added method:

```csharp
public virtual bool OnMeasureChild (AndroidX.CoordinatorLayout.Widget.CoordinatorLayout, Android.Views.View, int, int, int, int);
```



### Namespace Google.Android.Material.BottomSheet

#### Type Changed: Google.Android.Material.BottomSheet.BottomSheetDialogFragment

Added interface:

```csharp
AndroidX.SavedState.ISavedStateRegistryOwner
```



### Namespace AndroidX.CoordinatorLayout.Widget

#### Type Changed: AndroidX.CoordinatorLayout.Widget.CoordinatorLayout

Added interface:

```csharp
AndroidX.Core.View.INestedScrollingParent3
```

Added method:

```csharp
public virtual void OnNestedScroll (Android.Views.View, int, int, int, int, int, int[]);
```

#### Type Changed: AndroidX.CoordinatorLayout.Widget.CoordinatorLayout.Behavior

Obsoleted methods:

```diff
 [Obsolete ("deprecated")]
 public virtual void OnNestedScroll (CoordinatorLayout, Java.Lang.Object, Android.Views.View, int, int, int, int, int);
```

Added method:

```csharp
public virtual void OnNestedScroll (CoordinatorLayout, Java.Lang.Object, Android.Views.View, int, int, int, int, int, int[]);
```




### Namespace AndroidX.VectorDrawable.Graphics.Drawable

#### Type Changed: AndroidX.VectorDrawable.Graphics.Drawable.VectorDrawableCompat

Removed property:

```csharp
public Android.Graphics.ColorFilter ColorFilter { get; }
```



### Namespace AndroidX.ExifInterface.Media

#### Type Changed: AndroidX.ExifInterface.Media.ExifInterface

Added constructors:

```csharp
public ExifInterface (Java.IO.File);
public ExifInterface (Java.IO.FileDescriptor);
```

Obsoleted fields:

```diff
 [Obsolete ("deprecated")]
 public static const string TagCamaraOwnerName = "CameraOwnerName";
```

Added fields:

```csharp
public static const string TagCameraOwnerName = "CameraOwnerName";
public static const string TagThumbnailOrientation = "ThumbnailOrientation";
public static const string TagXmp = "Xmp";
```

Added properties:

```csharp
public long DateTimeDigitized { get; }
public long DateTimeOriginal { get; }
```

Added methods:

```csharp
public virtual byte[] GetAttributeBytes (string);
public virtual long[] GetAttributeRange (string);
public virtual bool HasAttribute (string);
```



### Namespace AndroidX.Emoji.Widget

#### Type Changed: AndroidX.Emoji.Widget.EmojiAppCompatTextView

Added interface:

```csharp
AndroidX.Core.Widget.ITintableCompoundDrawablesView
```



### Namespace AndroidX.Transitions

#### Type Changed: AndroidX.Transitions.Scene

Added method:

```csharp
public static Scene GetCurrentScene (Android.Views.ViewGroup);
```


#### Type Changed: AndroidX.Transitions.TransitionValues

Obsoleted constructors:

```diff
 [Obsolete ("deprecated")]
 public TransitionValues ();
```

Added constructor:

```csharp
public TransitionValues (Android.Views.View);
```



### Namespace AndroidX.Core.View

#### Type Changed: AndroidX.Core.View.AccessibilityDelegateCompat

Added constructor:

```csharp
public AccessibilityDelegateCompat (Android.Views.View.AccessibilityDelegate);
```


#### Type Changed: AndroidX.Core.View.GestureDetectorCompat

#### Type Changed: AndroidX.Core.View.GestureDetectorCompat.GestureDetectorCompatImplBase

Removed interfaces:

```csharp
Android.Runtime.IJavaObject
GestureDetectorCompat.IGestureDetectorCompatImpl
System.IDisposable
```



#### Type Changed: AndroidX.Core.View.NestedScrollingChildHelper

Added method:

```csharp
public virtual void DispatchNestedScroll (int, int, int, int, int[], int, int[]);
```


#### Type Changed: AndroidX.Core.View.ViewCompat

Added methods:

```csharp
public static int AddAccessibilityAction (Android.Views.View, Java.Lang.ICharSequence, Accessibiity.IAccessibilityViewCommand);
public static int AddAccessibilityAction (Android.Views.View, string, Accessibiity.IAccessibilityViewCommand);
public static void DispatchNestedScroll (Android.Views.View, int, int, int, int, int[], int, int[]);
public static void EnableAccessibleClickableSpanSupport (Android.Views.View);
public static AccessibilityDelegateCompat GetAccessibilityDelegate (Android.Views.View);
public static string GetAccessibilityPaneTitle (Android.Views.View);
public static Java.Lang.ICharSequence GetAccessibilityPaneTitleFormatted (Android.Views.View);
public static bool IsAccessibilityHeading (Android.Views.View);
public static bool IsScreenReaderFocusable (Android.Views.View);
public static void RemoveAccessibilityAction (Android.Views.View, int);
public static void ReplaceAccessibilityAction (Android.Views.View, Accessibiity.AccessibilityNodeInfoCompat.AccessibilityActionCompat, Java.Lang.ICharSequence, Accessibiity.IAccessibilityViewCommand);
public static void ReplaceAccessibilityAction (Android.Views.View, Accessibiity.AccessibilityNodeInfoCompat.AccessibilityActionCompat, string, Accessibiity.IAccessibilityViewCommand);
public static void SetAccessibilityHeading (Android.Views.View, bool);
public static void SetAccessibilityPaneTitle (Android.Views.View, Java.Lang.ICharSequence);
public static void SetAccessibilityPaneTitle (Android.Views.View, string);
public static void SetScreenReaderFocusable (Android.Views.View, bool);
```

#### New Type: AndroidX.Core.View.ViewCompat.AccessibilityPaneVisibilityManager

```csharp
public class AccessibilityPaneVisibilityManager : Java.Lang.Object, Android.Runtime.IJavaObject, Android.Views.View.IOnAttachStateChangeListener, Android.Views.ViewTreeObserver.IOnGlobalLayoutListener, System.IDisposable {
	// constructors
	protected ViewCompat.AccessibilityPaneVisibilityManager (IntPtr, Android.Runtime.JniHandleOwnership);
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public virtual void OnGlobalLayout ();
	public virtual void OnViewAttachedToWindow (Android.Views.View);
	public virtual void OnViewDetachedFromWindow (Android.Views.View);
}
```

#### New Type: AndroidX.Core.View.ViewCompat.AccessibilityViewProperty

```csharp
public abstract class AccessibilityViewProperty : Java.Lang.Object {
	// constructors
	protected ViewCompat.AccessibilityViewProperty (IntPtr, Android.Runtime.JniHandleOwnership);
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
}
```


#### Type Changed: AndroidX.Core.View.ViewParentCompat

Added method:

```csharp
public static void OnNestedScroll (Android.Views.IViewParent, Android.Views.View, int, int, int, int, int, int[]);
```


#### New Type: AndroidX.Core.View.INestedScrollingChild3

```csharp
public interface INestedScrollingChild3 : Android.Runtime.IJavaObject, INestedScrollingChild, INestedScrollingChild2, System.IDisposable {
	// methods
	public virtual void DispatchNestedScroll (int, int, int, int, int[], int, int[]);
}
```

#### New Type: AndroidX.Core.View.INestedScrollingParent3

```csharp
public interface INestedScrollingParent3 : Android.Runtime.IJavaObject, INestedScrollingParent, INestedScrollingParent2, System.IDisposable {
	// methods
	public virtual void OnNestedScroll (Android.Views.View, int, int, int, int, int, int[]);
}
```

#### New Type: AndroidX.Core.View.OneShotPreDrawListener

```csharp
public sealed class OneShotPreDrawListener : Java.Lang.Object, Android.Runtime.IJavaObject, Android.Views.View.IOnAttachStateChangeListener, Android.Views.ViewTreeObserver.IOnPreDrawListener, System.IDisposable {
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public static OneShotPreDrawListener Add (Android.Views.View, Java.Lang.IRunnable);
	public virtual bool OnPreDraw ();
	public virtual void OnViewAttachedToWindow (Android.Views.View);
	public virtual void OnViewDetachedFromWindow (Android.Views.View);
	public void RemoveListener ();
}
```


### Namespace AndroidX.Preference

#### Type Changed: AndroidX.Preference.EditTextPreferenceDialogFragment

Obsoleted constructors:

```diff
 [Obsolete ("deprecated")]
 public EditTextPreferenceDialogFragment ();
```

Obsoleted methods:

```diff
 [Obsolete ("deprecated")]
 public static EditTextPreferenceDialogFragment NewInstance (string);
 [Obsolete ("deprecated")]
 public override void OnDialogClosed (bool);
```


#### Type Changed: AndroidX.Preference.ListPreferenceDialogFragment

Obsoleted constructors:

```diff
 [Obsolete ("deprecated")]
 public ListPreferenceDialogFragment ();
```

Obsoleted methods:

```diff
 [Obsolete ("deprecated")]
 public static ListPreferenceDialogFragment NewInstance (string);
 [Obsolete ("deprecated")]
 public override void OnDialogClosed (bool);
```


#### Type Changed: AndroidX.Preference.MultiSelectListPreference

Modified base type:

```diff
-Android.Support.V7.Preference.Internal.AbstractMultiSelectListPreference
+AndroidX.Preference.DialogPreference
```


#### Type Changed: AndroidX.Preference.MultiSelectListPreferenceDialogFragment

Obsoleted constructors:

```diff
 [Obsolete ("deprecated")]
 public MultiSelectListPreferenceDialogFragment ();
```

Obsoleted methods:

```diff
 [Obsolete ("deprecated")]
 public static MultiSelectListPreferenceDialogFragment NewInstance (string);
 [Obsolete ("deprecated")]
 public override void OnDialogClosed (bool);
```


#### Type Changed: AndroidX.Preference.PreferenceDialogFragment

Obsoleted constructors:

```diff
 [Obsolete ("deprecated")]
 public PreferenceDialogFragment ();
```

Obsoleted fields:

```diff
 [Obsolete ("deprecated")]
 protected static const string ArgKey = "key";
```

Obsoleted properties:

```diff
 [Obsolete ("deprecated")]
 public DialogPreference Preference { get; }
```

Obsoleted methods:

```diff
 [Obsolete ("deprecated")]
 protected virtual void OnBindDialogView (Android.Views.View);
 [Obsolete ("deprecated")]
 public virtual void OnClick (Android.Content.IDialogInterface, int);
 [Obsolete ("deprecated")]
 protected virtual Android.Views.View OnCreateDialogView (Android.Content.Context);
 [Obsolete ("deprecated")]
 protected virtual void OnPrepareDialogBuilder (Android.App.AlertDialog.Builder);
```


#### Type Changed: AndroidX.Preference.PreferenceFragment

Obsoleted fields:

```diff
 [Obsolete ("deprecated")]
 public static const string ArgPreferenceRoot = "androidx.preference.PreferenceFragmentCompat.PREFERENCE_ROOT";
```

Modified fields:

```diff
-public const string ArgPreferenceRoot = "android.support.v7.preference.PreferenceFragmentCompat.PREFERENCE_ROOT";
+public const string ArgPreferenceRoot = "androidx.preference.PreferenceFragmentCompat.PREFERENCE_ROOT";
```

Obsoleted properties:

```diff
 [Obsolete ("deprecated")]
 public AndroidX.RecyclerView.Widget.RecyclerView ListView { get; }
 [Obsolete ("deprecated")]
 public PreferenceManager PreferenceManager { get; }
 [Obsolete ("deprecated")]
 public PreferenceScreen PreferenceScreen { get; set; }
```

Removed methods:

```csharp
public virtual Preference FindPreference (Java.Lang.ICharSequence);
public Preference FindPreference (string);
```

Obsoleted methods:

```diff
 [Obsolete ("deprecated")]
 public virtual void AddPreferencesFromResource (int);
 [Obsolete ("deprecated")]
 protected virtual AndroidX.RecyclerView.Widget.RecyclerView.Adapter OnCreateAdapter (PreferenceScreen);
 [Obsolete ("deprecated")]
 public virtual AndroidX.RecyclerView.Widget.RecyclerView.LayoutManager OnCreateLayoutManager ();
 [Obsolete ("deprecated")]
 public virtual AndroidX.RecyclerView.Widget.RecyclerView OnCreateRecyclerView (Android.Views.LayoutInflater, Android.Views.ViewGroup, Android.OS.Bundle);
 [Obsolete ("deprecated")]
 public virtual void OnDisplayPreferenceDialog (Preference);
 [Obsolete ("deprecated")]
 public virtual void OnNavigateToScreen (PreferenceScreen);
 [Obsolete ("deprecated")]
 public virtual bool OnPreferenceTreeClick (Preference);
 [Obsolete ("deprecated")]
 public virtual void ScrollToPreference (Preference);
 [Obsolete ("deprecated")]
 public virtual void ScrollToPreference (string);
 [Obsolete ("deprecated")]
 public virtual void SetDivider (Android.Graphics.Drawables.Drawable);
 [Obsolete ("deprecated")]
 public virtual void SetDividerHeight (int);
 [Obsolete ("deprecated")]
 public virtual void SetPreferencesFromResource (int, string);
```

Added methods:

```csharp

[Obsolete ("deprecated")]
public virtual Java.Lang.Object FindPreference (Java.Lang.ICharSequence);

[Obsolete ("deprecated")]
public Java.Lang.Object FindPreference (string);
```


#### Type Changed: AndroidX.Preference.AndroidResources

Removed fields:

```csharp
public static const int AndroidREdittextPreferenceStyle;
public static const int AndroidRListContainer;
public static const int AndroidRPreferenceFragmentStyle;
public static const int AndroidRSwitchWidget;
```


#### Type Changed: AndroidX.Preference.DialogPreference

#### Type Changed: AndroidX.Preference.DialogPreference.ITargetFragment

Removed method:

```csharp
public virtual Preference FindPreference (Java.Lang.ICharSequence);
```

Added method:

```csharp
public virtual Java.Lang.Object FindPreference (Java.Lang.ICharSequence);
```



#### Type Changed: AndroidX.Preference.DialogPreferenceITargetFragmentExtensions

Removed method:

```csharp
public static Preference FindPreference (this DialogPreference.ITargetFragment, string);
```

Added method:

```csharp
public static Java.Lang.Object FindPreference (this DialogPreference.ITargetFragment, string);
```


#### Type Changed: AndroidX.Preference.DropDownPreference

Removed method:

```csharp
public virtual int FindSpinnerIndexOfValue (string);
```


#### Type Changed: AndroidX.Preference.EditTextPreference

Added event:

```csharp
public event System.EventHandler<EditTextPreference.BindEditTextEventArgs> BindEditText;
```

Added method:

```csharp
public virtual void SetOnBindEditTextListener (EditTextPreference.IOnBindEditTextListener);
```


#### Type Changed: AndroidX.Preference.EditTextPreferenceDialogFragmentCompat

Added interface:

```csharp
AndroidX.SavedState.ISavedStateRegistryOwner
```


#### Type Changed: AndroidX.Preference.ListPreferenceDialogFragmentCompat

Added interface:

```csharp
AndroidX.SavedState.ISavedStateRegistryOwner
```


#### Type Changed: AndroidX.Preference.MultiSelectListPreferenceDialogFragmentCompat

Added interface:

```csharp
AndroidX.SavedState.ISavedStateRegistryOwner
```


#### Type Changed: AndroidX.Preference.Preference

Removed property:

```csharp
public Android.Content.ISharedPreferences SharedPreferences { get; }
```

Added property:

```csharp
public bool CopyingEnabled { get; set; }
```

Removed methods:

```csharp
public void ClearWasDetached ();
protected virtual Preference FindPreferenceInHierarchy (string);
public bool WasDetached ();
```

Obsoleted methods:

```diff
 [Obsolete ("deprecated")]
 public virtual void OnInitializeAccessibilityNodeInfo (AndroidX.Core.View.Accessibiity.AccessibilityNodeInfoCompat);
```

Added method:

```csharp
protected virtual Java.Lang.Object FindPreferenceInHierarchy (string);
```


#### Type Changed: AndroidX.Preference.PreferenceDialogFragmentCompat

Added interface:

```csharp
AndroidX.SavedState.ISavedStateRegistryOwner
```


#### Type Changed: AndroidX.Preference.PreferenceFragmentCompat

Added interface:

```csharp
AndroidX.SavedState.ISavedStateRegistryOwner
```

Modified fields:

```diff
-public const string ArgPreferenceRoot = "android.support.v7.preference.PreferenceFragmentCompat.PREFERENCE_ROOT";
+public const string ArgPreferenceRoot = "androidx.preference.PreferenceFragmentCompat.PREFERENCE_ROOT";
```

Removed methods:

```csharp
public virtual Preference FindPreference (Java.Lang.ICharSequence);
public Preference FindPreference (string);
```

Added methods:

```csharp
public virtual Java.Lang.Object FindPreference (Java.Lang.ICharSequence);
public Java.Lang.Object FindPreference (string);
```


#### Type Changed: AndroidX.Preference.PreferenceGroup

Removed methods:

```csharp
public virtual Preference FindPreference (Java.Lang.ICharSequence);
public Preference FindPreference (string);
```

Added methods:

```csharp
public virtual Java.Lang.Object FindPreference (Java.Lang.ICharSequence);
public Java.Lang.Object FindPreference (string);
public virtual bool RemovePreferenceRecursively (Java.Lang.ICharSequence);
public bool RemovePreferenceRecursively (string);
```


#### Type Changed: AndroidX.Preference.PreferenceManager

Removed property:

```csharp
public Android.Content.ISharedPreferences SharedPreferences { get; }
```

Removed methods:

```csharp
public virtual Preference FindPreference (Java.Lang.ICharSequence);
public Preference FindPreference (string);
public static Android.Content.ISharedPreferences GetDefaultSharedPreferences (Android.Content.Context);
```

Added methods:

```csharp
public virtual Java.Lang.Object FindPreference (Java.Lang.ICharSequence);
public Java.Lang.Object FindPreference (string);
```


#### Type Changed: AndroidX.Preference.SeekBarPreference

Added properties:

```csharp
public bool ShowSeekBarValue { get; set; }
public bool UpdatesContinuously { get; set; }
```


#### Type Changed: AndroidX.Preference.TwoStatePreference

#### Type Changed: AndroidX.Preference.TwoStatePreference.SavedState

Removed constructors:

```csharp
public TwoStatePreference.SavedState (Android.OS.IParcelable);
public TwoStatePreference.SavedState (Android.OS.Parcel);
```




### Namespace AndroidX.Leanback.App

#### Type Changed: AndroidX.Leanback.App.BaseRowSupportFragment

Added interface:

```csharp
AndroidX.SavedState.ISavedStateRegistryOwner
```


#### Type Changed: AndroidX.Leanback.App.BaseSupportFragment

Added interface:

```csharp
AndroidX.SavedState.ISavedStateRegistryOwner
```


#### Type Changed: AndroidX.Leanback.App.BrandedSupportFragment

Added interface:

```csharp
AndroidX.SavedState.ISavedStateRegistryOwner
```


#### Type Changed: AndroidX.Leanback.App.BrowseSupportFragment

Added interface:

```csharp
AndroidX.SavedState.ISavedStateRegistryOwner
```


#### Type Changed: AndroidX.Leanback.App.DetailsSupportFragment

Added interface:

```csharp
AndroidX.SavedState.ISavedStateRegistryOwner
```


#### Type Changed: AndroidX.Leanback.App.ErrorSupportFragment

Added interface:

```csharp
AndroidX.SavedState.ISavedStateRegistryOwner
```


#### Type Changed: AndroidX.Leanback.App.GuidedStepSupportFragment

Added interface:

```csharp
AndroidX.SavedState.ISavedStateRegistryOwner
```

#### Type Changed: AndroidX.Leanback.App.GuidedStepSupportFragment.DummyFragment

Added interface:

```csharp
AndroidX.SavedState.ISavedStateRegistryOwner
```



#### Type Changed: AndroidX.Leanback.App.HeadersSupportFragment

Added interface:

```csharp
AndroidX.SavedState.ISavedStateRegistryOwner
```


#### Type Changed: AndroidX.Leanback.App.OnboardingSupportFragment

Added interface:

```csharp
AndroidX.SavedState.ISavedStateRegistryOwner
```


#### Type Changed: AndroidX.Leanback.App.PlaybackSupportFragment

Added interface:

```csharp
AndroidX.SavedState.ISavedStateRegistryOwner
```


#### Type Changed: AndroidX.Leanback.App.RowsSupportFragment

Added interface:

```csharp
AndroidX.SavedState.ISavedStateRegistryOwner
```


#### Type Changed: AndroidX.Leanback.App.SearchSupportFragment

Added interface:

```csharp
AndroidX.SavedState.ISavedStateRegistryOwner
```


#### Type Changed: AndroidX.Leanback.App.VerticalGridSupportFragment

Added interface:

```csharp
AndroidX.SavedState.ISavedStateRegistryOwner
```


#### Type Changed: AndroidX.Leanback.App.VideoSupportFragment

Added interface:

```csharp
AndroidX.SavedState.ISavedStateRegistryOwner
```



### Namespace AndroidX.Leanback.Widget

#### Type Changed: AndroidX.Leanback.Widget.BaseGridView

Added interface:

```csharp
AndroidX.Core.View.INestedScrollingChild3
```


#### Type Changed: AndroidX.Leanback.Widget.GuidedActionDiffCallback

Added methods:

```csharp
public void OnBindViewHolder (Java.Lang.Object, int);
public virtual Java.Lang.Object OnCreateViewHolder (Android.Views.ViewGroup, int);
```


#### Type Changed: AndroidX.Leanback.Widget.HorizontalGridView

Added interface:

```csharp
AndroidX.Core.View.INestedScrollingChild3
```


#### Type Changed: AndroidX.Leanback.Widget.VerticalGridView

Added interface:

```csharp
AndroidX.Core.View.INestedScrollingChild3
```



### Namespace AndroidX.Core.App

#### Type Changed: AndroidX.Core.App.ActivityCompat

Added method:

```csharp
public static void Recreate (Android.App.Activity);
```


#### Type Changed: AndroidX.Core.App.JobIntentService

#### Type Changed: AndroidX.Core.App.JobIntentService.CompatWorkItem

Removed interfaces:

```csharp
Android.Runtime.IJavaObject
JobIntentService.IGenericWorkItem
System.IDisposable
```


#### Type Changed: AndroidX.Core.App.JobIntentService.JobServiceEngineImpl.JobServiceEngineImpl

Removed interfaces:

```csharp
Android.Runtime.IJavaObject
JobIntentService.ICompatJobEngine
System.IDisposable
```

#### Type Changed: AndroidX.Core.App.JobIntentService.JobServiceEngineImpl.WrapperWorkItem

Removed interfaces:

```csharp
Android.Runtime.IJavaObject
JobIntentService.IGenericWorkItem
System.IDisposable
```




#### Type Changed: AndroidX.Core.App.NotificationCompat

Added field:

```csharp
public static const string CategoryNavigation = "navigation";
```

#### Type Changed: AndroidX.Core.App.NotificationCompat.WearableExtender

Obsoleted fields:

```diff
 [Obsolete ("deprecated")]
 public static const int ScreenTimeoutLong;
 [Obsolete ("deprecated")]
 public static const int ScreenTimeoutShort;
 [Obsolete ("deprecated")]
 public static const int SizeDefault;
 [Obsolete ("deprecated")]
 public static const int SizeFullScreen;
 [Obsolete ("deprecated")]
 public static const int SizeLarge;
 [Obsolete ("deprecated")]
 public static const int SizeMedium;
 [Obsolete ("deprecated")]
 public static const int SizeSmall;
 [Obsolete ("deprecated")]
 public static const int SizeXsmall;
```

Obsoleted properties:

```diff
 [Obsolete ("deprecated")]
 public Android.Graphics.Bitmap Background { get; }
 [Obsolete ("deprecated")]
 public Android.App.PendingIntent DisplayIntent { get; }
 [Obsolete ("deprecated")]
 public bool HintAmbientBigPicture { get; }
 [Obsolete ("deprecated")]
 public System.Collections.Generic.IList<Android.App.Notification> Pages { get; }
```

Obsoleted methods:

```diff
 [Obsolete ("deprecated")]
 public NotificationCompat.WearableExtender AddPage (Android.App.Notification);
 [Obsolete ("deprecated")]
 public NotificationCompat.WearableExtender AddPages (System.Collections.Generic.IList<Android.App.Notification>);
 [Obsolete ("deprecated")]
 public NotificationCompat.WearableExtender ClearPages ();
 [Obsolete ("deprecated")]
 public NotificationCompat.WearableExtender SetBackground (Android.Graphics.Bitmap);
 [Obsolete ("deprecated")]
 public NotificationCompat.WearableExtender SetDisplayIntent (Android.App.PendingIntent);
 [Obsolete ("deprecated")]
 public NotificationCompat.WearableExtender SetHintAmbientBigPicture (bool);
```



#### Type Changed: AndroidX.Core.App.NotificationManagerCompat

Added properties:

```csharp
public System.Collections.Generic.IList<Android.App.NotificationChannelGroup> NotificationChannelGroups { get; }
public System.Collections.Generic.IList<Android.App.NotificationChannel> NotificationChannels { get; }
```

Added methods:

```csharp
public void CreateNotificationChannel (Android.App.NotificationChannel);
public void CreateNotificationChannelGroup (Android.App.NotificationChannelGroup);
public void CreateNotificationChannelGroups (System.Collections.Generic.IList<Android.App.NotificationChannelGroup>);
public void CreateNotificationChannels (System.Collections.Generic.IList<Android.App.NotificationChannel>);
public void DeleteNotificationChannel (string);
public void DeleteNotificationChannelGroup (string);
public Android.App.NotificationChannel GetNotificationChannel (string);
public Android.App.NotificationChannelGroup GetNotificationChannelGroup (string);
```


#### Type Changed: AndroidX.Core.App.Person

Added methods:

```csharp
public static Person FromPersistableBundle (Android.OS.PersistableBundle);
public virtual Android.OS.PersistableBundle ToPersistableBundle ();
```


#### Type Changed: AndroidX.Core.App.RemoteInput

Added fields:

```csharp
public static const int SourceChoice;
public static const int SourceFreeFormInput;
```

Added methods:

```csharp
public static int GetResultsSource (Android.Content.Intent);
public static void SetResultsSource (Android.Content.Intent, int);
```

#### New Type: AndroidX.Core.App.RemoteInput.ISource

```csharp
public interface ISource : Android.Runtime.IJavaObject, Java.Lang.Annotation.IAnnotation, System.IDisposable {
}
```


#### Type Changed: AndroidX.Core.App.ShareCompat

Modified fields:

```diff
-public const string ExtraCallingActivity = "android.support.v4.app.EXTRA_CALLING_ACTIVITY";
+public const string ExtraCallingActivity = "androidx.core.app.EXTRA_CALLING_ACTIVITY";
-public const string ExtraCallingPackage = "android.support.v4.app.EXTRA_CALLING_PACKAGE";
+public const string ExtraCallingPackage = "androidx.core.app.EXTRA_CALLING_PACKAGE";
```

Added fields:

```csharp
public static const string ExtraCallingActivityInterop = "android.support.v4.app.EXTRA_CALLING_ACTIVITY";
public static const string ExtraCallingPackageInterop = "android.support.v4.app.EXTRA_CALLING_PACKAGE";
```


#### Removed Type AndroidX.Core.App.SupportActivity
#### New Type: AndroidX.Core.App.ComponentActivity

```csharp
public class ComponentActivity : Android.App.Activity, Android.Runtime.IJavaObject, AndroidX.Core.View.KeyEventDispatcher.IComponent, AndroidX.Lifecycle.ILifecycleOwner, System.IDisposable {
	// constructors
	public ComponentActivity ();
	protected ComponentActivity (IntPtr, Android.Runtime.JniHandleOwnership);
	// properties
	public AndroidX.Lifecycle.Lifecycle Lifecycle { get; }
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public virtual Java.Lang.Object GetExtraData (Java.Lang.Class);
	public virtual void PutExtraData (ComponentActivity.ExtraData);
	public virtual bool SuperDispatchKeyEvent (Android.Views.KeyEvent);

	// inner types
	public class ExtraData : Java.Lang.Object {
		// constructors
		public ComponentActivity.ExtraData ();
		protected ComponentActivity.ExtraData (IntPtr, Android.Runtime.JniHandleOwnership);
		// properties
		protected IntPtr ThresholdClass { get; }
		protected System.Type ThresholdType { get; }
	}
}
```

#### New Type: AndroidX.Core.App.DialogCompat

```csharp
public class DialogCompat : Java.Lang.Object {
	// constructors
	protected DialogCompat (IntPtr, Android.Runtime.JniHandleOwnership);
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public static Android.Views.View RequireViewById (Android.App.Dialog, int);
}
```

#### New Type: AndroidX.Core.App.RemoteActionCompat

```csharp
public sealed class RemoteActionCompat : Java.Lang.Object, Android.Runtime.IJavaObject, AndroidX.VersionedParcelable.IVersionedParcelable, System.IDisposable {
	// constructors
	public RemoteActionCompat ();
	public RemoteActionCompat (RemoteActionCompat);
	public RemoteActionCompat (AndroidX.Core.Graphics.Drawable.IconCompat, Java.Lang.ICharSequence, Java.Lang.ICharSequence, Android.App.PendingIntent);
	public RemoteActionCompat (AndroidX.Core.Graphics.Drawable.IconCompat, string, string, Android.App.PendingIntent);
	// properties
	public Android.App.PendingIntent ActionIntent { get; }
	public string ContentDescription { get; }
	public Java.Lang.ICharSequence ContentDescriptionFormatted { get; }
	public bool Enabled { get; set; }
	public AndroidX.Core.Graphics.Drawable.IconCompat Icon { get; }
	public Android.App.PendingIntent MActionIntent { get; set; }
	public Java.Lang.ICharSequence MContentDescription { get; set; }
	public bool MEnabled { get; set; }
	public AndroidX.Core.Graphics.Drawable.IconCompat MIcon { get; set; }
	public bool MShouldShowIcon { get; set; }
	public Java.Lang.ICharSequence MTitle { get; set; }
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	public string Title { get; }
	public Java.Lang.ICharSequence TitleFormatted { get; }
	// methods
	public static RemoteActionCompat CreateFromRemoteAction (Android.App.RemoteAction);
	public void SetShouldShowIcon (bool);
	public bool ShouldShowIcon ();
	public Android.App.RemoteAction ToRemoteAction ();
}
```

#### New Type: AndroidX.Core.App.RemoteActionCompatParcelizer

```csharp
public class RemoteActionCompatParcelizer : Java.Lang.Object {
	// constructors
	public RemoteActionCompatParcelizer ();
	protected RemoteActionCompatParcelizer (IntPtr, Android.Runtime.JniHandleOwnership);
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public static RemoteActionCompat Read (AndroidX.VersionedParcelable.VersionedParcel);
	public static void Write (RemoteActionCompat, AndroidX.VersionedParcelable.VersionedParcel);
}
```


### Namespace AndroidX.Fragment.App

#### Type Changed: AndroidX.Fragment.App.DialogFragment

Added interface:

```csharp
AndroidX.SavedState.ISavedStateRegistryOwner
```

Added method:

```csharp
public Android.App.Dialog RequireDialog ();
```


#### Type Changed: AndroidX.Fragment.App.Fragment

Added constructor:

```csharp
public Fragment (int);
```

Added interface:

```csharp
AndroidX.SavedState.ISavedStateRegistryOwner
```

Obsoleted properties:

```diff
 [Obsolete ("deprecated")]
 public bool UserVisibleHint { get; set; }
```

Added property:

```csharp
public AndroidX.SavedState.SavedStateRegistry SavedStateRegistry { get; }
```

Obsoleted methods:

```diff
 [Obsolete ("deprecated")]
 public static Fragment Instantiate (Android.Content.Context, string);
 [Obsolete ("deprecated")]
 public static Fragment Instantiate (Android.Content.Context, string, Android.OS.Bundle);
```

Added methods:

```csharp
public virtual void OnPrimaryNavigationFragmentChanged (bool);
public void PostponeEnterTransition (long, Java.Util.Concurrent.TimeUnit);
public Android.OS.Bundle RequireArguments ();
public Fragment RequireParentFragment ();
public Android.Views.View RequireView ();
```


#### Type Changed: AndroidX.Fragment.App.FragmentActivity

Modified base type:

```diff
-Android.App.Activity
+AndroidX.Activity.ComponentActivity
```

Added constructor:

```csharp
public FragmentActivity (int);
```

Added interfaces:

```csharp
AndroidX.Activity.IOnBackPressedDispatcherOwner
AndroidX.Core.View.KeyEventDispatcher.IComponent
AndroidX.SavedState.ISavedStateRegistryOwner
```

Removed properties:

```csharp
public Java.Lang.Object LastCustomNonConfigurationInstance { get; }
public AndroidX.Lifecycle.ViewModelStore ViewModelStore { get; }
```

Removed methods:

```csharp
public virtual Java.Lang.Object OnRetainCustomNonConfigurationInstance ();
public override Java.Lang.Object OnRetainNonConfigurationInstance ();
```

Obsoleted methods:

```diff
 [Obsolete ("deprecated")]
 protected virtual bool OnPrepareOptionsPanel (Android.Views.View, Android.Views.IMenu);
```

#### Type Changed: AndroidX.Fragment.App.FragmentActivity.HostCallbacks

Added interfaces:

```csharp
Android.Runtime.IJavaObject
AndroidX.Activity.IOnBackPressedDispatcherOwner
AndroidX.Lifecycle.ILifecycleOwner
AndroidX.Lifecycle.IViewModelStoreOwner
System.IDisposable
```

Added properties:

```csharp
public AndroidX.Lifecycle.Lifecycle Lifecycle { get; }
public AndroidX.Activity.OnBackPressedDispatcher OnBackPressedDispatcher { get; }
public AndroidX.Lifecycle.ViewModelStore ViewModelStore { get; }
```


#### Removed Type AndroidX.Fragment.App.FragmentActivity.NonConfigurationInstances

#### Type Changed: AndroidX.Fragment.App.FragmentContainer

Obsoleted methods:

```diff
 [Obsolete ("deprecated")]
 public virtual Fragment Instantiate (Android.Content.Context, string, Android.OS.Bundle);
```


#### Type Changed: AndroidX.Fragment.App.FragmentController

Obsoleted methods:

```diff
 [Obsolete ("deprecated")]
 public virtual void RestoreAllState (Android.OS.IParcelable, FragmentManagerNonConfig);
 [Obsolete ("deprecated")]
 public virtual FragmentManagerNonConfig RetainNestedNonConfig ();
```

Added method:

```csharp
public virtual void RestoreSaveState (Android.OS.IParcelable);
```


#### Type Changed: AndroidX.Fragment.App.FragmentManager

Added property:

```csharp
public FragmentFactory FragmentFactory { get; set; }
```


#### Type Changed: AndroidX.Fragment.App.FragmentPagerAdapter

Obsoleted constructors:

```diff
 [Obsolete ("deprecated")]
 public FragmentPagerAdapter (FragmentManager);
```

Added constructor:

```csharp
public FragmentPagerAdapter (FragmentManager, int);
```

Added fields:

```csharp
public static const int BehaviorResumeOnlyCurrentFragment;

[Obsolete ("deprecated")]
public static const int BehaviorSetUserVisibleHint;
```


#### Type Changed: AndroidX.Fragment.App.FragmentStatePagerAdapter

Obsoleted constructors:

```diff
 [Obsolete ("deprecated")]
 public FragmentStatePagerAdapter (FragmentManager);
```

Added constructor:

```csharp
public FragmentStatePagerAdapter (FragmentManager, int);
```

Added fields:

```csharp
public static const int BehaviorResumeOnlyCurrentFragment;

[Obsolete ("deprecated")]
public static const int BehaviorSetUserVisibleHint;
```


#### Type Changed: AndroidX.Fragment.App.FragmentTabHost

Obsoleted constructors:

```diff
 [Obsolete ("deprecated")]
 public FragmentTabHost (Android.Content.Context);
 [Obsolete ("deprecated")]
 public FragmentTabHost (Android.Content.Context, Android.Util.IAttributeSet);
```

Obsoleted methods:

```diff
 [Obsolete ("deprecated")]
 public virtual void AddTab (Android.Widget.TabHost.TabSpec, Java.Lang.Class, Android.OS.Bundle);
 [Obsolete ("deprecated")]
 public virtual void OnTabChanged (string);
 [Obsolete ("deprecated")]
 public virtual void Setup (Android.Content.Context, FragmentManager);
 [Obsolete ("deprecated")]
 public virtual void Setup (Android.Content.Context, FragmentManager, int);
```


#### Type Changed: AndroidX.Fragment.App.FragmentTransaction

Obsoleted methods:

```diff
 [Obsolete ("deprecated")]
 public virtual FragmentTransaction SetAllowOptimization (bool);
```

Added method:

```csharp
public virtual FragmentTransaction SetMaxLifecycle (Fragment, AndroidX.Lifecycle.Lifecycle.State);
```


#### Type Changed: AndroidX.Fragment.App.ListFragment

Added interface:

```csharp
AndroidX.SavedState.ISavedStateRegistryOwner
```

Added method:

```csharp
public Android.Widget.IListAdapter RequireListAdapter ();
```


#### New Type: AndroidX.Fragment.App.FragmentFactory

```csharp
public class FragmentFactory : Java.Lang.Object {
	// constructors
	public FragmentFactory ();
	protected FragmentFactory (IntPtr, Android.Runtime.JniHandleOwnership);
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public virtual Fragment Instantiate (Java.Lang.ClassLoader, string);
	public static Java.Lang.Class LoadFragmentClass (Java.Lang.ClassLoader, string);
}
```


### Namespace Android.Support.V4.App

#### New Type: Android.Support.V4.App.RemoteActionCompatParcelizer

```csharp
public sealed class RemoteActionCompatParcelizer : AndroidX.Core.App.RemoteActionCompatParcelizer {
	// constructors
	public RemoteActionCompatParcelizer ();
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public static AndroidX.Core.App.RemoteActionCompat Read (AndroidX.VersionedParcelable.VersionedParcel);
	public static void Write (AndroidX.Core.App.RemoteActionCompat, AndroidX.VersionedParcelable.VersionedParcel);
}
```


### Namespace AndroidX.Loader.Content

#### Type Changed: AndroidX.Loader.Content.AsyncTaskLoader

Added property:

```csharp
protected Java.Util.Concurrent.IExecutor Executor { get; }
```

Removed method:

```csharp
public virtual void WaitForLoader ();
```



### Namespace AndroidX.Core.Content

#### Type Changed: AndroidX.Core.Content.ContextCompat

Added method:

```csharp
public static Java.Util.Concurrent.IExecutor GetMainExecutor (Android.Content.Context);
```


#### Type Changed: AndroidX.Core.Content.FileProvider

#### Type Changed: AndroidX.Core.Content.FileProvider.SimplePathStrategy

Removed interfaces:

```csharp
Android.Runtime.IJavaObject
FileProvider.IPathStrategy
System.IDisposable
```



#### Type Changed: AndroidX.Core.Content.SharedPreferencesCompat

#### Type Changed: AndroidX.Core.Content.SharedPreferencesCompat.EditorCompat

Removed method:

```csharp
[Obsolete ("deprecated")]
public void Apply (Android.Content.ISharedPreferencesEditor);
```




### Namespace AndroidX.Core.Content.PM

#### Type Changed: AndroidX.Core.Content.PM.ShortcutInfoCompat

Added properties:

```csharp
public System.Collections.Generic.ICollection<string> Categories { get; }
public AndroidX.Core.Graphics.Drawable.IconCompat Icon { get; }
```

#### Type Changed: AndroidX.Core.Content.PM.ShortcutInfoCompat.Builder

Added constructors:

```csharp
public ShortcutInfoCompat.Builder (ShortcutInfoCompat);
public ShortcutInfoCompat.Builder (Android.Content.Context, Android.Content.PM.ShortcutInfo);
```

Added methods:

```csharp
public virtual ShortcutInfoCompat.Builder SetCategories (System.Collections.Generic.ICollection<string>);
public virtual ShortcutInfoCompat.Builder SetLongLived ();
public virtual ShortcutInfoCompat.Builder SetPerson (AndroidX.Core.App.Person);
public virtual ShortcutInfoCompat.Builder SetPersons (AndroidX.Core.App.Person[]);
```



#### Type Changed: AndroidX.Core.Content.PM.ShortcutManagerCompat

Added field:

```csharp
public static const string ExtraShortcutId = "android.intent.extra.shortcut.ID";
```

Added methods:

```csharp
public static bool AddDynamicShortcuts (Android.Content.Context, System.Collections.Generic.IList<ShortcutInfoCompat>);
public static System.Collections.Generic.IList<ShortcutInfoCompat> GetDynamicShortcuts (Android.Content.Context);
public static int GetMaxShortcutCountPerActivity (Android.Content.Context);
public static void RemoveAllDynamicShortcuts (Android.Content.Context);
public virtual void RemoveDynamicShortcuts (Android.Content.Context, System.Collections.Generic.IList<string>);
public static bool UpdateShortcuts (Android.Content.Context, System.Collections.Generic.IList<ShortcutInfoCompat>);
```


#### New Type: AndroidX.Core.Content.PM.ShortcutInfoCompatSaver

```csharp
public abstract class ShortcutInfoCompatSaver : Java.Lang.Object {
	// constructors
	public ShortcutInfoCompatSaver ();
	protected ShortcutInfoCompatSaver (IntPtr, Android.Runtime.JniHandleOwnership);
	// properties
	public System.Collections.Generic.IList<ShortcutInfoCompat> Shortcuts { get; }
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public virtual Java.Lang.Object AddShortcuts (System.Collections.Generic.IList<ShortcutInfoCompat>);
	public virtual Java.Lang.Object RemoveAllShortcuts ();
	public virtual Java.Lang.Object RemoveShortcuts (System.Collections.Generic.IList<string>);

	// inner types
	public class NoopImpl : AndroidX.Core.Content.PM.ShortcutInfoCompatSaver {
		// constructors
		public ShortcutInfoCompatSaver.NoopImpl ();
		protected ShortcutInfoCompatSaver.NoopImpl (IntPtr, Android.Runtime.JniHandleOwnership);
		// properties
		protected IntPtr ThresholdClass { get; }
		protected System.Type ThresholdType { get; }
		// methods
		public override Java.Lang.Object AddShortcuts (System.Collections.Generic.IList<ShortcutInfoCompat>);
		public override Java.Lang.Object RemoveAllShortcuts ();
		public override Java.Lang.Object RemoveShortcuts (System.Collections.Generic.IList<string>);
	}
}
```


### Namespace AndroidX.Core.Content.Resources

#### Type Changed: AndroidX.Core.Content.Resources.ColorStateListInflaterCompat

Added method:

```csharp
public static Android.Content.Res.ColorStateList Inflate (Android.Content.Res.Resources, int, Android.Content.Res.Resources.Theme);
```


#### Type Changed: AndroidX.Core.Content.Resources.ResourcesCompat

Added method:

```csharp
public static float GetFloat (Android.Content.Res.Resources, int);
```


#### Type Changed: AndroidX.Core.Content.Resources.TypedArrayUtils

Added method:

```csharp
public static Android.Content.Res.ColorStateList GetNamedColorStateList (Android.Content.Res.TypedArray, System.Xml.XmlReader, Android.Content.Res.Resources.Theme, string, int);
```



### Namespace AndroidX.Core.Graphics

#### Type Changed: AndroidX.Core.Graphics.PathParser

Added method:

```csharp
public static bool InterpolatePathDataNodes (PathParser.PathDataNode[], PathParser.PathDataNode[], PathParser.PathDataNode[], float);
```


#### Type Changed: AndroidX.Core.Graphics.TypefaceCompat

Added method:

```csharp
public static Android.Graphics.Typeface Create (Android.Content.Context, Android.Graphics.Typeface, int);
```



### Namespace AndroidX.Core.Graphics.Drawable

#### Type Changed: AndroidX.Core.Graphics.Drawable.IconCompat

Added property:

```csharp
public Android.Graphics.Bitmap Bitmap { get; }
```



### Namespace AndroidX.Core.Internal.View

#### Type Changed: AndroidX.Core.Internal.View.ISupportMenuItem

Added methods:

```csharp
public virtual bool RequiresActionButton ();
public virtual bool RequiresOverflow ();
```



### Namespace AndroidX.Media

#### Type Changed: AndroidX.Media.AudioAttributesCompat

Removed methods:

```csharp
public static AudioAttributesCompat FromBundle (Android.OS.Bundle);
public virtual Android.OS.Bundle ToBundle ();
```


#### Type Changed: AndroidX.Media.MediaBrowserProtocol

Added field:

```csharp
public static const string ExtraCallingPid = "extra_calling_pid";
```


#### Type Changed: AndroidX.Media.MediaBrowserServiceCompat

#### Type Changed: AndroidX.Media.MediaBrowserServiceCompat.MediaBrowserServiceImplBase

Removed interfaces:

```csharp
Android.Runtime.IJavaObject
MediaBrowserServiceCompat.IMediaBrowserServiceImpl
System.IDisposable
```


#### New Type: AndroidX.Media.MediaBrowserServiceCompat.ResultWrapper

```csharp
public class ResultWrapper : Java.Lang.Object {
	// constructors
	protected MediaBrowserServiceCompat.ResultWrapper (IntPtr, Android.Runtime.JniHandleOwnership);
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public virtual void Detach ();
	public virtual void SendResult (Java.Lang.Object);
}
```


#### Type Changed: AndroidX.Media.MediaSessionManager

#### Type Changed: AndroidX.Media.MediaSessionManager.RemoteUserInfo

Added fields:

```csharp
public static const int UnknownPid;
public static const int UnknownUid;
```



#### Type Changed: AndroidX.Media.AudioAttributesCompatParcelizer

Added constructor:

```csharp
protected AudioAttributesCompatParcelizer (IntPtr, Android.Runtime.JniHandleOwnership);
```


#### Type Changed: AndroidX.Media.AudioAttributesImplBaseParcelizer

Added constructor:

```csharp
protected AudioAttributesImplBaseParcelizer (IntPtr, Android.Runtime.JniHandleOwnership);
```

Removed method:

```csharp
public static Java.Lang.Object Read (AndroidX.VersionedParcelable.VersionedParcel);
```

Added methods:

```csharp
public static AudioAttributesImplBase Read (AndroidX.VersionedParcelable.VersionedParcel);
public static void Write (AudioAttributesImplBase, AndroidX.VersionedParcelable.VersionedParcel);
```


#### New Type: AndroidX.Media.AudioAttributesImplBase

```csharp
public class AudioAttributesImplBase : Java.Lang.Object {
	// constructors
	protected AudioAttributesImplBase (IntPtr, Android.Runtime.JniHandleOwnership);
	// properties
	public Java.Lang.Object AudioAttributes { get; }
	public int ContentType { get; }
	public int Flags { get; }
	public int LegacyStreamType { get; }
	public int MContentType { get; set; }
	public int MFlags { get; set; }
	public int MLegacyStream { get; set; }
	public int MUsage { get; set; }
	public int RawLegacyStreamType { get; }
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	public int Usage { get; }
	public int VolumeControlStream { get; }

	// inner types
	public class Builder : Java.Lang.Object {
		// constructors
		protected AudioAttributesImplBase.Builder (IntPtr, Android.Runtime.JniHandleOwnership);
		// properties
		protected IntPtr ThresholdClass { get; }
		protected System.Type ThresholdType { get; }
		// methods
		public virtual Java.Lang.Object Build ();
		public virtual Java.Lang.Object SetContentType (int);
		public virtual Java.Lang.Object SetFlags (int);
		public virtual Java.Lang.Object SetLegacyStreamType (int);
		public virtual Java.Lang.Object SetUsage (int);
	}
}
```

#### New Type: AndroidX.Media.AudioFocusRequestCompat

```csharp
public class AudioFocusRequestCompat : Java.Lang.Object {
	// constructors
	protected AudioFocusRequestCompat (IntPtr, Android.Runtime.JniHandleOwnership);
	// properties
	public AudioAttributesCompat AudioAttributesCompat { get; }
	public Android.OS.Handler FocusChangeHandler { get; }
	public int FocusGain { get; }
	public Android.Media.AudioManager.IOnAudioFocusChangeListener OnAudioFocusChangeListener { get; }
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public virtual bool WillPauseWhenDucked ();

	// inner types
	public sealed class Builder : Java.Lang.Object {
		// constructors
		public AudioFocusRequestCompat.Builder (AudioFocusRequestCompat);
		public AudioFocusRequestCompat.Builder (int);
		// properties
		protected IntPtr ThresholdClass { get; }
		protected System.Type ThresholdType { get; }
		// methods
		public AudioFocusRequestCompat Build ();
		public AudioFocusRequestCompat.Builder SetAudioAttributes (AudioAttributesCompat);
		public AudioFocusRequestCompat.Builder SetFocusGain (int);
		public AudioFocusRequestCompat.Builder SetOnAudioFocusChangeListener (Android.Media.AudioManager.IOnAudioFocusChangeListener);
		public AudioFocusRequestCompat.Builder SetOnAudioFocusChangeListener (Android.Media.AudioManager.IOnAudioFocusChangeListener, Android.OS.Handler);
		public AudioFocusRequestCompat.Builder SetWillPauseWhenDucked (bool);
	}
	public interface IFocusGainType : Android.Runtime.IJavaObject, Java.Lang.Annotation.IAnnotation, System.IDisposable {
	}
}
```

#### New Type: AndroidX.Media.AudioManagerCompat

```csharp
public sealed class AudioManagerCompat : Java.Lang.Object {
	// fields
	public static const int AudiofocusGain;
	public static const int AudiofocusGainTransient;
	public static const int AudiofocusGainTransientExclusive;
	public static const int AudiofocusGainTransientMayDuck;
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public static int AbandonAudioFocusRequest (Android.Media.AudioManager, AudioFocusRequestCompat);
	public static int RequestAudioFocus (Android.Media.AudioManager, AudioFocusRequestCompat);
}
```


### Namespace Android.Support.V4.Media

#### Type Changed: Android.Support.V4.Media.MediaBrowserCompat

#### Type Changed: Android.Support.V4.Media.MediaBrowserCompat.MediaBrowserImplBase

Removed interfaces:

```csharp
Android.Runtime.IJavaObject
MediaBrowserCompat.IMediaBrowserImpl
MediaBrowserCompat.IMediaBrowserServiceCallbackImpl
System.IDisposable
```



#### New Type: Android.Support.V4.Media.AudioAttributesCompatParcelizer

```csharp
public sealed class AudioAttributesCompatParcelizer : AndroidX.Media.AudioAttributesCompatParcelizer {
	// constructors
	public AudioAttributesCompatParcelizer ();
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public static AndroidX.Media.AudioAttributesCompat Read (AndroidX.VersionedParcelable.VersionedParcel);
	public static void Write (AndroidX.Media.AudioAttributesCompat, AndroidX.VersionedParcelable.VersionedParcel);
}
```

#### New Type: Android.Support.V4.Media.AudioAttributesImplBaseParcelizer

```csharp
public sealed class AudioAttributesImplBaseParcelizer : AndroidX.Media.AudioAttributesImplBaseParcelizer {
	// constructors
	public AudioAttributesImplBaseParcelizer ();
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public static AndroidX.Media.AudioAttributesImplBase Read (AndroidX.VersionedParcelable.VersionedParcel);
	public static void Write (AndroidX.Media.AudioAttributesImplBase, AndroidX.VersionedParcelable.VersionedParcel);
}
```


### Namespace Android.Support.V4.Media.Session

#### Type Changed: Android.Support.V4.Media.Session.IMediaSession

Added property:

```csharp
public Android.OS.Bundle SessionInfo { get; }
```

Added method:

```csharp
public virtual void SetPlaybackSpeed (float);
```


#### Type Changed: Android.Support.V4.Media.Session.MediaControllerCompat

Removed property:

```csharp
public Android.OS.Bundle SessionToken2Bundle { get; }
```

Added properties:

```csharp
public AndroidX.VersionedParcelable.IVersionedParcelable Session2Token { get; }
public Android.OS.Bundle SessionInfo { get; }
```

#### Type Changed: Android.Support.V4.Media.Session.MediaControllerCompat.IMediaControllerImpl

Added property:

```csharp
public Android.OS.Bundle SessionInfo { get; }
```


#### Type Changed: Android.Support.V4.Media.Session.MediaControllerCompat.MediaControllerImplBase

Removed interfaces:

```csharp
Android.Runtime.IJavaObject
MediaControllerCompat.IMediaControllerImpl
System.IDisposable
```

Added property:

```csharp
public Android.OS.Bundle SessionInfo { get; }
```


#### Type Changed: Android.Support.V4.Media.Session.MediaControllerCompat.PlaybackInfo

Obsoleted properties:

```diff
 [Obsolete ("deprecated")]
 public int AudioStream { get; }
```

Added property:

```csharp
public AndroidX.Media.AudioAttributesCompat AudioAttributes { get; }
```


#### Type Changed: Android.Support.V4.Media.Session.MediaControllerCompat.TransportControls

Added method:

```csharp
public virtual void SetPlaybackSpeed (float);
```



#### Type Changed: Android.Support.V4.Media.Session.MediaSessionCompat

Removed constructor:

```csharp
public MediaSessionCompat (Android.Content.Context, string, Android.OS.Bundle);
```

Added constructors:

```csharp
public MediaSessionCompat (Android.Content.Context, string, Android.Content.ComponentName, Android.App.PendingIntent, Android.OS.Bundle);
public MediaSessionCompat (Android.Content.Context, string, Android.Content.ComponentName, Android.App.PendingIntent, Android.OS.Bundle, AndroidX.VersionedParcelable.IVersionedParcelable);
```

Removed field:

```csharp
public static const string KeySessionToken2Bundle = "android.support.v4.media.session.SESSION_TOKEN2_BUNDLE";
```

Obsoleted fields:

```diff
 [Obsolete ("deprecated")]
 public static const int FlagHandlesMediaButtons;
 [Obsolete ("deprecated")]
 public static const int FlagHandlesTransportControls;
```

Added fields:

```csharp
public static const string ActionArgumentPlaybackSpeed = "android.support.v4.media.session.action.ARGUMENT_PLAYBACK_SPEED";
public static const string ActionSetPlaybackSpeed = "android.support.v4.media.session.action.SET_PLAYBACK_SPEED";
public static const string KeySession2Token = "android.support.v4.media.session.SESSION_TOKEN2";
```

#### Type Changed: Android.Support.V4.Media.Session.MediaSessionCompat.Callback

Added method:

```csharp
public virtual void OnSetPlaybackSpeed (float);
```


#### Type Changed: Android.Support.V4.Media.Session.MediaSessionCompat.MediaSessionImplBase.MediaSessionImplBase

Removed constructor:

```csharp
public MediaSessionCompat.MediaSessionImplBase (Android.Content.Context, string, Android.Content.ComponentName, Android.App.PendingIntent);
```

Added constructor:

```csharp
public MediaSessionCompat.MediaSessionImplBase (Android.Content.Context, string, Android.Content.ComponentName, Android.App.PendingIntent, Android.OS.Bundle);
```

Removed interfaces:

```csharp
Android.Runtime.IJavaObject
MediaSessionCompat.IMediaSessionImpl
System.IDisposable
```

#### Type Changed: Android.Support.V4.Media.Session.MediaSessionCompat.MediaSessionImplBase.MediaSessionStub

Added property:

```csharp
public Android.OS.Bundle SessionInfo { get; }
```

Added method:

```csharp
public override void SetPlaybackSpeed (float);
```



#### Type Changed: Android.Support.V4.Media.Session.MediaSessionCompat.MediaSessionImplBase.Token

Removed property:

```csharp
public Android.OS.Bundle SessionToken2Bundle { get; set; }
```

Added property:

```csharp
public AndroidX.VersionedParcelable.IVersionedParcelable Session2Token { get; set; }
```



#### Type Changed: Android.Support.V4.Media.Session.MediaSessionStub

Added property:

```csharp
public Android.OS.Bundle SessionInfo { get; }
```

Added method:

```csharp
public virtual void SetPlaybackSpeed (float);
```



### Namespace AndroidX.Core.OS

#### Type Changed: AndroidX.Core.OS.HandlerCompat

Added methods:

```csharp
public static Android.OS.Handler CreateAsync (Android.OS.Looper);
public static Android.OS.Handler CreateAsync (Android.OS.Looper, Android.OS.Handler.ICallback);
```


#### Type Changed: AndroidX.Core.OS.LocaleListCompat

Obsoleted methods:

```diff
 [Obsolete ("deprecated")]
 public static LocaleListCompat Wrap (Java.Lang.Object);
```

Added method:

```csharp
public static LocaleListCompat Wrap (Android.OS.LocaleList);
```


#### New Type: AndroidX.Core.OS.MessageCompat

```csharp
public sealed class MessageCompat : Java.Lang.Object {
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public static bool IsAsynchronous (Android.OS.Message);
	public static void SetAsynchronous (Android.OS.Message, bool);
}
```


### Namespace AndroidX.Core.Text

#### Type Changed: AndroidX.Core.Text.PrecomputedTextCompat

#### Type Changed: AndroidX.Core.Text.PrecomputedTextCompat.Params.Params

Added method:

```csharp
public bool EqualsWithoutTextDirection (PrecomputedTextCompat.Params);
```



#### Type Changed: AndroidX.Core.Text.TextDirectionHeuristicsCompat

#### Removed Type AndroidX.Core.Text.TextDirectionHeuristicsCompat.ITextDirectionAlgorithm


### Namespace AndroidX.Collection

#### Type Changed: AndroidX.Collection.LongSparseArray

Obsoleted methods:

```diff
 [Obsolete ("deprecated")]
 public virtual void Delete (long);
```

Added methods:

```csharp
public virtual Java.Lang.Object PutIfAbsent (long, Java.Lang.Object);
public virtual bool Remove (long, Java.Lang.Object);
public virtual Java.Lang.Object Replace (long, Java.Lang.Object);
public virtual bool Replace (long, Java.Lang.Object, Java.Lang.Object);
```


#### Type Changed: AndroidX.Collection.SimpleArrayMap

Added methods:

```csharp
public virtual Java.Lang.Object GetOrDefault (Java.Lang.Object, Java.Lang.Object);
public virtual Java.Lang.Object PutIfAbsent (Java.Lang.Object, Java.Lang.Object);
public virtual bool Remove (Java.Lang.Object, Java.Lang.Object);
public virtual Java.Lang.Object Replace (Java.Lang.Object, Java.Lang.Object);
public virtual bool Replace (Java.Lang.Object, Java.Lang.Object, Java.Lang.Object);
```


#### Type Changed: AndroidX.Collection.SparseArrayCompat

Obsoleted methods:

```diff
 [Obsolete ("deprecated")]
 public virtual void Delete (int);
```

Added methods:

```csharp
public virtual Java.Lang.Object PutIfAbsent (int, Java.Lang.Object);
public virtual bool Remove (int, Java.Lang.Object);
public virtual Java.Lang.Object Replace (int, Java.Lang.Object);
public virtual bool Replace (int, Java.Lang.Object, Java.Lang.Object);
```



### Namespace AndroidX.Core.Util

#### Type Changed: AndroidX.Core.Util.Preconditions

Removed constructor:

```csharp
protected Preconditions (IntPtr, Android.Runtime.JniHandleOwnership);
```

Removed methods:

```csharp
public static float CheckArgumentFinite (float, string);
public static long CheckArgumentInRange (long, long, long, string);
public static float CheckArgumentInRange (float, float, float, string);
public static long CheckArgumentNonnegative (long);
public static long CheckArgumentNonnegative (long, string);
public static int CheckArgumentPositive (int, string);
public static float[] CheckArrayElementsInRange (float[], float, float, string);
public static Java.Lang.Object[] CheckArrayElementsNotNull (Java.Lang.Object[], string);
public static Java.Lang.Object CheckCollectionElementsNotNull (Java.Lang.Object, string);
public static System.Collections.ICollection CheckCollectionNotEmpty (System.Collections.ICollection, string);
public static int CheckFlagsArgument (int, int);
```


#### New Type: AndroidX.Core.Util.ISupplier

```csharp
public interface ISupplier : Android.Runtime.IJavaObject, System.IDisposable {
	// methods
	public virtual Java.Lang.Object Get ();
}
```


### Namespace AndroidX.Core.View.Accessibiity

#### Type Changed: AndroidX.Core.View.Accessibiity.AccessibilityEventCompat

Added fields:

```csharp
public static const int ContentChangeTypePaneAppeared;
public static const int ContentChangeTypePaneDisappeared;
public static const int ContentChangeTypePaneTitle;
```


#### Type Changed: AndroidX.Core.View.Accessibiity.AccessibilityNodeInfoCompat

Added property:

```csharp
public bool TextEntryKey { get; set; }
```

Added methods:

```csharp
public virtual void AddSpansToExtras (Java.Lang.ICharSequence, Android.Views.View);
public void AddSpansToExtras (string, Android.Views.View);
public static Android.Text.Style.ClickableSpan[] GetClickableSpans (Java.Lang.ICharSequence);
public static Android.Text.Style.ClickableSpan[] GetClickableSpans (string);
```

#### Type Changed: AndroidX.Core.View.Accessibiity.AccessibilityNodeInfoCompat.AccessibilityActionCompat

Added constructors:

```csharp
public AccessibilityNodeInfoCompat.AccessibilityActionCompat (int, Java.Lang.ICharSequence, IAccessibilityViewCommand);
public AccessibilityNodeInfoCompat.AccessibilityActionCompat (int, string, IAccessibilityViewCommand);
```

Added property:

```csharp
protected IAccessibilityViewCommand MCommand { get; set; }
```

Added methods:

```csharp
public virtual AccessibilityNodeInfoCompat.AccessibilityActionCompat CreateReplacementAction (Java.Lang.ICharSequence, IAccessibilityViewCommand);
public AccessibilityNodeInfoCompat.AccessibilityActionCompat CreateReplacementAction (string, IAccessibilityViewCommand);
public virtual bool Perform (Android.Views.View, Android.OS.Bundle);
```



#### New Type: AndroidX.Core.View.Accessibiity.AccessibilityClickableSpanCompat

```csharp
public sealed class AccessibilityClickableSpanCompat : Android.Text.Style.ClickableSpan {
	// constructors
	public AccessibilityClickableSpanCompat (int, AccessibilityNodeInfoCompat, int);
	// fields
	public static const string SpanId = "ACCESSIBILITY_CLICKABLE_SPAN_ID";
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public override void OnClick (Android.Views.View);
}
```

#### New Type: AndroidX.Core.View.Accessibiity.AccessibilityViewCommandCommandArguments

```csharp
public abstract class AccessibilityViewCommandCommandArguments : Java.Lang.Object {
	// constructors
	public AccessibilityViewCommandCommandArguments ();
	protected AccessibilityViewCommandCommandArguments (IntPtr, Android.Runtime.JniHandleOwnership);
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public virtual void SetBundle (Android.OS.Bundle);
}
```

#### New Type: AndroidX.Core.View.Accessibiity.AccessibilityViewCommandMoveAtGranularityArguments

```csharp
public sealed class AccessibilityViewCommandMoveAtGranularityArguments : AndroidX.Core.View.Accessibiity.AccessibilityViewCommandCommandArguments {
	// constructors
	public AccessibilityViewCommandMoveAtGranularityArguments ();
	// properties
	public bool ExtendSelection { get; }
	public int Granularity { get; }
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
}
```

#### New Type: AndroidX.Core.View.Accessibiity.AccessibilityViewCommandMoveHtmlArguments

```csharp
public sealed class AccessibilityViewCommandMoveHtmlArguments : AndroidX.Core.View.Accessibiity.AccessibilityViewCommandCommandArguments {
	// constructors
	public AccessibilityViewCommandMoveHtmlArguments ();
	// properties
	public string HTMLElement { get; }
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
}
```

#### New Type: AndroidX.Core.View.Accessibiity.AccessibilityViewCommandMoveWindowArguments

```csharp
public sealed class AccessibilityViewCommandMoveWindowArguments : AndroidX.Core.View.Accessibiity.AccessibilityViewCommandCommandArguments {
	// constructors
	public AccessibilityViewCommandMoveWindowArguments ();
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public int GetX ();
	public int GetY ();
}
```

#### New Type: AndroidX.Core.View.Accessibiity.AccessibilityViewCommandScrollToPositionArguments

```csharp
public sealed class AccessibilityViewCommandScrollToPositionArguments : AndroidX.Core.View.Accessibiity.AccessibilityViewCommandCommandArguments {
	// constructors
	public AccessibilityViewCommandScrollToPositionArguments ();
	// properties
	public int Column { get; }
	public int Row { get; }
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
}
```

#### New Type: AndroidX.Core.View.Accessibiity.AccessibilityViewCommandSetProgressArguments

```csharp
public sealed class AccessibilityViewCommandSetProgressArguments : AndroidX.Core.View.Accessibiity.AccessibilityViewCommandCommandArguments {
	// constructors
	public AccessibilityViewCommandSetProgressArguments ();
	// properties
	public float Progress { get; }
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
}
```

#### New Type: AndroidX.Core.View.Accessibiity.AccessibilityViewCommandSetSelectionArguments

```csharp
public sealed class AccessibilityViewCommandSetSelectionArguments : AndroidX.Core.View.Accessibiity.AccessibilityViewCommandCommandArguments {
	// constructors
	public AccessibilityViewCommandSetSelectionArguments ();
	// properties
	public int End { get; }
	public int Start { get; }
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
}
```

#### New Type: AndroidX.Core.View.Accessibiity.AccessibilityViewCommandSetTextArguments

```csharp
public sealed class AccessibilityViewCommandSetTextArguments : AndroidX.Core.View.Accessibiity.AccessibilityViewCommandCommandArguments {
	// constructors
	public AccessibilityViewCommandSetTextArguments ();
	// properties
	public string Text { get; }
	public Java.Lang.ICharSequence TextFormatted { get; }
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
}
```

#### New Type: AndroidX.Core.View.Accessibiity.IAccessibilityViewCommand

```csharp
public interface IAccessibilityViewCommand : Android.Runtime.IJavaObject, System.IDisposable {
	// methods
	public virtual bool Perform (Android.Views.View, AccessibilityViewCommandCommandArguments);
}
```


### Namespace AndroidX.Core.Widget

#### Type Changed: AndroidX.Core.Widget.NestedScrollView

Added interfaces:

```csharp
AndroidX.Core.View.INestedScrollingChild3
AndroidX.Core.View.INestedScrollingParent3
```

Added methods:

```csharp
public virtual void DispatchNestedScroll (int, int, int, int, int[], int, int[]);
public virtual void OnNestedScroll (Android.Views.View, int, int, int, int, int, int[]);
public override void OnNestedScrollAccepted (Android.Views.View, Android.Views.View, Android.Views.ScrollAxis);
```


#### Type Changed: AndroidX.Core.Widget.TextViewCompat

Added methods:

```csharp
public static Android.Content.Res.ColorStateList GetCompoundDrawableTintList (Android.Widget.TextView);
public static Android.Graphics.PorterDuff.Mode GetCompoundDrawableTintMode (Android.Widget.TextView);
public static void SetCompoundDrawableTintList (Android.Widget.TextView, Android.Content.Res.ColorStateList);
public static void SetCompoundDrawableTintMode (Android.Widget.TextView, Android.Graphics.PorterDuff.Mode);
```


#### New Type: AndroidX.Core.Widget.ITintableCompoundDrawablesView

```csharp
public interface ITintableCompoundDrawablesView : Android.Runtime.IJavaObject, System.IDisposable {
	// properties
	public Android.Content.Res.ColorStateList SupportCompoundDrawablesTintList { get; set; }
	public Android.Graphics.PorterDuff.Mode SupportCompoundDrawablesTintMode { get; set; }
}
```


### Namespace AndroidX.CursorAdapter.Widget

#### Type Changed: AndroidX.CursorAdapter.Widget.CursorAdapter

Removed interface:

```csharp
CursorFilter.ICursorFilterClient
```


#### Type Changed: AndroidX.CursorAdapter.Widget.ResourceCursorAdapter

Removed interface:

```csharp
CursorFilter.ICursorFilterClient
```


#### Type Changed: AndroidX.CursorAdapter.Widget.SimpleCursorAdapter

Removed interface:

```csharp
CursorFilter.ICursorFilterClient
```



### Namespace AndroidX.AppCompat.App

#### Type Changed: AndroidX.AppCompat.App.AppCompatActivity

Added constructor:

```csharp
public AppCompatActivity (int);
```

Added interfaces:

```csharp
AndroidX.Activity.IOnBackPressedDispatcherOwner
AndroidX.Core.View.KeyEventDispatcher.IComponent
AndroidX.SavedState.ISavedStateRegistryOwner
```

Added method:

```csharp
protected virtual void OnNightModeChanged (int);
```


#### Type Changed: AndroidX.AppCompat.App.AppCompatDelegate

Obsoleted fields:

```diff
 [Obsolete ("deprecated")]
 public static const int ModeNightAuto;
```

Added fields:

```csharp
public static const int ModeNightAutoBattery;

[Obsolete ("deprecated")]
public static const int ModeNightAutoTime;
public static const int ModeNightUnspecified;
```

Added property:

```csharp
public int LocalNightMode { get; }
```

Added methods:

```csharp
public virtual void AttachBaseContext (Android.Content.Context);
public static AppCompatDelegate Create (Android.Content.Context, Android.App.Activity, IAppCompatCallback);
public virtual void SetTheme (int);
```


#### Type Changed: AndroidX.AppCompat.App.AppCompatDialogFragment

Added interface:

```csharp
AndroidX.SavedState.ISavedStateRegistryOwner
```


#### Type Changed: AndroidX.AppCompat.App.AppCompatViewInflater

Added method:

```csharp
protected virtual AndroidX.AppCompat.Widget.AppCompatToggleButton CreateToggleButton (Android.Content.Context, Android.Util.IAttributeSet);
```



### Namespace AndroidX.MediaRouter.App

#### Type Changed: AndroidX.MediaRouter.App.MediaRouteActionProvider

Added methods:

```csharp
public virtual void EnableDynamicGroup ();
public virtual void SetAlwaysVisible (bool);
```


#### Type Changed: AndroidX.MediaRouter.App.MediaRouteButton

Added methods:

```csharp
public virtual void EnableDynamicGroup ();
public virtual void SetAlwaysVisible (bool);
```


#### Type Changed: AndroidX.MediaRouter.App.MediaRouteChooserDialog

#### Type Changed: AndroidX.MediaRouter.App.MediaRouteChooserDialog.RouteComparator

Added method:

```csharp
public int Compare (AndroidX.MediaRouter.Media.MediaRouter.RouteInfo, AndroidX.MediaRouter.Media.MediaRouter.RouteInfo);
```



#### Type Changed: AndroidX.MediaRouter.App.MediaRouteChooserDialogFragment

Added interface:

```csharp
AndroidX.SavedState.ISavedStateRegistryOwner
```

Removed method:

```csharp
public virtual Android.Support.V7.App.MediaRouteDevicePickerDialog OnCreateDevicePickerDialog (Android.Content.Context);
```

Added method:

```csharp
public virtual MediaRouteDynamicChooserDialog OnCreateDynamicChooserDialog (Android.Content.Context);
```


#### Type Changed: AndroidX.MediaRouter.App.MediaRouteControllerDialogFragment

Added interface:

```csharp
AndroidX.SavedState.ISavedStateRegistryOwner
```

Removed method:

```csharp
public virtual Android.Support.V7.App.MediaRouteCastDialog OnCreateCastDialog (Android.Content.Context);
```

Added method:

```csharp
public virtual MediaRouteDynamicControllerDialog OnCreateDynamicControllerDialog (Android.Content.Context);
```


#### Type Changed: AndroidX.MediaRouter.App.MediaRouteDiscoveryFragment

Added interface:

```csharp
AndroidX.SavedState.ISavedStateRegistryOwner
```


#### New Type: AndroidX.MediaRouter.App.MediaRouteDevicePickerDialog

```csharp
public class MediaRouteDevicePickerDialog {
	// constructors
	public MediaRouteDevicePickerDialog ();

	// inner types
	public class RouteComparator {
		// constructors
		public MediaRouteDevicePickerDialog.RouteComparator ();
		// methods
		public int Compare (Java.Lang.Object, Java.Lang.Object);
	}
}
```

#### New Type: AndroidX.MediaRouter.App.MediaRouteDynamicChooserDialog

```csharp
public class MediaRouteDynamicChooserDialog : AndroidX.AppCompat.App.AppCompatDialog, Android.Runtime.IJavaObject, AndroidX.AppCompat.App.IAppCompatCallback, System.IDisposable {
	// constructors
	public MediaRouteDynamicChooserDialog (Android.Content.Context);
	public MediaRouteDynamicChooserDialog (Android.Content.Context, int);
	protected MediaRouteDynamicChooserDialog (IntPtr, Android.Runtime.JniHandleOwnership);
	// properties
	public AndroidX.MediaRouter.Media.MediaRouteSelector RouteSelector { get; set; }
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public virtual bool OnFilterRoute (AndroidX.MediaRouter.Media.MediaRouter.RouteInfo);
	public virtual void OnFilterRoutes (System.Collections.Generic.IList<AndroidX.MediaRouter.Media.MediaRouter.RouteInfo>);
	public virtual void RefreshRoutes ();

	// inner types
	public sealed class RouteComparator : Java.Lang.Object, Android.Runtime.IJavaObject, Java.Util.IComparator, System.IDisposable {
		// properties
		public static MediaRouteDynamicChooserDialog.RouteComparator SInstance { get; }
		protected IntPtr ThresholdClass { get; }
		protected System.Type ThresholdType { get; }
		// methods
		public int Compare (AndroidX.MediaRouter.Media.MediaRouter.RouteInfo, AndroidX.MediaRouter.Media.MediaRouter.RouteInfo);
		public virtual int Compare (Java.Lang.Object, Java.Lang.Object);
	}
}
```

#### New Type: AndroidX.MediaRouter.App.MediaRouteDynamicControllerDialog

```csharp
public class MediaRouteDynamicControllerDialog : AndroidX.AppCompat.App.AppCompatDialog, Android.Runtime.IJavaObject, AndroidX.AppCompat.App.IAppCompatCallback, System.IDisposable {
	// constructors
	public MediaRouteDynamicControllerDialog (Android.Content.Context);
	public MediaRouteDynamicControllerDialog (Android.Content.Context, int);
	protected MediaRouteDynamicControllerDialog (IntPtr, Android.Runtime.JniHandleOwnership);
	// properties
	public Android.Support.V4.Media.Session.MediaSessionCompat.Token MediaSession { get; }
	public AndroidX.MediaRouter.Media.MediaRouteSelector RouteSelector { get; set; }
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public virtual bool OnFilterRoute (AndroidX.MediaRouter.Media.MediaRouter.RouteInfo);
	public virtual void OnFilterRoutes (System.Collections.Generic.IList<AndroidX.MediaRouter.Media.MediaRouter.RouteInfo>);

	// inner types
	public sealed class RouteComparator : Java.Lang.Object, Android.Runtime.IJavaObject, Java.Util.IComparator, System.IDisposable {
		// properties
		protected IntPtr ThresholdClass { get; }
		protected System.Type ThresholdType { get; }
		// methods
		public int Compare (AndroidX.MediaRouter.Media.MediaRouter.RouteInfo, AndroidX.MediaRouter.Media.MediaRouter.RouteInfo);
		public virtual int Compare (Java.Lang.Object, Java.Lang.Object);
	}
}
```


### Namespace AndroidX.AppCompat.Graphics.Drawable

#### Type Changed: AndroidX.AppCompat.Graphics.Drawable.AnimatedStateListDrawableCompat

Modified base type:

```diff
-Android.Graphics.Drawables.Drawable
+AndroidX.AppCompat.Graphics.Drawable.DrawableContainer
```

Added interfaces:

```csharp
Android.Graphics.Drawables.Drawable.ICallback
Android.Runtime.IJavaObject
AndroidX.Core.Graphics.Drawable.ITintAwareDrawable
System.IDisposable
```

Modified properties:

```diff
-public override int Alpha { get; set; }
+public override int Alpha { get; }
```

Removed methods:

```csharp
public override Android.Graphics.Drawables.Drawable.ConstantState GetConstantState ();
public override void SetAlpha (int);
```


#### New Type: AndroidX.AppCompat.Graphics.Drawable.DrawableContainer

```csharp
public class DrawableContainer : Android.Graphics.Drawables.Drawable, Android.Graphics.Drawables.Drawable.ICallback, Android.Runtime.IJavaObject, System.IDisposable {
	// constructors
	protected DrawableContainer (IntPtr, Android.Runtime.JniHandleOwnership);
	// properties
	public int Opacity { get; }
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public override void Draw (Android.Graphics.Canvas);
	public override Android.Graphics.Drawables.Drawable.ConstantState GetConstantState ();
	public virtual void InvalidateDrawable (Android.Graphics.Drawables.Drawable);
	public virtual void ScheduleDrawable (Android.Graphics.Drawables.Drawable, Java.Lang.IRunnable, long);
	public override void SetAlpha (int);
	public override void SetColorFilter (Android.Graphics.ColorFilter);
	public virtual void SetEnterFadeDuration (int);
	public virtual void SetExitFadeDuration (int);
	public virtual void UnscheduleDrawable (Android.Graphics.Drawables.Drawable, Java.Lang.IRunnable);

	// inner types
	public class BlockInvalidateCallback : Java.Lang.Object, Android.Graphics.Drawables.Drawable.ICallback, Android.Runtime.IJavaObject, System.IDisposable {
		// constructors
		protected DrawableContainer.BlockInvalidateCallback (IntPtr, Android.Runtime.JniHandleOwnership);
		// properties
		protected IntPtr ThresholdClass { get; }
		protected System.Type ThresholdType { get; }
		// methods
		public virtual void InvalidateDrawable (Android.Graphics.Drawables.Drawable);
		public virtual void ScheduleDrawable (Android.Graphics.Drawables.Drawable, Java.Lang.IRunnable, long);
		public virtual void UnscheduleDrawable (Android.Graphics.Drawables.Drawable, Java.Lang.IRunnable);
		public virtual Android.Graphics.Drawables.Drawable.ICallback Unwrap ();
		public virtual Java.Lang.Object Wrap (Android.Graphics.Drawables.Drawable.ICallback);
	}
	public abstract class DrawableContainerState : Android.Graphics.Drawables.Drawable+ConstantState {
		// constructors
		protected DrawableContainer.DrawableContainerState (IntPtr, Android.Runtime.JniHandleOwnership);
		// properties
		public Android.Content.PM.ConfigChanges ChangingConfigurations { get; }
		public int ChildCount { get; }
		public int ConstantHeight { get; }
		public int ConstantMinimumHeight { get; }
		public int ConstantMinimumWidth { get; }
		public Android.Graphics.Rect ConstantPadding { get; }
		public bool ConstantSize { get; set; }
		public int ConstantWidth { get; }
		public int EnterFadeDuration { get; set; }
		public int ExitFadeDuration { get; set; }
		public bool IsStateful { get; }
		public int Opacity { get; }
		protected IntPtr ThresholdClass { get; }
		protected System.Type ThresholdType { get; }
		// methods
		public int AddChild (Android.Graphics.Drawables.Drawable);
		public virtual bool CanConstantState ();
		protected virtual void ComputeConstantSize ();
		public Android.Graphics.Drawables.Drawable GetChild (int);
		public virtual void GrowArray (int, int);
		public void SetVariablePadding (bool);
	}
}
```


### Namespace AndroidX.MediaRouter.Media

#### Type Changed: AndroidX.MediaRouter.Media.MediaRouteDescriptor

Added property:

```csharp
public bool IsDynamicGroupRoute { get; }
```

#### Type Changed: AndroidX.MediaRouter.Media.MediaRouteDescriptor.Builder

Added methods:

```csharp
public MediaRouteDescriptor.Builder RemoveGroupMemberId (string);
public MediaRouteDescriptor.Builder SetIsDynamicGroupRoute (bool);
```



#### Type Changed: AndroidX.MediaRouter.Media.MediaRouteProvider

Added method:

```csharp
public virtual MediaRouteProvider.DynamicGroupRouteController OnCreateDynamicGroupRouteController (string);
```

#### New Type: AndroidX.MediaRouter.Media.MediaRouteProvider.DynamicGroupRouteController

```csharp
public abstract class DynamicGroupRouteController : AndroidX.MediaRouter.Media.MediaRouteProvider+RouteController {
	// constructors
	public MediaRouteProvider.DynamicGroupRouteController ();
	protected MediaRouteProvider.DynamicGroupRouteController (IntPtr, Android.Runtime.JniHandleOwnership);
	// properties
	public string GroupableSelectionTitle { get; }
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	public string TransferableSectionTitle { get; }
	// methods
	public void NotifyDynamicRoutesChanged (System.Collections.Generic.ICollection<MediaRouteProvider.DynamicGroupRouteController.DynamicRouteDescriptor>);
	public virtual void OnAddMemberRoute (string);
	public virtual void OnRemoveMemberRoute (string);
	public virtual void OnUpdateMemberRoutes (System.Collections.Generic.IList<string>);

	// inner types
	public sealed class DynamicRouteDescriptor : Java.Lang.Object {
		// fields
		public static const int Selected;
		public static const int Selecting;
		public static const int Unselected;
		public static const int Unselecting;
		// properties
		public bool IsGroupable { get; }
		public bool IsTransferable { get; }
		public bool IsUnselectable { get; }
		public MediaRouteDescriptor RouteDescriptor { get; }
		public int SelectionState { get; }
		protected IntPtr ThresholdClass { get; }
		protected System.Type ThresholdType { get; }

		// inner types
		public sealed class Builder : Java.Lang.Object {
			// constructors
			public MediaRouteProvider.DynamicGroupRouteController.DynamicRouteDescriptor.Builder (MediaRouteDescriptor);
			public MediaRouteProvider.DynamicGroupRouteController.DynamicRouteDescriptor.Builder (MediaRouteProvider.DynamicGroupRouteController.DynamicRouteDescriptor);
			// properties
			protected IntPtr ThresholdClass { get; }
			protected System.Type ThresholdType { get; }
			// methods
			public MediaRouteProvider.DynamicGroupRouteController.DynamicRouteDescriptor Build ();
			public MediaRouteProvider.DynamicGroupRouteController.DynamicRouteDescriptor.Builder SetIsGroupable (bool);
			public MediaRouteProvider.DynamicGroupRouteController.DynamicRouteDescriptor.Builder SetIsTransferable (bool);
			public MediaRouteProvider.DynamicGroupRouteController.DynamicRouteDescriptor.Builder SetIsUnselectable (bool);
			public MediaRouteProvider.DynamicGroupRouteController.DynamicRouteDescriptor.Builder SetSelectionState (int);
		}
		public interface ISelectionState : Android.Runtime.IJavaObject, Java.Lang.Annotation.IAnnotation, System.IDisposable {
		}
	}
}
```


#### Type Changed: AndroidX.MediaRouter.Media.MediaRouteProviderDescriptor

Added method:

```csharp
public bool SupportsDynamicGroupRoute ();
```

#### Type Changed: AndroidX.MediaRouter.Media.MediaRouteProviderDescriptor.Builder

Added method:

```csharp
public MediaRouteProviderDescriptor.Builder SetSupportsDynamicGroupRoute (bool);
```



#### Type Changed: AndroidX.MediaRouter.Media.MediaRouter

Added methods:

```csharp
public void AddMemberToDynamicGroup (MediaRouter.RouteInfo);
public void RemoveMemberFromDynamicGroup (MediaRouter.RouteInfo);
```

#### Type Changed: AndroidX.MediaRouter.Media.MediaRouter.RouteInfo

Obsoleted properties:

```diff
 [Obsolete ("deprecated")]
 public bool IsConnecting { get; }
```

Added properties:

```csharp
public MediaRouteProvider.DynamicGroupRouteController DynamicGroupController { get; }
public bool IsGroup { get; }
public System.Collections.Generic.IList<MediaRouter.RouteInfo> MemberRoutes { get; }
```

Added method:

```csharp
public virtual MediaRouter.RouteInfo.DynamicGroupState GetDynamicGroupState ();
```


#### Removed Type AndroidX.MediaRouter.Media.MediaRouter.RouteGroup


### Namespace AndroidX.RecyclerView.Widget

#### Type Changed: AndroidX.RecyclerView.Widget.AsyncListDiffer

Added methods:

```csharp
public virtual void AddListListener (AsyncListDiffer.IListListener);
public virtual void RemoveListListener (AsyncListDiffer.IListListener);
public virtual void SubmitList (System.Collections.IList, Java.Lang.IRunnable);
```


#### Type Changed: AndroidX.RecyclerView.Widget.ListAdapter

Added property:

```csharp
public System.Collections.IList CurrentList { get; }
```

Added methods:

```csharp
public virtual void OnCurrentListChanged (System.Collections.IList, System.Collections.IList);
public virtual void SubmitList (System.Collections.IList, Java.Lang.IRunnable);
```


#### Type Changed: AndroidX.RecyclerView.Widget.DividerItemDecoration

Added property:

```csharp
public Android.Graphics.Drawables.Drawable Drawable { get; set; }
```

Removed method:

```csharp
public virtual void SetDrawable (Android.Graphics.Drawables.Drawable);
```


#### Type Changed: AndroidX.RecyclerView.Widget.GridLayoutManager

Added property:

```csharp
public bool UsingSpansToEstimateScrollbarDimensions { get; set; }
```

#### Type Changed: AndroidX.RecyclerView.Widget.GridLayoutManager.SpanSizeLookup

Added property:

```csharp
public bool SpanGroupIndexCacheEnabled { get; set; }
```

Added method:

```csharp
public virtual void InvalidateSpanGroupIndexCache ();
```



#### Type Changed: AndroidX.RecyclerView.Widget.LinearLayoutManager

Obsoleted methods:

```diff
 [Obsolete ("deprecated")]
 protected virtual int GetExtraLayoutSpace (RecyclerView.State);
```

Added method:

```csharp
protected virtual void CalculateExtraLayoutSpace (RecyclerView.State, int[]);
```


#### Type Changed: AndroidX.RecyclerView.Widget.RecyclerView

Added interface:

```csharp
AndroidX.Core.View.INestedScrollingChild3
```

Added field:

```csharp
public static const int UndefinedDuration;
```

Obsoleted properties:

```diff
 [Obsolete ("deprecated")]
 public bool LayoutFrozen { get; set; }
```

Added property:

```csharp
public bool IsLayoutSuppressed { get; }
```

Added methods:

```csharp
public virtual void DispatchNestedScroll (int, int, int, int, int[], int, int[]);
public virtual void SmoothScrollBy (int, int, Android.Views.Animations.IInterpolator, int);
public void SuppressLayout (bool);
```

#### Type Changed: AndroidX.RecyclerView.Widget.RecyclerView.Adapter

Modified properties:

```diff
 public bool HasStableIds { get; ---set;--- }
```

Added method:

```csharp
public virtual void SetHasStableIds (bool);
```


#### Type Changed: AndroidX.RecyclerView.Widget.RecyclerView.ViewFlinger

Removed methods:

```csharp
public virtual void SmoothScrollBy (int, int);
public virtual void SmoothScrollBy (int, int, Android.Views.Animations.IInterpolator);
public virtual void SmoothScrollBy (int, int, int);
public virtual void SmoothScrollBy (int, int, int, int);
```




### Namespace AndroidX.AppCompat.View

#### Type Changed: AndroidX.AppCompat.View.WindowCallbackWrapper

Added property:

```csharp
public Android.Views.Window.ICallback Wrapped { get; }
```



### Namespace AndroidX.AppCompat.View.Menu

#### Type Changed: AndroidX.AppCompat.View.Menu.ActionMenuItem

Added methods:

```csharp
public virtual bool RequiresActionButton ();
public virtual bool RequiresOverflow ();
```


#### Type Changed: AndroidX.AppCompat.View.Menu.ActionMenuItemView

Added interface:

```csharp
AndroidX.Core.Widget.ITintableCompoundDrawablesView
```


#### Type Changed: AndroidX.AppCompat.View.Menu.MenuItemImpl

Added method:

```csharp
public virtual bool RequiresOverflow ();
```


#### Type Changed: AndroidX.AppCompat.View.Menu.MenuPopupHelper

Removed interfaces:

```csharp
Android.Runtime.IJavaObject
Android.Support.V7.View.Menu.IMenuHelper
System.IDisposable
```


#### New Type: AndroidX.AppCompat.View.Menu.MenuWrapperICS

```csharp
public class MenuWrapperICS : Java.Lang.Object, Android.Runtime.IJavaObject, Android.Views.IMenu, System.IDisposable {
	// constructors
	public MenuWrapperICS (Android.Content.Context, AndroidX.Core.Internal.View.ISupportMenu);
	protected MenuWrapperICS (IntPtr, Android.Runtime.JniHandleOwnership);
	// properties
	public bool HasVisibleItems { get; }
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public virtual Android.Views.IMenuItem Add (Java.Lang.ICharSequence);
	public virtual Android.Views.IMenuItem Add (int);
	public Android.Views.IMenuItem Add (string);
	public virtual Android.Views.IMenuItem Add (int, int, int, Java.Lang.ICharSequence);
	public virtual Android.Views.IMenuItem Add (int, int, int, int);
	public Android.Views.IMenuItem Add (int, int, int, string);
	public virtual int AddIntentOptions (int, int, int, Android.Content.ComponentName, Android.Content.Intent[], Android.Content.Intent, Android.Views.MenuAppendFlags, Android.Views.IMenuItem[]);
	public virtual Android.Views.ISubMenu AddSubMenu (Java.Lang.ICharSequence);
	public virtual Android.Views.ISubMenu AddSubMenu (int);
	public Android.Views.ISubMenu AddSubMenu (string);
	public virtual Android.Views.ISubMenu AddSubMenu (int, int, int, Java.Lang.ICharSequence);
	public virtual Android.Views.ISubMenu AddSubMenu (int, int, int, int);
	public Android.Views.ISubMenu AddSubMenu (int, int, int, string);
	public virtual void Clear ();
	public virtual void Close ();
	public virtual Android.Views.IMenuItem FindItem (int);
	public virtual Android.Views.IMenuItem GetItem (int);
	public virtual bool IsShortcutKey (Android.Views.Keycode, Android.Views.KeyEvent);
	public virtual bool PerformIdentifierAction (int, Android.Views.MenuPerformFlags);
	public virtual bool PerformShortcut (Android.Views.Keycode, Android.Views.KeyEvent, Android.Views.MenuPerformFlags);
	public virtual void RemoveGroup (int);
	public virtual void RemoveItem (int);
	public virtual void SetGroupCheckable (int, bool, bool);
	public virtual void SetGroupEnabled (int, bool);
	public virtual void SetGroupVisible (int, bool);
	public virtual void SetQwertyMode (bool);
	public virtual int Size ();
}
```


### Namespace AndroidX.AppCompat.Widget

#### Type Changed: AndroidX.AppCompat.Widget.ActionBarOverlayLayout

Added interfaces:

```csharp
AndroidX.Core.View.INestedScrollingParent2
AndroidX.Core.View.INestedScrollingParent3
```

Added methods:

```csharp
public virtual void OnNestedPreScroll (Android.Views.View, int, int, int[], int);
public virtual void OnNestedScroll (Android.Views.View, int, int, int, int, int);
public virtual void OnNestedScroll (Android.Views.View, int, int, int, int, int, int[]);
public virtual void OnNestedScrollAccepted (Android.Views.View, Android.Views.View, int, int);
public virtual bool OnStartNestedScroll (Android.Views.View, Android.Views.View, int, int);
public virtual void OnStopNestedScroll (Android.Views.View, int);
```


#### Type Changed: AndroidX.AppCompat.Widget.AppCompatCheckBox

Added interface:

```csharp
AndroidX.Core.View.ITintableBackgroundView
```

Added properties:

```csharp
public Android.Content.Res.ColorStateList SupportBackgroundTintList { get; set; }
public Android.Graphics.PorterDuff.Mode SupportBackgroundTintMode { get; set; }
```


#### Type Changed: AndroidX.AppCompat.Widget.AppCompatDrawableManager

Added method:

```csharp
public static void Preload ();
```

#### Removed Type AndroidX.AppCompat.Widget.AppCompatDrawableManager.AsldcInflateDelegate

#### Type Changed: AndroidX.AppCompat.Widget.AppCompatRadioButton

Added interface:

```csharp
AndroidX.Core.View.ITintableBackgroundView
```

Added properties:

```csharp
public Android.Content.Res.ColorStateList SupportBackgroundTintList { get; set; }
public Android.Graphics.PorterDuff.Mode SupportBackgroundTintMode { get; set; }
```


#### Type Changed: AndroidX.AppCompat.Widget.AppCompatTextView

Added interface:

```csharp
AndroidX.Core.Widget.ITintableCompoundDrawablesView
```

Added properties:

```csharp
public Android.Content.Res.ColorStateList SupportCompoundDrawablesTintList { get; set; }
public Android.Graphics.PorterDuff.Mode SupportCompoundDrawablesTintMode { get; set; }
```


#### Type Changed: AndroidX.AppCompat.Widget.DialogTitle

Modified base type:

```diff
-Android.Widget.TextView
+AndroidX.AppCompat.Widget.AppCompatTextView
```

Added interfaces:

```csharp
Android.Runtime.IJavaObject
AndroidX.Core.View.ITintableBackgroundView
AndroidX.Core.Widget.IAutoSizeableTextView
AndroidX.Core.Widget.ITintableCompoundDrawablesView
System.IDisposable
```


#### Type Changed: AndroidX.AppCompat.Widget.ListPopupWindow

Added property:

```csharp
public Android.Graphics.Rect EpicenterBounds { get; set; }
```

Removed method:

```csharp
public virtual void SetEpicenterBounds (Android.Graphics.Rect);
```


#### Type Changed: AndroidX.AppCompat.Widget.Toolbar

Added properties:

```csharp
public string CollapseContentDescription { get; set; }
public Java.Lang.ICharSequence CollapseContentDescriptionFormatted { get; set; }
public Android.Graphics.Drawables.Drawable CollapseIcon { get; set; }
```

Added methods:

```csharp
public virtual void SetCollapseContentDescription (int);
public virtual void SetCollapseIcon (int);
public virtual void SetSubtitleTextColor (Android.Content.Res.ColorStateList);
public virtual void SetTitleTextColor (Android.Content.Res.ColorStateList);
```


#### New Type: AndroidX.AppCompat.Widget.AppCompatSpinnerISpinnerPopupExtensions

```csharp
public static class AppCompatSpinnerISpinnerPopupExtensions {
	// methods
	public static void SetPromptText (this AppCompatSpinner.ISpinnerPopup, string);
}
```

#### New Type: AndroidX.AppCompat.Widget.AppCompatToggleButton

```csharp
public class AppCompatToggleButton : Android.Widget.ToggleButton {
	// constructors
	public AppCompatToggleButton (Android.Content.Context);
	public AppCompatToggleButton (Android.Content.Context, Android.Util.IAttributeSet);
	protected AppCompatToggleButton (IntPtr, Android.Runtime.JniHandleOwnership);
	public AppCompatToggleButton (Android.Content.Context, Android.Util.IAttributeSet, int);
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
}
```

#### New Type: AndroidX.AppCompat.Widget.ResourceManagerInternal

```csharp
public sealed class ResourceManagerInternal : Java.Lang.Object {
	// constructors
	public ResourceManagerInternal ();
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public static ResourceManagerInternal Get ();
	public Android.Graphics.Drawables.Drawable GetDrawable (Android.Content.Context, int);
	public static Android.Graphics.PorterDuffColorFilter GetPorterDuffColorFilter (int, Android.Graphics.PorterDuff.Mode);
	public void OnConfigurationChanged (Android.Content.Context);

	// inner types
	public class AsldcInflateDelegate : Java.Lang.Object {
		// constructors
		protected ResourceManagerInternal.AsldcInflateDelegate (IntPtr, Android.Runtime.JniHandleOwnership);
		// properties
		protected IntPtr ThresholdClass { get; }
		protected System.Type ThresholdType { get; }
		// methods
		public virtual Android.Graphics.Drawables.Drawable CreateFromXmlInner (Android.Content.Context, System.Xml.XmlReader, Android.Util.IAttributeSet, Android.Content.Res.Resources.Theme);
	}
	public interface IResourceManagerHooks : Android.Runtime.IJavaObject, System.IDisposable {
		// methods
		public virtual Android.Graphics.Drawables.Drawable CreateDrawableFor (ResourceManagerInternal, Android.Content.Context, int);
		public virtual Android.Content.Res.ColorStateList GetTintListForDrawableRes (Android.Content.Context, int);
		public virtual Android.Graphics.PorterDuff.Mode GetTintModeForDrawableRes (int);
		public virtual bool TintDrawable (Android.Content.Context, int, Android.Graphics.Drawables.Drawable);
		public virtual bool TintDrawableUsingColorFilter (Android.Content.Context, int, Android.Graphics.Drawables.Drawable);
	}
}
```

#### New Type: AndroidX.AppCompat.Widget.TintInfo

```csharp
public class TintInfo : Java.Lang.Object {
	// constructors
	public TintInfo ();
	protected TintInfo (IntPtr, Android.Runtime.JniHandleOwnership);
	// properties
	public bool MHasTintList { get; set; }
	public bool MHasTintMode { get; set; }
	public Android.Content.Res.ColorStateList MTintList { get; set; }
	public Android.Graphics.PorterDuff.Mode MTintMode { get; set; }
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
}
```


### Namespace AndroidX.Wear.Activity

#### Type Changed: AndroidX.Wear.Activity.ConfirmationActivity

Modified fields:

```diff
-public const string ExtraAnimationType = "android.support.wear.activity.extra.ANIMATION_TYPE";
+public const string ExtraAnimationType = "androidx.wear.activity.extra.ANIMATION_TYPE";
-public const string ExtraMessage = "android.support.wear.activity.extra.MESSAGE";
+public const string ExtraMessage = "androidx.wear.activity.extra.MESSAGE";
```



### Namespace AndroidX.Wear.Ambient

#### Type Changed: AndroidX.Wear.Ambient.AmbientModeSupport

Added interface:

```csharp
AndroidX.SavedState.ISavedStateRegistryOwner
```



### Namespace AndroidX.Wear.Widget

#### Type Changed: AndroidX.Wear.Widget.WearableRecyclerView

Added interface:

```csharp
AndroidX.Core.View.INestedScrollingChild3
```



### Namespace AndroidX.Slice.Widget

#### Type Changed: AndroidX.Slice.Widget.LargeSliceAdapter

Removed method:

```csharp
public virtual void OnBindViewHolder (int);
```



### Namespace AndroidX.VersionedParcelable

#### Type Changed: AndroidX.VersionedParcelable.IParcelField

Added method:

```csharp
public virtual string DefaultValue ();
```


#### Type Changed: AndroidX.VersionedParcelable.IVersionedParcelize

Added method:

```csharp
public virtual Java.Lang.Class Factory ();
```


#### Type Changed: AndroidX.VersionedParcelable.ParcelFieldAttribute

Added property:

```csharp
public string DefaultValue { get; set; }
```


#### Type Changed: AndroidX.VersionedParcelable.ParcelUtils

Added methods:

```csharp
public static Java.Lang.Object GetVersionedParcelable (Android.OS.Bundle, string);
public static System.Collections.IList GetVersionedParcelableList (Android.OS.Bundle, string);
public static void PutVersionedParcelable (Android.OS.Bundle, string, IVersionedParcelable);
public static void PutVersionedParcelableList (Android.OS.Bundle, string, System.Collections.Generic.IList<IVersionedParcelable>);
```


#### Type Changed: AndroidX.VersionedParcelable.VersionedParcel

Removed constructor:

```csharp
public VersionedParcel ();
```

Added constructor:

```csharp
public VersionedParcel (AndroidX.Collection.ArrayMap, AndroidX.Collection.ArrayMap, AndroidX.Collection.ArrayMap);
```

Added properties:

```csharp
protected AndroidX.Collection.ArrayMap MParcelizerCache { get; set; }
protected AndroidX.Collection.ArrayMap MReadCache { get; set; }
protected AndroidX.Collection.ArrayMap MWriteCache { get; set; }
```

Modified methods:

```diff
 ---static--- protected Java.Lang.Object ReadFromParcel (string parcelCls, VersionedParcel versionedParcel)
 ---static--- protected void WriteToParcel (Java.Lang.Object val, VersionedParcel versionedParcel)
```

Added methods:

```csharp
protected string ReadCharSequence ();
public string ReadCharSequence (string, int);
protected virtual Java.Lang.ICharSequence ReadCharSequenceFormatted ();
public virtual Java.Lang.ICharSequence ReadCharSequenceFormatted (Java.Lang.ICharSequence, int);
public virtual System.Collections.IDictionary ReadMap (System.Collections.IDictionary, int);
protected virtual void WriteCharSequence (Java.Lang.ICharSequence);
protected void WriteCharSequence (string);
public virtual void WriteCharSequence (Java.Lang.ICharSequence, int);
public void WriteCharSequence (string, int);
public virtual void WriteMap (System.Collections.IDictionary, int);
```


#### Type Changed: AndroidX.VersionedParcelable.VersionedParcelizeAttribute

Added property:

```csharp
public Java.Lang.Class Factory { get; set; }
```



### Namespace AndroidX.WebKit

#### Type Changed: AndroidX.WebKit.WebSettingsCompat

Added fields:

```csharp
public static const int ForceDarkAuto;
public static const int ForceDarkOff;
public static const int ForceDarkOn;
```

Added methods:

```csharp
public static int GetForceDark (Android.Webkit.WebSettings);
public static void SetForceDark (Android.Webkit.WebSettings, int);
public static void SetWillSuppressErrorPage (Android.Webkit.WebSettings, bool);
public static bool WillSuppressErrorPage (Android.Webkit.WebSettings);
```

#### New Type: AndroidX.WebKit.WebSettingsCompat.IForceDark

```csharp
public interface IForceDark : Android.Runtime.IJavaObject, Java.Lang.Annotation.IAnnotation, System.IDisposable {
}
```


#### Type Changed: AndroidX.WebKit.WebViewCompat

Added property:

```csharp
public static bool IsMultiProcessEnabled { get; }
```

Added methods:

```csharp
public static Android.Webkit.WebChromeClient GetWebChromeClient (Android.Webkit.WebView);
public static Android.Webkit.WebViewClient GetWebViewClient (Android.Webkit.WebView);
public static WebViewRenderProcess GetWebViewRenderProcess (Android.Webkit.WebView);
public static WebViewRenderProcessClient GetWebViewRenderProcessClient (Android.Webkit.WebView);
public static void SetWebViewRenderProcessClient (Android.Webkit.WebView, WebViewRenderProcessClient);
public static void SetWebViewRenderProcessClient (Android.Webkit.WebView, Java.Util.Concurrent.IExecutor, WebViewRenderProcessClient);
```


#### Type Changed: AndroidX.WebKit.WebViewFeature

Added fields:

```csharp
public static const string ForceDark = "FORCE_DARK";
public static const string GetWebChromeClient = "GET_WEB_CHROME_CLIENT";
public static const string GetWebViewClient = "GET_WEB_VIEW_CLIENT";
public static const string GetWebViewRenderer = "GET_WEB_VIEW_RENDERER";
public static const string MultiProcessQuery = "MULTI_PROCESS_QUERY";
public static const string ProxyOverride = "PROXY_OVERRIDE";
public static const string SuppressErrorPage = "SUPPRESS_ERROR_PAGE";
public static const string TracingControllerBasicUsage = "TRACING_CONTROLLER_BASIC_USAGE";
public static const string WebViewRendererClientBasicUsage = "WEB_VIEW_RENDERER_CLIENT_BASIC_USAGE";
public static const string WebViewRendererTerminate = "WEB_VIEW_RENDERER_TERMINATE";
```


#### New Type: AndroidX.WebKit.ProxyConfig

```csharp
public sealed class ProxyConfig : Java.Lang.Object {
	// constructors
	public ProxyConfig (System.Collections.Generic.IList<ProxyConfig.ProxyRule>, System.Collections.Generic.IList<string>);
	// fields
	public static const string MatchAllSchemes = "*";
	public static const string MatchHttp = "http";
	public static const string MatchHttps = "https";
	// properties
	public System.Collections.Generic.IList<string> BypassRules { get; }
	public System.Collections.Generic.IList<ProxyConfig.ProxyRule> ProxyRules { get; }
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }

	// inner types
	public sealed class Builder : Java.Lang.Object {
		// constructors
		public ProxyConfig.Builder ();
		public ProxyConfig.Builder (ProxyConfig);
		// properties
		protected IntPtr ThresholdClass { get; }
		protected System.Type ThresholdType { get; }
		// methods
		public ProxyConfig.Builder AddBypassRule (string);
		public ProxyConfig.Builder AddDirect ();
		public ProxyConfig.Builder AddDirect (string);
		public ProxyConfig.Builder AddProxyRule (string);
		public ProxyConfig.Builder AddProxyRule (string, string);
		public ProxyConfig Build ();
		public ProxyConfig.Builder BypassSimpleHostnames ();
		public ProxyConfig.Builder RemoveImplicitRules ();
	}
	public interface IProxyScheme : Android.Runtime.IJavaObject, Java.Lang.Annotation.IAnnotation, System.IDisposable {
	}
	public sealed class ProxyRule : Java.Lang.Object {
		// constructors
		public ProxyConfig.ProxyRule (string);
		public ProxyConfig.ProxyRule (string, string);
		// properties
		public string SchemeFilter { get; }
		protected IntPtr ThresholdClass { get; }
		protected System.Type ThresholdType { get; }
		public string Url { get; }
	}
}
```

#### New Type: AndroidX.WebKit.ProxyController

```csharp
public abstract class ProxyController : Java.Lang.Object {
	// constructors
	public ProxyController ();
	protected ProxyController (IntPtr, Android.Runtime.JniHandleOwnership);
	// properties
	public static ProxyController Instance { get; }
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public virtual void ClearProxyOverride (Java.Util.Concurrent.IExecutor, Java.Lang.IRunnable);
	public virtual void SetProxyOverride (ProxyConfig, Java.Util.Concurrent.IExecutor, Java.Lang.IRunnable);
}
```

#### New Type: AndroidX.WebKit.TracingConfig

```csharp
public class TracingConfig : Java.Lang.Object {
	// constructors
	protected TracingConfig (IntPtr, Android.Runtime.JniHandleOwnership);
	public TracingConfig (int, System.Collections.Generic.IList<string>, int);
	// fields
	public static const int CategoriesAll;
	public static const int CategoriesAndroidWebview;
	public static const int CategoriesFrameViewer;
	public static const int CategoriesInputLatency;
	public static const int CategoriesJavascriptAndRendering;
	public static const int CategoriesNone;
	public static const int CategoriesRendering;
	public static const int CategoriesWebDeveloper;
	public static const int RecordContinuously;
	public static const int RecordUntilFull;
	// properties
	public System.Collections.Generic.IList<string> CustomIncludedCategories { get; }
	public int PredefinedCategories { get; }
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	public int TracingMode { get; }

	// inner types
	public class Builder : Java.Lang.Object {
		// constructors
		public TracingConfig.Builder ();
		protected TracingConfig.Builder (IntPtr, Android.Runtime.JniHandleOwnership);
		// properties
		protected IntPtr ThresholdClass { get; }
		protected System.Type ThresholdType { get; }
		// methods
		public virtual TracingConfig.Builder AddCategories (System.Collections.Generic.ICollection<string>);
		public virtual TracingConfig.Builder AddCategories (int[]);
		public virtual TracingConfig.Builder AddCategories (string[]);
		public virtual TracingConfig Build ();
		public virtual TracingConfig.Builder SetTracingMode (int);
	}
	public interface IPredefinedCategories : Android.Runtime.IJavaObject, Java.Lang.Annotation.IAnnotation, System.IDisposable {
	}
	public interface ITracingMode : Android.Runtime.IJavaObject, Java.Lang.Annotation.IAnnotation, System.IDisposable {
	}
}
```

#### New Type: AndroidX.WebKit.TracingController

```csharp
public abstract class TracingController : Java.Lang.Object {
	// constructors
	public TracingController ();
	protected TracingController (IntPtr, Android.Runtime.JniHandleOwnership);
	// properties
	public static TracingController Instance { get; }
	public bool IsTracing { get; }
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public virtual void Start (TracingConfig);
	public virtual bool Stop (System.IO.Stream, Java.Util.Concurrent.IExecutor);
}
```

#### New Type: AndroidX.WebKit.WebViewAssetLoader

```csharp
public sealed class WebViewAssetLoader : Java.Lang.Object {
	// fields
	public static const string DefaultDomain = "appassets.androidplatform.net";
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public Android.Webkit.WebResourceResponse ShouldInterceptRequest (Android.Net.Uri);

	// inner types
	public sealed class AssetsPathHandler : Java.Lang.Object, Android.Runtime.IJavaObject, WebViewAssetLoader.IPathHandler, System.IDisposable {
		// constructors
		public WebViewAssetLoader.AssetsPathHandler (Android.Content.Context);
		// properties
		protected IntPtr ThresholdClass { get; }
		protected System.Type ThresholdType { get; }
		// methods
		public virtual Android.Webkit.WebResourceResponse Handle (string);
	}
	public sealed class Builder : Java.Lang.Object {
		// constructors
		public WebViewAssetLoader.Builder ();
		// properties
		protected IntPtr ThresholdClass { get; }
		protected System.Type ThresholdType { get; }
		// methods
		public WebViewAssetLoader.Builder AddPathHandler (string, WebViewAssetLoader.IPathHandler);
		public WebViewAssetLoader Build ();
		public WebViewAssetLoader.Builder SetDomain (string);
		public WebViewAssetLoader.Builder SetHttpAllowed (bool);
	}
	public interface IPathHandler : Android.Runtime.IJavaObject, System.IDisposable {
		// methods
		public virtual Android.Webkit.WebResourceResponse Handle (string);
	}
	public sealed class InternalStoragePathHandler : Java.Lang.Object, Android.Runtime.IJavaObject, WebViewAssetLoader.IPathHandler, System.IDisposable {
		// constructors
		public WebViewAssetLoader.InternalStoragePathHandler (Android.Content.Context, Java.IO.File);
		// properties
		protected IntPtr ThresholdClass { get; }
		protected System.Type ThresholdType { get; }
		// methods
		public virtual Android.Webkit.WebResourceResponse Handle (string);
	}
	public class PathMatcher : Java.Lang.Object {
		// constructors
		protected WebViewAssetLoader.PathMatcher (IntPtr, Android.Runtime.JniHandleOwnership);
		// properties
		protected IntPtr ThresholdClass { get; }
		protected System.Type ThresholdType { get; }
		// methods
		public virtual string GetSuffixPath (string);
		public virtual WebViewAssetLoader.IPathHandler Match (Android.Net.Uri);
	}
	public sealed class ResourcesPathHandler : Java.Lang.Object, Android.Runtime.IJavaObject, WebViewAssetLoader.IPathHandler, System.IDisposable {
		// constructors
		public WebViewAssetLoader.ResourcesPathHandler (Android.Content.Context);
		// properties
		protected IntPtr ThresholdClass { get; }
		protected System.Type ThresholdType { get; }
		// methods
		public virtual Android.Webkit.WebResourceResponse Handle (string);
	}
}
```

#### New Type: AndroidX.WebKit.WebViewRenderProcess

```csharp
public abstract class WebViewRenderProcess : Java.Lang.Object {
	// constructors
	public WebViewRenderProcess ();
	protected WebViewRenderProcess (IntPtr, Android.Runtime.JniHandleOwnership);
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public virtual bool Terminate ();
}
```

#### New Type: AndroidX.WebKit.WebViewRenderProcessClient

```csharp
public abstract class WebViewRenderProcessClient : Java.Lang.Object {
	// constructors
	public WebViewRenderProcessClient ();
	protected WebViewRenderProcessClient (IntPtr, Android.Runtime.JniHandleOwnership);
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public virtual void OnRenderProcessResponsive (Android.Webkit.WebView, WebViewRenderProcess);
	public virtual void OnRenderProcessUnresponsive (Android.Webkit.WebView, WebViewRenderProcess);
}
```


### Namespace AndroidX.WebKit.Internal

#### Type Changed: AndroidX.WebKit.Internal.IWebViewProviderFactory

Added properties:

```csharp
public AndroidX.WebKit.ChromiumLibBoundary.IProxyControllerBoundaryInterface ProxyController { get; }
public AndroidX.WebKit.ChromiumLibBoundary.ITracingControllerBoundaryInterface TracingController { get; }
```


#### Type Changed: AndroidX.WebKit.Internal.IncompatibleApkWebViewProviderFactory

Added properties:

```csharp
public AndroidX.WebKit.ChromiumLibBoundary.IProxyControllerBoundaryInterface ProxyController { get; }
public AndroidX.WebKit.ChromiumLibBoundary.ITracingControllerBoundaryInterface TracingController { get; }
```


#### Type Changed: AndroidX.WebKit.Internal.WebSettingsAdapter

Added property:

```csharp
public int ForceDark { get; set; }
```

Added methods:

```csharp
public virtual void SetWillSuppressErrorPage (bool);
public virtual bool WillSuppressErrorPage ();
```


#### Type Changed: AndroidX.WebKit.Internal.WebViewFeatureInternal

Added properties:

```csharp
public static WebViewFeatureInternal ForceDark { get; }
public static WebViewFeatureInternal GetWebChromeClient { get; }
public static WebViewFeatureInternal GetWebViewClient { get; }
public static WebViewFeatureInternal GetWebViewRenderer { get; }
public static WebViewFeatureInternal MultiProcessQuery { get; }
public static WebViewFeatureInternal ProxyOverride { get; }
public static WebViewFeatureInternal SuppressErrorPage { get; }
public static WebViewFeatureInternal TracingControllerBasicUsage { get; }
public static System.Collections.Generic.ICollection<string> WebViewApkFeaturesForTesting { get; }
public static WebViewFeatureInternal WebViewRendererClientBasicUsage { get; }
public static WebViewFeatureInternal WebViewRendererTerminate { get; }
```

Removed method:

```csharp
public static string[] GetWebViewApkFeaturesForTesting ();
```


#### Type Changed: AndroidX.WebKit.Internal.WebViewProviderAdapter

Added properties:

```csharp
public Android.Webkit.WebChromeClient WebChromeClient { get; }
public Android.Webkit.WebViewClient WebViewClient { get; }
public AndroidX.WebKit.WebViewRenderProcess WebViewRenderProcess { get; }
public AndroidX.WebKit.WebViewRenderProcessClient WebViewRenderProcessClient { get; }
```

Added method:

```csharp
public virtual void SetWebViewRenderProcessClient (Java.Util.Concurrent.IExecutor, AndroidX.WebKit.WebViewRenderProcessClient);
```


#### Type Changed: AndroidX.WebKit.Internal.WebViewProviderFactoryAdapter

Added properties:

```csharp
public AndroidX.WebKit.ChromiumLibBoundary.IProxyControllerBoundaryInterface ProxyController { get; }
public AndroidX.WebKit.ChromiumLibBoundary.ITracingControllerBoundaryInterface TracingController { get; }
```


#### New Type: AndroidX.WebKit.Internal.AssetHelper

```csharp
public class AssetHelper : Java.Lang.Object {
	// constructors
	public AssetHelper (Android.Content.Context);
	protected AssetHelper (IntPtr, Android.Runtime.JniHandleOwnership);
	// fields
	public static const string DefaultMimeType = "text/plain";
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public static string GetCanonicalPath (Java.IO.File);
	public static Java.IO.File GetDataDir (Android.Content.Context);
	public static string GuessMimeType (string);
	public static bool IsCanonicalChildOf (Java.IO.File, Java.IO.File);
	public virtual System.IO.Stream OpenAsset (string);
	public static System.IO.Stream OpenFile (Java.IO.File);
	public virtual System.IO.Stream OpenResource (string);
}
```

#### New Type: AndroidX.WebKit.Internal.ProxyControllerImpl

```csharp
public class ProxyControllerImpl : AndroidX.WebKit.ProxyController {
	// constructors
	public ProxyControllerImpl ();
	protected ProxyControllerImpl (IntPtr, Android.Runtime.JniHandleOwnership);
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public override void ClearProxyOverride (Java.Util.Concurrent.IExecutor, Java.Lang.IRunnable);
	public override void SetProxyOverride (AndroidX.WebKit.ProxyConfig, Java.Util.Concurrent.IExecutor, Java.Lang.IRunnable);
}
```

#### New Type: AndroidX.WebKit.Internal.TracingControllerImpl

```csharp
public class TracingControllerImpl : AndroidX.WebKit.TracingController {
	// constructors
	public TracingControllerImpl ();
	protected TracingControllerImpl (IntPtr, Android.Runtime.JniHandleOwnership);
	// properties
	public bool IsTracing { get; }
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public override void Start (AndroidX.WebKit.TracingConfig);
	public override bool Stop (System.IO.Stream, Java.Util.Concurrent.IExecutor);
}
```

#### New Type: AndroidX.WebKit.Internal.WebViewRenderProcessImpl

```csharp
public class WebViewRenderProcessImpl : AndroidX.WebKit.WebViewRenderProcess {
	// constructors
	public WebViewRenderProcessImpl (AndroidX.WebKit.ChromiumLibBoundary.IWebViewRendererBoundaryInterface);
	protected WebViewRenderProcessImpl (IntPtr, Android.Runtime.JniHandleOwnership);
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public static WebViewRenderProcessImpl ForInvocationHandler (Java.Lang.Reflect.IInvocationHandler);
	public override bool Terminate ();
}
```


### Namespace AndroidX.Work

#### Type Changed: AndroidX.Work.Configuration

Added property:

```csharp
public Java.Util.Concurrent.IExecutor TaskExecutor { get; }
```

#### Type Changed: AndroidX.Work.Configuration.Builder

Added method:

```csharp
public Configuration.Builder SetTaskExecutor (Java.Util.Concurrent.IExecutor);
```


#### New Type: AndroidX.Work.Configuration.IProvider

```csharp
public interface IProvider : Android.Runtime.IJavaObject, System.IDisposable {
	// properties
	public Configuration WorkManagerConfiguration { get; }
}
```


#### Type Changed: AndroidX.Work.Data

Added methods:

```csharp
public sbyte GetByte (string, sbyte);
public byte[] GetByteArray (string);
```

#### Type Changed: AndroidX.Work.Data.Builder

Added methods:

```csharp
public Data.Builder PutByte (string, sbyte);
public Data.Builder PutByteArray (string, byte[]);
```



#### Type Changed: AndroidX.Work.IOperation

Added property:

```csharp
public Google.Common.Util.Concurrent.IListenableFuture Result { get; }
```


#### Type Changed: AndroidX.Work.ListenableWorker

Added method:

```csharp
public virtual Google.Common.Util.Concurrent.IListenableFuture StartWork ();
```


#### Type Changed: AndroidX.Work.OneTimeWorkRequest

#### Type Changed: AndroidX.Work.OneTimeWorkRequest.Builder

Added method:

```csharp
public OneTimeWorkRequest.Builder SetInitialDelay (System.TimeSpan);
```



#### Type Changed: AndroidX.Work.WorkContinuation

Added property:

```csharp
public Google.Common.Util.Concurrent.IListenableFuture WorkInfos { get; }
```


#### Type Changed: AndroidX.Work.WorkInfo

Removed constructor:

```csharp
public WorkInfo (Java.Util.UUID, WorkInfo.State, Data, System.Collections.Generic.IList<string>);
```

Added constructor:

```csharp
public WorkInfo (Java.Util.UUID, WorkInfo.State, Data, System.Collections.Generic.IList<string>, int);
```

Added property:

```csharp
public int RunAttemptCount { get; }
```


#### Type Changed: AndroidX.Work.WorkManager

Obsoleted properties:

```diff
 [Obsolete ("deprecated")]
 public static WorkManager Instance { get; }
```

Added property:

```csharp
public Google.Common.Util.Concurrent.IListenableFuture LastCancelAllTimeMillis { get; }
```

Added methods:

```csharp
public static WorkManager GetInstance (Android.Content.Context);
public virtual Google.Common.Util.Concurrent.IListenableFuture GetWorkInfoById (Java.Util.UUID);
public virtual Google.Common.Util.Concurrent.IListenableFuture GetWorkInfosByTag (string);
public virtual Google.Common.Util.Concurrent.IListenableFuture GetWorkInfosForUniqueWork (string);
```


#### Type Changed: AndroidX.Work.WorkRequest

#### Type Changed: AndroidX.Work.WorkRequest.Builder

Added method:

```csharp
public virtual Java.Lang.Object SetInitialDelay (long, Java.Util.Concurrent.TimeUnit);
```



#### Type Changed: AndroidX.Work.Worker

Added method:

```csharp
public override Google.Common.Util.Concurrent.IListenableFuture StartWork ();
```


#### New Type: AndroidX.Work.DelegatingWorkerFactory

```csharp
public class DelegatingWorkerFactory : AndroidX.Work.WorkerFactory {
	// constructors
	public DelegatingWorkerFactory ();
	protected DelegatingWorkerFactory (IntPtr, Android.Runtime.JniHandleOwnership);
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public void AddFactory (WorkerFactory);
	public override ListenableWorker CreateWorker (Android.Content.Context, string, WorkerParameters);
}
```


### Namespace AndroidX.WebKit.ChromiumLibBoundary

#### Type Changed: AndroidX.WebKit.ChromiumLibBoundary.IStaticsBoundaryInterface

Added property:

```csharp
public bool IsMultiProcessEnabled { get; }
```


#### Type Changed: AndroidX.WebKit.ChromiumLibBoundary.IWebSettingsBoundaryInterface

Added properties:

```csharp
public int ForceDark { get; set; }
public bool WillSuppressErrorPage { get; set; }
```


#### Type Changed: AndroidX.WebKit.ChromiumLibBoundary.IWebViewProviderBoundaryInterface

Added properties:

```csharp
public Android.Webkit.WebChromeClient WebChromeClient { get; }
public Android.Webkit.WebViewClient WebViewClient { get; }
public Java.Lang.Reflect.IInvocationHandler WebViewRenderer { get; }
public Java.Lang.Reflect.IInvocationHandler WebViewRendererClient { get; set; }
```


#### Type Changed: AndroidX.WebKit.ChromiumLibBoundary.IWebViewProviderFactoryBoundaryInterface

Added properties:

```csharp
public Java.Lang.Reflect.IInvocationHandler ProxyController { get; }
public Java.Lang.Reflect.IInvocationHandler TracingController { get; }
```


#### New Type: AndroidX.WebKit.ChromiumLibBoundary.IIsomorphicObjectBoundaryInterface

```csharp
public interface IIsomorphicObjectBoundaryInterface : Android.Runtime.IJavaObject, System.IDisposable {
	// methods
	public virtual Java.Lang.Object GetOrCreatePeer (Java.Util.Concurrent.ICallable);
}
```

#### New Type: AndroidX.WebKit.ChromiumLibBoundary.IProxyControllerBoundaryInterface

```csharp
public interface IProxyControllerBoundaryInterface : Android.Runtime.IJavaObject, System.IDisposable {
	// methods
	public virtual void ClearProxyOverride (Java.Lang.IRunnable, Java.Util.Concurrent.IExecutor);
	public virtual void SetProxyOverride (string[][], string[], Java.Lang.IRunnable, Java.Util.Concurrent.IExecutor);
}
```

#### New Type: AndroidX.WebKit.ChromiumLibBoundary.ITracingControllerBoundaryInterface

```csharp
public interface ITracingControllerBoundaryInterface : Android.Runtime.IJavaObject, System.IDisposable {
	// properties
	public bool IsTracing { get; }
	// methods
	public virtual void Start (int, System.Collections.Generic.ICollection<string>, int);
	public virtual bool Stop (System.IO.Stream, Java.Util.Concurrent.IExecutor);
}
```

#### New Type: AndroidX.WebKit.ChromiumLibBoundary.IWebViewRendererBoundaryInterface

```csharp
public interface IWebViewRendererBoundaryInterface : Android.Runtime.IJavaObject, IIsomorphicObjectBoundaryInterface, System.IDisposable {
	// methods
	public virtual bool Terminate ();
}
```

#### New Type: AndroidX.WebKit.ChromiumLibBoundary.IWebViewRendererClientBoundaryInterface

```csharp
public interface IWebViewRendererClientBoundaryInterface : Android.Runtime.IJavaObject, IFeatureFlagHolderBoundaryInterface, System.IDisposable {
	// methods
	public virtual void OnRendererResponsive (Android.Webkit.WebView, Java.Lang.Reflect.IInvocationHandler);
	public virtual void OnRendererUnresponsive (Android.Webkit.WebView, Java.Lang.Reflect.IInvocationHandler);
}
```


### Namespace AndroidX.WebKit.ChromiumLibBoundary.Util

#### Type Changed: AndroidX.WebKit.ChromiumLibBoundary.Util.BoundaryInterfaceReflectionUtil

Added methods:

```csharp
public static bool ContainsFeature (System.Collections.Generic.ICollection<string>, string);
public static Java.Lang.Reflect.IInvocationHandler[] CreateInvocationHandlersForArray (Java.Lang.Object[]);
public static bool InstanceOfInOwnClassLoader (Java.Lang.Object, string);
```


#### Type Changed: AndroidX.WebKit.ChromiumLibBoundary.Util.Features

Added fields:

```csharp
public static const string DevSuffix = ":dev";
public static const string ForceDark = "FORCE_DARK";
public static const string GetWebChromeClient = "GET_WEB_CHROME_CLIENT";
public static const string GetWebViewClient = "GET_WEB_VIEW_CLIENT";
public static const string GetWebViewRenderer = "GET_WEB_VIEW_RENDERER";
public static const string MultiProcessQuery = "MULTI_PROCESS_QUERY";
public static const string ProxyOverride = "PROXY_OVERRIDE:3";
public static const string SuppressErrorPage = "SUPPRESS_ERROR_PAGE";
public static const string TracingControllerBasicUsage = "TRACING_CONTROLLER_BASIC_USAGE";
public static const string WebViewRendererClientBasicUsage = "WEB_VIEW_RENDERER_CLIENT_BASIC_USAGE";
public static const string WebViewRendererTerminate = "WEB_VIEW_RENDERER_TERMINATE";
```



### Removed Namespace Android.Arch.Lifecycle


#### Removed Type Android.Arch.Lifecycle.HolderFragment
### Removed Namespace Android.Support.Constraints


#### Removed Type Android.Support.Constraints.BuildConfig
### Removed Namespace Android.Support.Constraints.Solver


#### Removed Type Android.Support.Constraints.Solver.ArrayVariables
### Removed Namespace Android.Support.Palette


#### Removed Type Android.Support.Palette.Additions
### Removed Namespace Android.Support.V4.Text


#### Removed Type Android.Support.V4.Text.TextDirectionHeuristicsCompatITextDirectionAlgorithmExtensions
### Removed Namespace Android.Support.V7.App


#### Removed Type Android.Support.V7.App.MediaRouteCastDialog
#### Removed Type Android.Support.V7.App.MediaRouteDevicePickerDialog
### Removed Namespace Android.Support.V7.Preference.Internal


#### Removed Type Android.Support.V7.Preference.Internal.AbstractMultiSelectListPreference
### Removed Namespace Android.Support.V7.View.Menu


#### Removed Type Android.Support.V7.View.Menu.IMenuHelper
#### Removed Type Android.Support.V7.View.Menu.MenuWrapperFactory
### Removed Namespace Android.Support.V7.Widget


#### Removed Type Android.Support.V7.Widget.ICardViewDelegate
### New Namespace AndroidX.Activity

#### New Type: AndroidX.Activity.ComponentActivity

```csharp
public class ComponentActivity : AndroidX.Core.App.ComponentActivity, Android.Runtime.IJavaObject, IOnBackPressedDispatcherOwner, AndroidX.Core.View.KeyEventDispatcher.IComponent, AndroidX.Lifecycle.ILifecycleOwner, AndroidX.Lifecycle.IViewModelStoreOwner, AndroidX.SavedState.ISavedStateRegistryOwner, System.IDisposable {
	// constructors
	public ComponentActivity ();
	public ComponentActivity (int);
	protected ComponentActivity (IntPtr, Android.Runtime.JniHandleOwnership);
	// properties

	[Obsolete ("deprecated")]
public Java.Lang.Object LastCustomNonConfigurationInstance { get; }
	public OnBackPressedDispatcher OnBackPressedDispatcher { get; }
	public AndroidX.SavedState.SavedStateRegistry SavedStateRegistry { get; }
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	public AndroidX.Lifecycle.ViewModelStore ViewModelStore { get; }
	// methods

	[Obsolete ("deprecated")]
public virtual Java.Lang.Object OnRetainCustomNonConfigurationInstance ();
	public override Java.Lang.Object OnRetainNonConfigurationInstance ();

	// inner types
	public sealed class NonConfigurationInstances : Java.Lang.Object {
		// properties
		protected IntPtr ThresholdClass { get; }
		protected System.Type ThresholdType { get; }
	}
}
```

#### New Type: AndroidX.Activity.IOnBackPressedDispatcherOwner

```csharp
public interface IOnBackPressedDispatcherOwner : Android.Runtime.IJavaObject, AndroidX.Lifecycle.ILifecycleOwner, System.IDisposable {
	// properties
	public OnBackPressedDispatcher OnBackPressedDispatcher { get; }
}
```

#### New Type: AndroidX.Activity.OnBackPressedCallback

```csharp
public abstract class OnBackPressedCallback : Java.Lang.Object {
	// constructors
	public OnBackPressedCallback (bool);
	protected OnBackPressedCallback (IntPtr, Android.Runtime.JniHandleOwnership);
	// properties
	public bool Enabled { get; set; }
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public virtual void HandleOnBackPressed ();
	public void Remove ();
}
```

#### New Type: AndroidX.Activity.OnBackPressedDispatcher

```csharp
public sealed class OnBackPressedDispatcher : Java.Lang.Object {
	// constructors
	public OnBackPressedDispatcher ();
	public OnBackPressedDispatcher (Java.Lang.IRunnable);
	// properties
	public bool HasEnabledCallbacks { get; }
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public void AddCallback (OnBackPressedCallback);
	public void AddCallback (AndroidX.Lifecycle.ILifecycleOwner, OnBackPressedCallback);
	public void OnBackPressed ();
}
```

### New Namespace AndroidX.AutoFill

#### New Type: AndroidX.AutoFill.HintConstants

```csharp
public sealed class HintConstants : Java.Lang.Object {
	// fields
	public static const string AutofillHintBirthDateDay = "birthDateDay";
	public static const string AutofillHintBirthDateFull = "birthDateFull";
	public static const string AutofillHintBirthDateMonth = "birthDateMonth";
	public static const string AutofillHintBirthDateYear = "birthDateYear";
	public static const string AutofillHintCreditCardExpirationDate = "creditCardExpirationDate";
	public static const string AutofillHintCreditCardExpirationDay = "creditCardExpirationDay";
	public static const string AutofillHintCreditCardExpirationMonth = "creditCardExpirationMonth";
	public static const string AutofillHintCreditCardExpirationYear = "creditCardExpirationYear";
	public static const string AutofillHintCreditCardNumber = "creditCardNumber";
	public static const string AutofillHintCreditCardSecurityCode = "creditCardSecurityCode";
	public static const string AutofillHintEmailAddress = "emailAddress";
	public static const string AutofillHintGender = "gender";

	[Obsolete ("deprecated")]
public static const string AutofillHintName = "name";
	public static const string AutofillHintNewPassword = "newPassword";
	public static const string AutofillHintNewUsername = "newUsername";
	public static const string AutofillHintPassword = "password";
	public static const string AutofillHintPersonName = "personName";
	public static const string AutofillHintPersonNameFamily = "personFamilyName";
	public static const string AutofillHintPersonNameGiven = "personGivenName";
	public static const string AutofillHintPersonNameMiddle = "personMiddleName";
	public static const string AutofillHintPersonNameMiddleInitial = "personMiddleInitial";
	public static const string AutofillHintPersonNamePrefix = "personNamePrefix";
	public static const string AutofillHintPersonNameSuffix = "personNameSuffix";

	[Obsolete ("deprecated")]
public static const string AutofillHintPhone = "phone";
	public static const string AutofillHintPhoneCountryCode = "phoneCountryCode";
	public static const string AutofillHintPhoneNational = "phoneNational";
	public static const string AutofillHintPhoneNumber = "phoneNumber";
	public static const string AutofillHintPhoneNumberDevice = "phoneNumberDevice";
	public static const string AutofillHintPostalAddress = "postalAddress";
	public static const string AutofillHintPostalAddressCountry = "addressCountry";
	public static const string AutofillHintPostalAddressExtendedAddress = "extendedAddress";
	public static const string AutofillHintPostalAddressExtendedPostalCode = "extendedPostalCode";
	public static const string AutofillHintPostalAddressLocality = "addressLocality";
	public static const string AutofillHintPostalAddressRegion = "addressRegion";
	public static const string AutofillHintPostalAddressStreetAddress = "streetAddress";
	public static const string AutofillHintPostalCode = "postalCode";
	public static const string AutofillHintSmsOtp = "smsOTPCode";
	public static const string AutofillHintUsername = "username";
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public static string GenerateSmsOtpHintForCharacterPosition (int);
}
```

### New Namespace AndroidX.Biometric

#### New Type: AndroidX.Biometric.BiometricConstants

```csharp
public abstract class BiometricConstants : Java.Lang.Object {
	// fields
	public static const int ErrorCanceled;
	public static const int ErrorHwNotPresent;
	public static const int ErrorHwUnavailable;
	public static const int ErrorLockout;
	public static const int ErrorLockoutPermanent;
	public static const int ErrorNegativeButton;
	public static const int ErrorNoBiometrics;
	public static const int ErrorNoDeviceCredential;
	public static const int ErrorNoSpace;
	public static const int ErrorTimeout;
	public static const int ErrorUnableToProcess;
	public static const int ErrorUnableToRemove;
	public static const int ErrorUserCanceled;
	public static const int ErrorVendor;
	public static const int ErrorVendorBase;
}
```

#### New Type: AndroidX.Biometric.BiometricConstantsConsts

```csharp
public abstract class BiometricConstantsConsts : AndroidX.Biometric.BiometricConstants {
}
```

#### New Type: AndroidX.Biometric.BiometricFragment

```csharp
public class BiometricFragment : AndroidX.Fragment.App.Fragment, Android.Content.IComponentCallbacks, Android.Runtime.IJavaObject, Android.Views.View.IOnCreateContextMenuListener, AndroidX.Lifecycle.ILifecycleOwner, AndroidX.Lifecycle.IViewModelStoreOwner, AndroidX.SavedState.ISavedStateRegistryOwner, System.IDisposable {
	// constructors
	public BiometricFragment ();
	protected BiometricFragment (IntPtr, Android.Runtime.JniHandleOwnership);
	// properties
	protected string NegativeButtonText { get; }
	protected Java.Lang.ICharSequence NegativeButtonTextFormatted { get; }
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public virtual void SetBundle (Android.OS.Bundle);
}
```

#### New Type: AndroidX.Biometric.BiometricManager

```csharp
public class BiometricManager : Java.Lang.Object {
	// constructors
	protected BiometricManager (IntPtr, Android.Runtime.JniHandleOwnership);
	// fields
	public static const int BiometricErrorHwUnavailable;
	public static const int BiometricErrorNoHardware;
	public static const int BiometricErrorNoneEnrolled;
	public static const int BiometricSuccess;
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public virtual int CanAuthenticate ();
	public static BiometricManager From (Android.Content.Context);
}
```

#### New Type: AndroidX.Biometric.BiometricPrompt

```csharp
public class BiometricPrompt : Java.Lang.Object {
	// constructors
	protected BiometricPrompt (IntPtr, Android.Runtime.JniHandleOwnership);
	public BiometricPrompt (AndroidX.Fragment.App.Fragment, Java.Util.Concurrent.IExecutor, BiometricPrompt.AuthenticationCallback);
	public BiometricPrompt (AndroidX.Fragment.App.FragmentActivity, Java.Util.Concurrent.IExecutor, BiometricPrompt.AuthenticationCallback);
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public virtual void Authenticate (BiometricPrompt.PromptInfo);
	public virtual void Authenticate (BiometricPrompt.PromptInfo, BiometricPrompt.CryptoObject);
	public virtual void CancelAuthentication ();

	// inner types
	public abstract class AuthenticationCallback : Java.Lang.Object {
		// constructors
		public BiometricPrompt.AuthenticationCallback ();
		protected BiometricPrompt.AuthenticationCallback (IntPtr, Android.Runtime.JniHandleOwnership);
		// properties
		protected IntPtr ThresholdClass { get; }
		protected System.Type ThresholdType { get; }
		// methods
		public virtual void OnAuthenticationError (int, Java.Lang.ICharSequence);
		public void OnAuthenticationError (int, string);
		public virtual void OnAuthenticationFailed ();
		public virtual void OnAuthenticationSucceeded (BiometricPrompt.AuthenticationResult);
	}
	public class AuthenticationResult : Java.Lang.Object {
		// constructors
		protected BiometricPrompt.AuthenticationResult (IntPtr, Android.Runtime.JniHandleOwnership);
		// properties
		public BiometricPrompt.CryptoObject CryptoObject { get; }
		protected IntPtr ThresholdClass { get; }
		protected System.Type ThresholdType { get; }
	}
	public class CryptoObject : Java.Lang.Object {
		// constructors
		public BiometricPrompt.CryptoObject (Java.Security.Signature);
		public BiometricPrompt.CryptoObject (Javax.Crypto.Cipher);
		public BiometricPrompt.CryptoObject (Javax.Crypto.Mac);
		protected BiometricPrompt.CryptoObject (IntPtr, Android.Runtime.JniHandleOwnership);
		// properties
		public Javax.Crypto.Cipher Cipher { get; }
		public Javax.Crypto.Mac Mac { get; }
		public Java.Security.Signature Signature { get; }
		protected IntPtr ThresholdClass { get; }
		protected System.Type ThresholdType { get; }
	}
	public static class InterfaceConsts {
		// fields
		public static const int ErrorCanceled;
		public static const int ErrorHwNotPresent;
		public static const int ErrorHwUnavailable;
		public static const int ErrorLockout;
		public static const int ErrorLockoutPermanent;
		public static const int ErrorNegativeButton;
		public static const int ErrorNoBiometrics;
		public static const int ErrorNoDeviceCredential;
		public static const int ErrorNoSpace;
		public static const int ErrorTimeout;
		public static const int ErrorUnableToProcess;
		public static const int ErrorUnableToRemove;
		public static const int ErrorUserCanceled;
		public static const int ErrorVendor;
		public static const int ErrorVendorBase;
	}
	public class PromptInfo : Java.Lang.Object {
		// constructors
		protected BiometricPrompt.PromptInfo (IntPtr, Android.Runtime.JniHandleOwnership);
		// properties
		public string Description { get; }
		public Java.Lang.ICharSequence DescriptionFormatted { get; }
		public bool IsConfirmationRequired { get; }
		public bool IsDeviceCredentialAllowed { get; }
		public string NegativeButtonText { get; }
		public Java.Lang.ICharSequence NegativeButtonTextFormatted { get; }
		public string Subtitle { get; }
		public Java.Lang.ICharSequence SubtitleFormatted { get; }
		protected IntPtr ThresholdClass { get; }
		protected System.Type ThresholdType { get; }
		public string Title { get; }
		public Java.Lang.ICharSequence TitleFormatted { get; }

		// inner types
		public class Builder : Java.Lang.Object {
			// constructors
			public BiometricPrompt.PromptInfo.Builder ();
			protected BiometricPrompt.PromptInfo.Builder (IntPtr, Android.Runtime.JniHandleOwnership);
			// properties
			protected IntPtr ThresholdClass { get; }
			protected System.Type ThresholdType { get; }
			// methods
			public virtual BiometricPrompt.PromptInfo Build ();
			public virtual BiometricPrompt.PromptInfo.Builder SetConfirmationRequired (bool);
			public virtual BiometricPrompt.PromptInfo.Builder SetDescription (Java.Lang.ICharSequence);
			public BiometricPrompt.PromptInfo.Builder SetDescription (string);
			public virtual BiometricPrompt.PromptInfo.Builder SetDeviceCredentialAllowed (bool);
			public virtual BiometricPrompt.PromptInfo.Builder SetNegativeButtonText (Java.Lang.ICharSequence);
			public BiometricPrompt.PromptInfo.Builder SetNegativeButtonText (string);
			public virtual BiometricPrompt.PromptInfo.Builder SetSubtitle (Java.Lang.ICharSequence);
			public BiometricPrompt.PromptInfo.Builder SetSubtitle (string);
			public virtual BiometricPrompt.PromptInfo.Builder SetTitle (Java.Lang.ICharSequence);
			public BiometricPrompt.PromptInfo.Builder SetTitle (string);
		}
	}
}
```

#### New Type: AndroidX.Biometric.DeviceCredentialHandlerActivity

```csharp
public class DeviceCredentialHandlerActivity : AndroidX.AppCompat.App.AppCompatActivity, Android.Runtime.IJavaObject, AndroidX.Activity.IOnBackPressedDispatcherOwner, AndroidX.AppCompat.App.ActionBarDrawerToggle.IDelegateProvider, AndroidX.AppCompat.App.IAppCompatCallback, AndroidX.Core.App.ActivityCompat.IOnRequestPermissionsResultCallback, AndroidX.Core.App.ActivityCompat.IRequestPermissionsRequestCodeValidator, AndroidX.Core.App.TaskStackBuilder.ISupportParentable, AndroidX.Core.View.KeyEventDispatcher.IComponent, AndroidX.Lifecycle.ILifecycleOwner, AndroidX.Lifecycle.IViewModelStoreOwner, AndroidX.SavedState.ISavedStateRegistryOwner, System.IDisposable {
	// constructors
	public DeviceCredentialHandlerActivity ();
	protected DeviceCredentialHandlerActivity (IntPtr, Android.Runtime.JniHandleOwnership);
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
}
```

#### New Type: AndroidX.Biometric.DeviceCredentialHandlerBridge

```csharp
public class DeviceCredentialHandlerBridge : Java.Lang.Object {
	// constructors
	protected DeviceCredentialHandlerBridge (IntPtr, Android.Runtime.JniHandleOwnership);
	// properties
	public FingerprintDialogFragment FingerprintDialogFragment { get; }
	public FingerprintHelperFragment FingerprintHelperFragment { get; }
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
}
```

#### New Type: AndroidX.Biometric.FingerprintDialogFragment

```csharp
public class FingerprintDialogFragment : AndroidX.Fragment.App.DialogFragment, Android.Content.IComponentCallbacks, Android.Content.IDialogInterfaceOnCancelListener, Android.Content.IDialogInterfaceOnDismissListener, Android.Runtime.IJavaObject, Android.Views.View.IOnCreateContextMenuListener, AndroidX.Lifecycle.ILifecycleOwner, AndroidX.Lifecycle.IViewModelStoreOwner, AndroidX.SavedState.ISavedStateRegistryOwner, System.IDisposable {
	// constructors
	public FingerprintDialogFragment ();
	protected FingerprintDialogFragment (IntPtr, Android.Runtime.JniHandleOwnership);
	// properties
	protected string NegativeButtonText { get; }
	protected Java.Lang.ICharSequence NegativeButtonTextFormatted { get; }
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public virtual void SetBundle (Android.OS.Bundle);

	// inner types
	public sealed class H : Android.OS.Handler {
		// properties
		protected IntPtr ThresholdClass { get; }
		protected System.Type ThresholdType { get; }
	}
}
```

#### New Type: AndroidX.Biometric.FingerprintHelperFragment

```csharp
public class FingerprintHelperFragment : AndroidX.Fragment.App.Fragment, Android.Content.IComponentCallbacks, Android.Runtime.IJavaObject, Android.Views.View.IOnCreateContextMenuListener, AndroidX.Lifecycle.ILifecycleOwner, AndroidX.Lifecycle.IViewModelStoreOwner, AndroidX.SavedState.ISavedStateRegistryOwner, System.IDisposable {
	// constructors
	public FingerprintHelperFragment ();
	protected FingerprintHelperFragment (IntPtr, Android.Runtime.JniHandleOwnership);
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }

	// inner types
	public class MessageRouter : Java.Lang.Object {
		// constructors
		protected FingerprintHelperFragment.MessageRouter (IntPtr, Android.Runtime.JniHandleOwnership);
		// properties
		protected IntPtr ThresholdClass { get; }
		protected System.Type ThresholdType { get; }
	}
}
```

### New Namespace AndroidX.Concurrent.Futures

#### New Type: AndroidX.Concurrent.Futures.AbstractResolvableFuture

```csharp
public abstract class AbstractResolvableFuture : Java.Lang.Object, Android.Runtime.IJavaObject, Google.Common.Util.Concurrent.IListenableFuture, Java.Util.Concurrent.IFuture, System.IDisposable {
	// constructors
	protected AbstractResolvableFuture ();
	protected AbstractResolvableFuture (IntPtr, Android.Runtime.JniHandleOwnership);
	// properties
	public bool IsCancelled { get; }
	public bool IsDone { get; }
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public virtual void AddListener (Java.Lang.IRunnable, Java.Util.Concurrent.IExecutor);
	protected virtual void AfterDone ();
	public virtual bool Cancel (bool);
	public virtual Java.Lang.Object Get ();
	public virtual Java.Lang.Object Get (long, Java.Util.Concurrent.TimeUnit);
	protected virtual void InterruptTask ();
	protected virtual string PendingToString ();
	protected virtual bool Set (Java.Lang.Object);
	protected virtual bool SetException (Java.Lang.Throwable);
	protected virtual bool SetFuture (Google.Common.Util.Concurrent.IListenableFuture);
	protected bool WasInterrupted ();
}
```

#### New Type: AndroidX.Concurrent.Futures.CallbackToFutureAdapter

```csharp
public sealed class CallbackToFutureAdapter : Java.Lang.Object {
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public static Google.Common.Util.Concurrent.IListenableFuture GetFuture (CallbackToFutureAdapter.IResolver);

	// inner types
	public sealed class Completer : Java.Lang.Object {
		// properties
		protected IntPtr ThresholdClass { get; }
		protected System.Type ThresholdType { get; }
		// methods
		public void AddCancellationListener (Java.Lang.IRunnable, Java.Util.Concurrent.IExecutor);
		public bool Set (Java.Lang.Object);
		public bool SetCancelled ();
		public bool SetException (Java.Lang.Throwable);
	}
	public sealed class FutureGarbageCollectedException : Java.Lang.Throwable {
		// properties
		protected IntPtr ThresholdClass { get; }
		protected System.Type ThresholdType { get; }
	}
	public interface IResolver : Android.Runtime.IJavaObject, System.IDisposable {
		// methods
		public virtual Java.Lang.Object AttachCompleter (CallbackToFutureAdapter.Completer);
	}
}
```

#### New Type: AndroidX.Concurrent.Futures.ResolvableFuture

```csharp
public sealed class ResolvableFuture : AndroidX.Concurrent.Futures.AbstractResolvableFuture, Android.Runtime.IJavaObject, Google.Common.Util.Concurrent.IListenableFuture, Java.Util.Concurrent.IFuture, System.IDisposable {
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public static ResolvableFuture Create ();
	public bool Set (Java.Lang.Object);
	public bool SetException (Java.Lang.Throwable);
	public bool SetFuture (Google.Common.Util.Concurrent.IListenableFuture);
}
```

### New Namespace AndroidX.ContentPager.Content

#### New Type: AndroidX.ContentPager.Content.ContentPager

```csharp
public class ContentPager : Java.Lang.Object {
	// constructors
	public ContentPager (Android.Content.ContentResolver, ContentPager.IQueryRunner);
	protected ContentPager (IntPtr, Android.Runtime.JniHandleOwnership);
	public ContentPager (Android.Content.ContentResolver, ContentPager.IQueryRunner, int);
	// fields
	public static const int CursorDispositionCopied;
	public static const int CursorDispositionPaged;
	public static const int CursorDispositionRepaged;
	public static const int CursorDispositionWrapped;
	public static const string ExtraHonoredArgs = "android.content.extra.HONORED_ARGS";
	public static const string ExtraRequestedLimit = "android-support:extra-ignored-limit";
	public static const string ExtraSuggestedLimit = "android-support:extra-suggested-limit";
	public static const string ExtraTotalCount = "android.content.extra.TOTAL_COUNT";
	public static const string QueryArgLimit = "android:query-arg-limit";
	public static const string QueryArgOffset = "android:query-arg-offset";
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public static Android.OS.Bundle CreateArgs (int, int);
	public virtual Query Query (Android.Net.Uri, string[], Android.OS.Bundle, Android.OS.CancellationSignal, ContentPager.IContentCallback);
	public virtual void Reset ();

	// inner types
	public interface IContentCallback : Android.Runtime.IJavaObject, System.IDisposable {
		// methods
		public virtual void OnCursorReady (Query, Android.Database.ICursor);
	}
	public interface ICursorDisposition : Android.Runtime.IJavaObject, Java.Lang.Annotation.IAnnotation, System.IDisposable {
	}
	public interface IQueryRunner : Android.Runtime.IJavaObject, System.IDisposable {
		// methods
		public virtual void Cancel (Query);
		public virtual bool IsRunning (Query);
		public virtual void Query (Query, ContentPager.IQueryRunnerCallback);
	}
	public interface IQueryRunnerCallback : Android.Runtime.IJavaObject, System.IDisposable {
		// methods
		public virtual void OnQueryFinished (Query, Android.Database.ICursor);
		public virtual Android.Database.ICursor RunQueryInBackground (Query);
	}
	public sealed class Stats : Java.Lang.Object {
		// properties
		protected IntPtr ThresholdClass { get; }
		protected System.Type ThresholdType { get; }
	}
}
```

#### New Type: AndroidX.ContentPager.Content.LoaderQueryRunner

```csharp
public sealed class LoaderQueryRunner : Java.Lang.Object, Android.Runtime.IJavaObject, ContentPager.IQueryRunner, System.IDisposable {
	// constructors
	public LoaderQueryRunner (Android.Content.Context, Android.App.LoaderManager);
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public virtual void Cancel (Query);
	public virtual bool IsRunning (Query);
	public virtual void Query (Query, ContentPager.IQueryRunnerCallback);
}
```

#### New Type: AndroidX.ContentPager.Content.Query

```csharp
public sealed class Query : Java.Lang.Object {
	// properties
	public int Id { get; }
	public int Limit { get; }
	public int Offset { get; }
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	public Android.Net.Uri Uri { get; }
}
```

### New Namespace AndroidX.Core.Location

#### New Type: AndroidX.Core.Location.LocationManagerCompat

```csharp
public sealed class LocationManagerCompat : Java.Lang.Object {
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public static bool IsLocationEnabled (Android.Locations.LocationManager);
}
```

### New Namespace AndroidX.Core.Telephony.Mbms

#### New Type: AndroidX.Core.Telephony.Mbms.MbmsHelper

```csharp
public sealed class MbmsHelper : Java.Lang.Object {
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public static string GetBestNameForService (Android.Content.Context, Android.Telephony.Mbms.ServiceInfo);
	public static Java.Lang.ICharSequence GetBestNameForServiceFormatted (Android.Content.Context, Android.Telephony.Mbms.ServiceInfo);
}
```

### New Namespace AndroidX.Medai2.Common

#### New Type: AndroidX.Medai2.Common.BaseResult

```csharp
public abstract class BaseResult : Java.Lang.Object {
	// fields
	public static const int ResultErrorBadValue;
	public static const int ResultErrorInvalidState;
	public static const int ResultErrorIo;
	public static const int ResultErrorNotSupported;
	public static const int ResultErrorPermissionDenied;
	public static const int ResultErrorUnknown;
	public static const int ResultInfoSkipped;
	public static const int ResultSuccess;
}
```

#### New Type: AndroidX.Medai2.Common.BaseResultConsts

```csharp
public abstract class BaseResultConsts : AndroidX.Medai2.Common.BaseResult {
}
```

#### New Type: AndroidX.Medai2.Common.BitmapEntryParcelizer

```csharp
public sealed class BitmapEntryParcelizer : Java.Lang.Object {
	// constructors
	public BitmapEntryParcelizer ();
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public static Java.Lang.Object Read (AndroidX.VersionedParcelable.VersionedParcel);
}
```

#### New Type: AndroidX.Medai2.Common.CallbackMediaItem

```csharp
public class CallbackMediaItem : AndroidX.Medai2.Common.MediaItem, Android.Runtime.IJavaObject, AndroidX.VersionedParcelable.IVersionedParcelable, System.IDisposable {
	// constructors
	protected CallbackMediaItem (IntPtr, Android.Runtime.JniHandleOwnership);
	// properties
	public DataSourceCallback DataSourceCallback { get; }
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }

	// inner types
	public sealed class Builder : AndroidX.Medai2.Common.MediaItem+Builder {
		// constructors
		public CallbackMediaItem.Builder (DataSourceCallback);
		// properties
		protected IntPtr ThresholdClass { get; }
		protected System.Type ThresholdType { get; }
	}
}
```

#### New Type: AndroidX.Medai2.Common.CallbackMediaItemParcelizer

```csharp
public sealed class CallbackMediaItemParcelizer : Java.Lang.Object {
	// constructors
	public CallbackMediaItemParcelizer ();
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public static CallbackMediaItem Read (AndroidX.VersionedParcelable.VersionedParcel);
	public static void Write (CallbackMediaItem, AndroidX.VersionedParcelable.VersionedParcel);
}
```

#### New Type: AndroidX.Medai2.Common.DataSourceCallback

```csharp
public abstract class DataSourceCallback : Java.Lang.Object, Android.Runtime.IJavaObject, Java.IO.ICloseable, System.IDisposable {
	// constructors
	public DataSourceCallback ();
	protected DataSourceCallback (IntPtr, Android.Runtime.JniHandleOwnership);
	// properties
	public long Size { get; }
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public virtual void Close ();
	public virtual int ReadAt (long, byte[], int, int);
}
```

#### New Type: AndroidX.Medai2.Common.FileMediaItem

```csharp
public class FileMediaItem : AndroidX.Medai2.Common.MediaItem, Android.Runtime.IJavaObject, AndroidX.VersionedParcelable.IVersionedParcelable, System.IDisposable {
	// constructors
	protected FileMediaItem (IntPtr, Android.Runtime.JniHandleOwnership);
	// fields
	public static const long FdLengthUnknown;
	// properties
	public long FileDescriptorLength { get; }
	public long FileDescriptorOffset { get; }
	public bool IsClosed { get; }
	public Android.OS.ParcelFileDescriptor ParcelFileDescriptor { get; }
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public virtual void Close ();
	public virtual void DecreaseRefCount ();
	public virtual void IncreaseRefCount ();

	// inner types
	public sealed class Builder : AndroidX.Medai2.Common.MediaItem+Builder {
		// constructors
		public FileMediaItem.Builder (Android.OS.ParcelFileDescriptor);
		// properties
		protected IntPtr ThresholdClass { get; }
		protected System.Type ThresholdType { get; }
		// methods
		public FileMediaItem.Builder SetFileDescriptorLength (long);
		public FileMediaItem.Builder SetFileDescriptorOffset (long);
	}
}
```

#### New Type: AndroidX.Medai2.Common.FileMediaItemParcelizer

```csharp
public sealed class FileMediaItemParcelizer : Java.Lang.Object {
	// constructors
	public FileMediaItemParcelizer ();
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public static FileMediaItem Read (AndroidX.VersionedParcelable.VersionedParcel);
	public static void Write (FileMediaItem, AndroidX.VersionedParcelable.VersionedParcel);
}
```

#### New Type: AndroidX.Medai2.Common.IBaseResult

```csharp
public interface IBaseResult : Android.Runtime.IJavaObject, System.IDisposable {
	// properties
	public long CompletionTime { get; }
	public MediaItem MediaItem { get; }
	public int ResultCode { get; }
}
```

#### New Type: AndroidX.Medai2.Common.IRating

```csharp
public interface IRating : Android.Runtime.IJavaObject, AndroidX.VersionedParcelable.IVersionedParcelable, System.IDisposable {
	// properties
	public bool IsRated { get; }
}
```

#### New Type: AndroidX.Medai2.Common.MediaItem

```csharp
public class MediaItem : AndroidX.VersionedParcelable.CustomVersionedParcelable, Android.Runtime.IJavaObject, AndroidX.VersionedParcelable.IVersionedParcelable, System.IDisposable {
	// constructors
	protected MediaItem (IntPtr, Android.Runtime.JniHandleOwnership);
	// fields
	public static const long PositionUnknown;
	// properties
	public long EndPosition { get; }
	public string MediaId { get; }
	public MediaMetadata Metadata { get; set; }
	public long StartPosition { get; }
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public virtual void AddOnMetadataChangedListener (Java.Util.Concurrent.IExecutor, MediaItem.IOnMetadataChangedListener);
	public virtual void RemoveOnMetadataChangedListener (MediaItem.IOnMetadataChangedListener);

	// inner types
	public class Builder : Java.Lang.Object {
		// constructors
		public MediaItem.Builder ();
		protected MediaItem.Builder (IntPtr, Android.Runtime.JniHandleOwnership);
		// properties
		protected IntPtr ThresholdClass { get; }
		protected System.Type ThresholdType { get; }
		// methods
		public virtual MediaItem Build ();
		public virtual MediaItem.Builder SetEndPosition (long);
		public virtual MediaItem.Builder SetMetadata (MediaMetadata);
		public virtual MediaItem.Builder SetStartPosition (long);
	}
	public interface IOnMetadataChangedListener : Android.Runtime.IJavaObject, System.IDisposable {
		// methods
		public virtual void OnMetadataChanged (MediaItem);
	}
	public class MetadataChangedEventArgs : System.EventArgs {
		// constructors
		public MediaItem.MetadataChangedEventArgs (MediaItem);
		// properties
		public MediaItem P0 { get; }
	}
}
```

#### New Type: AndroidX.Medai2.Common.MediaItemParcelizer

```csharp
public sealed class MediaItemParcelizer : Java.Lang.Object {
	// constructors
	public MediaItemParcelizer ();
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public static MediaItem Read (AndroidX.VersionedParcelable.VersionedParcel);
	public static void Write (MediaItem, AndroidX.VersionedParcelable.VersionedParcel);
}
```

#### New Type: AndroidX.Medai2.Common.MediaMetadata

```csharp
public sealed class MediaMetadata : AndroidX.VersionedParcelable.CustomVersionedParcelable, Android.Runtime.IJavaObject, AndroidX.VersionedParcelable.IVersionedParcelable, System.IDisposable {
	// fields
	public static const long BrowsableTypeAlbums;
	public static const long BrowsableTypeArtists;
	public static const long BrowsableTypeGenres;
	public static const long BrowsableTypeMixed;
	public static const long BrowsableTypeNone;
	public static const long BrowsableTypePlaylists;
	public static const long BrowsableTypeTitles;
	public static const long BrowsableTypeYears;
	public static const string MetadataKeyAdvertisement = "androidx.media2.metadata.ADVERTISEMENT";
	public static const string MetadataKeyAlbum = "android.media.metadata.ALBUM";
	public static const string MetadataKeyAlbumArt = "android.media.metadata.ALBUM_ART";
	public static const string MetadataKeyAlbumArtUri = "android.media.metadata.ALBUM_ART_URI";
	public static const string MetadataKeyAlbumArtist = "android.media.metadata.ALBUM_ARTIST";
	public static const string MetadataKeyArt = "android.media.metadata.ART";
	public static const string MetadataKeyArtUri = "android.media.metadata.ART_URI";
	public static const string MetadataKeyArtist = "android.media.metadata.ARTIST";
	public static const string MetadataKeyAuthor = "android.media.metadata.AUTHOR";
	public static const string MetadataKeyBrowsable = "androidx.media2.metadata.BROWSABLE";
	public static const string MetadataKeyCompilation = "android.media.metadata.COMPILATION";
	public static const string MetadataKeyComposer = "android.media.metadata.COMPOSER";
	public static const string MetadataKeyDate = "android.media.metadata.DATE";
	public static const string MetadataKeyDiscNumber = "android.media.metadata.DISC_NUMBER";
	public static const string MetadataKeyDisplayDescription = "android.media.metadata.DISPLAY_DESCRIPTION";
	public static const string MetadataKeyDisplayIcon = "android.media.metadata.DISPLAY_ICON";
	public static const string MetadataKeyDisplayIconUri = "android.media.metadata.DISPLAY_ICON_URI";
	public static const string MetadataKeyDisplaySubtitle = "android.media.metadata.DISPLAY_SUBTITLE";
	public static const string MetadataKeyDisplayTitle = "android.media.metadata.DISPLAY_TITLE";
	public static const string MetadataKeyDownloadStatus = "androidx.media2.metadata.DOWNLOAD_STATUS";
	public static const string MetadataKeyDuration = "android.media.metadata.DURATION";
	public static const string MetadataKeyExtras = "androidx.media2.metadata.EXTRAS";
	public static const string MetadataKeyGenre = "android.media.metadata.GENRE";
	public static const string MetadataKeyMediaId = "android.media.metadata.MEDIA_ID";
	public static const string MetadataKeyMediaUri = "android.media.metadata.MEDIA_URI";
	public static const string MetadataKeyNumTracks = "android.media.metadata.NUM_TRACKS";
	public static const string MetadataKeyPlayable = "androidx.media2.metadata.PLAYABLE";
	public static const string MetadataKeyRadioFrequency = "androidx.media2.metadata.RADIO_FREQUENCY";
	public static const string MetadataKeyRadioProgramName = "androidx.media2.metadata.RADIO_PROGRAM_NAME";
	public static const string MetadataKeyRating = "android.media.metadata.RATING";
	public static const string MetadataKeyTitle = "android.media.metadata.TITLE";
	public static const string MetadataKeyTrackNumber = "android.media.metadata.TRACK_NUMBER";
	public static const string MetadataKeyUserRating = "android.media.metadata.USER_RATING";
	public static const string MetadataKeyWriter = "android.media.metadata.WRITER";
	public static const string MetadataKeyYear = "android.media.metadata.YEAR";
	public static const long StatusDownloaded;
	public static const long StatusDownloading;
	public static const long StatusNotDownloaded;
	// properties
	public Android.OS.Bundle Extras { get; }
	public string MediaId { get; }
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public bool ContainsKey (string);
	public Android.Graphics.Bitmap GetBitmap (string);
	public float GetFloat (string);
	public long GetLong (string);
	public Java.Lang.Object GetObject (string);
	public IRating GetRating (string);
	public string GetString (string);
	public string GetText (string);
	public Java.Lang.ICharSequence GetTextFormatted (string);
	public System.Collections.Generic.ICollection<string> KeySet ();
	public int Size ();

	// inner types
	public sealed class BitmapEntry : Java.Lang.Object, Android.Runtime.IJavaObject, AndroidX.VersionedParcelable.IVersionedParcelable, System.IDisposable {
		// properties
		protected IntPtr ThresholdClass { get; }
		protected System.Type ThresholdType { get; }
	}
	public sealed class Builder : Java.Lang.Object {
		// constructors
		public MediaMetadata.Builder ();
		public MediaMetadata.Builder (MediaMetadata);
		// properties
		protected IntPtr ThresholdClass { get; }
		protected System.Type ThresholdType { get; }
		// methods
		public MediaMetadata Build ();
		public MediaMetadata.Builder PutBitmap (string, Android.Graphics.Bitmap);
		public MediaMetadata.Builder PutFloat (string, float);
		public MediaMetadata.Builder PutLong (string, long);
		public MediaMetadata.Builder PutRating (string, IRating);
		public MediaMetadata.Builder PutString (string, string);
		public MediaMetadata.Builder PutText (string, Java.Lang.ICharSequence);
		public MediaMetadata.Builder PutText (string, string);
		public MediaMetadata.Builder SetExtras (Android.OS.Bundle);
	}
	public interface IBitmapKey : Android.Runtime.IJavaObject, Java.Lang.Annotation.IAnnotation, System.IDisposable {
	}
	public interface IBundleKey : Android.Runtime.IJavaObject, Java.Lang.Annotation.IAnnotation, System.IDisposable {
	}
	public interface IFloatKey : Android.Runtime.IJavaObject, Java.Lang.Annotation.IAnnotation, System.IDisposable {
	}
	public interface ILongKey : Android.Runtime.IJavaObject, Java.Lang.Annotation.IAnnotation, System.IDisposable {
	}
	public interface IRatingKey : Android.Runtime.IJavaObject, Java.Lang.Annotation.IAnnotation, System.IDisposable {
	}
	public interface ITextKey : Android.Runtime.IJavaObject, Java.Lang.Annotation.IAnnotation, System.IDisposable {
	}
}
```

#### New Type: AndroidX.Medai2.Common.MediaMetadataParcelizer

```csharp
public sealed class MediaMetadataParcelizer : Java.Lang.Object {
	// constructors
	public MediaMetadataParcelizer ();
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public static MediaMetadata Read (AndroidX.VersionedParcelable.VersionedParcel);
	public static void Write (MediaMetadata, AndroidX.VersionedParcelable.VersionedParcel);
}
```

#### New Type: AndroidX.Medai2.Common.MediaParcelUtils

```csharp
public class MediaParcelUtils : Java.Lang.Object {
	// constructors
	public MediaParcelUtils ();
	protected MediaParcelUtils (IntPtr, Android.Runtime.JniHandleOwnership);
	// fields
	public static const string Tag = "MediaParcelUtils";
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public static Java.Lang.Object FromParcelable (AndroidX.VersionedParcelable.ParcelImpl);
	public static System.Collections.IList FromParcelableList (System.Collections.Generic.IList<AndroidX.VersionedParcelable.ParcelImpl>);
	public static AndroidX.VersionedParcelable.ParcelImpl ToParcelable (AndroidX.VersionedParcelable.IVersionedParcelable);
	public static System.Collections.Generic.IList<AndroidX.VersionedParcelable.ParcelImpl> ToParcelableList (System.Collections.Generic.IList<AndroidX.VersionedParcelable.IVersionedParcelable>);
}
```

#### New Type: AndroidX.Medai2.Common.ParcelImplListSlice

```csharp
public class ParcelImplListSlice : Java.Lang.Object, Android.OS.IParcelable, Android.Runtime.IJavaObject, System.IDisposable {
	// constructors
	public ParcelImplListSlice (System.Collections.Generic.IList<AndroidX.VersionedParcelable.ParcelImpl>);
	protected ParcelImplListSlice (IntPtr, Android.Runtime.JniHandleOwnership);
	// properties
	public static Android.OS.IParcelableCreator Creator { get; }
	public System.Collections.Generic.IList<AndroidX.VersionedParcelable.ParcelImpl> List { get; }
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public virtual int DescribeContents ();
	public virtual void WriteToParcel (Android.OS.Parcel, Android.OS.ParcelableWriteFlags);
}
```

#### New Type: AndroidX.Medai2.Common.SessionPlayer

```csharp
public abstract class SessionPlayer : Java.Lang.Object, Android.Runtime.IJavaObject, Java.Lang.IAutoCloseable, System.IDisposable {
	// constructors
	public SessionPlayer ();
	protected SessionPlayer (IntPtr, Android.Runtime.JniHandleOwnership);
	// fields
	public static const int BufferingStateBufferingAndPlayable;
	public static const int BufferingStateBufferingAndStarved;
	public static const int BufferingStateComplete;
	public static const int BufferingStateUnknown;
	public static const int InvalidItemIndex;
	public static const int PlayerStateError;
	public static const int PlayerStateIdle;
	public static const int PlayerStatePaused;
	public static const int PlayerStatePlaying;
	public static const int RepeatModeAll;
	public static const int RepeatModeGroup;
	public static const int RepeatModeNone;
	public static const int RepeatModeOne;
	public static const int ShuffleModeAll;
	public static const int ShuffleModeGroup;
	public static const int ShuffleModeNone;
	public static const long UnknownTime;
	// properties
	public AndroidX.Media.AudioAttributesCompat AudioAttributes { get; }
	public long BufferedPosition { get; }
	public int BufferingState { get; }
	protected System.Collections.Generic.IList<AndroidX.Core.Util.Pair> Callbacks { get; }
	public MediaItem CurrentMediaItem { get; }
	public int CurrentMediaItemIndex { get; }
	public long CurrentPosition { get; }
	public long Duration { get; }
	public int NextMediaItemIndex { get; }
	public float PlaybackSpeed { get; }
	public int PlayerState { get; }
	public System.Collections.Generic.IList<MediaItem> Playlist { get; }
	public MediaMetadata PlaylistMetadata { get; }
	public int PreviousMediaItemIndex { get; }
	public int RepeatMode { get; }
	public int ShuffleMode { get; }
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	public System.Collections.Generic.IList<SessionPlayer.TrackInfo> TrackInfoInternal { get; }
	public VideoSize VideoSizeInternal { get; }
	// methods
	public virtual Google.Common.Util.Concurrent.IListenableFuture AddPlaylistItem (int, MediaItem);
	public virtual void Close ();
	public virtual Google.Common.Util.Concurrent.IListenableFuture DeselectTrackInternal (SessionPlayer.TrackInfo);
	public virtual SessionPlayer.TrackInfo GetSelectedTrackInternal (int);
	public virtual Google.Common.Util.Concurrent.IListenableFuture Pause ();
	public virtual Google.Common.Util.Concurrent.IListenableFuture Play ();
	public virtual Google.Common.Util.Concurrent.IListenableFuture Prepare ();
	public void RegisterPlayerCallback (Java.Util.Concurrent.IExecutor, SessionPlayer.PlayerCallback);
	public virtual Google.Common.Util.Concurrent.IListenableFuture RemovePlaylistItem (int);
	public virtual Google.Common.Util.Concurrent.IListenableFuture ReplacePlaylistItem (int, MediaItem);
	public virtual Google.Common.Util.Concurrent.IListenableFuture SeekTo (long);
	public virtual Google.Common.Util.Concurrent.IListenableFuture SelectTrackInternal (SessionPlayer.TrackInfo);
	public virtual Google.Common.Util.Concurrent.IListenableFuture SetAudioAttributes (AndroidX.Media.AudioAttributesCompat);
	public virtual Google.Common.Util.Concurrent.IListenableFuture SetMediaItem (MediaItem);
	public virtual Google.Common.Util.Concurrent.IListenableFuture SetPlaybackSpeed (float);
	public virtual Google.Common.Util.Concurrent.IListenableFuture SetPlaylist (System.Collections.Generic.IList<MediaItem>, MediaMetadata);
	public virtual Google.Common.Util.Concurrent.IListenableFuture SetRepeatMode (int);
	public virtual Google.Common.Util.Concurrent.IListenableFuture SetShuffleMode (int);
	public virtual Google.Common.Util.Concurrent.IListenableFuture SetSurfaceInternal (Android.Views.Surface);
	public virtual Google.Common.Util.Concurrent.IListenableFuture SkipToNextPlaylistItem ();
	public virtual Google.Common.Util.Concurrent.IListenableFuture SkipToPlaylistItem (int);
	public virtual Google.Common.Util.Concurrent.IListenableFuture SkipToPreviousPlaylistItem ();
	public void UnregisterPlayerCallback (SessionPlayer.PlayerCallback);
	public virtual Google.Common.Util.Concurrent.IListenableFuture UpdatePlaylistMetadata (MediaMetadata);

	// inner types
	public interface IBuffState : Android.Runtime.IJavaObject, Java.Lang.Annotation.IAnnotation, System.IDisposable {
	}
	public interface IPlayerState : Android.Runtime.IJavaObject, Java.Lang.Annotation.IAnnotation, System.IDisposable {
	}
	public interface IRepeatMode : Android.Runtime.IJavaObject, Java.Lang.Annotation.IAnnotation, System.IDisposable {
	}
	public interface IShuffleMode : Android.Runtime.IJavaObject, Java.Lang.Annotation.IAnnotation, System.IDisposable {
	}
	public abstract class PlayerCallback : Java.Lang.Object {
		// constructors
		public SessionPlayer.PlayerCallback ();
		protected SessionPlayer.PlayerCallback (IntPtr, Android.Runtime.JniHandleOwnership);
		// properties
		protected IntPtr ThresholdClass { get; }
		protected System.Type ThresholdType { get; }
		// methods
		public virtual void OnAudioAttributesChanged (SessionPlayer, AndroidX.Media.AudioAttributesCompat);
		public virtual void OnBufferingStateChanged (SessionPlayer, MediaItem, int);
		public virtual void OnCurrentMediaItemChanged (SessionPlayer, MediaItem);
		public virtual void OnPlaybackCompleted (SessionPlayer);
		public virtual void OnPlaybackSpeedChanged (SessionPlayer, float);
		public virtual void OnPlayerStateChanged (SessionPlayer, int);
		public virtual void OnPlaylistChanged (SessionPlayer, System.Collections.Generic.IList<MediaItem>, MediaMetadata);
		public virtual void OnPlaylistMetadataChanged (SessionPlayer, MediaMetadata);
		public virtual void OnRepeatModeChanged (SessionPlayer, int);
		public virtual void OnSeekCompleted (SessionPlayer, long);
		public virtual void OnShuffleModeChanged (SessionPlayer, int);
		public virtual void OnSubtitleData (SessionPlayer, MediaItem, SessionPlayer.TrackInfo, SubtitleData);
		public virtual void OnTrackDeselected (SessionPlayer, SessionPlayer.TrackInfo);
		public virtual void OnTrackInfoChanged (SessionPlayer, System.Collections.Generic.IList<SessionPlayer.TrackInfo>);
		public virtual void OnTrackSelected (SessionPlayer, SessionPlayer.TrackInfo);
		public virtual void OnVideoSizeChangedInternal (SessionPlayer, MediaItem, VideoSize);
	}
	public class PlayerResult : Java.Lang.Object, Android.Runtime.IJavaObject, IBaseResult, System.IDisposable {
		// constructors
		public SessionPlayer.PlayerResult (int, MediaItem);
		protected SessionPlayer.PlayerResult (IntPtr, Android.Runtime.JniHandleOwnership);
		// properties
		public long CompletionTime { get; }
		public MediaItem MediaItem { get; }
		public int ResultCode { get; }
		protected IntPtr ThresholdClass { get; }
		protected System.Type ThresholdType { get; }
		// methods
		public static Google.Common.Util.Concurrent.IListenableFuture CreateFuture (int);

		// inner types
		public interface IResultCode : Android.Runtime.IJavaObject, Java.Lang.Annotation.IAnnotation, System.IDisposable {
		}
		public static class InterfaceConsts {
			// fields
			public static const int ResultErrorBadValue;
			public static const int ResultErrorInvalidState;
			public static const int ResultErrorIo;
			public static const int ResultErrorNotSupported;
			public static const int ResultErrorPermissionDenied;
			public static const int ResultErrorUnknown;
			public static const int ResultInfoSkipped;
			public static const int ResultSuccess;
		}
	}
	public sealed class TrackInfo : AndroidX.VersionedParcelable.CustomVersionedParcelable, Android.Runtime.IJavaObject, AndroidX.VersionedParcelable.IVersionedParcelable, System.IDisposable {
		// constructors
		public SessionPlayer.PlayerResult.TrackInfo (int, MediaItem, int, Android.Media.MediaFormat);
		// fields
		public static const int MediaTrackTypeAudio;
		public static const int MediaTrackTypeMetadata;
		public static const int MediaTrackTypeSubtitle;
		public static const int MediaTrackTypeUnknown;
		public static const int MediaTrackTypeVideo;
		// properties
		public Android.Media.MediaFormat Format { get; }
		public int Id { get; }
		public Java.Util.Locale Language { get; }
		public MediaItem MediaItem { get; }
		protected IntPtr ThresholdClass { get; }
		protected System.Type ThresholdType { get; }
		public int TrackType { get; }

		// inner types
		public interface IMediaTrackType : Android.Runtime.IJavaObject, Java.Lang.Annotation.IAnnotation, System.IDisposable {
		}
	}
}
```

#### New Type: AndroidX.Medai2.Common.SubtitleData

```csharp
public sealed class SubtitleData : Java.Lang.Object, Android.Runtime.IJavaObject, AndroidX.VersionedParcelable.IVersionedParcelable, System.IDisposable {
	// constructors
	public SubtitleData (long, long, byte[]);
	// fields
	public static const string MimetypeTextCea608 = "text/cea-608";
	public static const string MimetypeTextCea708 = "text/cea-708";
	public static const string MimetypeTextVtt = "text/vtt";
	// properties
	public long DurationUs { get; }
	public long StartTimeUs { get; }
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public byte[] GetData ();
}
```

#### New Type: AndroidX.Medai2.Common.SubtitleDataParcelizer

```csharp
public sealed class SubtitleDataParcelizer : Java.Lang.Object {
	// constructors
	public SubtitleDataParcelizer ();
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public static SubtitleData Read (AndroidX.VersionedParcelable.VersionedParcel);
	public static void Write (SubtitleData, AndroidX.VersionedParcelable.VersionedParcel);
}
```

#### New Type: AndroidX.Medai2.Common.TrackInfoParcelizer

```csharp
public sealed class TrackInfoParcelizer : Java.Lang.Object {
	// constructors
	public TrackInfoParcelizer ();
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public static SessionPlayer.TrackInfo Read (AndroidX.VersionedParcelable.VersionedParcel);
	public static void Write (SessionPlayer.TrackInfo, AndroidX.VersionedParcelable.VersionedParcel);
}
```

#### New Type: AndroidX.Medai2.Common.UriMediaItem

```csharp
public class UriMediaItem : AndroidX.Medai2.Common.MediaItem, Android.Runtime.IJavaObject, AndroidX.VersionedParcelable.IVersionedParcelable, System.IDisposable {
	// constructors
	protected UriMediaItem (IntPtr, Android.Runtime.JniHandleOwnership);
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	public Android.Net.Uri Uri { get; }
	public System.Collections.Generic.IList<Java.Net.HttpCookie> UriCookies { get; }
	public System.Collections.Generic.IDictionary<System.String,System.String> UriHeaders { get; }

	// inner types
	public sealed class Builder : AndroidX.Medai2.Common.MediaItem+Builder {
		// constructors
		public UriMediaItem.Builder (Android.Net.Uri);
		public UriMediaItem.Builder (Android.Net.Uri, System.Collections.Generic.IDictionary<System.String,System.String>, System.Collections.Generic.IList<Java.Net.HttpCookie>);
		// properties
		protected IntPtr ThresholdClass { get; }
		protected System.Type ThresholdType { get; }
	}
}
```

#### New Type: AndroidX.Medai2.Common.UriMediaItemParcelizer

```csharp
public sealed class UriMediaItemParcelizer : Java.Lang.Object {
	// constructors
	public UriMediaItemParcelizer ();
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public static UriMediaItem Read (AndroidX.VersionedParcelable.VersionedParcel);
	public static void Write (UriMediaItem, AndroidX.VersionedParcelable.VersionedParcel);
}
```

#### New Type: AndroidX.Medai2.Common.VideoSize

```csharp
public sealed class VideoSize : Java.Lang.Object, Android.Runtime.IJavaObject, AndroidX.VersionedParcelable.IVersionedParcelable, System.IDisposable {
	// constructors
	public VideoSize (int, int);
	// properties
	public int Height { get; }
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	public int Width { get; }
}
```

#### New Type: AndroidX.Medai2.Common.VideoSizeParcelizer

```csharp
public sealed class VideoSizeParcelizer : Java.Lang.Object {
	// constructors
	public VideoSizeParcelizer ();
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public static VideoSize Read (AndroidX.VersionedParcelable.VersionedParcel);
	public static void Write (VideoSize, AndroidX.VersionedParcelable.VersionedParcel);
}
```

### New Namespace AndroidX.Medai2.Common.Futures

#### New Type: AndroidX.Medai2.Common.Futures.AbstractResolvableFuture

```csharp
public abstract class AbstractResolvableFuture : Java.Lang.Object, Android.Runtime.IJavaObject, Google.Common.Util.Concurrent.IListenableFuture, Java.Util.Concurrent.IFuture, System.IDisposable {
	// constructors
	protected AbstractResolvableFuture ();
	protected AbstractResolvableFuture (IntPtr, Android.Runtime.JniHandleOwnership);
	// properties
	public bool IsCancelled { get; }
	public bool IsDone { get; }
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public virtual void AddListener (Java.Lang.IRunnable, Java.Util.Concurrent.IExecutor);
	protected virtual void AfterDone ();
	public virtual bool Cancel (bool);
	public virtual Java.Lang.Object Get ();
	public virtual Java.Lang.Object Get (long, Java.Util.Concurrent.TimeUnit);
	protected virtual void InterruptTask ();
	protected virtual string PendingToString ();
	protected virtual bool Set (Java.Lang.Object);
	protected virtual bool SetException (Java.Lang.Throwable);
	protected virtual bool SetFuture (Google.Common.Util.Concurrent.IListenableFuture);
	protected bool WasInterrupted ();
}
```

#### New Type: AndroidX.Medai2.Common.Futures.ResolvableFuture

```csharp
public sealed class ResolvableFuture : AndroidX.Medai2.Common.Futures.AbstractResolvableFuture, Android.Runtime.IJavaObject, Google.Common.Util.Concurrent.IListenableFuture, Java.Util.Concurrent.IFuture, System.IDisposable {
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public static ResolvableFuture Create ();
	public bool Set (Java.Lang.Object);
	public bool SetException (Java.Lang.Throwable);
	public bool SetFuture (Google.Common.Util.Concurrent.IListenableFuture);
}
```

### New Namespace AndroidX.Media2.Session

#### New Type: AndroidX.Media2.Session.CommandButtonParcelizer

```csharp
public sealed class CommandButtonParcelizer : Java.Lang.Object {
	// constructors
	public CommandButtonParcelizer ();
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public static MediaSession.CommandButton Read (AndroidX.VersionedParcelable.VersionedParcel);
	public static void Write (MediaSession.CommandButton, AndroidX.VersionedParcelable.VersionedParcel);
}
```

#### New Type: AndroidX.Media2.Session.ConnectionRequestParcelizer

```csharp
public sealed class ConnectionRequestParcelizer : Java.Lang.Object {
	// constructors
	public ConnectionRequestParcelizer ();
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public static Java.Lang.Object Read (AndroidX.VersionedParcelable.VersionedParcel);
}
```

#### New Type: AndroidX.Media2.Session.ConnectionResultParcelizer

```csharp
public sealed class ConnectionResultParcelizer : Java.Lang.Object {
	// constructors
	public ConnectionResultParcelizer ();
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public static AndroidX.VersionedParcelable.CustomVersionedParcelable Read (AndroidX.VersionedParcelable.VersionedParcel);
}
```

#### New Type: AndroidX.Media2.Session.HeartRating

```csharp
public sealed class HeartRating : Java.Lang.Object, Android.Runtime.IJavaObject, AndroidX.Medai2.Common.IRating, AndroidX.VersionedParcelable.IVersionedParcelable, System.IDisposable {
	// constructors
	public HeartRating ();
	public HeartRating (bool);
	// properties
	public bool HasHeart { get; }
	public bool IsRated { get; }
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
}
```

#### New Type: AndroidX.Media2.Session.HeartRatingParcelizer

```csharp
public sealed class HeartRatingParcelizer : Java.Lang.Object {
	// constructors
	public HeartRatingParcelizer ();
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public static HeartRating Read (AndroidX.VersionedParcelable.VersionedParcel);
	public static void Write (HeartRating, AndroidX.VersionedParcelable.VersionedParcel);
}
```

#### New Type: AndroidX.Media2.Session.IMediaController

```csharp
public interface IMediaController : Android.OS.IInterface, Android.Runtime.IJavaObject, System.IDisposable {
	// methods
	public virtual void OnAllowedCommandsChanged (int, AndroidX.VersionedParcelable.ParcelImpl);
	public virtual void OnBufferingStateChanged (int, AndroidX.VersionedParcelable.ParcelImpl, int, long, long, long);
	public virtual void OnChildrenChanged (int, string, int, AndroidX.VersionedParcelable.ParcelImpl);
	public virtual void OnConnected (int, AndroidX.VersionedParcelable.ParcelImpl);
	public virtual void OnCurrentMediaItemChanged (int, AndroidX.VersionedParcelable.ParcelImpl, int, int, int);
	public virtual void OnCustomCommand (int, AndroidX.VersionedParcelable.ParcelImpl, Android.OS.Bundle);
	public virtual void OnDisconnected (int);
	public virtual void OnLibraryResult (int, AndroidX.VersionedParcelable.ParcelImpl);
	public virtual void OnPlaybackCompleted (int);
	public virtual void OnPlaybackInfoChanged (int, AndroidX.VersionedParcelable.ParcelImpl);
	public virtual void OnPlaybackSpeedChanged (int, long, long, float);
	public virtual void OnPlayerStateChanged (int, long, long, int);
	public virtual void OnPlaylistChanged (int, AndroidX.Medai2.Common.ParcelImplListSlice, AndroidX.VersionedParcelable.ParcelImpl, int, int, int);
	public virtual void OnPlaylistMetadataChanged (int, AndroidX.VersionedParcelable.ParcelImpl);
	public virtual void OnRepeatModeChanged (int, int, int, int, int);
	public virtual void OnSearchResultChanged (int, string, int, AndroidX.VersionedParcelable.ParcelImpl);
	public virtual void OnSeekCompleted (int, long, long, long);
	public virtual void OnSessionResult (int, AndroidX.VersionedParcelable.ParcelImpl);
	public virtual void OnSetCustomLayout (int, System.Collections.Generic.IList<AndroidX.VersionedParcelable.ParcelImpl>);
	public virtual void OnShuffleModeChanged (int, int, int, int, int);
	public virtual void OnSubtitleData (int, AndroidX.VersionedParcelable.ParcelImpl, AndroidX.VersionedParcelable.ParcelImpl, AndroidX.VersionedParcelable.ParcelImpl);
	public virtual void OnTrackDeselected (int, AndroidX.VersionedParcelable.ParcelImpl);
	public virtual void OnTrackInfoChanged (int, System.Collections.Generic.IList<AndroidX.VersionedParcelable.ParcelImpl>, AndroidX.VersionedParcelable.ParcelImpl, AndroidX.VersionedParcelable.ParcelImpl, AndroidX.VersionedParcelable.ParcelImpl, AndroidX.VersionedParcelable.ParcelImpl);
	public virtual void OnTrackSelected (int, AndroidX.VersionedParcelable.ParcelImpl);
	public virtual void OnVideoSizeChanged (int, AndroidX.VersionedParcelable.ParcelImpl, AndroidX.VersionedParcelable.ParcelImpl);
}
```

#### New Type: AndroidX.Media2.Session.IMediaSession

```csharp
public interface IMediaSession : Android.OS.IInterface, Android.Runtime.IJavaObject, System.IDisposable {
	// methods
	public virtual void AddPlaylistItem (IMediaController, int, int, string);
	public virtual void AdjustVolume (IMediaController, int, int, int);
	public virtual void Connect (IMediaController, int, AndroidX.VersionedParcelable.ParcelImpl);
	public virtual void DeselectTrack (IMediaController, int, AndroidX.VersionedParcelable.ParcelImpl);
	public virtual void FastForward (IMediaController, int);
	public virtual void GetChildren (IMediaController, int, string, int, int, AndroidX.VersionedParcelable.ParcelImpl);
	public virtual void GetItem (IMediaController, int, string);
	public virtual void GetLibraryRoot (IMediaController, int, AndroidX.VersionedParcelable.ParcelImpl);
	public virtual void GetSearchResult (IMediaController, int, string, int, int, AndroidX.VersionedParcelable.ParcelImpl);
	public virtual void OnControllerResult (IMediaController, int, AndroidX.VersionedParcelable.ParcelImpl);
	public virtual void OnCustomCommand (IMediaController, int, AndroidX.VersionedParcelable.ParcelImpl, Android.OS.Bundle);
	public virtual void Pause (IMediaController, int);
	public virtual void Play (IMediaController, int);
	public virtual void PlayFromMediaId (IMediaController, int, string, Android.OS.Bundle);
	public virtual void PlayFromSearch (IMediaController, int, string, Android.OS.Bundle);
	public virtual void PlayFromUri (IMediaController, int, Android.Net.Uri, Android.OS.Bundle);
	public virtual void Prepare (IMediaController, int);
	public virtual void PrepareFromMediaId (IMediaController, int, string, Android.OS.Bundle);
	public virtual void PrepareFromSearch (IMediaController, int, string, Android.OS.Bundle);
	public virtual void PrepareFromUri (IMediaController, int, Android.Net.Uri, Android.OS.Bundle);
	public virtual void Release (IMediaController, int);
	public virtual void RemovePlaylistItem (IMediaController, int, int);
	public virtual void ReplacePlaylistItem (IMediaController, int, int, string);
	public virtual void Rewind (IMediaController, int);
	public virtual void Search (IMediaController, int, string, AndroidX.VersionedParcelable.ParcelImpl);
	public virtual void SeekTo (IMediaController, int, long);
	public virtual void SelectTrack (IMediaController, int, AndroidX.VersionedParcelable.ParcelImpl);
	public virtual void SetMediaItem (IMediaController, int, string);
	public virtual void SetPlaybackSpeed (IMediaController, int, float);
	public virtual void SetPlaylist (IMediaController, int, System.Collections.Generic.IList<string>, AndroidX.VersionedParcelable.ParcelImpl);
	public virtual void SetRating (IMediaController, int, string, AndroidX.VersionedParcelable.ParcelImpl);
	public virtual void SetRepeatMode (IMediaController, int, int);
	public virtual void SetShuffleMode (IMediaController, int, int);
	public virtual void SetSurface (IMediaController, int, Android.Views.Surface);
	public virtual void SetVolumeTo (IMediaController, int, int, int);
	public virtual void SkipBackward (IMediaController, int);
	public virtual void SkipForward (IMediaController, int);
	public virtual void SkipToNextItem (IMediaController, int);
	public virtual void SkipToPlaylistItem (IMediaController, int, int);
	public virtual void SkipToPreviousItem (IMediaController, int);
	public virtual void Subscribe (IMediaController, int, string, AndroidX.VersionedParcelable.ParcelImpl);
	public virtual void Unsubscribe (IMediaController, int, string);
	public virtual void UpdatePlaylistMetadata (IMediaController, int, AndroidX.VersionedParcelable.ParcelImpl);
}
```

#### New Type: AndroidX.Media2.Session.IMediaSessionService

```csharp
public interface IMediaSessionService : Android.OS.IInterface, Android.Runtime.IJavaObject, System.IDisposable {
	// methods
	public virtual void Connect (IMediaController, AndroidX.VersionedParcelable.ParcelImpl);
}
```

#### New Type: AndroidX.Media2.Session.LibraryParamsParcelizer

```csharp
public sealed class LibraryParamsParcelizer : Java.Lang.Object {
	// constructors
	public LibraryParamsParcelizer ();
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public static MediaLibraryService.LibraryParams Read (AndroidX.VersionedParcelable.VersionedParcel);
	public static void Write (MediaLibraryService.LibraryParams, AndroidX.VersionedParcelable.VersionedParcel);
}
```

#### New Type: AndroidX.Media2.Session.LibraryResult

```csharp
public class LibraryResult : AndroidX.VersionedParcelable.CustomVersionedParcelable, Android.Runtime.IJavaObject, AndroidX.VersionedParcelable.IVersionedParcelable, System.IDisposable {
	// constructors
	public LibraryResult (int);
	protected LibraryResult (IntPtr, Android.Runtime.JniHandleOwnership);
	public LibraryResult (int, AndroidX.Medai2.Common.MediaItem, MediaLibraryService.LibraryParams);
	public LibraryResult (int, System.Collections.Generic.IList<AndroidX.Medai2.Common.MediaItem>, MediaLibraryService.LibraryParams);
	// properties
	public long CompletionTime { get; }
	public MediaLibraryService.LibraryParams LibraryParams { get; }
	public AndroidX.Medai2.Common.MediaItem MediaItem { get; }
	public System.Collections.Generic.IList<AndroidX.Medai2.Common.MediaItem> MediaItems { get; }
	public int ResultCode { get; }
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }

	// inner types
	public interface IResultCode : Android.Runtime.IJavaObject, Java.Lang.Annotation.IAnnotation, System.IDisposable {
	}
}
```

#### New Type: AndroidX.Media2.Session.LibraryResultParcelizer

```csharp
public sealed class LibraryResultParcelizer : Java.Lang.Object {
	// constructors
	public LibraryResultParcelizer ();
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public static LibraryResult Read (AndroidX.VersionedParcelable.VersionedParcel);
	public static void Write (LibraryResult, AndroidX.VersionedParcelable.VersionedParcel);
}
```

#### New Type: AndroidX.Media2.Session.MediaController

```csharp
public class MediaController : Java.Lang.Object, Android.Runtime.IJavaObject, Java.Lang.IAutoCloseable, System.IDisposable {
	// constructors
	protected MediaController (IntPtr, Android.Runtime.JniHandleOwnership);
	// properties
	public SessionCommandGroup AllowedCommands { get; }
	public long BufferedPosition { get; }
	public int BufferingState { get; }
	public SessionToken ConnectedToken { get; }
	public AndroidX.Medai2.Common.MediaItem CurrentMediaItem { get; }
	public int CurrentMediaItemIndex { get; }
	public long CurrentPosition { get; }
	public long Duration { get; }
	public System.Collections.Generic.IList<AndroidX.Core.Util.Pair> ExtraCallbacks { get; }
	public bool IsConnected { get; }
	public int NextMediaItemIndex { get; }
	public float PlaybackSpeed { get; }
	public int PlayerState { get; }
	public System.Collections.Generic.IList<AndroidX.Medai2.Common.MediaItem> Playlist { get; }
	public AndroidX.Medai2.Common.MediaMetadata PlaylistMetadata { get; }
	public int PreviousMediaItemIndex { get; }
	public int RepeatMode { get; }
	public Android.App.PendingIntent SessionActivity { get; }
	public int ShuffleMode { get; }
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	public System.Collections.Generic.IList<AndroidX.Medai2.Common.SessionPlayer.TrackInfo> TrackInfo { get; }
	public AndroidX.Medai2.Common.VideoSize VideoSize { get; }
	// methods
	public virtual Google.Common.Util.Concurrent.IListenableFuture AddPlaylistItem (int, string);
	public virtual Google.Common.Util.Concurrent.IListenableFuture AdjustVolume (int, int);
	public virtual void Close ();
	public virtual Google.Common.Util.Concurrent.IListenableFuture DeselectTrack (AndroidX.Medai2.Common.SessionPlayer.TrackInfo);
	public virtual Google.Common.Util.Concurrent.IListenableFuture FastForward ();
	public virtual MediaController.PlaybackInfo GetPlaybackInfo ();
	public virtual AndroidX.Medai2.Common.SessionPlayer.TrackInfo GetSelectedTrack (int);
	public virtual void NotifyControllerCallback (MediaController.IControllerCallbackRunnable);
	public virtual Google.Common.Util.Concurrent.IListenableFuture Pause ();
	public virtual Google.Common.Util.Concurrent.IListenableFuture Play ();
	public virtual Google.Common.Util.Concurrent.IListenableFuture PlayFromMediaId (string, Android.OS.Bundle);
	public virtual Google.Common.Util.Concurrent.IListenableFuture PlayFromSearch (string, Android.OS.Bundle);
	public virtual Google.Common.Util.Concurrent.IListenableFuture PlayFromUri (Android.Net.Uri, Android.OS.Bundle);
	public virtual Google.Common.Util.Concurrent.IListenableFuture Prepare ();
	public virtual Google.Common.Util.Concurrent.IListenableFuture PrepareFromMediaId (string, Android.OS.Bundle);
	public virtual Google.Common.Util.Concurrent.IListenableFuture PrepareFromSearch (string, Android.OS.Bundle);
	public virtual Google.Common.Util.Concurrent.IListenableFuture PrepareFromUri (Android.Net.Uri, Android.OS.Bundle);
	public virtual void RegisterExtraCallback (Java.Util.Concurrent.IExecutor, MediaController.ControllerCallback);
	public virtual Google.Common.Util.Concurrent.IListenableFuture RemovePlaylistItem (int);
	public virtual Google.Common.Util.Concurrent.IListenableFuture ReplacePlaylistItem (int, string);
	public virtual Google.Common.Util.Concurrent.IListenableFuture Rewind ();
	public virtual Google.Common.Util.Concurrent.IListenableFuture SeekTo (long);
	public virtual Google.Common.Util.Concurrent.IListenableFuture SelectTrack (AndroidX.Medai2.Common.SessionPlayer.TrackInfo);
	public virtual Google.Common.Util.Concurrent.IListenableFuture SendCustomCommand (SessionCommand, Android.OS.Bundle);
	public virtual Google.Common.Util.Concurrent.IListenableFuture SetMediaItem (string);
	public virtual Google.Common.Util.Concurrent.IListenableFuture SetPlaybackSpeed (float);
	public virtual Google.Common.Util.Concurrent.IListenableFuture SetPlaylist (System.Collections.Generic.IList<string>, AndroidX.Medai2.Common.MediaMetadata);
	public virtual Google.Common.Util.Concurrent.IListenableFuture SetRating (string, AndroidX.Medai2.Common.IRating);
	public virtual Google.Common.Util.Concurrent.IListenableFuture SetRepeatMode (int);
	public virtual Google.Common.Util.Concurrent.IListenableFuture SetShuffleMode (int);
	public virtual Google.Common.Util.Concurrent.IListenableFuture SetSurface (Android.Views.Surface);
	public virtual void SetTimeDiff (Java.Lang.Long);
	public virtual Google.Common.Util.Concurrent.IListenableFuture SetVolumeTo (int, int);
	public virtual Google.Common.Util.Concurrent.IListenableFuture SkipBackward ();
	public virtual Google.Common.Util.Concurrent.IListenableFuture SkipForward ();
	public virtual Google.Common.Util.Concurrent.IListenableFuture SkipToNextPlaylistItem ();
	public virtual Google.Common.Util.Concurrent.IListenableFuture SkipToPlaylistItem (int);
	public virtual Google.Common.Util.Concurrent.IListenableFuture SkipToPreviousPlaylistItem ();
	public virtual void UnregisterExtraCallback (MediaController.ControllerCallback);
	public virtual Google.Common.Util.Concurrent.IListenableFuture UpdatePlaylistMetadata (AndroidX.Medai2.Common.MediaMetadata);

	// inner types
	public sealed class Builder : Java.Lang.Object {
		// constructors
		public MediaController.Builder (Android.Content.Context);
		// properties
		protected IntPtr ThresholdClass { get; }
		protected System.Type ThresholdType { get; }
		// methods
		public MediaController Build ();
	}
	public abstract class BuilderBase : Java.Lang.Object {
		// constructors
		protected MediaController.BuilderBase (IntPtr, Android.Runtime.JniHandleOwnership);
		// properties
		protected IntPtr ThresholdClass { get; }
		protected System.Type ThresholdType { get; }
		// methods
		public virtual Java.Lang.Object SetConnectionHints (Android.OS.Bundle);
		public virtual Java.Lang.Object SetControllerCallback (Java.Util.Concurrent.IExecutor, Java.Lang.Object);
		public virtual Java.Lang.Object SetSessionCompatToken (Android.Support.V4.Media.Session.MediaSessionCompat.Token);
		public virtual Java.Lang.Object SetSessionToken (SessionToken);
	}
	public abstract class ControllerCallback : Java.Lang.Object {
		// constructors
		public MediaController.ControllerCallback ();
		protected MediaController.ControllerCallback (IntPtr, Android.Runtime.JniHandleOwnership);
		// properties
		protected IntPtr ThresholdClass { get; }
		protected System.Type ThresholdType { get; }
		// methods
		public virtual void OnAllowedCommandsChanged (MediaController, SessionCommandGroup);
		public virtual void OnBufferingStateChanged (MediaController, AndroidX.Medai2.Common.MediaItem, int);
		public virtual void OnConnected (MediaController, SessionCommandGroup);
		public virtual void OnCurrentMediaItemChanged (MediaController, AndroidX.Medai2.Common.MediaItem);
		public virtual SessionResult OnCustomCommand (MediaController, SessionCommand, Android.OS.Bundle);
		public virtual void OnDisconnected (MediaController);
		public virtual void OnPlaybackCompleted (MediaController);
		public virtual void OnPlaybackInfoChanged (MediaController, MediaController.PlaybackInfo);
		public virtual void OnPlaybackSpeedChanged (MediaController, float);
		public virtual void OnPlayerStateChanged (MediaController, int);
		public virtual void OnPlaylistChanged (MediaController, System.Collections.Generic.IList<AndroidX.Medai2.Common.MediaItem>, AndroidX.Medai2.Common.MediaMetadata);
		public virtual void OnPlaylistMetadataChanged (MediaController, AndroidX.Medai2.Common.MediaMetadata);
		public virtual void OnRepeatModeChanged (MediaController, int);
		public virtual void OnSeekCompleted (MediaController, long);
		public virtual int OnSetCustomLayout (MediaController, System.Collections.Generic.IList<MediaSession.CommandButton>);
		public virtual void OnShuffleModeChanged (MediaController, int);
		public virtual void OnSubtitleData (MediaController, AndroidX.Medai2.Common.MediaItem, AndroidX.Medai2.Common.SessionPlayer.TrackInfo, AndroidX.Medai2.Common.SubtitleData);
		public virtual void OnTrackDeselected (MediaController, AndroidX.Medai2.Common.SessionPlayer.TrackInfo);
		public virtual void OnTrackInfoChanged (MediaController, System.Collections.Generic.IList<AndroidX.Medai2.Common.SessionPlayer.TrackInfo>);
		public virtual void OnTrackSelected (MediaController, AndroidX.Medai2.Common.SessionPlayer.TrackInfo);
		public virtual void OnVideoSizeChanged (MediaController, AndroidX.Medai2.Common.MediaItem, AndroidX.Medai2.Common.VideoSize);
	}
	public interface IControllerCallbackRunnable : Android.Runtime.IJavaObject, System.IDisposable {
		// methods
		public virtual void Run (MediaController.ControllerCallback);
	}
	public interface IMediaControllerImpl : Android.Runtime.IJavaObject, Java.Lang.IAutoCloseable, System.IDisposable {
		// properties
		public SessionCommandGroup AllowedCommands { get; }
		public Android.Support.V4.Media.MediaBrowserCompat BrowserCompat { get; }
		public long BufferedPosition { get; }
		public int BufferingState { get; }
		public SessionToken ConnectedToken { get; }
		public Android.Content.Context Context { get; }
		public AndroidX.Medai2.Common.MediaItem CurrentMediaItem { get; }
		public int CurrentMediaItemIndex { get; }
		public long CurrentPosition { get; }
		public long Duration { get; }
		public bool IsConnected { get; }
		public int NextMediaItemIndex { get; }
		public MediaController.PlaybackInfo PlaybackInfo { get; }
		public float PlaybackSpeed { get; }
		public int PlayerState { get; }
		public System.Collections.Generic.IList<AndroidX.Medai2.Common.MediaItem> Playlist { get; }
		public AndroidX.Medai2.Common.MediaMetadata PlaylistMetadata { get; }
		public int PreviousMediaItemIndex { get; }
		public int RepeatMode { get; }
		public Android.App.PendingIntent SessionActivity { get; }
		public int ShuffleMode { get; }
		public System.Collections.Generic.IList<AndroidX.Medai2.Common.SessionPlayer.TrackInfo> TrackInfo { get; }
		public AndroidX.Medai2.Common.VideoSize VideoSize { get; }
		// methods
		public virtual Google.Common.Util.Concurrent.IListenableFuture AddPlaylistItem (int, string);
		public virtual Google.Common.Util.Concurrent.IListenableFuture AdjustVolume (int, int);
		public virtual Google.Common.Util.Concurrent.IListenableFuture DeselectTrack (AndroidX.Medai2.Common.SessionPlayer.TrackInfo);
		public virtual Google.Common.Util.Concurrent.IListenableFuture FastForward ();
		public virtual AndroidX.Medai2.Common.SessionPlayer.TrackInfo GetSelectedTrack (int);
		public virtual Google.Common.Util.Concurrent.IListenableFuture Pause ();
		public virtual Google.Common.Util.Concurrent.IListenableFuture Play ();
		public virtual Google.Common.Util.Concurrent.IListenableFuture PlayFromMediaId (string, Android.OS.Bundle);
		public virtual Google.Common.Util.Concurrent.IListenableFuture PlayFromSearch (string, Android.OS.Bundle);
		public virtual Google.Common.Util.Concurrent.IListenableFuture PlayFromUri (Android.Net.Uri, Android.OS.Bundle);
		public virtual Google.Common.Util.Concurrent.IListenableFuture Prepare ();
		public virtual Google.Common.Util.Concurrent.IListenableFuture PrepareFromMediaId (string, Android.OS.Bundle);
		public virtual Google.Common.Util.Concurrent.IListenableFuture PrepareFromSearch (string, Android.OS.Bundle);
		public virtual Google.Common.Util.Concurrent.IListenableFuture PrepareFromUri (Android.Net.Uri, Android.OS.Bundle);
		public virtual Google.Common.Util.Concurrent.IListenableFuture RemovePlaylistItem (int);
		public virtual Google.Common.Util.Concurrent.IListenableFuture ReplacePlaylistItem (int, string);
		public virtual Google.Common.Util.Concurrent.IListenableFuture Rewind ();
		public virtual Google.Common.Util.Concurrent.IListenableFuture SeekTo (long);
		public virtual Google.Common.Util.Concurrent.IListenableFuture SelectTrack (AndroidX.Medai2.Common.SessionPlayer.TrackInfo);
		public virtual Google.Common.Util.Concurrent.IListenableFuture SendCustomCommand (SessionCommand, Android.OS.Bundle);
		public virtual Google.Common.Util.Concurrent.IListenableFuture SetMediaItem (string);
		public virtual Google.Common.Util.Concurrent.IListenableFuture SetPlaybackSpeed (float);
		public virtual Google.Common.Util.Concurrent.IListenableFuture SetPlaylist (System.Collections.Generic.IList<string>, AndroidX.Medai2.Common.MediaMetadata);
		public virtual Google.Common.Util.Concurrent.IListenableFuture SetRating (string, AndroidX.Medai2.Common.IRating);
		public virtual Google.Common.Util.Concurrent.IListenableFuture SetRepeatMode (int);
		public virtual Google.Common.Util.Concurrent.IListenableFuture SetShuffleMode (int);
		public virtual Google.Common.Util.Concurrent.IListenableFuture SetSurface (Android.Views.Surface);
		public virtual Google.Common.Util.Concurrent.IListenableFuture SetVolumeTo (int, int);
		public virtual Google.Common.Util.Concurrent.IListenableFuture SkipBackward ();
		public virtual Google.Common.Util.Concurrent.IListenableFuture SkipForward ();
		public virtual Google.Common.Util.Concurrent.IListenableFuture SkipToNextItem ();
		public virtual Google.Common.Util.Concurrent.IListenableFuture SkipToPlaylistItem (int);
		public virtual Google.Common.Util.Concurrent.IListenableFuture SkipToPreviousItem ();
		public virtual Google.Common.Util.Concurrent.IListenableFuture UpdatePlaylistMetadata (AndroidX.Medai2.Common.MediaMetadata);
	}
	public interface IVolumeDirection : Android.Runtime.IJavaObject, Java.Lang.Annotation.IAnnotation, System.IDisposable {
	}
	public interface IVolumeFlags : Android.Runtime.IJavaObject, Java.Lang.Annotation.IAnnotation, System.IDisposable {
	}
	public sealed class PlaybackInfo : Java.Lang.Object, Android.Runtime.IJavaObject, AndroidX.VersionedParcelable.IVersionedParcelable, System.IDisposable {
		// fields
		public static const int PlaybackTypeLocal;
		public static const int PlaybackTypeRemote;
		// properties
		public AndroidX.Media.AudioAttributesCompat AudioAttributes { get; }
		public int ControlType { get; }
		public int CurrentVolume { get; }
		public int MaxVolume { get; }
		public int PlaybackType { get; }
		protected IntPtr ThresholdClass { get; }
		protected System.Type ThresholdType { get; }
	}
}
```

#### New Type: AndroidX.Media2.Session.MediaControllerStub

```csharp
public abstract class MediaControllerStub : Android.OS.Binder, Android.OS.IInterface, Android.Runtime.IJavaObject, IMediaController, System.IDisposable {
	// constructors
	public MediaControllerStub ();
	protected MediaControllerStub (IntPtr, Android.Runtime.JniHandleOwnership);
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public virtual Android.OS.IBinder AsBinder ();
	public static IMediaController AsInterface (Android.OS.IBinder);
	public virtual void OnAllowedCommandsChanged (int, AndroidX.VersionedParcelable.ParcelImpl);
	public virtual void OnBufferingStateChanged (int, AndroidX.VersionedParcelable.ParcelImpl, int, long, long, long);
	public virtual void OnChildrenChanged (int, string, int, AndroidX.VersionedParcelable.ParcelImpl);
	public virtual void OnConnected (int, AndroidX.VersionedParcelable.ParcelImpl);
	public virtual void OnCurrentMediaItemChanged (int, AndroidX.VersionedParcelable.ParcelImpl, int, int, int);
	public virtual void OnCustomCommand (int, AndroidX.VersionedParcelable.ParcelImpl, Android.OS.Bundle);
	public virtual void OnDisconnected (int);
	public virtual void OnLibraryResult (int, AndroidX.VersionedParcelable.ParcelImpl);
	public virtual void OnPlaybackCompleted (int);
	public virtual void OnPlaybackInfoChanged (int, AndroidX.VersionedParcelable.ParcelImpl);
	public virtual void OnPlaybackSpeedChanged (int, long, long, float);
	public virtual void OnPlayerStateChanged (int, long, long, int);
	public virtual void OnPlaylistChanged (int, AndroidX.Medai2.Common.ParcelImplListSlice, AndroidX.VersionedParcelable.ParcelImpl, int, int, int);
	public virtual void OnPlaylistMetadataChanged (int, AndroidX.VersionedParcelable.ParcelImpl);
	public virtual void OnRepeatModeChanged (int, int, int, int, int);
	public virtual void OnSearchResultChanged (int, string, int, AndroidX.VersionedParcelable.ParcelImpl);
	public virtual void OnSeekCompleted (int, long, long, long);
	public virtual void OnSessionResult (int, AndroidX.VersionedParcelable.ParcelImpl);
	public virtual void OnSetCustomLayout (int, System.Collections.Generic.IList<AndroidX.VersionedParcelable.ParcelImpl>);
	public virtual void OnShuffleModeChanged (int, int, int, int, int);
	public virtual void OnSubtitleData (int, AndroidX.VersionedParcelable.ParcelImpl, AndroidX.VersionedParcelable.ParcelImpl, AndroidX.VersionedParcelable.ParcelImpl);
	public virtual void OnTrackDeselected (int, AndroidX.VersionedParcelable.ParcelImpl);
	public virtual void OnTrackInfoChanged (int, System.Collections.Generic.IList<AndroidX.VersionedParcelable.ParcelImpl>, AndroidX.VersionedParcelable.ParcelImpl, AndroidX.VersionedParcelable.ParcelImpl, AndroidX.VersionedParcelable.ParcelImpl, AndroidX.VersionedParcelable.ParcelImpl);
	public virtual void OnTrackSelected (int, AndroidX.VersionedParcelable.ParcelImpl);
	public virtual bool OnTransact (int, Android.OS.Parcel, Android.OS.Parcel, int);
	public virtual void OnVideoSizeChanged (int, AndroidX.VersionedParcelable.ParcelImpl, AndroidX.VersionedParcelable.ParcelImpl);
}
```

#### New Type: AndroidX.Media2.Session.MediaLibraryService

```csharp
public abstract class MediaLibraryService : AndroidX.Media2.Session.MediaSessionService {
	// constructors
	public MediaLibraryService ();
	protected MediaLibraryService (IntPtr, Android.Runtime.JniHandleOwnership);
	// fields
	public static const string ServiceInterface = "androidx.media2.session.MediaLibraryService";
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }

	// inner types
	public sealed class LibraryParams : Java.Lang.Object, Android.Runtime.IJavaObject, AndroidX.VersionedParcelable.IVersionedParcelable, System.IDisposable {
		// properties
		public Android.OS.Bundle Extras { get; }
		public bool IsOffline { get; }
		public bool IsRecent { get; }
		public bool IsSuggested { get; }
		protected IntPtr ThresholdClass { get; }
		protected System.Type ThresholdType { get; }

		// inner types
		public sealed class Builder : Java.Lang.Object {
			// constructors
			public MediaLibraryService.LibraryParams.Builder ();
			// properties
			protected IntPtr ThresholdClass { get; }
			protected System.Type ThresholdType { get; }
			// methods
			public MediaLibraryService.LibraryParams Build ();
			public MediaLibraryService.LibraryParams.Builder SetExtras (Android.OS.Bundle);
			public MediaLibraryService.LibraryParams.Builder SetOffline (bool);
			public MediaLibraryService.LibraryParams.Builder SetRecent (bool);
			public MediaLibraryService.LibraryParams.Builder SetSuggested (bool);
		}
	}
	public sealed class MediaLibrarySession : AndroidX.Media2.Session.MediaSession, Android.Runtime.IJavaObject, Java.Lang.IAutoCloseable, System.IDisposable {
		// properties
		protected IntPtr ThresholdClass { get; }
		protected System.Type ThresholdType { get; }
		// methods
		public void NotifyChildrenChanged (string, int, MediaLibraryService.LibraryParams);
		public void NotifyChildrenChanged (MediaSession.ControllerInfo, string, int, MediaLibraryService.LibraryParams);
		public void NotifySearchResultChanged (MediaSession.ControllerInfo, string, int, MediaLibraryService.LibraryParams);

		// inner types
		public sealed class Builder : Java.Lang.Object {
			// constructors
			public MediaLibraryService.LibraryParams.MediaLibrarySession.Builder (MediaLibraryService, AndroidX.Medai2.Common.SessionPlayer, Java.Util.Concurrent.IExecutor, MediaLibraryService.MediaLibrarySession.MediaLibrarySessionCallback);
			// properties
			protected IntPtr ThresholdClass { get; }
			protected System.Type ThresholdType { get; }
			// methods
			public MediaLibraryService.MediaLibrarySession Build ();
			public MediaLibraryService.MediaLibrarySession.Builder SetId (string);
			public MediaLibraryService.MediaLibrarySession.Builder SetSessionActivity (Android.App.PendingIntent);
		}
		public class MediaLibrarySessionCallback : AndroidX.Media2.Session.MediaSession+SessionCallback {
			// constructors
			public MediaLibraryService.LibraryParams.MediaLibrarySession.MediaLibrarySessionCallback ();
			protected MediaLibraryService.LibraryParams.MediaLibrarySession.MediaLibrarySessionCallback (IntPtr, Android.Runtime.JniHandleOwnership);
			// properties
			protected IntPtr ThresholdClass { get; }
			protected System.Type ThresholdType { get; }
			// methods
			public virtual LibraryResult OnGetChildren (MediaLibraryService.MediaLibrarySession, MediaSession.ControllerInfo, string, int, int, MediaLibraryService.LibraryParams);
			public virtual LibraryResult OnGetItem (MediaLibraryService.MediaLibrarySession, MediaSession.ControllerInfo, string);
			public virtual LibraryResult OnGetLibraryRoot (MediaLibraryService.MediaLibrarySession, MediaSession.ControllerInfo, MediaLibraryService.LibraryParams);
			public virtual LibraryResult OnGetSearchResult (MediaLibraryService.MediaLibrarySession, MediaSession.ControllerInfo, string, int, int, MediaLibraryService.LibraryParams);
			public virtual int OnSearch (MediaLibraryService.MediaLibrarySession, MediaSession.ControllerInfo, string, MediaLibraryService.LibraryParams);
			public virtual int OnSubscribe (MediaLibraryService.MediaLibrarySession, MediaSession.ControllerInfo, string, MediaLibraryService.LibraryParams);
			public virtual int OnUnsubscribe (MediaLibraryService.MediaLibrarySession, MediaSession.ControllerInfo, string);
		}
	}
}
```

#### New Type: AndroidX.Media2.Session.MediaNotificationHandler

```csharp
public class MediaNotificationHandler : Java.Lang.Object {
	// constructors
	public MediaNotificationHandler (MediaSessionService);
	protected MediaNotificationHandler (IntPtr, Android.Runtime.JniHandleOwnership);
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public virtual void OnPlayerStateChanged (MediaSession, int);
	public virtual void OnSessionClosed (MediaSession);
	public virtual MediaSessionService.MediaNotification OnUpdateNotification (MediaSession);
}
```

#### New Type: AndroidX.Media2.Session.MediaSession

```csharp
public class MediaSession : Java.Lang.Object, Android.Runtime.IJavaObject, Java.Lang.IAutoCloseable, System.IDisposable {
	// constructors
	protected MediaSession (IntPtr, Android.Runtime.JniHandleOwnership);
	// properties
	public System.Collections.Generic.IList<MediaSession.ControllerInfo> ConnectedControllers { get; }
	public string Id { get; }
	public bool IsClosed { get; }
	public AndroidX.Medai2.Common.SessionPlayer Player { get; }
	public Android.Support.V4.Media.Session.MediaSessionCompat SessionCompat { get; }
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	public SessionToken Token { get; }
	// methods
	public virtual void BroadcastCustomCommand (SessionCommand, Android.OS.Bundle);
	public virtual void Close ();
	public virtual Google.Common.Util.Concurrent.IListenableFuture SendCustomCommand (MediaSession.ControllerInfo, SessionCommand, Android.OS.Bundle);
	public virtual void SetAllowedCommands (MediaSession.ControllerInfo, SessionCommandGroup);
	public virtual Google.Common.Util.Concurrent.IListenableFuture SetCustomLayout (MediaSession.ControllerInfo, System.Collections.Generic.IList<MediaSession.CommandButton>);
	public virtual void UpdatePlayer (AndroidX.Medai2.Common.SessionPlayer);

	// inner types
	public sealed class Builder : Java.Lang.Object {
		// constructors
		public MediaSession.Builder (Android.Content.Context, AndroidX.Medai2.Common.SessionPlayer);
		// properties
		protected IntPtr ThresholdClass { get; }
		protected System.Type ThresholdType { get; }
		// methods
		public MediaSession Build ();
		public MediaSession.Builder SetId (string);
		public MediaSession.Builder SetSessionActivity (Android.App.PendingIntent);
		public MediaSession.Builder SetSessionCallback (Java.Util.Concurrent.IExecutor, MediaSession.SessionCallback);
	}
	public abstract class BuilderBase : Java.Lang.Object {
		// constructors
		protected MediaSession.BuilderBase (IntPtr, Android.Runtime.JniHandleOwnership);
		// properties
		protected IntPtr ThresholdClass { get; }
		protected System.Type ThresholdType { get; }
		// methods
		public virtual Java.Lang.Object SetExtras (Android.OS.Bundle);
	}
	public sealed class CommandButton : Java.Lang.Object, Android.Runtime.IJavaObject, AndroidX.VersionedParcelable.IVersionedParcelable, System.IDisposable {
		// properties
		public SessionCommand Command { get; }
		public string DisplayName { get; }
		public Java.Lang.ICharSequence DisplayNameFormatted { get; }
		public Android.OS.Bundle Extras { get; }
		public int IconResId { get; }
		public bool IsEnabled { get; }
		protected IntPtr ThresholdClass { get; }
		protected System.Type ThresholdType { get; }

		// inner types
		public sealed class Builder : Java.Lang.Object {
			// constructors
			public MediaSession.CommandButton.Builder ();
			// properties
			protected IntPtr ThresholdClass { get; }
			protected System.Type ThresholdType { get; }
			// methods
			public MediaSession.CommandButton Build ();
			public MediaSession.CommandButton.Builder SetCommand (SessionCommand);
			public MediaSession.CommandButton.Builder SetDisplayName (Java.Lang.ICharSequence);
			public MediaSession.CommandButton.Builder SetDisplayName (string);
			public MediaSession.CommandButton.Builder SetEnabled (bool);
			public MediaSession.CommandButton.Builder SetExtras (Android.OS.Bundle);
			public MediaSession.CommandButton.Builder SetIconResId (int);
		}
	}
	public abstract class ControllerCb : Java.Lang.Object {
		// constructors
		protected MediaSession.CommandButton.ControllerCb (IntPtr, Android.Runtime.JniHandleOwnership);
		// properties
		protected IntPtr ThresholdClass { get; }
		protected System.Type ThresholdType { get; }
	}
	public sealed class ControllerInfo : Java.Lang.Object {
		// properties
		public Android.OS.Bundle ConnectionHints { get; }
		public bool IsTrusted { get; }
		public string PackageName { get; }
		public AndroidX.Media.MediaSessionManager.RemoteUserInfo RemoteUserInfo { get; }
		protected IntPtr ThresholdClass { get; }
		protected System.Type ThresholdType { get; }
		public int Uid { get; }
	}
	public abstract class SessionCallback : Java.Lang.Object {
		// constructors
		public MediaSession.CommandButton.SessionCallback ();
		protected MediaSession.CommandButton.SessionCallback (IntPtr, Android.Runtime.JniHandleOwnership);
		// properties
		protected IntPtr ThresholdClass { get; }
		protected System.Type ThresholdType { get; }
		// methods
		public virtual int OnCommandRequest (MediaSession, MediaSession.ControllerInfo, SessionCommand);
		public virtual SessionCommandGroup OnConnect (MediaSession, MediaSession.ControllerInfo);
		public virtual AndroidX.Medai2.Common.MediaItem OnCreateMediaItem (MediaSession, MediaSession.ControllerInfo, string);
		public virtual SessionResult OnCustomCommand (MediaSession, MediaSession.ControllerInfo, SessionCommand, Android.OS.Bundle);
		public virtual void OnDisconnected (MediaSession, MediaSession.ControllerInfo);
		public virtual int OnFastForward (MediaSession, MediaSession.ControllerInfo);
		public virtual int OnPlayFromMediaId (MediaSession, MediaSession.ControllerInfo, string, Android.OS.Bundle);
		public virtual int OnPlayFromSearch (MediaSession, MediaSession.ControllerInfo, string, Android.OS.Bundle);
		public virtual int OnPlayFromUri (MediaSession, MediaSession.ControllerInfo, Android.Net.Uri, Android.OS.Bundle);
		public virtual void OnPostConnect (MediaSession, MediaSession.ControllerInfo);
		public virtual int OnPrepareFromMediaId (MediaSession, MediaSession.ControllerInfo, string, Android.OS.Bundle);
		public virtual int OnPrepareFromSearch (MediaSession, MediaSession.ControllerInfo, string, Android.OS.Bundle);
		public virtual int OnPrepareFromUri (MediaSession, MediaSession.ControllerInfo, Android.Net.Uri, Android.OS.Bundle);
		public virtual int OnRewind (MediaSession, MediaSession.ControllerInfo);
		public virtual int OnSetRating (MediaSession, MediaSession.ControllerInfo, string, AndroidX.Medai2.Common.IRating);
		public virtual int OnSkipBackward (MediaSession, MediaSession.ControllerInfo);
		public virtual int OnSkipForward (MediaSession, MediaSession.ControllerInfo);

		// inner types
		public abstract class ForegroundServiceEventCallback : Java.Lang.Object {
			// constructors
			protected MediaSession.CommandButton.SessionCallback.ForegroundServiceEventCallback (IntPtr, Android.Runtime.JniHandleOwnership);
			// properties
			protected IntPtr ThresholdClass { get; }
			protected System.Type ThresholdType { get; }
			// methods
			public virtual void OnPlayerStateChanged (MediaSession, int);
			public virtual void OnSessionClosed (MediaSession);
		}
	}
}
```

#### New Type: AndroidX.Media2.Session.MediaSessionManager

```csharp
public sealed class MediaSessionManager : Java.Lang.Object {
	// properties
	public System.Collections.Generic.ICollection<SessionToken> SessionServiceTokens { get; }
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public static MediaSessionManager GetInstance (Android.Content.Context);
}
```

#### New Type: AndroidX.Media2.Session.MediaSessionService

```csharp
public abstract class MediaSessionService : Android.App.Service {
	// constructors
	public MediaSessionService ();
	protected MediaSessionService (IntPtr, Android.Runtime.JniHandleOwnership);
	// fields
	public static const string ServiceInterface = "androidx.media2.session.MediaSessionService";
	// properties
	public System.Collections.Generic.IList<MediaSession> Sessions { get; }
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public void AddSession (MediaSession);
	public override Android.OS.IBinder OnBind (Android.Content.Intent);
	public virtual MediaSession OnGetSession (MediaSession.ControllerInfo);
	public virtual MediaSessionService.MediaNotification OnUpdateNotification (MediaSession);
	public void RemoveSession (MediaSession);

	// inner types
	public interface IMediaSessionServiceImpl : Android.Runtime.IJavaObject, System.IDisposable {
		// properties
		public System.Collections.Generic.IList<MediaSession> Sessions { get; }
		// methods
		public virtual void AddSession (MediaSession);
		public virtual Android.OS.IBinder OnBind (Android.Content.Intent);
		public virtual void OnCreate (MediaSessionService);
		public virtual void OnDestroy ();
		public virtual int OnStartCommand (Android.Content.Intent, int, int);
		public virtual MediaSessionService.MediaNotification OnUpdateNotification (MediaSession);
		public virtual void RemoveSession (MediaSession);
	}
	public class MediaNotification : Java.Lang.Object {
		// constructors
		public MediaSessionService.MediaNotification (int, Android.App.Notification);
		protected MediaSessionService.MediaNotification (IntPtr, Android.Runtime.JniHandleOwnership);
		// properties
		public Android.App.Notification Notification { get; }
		public int NotificationId { get; }
		protected IntPtr ThresholdClass { get; }
		protected System.Type ThresholdType { get; }
	}
}
```

#### New Type: AndroidX.Media2.Session.MediaSessionServiceStub

```csharp
public abstract class MediaSessionServiceStub : Android.OS.Binder, Android.OS.IInterface, Android.Runtime.IJavaObject, IMediaSessionService, System.IDisposable {
	// constructors
	public MediaSessionServiceStub ();
	protected MediaSessionServiceStub (IntPtr, Android.Runtime.JniHandleOwnership);
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public virtual Android.OS.IBinder AsBinder ();
	public static IMediaSessionService AsInterface (Android.OS.IBinder);
	public virtual void Connect (IMediaController, AndroidX.VersionedParcelable.ParcelImpl);
	public virtual bool OnTransact (int, Android.OS.Parcel, Android.OS.Parcel, int);
}
```

#### New Type: AndroidX.Media2.Session.MediaSessionStub

```csharp
public abstract class MediaSessionStub : Android.OS.Binder, Android.OS.IInterface, Android.Runtime.IJavaObject, IMediaSession, System.IDisposable {
	// constructors
	public MediaSessionStub ();
	protected MediaSessionStub (IntPtr, Android.Runtime.JniHandleOwnership);
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public virtual void AddPlaylistItem (IMediaController, int, int, string);
	public virtual void AdjustVolume (IMediaController, int, int, int);
	public virtual Android.OS.IBinder AsBinder ();
	public static IMediaSession AsInterface (Android.OS.IBinder);
	public virtual void Connect (IMediaController, int, AndroidX.VersionedParcelable.ParcelImpl);
	public virtual void DeselectTrack (IMediaController, int, AndroidX.VersionedParcelable.ParcelImpl);
	public virtual void FastForward (IMediaController, int);
	public virtual void GetChildren (IMediaController, int, string, int, int, AndroidX.VersionedParcelable.ParcelImpl);
	public virtual void GetItem (IMediaController, int, string);
	public virtual void GetLibraryRoot (IMediaController, int, AndroidX.VersionedParcelable.ParcelImpl);
	public virtual void GetSearchResult (IMediaController, int, string, int, int, AndroidX.VersionedParcelable.ParcelImpl);
	public virtual void OnControllerResult (IMediaController, int, AndroidX.VersionedParcelable.ParcelImpl);
	public virtual void OnCustomCommand (IMediaController, int, AndroidX.VersionedParcelable.ParcelImpl, Android.OS.Bundle);
	public virtual bool OnTransact (int, Android.OS.Parcel, Android.OS.Parcel, int);
	public virtual void Pause (IMediaController, int);
	public virtual void Play (IMediaController, int);
	public virtual void PlayFromMediaId (IMediaController, int, string, Android.OS.Bundle);
	public virtual void PlayFromSearch (IMediaController, int, string, Android.OS.Bundle);
	public virtual void PlayFromUri (IMediaController, int, Android.Net.Uri, Android.OS.Bundle);
	public virtual void Prepare (IMediaController, int);
	public virtual void PrepareFromMediaId (IMediaController, int, string, Android.OS.Bundle);
	public virtual void PrepareFromSearch (IMediaController, int, string, Android.OS.Bundle);
	public virtual void PrepareFromUri (IMediaController, int, Android.Net.Uri, Android.OS.Bundle);
	public virtual void Release (IMediaController, int);
	public virtual void RemovePlaylistItem (IMediaController, int, int);
	public virtual void ReplacePlaylistItem (IMediaController, int, int, string);
	public virtual void Rewind (IMediaController, int);
	public virtual void Search (IMediaController, int, string, AndroidX.VersionedParcelable.ParcelImpl);
	public virtual void SeekTo (IMediaController, int, long);
	public virtual void SelectTrack (IMediaController, int, AndroidX.VersionedParcelable.ParcelImpl);
	public virtual void SetMediaItem (IMediaController, int, string);
	public virtual void SetPlaybackSpeed (IMediaController, int, float);
	public virtual void SetPlaylist (IMediaController, int, System.Collections.Generic.IList<string>, AndroidX.VersionedParcelable.ParcelImpl);
	public virtual void SetRating (IMediaController, int, string, AndroidX.VersionedParcelable.ParcelImpl);
	public virtual void SetRepeatMode (IMediaController, int, int);
	public virtual void SetShuffleMode (IMediaController, int, int);
	public virtual void SetSurface (IMediaController, int, Android.Views.Surface);
	public virtual void SetVolumeTo (IMediaController, int, int, int);
	public virtual void SkipBackward (IMediaController, int);
	public virtual void SkipForward (IMediaController, int);
	public virtual void SkipToNextItem (IMediaController, int);
	public virtual void SkipToPlaylistItem (IMediaController, int, int);
	public virtual void SkipToPreviousItem (IMediaController, int);
	public virtual void Subscribe (IMediaController, int, string, AndroidX.VersionedParcelable.ParcelImpl);
	public virtual void Unsubscribe (IMediaController, int, string);
	public virtual void UpdatePlaylistMetadata (IMediaController, int, AndroidX.VersionedParcelable.ParcelImpl);
}
```

#### New Type: AndroidX.Media2.Session.MediaUtils

```csharp
public class MediaUtils : Java.Lang.Object {
	// constructors
	protected MediaUtils (IntPtr, Android.Runtime.JniHandleOwnership);
	// fields
	public static const int CurrentVersion;
	public static const string Tag = "MediaUtils";
	public static const int TransactionSizeLimitInBytes;
	public static const int Version0;
	// properties
	public static Java.Util.Concurrent.IExecutor DirectExecutor { get; }
	public static AndroidX.Media.MediaBrowserServiceCompat.BrowserRoot SDefaultBrowserRoot { get; }
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public static System.Collections.Generic.IList<AndroidX.VersionedParcelable.ParcelImpl> ConvertCommandButtonListToParcelImplList (System.Collections.Generic.IList<MediaSession.CommandButton>);
	public static System.Collections.Generic.IList<AndroidX.Medai2.Common.MediaItem> ConvertMediaItemListToMediaItemList (System.Collections.Generic.IList<Android.Support.V4.Media.MediaBrowserCompat.MediaItem>);
	public static AndroidX.Medai2.Common.ParcelImplListSlice ConvertMediaItemListToParcelImplListSlice (System.Collections.Generic.IList<AndroidX.Medai2.Common.MediaItem>);
	public static System.Collections.Generic.IList<AndroidX.Medai2.Common.MediaItem> ConvertParcelImplListSliceToMediaItemList (AndroidX.Medai2.Common.ParcelImplListSlice);
	public static System.Collections.Generic.IList<AndroidX.Medai2.Common.MediaItem> ConvertQueueItemListToMediaItemList (System.Collections.Generic.IList<Android.Support.V4.Media.Session.MediaSessionCompat.QueueItem>);
	public static System.Collections.Generic.IList<MediaSession.CommandButton> ConvertToCustomLayout (Android.Support.V4.Media.Session.PlaybackStateCompat);
	public static MediaLibraryService.LibraryParams ConvertToLibraryParams (Android.Content.Context, Android.OS.Bundle);
	public static AndroidX.Medai2.Common.MediaItem ConvertToMediaItem (Android.Support.V4.Media.MediaBrowserCompat.MediaItem);
	public static AndroidX.Medai2.Common.MediaItem ConvertToMediaItem (Android.Support.V4.Media.MediaDescriptionCompat);
	public static AndroidX.Medai2.Common.MediaItem ConvertToMediaItem (Android.Support.V4.Media.MediaMetadataCompat);
	public static AndroidX.Medai2.Common.MediaItem ConvertToMediaItem (Android.Support.V4.Media.Session.MediaSessionCompat.QueueItem);
	public static Android.Support.V4.Media.MediaBrowserCompat.MediaItem ConvertToMediaItem (AndroidX.Medai2.Common.MediaItem);
	public static System.Collections.Generic.IList<Android.Support.V4.Media.MediaBrowserCompat.MediaItem> ConvertToMediaItemList (System.Collections.Generic.IList<AndroidX.Medai2.Common.MediaItem>);
	public static AndroidX.Medai2.Common.MediaMetadata ConvertToMediaMetadata (Java.Lang.ICharSequence);
	public static AndroidX.Medai2.Common.MediaMetadata ConvertToMediaMetadata (string);
	public static Android.Support.V4.Media.MediaMetadataCompat ConvertToMediaMetadataCompat (AndroidX.Medai2.Common.MediaMetadata);
	public static int ConvertToPlaybackStateCompatState (int, int);
	public static int ConvertToPlayerState (Android.Support.V4.Media.Session.PlaybackStateCompat);
	public static System.Collections.Generic.IList<Android.Support.V4.Media.Session.MediaSessionCompat.QueueItem> ConvertToQueueItemList (System.Collections.Generic.IList<AndroidX.Medai2.Common.MediaItem>);
	public static AndroidX.Medai2.Common.IRating ConvertToRating (Android.Support.V4.Media.RatingCompat);
	public static Android.Support.V4.Media.RatingCompat ConvertToRatingCompat (AndroidX.Medai2.Common.IRating);
	public static Android.OS.Bundle ConvertToRootHints (MediaLibraryService.LibraryParams);
	public static SessionCommandGroup ConvertToSessionCommandGroup (long, Android.Support.V4.Media.Session.PlaybackStateCompat);
	public static Android.Support.V4.Media.MediaDescriptionCompat CreateMediaDescriptionCompat (string);
	public static bool IsUnparcelableBundle (Android.OS.Bundle);
	public static void KeepUnparcelableBundlesOnly (System.Collections.Generic.IList<Android.OS.Bundle>);
	public static System.Collections.IList RemoveNullElements (System.Collections.IList);
	public static int ToBufferingState (int);
	public static MediaController.PlaybackInfo ToPlaybackInfo2 (Android.Support.V4.Media.Session.MediaControllerCompat.PlaybackInfo);
	public static System.Collections.IList TruncateListBySize (System.Collections.IList, int);
	public static AndroidX.Medai2.Common.MediaItem UpcastForPreparceling (AndroidX.Medai2.Common.MediaItem);
}
```

#### New Type: AndroidX.Media2.Session.PercentageRating

```csharp
public sealed class PercentageRating : Java.Lang.Object, Android.Runtime.IJavaObject, AndroidX.Medai2.Common.IRating, AndroidX.VersionedParcelable.IVersionedParcelable, System.IDisposable {
	// constructors
	public PercentageRating ();
	public PercentageRating (float);
	// properties
	public bool IsRated { get; }
	public float PercentRating { get; }
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
}
```

#### New Type: AndroidX.Media2.Session.PercentageRatingParcelizer

```csharp
public sealed class PercentageRatingParcelizer : Java.Lang.Object {
	// constructors
	public PercentageRatingParcelizer ();
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public static PercentageRating Read (AndroidX.VersionedParcelable.VersionedParcel);
	public static void Write (PercentageRating, AndroidX.VersionedParcelable.VersionedParcel);
}
```

#### New Type: AndroidX.Media2.Session.PlaybackInfoParcelizer

```csharp
public sealed class PlaybackInfoParcelizer : Java.Lang.Object {
	// constructors
	public PlaybackInfoParcelizer ();
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public static MediaController.PlaybackInfo Read (AndroidX.VersionedParcelable.VersionedParcel);
	public static void Write (MediaController.PlaybackInfo, AndroidX.VersionedParcelable.VersionedParcel);
}
```

#### New Type: AndroidX.Media2.Session.SessionCommand

```csharp
public sealed class SessionCommand : Java.Lang.Object, Android.Runtime.IJavaObject, AndroidX.VersionedParcelable.IVersionedParcelable, System.IDisposable {
	// constructors
	public SessionCommand (int);
	public SessionCommand (string, Android.OS.Bundle);
	// fields
	public static const int CommandCodeCustom;
	public static const int CommandCodeLibraryGetChildren;
	public static const int CommandCodeLibraryGetItem;
	public static const int CommandCodeLibraryGetLibraryRoot;
	public static const int CommandCodeLibraryGetSearchResult;
	public static const int CommandCodeLibrarySearch;
	public static const int CommandCodeLibrarySubscribe;
	public static const int CommandCodeLibraryUnsubscribe;
	public static const int CommandCodePlayerAddPlaylistItem;
	public static const int CommandCodePlayerDeselectTrack;
	public static const int CommandCodePlayerGetCurrentMediaItem;
	public static const int CommandCodePlayerGetPlaylist;
	public static const int CommandCodePlayerGetPlaylistMetadata;
	public static const int CommandCodePlayerPause;
	public static const int CommandCodePlayerPlay;
	public static const int CommandCodePlayerPrepare;
	public static const int CommandCodePlayerRemovePlaylistItem;
	public static const int CommandCodePlayerReplacePlaylistItem;
	public static const int CommandCodePlayerSeekTo;
	public static const int CommandCodePlayerSelectTrack;
	public static const int CommandCodePlayerSetMediaItem;
	public static const int CommandCodePlayerSetPlaylist;
	public static const int CommandCodePlayerSetRepeatMode;
	public static const int CommandCodePlayerSetShuffleMode;
	public static const int CommandCodePlayerSetSpeed;
	public static const int CommandCodePlayerSetSurface;
	public static const int CommandCodePlayerSkipToNextPlaylistItem;
	public static const int CommandCodePlayerSkipToPlaylistItem;
	public static const int CommandCodePlayerSkipToPreviousPlaylistItem;
	public static const int CommandCodePlayerUpdateListMetadata;
	public static const int CommandCodeSessionFastForward;
	public static const int CommandCodeSessionPlayFromMediaId;
	public static const int CommandCodeSessionPlayFromSearch;
	public static const int CommandCodeSessionPlayFromUri;
	public static const int CommandCodeSessionPrepareFromMediaId;
	public static const int CommandCodeSessionPrepareFromSearch;
	public static const int CommandCodeSessionPrepareFromUri;
	public static const int CommandCodeSessionRewind;
	public static const int CommandCodeSessionSetRating;
	public static const int CommandCodeSessionSkipBackward;
	public static const int CommandCodeSessionSkipForward;
	public static const int CommandCodeVolumeAdjustVolume;
	public static const int CommandCodeVolumeSetVolume;
	public static const int CommandVersion1;
	public static const int CommandVersionCurrent;
	// properties
	public int CommandCode { get; }
	public string CustomAction { get; }
	public Android.OS.Bundle CustomExtras { get; }
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }

	// inner types
	public interface ICommandCode : Android.Runtime.IJavaObject, Java.Lang.Annotation.IAnnotation, System.IDisposable {
	}
	public interface ICommandVersion : Android.Runtime.IJavaObject, Java.Lang.Annotation.IAnnotation, System.IDisposable {
	}
	public sealed class Range : Java.Lang.Object {
		// properties
		public int Lower { get; set; }
		protected IntPtr ThresholdClass { get; }
		protected System.Type ThresholdType { get; }
		public int Upper { get; set; }
	}
}
```

#### New Type: AndroidX.Media2.Session.SessionCommandGroup

```csharp
public sealed class SessionCommandGroup : Java.Lang.Object, Android.Runtime.IJavaObject, AndroidX.VersionedParcelable.IVersionedParcelable, System.IDisposable {
	// constructors
	public SessionCommandGroup ();
	public SessionCommandGroup (System.Collections.Generic.ICollection<SessionCommand>);
	// properties
	public System.Collections.Generic.ICollection<SessionCommand> Commands { get; }
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public bool HasCommand (SessionCommand);
	public bool HasCommand (int);

	// inner types
	public sealed class Builder : Java.Lang.Object {
		// constructors
		public SessionCommandGroup.Builder ();
		public SessionCommandGroup.Builder (SessionCommandGroup);
		// properties
		protected IntPtr ThresholdClass { get; }
		protected System.Type ThresholdType { get; }
		// methods
		public SessionCommandGroup.Builder AddAllPredefinedCommands (int);
		public SessionCommandGroup.Builder AddCommand (SessionCommand);
		public SessionCommandGroup Build ();
		public SessionCommandGroup.Builder RemoveCommand (SessionCommand);
	}
}
```

#### New Type: AndroidX.Media2.Session.SessionCommandGroupParcelizer

```csharp
public sealed class SessionCommandGroupParcelizer : Java.Lang.Object {
	// constructors
	public SessionCommandGroupParcelizer ();
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public static SessionCommandGroup Read (AndroidX.VersionedParcelable.VersionedParcel);
	public static void Write (SessionCommandGroup, AndroidX.VersionedParcelable.VersionedParcel);
}
```

#### New Type: AndroidX.Media2.Session.SessionCommandParcelizer

```csharp
public sealed class SessionCommandParcelizer : Java.Lang.Object {
	// constructors
	public SessionCommandParcelizer ();
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public static SessionCommand Read (AndroidX.VersionedParcelable.VersionedParcel);
	public static void Write (SessionCommand, AndroidX.VersionedParcelable.VersionedParcel);
}
```

#### New Type: AndroidX.Media2.Session.SessionResult

```csharp
public class SessionResult : AndroidX.VersionedParcelable.CustomVersionedParcelable, Android.Runtime.IJavaObject, AndroidX.VersionedParcelable.IVersionedParcelable, System.IDisposable {
	// constructors
	public SessionResult (int, Android.OS.Bundle);
	protected SessionResult (IntPtr, Android.Runtime.JniHandleOwnership);
	// fields
	public static const int ResultSuccess;
	// properties
	public long CompletionTime { get; }
	public Android.OS.Bundle CustomCommandResult { get; }
	public AndroidX.Medai2.Common.MediaItem MediaItem { get; }
	public int ResultCode { get; }
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }

	// inner types
	public interface IResultCode : Android.Runtime.IJavaObject, Java.Lang.Annotation.IAnnotation, System.IDisposable {
	}
}
```

#### New Type: AndroidX.Media2.Session.SessionResultParcelizer

```csharp
public sealed class SessionResultParcelizer : Java.Lang.Object {
	// constructors
	public SessionResultParcelizer ();
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public static SessionResult Read (AndroidX.VersionedParcelable.VersionedParcel);
	public static void Write (SessionResult, AndroidX.VersionedParcelable.VersionedParcel);
}
```

#### New Type: AndroidX.Media2.Session.SessionToken

```csharp
public sealed class SessionToken : Java.Lang.Object, Android.Runtime.IJavaObject, AndroidX.VersionedParcelable.IVersionedParcelable, System.IDisposable {
	// constructors
	public SessionToken (Android.Content.Context, Android.Content.ComponentName);
	// fields
	public static const int TypeLibraryService;
	public static const int TypeSession;
	public static const int TypeSessionService;
	// properties
	public Java.Lang.Object Binder { get; }
	public Android.Content.ComponentName ComponentName { get; }
	public Android.OS.Bundle Extras { get; }
	public bool IsLegacySession { get; }
	public string PackageName { get; }
	public string ServiceName { get; }
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	public int Type { get; }
	public int Uid { get; }
	// methods
	public static void CreateSessionToken (Android.Content.Context, Android.Support.V4.Media.Session.MediaSessionCompat.Token, Java.Util.Concurrent.IExecutor, SessionToken.IOnSessionTokenCreatedListener);

	// inner types
	public interface IOnSessionTokenCreatedListener : Android.Runtime.IJavaObject, System.IDisposable {
		// methods
		public virtual void OnSessionTokenCreated (Android.Support.V4.Media.Session.MediaSessionCompat.Token, SessionToken);
	}
	public interface ISessionTokenImpl : Android.Runtime.IJavaObject, AndroidX.VersionedParcelable.IVersionedParcelable, System.IDisposable {
		// properties
		public Java.Lang.Object Binder { get; }
		public Android.Content.ComponentName ComponentName { get; }
		public Android.OS.Bundle Extras { get; }
		public bool IsLegacySession { get; }
		public string PackageName { get; }
		public string ServiceName { get; }
		public int Type { get; }
		public int Uid { get; }
	}
	public interface ITokenType : Android.Runtime.IJavaObject, Java.Lang.Annotation.IAnnotation, System.IDisposable {
	}
	public class SessionTokenCreatedEventArgs : System.EventArgs {
		// constructors
		public SessionToken.SessionTokenCreatedEventArgs (Android.Support.V4.Media.Session.MediaSessionCompat.Token, SessionToken);
		// properties
		public Android.Support.V4.Media.Session.MediaSessionCompat.Token P0 { get; }
		public SessionToken P1 { get; }
	}
}
```

#### New Type: AndroidX.Media2.Session.SessionTokenImplBaseParcelizer

```csharp
public sealed class SessionTokenImplBaseParcelizer : Java.Lang.Object {
	// constructors
	public SessionTokenImplBaseParcelizer ();
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public static Java.Lang.Object Read (AndroidX.VersionedParcelable.VersionedParcel);
}
```

#### New Type: AndroidX.Media2.Session.SessionTokenImplLegacyParcelizer

```csharp
public sealed class SessionTokenImplLegacyParcelizer : Java.Lang.Object {
	// constructors
	public SessionTokenImplLegacyParcelizer ();
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public static AndroidX.VersionedParcelable.CustomVersionedParcelable Read (AndroidX.VersionedParcelable.VersionedParcel);
}
```

#### New Type: AndroidX.Media2.Session.SessionTokenParcelizer

```csharp
public sealed class SessionTokenParcelizer : Java.Lang.Object {
	// constructors
	public SessionTokenParcelizer ();
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public static SessionToken Read (AndroidX.VersionedParcelable.VersionedParcel);
	public static void Write (SessionToken, AndroidX.VersionedParcelable.VersionedParcel);
}
```

#### New Type: AndroidX.Media2.Session.StarRating

```csharp
public sealed class StarRating : Java.Lang.Object, Android.Runtime.IJavaObject, AndroidX.Medai2.Common.IRating, AndroidX.VersionedParcelable.IVersionedParcelable, System.IDisposable {
	// constructors
	public StarRating (int);
	public StarRating (int, float);
	// properties
	public bool IsRated { get; }
	public int MaxStars { get; }
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public float GetStarRating ();
}
```

#### New Type: AndroidX.Media2.Session.StarRatingParcelizer

```csharp
public sealed class StarRatingParcelizer : Java.Lang.Object {
	// constructors
	public StarRatingParcelizer ();
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public static StarRating Read (AndroidX.VersionedParcelable.VersionedParcel);
	public static void Write (StarRating, AndroidX.VersionedParcelable.VersionedParcel);
}
```

#### New Type: AndroidX.Media2.Session.ThumbRating

```csharp
public sealed class ThumbRating : Java.Lang.Object, Android.Runtime.IJavaObject, AndroidX.Medai2.Common.IRating, AndroidX.VersionedParcelable.IVersionedParcelable, System.IDisposable {
	// constructors
	public ThumbRating ();
	public ThumbRating (bool);
	// properties
	public bool IsRated { get; }
	public bool IsThumbUp { get; }
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
}
```

#### New Type: AndroidX.Media2.Session.ThumbRatingParcelizer

```csharp
public sealed class ThumbRatingParcelizer : Java.Lang.Object {
	// constructors
	public ThumbRatingParcelizer ();
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public static ThumbRating Read (AndroidX.VersionedParcelable.VersionedParcel);
	public static void Write (ThumbRating, AndroidX.VersionedParcelable.VersionedParcel);
}
```

### New Namespace AndroidX.Media2.Session.Futures

#### New Type: AndroidX.Media2.Session.Futures.AbstractResolvableFuture

```csharp
public abstract class AbstractResolvableFuture : Java.Lang.Object, Android.Runtime.IJavaObject, Google.Common.Util.Concurrent.IListenableFuture, Java.Util.Concurrent.IFuture, System.IDisposable {
	// constructors
	protected AbstractResolvableFuture ();
	protected AbstractResolvableFuture (IntPtr, Android.Runtime.JniHandleOwnership);
	// properties
	public bool IsCancelled { get; }
	public bool IsDone { get; }
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public virtual void AddListener (Java.Lang.IRunnable, Java.Util.Concurrent.IExecutor);
	protected virtual void AfterDone ();
	public virtual bool Cancel (bool);
	public virtual Java.Lang.Object Get ();
	public virtual Java.Lang.Object Get (long, Java.Util.Concurrent.TimeUnit);
	protected virtual void InterruptTask ();
	protected virtual string PendingToString ();
	protected virtual bool Set (Java.Lang.Object);
	protected virtual bool SetException (Java.Lang.Throwable);
	protected virtual bool SetFuture (Google.Common.Util.Concurrent.IListenableFuture);
	protected bool WasInterrupted ();
}
```

#### New Type: AndroidX.Media2.Session.Futures.ResolvableFuture

```csharp
public sealed class ResolvableFuture : AndroidX.Media2.Session.Futures.AbstractResolvableFuture, Android.Runtime.IJavaObject, Google.Common.Util.Concurrent.IListenableFuture, Java.Util.Concurrent.IFuture, System.IDisposable {
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public static ResolvableFuture Create ();
	public bool Set (Java.Lang.Object);
	public bool SetException (Java.Lang.Throwable);
	public bool SetFuture (Google.Common.Util.Concurrent.IListenableFuture);
}
```

### New Namespace AndroidX.Media2.Widget

#### New Type: AndroidX.Media2.Widget.MediaControlView

```csharp
public class MediaControlView : Android.Views.ViewGroup {
	// constructors
	public MediaControlView (Android.Content.Context);
	public MediaControlView (Android.Content.Context, Android.Util.IAttributeSet);
	protected MediaControlView (IntPtr, Android.Runtime.JniHandleOwnership);
	public MediaControlView (Android.Content.Context, Android.Util.IAttributeSet, int);
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// events
	public event System.EventHandler<MediaControlView.FullScreenEventArgs> FullScreen;
	// methods
	protected override void OnLayout (bool, int, int, int, int);
	public override void OnVisibilityAggregated (bool);
	public virtual void RequestPlayButtonFocus ();
	public virtual void SetMediaController (AndroidX.Media2.Session.MediaController);
	public virtual void SetOnFullScreenListener (MediaControlView.IOnFullScreenListener);
	public virtual void SetPlayer (AndroidX.Medai2.Common.SessionPlayer);

	// inner types
	public class FullScreenEventArgs : System.EventArgs {
		// constructors
		public MediaControlView.FullScreenEventArgs (Android.Views.View, bool);
		// properties
		public Android.Views.View P0 { get; }
		public bool P1 { get; }
	}
	public interface IOnFullScreenListener : Android.Runtime.IJavaObject, System.IDisposable {
		// methods
		public virtual void OnFullScreen (Android.Views.View, bool);
	}
}
```

#### New Type: AndroidX.Media2.Widget.VideoView

```csharp
public class VideoView : Android.Views.ViewGroup {
	// constructors
	public VideoView (Android.Content.Context);
	public VideoView (Android.Content.Context, Android.Util.IAttributeSet);
	protected VideoView (IntPtr, Android.Runtime.JniHandleOwnership);
	public VideoView (Android.Content.Context, Android.Util.IAttributeSet, int);
	// fields
	public static const int ViewTypeSurfaceview;
	public static const int ViewTypeTextureview;
	// properties
	public MediaControlView MediaControlView { get; }
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	public int ViewType { get; set; }
	// events
	public event System.EventHandler<VideoView.ViewTypeChangedEventArgs> ViewTypeChanged;
	// methods
	public override Android.Views.ViewGroup.LayoutParams GenerateLayoutParams (Android.Util.IAttributeSet);
	protected override void OnLayout (bool, int, int, int, int);
	public override void OnVisibilityAggregated (bool);
	public virtual void SetMediaControlView (MediaControlView, long);
	public virtual void SetMediaController (AndroidX.Media2.Session.MediaController);
	public virtual void SetOnViewTypeChangedListener (VideoView.IOnViewTypeChangedListener);
	public virtual void SetPlayer (AndroidX.Medai2.Common.SessionPlayer);
	public override bool ShouldDelayChildPressedState ();

	// inner types
	public interface IOnViewTypeChangedListener : Android.Runtime.IJavaObject, System.IDisposable {
		// methods
		public virtual void OnViewTypeChanged (Android.Views.View, int);
	}
	public class ViewTypeChangedEventArgs : System.EventArgs {
		// constructors
		public VideoView.ViewTypeChangedEventArgs (Android.Views.View, int);
		// properties
		public Android.Views.View P0 { get; }
		public int P1 { get; }
	}
}
```

### New Namespace AndroidX.Navigation

#### New Type: AndroidX.Navigation.ActionOnlyNavDirections

```csharp
public sealed class ActionOnlyNavDirections : Java.Lang.Object, Android.Runtime.IJavaObject, INavDirections, System.IDisposable {
	// constructors
	public ActionOnlyNavDirections (int);
	// properties
	public int ActionId { get; }
	public Android.OS.Bundle Arguments { get; }
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
}
```

#### New Type: AndroidX.Navigation.ActivityNavigator

```csharp
public class ActivityNavigator : AndroidX.Navigation.Navigator {
	// constructors
	public ActivityNavigator (Android.Content.Context);
	protected ActivityNavigator (IntPtr, Android.Runtime.JniHandleOwnership);
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public static void ApplyPopAnimationsToPendingTransition (Android.App.Activity);
	public override Java.Lang.Object CreateDestination ();
	public override NavDestination Navigate (Java.Lang.Object, Android.OS.Bundle, NavOptions, Navigator.IExtras);
	public override bool PopBackStack ();

	// inner types
	public class Destination : AndroidX.Navigation.NavDestination {
		// constructors
		public ActivityNavigator.Destination (Navigator);
		public ActivityNavigator.Destination (NavigatorProvider);
		protected ActivityNavigator.Destination (IntPtr, Android.Runtime.JniHandleOwnership);
		// properties
		public string Action { get; }
		public Android.Content.ComponentName Component { get; }
		public Android.Net.Uri Data { get; }
		public string DataPattern { get; }
		public Android.Content.Intent Intent { get; }
		public string TargetPackage { get; }
		protected IntPtr ThresholdClass { get; }
		protected System.Type ThresholdType { get; }
		// methods
		public ActivityNavigator.Destination SetAction (string);
		public ActivityNavigator.Destination SetComponentName (Android.Content.ComponentName);
		public ActivityNavigator.Destination SetData (Android.Net.Uri);
		public ActivityNavigator.Destination SetDataPattern (string);
		public ActivityNavigator.Destination SetIntent (Android.Content.Intent);
		public ActivityNavigator.Destination SetTargetPackage (string);
	}
	public sealed class Extras : Java.Lang.Object, Android.Runtime.IJavaObject, Navigator.IExtras, System.IDisposable {
		// properties
		public AndroidX.Core.App.ActivityOptionsCompat ActivityOptions { get; }
		public int Flags { get; }
		protected IntPtr ThresholdClass { get; }
		protected System.Type ThresholdType { get; }

		// inner types
		public sealed class Builder : Java.Lang.Object {
			// constructors
			public ActivityNavigator.Extras.Builder ();
			// properties
			protected IntPtr ThresholdClass { get; }
			protected System.Type ThresholdType { get; }
			// methods
			public ActivityNavigator.Extras.Builder AddFlags (int);
			public ActivityNavigator.Extras Build ();
			public ActivityNavigator.Extras.Builder SetActivityOptions (AndroidX.Core.App.ActivityOptionsCompat);
		}
	}
}
```

#### New Type: AndroidX.Navigation.IFloatingWindow

```csharp
public interface IFloatingWindow : Android.Runtime.IJavaObject, System.IDisposable {
}
```

#### New Type: AndroidX.Navigation.INavArgs

```csharp
public interface INavArgs : Android.Runtime.IJavaObject, System.IDisposable {
}
```

#### New Type: AndroidX.Navigation.INavDirections

```csharp
public interface INavDirections : Android.Runtime.IJavaObject, System.IDisposable {
	// properties
	public int ActionId { get; }
	public Android.OS.Bundle Arguments { get; }
}
```

#### New Type: AndroidX.Navigation.INavHost

```csharp
public interface INavHost : Android.Runtime.IJavaObject, System.IDisposable {
	// properties
	public NavController NavController { get; }
}
```

#### New Type: AndroidX.Navigation.NavAction

```csharp
public sealed class NavAction : Java.Lang.Object {
	// constructors
	public NavAction (int);
	public NavAction (int, NavOptions);
	public NavAction (int, NavOptions, Android.OS.Bundle);
	// properties
	public Android.OS.Bundle DefaultArguments { get; set; }
	public int DestinationId { get; }
	public NavOptions NavOptions { get; set; }
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
}
```

#### New Type: AndroidX.Navigation.NavArgument

```csharp
public sealed class NavArgument : Java.Lang.Object {
	// properties
	public Java.Lang.Object DefaultValue { get; }
	public bool IsDefaultValuePresent { get; }
	public bool IsNullable { get; }
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	public NavType Type { get; }

	// inner types
	public sealed class Builder : Java.Lang.Object {
		// constructors
		public NavArgument.Builder ();
		// properties
		protected IntPtr ThresholdClass { get; }
		protected System.Type ThresholdType { get; }
		// methods
		public NavArgument Build ();
		public NavArgument.Builder SetDefaultValue (Java.Lang.Object);
		public NavArgument.Builder SetIsNullable (bool);
		public NavArgument.Builder SetType (NavType);
	}
}
```

#### New Type: AndroidX.Navigation.NavController

```csharp
public class NavController : Java.Lang.Object {
	// constructors
	public NavController (Android.Content.Context);
	protected NavController (IntPtr, Android.Runtime.JniHandleOwnership);
	// fields
	public static const string KeyDeepLinkIntent = "android-support-nav:controller:deepLinkIntent";
	// properties
	public NavDestination CurrentDestination { get; }
	public NavGraph Graph { get; set; }
	public NavInflater NavInflater { get; }
	public NavigatorProvider NavigatorProvider { get; }
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// events
	public event System.EventHandler<NavController.DestinationChangedEventArgs> DestinationChanged;
	// methods
	public virtual void AddOnDestinationChangedListener (NavController.IOnDestinationChangedListener);
	public virtual NavDeepLinkBuilder CreateDeepLink ();
	public virtual AndroidX.Lifecycle.IViewModelStoreOwner GetViewModelStoreOwner (int);
	public virtual bool HandleDeepLink (Android.Content.Intent);
	public virtual void Navigate (Android.Net.Uri);
	public virtual void Navigate (INavDirections);
	public virtual void Navigate (int);
	public virtual void Navigate (Android.Net.Uri, NavOptions);
	public virtual void Navigate (INavDirections, NavOptions);
	public virtual void Navigate (INavDirections, Navigator.IExtras);
	public virtual void Navigate (int, Android.OS.Bundle);
	public virtual void Navigate (Android.Net.Uri, NavOptions, Navigator.IExtras);
	public virtual void Navigate (int, Android.OS.Bundle, NavOptions);
	public virtual void Navigate (int, Android.OS.Bundle, NavOptions, Navigator.IExtras);
	public virtual bool NavigateUp ();
	public virtual bool PopBackStack ();
	public virtual bool PopBackStack (int, bool);
	public virtual void RemoveOnDestinationChangedListener (NavController.IOnDestinationChangedListener);
	public virtual void RestoreState (Android.OS.Bundle);
	public virtual Android.OS.Bundle SaveState ();
	public virtual void SetGraph (int);
	public virtual void SetGraph (NavGraph, Android.OS.Bundle);
	public virtual void SetGraph (int, Android.OS.Bundle);

	// inner types
	public class DestinationChangedEventArgs : System.EventArgs {
		// constructors
		public NavController.DestinationChangedEventArgs (NavController, NavDestination, Android.OS.Bundle);
		// properties
		public NavController P0 { get; }
		public NavDestination P1 { get; }
		public Android.OS.Bundle P2 { get; }
	}
	public interface IOnDestinationChangedListener : Android.Runtime.IJavaObject, System.IDisposable {
		// methods
		public virtual void OnDestinationChanged (NavController, NavDestination, Android.OS.Bundle);
	}
}
```

#### New Type: AndroidX.Navigation.NavDeepLinkBuilder

```csharp
public sealed class NavDeepLinkBuilder : Java.Lang.Object {
	// constructors
	public NavDeepLinkBuilder (Android.Content.Context);
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public Android.App.PendingIntent CreatePendingIntent ();
	public AndroidX.Core.App.TaskStackBuilder CreateTaskStackBuilder ();
	public NavDeepLinkBuilder SetArguments (Android.OS.Bundle);
	public NavDeepLinkBuilder SetComponentName (Android.Content.ComponentName);
	public NavDeepLinkBuilder SetComponentName (Java.Lang.Class);
	public NavDeepLinkBuilder SetDestination (int);
	public NavDeepLinkBuilder SetGraph (NavGraph);
	public NavDeepLinkBuilder SetGraph (int);
}
```

#### New Type: AndroidX.Navigation.NavDestination

```csharp
public class NavDestination : Java.Lang.Object {
	// constructors
	public NavDestination (Navigator);
	public NavDestination (string);
	protected NavDestination (IntPtr, Android.Runtime.JniHandleOwnership);
	// properties
	public System.Collections.Generic.IDictionary<System.String,AndroidX.Navigation.NavArgument> Arguments { get; }
	public int Id { get; set; }
	public string Label { get; set; }
	public Java.Lang.ICharSequence LabelFormatted { get; set; }
	public string NavigatorName { get; }
	public NavGraph Parent { get; }
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public void AddArgument (string, NavArgument);
	public void AddDeepLink (string);
	public NavAction GetAction (int);
	public virtual bool HasDeepLink (Android.Net.Uri);
	public virtual void OnInflate (Android.Content.Context, Android.Util.IAttributeSet);
	protected static Java.Lang.Class ParseClassFromName (Android.Content.Context, string, Java.Lang.Class);
	public void PutAction (int, NavAction);
	public void PutAction (int, int);
	public void RemoveAction (int);
	public void RemoveArgument (string);

	// inner types
	public class DeepLinkMatch : Java.Lang.Object, Android.Runtime.IJavaObject, Java.Lang.IComparable, System.IDisposable {
		// constructors
		protected NavDestination.DeepLinkMatch (IntPtr, Android.Runtime.JniHandleOwnership);
		// properties
		protected IntPtr ThresholdClass { get; }
		protected System.Type ThresholdType { get; }
		// methods
		public virtual int CompareTo (Java.Lang.Object);
	}
	public interface IClassType : Android.Runtime.IJavaObject, Java.Lang.Annotation.IAnnotation, System.IDisposable {
		// methods
		public virtual Java.Lang.Class Value ();
	}
}
```

#### New Type: AndroidX.Navigation.NavGraph

```csharp
public class NavGraph : AndroidX.Navigation.NavDestination, Android.Runtime.IJavaObject, Java.Lang.IIterable, System.IDisposable {
	// constructors
	public NavGraph (Navigator);
	protected NavGraph (IntPtr, Android.Runtime.JniHandleOwnership);
	// properties
	public int StartDestination { get; set; }
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public void AddAll (NavGraph);
	public void AddDestination (NavDestination);
	public void AddDestinations (NavDestination[]);
	public void AddDestinations (System.Collections.Generic.ICollection<NavDestination>);
	public void Clear ();
	public NavDestination FindNode (int);
	public virtual Java.Util.IIterator Iterator ();
	public void Remove (NavDestination);
}
```

#### New Type: AndroidX.Navigation.NavGraphNavigator

```csharp
public class NavGraphNavigator : AndroidX.Navigation.Navigator {
	// constructors
	public NavGraphNavigator (NavigatorProvider);
	protected NavGraphNavigator (IntPtr, Android.Runtime.JniHandleOwnership);
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public override Java.Lang.Object CreateDestination ();
	public override NavDestination Navigate (Java.Lang.Object, Android.OS.Bundle, NavOptions, Navigator.IExtras);
	public override bool PopBackStack ();
}
```

#### New Type: AndroidX.Navigation.NavHostController

```csharp
public sealed class NavHostController : AndroidX.Navigation.NavController {
	// constructors
	public NavHostController (Android.Content.Context);
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public void EnableOnBackPressed (bool);
	public void SetLifecycleOwner (AndroidX.Lifecycle.ILifecycleOwner);
	public void SetOnBackPressedDispatcher (AndroidX.Activity.OnBackPressedDispatcher);
	public void SetViewModelStore (AndroidX.Lifecycle.ViewModelStore);
}
```

#### New Type: AndroidX.Navigation.NavInflater

```csharp
public sealed class NavInflater : Java.Lang.Object {
	// constructors
	public NavInflater (Android.Content.Context, NavigatorProvider);
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public NavGraph Inflate (int);
}
```

#### New Type: AndroidX.Navigation.NavOptions

```csharp
public sealed class NavOptions : Java.Lang.Object {
	// properties
	public int EnterAnim { get; }
	public int ExitAnim { get; }
	public bool IsPopUpToInclusive { get; }
	public int PopEnterAnim { get; }
	public int PopExitAnim { get; }
	public int PopUpTo { get; }
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public bool ShouldLaunchSingleTop ();

	// inner types
	public sealed class Builder : Java.Lang.Object {
		// constructors
		public NavOptions.Builder ();
		// properties
		protected IntPtr ThresholdClass { get; }
		protected System.Type ThresholdType { get; }
		// methods
		public NavOptions Build ();
		public NavOptions.Builder SetEnterAnim (int);
		public NavOptions.Builder SetExitAnim (int);
		public NavOptions.Builder SetLaunchSingleTop (bool);
		public NavOptions.Builder SetPopEnterAnim (int);
		public NavOptions.Builder SetPopExitAnim (int);
		public NavOptions.Builder SetPopUpTo (int, bool);
	}
}
```

#### New Type: AndroidX.Navigation.NavType

```csharp
public abstract class NavType : Java.Lang.Object {
	// constructors
	protected NavType (IntPtr, Android.Runtime.JniHandleOwnership);
	// properties
	public static NavType BoolArrayType { get; }
	public static NavType BoolType { get; }
	public static NavType FloatArrayType { get; }
	public static NavType FloatType { get; }
	public static NavType IntArrayType { get; }
	public static NavType IntType { get; }
	public bool IsNullableAllowed { get; }
	public static NavType LongArrayType { get; }
	public static NavType LongType { get; }
	public string Name { get; }
	public static NavType ReferenceType { get; }
	public static NavType StringArrayType { get; }
	public static NavType StringType { get; }
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public static NavType FromArgType (string, string);
	public virtual Java.Lang.Object Get (Android.OS.Bundle, string);
	public virtual Java.Lang.Object ParseValue (string);

	// inner types
	public sealed class EnumType : AndroidX.Navigation.NavType+SerializableType {
		// constructors
		public NavType.EnumType (Java.Lang.Class);
		// properties
		protected IntPtr ThresholdClass { get; }
		protected System.Type ThresholdType { get; }
	}
	public sealed class ParcelableArrayType : AndroidX.Navigation.NavType {
		// constructors
		public NavType.ParcelableArrayType (Java.Lang.Class);
		// properties
		public string Name { get; }
		protected IntPtr ThresholdClass { get; }
		protected System.Type ThresholdType { get; }
		// methods
		public override Java.Lang.Object Get (Android.OS.Bundle, string);
		public override Java.Lang.Object ParseValue (string);
		public void Put (Android.OS.Bundle, string, Java.Lang.Object[]);
	}
	public sealed class ParcelableType : AndroidX.Navigation.NavType {
		// constructors
		public NavType.ParcelableType (Java.Lang.Class);
		// properties
		public string Name { get; }
		protected IntPtr ThresholdClass { get; }
		protected System.Type ThresholdType { get; }
		// methods
		public override Java.Lang.Object Get (Android.OS.Bundle, string);
		public override Java.Lang.Object ParseValue (string);
		public void Put (Android.OS.Bundle, string, Java.Lang.Object);
	}
	public sealed class SerializableArrayType : AndroidX.Navigation.NavType {
		// constructors
		public NavType.SerializableArrayType (Java.Lang.Class);
		// properties
		public string Name { get; }
		protected IntPtr ThresholdClass { get; }
		protected System.Type ThresholdType { get; }
		// methods
		public override Java.Lang.Object Get (Android.OS.Bundle, string);
		public override Java.Lang.Object ParseValue (string);
		public void Put (Android.OS.Bundle, string, Java.Lang.Object[]);
	}
	public class SerializableType : AndroidX.Navigation.NavType {
		// constructors
		public NavType.SerializableType (Java.Lang.Class);
		protected NavType.SerializableType (IntPtr, Android.Runtime.JniHandleOwnership);
		// properties
		public string Name { get; }
		protected IntPtr ThresholdClass { get; }
		protected System.Type ThresholdType { get; }
		// methods
		public override Java.Lang.Object Get (Android.OS.Bundle, string);
		public override Java.Lang.Object ParseValue (string);
		public virtual void Put (Android.OS.Bundle, string, Java.Lang.Object);
	}
}
```

#### New Type: AndroidX.Navigation.Navigation

```csharp
public sealed class Navigation : Java.Lang.Object {
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public static Android.Views.View.IOnClickListener CreateNavigateOnClickListener (INavDirections);
	public static Android.Views.View.IOnClickListener CreateNavigateOnClickListener (int);
	public static Android.Views.View.IOnClickListener CreateNavigateOnClickListener (int, Android.OS.Bundle);
	public static NavController FindNavController (Android.Views.View);
	public static NavController FindNavController (Android.App.Activity, int);
	public static void SetViewNavController (Android.Views.View, NavController);
}
```

#### New Type: AndroidX.Navigation.Navigator

```csharp
public abstract class Navigator : Java.Lang.Object {
	// constructors
	public Navigator ();
	protected Navigator (IntPtr, Android.Runtime.JniHandleOwnership);
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public virtual Java.Lang.Object CreateDestination ();
	public virtual NavDestination Navigate (Java.Lang.Object, Android.OS.Bundle, NavOptions, Navigator.IExtras);
	public virtual void OnRestoreState (Android.OS.Bundle);
	public virtual Android.OS.Bundle OnSaveState ();
	public virtual bool PopBackStack ();

	// inner types
	public interface IExtras : Android.Runtime.IJavaObject, System.IDisposable {
	}
	public interface IName : Android.Runtime.IJavaObject, Java.Lang.Annotation.IAnnotation, System.IDisposable {
		// methods
		public virtual string Value ();
	}
}
```

#### New Type: AndroidX.Navigation.NavigatorProvider

```csharp
public class NavigatorProvider : Java.Lang.Object {
	// constructors
	public NavigatorProvider ();
	protected NavigatorProvider (IntPtr, Android.Runtime.JniHandleOwnership);
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public Navigator AddNavigator (Navigator);
	public virtual Navigator AddNavigator (string, Navigator);
	public Java.Lang.Object GetNavigator (Java.Lang.Class);
	public virtual Java.Lang.Object GetNavigator (string);
}
```

### New Namespace AndroidX.Navigation.Fragment

#### New Type: AndroidX.Navigation.Fragment.DialogFragmentNavigator

```csharp
public sealed class DialogFragmentNavigator : AndroidX.Navigation.Navigator {
	// constructors
	public DialogFragmentNavigator (Android.Content.Context, AndroidX.Fragment.App.FragmentManager);
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public override Java.Lang.Object CreateDestination ();
	public override AndroidX.Navigation.NavDestination Navigate (Java.Lang.Object, Android.OS.Bundle, AndroidX.Navigation.NavOptions, AndroidX.Navigation.Navigator.IExtras);
	public override bool PopBackStack ();

	// inner types
	public class Destination : AndroidX.Navigation.NavDestination, Android.Runtime.IJavaObject, AndroidX.Navigation.IFloatingWindow, System.IDisposable {
		// constructors
		public DialogFragmentNavigator.Destination (AndroidX.Navigation.Navigator);
		public DialogFragmentNavigator.Destination (AndroidX.Navigation.NavigatorProvider);
		protected DialogFragmentNavigator.Destination (IntPtr, Android.Runtime.JniHandleOwnership);
		// properties
		public string ClassName { get; }
		protected IntPtr ThresholdClass { get; }
		protected System.Type ThresholdType { get; }
		// methods
		public DialogFragmentNavigator.Destination SetClassName (string);
	}
}
```

#### New Type: AndroidX.Navigation.Fragment.FragmentNavigator

```csharp
public class FragmentNavigator : AndroidX.Navigation.Navigator {
	// constructors
	protected FragmentNavigator (IntPtr, Android.Runtime.JniHandleOwnership);
	public FragmentNavigator (Android.Content.Context, AndroidX.Fragment.App.FragmentManager, int);
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public override Java.Lang.Object CreateDestination ();

	[Obsolete ("deprecated")]
public virtual AndroidX.Fragment.App.Fragment InstantiateFragment (Android.Content.Context, AndroidX.Fragment.App.FragmentManager, string, Android.OS.Bundle);
	public override AndroidX.Navigation.NavDestination Navigate (Java.Lang.Object, Android.OS.Bundle, AndroidX.Navigation.NavOptions, AndroidX.Navigation.Navigator.IExtras);
	public override bool PopBackStack ();

	// inner types
	public class Destination : AndroidX.Navigation.NavDestination {
		// constructors
		public FragmentNavigator.Destination (AndroidX.Navigation.Navigator);
		public FragmentNavigator.Destination (AndroidX.Navigation.NavigatorProvider);
		protected FragmentNavigator.Destination (IntPtr, Android.Runtime.JniHandleOwnership);
		// properties
		public string ClassName { get; }
		protected IntPtr ThresholdClass { get; }
		protected System.Type ThresholdType { get; }
		// methods
		public FragmentNavigator.Destination SetClassName (string);
	}
	public sealed class Extras : Java.Lang.Object, Android.Runtime.IJavaObject, AndroidX.Navigation.Navigator.IExtras, System.IDisposable {
		// properties
		public System.Collections.Generic.IDictionary<Android.Views.View,System.String> SharedElements { get; }
		protected IntPtr ThresholdClass { get; }
		protected System.Type ThresholdType { get; }

		// inner types
		public sealed class Builder : Java.Lang.Object {
			// constructors
			public FragmentNavigator.Extras.Builder ();
			// properties
			protected IntPtr ThresholdClass { get; }
			protected System.Type ThresholdType { get; }
			// methods
			public FragmentNavigator.Extras.Builder AddSharedElement (Android.Views.View, string);
			public FragmentNavigator.Extras.Builder AddSharedElements (System.Collections.Generic.IDictionary<Android.Views.View,System.String>);
			public FragmentNavigator.Extras Build ();
		}
	}
}
```

#### New Type: AndroidX.Navigation.Fragment.NavHostFragment

```csharp
public class NavHostFragment : AndroidX.Fragment.App.Fragment, Android.Content.IComponentCallbacks, Android.Runtime.IJavaObject, Android.Views.View.IOnCreateContextMenuListener, AndroidX.Lifecycle.ILifecycleOwner, AndroidX.Lifecycle.IViewModelStoreOwner, AndroidX.Navigation.INavHost, AndroidX.SavedState.ISavedStateRegistryOwner, System.IDisposable {
	// constructors
	public NavHostFragment ();
	protected NavHostFragment (IntPtr, Android.Runtime.JniHandleOwnership);
	// properties
	public AndroidX.Navigation.NavController NavController { get; }
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public static NavHostFragment Create (int);
	public static NavHostFragment Create (int, Android.OS.Bundle);

	[Obsolete ("deprecated")]
protected virtual AndroidX.Navigation.Navigator CreateFragmentNavigator ();
	public static AndroidX.Navigation.NavController FindNavController (AndroidX.Fragment.App.Fragment);
	protected virtual void OnCreateNavController (AndroidX.Navigation.NavController);
}
```

### New Namespace AndroidX.Navigation.UI

#### New Type: AndroidX.Navigation.UI.AppBarConfiguration

```csharp
public sealed class AppBarConfiguration : Java.Lang.Object {
	// properties
	public AndroidX.DrawerLayout.Widget.DrawerLayout DrawerLayout { get; }
	public AppBarConfiguration.IOnNavigateUpListener FallbackOnNavigateUpListener { get; }
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	public System.Collections.Generic.ICollection<Java.Lang.Integer> TopLevelDestinations { get; }

	// inner types
	public sealed class Builder : Java.Lang.Object {
		// constructors
		public AppBarConfiguration.Builder (Android.Views.IMenu);
		public AppBarConfiguration.Builder (AndroidX.Navigation.NavGraph);
		public AppBarConfiguration.Builder (System.Collections.Generic.ICollection<Java.Lang.Integer>);
		public AppBarConfiguration.Builder (int[]);
		// properties
		protected IntPtr ThresholdClass { get; }
		protected System.Type ThresholdType { get; }
		// methods
		public AppBarConfiguration Build ();
		public AppBarConfiguration.Builder SetDrawerLayout (AndroidX.DrawerLayout.Widget.DrawerLayout);
		public AppBarConfiguration.Builder SetFallbackOnNavigateUpListener (AppBarConfiguration.IOnNavigateUpListener);
	}
	public interface IOnNavigateUpListener : Android.Runtime.IJavaObject, System.IDisposable {
		// methods
		public virtual bool OnNavigateUp ();
	}
	public class NavigateUpEventArgs : System.EventArgs {
		// constructors
		public AppBarConfiguration.NavigateUpEventArgs (bool);
		// properties
		public bool Handled { get; set; }
	}
}
```

#### New Type: AndroidX.Navigation.UI.NavigationUI

```csharp
public sealed class NavigationUI : Java.Lang.Object {
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public static bool NavigateUp (AndroidX.Navigation.NavController, AndroidX.DrawerLayout.Widget.DrawerLayout);
	public static bool NavigateUp (AndroidX.Navigation.NavController, AppBarConfiguration);
	public static bool OnNavDestinationSelected (Android.Views.IMenuItem, AndroidX.Navigation.NavController);
	public static void SetupActionBarWithNavController (AndroidX.AppCompat.App.AppCompatActivity, AndroidX.Navigation.NavController);
	public static void SetupActionBarWithNavController (AndroidX.AppCompat.App.AppCompatActivity, AndroidX.Navigation.NavController, AndroidX.DrawerLayout.Widget.DrawerLayout);
	public static void SetupActionBarWithNavController (AndroidX.AppCompat.App.AppCompatActivity, AndroidX.Navigation.NavController, AppBarConfiguration);
	public static void SetupWithNavController (AndroidX.AppCompat.Widget.Toolbar, AndroidX.Navigation.NavController);
	public static void SetupWithNavController (Google.Android.Material.BottomNavigation.BottomNavigationView, AndroidX.Navigation.NavController);
	public static void SetupWithNavController (Google.Android.Material.Navigation.NavigationView, AndroidX.Navigation.NavController);
	public static void SetupWithNavController (AndroidX.AppCompat.Widget.Toolbar, AndroidX.Navigation.NavController, AndroidX.DrawerLayout.Widget.DrawerLayout);
	public static void SetupWithNavController (AndroidX.AppCompat.Widget.Toolbar, AndroidX.Navigation.NavController, AppBarConfiguration);
	public static void SetupWithNavController (Google.Android.Material.AppBar.CollapsingToolbarLayout, AndroidX.AppCompat.Widget.Toolbar, AndroidX.Navigation.NavController);
	public static void SetupWithNavController (Google.Android.Material.AppBar.CollapsingToolbarLayout, AndroidX.AppCompat.Widget.Toolbar, AndroidX.Navigation.NavController, AndroidX.DrawerLayout.Widget.DrawerLayout);
	public static void SetupWithNavController (Google.Android.Material.AppBar.CollapsingToolbarLayout, AndroidX.AppCompat.Widget.Toolbar, AndroidX.Navigation.NavController, AppBarConfiguration);
}
```

### New Namespace AndroidX.Paging

#### New Type: AndroidX.Paging.AsyncPagedListDiffer

```csharp
public class AsyncPagedListDiffer : Java.Lang.Object {
	// constructors
	public AsyncPagedListDiffer (AndroidX.RecyclerView.Widget.IListUpdateCallback, AndroidX.RecyclerView.Widget.AsyncDifferConfig);
	public AsyncPagedListDiffer (AndroidX.RecyclerView.Widget.RecyclerView.Adapter, AndroidX.RecyclerView.Widget.DiffUtil.ItemCallback);
	protected AsyncPagedListDiffer (IntPtr, Android.Runtime.JniHandleOwnership);
	// properties
	public PagedList CurrentList { get; }
	public int ItemCount { get; }
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public virtual void AddPagedListListener (AsyncPagedListDiffer.IPagedListListener);
	public virtual Java.Lang.Object GetItem (int);
	public virtual void RemovePagedListListener (AsyncPagedListDiffer.IPagedListListener);
	public virtual void SubmitList (PagedList);
	public virtual void SubmitList (PagedList, Java.Lang.IRunnable);

	// inner types
	public interface IPagedListListener : Android.Runtime.IJavaObject, System.IDisposable {
		// methods
		public virtual void OnCurrentListChanged (PagedList, PagedList);
	}
	public class PagedListEventArgs : System.EventArgs {
		// constructors
		public AsyncPagedListDiffer.PagedListEventArgs (PagedList, PagedList);
		// properties
		public PagedList P0 { get; }
		public PagedList P1 { get; }
	}
}
```

#### New Type: AndroidX.Paging.LivePagedListBuilder

```csharp
public sealed class LivePagedListBuilder : Java.Lang.Object {
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public AndroidX.Lifecycle.LiveData Build ();
	public LivePagedListBuilder SetBoundaryCallback (PagedList.BoundaryCallback);
	public LivePagedListBuilder SetFetchExecutor (Java.Util.Concurrent.IExecutor);
	public LivePagedListBuilder SetInitialLoadKey (Java.Lang.Object);
}
```

#### New Type: AndroidX.Paging.PagedList

```csharp
public abstract class PagedList : Java.Util.AbstractList {
	// constructors
	protected PagedList (IntPtr, Android.Runtime.JniHandleOwnership);
	// properties
	public bool IsDetached { get; }
	public bool IsImmutable { get; }
	public Java.Lang.Object LastKey { get; }
	public int LoadedCount { get; }
	public int PositionOffset { get; }
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public virtual void AddWeakCallback (System.Collections.IList, PagedList.Callback);
	public virtual void Detach ();
	public override Java.Lang.Object Get (int);
	public virtual PagedList.Config GetConfig ();
	public virtual void LoadAround (int);
	public virtual void RemoveWeakCallback (PagedList.Callback);
	public override int Size ();
	public virtual System.Collections.IList Snapshot ();

	// inner types
	public abstract class BoundaryCallback : Java.Lang.Object {
		// constructors
		public PagedList.BoundaryCallback ();
		protected PagedList.BoundaryCallback (IntPtr, Android.Runtime.JniHandleOwnership);
		// properties
		protected IntPtr ThresholdClass { get; }
		protected System.Type ThresholdType { get; }
		// methods
		public virtual void OnItemAtEndLoaded (Java.Lang.Object);
		public virtual void OnItemAtFrontLoaded (Java.Lang.Object);
		public virtual void OnZeroItemsLoaded ();
	}
	public sealed class Builder : Java.Lang.Object {
		// properties
		protected IntPtr ThresholdClass { get; }
		protected System.Type ThresholdType { get; }
		// methods
		public PagedList Build ();
		public PagedList.Builder SetBoundaryCallback (PagedList.BoundaryCallback);
		public PagedList.Builder SetFetchExecutor (Java.Util.Concurrent.IExecutor);
		public PagedList.Builder SetInitialKey (Java.Lang.Object);
		public PagedList.Builder SetNotifyExecutor (Java.Util.Concurrent.IExecutor);
	}
	public abstract class Callback : Java.Lang.Object {
		// constructors
		public PagedList.Callback ();
		protected PagedList.Callback (IntPtr, Android.Runtime.JniHandleOwnership);
		// properties
		protected IntPtr ThresholdClass { get; }
		protected System.Type ThresholdType { get; }
		// methods
		public virtual void OnChanged (int, int);
		public virtual void OnInserted (int, int);
		public virtual void OnRemoved (int, int);
	}
	public class Config : Java.Lang.Object {
		// constructors
		protected PagedList.Config (IntPtr, Android.Runtime.JniHandleOwnership);
		// fields
		public static const int MaxSizeUnbounded;
		// properties
		public bool EnablePlaceholders { get; set; }
		public int InitialLoadSizeHint { get; set; }
		public int MaxSize { get; set; }
		public int PageSize { get; set; }
		public int PrefetchDistance { get; set; }
		protected IntPtr ThresholdClass { get; }
		protected System.Type ThresholdType { get; }

		// inner types
		public sealed class Builder : Java.Lang.Object {
			// constructors
			public PagedList.Config.Builder ();
			// properties
			protected IntPtr ThresholdClass { get; }
			protected System.Type ThresholdType { get; }
			// methods
			public PagedList.Config Build ();
			public PagedList.Config.Builder SetEnablePlaceholders (bool);
			public PagedList.Config.Builder SetInitialLoadSizeHint (int);
			public PagedList.Config.Builder SetMaxSize (int);
			public PagedList.Config.Builder SetPageSize (int);
			public PagedList.Config.Builder SetPrefetchDistance (int);
		}
	}
}
```

#### New Type: AndroidX.Paging.PagedListAdapter

```csharp
public abstract class PagedListAdapter : AndroidX.RecyclerView.Widget.RecyclerView+Adapter {
	// constructors
	protected PagedListAdapter (AndroidX.RecyclerView.Widget.AsyncDifferConfig);
	protected PagedListAdapter (AndroidX.RecyclerView.Widget.DiffUtil.ItemCallback);
	protected PagedListAdapter (IntPtr, Android.Runtime.JniHandleOwnership);
	// properties
	public PagedList CurrentList { get; }
	public int ItemCount { get; }
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	protected virtual Java.Lang.Object GetItem (int);

	[Obsolete ("deprecated")]
public virtual void OnCurrentListChanged (PagedList);
	public virtual void OnCurrentListChanged (PagedList, PagedList);
	public virtual void SubmitList (PagedList);
	public virtual void SubmitList (PagedList, Java.Lang.IRunnable);
}
```

### New Namespace AndroidX.Room.Guava

#### New Type: AndroidX.Room.Guava.GuavaRoom

```csharp
public class GuavaRoom : Java.Lang.Object {
	// constructors
	protected GuavaRoom (IntPtr, Android.Runtime.JniHandleOwnership);
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods

	[Obsolete ("deprecated")]
public static Google.Common.Util.Concurrent.IListenableFuture CreateListenableFuture (AndroidX.Room.RoomDatabase, Java.Util.Concurrent.ICallable);
	public static Google.Common.Util.Concurrent.IListenableFuture CreateListenableFuture (AndroidX.Room.RoomDatabase, bool, Java.Util.Concurrent.ICallable);

	[Obsolete ("deprecated")]
public static Google.Common.Util.Concurrent.IListenableFuture CreateListenableFuture (Java.Util.Concurrent.ICallable, AndroidX.Room.RoomSQLiteQuery, bool);

	[Obsolete ("deprecated")]
public static Google.Common.Util.Concurrent.IListenableFuture CreateListenableFuture (AndroidX.Room.RoomDatabase, Java.Util.Concurrent.ICallable, AndroidX.Room.RoomSQLiteQuery, bool);
	public static Google.Common.Util.Concurrent.IListenableFuture CreateListenableFuture (AndroidX.Room.RoomDatabase, bool, Java.Util.Concurrent.ICallable, AndroidX.Room.RoomSQLiteQuery, bool);
	public static Google.Common.Util.Concurrent.IListenableFuture CreateListenableFuture (AndroidX.Room.RoomDatabase, bool, Java.Util.Concurrent.ICallable, AndroidX.Room.RoomSQLiteQuery, bool, Android.OS.CancellationSignal);
}
```

### New Namespace AndroidX.SavedState

#### New Type: AndroidX.SavedState.ISavedStateRegistryOwner

```csharp
public interface ISavedStateRegistryOwner : Android.Runtime.IJavaObject, AndroidX.Lifecycle.ILifecycleOwner, System.IDisposable {
	// properties
	public SavedStateRegistry SavedStateRegistry { get; }
}
```

#### New Type: AndroidX.SavedState.SavedStateRegistry

```csharp
public sealed class SavedStateRegistry : Java.Lang.Object {
	// properties
	public bool IsRestored { get; }
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public Android.OS.Bundle ConsumeRestoredStateForKey (string);
	public void RegisterSavedStateProvider (string, SavedStateRegistry.ISavedStateProvider);
	public void RunOnNextRecreation (Java.Lang.Class);
	public void UnregisterSavedStateProvider (string);

	// inner types
	public interface IAutoRecreated : Android.Runtime.IJavaObject, System.IDisposable {
		// methods
		public virtual void OnRecreated (ISavedStateRegistryOwner);
	}
	public interface ISavedStateProvider : Android.Runtime.IJavaObject, System.IDisposable {
		// methods
		public virtual Android.OS.Bundle SaveState ();
	}
}
```

#### New Type: AndroidX.SavedState.SavedStateRegistryController

```csharp
public sealed class SavedStateRegistryController : Java.Lang.Object {
	// properties
	public SavedStateRegistry SavedStateRegistry { get; }
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public static SavedStateRegistryController Create (ISavedStateRegistryOwner);
	public void PerformRestore (Android.OS.Bundle);
	public void PerformSave (Android.OS.Bundle);
}
```

### New Namespace AndroidX.ViewPager2.Adapter

#### New Type: AndroidX.ViewPager2.Adapter.FragmentStateAdapter

```csharp
public abstract class FragmentStateAdapter : AndroidX.RecyclerView.Widget.RecyclerView+Adapter, Android.Runtime.IJavaObject, IStatefulAdapter, System.IDisposable {
	// constructors
	public FragmentStateAdapter (AndroidX.Fragment.App.Fragment);
	public FragmentStateAdapter (AndroidX.Fragment.App.FragmentActivity);
	public FragmentStateAdapter (AndroidX.Fragment.App.FragmentManager, AndroidX.Lifecycle.Lifecycle);
	protected FragmentStateAdapter (IntPtr, Android.Runtime.JniHandleOwnership);
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public virtual bool ContainsItem (long);
	public virtual AndroidX.Fragment.App.Fragment CreateFragment (int);
	public void OnBindViewHolder (FragmentViewHolder, int);
	public override AndroidX.RecyclerView.Widget.RecyclerView.ViewHolder OnCreateViewHolder (Android.Views.ViewGroup, int);
	public bool OnFailedToRecycleView (FragmentViewHolder);
	public void OnViewAttachedToWindow (FragmentViewHolder);
	public void OnViewRecycled (FragmentViewHolder);
	public virtual void RestoreState (Android.OS.IParcelable);
	public virtual Android.OS.IParcelable SaveState ();
	public override void SetHasStableIds (bool);

	// inner types
	public class FragmentMaxLifecycleEnforcer : Java.Lang.Object {
		// constructors
		protected FragmentStateAdapter.FragmentMaxLifecycleEnforcer (IntPtr, Android.Runtime.JniHandleOwnership);
		// properties
		protected IntPtr ThresholdClass { get; }
		protected System.Type ThresholdType { get; }
	}
}
```

#### New Type: AndroidX.ViewPager2.Adapter.FragmentViewHolder

```csharp
public sealed class FragmentViewHolder : AndroidX.RecyclerView.Widget.RecyclerView+ViewHolder {
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
}
```

#### New Type: AndroidX.ViewPager2.Adapter.IStatefulAdapter

```csharp
public interface IStatefulAdapter : Android.Runtime.IJavaObject, System.IDisposable {
	// methods
	public virtual void RestoreState (Android.OS.IParcelable);
	public virtual Android.OS.IParcelable SaveState ();
}
```

### New Namespace AndroidX.ViewPager2.Widget

#### New Type: AndroidX.ViewPager2.Widget.CompositePageTransformer

```csharp
public sealed class CompositePageTransformer : Java.Lang.Object, Android.Runtime.IJavaObject, ViewPager2.IPageTransformer, System.IDisposable {
	// constructors
	public CompositePageTransformer ();
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public void AddTransformer (ViewPager2.IPageTransformer);
	public void RemoveTransformer (ViewPager2.IPageTransformer);
	public virtual void TransformPage (Android.Views.View, float);
}
```

#### New Type: AndroidX.ViewPager2.Widget.MarginPageTransformer

```csharp
public sealed class MarginPageTransformer : Java.Lang.Object, Android.Runtime.IJavaObject, ViewPager2.IPageTransformer, System.IDisposable {
	// constructors
	public MarginPageTransformer (int);
	// properties
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	// methods
	public virtual void TransformPage (Android.Views.View, float);
}
```

#### New Type: AndroidX.ViewPager2.Widget.ViewPager2

```csharp
public sealed class ViewPager2 : Android.Views.ViewGroup {
	// constructors
	public ViewPager2 (Android.Content.Context);
	public ViewPager2 (Android.Content.Context, Android.Util.IAttributeSet);
	public ViewPager2 (Android.Content.Context, Android.Util.IAttributeSet, int);
	public ViewPager2 (Android.Content.Context, Android.Util.IAttributeSet, int, int);
	// fields
	public static const int OffscreenPageLimitDefault;
	public static const int OrientationHorizontal;
	public static const int OrientationVertical;
	public static const int ScrollStateDragging;
	public static const int ScrollStateIdle;
	public static const int ScrollStateSettling;
	// properties
	public AndroidX.RecyclerView.Widget.RecyclerView.Adapter Adapter { get; set; }
	public int CurrentItem { get; set; }
	public bool IsFakeDragging { get; }
	public int ItemDecorationCount { get; }
	public int OffscreenPageLimit { get; set; }
	public int Orientation { get; set; }
	public int ScrollState { get; }
	protected IntPtr ThresholdClass { get; }
	protected System.Type ThresholdType { get; }
	public bool UserInputEnabled { get; set; }
	// methods
	public void AddItemDecoration (AndroidX.RecyclerView.Widget.RecyclerView.ItemDecoration);
	public void AddItemDecoration (AndroidX.RecyclerView.Widget.RecyclerView.ItemDecoration, int);
	public bool BeginFakeDrag ();
	protected override void DispatchRestoreInstanceState (Android.Util.SparseArray);
	public bool EndFakeDrag ();
	public bool FakeDragBy (float);
	public AndroidX.RecyclerView.Widget.RecyclerView.ItemDecoration GetItemDecorationAt (int);
	public void InvalidateItemDecorations ();
	protected override void OnLayout (bool, int, int, int, int);
	public void RegisterOnPageChangeCallback (ViewPager2.OnPageChangeCallback);
	public void RemoveItemDecoration (AndroidX.RecyclerView.Widget.RecyclerView.ItemDecoration);
	public void RemoveItemDecorationAt (int);
	public void RequestTransform ();
	public void SetCurrentItem (int, bool);
	public void SetPageTransformer (ViewPager2.IPageTransformer);
	public void UnregisterOnPageChangeCallback (ViewPager2.OnPageChangeCallback);

	// inner types
	public interface IOffscreenPageLimit : Android.Runtime.IJavaObject, Java.Lang.Annotation.IAnnotation, System.IDisposable {
	}
	public interface IOrientation : Android.Runtime.IJavaObject, Java.Lang.Annotation.IAnnotation, System.IDisposable {
	}
	public interface IPageTransformer : Android.Runtime.IJavaObject, System.IDisposable {
		// methods
		public virtual void TransformPage (Android.Views.View, float);
	}
	public interface IScrollState : Android.Runtime.IJavaObject, Java.Lang.Annotation.IAnnotation, System.IDisposable {
	}
	public abstract class OnPageChangeCallback : Java.Lang.Object {
		// constructors
		public ViewPager2.OnPageChangeCallback ();
		protected ViewPager2.OnPageChangeCallback (IntPtr, Android.Runtime.JniHandleOwnership);
		// properties
		protected IntPtr ThresholdClass { get; }
		protected System.Type ThresholdType { get; }
		// methods
		public virtual void OnPageScrollStateChanged (int);
		public virtual void OnPageScrolled (int, float, int);
		public virtual void OnPageSelected (int);
	}
	public class SavedState : Android.Views.View+BaseSavedState {
		// constructors
		protected ViewPager2.SavedState (IntPtr, Android.Runtime.JniHandleOwnership);
		// properties
		public static Android.OS.IParcelableCreator Creator { get; }
		protected IntPtr ThresholdClass { get; }
		protected System.Type ThresholdType { get; }
	}
}
```

### New Namespace Google.Common.Util.Concurrent

#### New Type: Google.Common.Util.Concurrent.IListenableFuture

```csharp
public interface IListenableFuture : Android.Runtime.IJavaObject, Java.Util.Concurrent.IFuture, System.IDisposable {
	// methods
	public virtual void AddListener (Java.Lang.IRunnable, Java.Util.Concurrent.IExecutor);
}
```

