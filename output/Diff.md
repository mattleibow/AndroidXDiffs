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
public virtual void OnStateChanged (ILifecycleOwner p0, Lifecycle.Event p1);
```


#### Type Changed: AndroidX.Lifecycle.LifecycleRegistry

Obsoleted methods:

```diff
 [Obsolete ("deprecated")]
 public virtual void MarkState (Lifecycle.State state);
```

Added method:

```csharp
public virtual void SetCurrentState (Lifecycle.State state);
```


#### Type Changed: AndroidX.Lifecycle.Lifecycling

Removed constructor:

```csharp
public Lifecycling ();
```


#### Type Changed: AndroidX.Lifecycle.LiveData

Added constructor:

```csharp
public LiveData (Java.Lang.Object value);
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
public MutableLiveData (Java.Lang.Object value);
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

Modified methods:

```diff
-public LiveData Map (LiveData source, AndroidX.Arch.Core.Util.IFunction func)
+public LiveData Map (LiveData source, AndroidX.Arch.Core.Util.IFunction mapFunction)
-public LiveData SwitchMap (LiveData trigger, AndroidX.Arch.Core.Util.IFunction func---switchMapFunction---)
+public LiveData SwitchMap (LiveData source, AndroidX.Arch.Core.Util.IFunction +++func+++switchMapFunction)
```

Added method:

```csharp
public static LiveData DistinctUntilChanged (LiveData source);
```


#### Type Changed: AndroidX.Lifecycle.ViewModelProvider

#### New Type: AndroidX.Lifecycle.ViewModelProvider.KeyedFactory

```csharp
public abstract class KeyedFactory : Java.Lang.Object, Android.Runtime.IJavaObject, ViewModelProvider.IFactory, System.IDisposable {
	// constructors
	protected ViewModelProvider.KeyedFactory (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
	// properties
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public virtual Java.Lang.Object Create (Java.Lang.Class modelClass);
	public virtual Java.Lang.Object Create (string p0, Java.Lang.Class p1);
}
```


#### Type Changed: AndroidX.Lifecycle.ViewModelStores

Obsoleted methods:

```diff
 [Obsolete ("deprecated")]
 public static ViewModelStore Of (AndroidX.Fragment.App.Fragment fragment);
 [Obsolete ("deprecated")]
 public static ViewModelStore Of (AndroidX.Fragment.App.FragmentActivity activity);
```


#### New Type: AndroidX.Lifecycle.ILifecycleEventObserver

```csharp
public interface ILifecycleEventObserver : Android.Runtime.IJavaObject, ILifecycleObserver, System.IDisposable {
	// methods
	public virtual void OnStateChanged (ILifecycleOwner p0, Lifecycle.Event p1);
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
public DatabaseConfiguration (Android.Content.Context context, string name, AndroidX.Sqlite.Db.ISupportSQLiteOpenHelperFactory sqliteOpenHelperFactory, RoomDatabase.MigrationContainer migrationContainer, System.Collections.Generic.IList<Android.Arch.Persistence.Room.RoomDatabase.Callback> callbacks, bool allowMainThreadQueries, RoomDatabase.JournalMode journalMode, bool requireMigration, System.Collections.Generic.ICollection<Java.Lang.Integer> migrationNotRequiredFrom);
```

Added constructors:

```csharp

[Obsolete ("deprecated")]
public DatabaseConfiguration (Android.Content.Context context, string name, AndroidX.Sqlite.Db.ISupportSQLiteOpenHelperFactory sqliteOpenHelperFactory, RoomDatabase.MigrationContainer migrationContainer, System.Collections.Generic.IList<RoomDatabase.Callback> callbacks, bool allowMainThreadQueries, RoomDatabase.JournalMode journalMode, Java.Util.Concurrent.IExecutor queryExecutor, bool requireMigration, System.Collections.Generic.ICollection<Java.Lang.Integer> migrationNotRequiredFrom);

[Obsolete ("deprecated")]
public DatabaseConfiguration (Android.Content.Context context, string name, AndroidX.Sqlite.Db.ISupportSQLiteOpenHelperFactory sqliteOpenHelperFactory, RoomDatabase.MigrationContainer migrationContainer, System.Collections.Generic.IList<RoomDatabase.Callback> callbacks, bool allowMainThreadQueries, RoomDatabase.JournalMode journalMode, Java.Util.Concurrent.IExecutor queryExecutor, Java.Util.Concurrent.IExecutor transactionExecutor, bool multiInstanceInvalidation, bool requireMigration, bool allowDestructiveMigrationOnDowngrade, System.Collections.Generic.ICollection<Java.Lang.Integer> migrationNotRequiredFrom);
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
 public virtual bool IsMigrationRequiredFrom (int version);
```

Added method:

```csharp
public virtual bool IsMigrationRequired (int fromVersion, int toVersion);
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
public InvalidationTracker (RoomDatabase database, System.Collections.Generic.IDictionary<System.String,System.String> shadowTablesMap, System.Collections.Generic.IDictionary<System.String,System.Collections.Generic.ICollection<string>> viewTables, string[] tableNames);
```

Added method:

```csharp
public virtual void NotifyObserversByTableNames (string[] tables);
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
public virtual Java.Util.Concurrent.IExecutor QueryExecutor { get; }
public virtual Java.Util.Concurrent.IExecutor TransactionExecutor { get; }
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
public virtual Android.Database.ICursor Query (AndroidX.Sqlite.Db.ISupportSQLiteQuery query, Android.OS.CancellationSignal signal);
```

#### Type Changed: AndroidX.Room.RoomDatabase.Builder

Added methods:

```csharp
public virtual RoomDatabase.Builder CreateFromAsset (string databaseFilePath);
public virtual RoomDatabase.Builder CreateFromFile (Java.IO.File databaseFile);
public virtual RoomDatabase.Builder EnableMultiInstanceInvalidation ();
public virtual RoomDatabase.Builder FallbackToDestructiveMigrationOnDowngrade ();
public virtual RoomDatabase.Builder SetQueryExecutor (Java.Util.Concurrent.IExecutor executor);
public virtual RoomDatabase.Builder SetTransactionExecutor (Java.Util.Concurrent.IExecutor executor);
```


#### Type Changed: AndroidX.Room.RoomDatabase.Callback

Added method:

```csharp
public virtual void OnDestructiveMigration (AndroidX.Sqlite.Db.ISupportSQLiteDatabase db);
```


#### Type Changed: AndroidX.Room.RoomDatabase.MigrationContainer

Removed method:

```csharp
public virtual System.Collections.Generic.IList<Android.Arch.Persistence.Room.Migration.Migration> FindMigrationPath (int start, int end);
```

Added method:

```csharp
public virtual System.Collections.Generic.IList<Migration.Migration> FindMigrationPath (int start, int end);
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
 protected virtual void ValidateMigration (AndroidX.Sqlite.Db.ISupportSQLiteDatabase db);
```

Modified methods:

```diff
-protected abstract void ValidateMigration (AndroidX.Sqlite.Db.ISupportSQLiteDatabase p0---db---)
+protected virtual void ValidateMigration (AndroidX.Sqlite.Db.ISupportSQLiteDatabase +++p0+++db)
```

Added methods:

```csharp
protected virtual void OnPostMigrate (AndroidX.Sqlite.Db.ISupportSQLiteDatabase database);
protected virtual void OnPreMigrate (AndroidX.Sqlite.Db.ISupportSQLiteDatabase database);
protected virtual RoomOpenHelper.ValidationResult OnValidateSchema (AndroidX.Sqlite.Db.ISupportSQLiteDatabase db);
```


#### New Type: AndroidX.Room.RoomOpenHelper.ValidationResult

```csharp
public class ValidationResult : Java.Lang.Object {
	// constructors
	public RoomOpenHelper.ValidationResult (bool isValid, string expectedFoundMsg);
	protected RoomOpenHelper.ValidationResult (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
	// properties
	public string ExpectedFoundMsg { get; set; }
	public bool IsValid { get; set; }
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
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
	protected FtsOptions (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
	// fields
	public static const string TokenizerIcu = "icu";
	public static const string TokenizerPorter = "porter";
	public static const string TokenizerSimple = "simple";
	public static const string TokenizerUnicode61 = "unicode61";
	// properties
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }

	// inner types
	public sealed class MatchInfo : Java.Lang.Enum {
		// properties
		public static FtsOptions.MatchInfo Fts3 { get; }
		public static FtsOptions.MatchInfo Fts4 { get; }
		protected override IntPtr ThresholdClass { get; }
		protected override System.Type ThresholdType { get; }
		// methods
		public static FtsOptions.MatchInfo ValueOf (string name);
		public static FtsOptions.MatchInfo[] Values ();
	}
	public sealed class Order : Java.Lang.Enum {
		// properties
		public static FtsOptions.Order Asc { get; }
		public static FtsOptions.Order Desc { get; }
		protected override IntPtr ThresholdClass { get; }
		protected override System.Type ThresholdType { get; }
		// methods
		public static FtsOptions.Order ValueOf (string name);
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
	public virtual void OnInvalidation (string[] p0);
}
```

#### New Type: AndroidX.Room.IMultiInstanceInvalidationService

```csharp
public interface IMultiInstanceInvalidationService : Android.OS.IInterface, Android.Runtime.IJavaObject, System.IDisposable {
	// methods
	public virtual void BroadcastInvalidation (int p0, string[] p1);
	public virtual int RegisterCallback (IMultiInstanceInvalidationCallback p0, string p1);
	public virtual void UnregisterCallback (IMultiInstanceInvalidationCallback p0, int p1);
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
	protected MultiInstanceInvalidationCallbackStub (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
	// properties
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public virtual Android.OS.IBinder AsBinder ();
	public static IMultiInstanceInvalidationCallback AsInterface (Android.OS.IBinder obj);
	public virtual void OnInvalidation (string[] p0);
	public virtual bool OnTransact (int code, Android.OS.Parcel data, Android.OS.Parcel reply, int flags);
}
```

#### New Type: AndroidX.Room.MultiInstanceInvalidationService

```csharp
public class MultiInstanceInvalidationService : Android.App.Service {
	// constructors
	public MultiInstanceInvalidationService ();
	protected MultiInstanceInvalidationService (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
	// properties
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public override Android.OS.IBinder OnBind (Android.Content.Intent intent);
}
```

#### New Type: AndroidX.Room.MultiInstanceInvalidationServiceStub

```csharp
public abstract class MultiInstanceInvalidationServiceStub : Android.OS.Binder, Android.OS.IInterface, Android.Runtime.IJavaObject, IMultiInstanceInvalidationService, System.IDisposable {
	// constructors
	public MultiInstanceInvalidationServiceStub ();
	protected MultiInstanceInvalidationServiceStub (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
	// properties
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public virtual Android.OS.IBinder AsBinder ();
	public static IMultiInstanceInvalidationService AsInterface (Android.OS.IBinder obj);
	public virtual void BroadcastInvalidation (int p0, string[] p1);
	public virtual bool OnTransact (int code, Android.OS.Parcel data, Android.OS.Parcel reply, int flags);
	public virtual int RegisterCallback (IMultiInstanceInvalidationCallback p0, string p1);
	public virtual void UnregisterCallback (IMultiInstanceInvalidationCallback p0, int p1);
}
```


### Namespace AndroidX.Room.Util

#### Type Changed: AndroidX.Room.Util.StringUtil

Removed constructor:

```csharp
public StringUtil ();
```


#### Type Changed: AndroidX.Room.Util.TableInfo

Removed constructors:

```csharp
public TableInfo (string name, System.Collections.Generic.IDictionary<System.String,Android.Arch.Persistence.Room.Util.TableInfo.Column> columns, System.Collections.Generic.ICollection<Android.Arch.Persistence.Room.Util.TableInfo.ForeignKey> foreignKeys);
public TableInfo (string name, System.Collections.Generic.IDictionary<System.String,Android.Arch.Persistence.Room.Util.TableInfo.Column> columns, System.Collections.Generic.ICollection<Android.Arch.Persistence.Room.Util.TableInfo.ForeignKey> foreignKeys, System.Collections.Generic.ICollection<Android.Arch.Persistence.Room.Util.TableInfo.Index> indices);
```

Added constructors:

```csharp
public TableInfo (string name, System.Collections.Generic.IDictionary<System.String,AndroidX.Room.Util.TableInfo.Column> columns, System.Collections.Generic.ICollection<TableInfo.ForeignKey> foreignKeys);
public TableInfo (string name, System.Collections.Generic.IDictionary<System.String,AndroidX.Room.Util.TableInfo.Column> columns, System.Collections.Generic.ICollection<TableInfo.ForeignKey> foreignKeys, System.Collections.Generic.ICollection<TableInfo.Index> indices);
```

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
 public TableInfo.Column (string name, string type, bool notNull, int primaryKeyPosition);
```

Added constructor:

```csharp
public TableInfo.Column (string name, string type, bool notNull, int primaryKeyPosition, string defaultValue, int createdFrom);
```

Added property:

```csharp
public string DefaultValue { get; set; }
```



#### New Type: AndroidX.Room.Util.CopyLock

```csharp
public class CopyLock : Java.Lang.Object {
	// constructors
	protected CopyLock (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
	public CopyLock (string name, Java.IO.File lockDir, bool processLock);
	// properties
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public virtual void Lock ();
	public virtual void Unlock ();
}
```

#### New Type: AndroidX.Room.Util.CursorUtil

```csharp
public class CursorUtil : Java.Lang.Object {
	// constructors
	protected CursorUtil (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
	// properties
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public static Android.Database.ICursor CopyAndClose (Android.Database.ICursor c);
	public static int GetColumnIndex (Android.Database.ICursor c, string name);
	public static int GetColumnIndexOrThrow (Android.Database.ICursor c, string name);
}
```

#### New Type: AndroidX.Room.Util.DBUtil

```csharp
public class DBUtil : Java.Lang.Object {
	// constructors
	protected DBUtil (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
	// properties
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public static Android.OS.CancellationSignal CreateCancellationSignal ();
	public static void DropFtsSyncTriggers (AndroidX.Sqlite.Db.ISupportSQLiteDatabase db);

	[Obsolete ("deprecated")]
public static Android.Database.ICursor Query (AndroidX.Room.RoomDatabase db, AndroidX.Sqlite.Db.ISupportSQLiteQuery sqLiteQuery, bool maybeCopy);
	public static Android.Database.ICursor Query (AndroidX.Room.RoomDatabase db, AndroidX.Sqlite.Db.ISupportSQLiteQuery sqLiteQuery, bool maybeCopy, Android.OS.CancellationSignal signal);
	public static int ReadVersion (Java.IO.File databaseFile);
}
```

#### New Type: AndroidX.Room.Util.FileUtil

```csharp
public class FileUtil : Java.Lang.Object {
	// constructors
	protected FileUtil (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
	// properties
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public static void Copy (Java.Nio.Channels.IReadableByteChannel input, Java.Nio.Channels.FileChannel output);
}
```

#### New Type: AndroidX.Room.Util.FtsTableInfo

```csharp
public class FtsTableInfo : Java.Lang.Object {
	// constructors
	protected FtsTableInfo (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
	public FtsTableInfo (string name, System.Collections.Generic.ICollection<string> columns, System.Collections.Generic.ICollection<string> options);
	public FtsTableInfo (string name, System.Collections.Generic.ICollection<string> columns, string createSql);
	// properties
	public System.Collections.ICollection Columns { get; set; }
	public string Name { get; set; }
	public System.Collections.ICollection Options { get; set; }
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public static FtsTableInfo Read (AndroidX.Sqlite.Db.ISupportSQLiteDatabase database, string tableName);
}
```

#### New Type: AndroidX.Room.Util.SneakyThrow

```csharp
public class SneakyThrow : Java.Lang.Object {
	// constructors
	protected SneakyThrow (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
	// properties
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public static void ReThrow (Java.Lang.Exception e);
}
```

#### New Type: AndroidX.Room.Util.ViewInfo

```csharp
public class ViewInfo : Java.Lang.Object {
	// constructors
	protected ViewInfo (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
	public ViewInfo (string name, string sql);
	// properties
	public string Name { get; set; }
	public string Sql { get; set; }
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public static ViewInfo Read (AndroidX.Sqlite.Db.ISupportSQLiteDatabase database, string viewName);
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
	public virtual bool HasAttributeId { get; }
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
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public static InspectablePropertyValueType ValueOf (string name);
	public static InspectablePropertyValueType[] Values ();
}
```


### Namespace AndroidX.ConstraintLayout.Widget

#### Type Changed: AndroidX.ConstraintLayout.Widget.Barrier

Added methods:

```csharp
public virtual bool AllowsGoneWidget ();
public virtual void SetAllowsGoneWidget (bool supportGone);
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
public virtual Java.Lang.Object GetParameters (int mId);
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

Modified properties:

```diff
-public virtual System.Collections.Generic.IList<Android.Support.Constraints.Solver.Widgets.ConstraintAnchor> Anchors { get; }
+public virtual System.Collections.Generic.IList<ConstraintAnchor> Anchors { get; }
-protected System.Collections.Generic.IList<Android.Support.Constraints.Solver.Widgets.ConstraintAnchor> MListAnchors { get; set; }
+protected System.Collections.Generic.IList<ConstraintAnchor> MListAnchors { get; set; }
-protected System.Collections.Generic.IList<Android.Support.Constraints.Solver.Widgets.ConstraintWidget.DimensionBehaviour> MListDimensionBehaviors { get; set; }
+protected System.Collections.Generic.IList<ConstraintWidget.DimensionBehaviour> MListDimensionBehaviors { get; set; }
-protected System.Collections.Generic.IList<Android.Support.Constraints.Solver.Widgets.ConstraintWidget> MListNextMatchConstraintsWidget { get; set; }
+protected System.Collections.Generic.IList<ConstraintWidget> MListNextMatchConstraintsWidget { get; set; }
-protected System.Collections.Generic.IList<Android.Support.Constraints.Solver.Widgets.ConstraintWidget> MListNextVisibleWidget { get; set; }
+protected System.Collections.Generic.IList<ConstraintWidget> MListNextVisibleWidget { get; set; }
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
public virtual void CreateObjectVariables (AndroidX.ConstraintLayout.Solver.LinearSystem system);
public virtual float GetBiasPercent (int orientation);
public virtual ConstraintWidget.DimensionBehaviour GetDimensionBehaviour (int orientation);
public virtual int GetLength (int orientation);
public virtual void SetFrame (int start, int end, int orientation);
public virtual void SetLength (int length, int orientation);
```


#### Type Changed: AndroidX.ConstraintLayout.Solver.Widgets.ConstraintWidgetContainer

Modified properties:

```diff
-public virtual System.Collections.Generic.IList<Android.Support.Constraints.Solver.Widgets.Guideline> HorizontalGuidelines { get; }
+public virtual System.Collections.Generic.IList<Guideline> HorizontalGuidelines { get; }
-public virtual System.Collections.Generic.IList<Android.Support.Constraints.Solver.Widgets.Guideline> VerticalGuidelines { get; }
+public virtual System.Collections.Generic.IList<Guideline> VerticalGuidelines { get; }
```

Added properties:

```csharp
public bool MGroupsWrapOptimized { get; set; }
public bool MHorizontalWrapOptimized { get; set; }
public bool MSkipSolver { get; set; }
public bool MVerticalWrapOptimized { get; set; }
public System.Collections.IList MWidgetGroups { get; set; }
public int MWrapFixedHeight { get; set; }
public int MWrapFixedWidth { get; set; }
public virtual System.Collections.Generic.IList<ConstraintWidgetGroup> WidgetGroups { get; }
```


#### Type Changed: AndroidX.ConstraintLayout.Solver.Widgets.Helper

Modified properties:

```diff
-protected System.Collections.Generic.IList<Android.Support.Constraints.Solver.Widgets.ConstraintWidget> MWidgets { get; set; }
+protected System.Collections.Generic.IList<ConstraintWidget> MWidgets { get; set; }
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

Modified properties:

```diff
-public virtual System.Collections.Generic.IList<Android.Support.Constraints.Solver.Widgets.ConstraintWidget> Children { get; }
+public virtual System.Collections.Generic.IList<ConstraintWidget> Children { get; }
```

Removed methods:

```csharp
public virtual System.Collections.Generic.IList<Android.Support.Constraints.Solver.Widgets.ConstraintWidget> FindWidgets (int x, int y, int width, int height);
public static Rectangle GetBounds (System.Collections.Generic.IList<Android.Support.Constraints.Solver.Widgets.ConstraintWidget> widgets);
```

Added methods:

```csharp
public virtual void Add (ConstraintWidget[] widgets);
public virtual System.Collections.Generic.IList<ConstraintWidget> FindWidgets (int x, int y, int width, int height);
public static Rectangle GetBounds (System.Collections.Generic.IList<ConstraintWidget> widgets);
```


#### New Type: AndroidX.ConstraintLayout.Solver.Widgets.Analyzer

```csharp
public class Analyzer : Java.Lang.Object {
	// constructors
	protected Analyzer (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
	// properties
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public static void DetermineGroups (ConstraintWidgetContainer layoutWidget);
	public static void SetPosition (System.Collections.Generic.IList<ConstraintWidgetGroup> groups, int orientation, int containerLength);
}
```

#### New Type: AndroidX.ConstraintLayout.Solver.Widgets.ChainHead

```csharp
public class ChainHead : Java.Lang.Object {
	// constructors
	protected ChainHead (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
	public ChainHead (ConstraintWidget first, int orientation, bool isRtl);
	// properties
	public virtual ConstraintWidget First { get; }
	public virtual ConstraintWidget FirstMatchConstraintWidget { get; }
	public virtual ConstraintWidget FirstVisibleWidget { get; }
	public virtual ConstraintWidget Head { get; }
	public virtual ConstraintWidget Last { get; }
	public virtual ConstraintWidget LastMatchConstraintWidget { get; }
	public virtual ConstraintWidget LastVisibleWidget { get; }
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
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	public virtual float TotalWeight { get; }
	// methods
	public virtual void Define ();
}
```

#### New Type: AndroidX.ConstraintLayout.Solver.Widgets.ConstraintWidgetGroup

```csharp
public class ConstraintWidgetGroup : Java.Lang.Object {
	// constructors
	protected ConstraintWidgetGroup (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
	// properties
	public System.Collections.IList MConstrainedGroup { get; set; }
	public System.Collections.Generic.IList<int> MGroupDimensions { get; set; }
	public bool MSkipSolver { get; set; }
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public virtual System.Collections.Generic.IList<ConstraintWidget> GetStartWidgets (int orientation);
}
```


### Namespace Google.Android.Material.Animation

#### Type Changed: Google.Android.Material.Animation.ChildrenAlphaProperty

Added methods:

```csharp
public virtual Java.Lang.Float Get (Android.Views.ViewGroup object);
public override void Set (Java.Lang.Object object, Java.Lang.Object value);
```


#### Type Changed: Google.Android.Material.Animation.DrawableAlphaProperty

Added methods:

```csharp
public virtual Java.Lang.Integer Get (Android.Graphics.Drawables.Drawable object);
public override void Set (Java.Lang.Object object, Java.Lang.Object value);
```


#### Type Changed: Google.Android.Material.Animation.ImageMatrixProperty

Added methods:

```csharp
public virtual Android.Graphics.Matrix Get (Android.Widget.ImageView object);
public override void Set (Java.Lang.Object object, Java.Lang.Object value);
```



### Namespace Google.Android.Material.Behavior

#### Type Changed: Google.Android.Material.Behavior.SwipeDismissBehavior

Modified methods:

```diff
-public virtual bool OnInterceptTouchEvent (AndroidX.CoordinatorLayout.Widget.CoordinatorLayout parent, Java.Lang.Object child, Android.Views.MotionEvent event_)
+public virtual bool OnInterceptTouchEvent (AndroidX.CoordinatorLayout.Widget.CoordinatorLayout parent, Java.Lang.Object child, Android.Views.MotionEvent e)
-public virtual bool OnTouchEvent (AndroidX.CoordinatorLayout.Widget.CoordinatorLayout parent, Java.Lang.Object child, Android.Views.MotionEvent event_)
+public virtual bool OnTouchEvent (AndroidX.CoordinatorLayout.Widget.CoordinatorLayout parent, Java.Lang.Object child, Android.Views.MotionEvent e)
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
public virtual void ActualDraw (Android.Graphics.Canvas p0);
public virtual bool ActualIsOpaque ();
```


#### New Type: Google.Android.Material.CircularReveal.CircularRevealWidgetCircularRevealProperty

```csharp
public class CircularRevealWidgetCircularRevealProperty : Android.Util.Property {
	// constructors
	protected CircularRevealWidgetCircularRevealProperty (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
	// properties
	public static Android.Util.Property CircularReveal { get; }
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public virtual CircularRevealWidgetRevealInfo Get (ICircularRevealWidget object);
	public override Java.Lang.Object Get (Java.Lang.Object object);
	public virtual void Set (ICircularRevealWidget object, CircularRevealWidgetRevealInfo value);
	public override void Set (Java.Lang.Object object, Java.Lang.Object value);
}
```

#### New Type: Google.Android.Material.CircularReveal.CircularRevealWidgetCircularRevealScrimColorProperty

```csharp
public class CircularRevealWidgetCircularRevealScrimColorProperty : Android.Util.Property {
	// constructors
	protected CircularRevealWidgetCircularRevealScrimColorProperty (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
	// properties
	public static Android.Util.Property CircularRevealScrimColor { get; }
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public virtual Java.Lang.Integer Get (ICircularRevealWidget object);
	public override Java.Lang.Object Get (Java.Lang.Object object);
	public virtual void Set (ICircularRevealWidget object, Java.Lang.Integer value);
	public override void Set (Java.Lang.Object object, Java.Lang.Object value);
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
	protected NavigationMenuPresenter (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
	// properties
	public virtual AndroidX.AppCompat.View.Menu.MenuItemImpl CheckedItem { get; set; }
	public virtual int HeaderCount { get; }
	public virtual int Id { get; set; }
	public virtual Android.Graphics.Drawables.Drawable ItemBackground { get; set; }
	public virtual int ItemHorizontalPadding { get; set; }
	public virtual int ItemIconPadding { get; set; }
	public virtual Android.Content.Res.ColorStateList ItemTextColor { get; set; }
	public virtual Android.Content.Res.ColorStateList ItemTintList { get; }
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public virtual void AddHeaderView (Android.Views.View view);
	public virtual bool CollapseItemActionView (AndroidX.AppCompat.View.Menu.MenuBuilder menu, AndroidX.AppCompat.View.Menu.MenuItemImpl item);
	public virtual void DispatchApplyWindowInsets (AndroidX.Core.View.WindowInsetsCompat insets);
	public virtual bool ExpandItemActionView (AndroidX.AppCompat.View.Menu.MenuBuilder menu, AndroidX.AppCompat.View.Menu.MenuItemImpl item);
	public virtual bool FlagActionItems ();
	public virtual Android.Views.View GetHeaderView (int index);
	public virtual AndroidX.AppCompat.View.Menu.IMenuView GetMenuView (Android.Views.ViewGroup root);
	public virtual Android.Views.View InflateHeaderView (int res);
	public virtual void InitForMenu (Android.Content.Context context, AndroidX.AppCompat.View.Menu.MenuBuilder menu);
	public virtual void OnCloseMenu (AndroidX.AppCompat.View.Menu.MenuBuilder menu, bool allMenusAreClosing);
	public virtual void OnRestoreInstanceState (Android.OS.IParcelable parcelable);
	public virtual Android.OS.IParcelable OnSaveInstanceState ();
	public virtual bool OnSubMenuSelected (AndroidX.AppCompat.View.Menu.SubMenuBuilder subMenu);
	public virtual void RemoveHeaderView (Android.Views.View view);
	public virtual void SetCallback (AndroidX.AppCompat.View.Menu.IMenuPresenterCallback cb);
	public virtual void SetItemIconTintList (Android.Content.Res.ColorStateList tint);
	public virtual void SetItemTextAppearance (int resId);
	public virtual void SetUpdateSuspended (bool updateSuspended);
	public virtual void UpdateMenuView (bool cleared);
}
```


### Namespace Google.Android.Material.Snackbar

#### Type Changed: Google.Android.Material.Snackbar.BaseTransientBottomBar

#### Type Changed: Google.Android.Material.Snackbar.BaseTransientBottomBar.Behavior

Added method:

```csharp
public override bool OnInterceptTouchEvent (AndroidX.CoordinatorLayout.Widget.CoordinatorLayout parent, Java.Lang.Object child, Android.Views.MotionEvent e);
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

#### Type Changed: Google.Android.Material.AppBar.AppBarLayout

#### Type Changed: Google.Android.Material.AppBar.AppBarLayout.Behavior.Behavior

Modified methods:

```diff
-public override void OnNestedScroll (AndroidX.CoordinatorLayout.Widget.CoordinatorLayout coordinatorLayout, Java.Lang.Object child, Android.Views.View target, int dx, int dy---dyConsumed---, int consumed---dxUnconsumed---, int type---dyUnconsumed---, int p7---type---)
+public override void OnNestedScroll (AndroidX.CoordinatorLayout.Widget.CoordinatorLayout coordinatorLayout, Java.Lang.Object child, Android.Views.View target, int dxConsumed, int +++dy+++dyConsumed, int +++consumed+++dxUnconsumed, int +++type+++dyUnconsumed, int +++p7+++type)
-public override void OnRestoreInstanceState (AndroidX.CoordinatorLayout.Widget.CoordinatorLayout state, Java.Lang.Object appBarLayout, Android.OS.IParcelable p2---state---)
+public override void OnRestoreInstanceState (AndroidX.CoordinatorLayout.Widget.CoordinatorLayout parent, Java.Lang.Object appBarLayout, Android.OS.IParcelable +++p2+++state)
```



#### Type Changed: Google.Android.Material.AppBar.HeaderScrollingViewBehavior

Removed method:

```csharp
public virtual bool OnMeasureChild (AndroidX.CoordinatorLayout.Widget.CoordinatorLayout parent, Android.Views.View child, int parentWidthMeasureSpec, int widthUsed, int parentHeightMeasureSpec, int heightUsed);
```

Added method:

```csharp
protected override void LayoutChild (AndroidX.CoordinatorLayout.Widget.CoordinatorLayout parent, Java.Lang.Object child, int layoutDirection);
```


#### Type Changed: Google.Android.Material.AppBar.ViewOffsetBehavior

Added method:

```csharp
public virtual bool OnMeasureChild (AndroidX.CoordinatorLayout.Widget.CoordinatorLayout parent, Android.Views.View child, int parentWidthMeasureSpec, int widthUsed, int parentHeightMeasureSpec, int heightUsed);
```



### Namespace Google.Android.Material.BottomSheet

#### Type Changed: Google.Android.Material.BottomSheet.BottomSheetBehavior

Modified methods:

```diff
-public virtual bool OnInterceptTouchEvent (AndroidX.CoordinatorLayout.Widget.CoordinatorLayout parent, Java.Lang.Object child, Android.Views.MotionEvent event_)
+public virtual bool OnInterceptTouchEvent (AndroidX.CoordinatorLayout.Widget.CoordinatorLayout parent, Java.Lang.Object child, Android.Views.MotionEvent e)
-public virtual bool OnTouchEvent (AndroidX.CoordinatorLayout.Widget.CoordinatorLayout parent, Java.Lang.Object child, Android.Views.MotionEvent event_)
+public virtual bool OnTouchEvent (AndroidX.CoordinatorLayout.Widget.CoordinatorLayout parent, Java.Lang.Object child, Android.Views.MotionEvent e)
```

#### Type Changed: Google.Android.Material.BottomSheet.BottomSheetBehavior.BottomSheetCallback

Modified methods:

```diff
-public abstract void OnSlide (Android.Views.View bottomSheet, float slideOffset)
+public abstract void OnSlide (Android.Views.View bottomSheet, float newState)
-public abstract void OnStateChanged (Android.Views.View bottomSheet, int newState---p1---)
+public abstract void OnStateChanged (Android.Views.View p0, int +++newState+++p1)
```



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
public virtual void OnNestedScroll (Android.Views.View target, int dxConsumed, int dyConsumed, int dxUnconsumed, int dyUnconsumed, int type, int[] consumed);
```

#### Type Changed: AndroidX.CoordinatorLayout.Widget.CoordinatorLayout.Behavior

Obsoleted methods:

```diff
 [Obsolete ("deprecated")]
 public virtual void OnNestedScroll (CoordinatorLayout coordinatorLayout, Java.Lang.Object child, Android.Views.View target, int dxConsumed, int dyConsumed, int dxUnconsumed, int dyUnconsumed, int type);
```

Added method:

```csharp
public virtual void OnNestedScroll (CoordinatorLayout coordinatorLayout, Java.Lang.Object child, Android.Views.View target, int dxConsumed, int dyConsumed, int dxUnconsumed, int dyUnconsumed, int type, int[] consumed);
```




### Namespace Google.Android.Material.FloatingActionButton

#### Type Changed: Google.Android.Material.FloatingActionButton.FloatingActionButton

Modified methods:

```diff
-public virtual void Show (FloatingActionButton.OnVisibilityChangedListener visibility)
+public virtual void Show (FloatingActionButton.OnVisibilityChangedListener listener)
```

#### Type Changed: Google.Android.Material.FloatingActionButton.FloatingActionButton.Behavior

Modified methods:

```diff
-public virtual bool GetInsetDodgeRect (AndroidX.CoordinatorLayout.Widget.CoordinatorLayout parent, FloatingActionButton child---p1---, Android.Graphics.Rect rect---p2---)
+public virtual bool GetInsetDodgeRect (AndroidX.CoordinatorLayout.Widget.CoordinatorLayout p0, FloatingActionButton +++child+++p1, Android.Graphics.Rect +++rect+++p2)
-public override void OnAttachedToLayoutParams (AndroidX.CoordinatorLayout.Widget.CoordinatorLayout.LayoutParams layoutParams)
+public override void OnAttachedToLayoutParams (AndroidX.CoordinatorLayout.Widget.CoordinatorLayout.LayoutParams p0)
-public virtual bool OnDependentViewChanged (AndroidX.CoordinatorLayout.Widget.CoordinatorLayout parent, FloatingActionButton child---p1---, Android.Views.View dependency---p2---)
+public virtual bool OnDependentViewChanged (AndroidX.CoordinatorLayout.Widget.CoordinatorLayout p0, FloatingActionButton +++child+++p1, Android.Views.View +++dependency+++p2)
-public virtual bool OnLayoutChild (AndroidX.CoordinatorLayout.Widget.CoordinatorLayout parent, FloatingActionButton child---p1---, int layoutDirection---p2---)
+public virtual bool OnLayoutChild (AndroidX.CoordinatorLayout.Widget.CoordinatorLayout p0, FloatingActionButton +++child+++p1, int +++layoutDirection+++p2)
-public virtual void SetInternalAutoHideListener (FloatingActionButton.OnVisibilityChangedListener listener)
+public virtual void SetInternalAutoHideListener (FloatingActionButton.OnVisibilityChangedListener p0)
```




### Namespace AndroidX.VectorDrawable.Graphics.Drawable

#### Type Changed: AndroidX.VectorDrawable.Graphics.Drawable.VectorDrawableCompat

Removed property:

```csharp
public override Android.Graphics.ColorFilter ColorFilter { get; }
```



### Namespace AndroidX.ExifInterface.Media

#### Type Changed: AndroidX.ExifInterface.Media.ExifInterface

Added constructors:

```csharp
public ExifInterface (Java.IO.File file);
public ExifInterface (Java.IO.FileDescriptor fileDescriptor);
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
public virtual long DateTimeDigitized { get; }
public virtual long DateTimeOriginal { get; }
```

Added methods:

```csharp
public virtual byte[] GetAttributeBytes (string tag);
public virtual long[] GetAttributeRange (string tag);
public virtual bool HasAttribute (string tag);
```



### Namespace AndroidX.TvProvider.Media.Tv

#### Type Changed: AndroidX.TvProvider.Media.Tv.PreviewChannelHelper

Modified properties:

```diff
-public virtual System.Collections.Generic.IList<Android.Support.Media.TV.PreviewChannel> AllChannels { get; }
+public virtual System.Collections.Generic.IList<PreviewChannel> AllChannels { get; }
```



### Namespace AndroidX.Emoji.Text

#### Type Changed: AndroidX.Emoji.Text.EmojiCompat

#### Type Changed: AndroidX.Emoji.Text.EmojiCompat.IMetadataRepoLoader

Modified methods:

```diff
-public abstract void Load (EmojiCompat.MetadataRepoLoaderCallback loaderCallback)
+public abstract void Load (EmojiCompat.MetadataRepoLoaderCallback p0)
```


#### Type Changed: AndroidX.Emoji.Text.EmojiCompat.MetadataRepoLoaderCallback

Modified methods:

```diff
-public abstract void OnFailed (Java.Lang.Throwable throwable)
+public abstract void OnFailed (Java.Lang.Throwable p0)
-public abstract void OnLoaded (MetadataRepo metadataRepo)
+public abstract void OnLoaded (MetadataRepo p0)
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
public static Scene GetCurrentScene (Android.Views.ViewGroup sceneRoot);
```


#### Type Changed: AndroidX.Transitions.TransitionValues

Obsoleted constructors:

```diff
 [Obsolete ("deprecated")]
 public TransitionValues ();
```

Added constructor:

```csharp
public TransitionValues (Android.Views.View view);
```



### Namespace AndroidX.Legacy.App

#### Type Changed: AndroidX.Legacy.App.ActionBarDrawerToggle

#### Type Changed: AndroidX.Legacy.App.ActionBarDrawerToggle.IDelegate

Modified methods:

```diff
-public abstract void SetActionBarDescription (int contentDescRes)
+public abstract void SetActionBarDescription (int p0)
-public abstract void SetActionBarUpIndicator (Android.Graphics.Drawables.Drawable upDrawable, int contentDescRes---p1---)
+public abstract void SetActionBarUpIndicator (Android.Graphics.Drawables.Drawable p0, int +++contentDescRes+++p1)
```




### Namespace AndroidX.Core.View

#### Type Changed: AndroidX.Core.View.AccessibilityDelegateCompat

Added constructor:

```csharp
public AccessibilityDelegateCompat (Android.Views.View.AccessibilityDelegate originalDelegate);
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
public virtual void DispatchNestedScroll (int dxConsumed, int dyConsumed, int dxUnconsumed, int dyUnconsumed, int[] offsetInWindow, int type, int[] consumed);
```


#### Type Changed: AndroidX.Core.View.ViewCompat

Modified methods:

```diff
-public bool HasAccessibilityDelegate (Android.Views.View v)
+public bool HasAccessibilityDelegate (Android.Views.View view)
```

Added methods:

```csharp
public static int AddAccessibilityAction (Android.Views.View view, Java.Lang.ICharSequence label, Accessibiity.IAccessibilityViewCommand command);
public static int AddAccessibilityAction (Android.Views.View view, string label, Accessibiity.IAccessibilityViewCommand command);
public static void DispatchNestedScroll (Android.Views.View view, int dxConsumed, int dyConsumed, int dxUnconsumed, int dyUnconsumed, int[] offsetInWindow, int type, int[] consumed);
public static void EnableAccessibleClickableSpanSupport (Android.Views.View view);
public static AccessibilityDelegateCompat GetAccessibilityDelegate (Android.Views.View view);
public static string GetAccessibilityPaneTitle (Android.Views.View view);
public static Java.Lang.ICharSequence GetAccessibilityPaneTitleFormatted (Android.Views.View view);
public static bool IsAccessibilityHeading (Android.Views.View view);
public static bool IsScreenReaderFocusable (Android.Views.View view);
public static void RemoveAccessibilityAction (Android.Views.View view, int actionId);
public static void ReplaceAccessibilityAction (Android.Views.View view, Accessibiity.AccessibilityNodeInfoCompat.AccessibilityActionCompat replacedAction, Java.Lang.ICharSequence label, Accessibiity.IAccessibilityViewCommand command);
public static void ReplaceAccessibilityAction (Android.Views.View view, Accessibiity.AccessibilityNodeInfoCompat.AccessibilityActionCompat replacedAction, string label, Accessibiity.IAccessibilityViewCommand command);
public static void SetAccessibilityHeading (Android.Views.View view, bool isHeading);
public static void SetAccessibilityPaneTitle (Android.Views.View view, Java.Lang.ICharSequence accessibilityPaneTitle);
public static void SetAccessibilityPaneTitle (Android.Views.View view, string accessibilityPaneTitle);
public static void SetScreenReaderFocusable (Android.Views.View view, bool screenReaderFocusable);
```

#### New Type: AndroidX.Core.View.ViewCompat.AccessibilityPaneVisibilityManager

```csharp
public class AccessibilityPaneVisibilityManager : Java.Lang.Object, Android.Runtime.IJavaObject, Android.Views.View.IOnAttachStateChangeListener, Android.Views.ViewTreeObserver.IOnGlobalLayoutListener, System.IDisposable {
	// constructors
	protected ViewCompat.AccessibilityPaneVisibilityManager (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
	// properties
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public virtual void OnGlobalLayout ();
	public virtual void OnViewAttachedToWindow (Android.Views.View view);
	public virtual void OnViewDetachedFromWindow (Android.Views.View view);
}
```

#### New Type: AndroidX.Core.View.ViewCompat.AccessibilityViewProperty

```csharp
public abstract class AccessibilityViewProperty : Java.Lang.Object {
	// constructors
	protected ViewCompat.AccessibilityViewProperty (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
	// properties
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
}
```


#### Type Changed: AndroidX.Core.View.ViewParentCompat

Added method:

```csharp
public static void OnNestedScroll (Android.Views.IViewParent parent, Android.Views.View target, int dxConsumed, int dyConsumed, int dxUnconsumed, int dyUnconsumed, int type, int[] consumed);
```


#### New Type: AndroidX.Core.View.INestedScrollingChild3

```csharp
public interface INestedScrollingChild3 : Android.Runtime.IJavaObject, INestedScrollingChild, INestedScrollingChild2, System.IDisposable {
	// methods
	public virtual void DispatchNestedScroll (int p0, int p1, int p2, int p3, int[] p4, int p5, int[] p6);
}
```

#### New Type: AndroidX.Core.View.INestedScrollingParent3

```csharp
public interface INestedScrollingParent3 : Android.Runtime.IJavaObject, INestedScrollingParent, INestedScrollingParent2, System.IDisposable {
	// methods
	public virtual void OnNestedScroll (Android.Views.View p0, int p1, int p2, int p3, int p4, int p5, int[] p6);
}
```

#### New Type: AndroidX.Core.View.OneShotPreDrawListener

```csharp
public sealed class OneShotPreDrawListener : Java.Lang.Object, Android.Runtime.IJavaObject, Android.Views.View.IOnAttachStateChangeListener, Android.Views.ViewTreeObserver.IOnPreDrawListener, System.IDisposable {
	// properties
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public static OneShotPreDrawListener Add (Android.Views.View view, Java.Lang.IRunnable runnable);
	public virtual bool OnPreDraw ();
	public virtual void OnViewAttachedToWindow (Android.Views.View v);
	public virtual void OnViewDetachedFromWindow (Android.Views.View v);
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
 public static EditTextPreferenceDialogFragment NewInstance (string key);
 [Obsolete ("deprecated")]
 public override void OnDialogClosed (bool positiveResult);
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
 public static ListPreferenceDialogFragment NewInstance (string key);
 [Obsolete ("deprecated")]
 public override void OnDialogClosed (bool positiveResult);
```


#### Type Changed: AndroidX.Preference.MultiSelectListPreference

Modified base type:

```diff
-Android.Support.V7.Preference.Internal.AbstractMultiSelectListPreference
+AndroidX.Preference.DialogPreference
```

Modified properties:

```diff
-public override System.Collections.Generic.ICollection<string> Values { get; set; }
+public virtual System.Collections.Generic.ICollection<string> Values { get; set; }
```

Modified methods:

```diff
-public override Java.Lang.ICharSequence[] GetEntriesFormatted ()
+public virtual Java.Lang.ICharSequence[] GetEntriesFormatted ()
-public override Java.Lang.ICharSequence[] GetEntryValuesFormatted ()
+public virtual Java.Lang.ICharSequence[] GetEntryValuesFormatted ()
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
 public static MultiSelectListPreferenceDialogFragment NewInstance (string key);
 [Obsolete ("deprecated")]
 public override void OnDialogClosed (bool positiveResult);
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
 public virtual DialogPreference Preference { get; }
```

Obsoleted methods:

```diff
 [Obsolete ("deprecated")]
 protected virtual void OnBindDialogView (Android.Views.View view);
 [Obsolete ("deprecated")]
 public virtual void OnClick (Android.Content.IDialogInterface dialog, int which);
 [Obsolete ("deprecated")]
 protected virtual Android.Views.View OnCreateDialogView (Android.Content.Context context);
 [Obsolete ("deprecated")]
 protected virtual void OnPrepareDialogBuilder (Android.App.AlertDialog.Builder builder);
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
 public virtual PreferenceManager PreferenceManager { get; }
 [Obsolete ("deprecated")]
 public virtual PreferenceScreen PreferenceScreen { get; set; }
```

Removed methods:

```csharp
public virtual Preference FindPreference (Java.Lang.ICharSequence key);
public Preference FindPreference (string key);
```

Obsoleted methods:

```diff
 [Obsolete ("deprecated")]
 public virtual void AddPreferencesFromResource (int preferencesResId);
 [Obsolete ("deprecated")]
 protected virtual AndroidX.RecyclerView.Widget.RecyclerView.Adapter OnCreateAdapter (PreferenceScreen preferenceScreen);
 [Obsolete ("deprecated")]
 public virtual AndroidX.RecyclerView.Widget.RecyclerView.LayoutManager OnCreateLayoutManager ();
 [Obsolete ("deprecated")]
 public virtual AndroidX.RecyclerView.Widget.RecyclerView OnCreateRecyclerView (Android.Views.LayoutInflater inflater, Android.Views.ViewGroup parent, Android.OS.Bundle savedInstanceState);
 [Obsolete ("deprecated")]
 public virtual void OnDisplayPreferenceDialog (Preference preference);
 [Obsolete ("deprecated")]
 public virtual void OnNavigateToScreen (PreferenceScreen preferenceScreen);
 [Obsolete ("deprecated")]
 public virtual bool OnPreferenceTreeClick (Preference preference);
 [Obsolete ("deprecated")]
 public virtual void ScrollToPreference (Preference preference);
 [Obsolete ("deprecated")]
 public virtual void ScrollToPreference (string key);
 [Obsolete ("deprecated")]
 public virtual void SetDivider (Android.Graphics.Drawables.Drawable divider);
 [Obsolete ("deprecated")]
 public virtual void SetDividerHeight (int height);
 [Obsolete ("deprecated")]
 public virtual void SetPreferencesFromResource (int preferencesResId, string key);
```

Added methods:

```csharp

[Obsolete ("deprecated")]
public virtual Java.Lang.Object FindPreference (Java.Lang.ICharSequence key);

[Obsolete ("deprecated")]
public Java.Lang.Object FindPreference (string key);
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
public virtual Preference FindPreference (Java.Lang.ICharSequence key);
```

Added method:

```csharp
public virtual Java.Lang.Object FindPreference (Java.Lang.ICharSequence key);
```



#### Type Changed: AndroidX.Preference.DialogPreferenceITargetFragmentExtensions

Removed method:

```csharp
public static Preference FindPreference (this DialogPreference.ITargetFragment self, string key);
```

Added method:

```csharp
public static Java.Lang.Object FindPreference (this DialogPreference.ITargetFragment self, string key);
```


#### Type Changed: AndroidX.Preference.DropDownPreference

Removed method:

```csharp
public virtual int FindSpinnerIndexOfValue (string value);
```


#### Type Changed: AndroidX.Preference.EditTextPreference

Added event:

```csharp
public event System.EventHandler<EditTextPreference.BindEditTextEventArgs> BindEditText;
```

Added method:

```csharp
public virtual void SetOnBindEditTextListener (EditTextPreference.IOnBindEditTextListener onBindEditTextListener);
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
public virtual Android.Content.ISharedPreferences SharedPreferences { get; }
```

Added property:

```csharp
public virtual bool CopyingEnabled { get; set; }
```

Removed methods:

```csharp
public void ClearWasDetached ();
protected virtual Preference FindPreferenceInHierarchy (string key);
public bool WasDetached ();
```

Obsoleted methods:

```diff
 [Obsolete ("deprecated")]
 public virtual void OnInitializeAccessibilityNodeInfo (AndroidX.Core.View.Accessibiity.AccessibilityNodeInfoCompat info);
```

Added method:

```csharp
protected virtual Java.Lang.Object FindPreferenceInHierarchy (string key);
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
public virtual Preference FindPreference (Java.Lang.ICharSequence key);
public Preference FindPreference (string key);
```

Added methods:

```csharp
public virtual Java.Lang.Object FindPreference (Java.Lang.ICharSequence key);
public Java.Lang.Object FindPreference (string key);
```


#### Type Changed: AndroidX.Preference.PreferenceGroup

Removed methods:

```csharp
public virtual Preference FindPreference (Java.Lang.ICharSequence key);
public Preference FindPreference (string key);
```

Added methods:

```csharp
public virtual Java.Lang.Object FindPreference (Java.Lang.ICharSequence key);
public Java.Lang.Object FindPreference (string key);
public virtual bool RemovePreferenceRecursively (Java.Lang.ICharSequence key);
public bool RemovePreferenceRecursively (string key);
```


#### Type Changed: AndroidX.Preference.PreferenceManager

Removed property:

```csharp
public virtual Android.Content.ISharedPreferences SharedPreferences { get; }
```

Removed methods:

```csharp
public virtual Preference FindPreference (Java.Lang.ICharSequence key);
public Preference FindPreference (string key);
public static Android.Content.ISharedPreferences GetDefaultSharedPreferences (Android.Content.Context context);
```

Added methods:

```csharp
public virtual Java.Lang.Object FindPreference (Java.Lang.ICharSequence key);
public Java.Lang.Object FindPreference (string key);
```


#### Type Changed: AndroidX.Preference.SeekBarPreference

Added properties:

```csharp
public virtual bool ShowSeekBarValue { get; set; }
public virtual bool UpdatesContinuously { get; set; }
```


#### Type Changed: AndroidX.Preference.TwoStatePreference

#### Type Changed: AndroidX.Preference.TwoStatePreference.SavedState

Removed constructors:

```csharp
public TwoStatePreference.SavedState (Android.OS.IParcelable superState);
public TwoStatePreference.SavedState (Android.OS.Parcel source);
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


#### Type Changed: AndroidX.Leanback.App.GuidedStepFragment

Modified properties:

```diff
-public virtual System.Collections.Generic.IList<Android.Support.V17.Leanback.Widget.GuidedAction> Actions { get; set; }
+public virtual System.Collections.Generic.IList<AndroidX.Leanback.Widget.GuidedAction> Actions { get; set; }
-public virtual System.Collections.Generic.IList<Android.Support.V17.Leanback.Widget.GuidedAction> ButtonActions { get; set; }
+public virtual System.Collections.Generic.IList<AndroidX.Leanback.Widget.GuidedAction> ButtonActions { get; set; }
```

Removed methods:

```csharp
public virtual void OnCreateActions (System.Collections.Generic.IList<Android.Support.V17.Leanback.Widget.GuidedAction> actions, Android.OS.Bundle savedInstanceState);
public virtual void OnCreateButtonActions (System.Collections.Generic.IList<Android.Support.V17.Leanback.Widget.GuidedAction> actions, Android.OS.Bundle savedInstanceState);
```

Added methods:

```csharp
public virtual void OnCreateActions (System.Collections.Generic.IList<AndroidX.Leanback.Widget.GuidedAction> actions, Android.OS.Bundle savedInstanceState);
public virtual void OnCreateButtonActions (System.Collections.Generic.IList<AndroidX.Leanback.Widget.GuidedAction> actions, Android.OS.Bundle savedInstanceState);
```


#### Type Changed: AndroidX.Leanback.App.GuidedStepSupportFragment

Added interface:

```csharp
AndroidX.SavedState.ISavedStateRegistryOwner
```

Modified properties:

```diff
-public virtual System.Collections.Generic.IList<Android.Support.V17.Leanback.Widget.GuidedAction> Actions { get; set; }
+public virtual System.Collections.Generic.IList<AndroidX.Leanback.Widget.GuidedAction> Actions { get; set; }
-public virtual System.Collections.Generic.IList<Android.Support.V17.Leanback.Widget.GuidedAction> ButtonActions { get; set; }
+public virtual System.Collections.Generic.IList<AndroidX.Leanback.Widget.GuidedAction> ButtonActions { get; set; }
```

Removed methods:

```csharp
public virtual void OnCreateActions (System.Collections.Generic.IList<Android.Support.V17.Leanback.Widget.GuidedAction> actions, Android.OS.Bundle savedInstanceState);
public virtual void OnCreateButtonActions (System.Collections.Generic.IList<Android.Support.V17.Leanback.Widget.GuidedAction> actions, Android.OS.Bundle savedInstanceState);
```

Added methods:

```csharp
public virtual void OnCreateActions (System.Collections.Generic.IList<AndroidX.Leanback.Widget.GuidedAction> actions, Android.OS.Bundle savedInstanceState);
public virtual void OnCreateButtonActions (System.Collections.Generic.IList<AndroidX.Leanback.Widget.GuidedAction> actions, Android.OS.Bundle savedInstanceState);
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



### Namespace AndroidX.Leanback.Media

#### Type Changed: AndroidX.Leanback.Media.PlaybackGlue

Modified properties:

```diff
-protected virtual System.Collections.Generic.IList<Android.Support.V17.Leanback.Media.PlaybackGlue.PlayerCallback> PlayerCallbacks { get; }
+protected virtual System.Collections.Generic.IList<PlaybackGlue.PlayerCallback> PlayerCallbacks { get; }
```



### Namespace AndroidX.Leanback.Widget

#### Type Changed: AndroidX.Leanback.Widget.BaseGridView

Added interface:

```csharp
AndroidX.Core.View.INestedScrollingChild3
```


#### Type Changed: AndroidX.Leanback.Widget.DetailsOverviewRow

Modified properties:

```diff
-public System.Collections.Generic.IList<Android.Support.V17.Leanback.Widget.Action> Actions { get; }
+public System.Collections.Generic.IList<Action> Actions { get; }
```


#### Type Changed: AndroidX.Leanback.Widget.GuidedAction

Modified properties:

```diff
-public virtual System.Collections.Generic.IList<Android.Support.V17.Leanback.Widget.GuidedAction> SubActions { get; set; }
+public virtual System.Collections.Generic.IList<GuidedAction> SubActions { get; set; }
```

#### Type Changed: AndroidX.Leanback.Widget.GuidedAction.BuilderBase

Removed method:

```csharp
public virtual Java.Lang.Object SubActions (System.Collections.Generic.IList<Android.Support.V17.Leanback.Widget.GuidedAction> subActions);
```

Added method:

```csharp
public virtual Java.Lang.Object SubActions (System.Collections.Generic.IList<GuidedAction> subActions);
```



#### Type Changed: AndroidX.Leanback.Widget.GuidedActionAdapter

Removed constructor:

```csharp
public GuidedActionAdapter (System.Collections.Generic.IList<Android.Support.V17.Leanback.Widget.GuidedAction> actions, GuidedActionAdapter.IClickListener clickListener, GuidedActionAdapter.IFocusListener focusListener, GuidedActionsStylist presenter, bool isSubAdapter);
```

Added constructor:

```csharp
public GuidedActionAdapter (System.Collections.Generic.IList<GuidedAction> actions, GuidedActionAdapter.IClickListener clickListener, GuidedActionAdapter.IFocusListener focusListener, GuidedActionsStylist presenter, bool isSubAdapter);
```

Modified properties:

```diff
-public virtual System.Collections.Generic.IList<Android.Support.V17.Leanback.Widget.GuidedAction> Actions { get; set; }
+public virtual System.Collections.Generic.IList<GuidedAction> Actions { get; set; }
```


#### Type Changed: AndroidX.Leanback.Widget.GuidedActionDiffCallback

Added methods:

```csharp
public void OnBindViewHolder (Java.Lang.Object holder, int position);
public virtual Java.Lang.Object OnCreateViewHolder (Android.Views.ViewGroup parent, int viewType);
```


#### Type Changed: AndroidX.Leanback.Widget.HorizontalGridView

Added interface:

```csharp
AndroidX.Core.View.INestedScrollingChild3
```


#### Type Changed: AndroidX.Leanback.Widget.ItemBridgeAdapter

Modified properties:

```diff
-public virtual System.Collections.Generic.IList<Android.Support.V17.Leanback.Widget.Presenter> PresenterMapper { get; set; }
+public virtual System.Collections.Generic.IList<Presenter> PresenterMapper { get; set; }
```


#### Type Changed: AndroidX.Leanback.Widget.Parallax

Modified properties:

```diff
-public virtual System.Collections.Generic.IList<Android.Support.V17.Leanback.Widget.ParallaxEffect> Effects { get; }
+public virtual System.Collections.Generic.IList<ParallaxEffect> Effects { get; }
```


#### Type Changed: AndroidX.Leanback.Widget.ParallaxEffect

Modified properties:

```diff
-public System.Collections.Generic.IList<Android.Support.V17.Leanback.Widget.Parallax.PropertyMarkerValue> PropertyRanges { get; }
+public System.Collections.Generic.IList<Parallax.PropertyMarkerValue> PropertyRanges { get; }
-public System.Collections.Generic.IList<Android.Support.V17.Leanback.Widget.ParallaxTarget> Targets { get; }
+public System.Collections.Generic.IList<ParallaxTarget> Targets { get; }
```


#### Type Changed: AndroidX.Leanback.Widget.VerticalGridView

Added interface:

```csharp
AndroidX.Core.View.INestedScrollingChild3
```



### Namespace AndroidX.Leanback.Widget.Picker

#### Type Changed: AndroidX.Leanback.Widget.Picker.Picker

Removed method:

```csharp
public virtual void SetColumns (System.Collections.Generic.IList<Android.Support.V17.Leanback.Widget.Picker.PickerColumn> columns);
```

Added method:

```csharp
public virtual void SetColumns (System.Collections.Generic.IList<PickerColumn> columns);
```



### Namespace AndroidX.Leanback.Preference

#### Type Changed: AndroidX.Leanback.Preference.LeanbackListPreferenceDialogFragment

#### Type Changed: AndroidX.Leanback.Preference.LeanbackListPreferenceDialogFragment.AdapterMulti

Modified methods:

```diff
-public override void OnBindViewHolder (AndroidX.RecyclerView.Widget.RecyclerView.ViewHolder p0, int p1---position---)
+public override void OnBindViewHolder (AndroidX.RecyclerView.Widget.RecyclerView.ViewHolder holder, int +++p1+++position)
```




### Namespace AndroidX.Core.App

#### Type Changed: AndroidX.Core.App.ActivityCompat

Added method:

```csharp
public static void Recreate (Android.App.Activity activity);
```


#### Type Changed: AndroidX.Core.App.JobIntentService

#### Type Changed: AndroidX.Core.App.JobIntentService.CompatWorkItem

Removed interfaces:

```csharp
Android.Runtime.IJavaObject
JobIntentService.IGenericWorkItem
System.IDisposable
```

Modified properties:

```diff
-public virtual Android.Content.Intent Intent { get; }
+public final Android.Content.Intent Intent { get; }
```

Modified methods:

```diff
-public virtual void Complete ()
+public final void Complete ()
```


#### Type Changed: AndroidX.Core.App.JobIntentService.JobServiceEngineImpl.JobServiceEngineImpl

Removed interfaces:

```csharp
Android.Runtime.IJavaObject
JobIntentService.ICompatJobEngine
System.IDisposable
```

Modified methods:

```diff
-public virtual Android.OS.IBinder CompatGetBinder ()
+public final Android.OS.IBinder CompatGetBinder ()
-public virtual JobIntentService.IGenericWorkItem DequeueWork ()
+public final JobIntentService.IGenericWorkItem DequeueWork ()
```

#### Type Changed: AndroidX.Core.App.JobIntentService.JobServiceEngineImpl.WrapperWorkItem

Removed interfaces:

```csharp
Android.Runtime.IJavaObject
JobIntentService.IGenericWorkItem
System.IDisposable
```

Modified properties:

```diff
-public virtual Android.Content.Intent Intent { get; }
+public final Android.Content.Intent Intent { get; }
```

Modified methods:

```diff
-public virtual void Complete ()
+public final void Complete ()
```




#### Type Changed: AndroidX.Core.App.NotificationCompat

Added field:

```csharp
public static const string CategoryNavigation = "navigation";
```

Removed method:

```csharp
public static System.Collections.Generic.IList<Android.Support.V4.App.NotificationCompat.Action> GetInvisibleActions (Android.App.Notification notification);
```

Added method:

```csharp
public static System.Collections.Generic.IList<NotificationCompat.Action> GetInvisibleActions (Android.App.Notification notification);
```

#### Type Changed: AndroidX.Core.App.NotificationCompat.MessagingStyle.MessagingStyle

Modified properties:

```diff
-public virtual System.Collections.Generic.IList<Android.Support.V4.App.NotificationCompat.MessagingStyle.Message> Messages { get; }
+public virtual System.Collections.Generic.IList<NotificationCompat.MessagingStyle.Message> Messages { get; }
```


#### Type Changed: AndroidX.Core.App.NotificationCompat.MessagingStyle.WearableExtender

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

Modified properties:

```diff
-public System.Collections.Generic.IList<Android.Support.V4.App.NotificationCompat.Action> Actions { get; }
+public System.Collections.Generic.IList<NotificationCompat.Action> Actions { get; }
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

Removed method:

```csharp
public NotificationCompat.WearableExtender AddActions (System.Collections.Generic.IList<Android.Support.V4.App.NotificationCompat.Action> actions);
```

Obsoleted methods:

```diff
 [Obsolete ("deprecated")]
 public NotificationCompat.WearableExtender AddPage (Android.App.Notification page);
 [Obsolete ("deprecated")]
 public NotificationCompat.WearableExtender AddPages (System.Collections.Generic.IList<Android.App.Notification> pages);
 [Obsolete ("deprecated")]
 public NotificationCompat.WearableExtender ClearPages ();
 [Obsolete ("deprecated")]
 public NotificationCompat.WearableExtender SetBackground (Android.Graphics.Bitmap background);
 [Obsolete ("deprecated")]
 public NotificationCompat.WearableExtender SetDisplayIntent (Android.App.PendingIntent intent);
 [Obsolete ("deprecated")]
 public NotificationCompat.WearableExtender SetHintAmbientBigPicture (bool hintAmbientBigPicture);
```

Added method:

```csharp
public NotificationCompat.WearableExtender AddActions (System.Collections.Generic.IList<NotificationCompat.Action> actions);
```



#### Type Changed: AndroidX.Core.App.NotificationManagerCompat

Added properties:

```csharp
public System.Collections.Generic.IList<Android.App.NotificationChannelGroup> NotificationChannelGroups { get; }
public System.Collections.Generic.IList<Android.App.NotificationChannel> NotificationChannels { get; }
```

Added methods:

```csharp
public void CreateNotificationChannel (Android.App.NotificationChannel channel);
public void CreateNotificationChannelGroup (Android.App.NotificationChannelGroup group);
public void CreateNotificationChannelGroups (System.Collections.Generic.IList<Android.App.NotificationChannelGroup> groups);
public void CreateNotificationChannels (System.Collections.Generic.IList<Android.App.NotificationChannel> channels);
public void DeleteNotificationChannel (string channelId);
public void DeleteNotificationChannelGroup (string groupId);
public Android.App.NotificationChannel GetNotificationChannel (string channelId);
public Android.App.NotificationChannelGroup GetNotificationChannelGroup (string channelGroupId);
```


#### Type Changed: AndroidX.Core.App.Person

Added methods:

```csharp
public static Person FromPersistableBundle (Android.OS.PersistableBundle bundle);
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
public static int GetResultsSource (Android.Content.Intent intent);
public static void SetResultsSource (Android.Content.Intent intent, int source);
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
	protected ComponentActivity (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
	// properties
	public virtual AndroidX.Lifecycle.Lifecycle Lifecycle { get; }
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public virtual Java.Lang.Object GetExtraData (Java.Lang.Class extraDataClass);
	public virtual void PutExtraData (ComponentActivity.ExtraData extraData);
	public virtual bool SuperDispatchKeyEvent (Android.Views.KeyEvent e);

	// inner types
	public class ExtraData : Java.Lang.Object {
		// constructors
		public ComponentActivity.ExtraData ();
		protected ComponentActivity.ExtraData (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
		// properties
		protected override IntPtr ThresholdClass { get; }
		protected override System.Type ThresholdType { get; }
	}
}
```

#### New Type: AndroidX.Core.App.DialogCompat

```csharp
public class DialogCompat : Java.Lang.Object {
	// constructors
	protected DialogCompat (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
	// properties
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public static Android.Views.View RequireViewById (Android.App.Dialog dialog, int id);
}
```

#### New Type: AndroidX.Core.App.RemoteActionCompat

```csharp
public sealed class RemoteActionCompat : Java.Lang.Object, Android.Runtime.IJavaObject, AndroidX.VersionedParcelable.IVersionedParcelable, System.IDisposable {
	// constructors
	public RemoteActionCompat ();
	public RemoteActionCompat (RemoteActionCompat other);
	public RemoteActionCompat (AndroidX.Core.Graphics.Drawable.IconCompat icon, Java.Lang.ICharSequence title, Java.Lang.ICharSequence contentDescription, Android.App.PendingIntent intent);
	public RemoteActionCompat (AndroidX.Core.Graphics.Drawable.IconCompat icon, string title, string contentDescription, Android.App.PendingIntent intent);
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
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	public string Title { get; }
	public Java.Lang.ICharSequence TitleFormatted { get; }
	// methods
	public static RemoteActionCompat CreateFromRemoteAction (Android.App.RemoteAction remoteAction);
	public void SetShouldShowIcon (bool shouldShowIcon);
	public bool ShouldShowIcon ();
	public Android.App.RemoteAction ToRemoteAction ();
}
```

#### New Type: AndroidX.Core.App.RemoteActionCompatParcelizer

```csharp
public class RemoteActionCompatParcelizer : Java.Lang.Object {
	// constructors
	public RemoteActionCompatParcelizer ();
	protected RemoteActionCompatParcelizer (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
	// properties
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public static RemoteActionCompat Read (AndroidX.VersionedParcelable.VersionedParcel parcel);
	public static void Write (RemoteActionCompat obj, AndroidX.VersionedParcelable.VersionedParcel parcel);
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
public Fragment (int contentLayoutId);
```

Added interface:

```csharp
AndroidX.SavedState.ISavedStateRegistryOwner
```

Obsoleted properties:

```diff
 [Obsolete ("deprecated")]
 public virtual bool UserVisibleHint { get; set; }
```

Added property:

```csharp
public virtual AndroidX.SavedState.SavedStateRegistry SavedStateRegistry { get; }
```

Obsoleted methods:

```diff
 [Obsolete ("deprecated")]
 public static Fragment Instantiate (Android.Content.Context context, string fname);
 [Obsolete ("deprecated")]
 public static Fragment Instantiate (Android.Content.Context context, string fname, Android.OS.Bundle args);
```

Added methods:

```csharp
public virtual void OnPrimaryNavigationFragmentChanged (bool isPrimaryNavigationFragment);
public void PostponeEnterTransition (long duration, Java.Util.Concurrent.TimeUnit timeUnit);
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
public FragmentActivity (int contentLayoutId);
```

Added interfaces:

```csharp
AndroidX.Activity.IOnBackPressedDispatcherOwner
AndroidX.Core.View.KeyEventDispatcher.IComponent
AndroidX.SavedState.ISavedStateRegistryOwner
```

Removed properties:

```csharp
public virtual Java.Lang.Object LastCustomNonConfigurationInstance { get; }
public virtual AndroidX.Lifecycle.ViewModelStore ViewModelStore { get; }
```

Modified properties:

```diff
-public virtual AndroidX.Lifecycle.Lifecycle Lifecycle { get; }
+public override AndroidX.Lifecycle.Lifecycle Lifecycle { get; }
```

Removed methods:

```csharp
public virtual Java.Lang.Object OnRetainCustomNonConfigurationInstance ();
public override Java.Lang.Object OnRetainNonConfigurationInstance ();
```

Obsoleted methods:

```diff
 [Obsolete ("deprecated")]
 protected virtual bool OnPrepareOptionsPanel (Android.Views.View view, Android.Views.IMenu menu);
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
public virtual AndroidX.Lifecycle.Lifecycle Lifecycle { get; }
public virtual AndroidX.Activity.OnBackPressedDispatcher OnBackPressedDispatcher { get; }
public virtual AndroidX.Lifecycle.ViewModelStore ViewModelStore { get; }
```


#### Removed Type AndroidX.Fragment.App.FragmentActivity.NonConfigurationInstances

#### Type Changed: AndroidX.Fragment.App.FragmentContainer

Obsoleted methods:

```diff
 [Obsolete ("deprecated")]
 public virtual Fragment Instantiate (Android.Content.Context context, string className, Android.OS.Bundle arguments);
```


#### Type Changed: AndroidX.Fragment.App.FragmentController

Removed methods:

```csharp
public virtual System.Collections.Generic.IList<Android.Support.V4.App.Fragment> GetActiveFragments (System.Collections.Generic.IList<Android.Support.V4.App.Fragment> actives);

[Obsolete ("deprecated")]
public virtual void RestoreAllState (Android.OS.IParcelable state, System.Collections.Generic.IList<Android.Support.V4.App.Fragment> nonConfigList);

[Obsolete ("deprecated")]
public virtual System.Collections.Generic.IList<Android.Support.V4.App.Fragment> RetainNonConfig ();
```

Obsoleted methods:

```diff
 [Obsolete ("deprecated")]
 public virtual void RestoreAllState (Android.OS.IParcelable state, FragmentManagerNonConfig nonConfig);
 [Obsolete ("deprecated")]
 public virtual FragmentManagerNonConfig RetainNestedNonConfig ();
```

Added methods:

```csharp
public virtual System.Collections.Generic.IList<Fragment> GetActiveFragments (System.Collections.Generic.IList<Fragment> actives);

[Obsolete ("deprecated")]
public virtual void RestoreAllState (Android.OS.IParcelable state, System.Collections.Generic.IList<Fragment> nonConfigList);
public virtual void RestoreSaveState (Android.OS.IParcelable state);

[Obsolete ("deprecated")]
public virtual System.Collections.Generic.IList<Fragment> RetainNonConfig ();
```


#### Type Changed: AndroidX.Fragment.App.FragmentManager

Modified properties:

```diff
-public abstract System.Collections.Generic.IList<Android.Support.V4.App.Fragment> Fragments { get; }
+public abstract System.Collections.Generic.IList<Fragment> Fragments { get; }
```

Added property:

```csharp
public virtual FragmentFactory FragmentFactory { get; set; }
```


#### Type Changed: AndroidX.Fragment.App.FragmentPagerAdapter

Obsoleted constructors:

```diff
 [Obsolete ("deprecated")]
 public FragmentPagerAdapter (FragmentManager fm);
```

Added constructor:

```csharp
public FragmentPagerAdapter (FragmentManager fm, int behavior);
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
 public FragmentStatePagerAdapter (FragmentManager fm);
```

Added constructor:

```csharp
public FragmentStatePagerAdapter (FragmentManager fm, int behavior);
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
 public FragmentTabHost (Android.Content.Context context);
 [Obsolete ("deprecated")]
 public FragmentTabHost (Android.Content.Context context, Android.Util.IAttributeSet attrs);
```

Obsoleted methods:

```diff
 [Obsolete ("deprecated")]
 public virtual void AddTab (Android.Widget.TabHost.TabSpec tabSpec, Java.Lang.Class clss, Android.OS.Bundle args);
 [Obsolete ("deprecated")]
 public virtual void OnTabChanged (string tabId);
 [Obsolete ("deprecated")]
 public virtual void Setup (Android.Content.Context context, FragmentManager manager);
 [Obsolete ("deprecated")]
 public virtual void Setup (Android.Content.Context context, FragmentManager manager, int containerId);
```


#### Type Changed: AndroidX.Fragment.App.FragmentTransaction

Modified properties:

```diff
-public abstract bool IsAddToBackStackAllowed { get; }
+public virtual bool IsAddToBackStackAllowed { get; }
-public abstract bool IsEmpty { get; }
+public virtual bool IsEmpty { get; }
```

Modified methods:

```diff
-public abstract FragmentTransaction Add (Fragment fragment, string tag)
+public virtual FragmentTransaction Add (Fragment fragment, string tag)
-public abstract FragmentTransaction Add (int containerViewId, Fragment fragment)
+public virtual FragmentTransaction Add (int containerViewId, Fragment fragment)
-public abstract FragmentTransaction Add (int containerViewId, Fragment fragment, string tag)
+public virtual FragmentTransaction Add (int containerViewId, Fragment fragment, string tag)
-public abstract FragmentTransaction AddSharedElement (Android.Views.View sharedElement, string name)
+public virtual FragmentTransaction AddSharedElement (Android.Views.View sharedElement, string name)
-public abstract FragmentTransaction AddToBackStack (string name)
+public virtual FragmentTransaction AddToBackStack (string name)
-public abstract FragmentTransaction Attach (Fragment fragment)
+public virtual FragmentTransaction Attach (Fragment fragment)
-public abstract FragmentTransaction Detach (Fragment fragment)
+public virtual FragmentTransaction Detach (Fragment fragment)
-public abstract FragmentTransaction DisallowAddToBackStack ()
+public virtual FragmentTransaction DisallowAddToBackStack ()
-public abstract FragmentTransaction Hide (Fragment fragment)
+public virtual FragmentTransaction Hide (Fragment fragment)
-public abstract FragmentTransaction Remove (Fragment fragment)
+public virtual FragmentTransaction Remove (Fragment fragment)
-public abstract FragmentTransaction Replace (int containerViewId, Fragment fragment)
+public virtual FragmentTransaction Replace (int containerViewId, Fragment fragment)
-public abstract FragmentTransaction Replace (int containerViewId, Fragment fragment, string tag)
+public virtual FragmentTransaction Replace (int containerViewId, Fragment fragment, string tag)
-public abstract FragmentTransaction RunOnCommit (Java.Lang.IRunnable runnable)
+public virtual FragmentTransaction RunOnCommit (Java.Lang.IRunnable runnable)
-public abstract FragmentTransaction SetAllowOptimization (bool allowOptimization)
+public virtual FragmentTransaction SetAllowOptimization (bool allowOptimization)
-public abstract FragmentTransaction SetBreadCrumbShortTitle (Java.Lang.ICharSequence text)
+public virtual FragmentTransaction SetBreadCrumbShortTitle (Java.Lang.ICharSequence text)
-public abstract FragmentTransaction SetBreadCrumbShortTitle (int res)
+public virtual FragmentTransaction SetBreadCrumbShortTitle (int res)
-public abstract FragmentTransaction SetBreadCrumbTitle (Java.Lang.ICharSequence text)
+public virtual FragmentTransaction SetBreadCrumbTitle (Java.Lang.ICharSequence text)
-public abstract FragmentTransaction SetBreadCrumbTitle (int res)
+public virtual FragmentTransaction SetBreadCrumbTitle (int res)
-public abstract FragmentTransaction SetCustomAnimations (int enter, int exit)
+public virtual FragmentTransaction SetCustomAnimations (int enter, int exit)
-public abstract FragmentTransaction SetCustomAnimations (int enter, int exit, int popEnter, int popExit)
+public virtual FragmentTransaction SetCustomAnimations (int enter, int exit, int popEnter, int popExit)
-public abstract FragmentTransaction SetPrimaryNavigationFragment (Fragment fragment)
+public virtual FragmentTransaction SetPrimaryNavigationFragment (Fragment fragment)
-public abstract FragmentTransaction SetReorderingAllowed (bool reorderingAllowed)
+public virtual FragmentTransaction SetReorderingAllowed (bool reorderingAllowed)
-public abstract FragmentTransaction SetTransition (int transit)
+public virtual FragmentTransaction SetTransition (int transit)
-public abstract FragmentTransaction SetTransitionStyle (int styleRes)
+public virtual FragmentTransaction SetTransitionStyle (int styleRes)
-public abstract FragmentTransaction Show (Fragment fragment)
+public virtual FragmentTransaction Show (Fragment fragment)
```

Obsoleted methods:

```diff
 [Obsolete ("deprecated")]
 public virtual FragmentTransaction SetAllowOptimization (bool allowOptimization);
```

Added method:

```csharp
public virtual FragmentTransaction SetMaxLifecycle (Fragment fragment, AndroidX.Lifecycle.Lifecycle.State state);
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
	protected FragmentFactory (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
	// properties
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public virtual Fragment Instantiate (Java.Lang.ClassLoader classLoader, string className);
	public static Java.Lang.Class LoadFragmentClass (Java.Lang.ClassLoader classLoader, string className);
}
```


### Namespace Android.Support.V4.App

#### New Type: Android.Support.V4.App.RemoteActionCompatParcelizer

```csharp
public sealed class RemoteActionCompatParcelizer : AndroidX.Core.App.RemoteActionCompatParcelizer {
	// constructors
	public RemoteActionCompatParcelizer ();
	// properties
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public static AndroidX.Core.App.RemoteActionCompat Read (AndroidX.VersionedParcelable.VersionedParcel parcel);
	public static void Write (AndroidX.Core.App.RemoteActionCompat obj, AndroidX.VersionedParcelable.VersionedParcel parcel);
}
```


### Namespace AndroidX.Loader.App

#### Type Changed: AndroidX.Loader.App.LoaderManager

Modified methods:

```diff
-public abstract void DestroyLoader (int id)
+public abstract void DestroyLoader (int p0)
-public abstract void Dump (string prefix, Java.IO.FileDescriptor fd---p1---, Java.IO.PrintWriter writer---p2---, string[] args---p3---)
+public abstract void Dump (string p0, Java.IO.FileDescriptor +++fd+++p1, Java.IO.PrintWriter +++writer+++p2, string[] +++args+++p3)
-public abstract AndroidX.Loader.Content.Loader GetLoader (int id)
+public abstract AndroidX.Loader.Content.Loader GetLoader (int p0)
-public abstract AndroidX.Loader.Content.Loader InitLoader (int id, Android.OS.Bundle args---p1---, LoaderManager.ILoaderCallbacks callback---p2---)
+public abstract AndroidX.Loader.Content.Loader InitLoader (int p0, Android.OS.Bundle +++args+++p1, LoaderManager.ILoaderCallbacks +++callback+++p2)
-public abstract AndroidX.Loader.Content.Loader RestartLoader (int id, Android.OS.Bundle args---p1---, LoaderManager.ILoaderCallbacks callback---p2---)
+public abstract AndroidX.Loader.Content.Loader RestartLoader (int p0, Android.OS.Bundle +++args+++p1, LoaderManager.ILoaderCallbacks +++callback+++p2)
```

#### Type Changed: AndroidX.Loader.App.LoaderManager.ILoaderCallbacks

Modified methods:

```diff
-public abstract AndroidX.Loader.Content.Loader OnCreateLoader (int id, Android.OS.Bundle args---p1---)
+public abstract AndroidX.Loader.Content.Loader OnCreateLoader (int p0, Android.OS.Bundle +++args+++p1)
-public abstract void OnLoadFinished (AndroidX.Loader.Content.Loader loader, Java.Lang.Object data---p1---)
+public abstract void OnLoadFinished (AndroidX.Loader.Content.Loader p0, Java.Lang.Object +++data+++p1)
-public abstract void OnLoaderReset (AndroidX.Loader.Content.Loader loader)
+public abstract void OnLoaderReset (AndroidX.Loader.Content.Loader p0)
```




### Namespace AndroidX.Loader.Content

#### Type Changed: AndroidX.Loader.Content.AsyncTaskLoader

Added property:

```csharp
protected virtual Java.Util.Concurrent.IExecutor Executor { get; }
```

Removed method:

```csharp
public virtual void WaitForLoader ();
```



### Namespace AndroidX.Core.Content

#### Type Changed: AndroidX.Core.Content.ContextCompat

Added method:

```csharp
public static Java.Util.Concurrent.IExecutor GetMainExecutor (Android.Content.Context context);
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
public void Apply (Android.Content.ISharedPreferencesEditor editor);
```




### Namespace AndroidX.Core.Content.PM

#### Type Changed: AndroidX.Core.Content.PM.ShortcutInfoCompat

Added properties:

```csharp
public virtual System.Collections.Generic.ICollection<string> Categories { get; }
public virtual AndroidX.Core.Graphics.Drawable.IconCompat Icon { get; }
```

#### Type Changed: AndroidX.Core.Content.PM.ShortcutInfoCompat.Builder

Added constructors:

```csharp
public ShortcutInfoCompat.Builder (ShortcutInfoCompat shortcutInfo);
public ShortcutInfoCompat.Builder (Android.Content.Context context, Android.Content.PM.ShortcutInfo shortcutInfo);
```

Added methods:

```csharp
public virtual ShortcutInfoCompat.Builder SetCategories (System.Collections.Generic.ICollection<string> categories);
public virtual ShortcutInfoCompat.Builder SetLongLived ();
public virtual ShortcutInfoCompat.Builder SetPerson (AndroidX.Core.App.Person person);
public virtual ShortcutInfoCompat.Builder SetPersons (AndroidX.Core.App.Person[] persons);
```



#### Type Changed: AndroidX.Core.Content.PM.ShortcutManagerCompat

Added field:

```csharp
public static const string ExtraShortcutId = "android.intent.extra.shortcut.ID";
```

Added methods:

```csharp
public static bool AddDynamicShortcuts (Android.Content.Context context, System.Collections.Generic.IList<ShortcutInfoCompat> shortcutInfoList);
public static System.Collections.Generic.IList<ShortcutInfoCompat> GetDynamicShortcuts (Android.Content.Context context);
public static int GetMaxShortcutCountPerActivity (Android.Content.Context context);
public static void RemoveAllDynamicShortcuts (Android.Content.Context context);
public virtual void RemoveDynamicShortcuts (Android.Content.Context context, System.Collections.Generic.IList<string> shortcutIds);
public static bool UpdateShortcuts (Android.Content.Context context, System.Collections.Generic.IList<ShortcutInfoCompat> shortcutInfoList);
```


#### New Type: AndroidX.Core.Content.PM.ShortcutInfoCompatSaver

```csharp
public abstract class ShortcutInfoCompatSaver : Java.Lang.Object {
	// constructors
	public ShortcutInfoCompatSaver ();
	protected ShortcutInfoCompatSaver (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
	// properties
	public virtual System.Collections.Generic.IList<ShortcutInfoCompat> Shortcuts { get; }
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public virtual Java.Lang.Object AddShortcuts (System.Collections.Generic.IList<ShortcutInfoCompat> p0);
	public virtual Java.Lang.Object RemoveAllShortcuts ();
	public virtual Java.Lang.Object RemoveShortcuts (System.Collections.Generic.IList<string> p0);

	// inner types
	public class NoopImpl : AndroidX.Core.Content.PM.ShortcutInfoCompatSaver {
		// constructors
		public ShortcutInfoCompatSaver.NoopImpl ();
		protected ShortcutInfoCompatSaver.NoopImpl (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
		// properties
		protected override IntPtr ThresholdClass { get; }
		protected override System.Type ThresholdType { get; }
		// methods
		public override Java.Lang.Object AddShortcuts (System.Collections.Generic.IList<ShortcutInfoCompat> shortcuts);
		public override Java.Lang.Object RemoveAllShortcuts ();
		public override Java.Lang.Object RemoveShortcuts (System.Collections.Generic.IList<string> shortcutIds);
	}
}
```


### Namespace AndroidX.Core.Content.Resources

#### Type Changed: AndroidX.Core.Content.Resources.ColorStateListInflaterCompat

Added method:

```csharp
public static Android.Content.Res.ColorStateList Inflate (Android.Content.Res.Resources resources, int resId, Android.Content.Res.Resources.Theme theme);
```


#### Type Changed: AndroidX.Core.Content.Resources.ResourcesCompat

Added method:

```csharp
public static float GetFloat (Android.Content.Res.Resources res, int id);
```


#### Type Changed: AndroidX.Core.Content.Resources.TypedArrayUtils

Added method:

```csharp
public static Android.Content.Res.ColorStateList GetNamedColorStateList (Android.Content.Res.TypedArray a, System.Xml.XmlReader parser, Android.Content.Res.Resources.Theme theme, string attrName, int resId);
```



### Namespace AndroidX.Core.Graphics

#### Type Changed: AndroidX.Core.Graphics.PathParser

Added method:

```csharp
public static bool InterpolatePathDataNodes (PathParser.PathDataNode[] target, PathParser.PathDataNode[] from, PathParser.PathDataNode[] to, float fraction);
```


#### Type Changed: AndroidX.Core.Graphics.PathUtils

Removed methods:

```csharp
public static System.Collections.Generic.ICollection<Android.Support.V4.Graphics.PathSegment> Flatten (Android.Graphics.Path path);
public static System.Collections.Generic.ICollection<Android.Support.V4.Graphics.PathSegment> Flatten (Android.Graphics.Path path, float error);
```

Added methods:

```csharp
public static System.Collections.Generic.ICollection<PathSegment> Flatten (Android.Graphics.Path path);
public static System.Collections.Generic.ICollection<PathSegment> Flatten (Android.Graphics.Path path, float error);
```


#### Type Changed: AndroidX.Core.Graphics.TypefaceCompat

Added method:

```csharp
public static Android.Graphics.Typeface Create (Android.Content.Context context, Android.Graphics.Typeface family, int style);
```



### Namespace AndroidX.Core.Graphics.Drawable

#### Type Changed: AndroidX.Core.Graphics.Drawable.IconCompat

Added property:

```csharp
public virtual Android.Graphics.Bitmap Bitmap { get; }
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
public static AudioAttributesCompat FromBundle (Android.OS.Bundle bundle);
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
	protected MediaBrowserServiceCompat.ResultWrapper (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
	// properties
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public virtual void Detach ();
	public virtual void SendResult (Java.Lang.Object result);
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
protected AudioAttributesCompatParcelizer (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
```


#### Type Changed: AndroidX.Media.AudioAttributesImplBaseParcelizer

Added constructor:

```csharp
protected AudioAttributesImplBaseParcelizer (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
```

Removed method:

```csharp
public static Java.Lang.Object Read (AndroidX.VersionedParcelable.VersionedParcel parcel);
```

Added methods:

```csharp
public static AudioAttributesImplBase Read (AndroidX.VersionedParcelable.VersionedParcel parcel);
public static void Write (AudioAttributesImplBase obj, AndroidX.VersionedParcelable.VersionedParcel parcel);
```


#### New Type: AndroidX.Media.AudioAttributesImplBase

```csharp
public class AudioAttributesImplBase : Java.Lang.Object {
	// constructors
	protected AudioAttributesImplBase (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
	// properties
	public virtual Java.Lang.Object AudioAttributes { get; }
	public virtual int ContentType { get; }
	public virtual int Flags { get; }
	public virtual int LegacyStreamType { get; }
	public int MContentType { get; set; }
	public int MFlags { get; set; }
	public int MLegacyStream { get; set; }
	public int MUsage { get; set; }
	public virtual int RawLegacyStreamType { get; }
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	public virtual int Usage { get; }
	public virtual int VolumeControlStream { get; }

	// inner types
	public class Builder : Java.Lang.Object {
		// constructors
		protected AudioAttributesImplBase.Builder (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
		// properties
		protected override IntPtr ThresholdClass { get; }
		protected override System.Type ThresholdType { get; }
		// methods
		public virtual Java.Lang.Object Build ();
		public virtual Java.Lang.Object SetContentType (int contentType);
		public virtual Java.Lang.Object SetFlags (int flags);
		public virtual Java.Lang.Object SetLegacyStreamType (int streamType);
		public virtual Java.Lang.Object SetUsage (int usage);
	}
}
```

#### New Type: AndroidX.Media.AudioFocusRequestCompat

```csharp
public class AudioFocusRequestCompat : Java.Lang.Object {
	// constructors
	protected AudioFocusRequestCompat (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
	// properties
	public virtual AudioAttributesCompat AudioAttributesCompat { get; }
	public virtual Android.OS.Handler FocusChangeHandler { get; }
	public virtual int FocusGain { get; }
	public virtual Android.Media.AudioManager.IOnAudioFocusChangeListener OnAudioFocusChangeListener { get; }
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public virtual bool WillPauseWhenDucked ();

	// inner types
	public sealed class Builder : Java.Lang.Object {
		// constructors
		public AudioFocusRequestCompat.Builder (AudioFocusRequestCompat requestToCopy);
		public AudioFocusRequestCompat.Builder (int focusGain);
		// properties
		protected override IntPtr ThresholdClass { get; }
		protected override System.Type ThresholdType { get; }
		// methods
		public AudioFocusRequestCompat Build ();
		public AudioFocusRequestCompat.Builder SetAudioAttributes (AudioAttributesCompat attributes);
		public AudioFocusRequestCompat.Builder SetFocusGain (int focusGain);
		public AudioFocusRequestCompat.Builder SetOnAudioFocusChangeListener (Android.Media.AudioManager.IOnAudioFocusChangeListener listener);
		public AudioFocusRequestCompat.Builder SetOnAudioFocusChangeListener (Android.Media.AudioManager.IOnAudioFocusChangeListener listener, Android.OS.Handler handler);
		public AudioFocusRequestCompat.Builder SetWillPauseWhenDucked (bool pauseOnDuck);
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
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public static int AbandonAudioFocusRequest (Android.Media.AudioManager audioManager, AudioFocusRequestCompat focusRequest);
	public static int RequestAudioFocus (Android.Media.AudioManager audioManager, AudioFocusRequestCompat focusRequest);
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
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public static AndroidX.Media.AudioAttributesCompat Read (AndroidX.VersionedParcelable.VersionedParcel parcel);
	public static void Write (AndroidX.Media.AudioAttributesCompat obj, AndroidX.VersionedParcelable.VersionedParcel parcel);
}
```

#### New Type: Android.Support.V4.Media.AudioAttributesImplBaseParcelizer

```csharp
public sealed class AudioAttributesImplBaseParcelizer : AndroidX.Media.AudioAttributesImplBaseParcelizer {
	// constructors
	public AudioAttributesImplBaseParcelizer ();
	// properties
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public static AndroidX.Media.AudioAttributesImplBase Read (AndroidX.VersionedParcelable.VersionedParcel parcel);
	public static void Write (AndroidX.Media.AudioAttributesImplBase obj, AndroidX.VersionedParcelable.VersionedParcel parcel);
}
```


### Namespace Android.Support.V4.Media.Session

#### Type Changed: Android.Support.V4.Media.Session.IMediaSession

Added property:

```csharp
public virtual Android.OS.Bundle SessionInfo { get; }
```

Added method:

```csharp
public virtual void SetPlaybackSpeed (float p0);
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
public virtual Android.OS.Bundle SessionInfo { get; }
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
public virtual Android.OS.Bundle SessionInfo { get; }
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
public virtual void SetPlaybackSpeed (float speed);
```



#### Type Changed: Android.Support.V4.Media.Session.MediaSessionCompat

Removed constructor:

```csharp
public MediaSessionCompat (Android.Content.Context context, string tag, Android.OS.Bundle token2Bundle);
```

Added constructors:

```csharp
public MediaSessionCompat (Android.Content.Context context, string tag, Android.Content.ComponentName mbrComponent, Android.App.PendingIntent mbrIntent, Android.OS.Bundle sessionInfo);
public MediaSessionCompat (Android.Content.Context context, string tag, Android.Content.ComponentName mbrComponent, Android.App.PendingIntent mbrIntent, Android.OS.Bundle sessionInfo, AndroidX.VersionedParcelable.IVersionedParcelable session2Token);
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
public virtual void OnSetPlaybackSpeed (float speed);
```


#### Type Changed: Android.Support.V4.Media.Session.MediaSessionCompat.MediaSessionImplBase.MediaSessionImplBase

Removed constructor:

```csharp
public MediaSessionCompat.MediaSessionImplBase (Android.Content.Context context, string tag, Android.Content.ComponentName mbrComponent, Android.App.PendingIntent mbrIntent);
```

Added constructor:

```csharp
public MediaSessionCompat.MediaSessionImplBase (Android.Content.Context context, string tag, Android.Content.ComponentName mbrComponent, Android.App.PendingIntent mbrIntent, Android.OS.Bundle sessionInfo);
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
public override Android.OS.Bundle SessionInfo { get; }
```

Added method:

```csharp
public override void SetPlaybackSpeed (float speed);
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
public virtual Android.OS.Bundle SessionInfo { get; }
```

Added method:

```csharp
public virtual void SetPlaybackSpeed (float p0);
```



### Namespace AndroidX.Core.OS

#### Type Changed: AndroidX.Core.OS.HandlerCompat

Added methods:

```csharp
public static Android.OS.Handler CreateAsync (Android.OS.Looper looper);
public static Android.OS.Handler CreateAsync (Android.OS.Looper looper, Android.OS.Handler.ICallback callback);
```


#### Type Changed: AndroidX.Core.OS.LocaleListCompat

Obsoleted methods:

```diff
 [Obsolete ("deprecated")]
 public static LocaleListCompat Wrap (Java.Lang.Object localeList);
```

Modified methods:

```diff
-public LocaleListCompat Wrap (Java.Lang.Object object)
+public LocaleListCompat Wrap (Java.Lang.Object localeList)
```

Added method:

```csharp
public static LocaleListCompat Wrap (Android.OS.LocaleList localeList);
```


#### New Type: AndroidX.Core.OS.MessageCompat

```csharp
public sealed class MessageCompat : Java.Lang.Object {
	// properties
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public static bool IsAsynchronous (Android.OS.Message message);
	public static void SetAsynchronous (Android.OS.Message message, bool async);
}
```


### Namespace AndroidX.Core.Text

#### Type Changed: AndroidX.Core.Text.PrecomputedTextCompat

#### Type Changed: AndroidX.Core.Text.PrecomputedTextCompat.Params.Params

Added method:

```csharp
public bool EqualsWithoutTextDirection (PrecomputedTextCompat.Params other);
```



#### Type Changed: AndroidX.Core.Text.TextDirectionHeuristicsCompat

#### Removed Type AndroidX.Core.Text.TextDirectionHeuristicsCompat.ITextDirectionAlgorithm


### Namespace AndroidX.Collection

#### Type Changed: AndroidX.Collection.LongSparseArray

Obsoleted methods:

```diff
 [Obsolete ("deprecated")]
 public virtual void Delete (long key);
```

Added methods:

```csharp
public virtual Java.Lang.Object PutIfAbsent (long key, Java.Lang.Object value);
public virtual bool Remove (long key, Java.Lang.Object value);
public virtual Java.Lang.Object Replace (long key, Java.Lang.Object value);
public virtual bool Replace (long key, Java.Lang.Object oldValue, Java.Lang.Object newValue);
```


#### Type Changed: AndroidX.Collection.SimpleArrayMap

Added methods:

```csharp
public virtual Java.Lang.Object GetOrDefault (Java.Lang.Object key, Java.Lang.Object defaultValue);
public virtual Java.Lang.Object PutIfAbsent (Java.Lang.Object key, Java.Lang.Object value);
public virtual bool Remove (Java.Lang.Object key, Java.Lang.Object value);
public virtual Java.Lang.Object Replace (Java.Lang.Object key, Java.Lang.Object value);
public virtual bool Replace (Java.Lang.Object key, Java.Lang.Object oldValue, Java.Lang.Object newValue);
```


#### Type Changed: AndroidX.Collection.SparseArrayCompat

Obsoleted methods:

```diff
 [Obsolete ("deprecated")]
 public virtual void Delete (int key);
```

Added methods:

```csharp
public virtual Java.Lang.Object PutIfAbsent (int key, Java.Lang.Object value);
public virtual bool Remove (int key, Java.Lang.Object value);
public virtual Java.Lang.Object Replace (int key, Java.Lang.Object value);
public virtual bool Replace (int key, Java.Lang.Object oldValue, Java.Lang.Object newValue);
```



### Namespace AndroidX.Core.Util

#### Type Changed: AndroidX.Core.Util.Preconditions

Removed constructor:

```csharp
protected Preconditions (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
```

Removed methods:

```csharp
public static float CheckArgumentFinite (float value, string valueName);
public static long CheckArgumentInRange (long value, long lower, long upper, string valueName);
public static float CheckArgumentInRange (float value, float lower, float upper, string valueName);
public static long CheckArgumentNonnegative (long value);
public static long CheckArgumentNonnegative (long value, string errorMessage);
public static int CheckArgumentPositive (int value, string errorMessage);
public static float[] CheckArrayElementsInRange (float[] value, float lower, float upper, string valueName);
public static Java.Lang.Object[] CheckArrayElementsNotNull (Java.Lang.Object[] value, string valueName);
public static Java.Lang.Object CheckCollectionElementsNotNull (Java.Lang.Object value, string valueName);
public static System.Collections.ICollection CheckCollectionNotEmpty (System.Collections.ICollection value, string valueName);
public static int CheckFlagsArgument (int requestedFlags, int allowedFlags);
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

Modified properties:

```diff
-public virtual System.Collections.Generic.IList<Android.Support.V4.View.Accessibility.AccessibilityNodeInfoCompat.AccessibilityActionCompat> ActionList { get; }
+public virtual System.Collections.Generic.IList<AccessibilityNodeInfoCompat.AccessibilityActionCompat> ActionList { get; }
```

Added property:

```csharp
public virtual bool TextEntryKey { get; set; }
```

Removed methods:

```csharp
public virtual System.Collections.Generic.IList<Android.Support.V4.View.Accessibility.AccessibilityNodeInfoCompat> FindAccessibilityNodeInfosByText (string text);
public virtual System.Collections.Generic.IList<Android.Support.V4.View.Accessibility.AccessibilityNodeInfoCompat> FindAccessibilityNodeInfosByViewId (string viewId);
```

Added methods:

```csharp
public virtual void AddSpansToExtras (Java.Lang.ICharSequence text, Android.Views.View view);
public void AddSpansToExtras (string text, Android.Views.View view);
public virtual System.Collections.Generic.IList<AccessibilityNodeInfoCompat> FindAccessibilityNodeInfosByText (string text);
public virtual System.Collections.Generic.IList<AccessibilityNodeInfoCompat> FindAccessibilityNodeInfosByViewId (string viewId);
public static Android.Text.Style.ClickableSpan[] GetClickableSpans (Java.Lang.ICharSequence text);
public static Android.Text.Style.ClickableSpan[] GetClickableSpans (string text);
```

#### Type Changed: AndroidX.Core.View.Accessibiity.AccessibilityNodeInfoCompat.AccessibilityActionCompat

Added constructors:

```csharp
public AccessibilityNodeInfoCompat.AccessibilityActionCompat (int actionId, Java.Lang.ICharSequence label, IAccessibilityViewCommand command);
public AccessibilityNodeInfoCompat.AccessibilityActionCompat (int actionId, string label, IAccessibilityViewCommand command);
```

Added property:

```csharp
protected IAccessibilityViewCommand MCommand { get; set; }
```

Added methods:

```csharp
public virtual AccessibilityNodeInfoCompat.AccessibilityActionCompat CreateReplacementAction (Java.Lang.ICharSequence label, IAccessibilityViewCommand command);
public AccessibilityNodeInfoCompat.AccessibilityActionCompat CreateReplacementAction (string label, IAccessibilityViewCommand command);
public virtual bool Perform (Android.Views.View view, Android.OS.Bundle arguments);
```



#### Type Changed: AndroidX.Core.View.Accessibiity.AccessibilityNodeProviderCompat

Removed method:

```csharp
public virtual System.Collections.Generic.IList<Android.Support.V4.View.Accessibility.AccessibilityNodeInfoCompat> FindAccessibilityNodeInfosByText (string text, int virtualViewId);
```

Added method:

```csharp
public virtual System.Collections.Generic.IList<AccessibilityNodeInfoCompat> FindAccessibilityNodeInfosByText (string text, int virtualViewId);
```


#### New Type: AndroidX.Core.View.Accessibiity.AccessibilityClickableSpanCompat

```csharp
public sealed class AccessibilityClickableSpanCompat : Android.Text.Style.ClickableSpan {
	// constructors
	public AccessibilityClickableSpanCompat (int originalClickableSpanId, AccessibilityNodeInfoCompat nodeInfoCompat, int clickableSpanActionId);
	// fields
	public static const string SpanId = "ACCESSIBILITY_CLICKABLE_SPAN_ID";
	// properties
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public override void OnClick (Android.Views.View unused);
}
```

#### New Type: AndroidX.Core.View.Accessibiity.AccessibilityViewCommandCommandArguments

```csharp
public abstract class AccessibilityViewCommandCommandArguments : Java.Lang.Object {
	// constructors
	public AccessibilityViewCommandCommandArguments ();
	protected AccessibilityViewCommandCommandArguments (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
	// properties
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public virtual void SetBundle (Android.OS.Bundle bundle);
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
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
}
```

#### New Type: AndroidX.Core.View.Accessibiity.AccessibilityViewCommandMoveHtmlArguments

```csharp
public sealed class AccessibilityViewCommandMoveHtmlArguments : AndroidX.Core.View.Accessibiity.AccessibilityViewCommandCommandArguments {
	// constructors
	public AccessibilityViewCommandMoveHtmlArguments ();
	// properties
	public string HTMLElement { get; }
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
}
```

#### New Type: AndroidX.Core.View.Accessibiity.AccessibilityViewCommandMoveWindowArguments

```csharp
public sealed class AccessibilityViewCommandMoveWindowArguments : AndroidX.Core.View.Accessibiity.AccessibilityViewCommandCommandArguments {
	// constructors
	public AccessibilityViewCommandMoveWindowArguments ();
	// properties
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
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
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
}
```

#### New Type: AndroidX.Core.View.Accessibiity.AccessibilityViewCommandSetProgressArguments

```csharp
public sealed class AccessibilityViewCommandSetProgressArguments : AndroidX.Core.View.Accessibiity.AccessibilityViewCommandCommandArguments {
	// constructors
	public AccessibilityViewCommandSetProgressArguments ();
	// properties
	public float Progress { get; }
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
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
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
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
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
}
```

#### New Type: AndroidX.Core.View.Accessibiity.IAccessibilityViewCommand

```csharp
public interface IAccessibilityViewCommand : Android.Runtime.IJavaObject, System.IDisposable {
	// methods
	public virtual bool Perform (Android.Views.View p0, AccessibilityViewCommandCommandArguments p1);
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
public virtual void DispatchNestedScroll (int dxConsumed, int dyConsumed, int dxUnconsumed, int dyUnconsumed, int[] offsetInWindow, int type, int[] consumed);
public virtual void OnNestedScroll (Android.Views.View target, int dxConsumed, int dyConsumed, int dxUnconsumed, int dyUnconsumed, int type, int[] consumed);
public override void OnNestedScrollAccepted (Android.Views.View p0, Android.Views.View p1, Android.Views.ScrollAxis p2);
```


#### Type Changed: AndroidX.Core.Widget.TextViewCompat

Added methods:

```csharp
public static Android.Content.Res.ColorStateList GetCompoundDrawableTintList (Android.Widget.TextView textView);
public static Android.Graphics.PorterDuff.Mode GetCompoundDrawableTintMode (Android.Widget.TextView textView);
public static void SetCompoundDrawableTintList (Android.Widget.TextView textView, Android.Content.Res.ColorStateList tint);
public static void SetCompoundDrawableTintMode (Android.Widget.TextView textView, Android.Graphics.PorterDuff.Mode tintMode);
```


#### New Type: AndroidX.Core.Widget.ITintableCompoundDrawablesView

```csharp
public interface ITintableCompoundDrawablesView : Android.Runtime.IJavaObject, System.IDisposable {
	// properties
	public virtual Android.Content.Res.ColorStateList SupportCompoundDrawablesTintList { get; set; }
	public virtual Android.Graphics.PorterDuff.Mode SupportCompoundDrawablesTintMode { get; set; }
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
public AppCompatActivity (int contentLayoutId);
```

Added interfaces:

```csharp
AndroidX.Activity.IOnBackPressedDispatcherOwner
AndroidX.Core.View.KeyEventDispatcher.IComponent
AndroidX.SavedState.ISavedStateRegistryOwner
```

Added method:

```csharp
protected virtual void OnNightModeChanged (int mode);
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
public virtual int LocalNightMode { get; }
```

Added methods:

```csharp
public virtual void AttachBaseContext (Android.Content.Context context);
public static AppCompatDelegate Create (Android.Content.Context context, Android.App.Activity activity, IAppCompatCallback callback);
public virtual void SetTheme (int themeResId);
```


#### Type Changed: AndroidX.AppCompat.App.AppCompatDialogFragment

Added interface:

```csharp
AndroidX.SavedState.ISavedStateRegistryOwner
```


#### Type Changed: AndroidX.AppCompat.App.AppCompatViewInflater

Added method:

```csharp
protected virtual AndroidX.AppCompat.Widget.AppCompatToggleButton CreateToggleButton (Android.Content.Context context, Android.Util.IAttributeSet attrs);
```



### Namespace AndroidX.MediaRouter.App

#### Type Changed: AndroidX.MediaRouter.App.MediaRouteActionProvider

Added methods:

```csharp
public virtual void EnableDynamicGroup ();
public virtual void SetAlwaysVisible (bool alwaysVisible);
```


#### Type Changed: AndroidX.MediaRouter.App.MediaRouteButton

Added methods:

```csharp
public virtual void EnableDynamicGroup ();
public virtual void SetAlwaysVisible (bool alwaysVisible);
```


#### Type Changed: AndroidX.MediaRouter.App.MediaRouteChooserDialog

Removed method:

```csharp
public virtual void OnFilterRoutes (System.Collections.Generic.IList<Android.Support.V7.Media.MediaRouter.RouteInfo> routes);
```

Added method:

```csharp
public virtual void OnFilterRoutes (System.Collections.Generic.IList<AndroidX.MediaRouter.Media.MediaRouter.RouteInfo> routes);
```

#### Type Changed: AndroidX.MediaRouter.App.MediaRouteChooserDialog.RouteComparator

Added method:

```csharp
public int Compare (AndroidX.MediaRouter.Media.MediaRouter.RouteInfo lhs, AndroidX.MediaRouter.Media.MediaRouter.RouteInfo rhs);
```



#### Type Changed: AndroidX.MediaRouter.App.MediaRouteChooserDialogFragment

Added interface:

```csharp
AndroidX.SavedState.ISavedStateRegistryOwner
```

Removed method:

```csharp
public virtual Android.Support.V7.App.MediaRouteDevicePickerDialog OnCreateDevicePickerDialog (Android.Content.Context context);
```

Added method:

```csharp
public virtual MediaRouteDynamicChooserDialog OnCreateDynamicChooserDialog (Android.Content.Context context);
```


#### Type Changed: AndroidX.MediaRouter.App.MediaRouteControllerDialogFragment

Added interface:

```csharp
AndroidX.SavedState.ISavedStateRegistryOwner
```

Removed method:

```csharp
public virtual Android.Support.V7.App.MediaRouteCastDialog OnCreateCastDialog (Android.Content.Context context);
```

Added method:

```csharp
public virtual MediaRouteDynamicControllerDialog OnCreateDynamicControllerDialog (Android.Content.Context context);
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
		public int Compare (Java.Lang.Object lhs, Java.Lang.Object rhs);
	}
}
```

#### New Type: AndroidX.MediaRouter.App.MediaRouteDynamicChooserDialog

```csharp
public class MediaRouteDynamicChooserDialog : AndroidX.AppCompat.App.AppCompatDialog, Android.Runtime.IJavaObject, AndroidX.AppCompat.App.IAppCompatCallback, System.IDisposable {
	// constructors
	public MediaRouteDynamicChooserDialog (Android.Content.Context context);
	public MediaRouteDynamicChooserDialog (Android.Content.Context context, int theme);
	protected MediaRouteDynamicChooserDialog (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
	// properties
	public virtual AndroidX.MediaRouter.Media.MediaRouteSelector RouteSelector { get; set; }
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public virtual bool OnFilterRoute (AndroidX.MediaRouter.Media.MediaRouter.RouteInfo route);
	public virtual void OnFilterRoutes (System.Collections.Generic.IList<AndroidX.MediaRouter.Media.MediaRouter.RouteInfo> routes);
	public virtual void RefreshRoutes ();

	// inner types
	public sealed class RouteComparator : Java.Lang.Object, Android.Runtime.IJavaObject, Java.Util.IComparator, System.IDisposable {
		// properties
		public static MediaRouteDynamicChooserDialog.RouteComparator SInstance { get; }
		protected override IntPtr ThresholdClass { get; }
		protected override System.Type ThresholdType { get; }
		// methods
		public int Compare (AndroidX.MediaRouter.Media.MediaRouter.RouteInfo lhs, AndroidX.MediaRouter.Media.MediaRouter.RouteInfo rhs);
		public virtual int Compare (Java.Lang.Object lhs, Java.Lang.Object rhs);
	}
}
```

#### New Type: AndroidX.MediaRouter.App.MediaRouteDynamicControllerDialog

```csharp
public class MediaRouteDynamicControllerDialog : AndroidX.AppCompat.App.AppCompatDialog, Android.Runtime.IJavaObject, AndroidX.AppCompat.App.IAppCompatCallback, System.IDisposable {
	// constructors
	public MediaRouteDynamicControllerDialog (Android.Content.Context context);
	public MediaRouteDynamicControllerDialog (Android.Content.Context context, int theme);
	protected MediaRouteDynamicControllerDialog (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
	// properties
	public virtual Android.Support.V4.Media.Session.MediaSessionCompat.Token MediaSession { get; }
	public virtual AndroidX.MediaRouter.Media.MediaRouteSelector RouteSelector { get; set; }
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public virtual bool OnFilterRoute (AndroidX.MediaRouter.Media.MediaRouter.RouteInfo route);
	public virtual void OnFilterRoutes (System.Collections.Generic.IList<AndroidX.MediaRouter.Media.MediaRouter.RouteInfo> routes);

	// inner types
	public sealed class RouteComparator : Java.Lang.Object, Android.Runtime.IJavaObject, Java.Util.IComparator, System.IDisposable {
		// properties
		protected override IntPtr ThresholdClass { get; }
		protected override System.Type ThresholdType { get; }
		// methods
		public int Compare (AndroidX.MediaRouter.Media.MediaRouter.RouteInfo lhs, AndroidX.MediaRouter.Media.MediaRouter.RouteInfo rhs);
		public virtual int Compare (Java.Lang.Object lhs, Java.Lang.Object rhs);
	}
}
```


### Namespace AndroidX.Palette.Graphics

#### Type Changed: AndroidX.Palette.Graphics.Palette

Modified properties:

```diff
-public System.Collections.Generic.IList<Android.Support.V7.Graphics.Palette.Swatch> Swatches { get; }
+public System.Collections.Generic.IList<Palette.Swatch> Swatches { get; }
-public System.Collections.Generic.IList<Android.Support.V7.Graphics.Target> Targets { get; }
+public System.Collections.Generic.IList<Target> Targets { get; }
```

Removed method:

```csharp
public static Palette From (System.Collections.Generic.IList<Android.Support.V7.Graphics.Palette.Swatch> swatches);
```

Added method:

```csharp
public static Palette From (System.Collections.Generic.IList<Palette.Swatch> swatches);
```

#### Type Changed: AndroidX.Palette.Graphics.Palette.Builder

Removed constructor:

```csharp
public Palette.Builder (System.Collections.Generic.IList<Android.Support.V7.Graphics.Palette.Swatch> swatches);
```

Added constructor:

```csharp
public Palette.Builder (System.Collections.Generic.IList<Palette.Swatch> swatches);
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
public override void SetAlpha (int p0);
```

Modified methods:

```diff
-public virtual void InvalidateDrawable (Android.Graphics.Drawables.Drawable p0)
+public override void InvalidateDrawable (Android.Graphics.Drawables.Drawable p0)
-public virtual void ScheduleDrawable (Android.Graphics.Drawables.Drawable p0, Java.Lang.IRunnable p1, long p2)
+public override void ScheduleDrawable (Android.Graphics.Drawables.Drawable p0, Java.Lang.IRunnable p1, long p2)
-public virtual void SetEnterFadeDuration (int p0)
+public override void SetEnterFadeDuration (int p0)
-public virtual void SetExitFadeDuration (int p0)
+public override void SetExitFadeDuration (int p0)
-public virtual void UnscheduleDrawable (Android.Graphics.Drawables.Drawable p0, Java.Lang.IRunnable p1)
+public override void UnscheduleDrawable (Android.Graphics.Drawables.Drawable p0, Java.Lang.IRunnable p1)
```


#### New Type: AndroidX.AppCompat.Graphics.Drawable.DrawableContainer

```csharp
public class DrawableContainer : Android.Graphics.Drawables.Drawable, Android.Graphics.Drawables.Drawable.ICallback, Android.Runtime.IJavaObject, System.IDisposable {
	// constructors
	protected DrawableContainer (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
	// properties
	public override int Opacity { get; }
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public override void Draw (Android.Graphics.Canvas canvas);
	public override Android.Graphics.Drawables.Drawable.ConstantState GetConstantState ();
	public virtual void InvalidateDrawable (Android.Graphics.Drawables.Drawable who);
	public virtual void ScheduleDrawable (Android.Graphics.Drawables.Drawable who, Java.Lang.IRunnable what, long when);
	public override void SetAlpha (int alpha);
	public override void SetColorFilter (Android.Graphics.ColorFilter colorFilter);
	public virtual void SetEnterFadeDuration (int ms);
	public virtual void SetExitFadeDuration (int ms);
	public virtual void UnscheduleDrawable (Android.Graphics.Drawables.Drawable who, Java.Lang.IRunnable what);

	// inner types
	public class BlockInvalidateCallback : Java.Lang.Object, Android.Graphics.Drawables.Drawable.ICallback, Android.Runtime.IJavaObject, System.IDisposable {
		// constructors
		protected DrawableContainer.BlockInvalidateCallback (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
		// properties
		protected override IntPtr ThresholdClass { get; }
		protected override System.Type ThresholdType { get; }
		// methods
		public virtual void InvalidateDrawable (Android.Graphics.Drawables.Drawable who);
		public virtual void ScheduleDrawable (Android.Graphics.Drawables.Drawable who, Java.Lang.IRunnable what, long when);
		public virtual void UnscheduleDrawable (Android.Graphics.Drawables.Drawable who, Java.Lang.IRunnable what);
		public virtual Android.Graphics.Drawables.Drawable.ICallback Unwrap ();
		public virtual Java.Lang.Object Wrap (Android.Graphics.Drawables.Drawable.ICallback callback);
	}
	public abstract class DrawableContainerState : Android.Graphics.Drawables.Drawable+ConstantState {
		// constructors
		protected DrawableContainer.DrawableContainerState (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
		// properties
		public override Android.Content.PM.ConfigChanges ChangingConfigurations { get; }
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
		protected override IntPtr ThresholdClass { get; }
		protected override System.Type ThresholdType { get; }
		// methods
		public int AddChild (Android.Graphics.Drawables.Drawable dr);
		public virtual bool CanConstantState ();
		protected virtual void ComputeConstantSize ();
		public Android.Graphics.Drawables.Drawable GetChild (int index);
		public virtual void GrowArray (int oldSize, int newSize);
		public void SetVariablePadding (bool variable);
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
public MediaRouteDescriptor.Builder RemoveGroupMemberId (string memberRouteId);
public MediaRouteDescriptor.Builder SetIsDynamicGroupRoute (bool isDynamicGroupRoute);
```



#### Type Changed: AndroidX.MediaRouter.Media.MediaRouteProvider

Added method:

```csharp
public virtual MediaRouteProvider.DynamicGroupRouteController OnCreateDynamicGroupRouteController (string initialMemberRouteId);
```

#### New Type: AndroidX.MediaRouter.Media.MediaRouteProvider.DynamicGroupRouteController

```csharp
public abstract class DynamicGroupRouteController : AndroidX.MediaRouter.Media.MediaRouteProvider+RouteController {
	// constructors
	public MediaRouteProvider.DynamicGroupRouteController ();
	protected MediaRouteProvider.DynamicGroupRouteController (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
	// properties
	public virtual string GroupableSelectionTitle { get; }
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	public virtual string TransferableSectionTitle { get; }
	// methods
	public void NotifyDynamicRoutesChanged (System.Collections.Generic.ICollection<MediaRouteProvider.DynamicGroupRouteController.DynamicRouteDescriptor> routes);
	public virtual void OnAddMemberRoute (string p0);
	public virtual void OnRemoveMemberRoute (string p0);
	public virtual void OnUpdateMemberRoutes (System.Collections.Generic.IList<string> p0);

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
		protected override IntPtr ThresholdClass { get; }
		protected override System.Type ThresholdType { get; }

		// inner types
		public sealed class Builder : Java.Lang.Object {
			// constructors
			public MediaRouteProvider.DynamicGroupRouteController.DynamicRouteDescriptor.Builder (MediaRouteDescriptor descriptor);
			public MediaRouteProvider.DynamicGroupRouteController.DynamicRouteDescriptor.Builder (MediaRouteProvider.DynamicGroupRouteController.DynamicRouteDescriptor dynamicRouteDescriptor);
			// properties
			protected override IntPtr ThresholdClass { get; }
			protected override System.Type ThresholdType { get; }
			// methods
			public MediaRouteProvider.DynamicGroupRouteController.DynamicRouteDescriptor Build ();
			public MediaRouteProvider.DynamicGroupRouteController.DynamicRouteDescriptor.Builder SetIsGroupable (bool value);
			public MediaRouteProvider.DynamicGroupRouteController.DynamicRouteDescriptor.Builder SetIsTransferable (bool value);
			public MediaRouteProvider.DynamicGroupRouteController.DynamicRouteDescriptor.Builder SetIsUnselectable (bool value);
			public MediaRouteProvider.DynamicGroupRouteController.DynamicRouteDescriptor.Builder SetSelectionState (int state);
		}
		public interface ISelectionState : Android.Runtime.IJavaObject, Java.Lang.Annotation.IAnnotation, System.IDisposable {
		}
	}
}
```


#### Type Changed: AndroidX.MediaRouter.Media.MediaRouteProviderDescriptor

Modified properties:

```diff
-public System.Collections.Generic.IList<Android.Support.V7.Media.MediaRouteDescriptor> Routes { get; }
+public System.Collections.Generic.IList<MediaRouteDescriptor> Routes { get; }
```

Added method:

```csharp
public bool SupportsDynamicGroupRoute ();
```

#### Type Changed: AndroidX.MediaRouter.Media.MediaRouteProviderDescriptor.Builder

Removed method:

```csharp
public MediaRouteProviderDescriptor.Builder AddRoutes (System.Collections.Generic.ICollection<Android.Support.V7.Media.MediaRouteDescriptor> routes);
```

Added methods:

```csharp
public MediaRouteProviderDescriptor.Builder AddRoutes (System.Collections.Generic.ICollection<MediaRouteDescriptor> routes);
public MediaRouteProviderDescriptor.Builder SetSupportsDynamicGroupRoute (bool value);
```



#### Type Changed: AndroidX.MediaRouter.Media.MediaRouter

Modified properties:

```diff
-public System.Collections.Generic.IList<Android.Support.V7.Media.MediaRouter.ProviderInfo> Providers { get; }
+public System.Collections.Generic.IList<MediaRouter.ProviderInfo> Providers { get; }
-public System.Collections.Generic.IList<Android.Support.V7.Media.MediaRouter.RouteInfo> Routes { get; }
+public System.Collections.Generic.IList<MediaRouter.RouteInfo> Routes { get; }
```

Added methods:

```csharp
public void AddMemberToDynamicGroup (MediaRouter.RouteInfo route);
public void RemoveMemberFromDynamicGroup (MediaRouter.RouteInfo route);
```

#### Type Changed: AndroidX.MediaRouter.Media.MediaRouter.ProviderInfo

Modified properties:

```diff
-public System.Collections.Generic.IList<Android.Support.V7.Media.MediaRouter.RouteInfo> Routes { get; }
+public System.Collections.Generic.IList<MediaRouter.RouteInfo> Routes { get; }
```


#### Type Changed: AndroidX.MediaRouter.Media.MediaRouter.RouteInfo

Obsoleted properties:

```diff
 [Obsolete ("deprecated")]
 public virtual bool IsConnecting { get; }
```

Added properties:

```csharp
public virtual MediaRouteProvider.DynamicGroupRouteController DynamicGroupController { get; }
public virtual bool IsGroup { get; }
public virtual System.Collections.Generic.IList<MediaRouter.RouteInfo> MemberRoutes { get; }
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
public virtual void AddListListener (AsyncListDiffer.IListListener listener);
public virtual void RemoveListListener (AsyncListDiffer.IListListener listener);
public virtual void SubmitList (System.Collections.IList newList, Java.Lang.IRunnable commitCallback);
```


#### Type Changed: AndroidX.RecyclerView.Widget.ListAdapter

Added property:

```csharp
public virtual System.Collections.IList CurrentList { get; }
```

Added methods:

```csharp
public virtual void OnCurrentListChanged (System.Collections.IList previousList, System.Collections.IList currentList);
public virtual void SubmitList (System.Collections.IList list, Java.Lang.IRunnable commitCallback);
```


#### Type Changed: AndroidX.RecyclerView.Widget.DividerItemDecoration

Added property:

```csharp
public virtual Android.Graphics.Drawables.Drawable Drawable { get; set; }
```

Removed method:

```csharp
public virtual void SetDrawable (Android.Graphics.Drawables.Drawable drawable);
```


#### Type Changed: AndroidX.RecyclerView.Widget.GridLayoutManager

Added property:

```csharp
public virtual bool UsingSpansToEstimateScrollbarDimensions { get; set; }
```

#### Type Changed: AndroidX.RecyclerView.Widget.GridLayoutManager.SpanSizeLookup

Added property:

```csharp
public virtual bool SpanGroupIndexCacheEnabled { get; set; }
```

Added method:

```csharp
public virtual void InvalidateSpanGroupIndexCache ();
```



#### Type Changed: AndroidX.RecyclerView.Widget.LinearLayoutManager

Obsoleted methods:

```diff
 [Obsolete ("deprecated")]
 protected virtual int GetExtraLayoutSpace (RecyclerView.State state);
```

Added method:

```csharp
protected virtual void CalculateExtraLayoutSpace (RecyclerView.State state, int[] extraLayoutSpace);
```


#### Type Changed: AndroidX.RecyclerView.Widget.RecyclerView

Modified constructors:

```diff
-public RecyclerView (Android.Content.Context context, Android.Util.IAttributeSet attrs, int defStyle)
+public RecyclerView (Android.Content.Context context, Android.Util.IAttributeSet attrs, int defStyleAttr)
```

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
 public virtual bool LayoutFrozen { get; set; }
```

Added property:

```csharp
public bool IsLayoutSuppressed { get; }
```

Added methods:

```csharp
public virtual void DispatchNestedScroll (int dxConsumed, int dyConsumed, int dxUnconsumed, int dyUnconsumed, int[] offsetInWindow, int type, int[] consumed);
public virtual void SmoothScrollBy (int dx, int dy, Android.Views.Animations.IInterpolator interpolator, int duration);
public void SuppressLayout (bool suppress);
```

#### Type Changed: AndroidX.RecyclerView.Widget.RecyclerView.Adapter

Modified properties:

```diff
 public bool HasStableIds { get; ---set;--- }
```

Added method:

```csharp
public virtual void SetHasStableIds (bool hasStableIds);
```


#### Type Changed: AndroidX.RecyclerView.Widget.RecyclerView.Recycler

Modified properties:

```diff
-public System.Collections.Generic.IList<Android.Support.V7.Widget.RecyclerView.ViewHolder> ScrapList { get; }
+public System.Collections.Generic.IList<RecyclerView.ViewHolder> ScrapList { get; }
```


#### Type Changed: AndroidX.RecyclerView.Widget.RecyclerView.ViewFlinger

Removed methods:

```csharp
public virtual void SmoothScrollBy (int dx, int dy);
public virtual void SmoothScrollBy (int dx, int dy, Android.Views.Animations.IInterpolator interpolator);
public virtual void SmoothScrollBy (int dx, int dy, int duration);
public virtual void SmoothScrollBy (int dx, int dy, int vx, int vy);
```



#### Type Changed: AndroidX.RecyclerView.Widget.IItemTouchUIUtil

Modified methods:

```diff
-public abstract void ClearView (Android.Views.View view)
+public abstract void ClearView (Android.Views.View p0)
-public abstract void OnDraw (Android.Graphics.Canvas c, RecyclerView recyclerView---p1---, Android.Views.View view---p2---, float dX---p3---, float dY---p4---, int actionState---p5---, bool isCurrentlyActive---p6---)
+public abstract void OnDraw (Android.Graphics.Canvas p0, RecyclerView +++recyclerView+++p1, Android.Views.View +++view+++p2, float +++dX+++p3, float +++dY+++p4, int +++actionState+++p5, bool +++isCurrentlyActive+++p6)
-public abstract void OnDrawOver (Android.Graphics.Canvas c, RecyclerView recyclerView---p1---, Android.Views.View view---p2---, float dX---p3---, float dY---p4---, int actionState---p5---, bool isCurrentlyActive---p6---)
+public abstract void OnDrawOver (Android.Graphics.Canvas p0, RecyclerView +++recyclerView+++p1, Android.Views.View +++view+++p2, float +++dX+++p3, float +++dY+++p4, int +++actionState+++p5, bool +++isCurrentlyActive+++p6)
-public abstract void OnSelected (Android.Views.View view)
+public abstract void OnSelected (Android.Views.View p0)
```


#### Type Changed: AndroidX.RecyclerView.Widget.ItemTouchHelper

#### Type Changed: AndroidX.RecyclerView.Widget.ItemTouchHelper.Callback

Removed method:

```csharp
public virtual RecyclerView.ViewHolder ChooseDropTarget (RecyclerView.ViewHolder selected, System.Collections.Generic.IList<Android.Support.V7.Widget.RecyclerView.ViewHolder> dropTargets, int curX, int curY);
```

Modified methods:

```diff
-public abstract bool OnMove (RecyclerView recyclerView, RecyclerView.ViewHolder viewHolder---p1---, RecyclerView.ViewHolder target---p2---)
+public abstract bool OnMove (RecyclerView p0, RecyclerView.ViewHolder +++viewHolder+++p1, RecyclerView.ViewHolder +++target+++p2)
-public abstract void OnSwiped (RecyclerView.ViewHolder viewHolder, int direction---p1---)
+public abstract void OnSwiped (RecyclerView.ViewHolder p0, int +++direction+++p1)
```

Added method:

```csharp
public virtual RecyclerView.ViewHolder ChooseDropTarget (RecyclerView.ViewHolder selected, System.Collections.Generic.IList<RecyclerView.ViewHolder> dropTargets, int curX, int curY);
```


#### Type Changed: AndroidX.RecyclerView.Widget.ItemTouchHelper.IViewDropHandler

Modified methods:

```diff
-public abstract void PrepareForDrop (Android.Views.View view, Android.Views.View target---p1---, int x---p2---, int y---p3---)
+public abstract void PrepareForDrop (Android.Views.View p0, Android.Views.View +++target+++p1, int +++x+++p2, int +++y+++p3)
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


#### Type Changed: AndroidX.AppCompat.View.Menu.MenuBuilder

Modified properties:

```diff
-public virtual System.Collections.Generic.IList<Android.Support.V7.View.Menu.MenuItemImpl> ActionItems { get; }
+public virtual System.Collections.Generic.IList<MenuItemImpl> ActionItems { get; }
-public virtual System.Collections.Generic.IList<Android.Support.V7.View.Menu.MenuItemImpl> NonActionItems { get; }
+public virtual System.Collections.Generic.IList<MenuItemImpl> NonActionItems { get; }
-public virtual System.Collections.Generic.IList<Android.Support.V7.View.Menu.MenuItemImpl> VisibleItems { get; }
+public virtual System.Collections.Generic.IList<MenuItemImpl> VisibleItems { get; }
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
	public MenuWrapperICS (Android.Content.Context context, AndroidX.Core.Internal.View.ISupportMenu object);
	protected MenuWrapperICS (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
	// properties
	public virtual bool HasVisibleItems { get; }
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public virtual Android.Views.IMenuItem Add (Java.Lang.ICharSequence title);
	public virtual Android.Views.IMenuItem Add (int titleRes);
	public Android.Views.IMenuItem Add (string title);
	public virtual Android.Views.IMenuItem Add (int groupId, int itemId, int order, Java.Lang.ICharSequence title);
	public virtual Android.Views.IMenuItem Add (int groupId, int itemId, int order, int titleRes);
	public Android.Views.IMenuItem Add (int groupId, int itemId, int order, string title);
	public virtual int AddIntentOptions (int groupId, int itemId, int order, Android.Content.ComponentName caller, Android.Content.Intent[] specifics, Android.Content.Intent intent, Android.Views.MenuAppendFlags flags, Android.Views.IMenuItem[] outSpecificItems);
	public virtual Android.Views.ISubMenu AddSubMenu (Java.Lang.ICharSequence title);
	public virtual Android.Views.ISubMenu AddSubMenu (int titleRes);
	public Android.Views.ISubMenu AddSubMenu (string title);
	public virtual Android.Views.ISubMenu AddSubMenu (int groupId, int itemId, int order, Java.Lang.ICharSequence title);
	public virtual Android.Views.ISubMenu AddSubMenu (int groupId, int itemId, int order, int titleRes);
	public Android.Views.ISubMenu AddSubMenu (int groupId, int itemId, int order, string title);
	public virtual void Clear ();
	public virtual void Close ();
	public virtual Android.Views.IMenuItem FindItem (int id);
	public virtual Android.Views.IMenuItem GetItem (int index);
	public virtual bool IsShortcutKey (Android.Views.Keycode keyCode, Android.Views.KeyEvent e);
	public virtual bool PerformIdentifierAction (int id, Android.Views.MenuPerformFlags flags);
	public virtual bool PerformShortcut (Android.Views.Keycode keyCode, Android.Views.KeyEvent e, Android.Views.MenuPerformFlags flags);
	public virtual void RemoveGroup (int groupId);
	public virtual void RemoveItem (int id);
	public virtual void SetGroupCheckable (int group, bool checkable, bool exclusive);
	public virtual void SetGroupEnabled (int group, bool enabled);
	public virtual void SetGroupVisible (int group, bool visible);
	public virtual void SetQwertyMode (bool isQwerty);
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
public virtual void OnNestedPreScroll (Android.Views.View target, int dx, int dy, int[] consumed, int type);
public virtual void OnNestedScroll (Android.Views.View target, int dxConsumed, int dyConsumed, int dxUnconsumed, int dyUnconsumed, int type);
public virtual void OnNestedScroll (Android.Views.View target, int dxConsumed, int dyConsumed, int dxUnconsumed, int dyUnconsumed, int type, int[] consumed);
public virtual void OnNestedScrollAccepted (Android.Views.View child, Android.Views.View target, int axes, int type);
public virtual bool OnStartNestedScroll (Android.Views.View child, Android.Views.View target, int axes, int type);
public virtual void OnStopNestedScroll (Android.Views.View target, int type);
```


#### Type Changed: AndroidX.AppCompat.Widget.AppCompatCheckBox

Added interface:

```csharp
AndroidX.Core.View.ITintableBackgroundView
```

Added properties:

```csharp
public virtual Android.Content.Res.ColorStateList SupportBackgroundTintList { get; set; }
public virtual Android.Graphics.PorterDuff.Mode SupportBackgroundTintMode { get; set; }
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
public virtual Android.Content.Res.ColorStateList SupportBackgroundTintList { get; set; }
public virtual Android.Graphics.PorterDuff.Mode SupportBackgroundTintMode { get; set; }
```


#### Type Changed: AndroidX.AppCompat.Widget.AppCompatTextView

Added interface:

```csharp
AndroidX.Core.Widget.ITintableCompoundDrawablesView
```

Added properties:

```csharp
public virtual Android.Content.Res.ColorStateList SupportCompoundDrawablesTintList { get; set; }
public virtual Android.Graphics.PorterDuff.Mode SupportCompoundDrawablesTintMode { get; set; }
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
public virtual Android.Graphics.Rect EpicenterBounds { get; set; }
```

Removed method:

```csharp
public virtual void SetEpicenterBounds (Android.Graphics.Rect bounds);
```


#### Type Changed: AndroidX.AppCompat.Widget.Toolbar

Added properties:

```csharp
public string CollapseContentDescription { get; set; }
public virtual Java.Lang.ICharSequence CollapseContentDescriptionFormatted { get; set; }
public virtual Android.Graphics.Drawables.Drawable CollapseIcon { get; set; }
```

Added methods:

```csharp
public virtual void SetCollapseContentDescription (int resId);
public virtual void SetCollapseIcon (int resId);
public virtual void SetSubtitleTextColor (Android.Content.Res.ColorStateList color);
public virtual void SetTitleTextColor (Android.Content.Res.ColorStateList color);
```


#### New Type: AndroidX.AppCompat.Widget.AppCompatSpinnerISpinnerPopupExtensions

```csharp
public static class AppCompatSpinnerISpinnerPopupExtensions {
	// methods
	public static void SetPromptText (this AppCompatSpinner.ISpinnerPopup self, string p0);
}
```

#### New Type: AndroidX.AppCompat.Widget.AppCompatToggleButton

```csharp
public class AppCompatToggleButton : Android.Widget.ToggleButton {
	// constructors
	public AppCompatToggleButton (Android.Content.Context context);
	public AppCompatToggleButton (Android.Content.Context context, Android.Util.IAttributeSet attrs);
	protected AppCompatToggleButton (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
	public AppCompatToggleButton (Android.Content.Context context, Android.Util.IAttributeSet attrs, int defStyleAttr);
	// properties
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
}
```

#### New Type: AndroidX.AppCompat.Widget.ResourceManagerInternal

```csharp
public sealed class ResourceManagerInternal : Java.Lang.Object {
	// constructors
	public ResourceManagerInternal ();
	// properties
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public static ResourceManagerInternal Get ();
	public Android.Graphics.Drawables.Drawable GetDrawable (Android.Content.Context context, int resId);
	public static Android.Graphics.PorterDuffColorFilter GetPorterDuffColorFilter (int color, Android.Graphics.PorterDuff.Mode mode);
	public void OnConfigurationChanged (Android.Content.Context context);

	// inner types
	public class AsldcInflateDelegate : Java.Lang.Object {
		// constructors
		protected ResourceManagerInternal.AsldcInflateDelegate (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
		// properties
		protected override IntPtr ThresholdClass { get; }
		protected override System.Type ThresholdType { get; }
		// methods
		public virtual Android.Graphics.Drawables.Drawable CreateFromXmlInner (Android.Content.Context context, System.Xml.XmlReader parser, Android.Util.IAttributeSet attrs, Android.Content.Res.Resources.Theme theme);
	}
	public interface IResourceManagerHooks : Android.Runtime.IJavaObject, System.IDisposable {
		// methods
		public virtual Android.Graphics.Drawables.Drawable CreateDrawableFor (ResourceManagerInternal p0, Android.Content.Context p1, int p2);
		public virtual Android.Content.Res.ColorStateList GetTintListForDrawableRes (Android.Content.Context p0, int p1);
		public virtual Android.Graphics.PorterDuff.Mode GetTintModeForDrawableRes (int p0);
		public virtual bool TintDrawable (Android.Content.Context p0, int p1, Android.Graphics.Drawables.Drawable p2);
		public virtual bool TintDrawableUsingColorFilter (Android.Content.Context p0, int p1, Android.Graphics.Drawables.Drawable p2);
	}
}
```

#### New Type: AndroidX.AppCompat.Widget.TintInfo

```csharp
public class TintInfo : Java.Lang.Object {
	// constructors
	public TintInfo ();
	protected TintInfo (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
	// properties
	public bool MHasTintList { get; set; }
	public bool MHasTintMode { get; set; }
	public Android.Content.Res.ColorStateList MTintList { get; set; }
	public Android.Graphics.PorterDuff.Mode MTintMode { get; set; }
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
}
```


### Namespace AndroidX.GridLayout.Widget

#### Type Changed: AndroidX.GridLayout.Widget.GridLayout

#### Type Changed: AndroidX.GridLayout.Widget.GridLayout.Axis

Modified properties:

```diff
-public System.Collections.Generic.IList<Android.Support.V7.Widget.GridLayout.Arc> Arcs { get; set; }
+public System.Collections.Generic.IList<GridLayout.Arc> Arcs { get; set; }
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

#### Type Changed: AndroidX.Wear.Widget.WearableLinearLayoutManager

#### Type Changed: AndroidX.Wear.Widget.WearableLinearLayoutManager.LayoutCallback

Modified methods:

```diff
-public abstract void OnLayoutFinished (Android.Views.View child, AndroidX.RecyclerView.Widget.RecyclerView parent---p1---)
+public abstract void OnLayoutFinished (Android.Views.View p0, AndroidX.RecyclerView.Widget.RecyclerView +++parent+++p1)
```



#### Type Changed: AndroidX.Wear.Widget.WearableRecyclerView

Added interface:

```csharp
AndroidX.Core.View.INestedScrollingChild3
```



### Namespace AndroidX.Slice.Widget

#### Type Changed: AndroidX.Slice.Widget.LargeSliceAdapter

Removed method:

```csharp
public virtual void OnBindViewHolder (int position);
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
public static Java.Lang.Object GetVersionedParcelable (Android.OS.Bundle bundle, string key);
public static System.Collections.IList GetVersionedParcelableList (Android.OS.Bundle bundle, string key);
public static void PutVersionedParcelable (Android.OS.Bundle b, string key, IVersionedParcelable obj);
public static void PutVersionedParcelableList (Android.OS.Bundle b, string key, System.Collections.Generic.IList<IVersionedParcelable> list);
```


#### Type Changed: AndroidX.VersionedParcelable.VersionedParcel

Removed constructor:

```csharp
public VersionedParcel ();
```

Added constructor:

```csharp
public VersionedParcel (AndroidX.Collection.ArrayMap readCache, AndroidX.Collection.ArrayMap writeCache, AndroidX.Collection.ArrayMap parcelizerCache);
```

Added properties:

```csharp
protected AndroidX.Collection.ArrayMap MParcelizerCache { get; set; }
protected AndroidX.Collection.ArrayMap MReadCache { get; set; }
protected AndroidX.Collection.ArrayMap MWriteCache { get; set; }
```

Modified methods:

```diff
 ---static--- protected ---virtual--- Java.Lang.Object ReadFromParcel (string parcelCls, VersionedParcel versionedParcel)
 ---static--- protected ---virtual--- void WriteToParcel (Java.Lang.Object val, VersionedParcel versionedParcel)
```

Added methods:

```csharp
protected string ReadCharSequence ();
public string ReadCharSequence (string def, int fieldId);
protected virtual Java.Lang.ICharSequence ReadCharSequenceFormatted ();
public virtual Java.Lang.ICharSequence ReadCharSequenceFormatted (Java.Lang.ICharSequence def, int fieldId);
public virtual System.Collections.IDictionary ReadMap (System.Collections.IDictionary def, int fieldId);
protected virtual void WriteCharSequence (Java.Lang.ICharSequence p0);
protected void WriteCharSequence (string p0);
public virtual void WriteCharSequence (Java.Lang.ICharSequence val, int fieldId);
public void WriteCharSequence (string val, int fieldId);
public virtual void WriteMap (System.Collections.IDictionary val, int fieldId);
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

Modified methods:

```diff
-public int GetDisabledActionModeMenuItems (Android.Webkit.WebSettings webSettings)
+public int GetDisabledActionModeMenuItems (Android.Webkit.WebSettings settings)
-public bool GetOffscreenPreRaster (Android.Webkit.WebSettings webSettings)
+public bool GetOffscreenPreRaster (Android.Webkit.WebSettings settings)
-public bool GetSafeBrowsingEnabled (Android.Webkit.WebSettings webSettings)
+public bool GetSafeBrowsingEnabled (Android.Webkit.WebSettings settings)
-public void SetDisabledActionModeMenuItems (Android.Webkit.WebSettings webSettings, int menuItems)
+public void SetDisabledActionModeMenuItems (Android.Webkit.WebSettings settings, int menuItems)
-public void SetOffscreenPreRaster (Android.Webkit.WebSettings webSettings, bool enabled)
+public void SetOffscreenPreRaster (Android.Webkit.WebSettings settings, bool enabled)
-public void SetSafeBrowsingEnabled (Android.Webkit.WebSettings webSettings, bool enabled)
+public void SetSafeBrowsingEnabled (Android.Webkit.WebSettings settings, bool enabled)
```

Added methods:

```csharp
public static int GetForceDark (Android.Webkit.WebSettings settings);
public static void SetForceDark (Android.Webkit.WebSettings settings, int forceDarkMode);
public static void SetWillSuppressErrorPage (Android.Webkit.WebSettings settings, bool suppressed);
public static bool WillSuppressErrorPage (Android.Webkit.WebSettings settings);
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
public static Android.Webkit.WebChromeClient GetWebChromeClient (Android.Webkit.WebView webview);
public static Android.Webkit.WebViewClient GetWebViewClient (Android.Webkit.WebView webview);
public static WebViewRenderProcess GetWebViewRenderProcess (Android.Webkit.WebView webview);
public static WebViewRenderProcessClient GetWebViewRenderProcessClient (Android.Webkit.WebView webview);
public static void SetWebViewRenderProcessClient (Android.Webkit.WebView webview, WebViewRenderProcessClient webViewRenderProcessClient);
public static void SetWebViewRenderProcessClient (Android.Webkit.WebView webview, Java.Util.Concurrent.IExecutor executor, WebViewRenderProcessClient webViewRenderProcessClient);
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
	public ProxyConfig (System.Collections.Generic.IList<ProxyConfig.ProxyRule> proxyRules, System.Collections.Generic.IList<string> bypassRules);
	// fields
	public static const string MatchAllSchemes = "*";
	public static const string MatchHttp = "http";
	public static const string MatchHttps = "https";
	// properties
	public System.Collections.Generic.IList<string> BypassRules { get; }
	public System.Collections.Generic.IList<ProxyConfig.ProxyRule> ProxyRules { get; }
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }

	// inner types
	public sealed class Builder : Java.Lang.Object {
		// constructors
		public ProxyConfig.Builder ();
		public ProxyConfig.Builder (ProxyConfig proxyConfig);
		// properties
		protected override IntPtr ThresholdClass { get; }
		protected override System.Type ThresholdType { get; }
		// methods
		public ProxyConfig.Builder AddBypassRule (string bypassRule);
		public ProxyConfig.Builder AddDirect ();
		public ProxyConfig.Builder AddDirect (string schemeFilter);
		public ProxyConfig.Builder AddProxyRule (string proxyUrl);
		public ProxyConfig.Builder AddProxyRule (string proxyUrl, string schemeFilter);
		public ProxyConfig Build ();
		public ProxyConfig.Builder BypassSimpleHostnames ();
		public ProxyConfig.Builder RemoveImplicitRules ();
	}
	public interface IProxyScheme : Android.Runtime.IJavaObject, Java.Lang.Annotation.IAnnotation, System.IDisposable {
	}
	public sealed class ProxyRule : Java.Lang.Object {
		// constructors
		public ProxyConfig.ProxyRule (string url);
		public ProxyConfig.ProxyRule (string schemeFilter, string url);
		// properties
		public string SchemeFilter { get; }
		protected override IntPtr ThresholdClass { get; }
		protected override System.Type ThresholdType { get; }
		public string Url { get; }
	}
}
```

#### New Type: AndroidX.WebKit.ProxyController

```csharp
public abstract class ProxyController : Java.Lang.Object {
	// constructors
	public ProxyController ();
	protected ProxyController (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
	// properties
	public static ProxyController Instance { get; }
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public virtual void ClearProxyOverride (Java.Util.Concurrent.IExecutor p0, Java.Lang.IRunnable p1);
	public virtual void SetProxyOverride (ProxyConfig p0, Java.Util.Concurrent.IExecutor p1, Java.Lang.IRunnable p2);
}
```

#### New Type: AndroidX.WebKit.TracingConfig

```csharp
public class TracingConfig : Java.Lang.Object {
	// constructors
	protected TracingConfig (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
	public TracingConfig (int predefinedCategories, System.Collections.Generic.IList<string> customIncludedCategories, int tracingMode);
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
	public virtual System.Collections.Generic.IList<string> CustomIncludedCategories { get; }
	public virtual int PredefinedCategories { get; }
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	public virtual int TracingMode { get; }

	// inner types
	public class Builder : Java.Lang.Object {
		// constructors
		public TracingConfig.Builder ();
		protected TracingConfig.Builder (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
		// properties
		protected override IntPtr ThresholdClass { get; }
		protected override System.Type ThresholdType { get; }
		// methods
		public virtual TracingConfig.Builder AddCategories (System.Collections.Generic.ICollection<string> categories);
		public virtual TracingConfig.Builder AddCategories (int[] predefinedCategories);
		public virtual TracingConfig.Builder AddCategories (string[] categories);
		public virtual TracingConfig Build ();
		public virtual TracingConfig.Builder SetTracingMode (int tracingMode);
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
	protected TracingController (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
	// properties
	public static TracingController Instance { get; }
	public virtual bool IsTracing { get; }
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public virtual void Start (TracingConfig p0);
	public virtual bool Stop (System.IO.Stream p0, Java.Util.Concurrent.IExecutor p1);
}
```

#### New Type: AndroidX.WebKit.WebViewAssetLoader

```csharp
public sealed class WebViewAssetLoader : Java.Lang.Object {
	// fields
	public static const string DefaultDomain = "appassets.androidplatform.net";
	// properties
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public Android.Webkit.WebResourceResponse ShouldInterceptRequest (Android.Net.Uri url);

	// inner types
	public sealed class AssetsPathHandler : Java.Lang.Object, Android.Runtime.IJavaObject, WebViewAssetLoader.IPathHandler, System.IDisposable {
		// constructors
		public WebViewAssetLoader.AssetsPathHandler (Android.Content.Context context);
		// properties
		protected override IntPtr ThresholdClass { get; }
		protected override System.Type ThresholdType { get; }
		// methods
		public virtual Android.Webkit.WebResourceResponse Handle (string path);
	}
	public sealed class Builder : Java.Lang.Object {
		// constructors
		public WebViewAssetLoader.Builder ();
		// properties
		protected override IntPtr ThresholdClass { get; }
		protected override System.Type ThresholdType { get; }
		// methods
		public WebViewAssetLoader.Builder AddPathHandler (string path, WebViewAssetLoader.IPathHandler handler);
		public WebViewAssetLoader Build ();
		public WebViewAssetLoader.Builder SetDomain (string domain);
		public WebViewAssetLoader.Builder SetHttpAllowed (bool httpAllowed);
	}
	public interface IPathHandler : Android.Runtime.IJavaObject, System.IDisposable {
		// methods
		public virtual Android.Webkit.WebResourceResponse Handle (string p0);
	}
	public sealed class InternalStoragePathHandler : Java.Lang.Object, Android.Runtime.IJavaObject, WebViewAssetLoader.IPathHandler, System.IDisposable {
		// constructors
		public WebViewAssetLoader.InternalStoragePathHandler (Android.Content.Context context, Java.IO.File directory);
		// properties
		protected override IntPtr ThresholdClass { get; }
		protected override System.Type ThresholdType { get; }
		// methods
		public virtual Android.Webkit.WebResourceResponse Handle (string path);
	}
	public class PathMatcher : Java.Lang.Object {
		// constructors
		protected WebViewAssetLoader.PathMatcher (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
		// properties
		protected override IntPtr ThresholdClass { get; }
		protected override System.Type ThresholdType { get; }
		// methods
		public virtual string GetSuffixPath (string path);
		public virtual WebViewAssetLoader.IPathHandler Match (Android.Net.Uri uri);
	}
	public sealed class ResourcesPathHandler : Java.Lang.Object, Android.Runtime.IJavaObject, WebViewAssetLoader.IPathHandler, System.IDisposable {
		// constructors
		public WebViewAssetLoader.ResourcesPathHandler (Android.Content.Context context);
		// properties
		protected override IntPtr ThresholdClass { get; }
		protected override System.Type ThresholdType { get; }
		// methods
		public virtual Android.Webkit.WebResourceResponse Handle (string path);
	}
}
```

#### New Type: AndroidX.WebKit.WebViewRenderProcess

```csharp
public abstract class WebViewRenderProcess : Java.Lang.Object {
	// constructors
	public WebViewRenderProcess ();
	protected WebViewRenderProcess (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
	// properties
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public virtual bool Terminate ();
}
```

#### New Type: AndroidX.WebKit.WebViewRenderProcessClient

```csharp
public abstract class WebViewRenderProcessClient : Java.Lang.Object {
	// constructors
	public WebViewRenderProcessClient ();
	protected WebViewRenderProcessClient (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
	// properties
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public virtual void OnRenderProcessResponsive (Android.Webkit.WebView p0, WebViewRenderProcess p1);
	public virtual void OnRenderProcessUnresponsive (Android.Webkit.WebView p0, WebViewRenderProcess p1);
}
```


### Namespace AndroidX.WebKit.Internal

#### Type Changed: AndroidX.WebKit.Internal.IWebViewProviderFactory

Added properties:

```csharp
public virtual AndroidX.WebKit.ChromiumLibBoundary.IProxyControllerBoundaryInterface ProxyController { get; }
public virtual AndroidX.WebKit.ChromiumLibBoundary.ITracingControllerBoundaryInterface TracingController { get; }
```


#### Type Changed: AndroidX.WebKit.Internal.IncompatibleApkWebViewProviderFactory

Added properties:

```csharp
public virtual AndroidX.WebKit.ChromiumLibBoundary.IProxyControllerBoundaryInterface ProxyController { get; }
public virtual AndroidX.WebKit.ChromiumLibBoundary.ITracingControllerBoundaryInterface TracingController { get; }
```


#### Type Changed: AndroidX.WebKit.Internal.WebSettingsAdapter

Added property:

```csharp
public virtual int ForceDark { get; set; }
```

Added methods:

```csharp
public virtual void SetWillSuppressErrorPage (bool suppressed);
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

Modified methods:

```diff
-public WebViewFeatureInternal GetFeature (string feature)
+public WebViewFeatureInternal GetFeature (string publicFeatureValue)
```


#### Type Changed: AndroidX.WebKit.Internal.WebViewProviderAdapter

Added properties:

```csharp
public virtual Android.Webkit.WebChromeClient WebChromeClient { get; }
public virtual Android.Webkit.WebViewClient WebViewClient { get; }
public virtual AndroidX.WebKit.WebViewRenderProcess WebViewRenderProcess { get; }
public virtual AndroidX.WebKit.WebViewRenderProcessClient WebViewRenderProcessClient { get; }
```

Added method:

```csharp
public virtual void SetWebViewRenderProcessClient (Java.Util.Concurrent.IExecutor executor, AndroidX.WebKit.WebViewRenderProcessClient webViewRenderProcessClient);
```


#### Type Changed: AndroidX.WebKit.Internal.WebViewProviderFactoryAdapter

Added properties:

```csharp
public virtual AndroidX.WebKit.ChromiumLibBoundary.IProxyControllerBoundaryInterface ProxyController { get; }
public virtual AndroidX.WebKit.ChromiumLibBoundary.ITracingControllerBoundaryInterface TracingController { get; }
```


#### New Type: AndroidX.WebKit.Internal.AssetHelper

```csharp
public class AssetHelper : Java.Lang.Object {
	// constructors
	public AssetHelper (Android.Content.Context context);
	protected AssetHelper (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
	// fields
	public static const string DefaultMimeType = "text/plain";
	// properties
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public static string GetCanonicalPath (Java.IO.File file);
	public static Java.IO.File GetDataDir (Android.Content.Context context);
	public static string GuessMimeType (string filePath);
	public static bool IsCanonicalChildOf (Java.IO.File parent, Java.IO.File child);
	public virtual System.IO.Stream OpenAsset (string path);
	public static System.IO.Stream OpenFile (Java.IO.File file);
	public virtual System.IO.Stream OpenResource (string path);
}
```

#### New Type: AndroidX.WebKit.Internal.ProxyControllerImpl

```csharp
public class ProxyControllerImpl : AndroidX.WebKit.ProxyController {
	// constructors
	public ProxyControllerImpl ();
	protected ProxyControllerImpl (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
	// properties
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public override void ClearProxyOverride (Java.Util.Concurrent.IExecutor executor, Java.Lang.IRunnable listener);
	public override void SetProxyOverride (AndroidX.WebKit.ProxyConfig proxyConfig, Java.Util.Concurrent.IExecutor executor, Java.Lang.IRunnable listener);
}
```

#### New Type: AndroidX.WebKit.Internal.TracingControllerImpl

```csharp
public class TracingControllerImpl : AndroidX.WebKit.TracingController {
	// constructors
	public TracingControllerImpl ();
	protected TracingControllerImpl (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
	// properties
	public override bool IsTracing { get; }
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public override void Start (AndroidX.WebKit.TracingConfig tracingConfig);
	public override bool Stop (System.IO.Stream outputStream, Java.Util.Concurrent.IExecutor executor);
}
```

#### New Type: AndroidX.WebKit.Internal.WebViewRenderProcessImpl

```csharp
public class WebViewRenderProcessImpl : AndroidX.WebKit.WebViewRenderProcess {
	// constructors
	public WebViewRenderProcessImpl (AndroidX.WebKit.ChromiumLibBoundary.IWebViewRendererBoundaryInterface boundaryInterface);
	protected WebViewRenderProcessImpl (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
	// properties
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public static WebViewRenderProcessImpl ForInvocationHandler (Java.Lang.Reflect.IInvocationHandler invocationHandler);
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
public Configuration.Builder SetTaskExecutor (Java.Util.Concurrent.IExecutor taskExecutor);
```


#### New Type: AndroidX.Work.Configuration.IProvider

```csharp
public interface IProvider : Android.Runtime.IJavaObject, System.IDisposable {
	// properties
	public virtual Configuration WorkManagerConfiguration { get; }
}
```


#### Type Changed: AndroidX.Work.Data

Added methods:

```csharp
public sbyte GetByte (string key, sbyte defaultValue);
public byte[] GetByteArray (string key);
```

#### Type Changed: AndroidX.Work.Data.Builder

Added methods:

```csharp
public Data.Builder PutByte (string key, sbyte value);
public Data.Builder PutByteArray (string key, byte[] value);
```



#### Type Changed: AndroidX.Work.IOperation

Added property:

```csharp
public virtual Google.Common.Util.Concurrent.IListenableFuture Result { get; }
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
public OneTimeWorkRequest.Builder SetInitialDelay (System.TimeSpan initialDelay);
```



#### Type Changed: AndroidX.Work.WorkContinuation

Added property:

```csharp
public virtual Google.Common.Util.Concurrent.IListenableFuture WorkInfos { get; }
```


#### Type Changed: AndroidX.Work.WorkInfo

Removed constructor:

```csharp
public WorkInfo (Java.Util.UUID id, WorkInfo.State state, Data outputData, System.Collections.Generic.IList<string> tags);
```

Added constructor:

```csharp
public WorkInfo (Java.Util.UUID id, WorkInfo.State state, Data outputData, System.Collections.Generic.IList<string> tags, int runAttemptCount);
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
public virtual Google.Common.Util.Concurrent.IListenableFuture LastCancelAllTimeMillis { get; }
```

Added methods:

```csharp
public static WorkManager GetInstance (Android.Content.Context context);
public virtual Google.Common.Util.Concurrent.IListenableFuture GetWorkInfoById (Java.Util.UUID p0);
public virtual Google.Common.Util.Concurrent.IListenableFuture GetWorkInfosByTag (string p0);
public virtual Google.Common.Util.Concurrent.IListenableFuture GetWorkInfosForUniqueWork (string p0);
```


#### Type Changed: AndroidX.Work.WorkRequest

#### Type Changed: AndroidX.Work.WorkRequest.Builder

Added method:

```csharp
public virtual Java.Lang.Object SetInitialDelay (long duration, Java.Util.Concurrent.TimeUnit timeUnit);
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
	protected DelegatingWorkerFactory (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
	// properties
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public void AddFactory (WorkerFactory workerFactory);
	public override ListenableWorker CreateWorker (Android.Content.Context context, string workerClass, WorkerParameters parameters);
}
```


### Namespace AndroidX.WebKit.ChromiumLibBoundary

#### Type Changed: AndroidX.WebKit.ChromiumLibBoundary.IStaticsBoundaryInterface

Added property:

```csharp
public virtual bool IsMultiProcessEnabled { get; }
```


#### Type Changed: AndroidX.WebKit.ChromiumLibBoundary.IWebSettingsBoundaryInterface

Added properties:

```csharp
public virtual int ForceDark { get; set; }
public virtual bool WillSuppressErrorPage { get; set; }
```


#### Type Changed: AndroidX.WebKit.ChromiumLibBoundary.IWebViewProviderBoundaryInterface

Added properties:

```csharp
public virtual Android.Webkit.WebChromeClient WebChromeClient { get; }
public virtual Android.Webkit.WebViewClient WebViewClient { get; }
public virtual Java.Lang.Reflect.IInvocationHandler WebViewRenderer { get; }
public virtual Java.Lang.Reflect.IInvocationHandler WebViewRendererClient { get; set; }
```


#### Type Changed: AndroidX.WebKit.ChromiumLibBoundary.IWebViewProviderFactoryBoundaryInterface

Added properties:

```csharp
public virtual Java.Lang.Reflect.IInvocationHandler ProxyController { get; }
public virtual Java.Lang.Reflect.IInvocationHandler TracingController { get; }
```


#### New Type: AndroidX.WebKit.ChromiumLibBoundary.IIsomorphicObjectBoundaryInterface

```csharp
public interface IIsomorphicObjectBoundaryInterface : Android.Runtime.IJavaObject, System.IDisposable {
	// methods
	public virtual Java.Lang.Object GetOrCreatePeer (Java.Util.Concurrent.ICallable p0);
}
```

#### New Type: AndroidX.WebKit.ChromiumLibBoundary.IProxyControllerBoundaryInterface

```csharp
public interface IProxyControllerBoundaryInterface : Android.Runtime.IJavaObject, System.IDisposable {
	// methods
	public virtual void ClearProxyOverride (Java.Lang.IRunnable p0, Java.Util.Concurrent.IExecutor p1);
	public virtual void SetProxyOverride (string[][] p0, string[] p1, Java.Lang.IRunnable p2, Java.Util.Concurrent.IExecutor p3);
}
```

#### New Type: AndroidX.WebKit.ChromiumLibBoundary.ITracingControllerBoundaryInterface

```csharp
public interface ITracingControllerBoundaryInterface : Android.Runtime.IJavaObject, System.IDisposable {
	// properties
	public virtual bool IsTracing { get; }
	// methods
	public virtual void Start (int p0, System.Collections.Generic.ICollection<string> p1, int p2);
	public virtual bool Stop (System.IO.Stream p0, Java.Util.Concurrent.IExecutor p1);
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
	public virtual void OnRendererResponsive (Android.Webkit.WebView p0, Java.Lang.Reflect.IInvocationHandler p1);
	public virtual void OnRendererUnresponsive (Android.Webkit.WebView p0, Java.Lang.Reflect.IInvocationHandler p1);
}
```


### Namespace AndroidX.WebKit.ChromiumLibBoundary.Util

#### Type Changed: AndroidX.WebKit.ChromiumLibBoundary.Util.BoundaryInterfaceReflectionUtil

Added methods:

```csharp
public static bool ContainsFeature (System.Collections.Generic.ICollection<string> features, string soughtFeature);
public static Java.Lang.Reflect.IInvocationHandler[] CreateInvocationHandlersForArray (Java.Lang.Object[] delegates);
public static bool InstanceOfInOwnClassLoader (Java.Lang.Object obj, string className);
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
	public ComponentActivity (int contentLayoutId);
	protected ComponentActivity (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
	// properties

	[Obsolete ("deprecated")]
public virtual Java.Lang.Object LastCustomNonConfigurationInstance { get; }
	public virtual OnBackPressedDispatcher OnBackPressedDispatcher { get; }
	public virtual AndroidX.SavedState.SavedStateRegistry SavedStateRegistry { get; }
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	public virtual AndroidX.Lifecycle.ViewModelStore ViewModelStore { get; }
	// methods

	[Obsolete ("deprecated")]
public virtual Java.Lang.Object OnRetainCustomNonConfigurationInstance ();
	public override Java.Lang.Object OnRetainNonConfigurationInstance ();

	// inner types
	public sealed class NonConfigurationInstances : Java.Lang.Object {
		// properties
		protected override IntPtr ThresholdClass { get; }
		protected override System.Type ThresholdType { get; }
	}
}
```

#### New Type: AndroidX.Activity.IOnBackPressedDispatcherOwner

```csharp
public interface IOnBackPressedDispatcherOwner : Android.Runtime.IJavaObject, AndroidX.Lifecycle.ILifecycleOwner, System.IDisposable {
	// properties
	public virtual OnBackPressedDispatcher OnBackPressedDispatcher { get; }
}
```

#### New Type: AndroidX.Activity.OnBackPressedCallback

```csharp
public abstract class OnBackPressedCallback : Java.Lang.Object {
	// constructors
	public OnBackPressedCallback (bool enabled);
	protected OnBackPressedCallback (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
	// properties
	public bool Enabled { get; set; }
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
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
	public OnBackPressedDispatcher (Java.Lang.IRunnable fallbackOnBackPressed);
	// properties
	public bool HasEnabledCallbacks { get; }
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public void AddCallback (OnBackPressedCallback onBackPressedCallback);
	public void AddCallback (AndroidX.Lifecycle.ILifecycleOwner owner, OnBackPressedCallback onBackPressedCallback);
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
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public static string GenerateSmsOtpHintForCharacterPosition (int characterPosition);
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
	protected BiometricFragment (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
	// properties
	protected string NegativeButtonText { get; }
	protected virtual Java.Lang.ICharSequence NegativeButtonTextFormatted { get; }
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public virtual void SetBundle (Android.OS.Bundle bundle);
}
```

#### New Type: AndroidX.Biometric.BiometricManager

```csharp
public class BiometricManager : Java.Lang.Object {
	// constructors
	protected BiometricManager (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
	// fields
	public static const int BiometricErrorHwUnavailable;
	public static const int BiometricErrorNoHardware;
	public static const int BiometricErrorNoneEnrolled;
	public static const int BiometricSuccess;
	// properties
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public virtual int CanAuthenticate ();
	public static BiometricManager From (Android.Content.Context context);
}
```

#### New Type: AndroidX.Biometric.BiometricPrompt

```csharp
public class BiometricPrompt : Java.Lang.Object {
	// constructors
	protected BiometricPrompt (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
	public BiometricPrompt (AndroidX.Fragment.App.Fragment fragment, Java.Util.Concurrent.IExecutor executor, BiometricPrompt.AuthenticationCallback callback);
	public BiometricPrompt (AndroidX.Fragment.App.FragmentActivity fragmentActivity, Java.Util.Concurrent.IExecutor executor, BiometricPrompt.AuthenticationCallback callback);
	// properties
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public virtual void Authenticate (BiometricPrompt.PromptInfo info);
	public virtual void Authenticate (BiometricPrompt.PromptInfo info, BiometricPrompt.CryptoObject crypto);
	public virtual void CancelAuthentication ();

	// inner types
	public abstract class AuthenticationCallback : Java.Lang.Object {
		// constructors
		public BiometricPrompt.AuthenticationCallback ();
		protected BiometricPrompt.AuthenticationCallback (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
		// properties
		protected override IntPtr ThresholdClass { get; }
		protected override System.Type ThresholdType { get; }
		// methods
		public virtual void OnAuthenticationError (int errorCode, Java.Lang.ICharSequence errString);
		public void OnAuthenticationError (int errorCode, string errString);
		public virtual void OnAuthenticationFailed ();
		public virtual void OnAuthenticationSucceeded (BiometricPrompt.AuthenticationResult result);
	}
	public class AuthenticationResult : Java.Lang.Object {
		// constructors
		protected BiometricPrompt.AuthenticationResult (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
		// properties
		public virtual BiometricPrompt.CryptoObject CryptoObject { get; }
		protected override IntPtr ThresholdClass { get; }
		protected override System.Type ThresholdType { get; }
	}
	public class CryptoObject : Java.Lang.Object {
		// constructors
		public BiometricPrompt.CryptoObject (Java.Security.Signature signature);
		public BiometricPrompt.CryptoObject (Javax.Crypto.Cipher cipher);
		public BiometricPrompt.CryptoObject (Javax.Crypto.Mac mac);
		protected BiometricPrompt.CryptoObject (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
		// properties
		public virtual Javax.Crypto.Cipher Cipher { get; }
		public virtual Javax.Crypto.Mac Mac { get; }
		public virtual Java.Security.Signature Signature { get; }
		protected override IntPtr ThresholdClass { get; }
		protected override System.Type ThresholdType { get; }
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
		protected BiometricPrompt.PromptInfo (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
		// properties
		public string Description { get; }
		public virtual Java.Lang.ICharSequence DescriptionFormatted { get; }
		public virtual bool IsConfirmationRequired { get; }
		public virtual bool IsDeviceCredentialAllowed { get; }
		public string NegativeButtonText { get; }
		public virtual Java.Lang.ICharSequence NegativeButtonTextFormatted { get; }
		public string Subtitle { get; }
		public virtual Java.Lang.ICharSequence SubtitleFormatted { get; }
		protected override IntPtr ThresholdClass { get; }
		protected override System.Type ThresholdType { get; }
		public string Title { get; }
		public virtual Java.Lang.ICharSequence TitleFormatted { get; }

		// inner types
		public class Builder : Java.Lang.Object {
			// constructors
			public BiometricPrompt.PromptInfo.Builder ();
			protected BiometricPrompt.PromptInfo.Builder (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
			// properties
			protected override IntPtr ThresholdClass { get; }
			protected override System.Type ThresholdType { get; }
			// methods
			public virtual BiometricPrompt.PromptInfo Build ();
			public virtual BiometricPrompt.PromptInfo.Builder SetConfirmationRequired (bool requireConfirmation);
			public virtual BiometricPrompt.PromptInfo.Builder SetDescription (Java.Lang.ICharSequence description);
			public BiometricPrompt.PromptInfo.Builder SetDescription (string description);
			public virtual BiometricPrompt.PromptInfo.Builder SetDeviceCredentialAllowed (bool enable);
			public virtual BiometricPrompt.PromptInfo.Builder SetNegativeButtonText (Java.Lang.ICharSequence text);
			public BiometricPrompt.PromptInfo.Builder SetNegativeButtonText (string text);
			public virtual BiometricPrompt.PromptInfo.Builder SetSubtitle (Java.Lang.ICharSequence subtitle);
			public BiometricPrompt.PromptInfo.Builder SetSubtitle (string subtitle);
			public virtual BiometricPrompt.PromptInfo.Builder SetTitle (Java.Lang.ICharSequence title);
			public BiometricPrompt.PromptInfo.Builder SetTitle (string title);
		}
	}
}
```

#### New Type: AndroidX.Biometric.DeviceCredentialHandlerActivity

```csharp
public class DeviceCredentialHandlerActivity : AndroidX.AppCompat.App.AppCompatActivity, Android.Runtime.IJavaObject, AndroidX.Activity.IOnBackPressedDispatcherOwner, AndroidX.AppCompat.App.ActionBarDrawerToggle.IDelegateProvider, AndroidX.AppCompat.App.IAppCompatCallback, AndroidX.Core.App.ActivityCompat.IOnRequestPermissionsResultCallback, AndroidX.Core.App.ActivityCompat.IRequestPermissionsRequestCodeValidator, AndroidX.Core.App.TaskStackBuilder.ISupportParentable, AndroidX.Core.View.KeyEventDispatcher.IComponent, AndroidX.Lifecycle.ILifecycleOwner, AndroidX.Lifecycle.IViewModelStoreOwner, AndroidX.SavedState.ISavedStateRegistryOwner, System.IDisposable {
	// constructors
	public DeviceCredentialHandlerActivity ();
	protected DeviceCredentialHandlerActivity (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
	// properties
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
}
```

#### New Type: AndroidX.Biometric.DeviceCredentialHandlerBridge

```csharp
public class DeviceCredentialHandlerBridge : Java.Lang.Object {
	// constructors
	protected DeviceCredentialHandlerBridge (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
	// properties
	public virtual FingerprintDialogFragment FingerprintDialogFragment { get; }
	public virtual FingerprintHelperFragment FingerprintHelperFragment { get; }
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
}
```

#### New Type: AndroidX.Biometric.FingerprintDialogFragment

```csharp
public class FingerprintDialogFragment : AndroidX.Fragment.App.DialogFragment, Android.Content.IComponentCallbacks, Android.Content.IDialogInterfaceOnCancelListener, Android.Content.IDialogInterfaceOnDismissListener, Android.Runtime.IJavaObject, Android.Views.View.IOnCreateContextMenuListener, AndroidX.Lifecycle.ILifecycleOwner, AndroidX.Lifecycle.IViewModelStoreOwner, AndroidX.SavedState.ISavedStateRegistryOwner, System.IDisposable {
	// constructors
	public FingerprintDialogFragment ();
	protected FingerprintDialogFragment (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
	// properties
	protected string NegativeButtonText { get; }
	protected virtual Java.Lang.ICharSequence NegativeButtonTextFormatted { get; }
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public virtual void SetBundle (Android.OS.Bundle bundle);

	// inner types
	public sealed class H : Android.OS.Handler {
		// properties
		protected override IntPtr ThresholdClass { get; }
		protected override System.Type ThresholdType { get; }
	}
}
```

#### New Type: AndroidX.Biometric.FingerprintHelperFragment

```csharp
public class FingerprintHelperFragment : AndroidX.Fragment.App.Fragment, Android.Content.IComponentCallbacks, Android.Runtime.IJavaObject, Android.Views.View.IOnCreateContextMenuListener, AndroidX.Lifecycle.ILifecycleOwner, AndroidX.Lifecycle.IViewModelStoreOwner, AndroidX.SavedState.ISavedStateRegistryOwner, System.IDisposable {
	// constructors
	public FingerprintHelperFragment ();
	protected FingerprintHelperFragment (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
	// properties
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }

	// inner types
	public class MessageRouter : Java.Lang.Object {
		// constructors
		protected FingerprintHelperFragment.MessageRouter (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
		// properties
		protected override IntPtr ThresholdClass { get; }
		protected override System.Type ThresholdType { get; }
	}
}
```

### New Namespace AndroidX.Concurrent.Futures

#### New Type: AndroidX.Concurrent.Futures.AbstractResolvableFuture

```csharp
public abstract class AbstractResolvableFuture : Java.Lang.Object, Android.Runtime.IJavaObject, Google.Common.Util.Concurrent.IListenableFuture, Java.Util.Concurrent.IFuture, System.IDisposable {
	// constructors
	protected AbstractResolvableFuture ();
	protected AbstractResolvableFuture (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
	// properties
	public virtual bool IsCancelled { get; }
	public virtual bool IsDone { get; }
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public virtual void AddListener (Java.Lang.IRunnable listener, Java.Util.Concurrent.IExecutor executor);
	protected virtual void AfterDone ();
	public virtual bool Cancel (bool mayInterruptIfRunning);
	public virtual Java.Lang.Object Get ();
	public virtual Java.Lang.Object Get (long timeout, Java.Util.Concurrent.TimeUnit unit);
	protected virtual void InterruptTask ();
	protected virtual string PendingToString ();
	protected virtual bool Set (Java.Lang.Object value);
	protected virtual bool SetException (Java.Lang.Throwable throwable);
	protected virtual bool SetFuture (Google.Common.Util.Concurrent.IListenableFuture future);
	protected bool WasInterrupted ();
}
```

#### New Type: AndroidX.Concurrent.Futures.CallbackToFutureAdapter

```csharp
public sealed class CallbackToFutureAdapter : Java.Lang.Object {
	// properties
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public static Google.Common.Util.Concurrent.IListenableFuture GetFuture (CallbackToFutureAdapter.IResolver callback);

	// inner types
	public sealed class Completer : Java.Lang.Object {
		// properties
		protected override IntPtr ThresholdClass { get; }
		protected override System.Type ThresholdType { get; }
		// methods
		public void AddCancellationListener (Java.Lang.IRunnable runnable, Java.Util.Concurrent.IExecutor executor);
		public bool Set (Java.Lang.Object value);
		public bool SetCancelled ();
		public bool SetException (Java.Lang.Throwable t);
	}
	public sealed class FutureGarbageCollectedException : Java.Lang.Throwable {
		// properties
		protected override IntPtr ThresholdClass { get; }
		protected override System.Type ThresholdType { get; }
	}
	public interface IResolver : Android.Runtime.IJavaObject, System.IDisposable {
		// methods
		public virtual Java.Lang.Object AttachCompleter (CallbackToFutureAdapter.Completer p0);
	}
}
```

#### New Type: AndroidX.Concurrent.Futures.ResolvableFuture

```csharp
public sealed class ResolvableFuture : AndroidX.Concurrent.Futures.AbstractResolvableFuture, Android.Runtime.IJavaObject, Google.Common.Util.Concurrent.IListenableFuture, Java.Util.Concurrent.IFuture, System.IDisposable {
	// properties
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public static ResolvableFuture Create ();
	public bool Set (Java.Lang.Object value);
	public bool SetException (Java.Lang.Throwable throwable);
	public bool SetFuture (Google.Common.Util.Concurrent.IListenableFuture future);
}
```

### New Namespace AndroidX.ContentPager.Content

#### New Type: AndroidX.ContentPager.Content.ContentPager

```csharp
public class ContentPager : Java.Lang.Object {
	// constructors
	public ContentPager (Android.Content.ContentResolver resolver, ContentPager.IQueryRunner queryRunner);
	protected ContentPager (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
	public ContentPager (Android.Content.ContentResolver resolver, ContentPager.IQueryRunner queryRunner, int cursorCacheSize);
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
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public static Android.OS.Bundle CreateArgs (int offset, int limit);
	public virtual Query Query (Android.Net.Uri uri, string[] projection, Android.OS.Bundle queryArgs, Android.OS.CancellationSignal cancellationSignal, ContentPager.IContentCallback callback);
	public virtual void Reset ();

	// inner types
	public interface IContentCallback : Android.Runtime.IJavaObject, System.IDisposable {
		// methods
		public virtual void OnCursorReady (Query p0, Android.Database.ICursor p1);
	}
	public interface ICursorDisposition : Android.Runtime.IJavaObject, Java.Lang.Annotation.IAnnotation, System.IDisposable {
	}
	public interface IQueryRunner : Android.Runtime.IJavaObject, System.IDisposable {
		// methods
		public virtual void Cancel (Query p0);
		public virtual bool IsRunning (Query p0);
		public virtual void Query (Query p0, ContentPager.IQueryRunnerCallback p1);
	}
	public interface IQueryRunnerCallback : Android.Runtime.IJavaObject, System.IDisposable {
		// methods
		public virtual void OnQueryFinished (Query p0, Android.Database.ICursor p1);
		public virtual Android.Database.ICursor RunQueryInBackground (Query p0);
	}
	public sealed class Stats : Java.Lang.Object {
		// properties
		protected override IntPtr ThresholdClass { get; }
		protected override System.Type ThresholdType { get; }
	}
}
```

#### New Type: AndroidX.ContentPager.Content.LoaderQueryRunner

```csharp
public sealed class LoaderQueryRunner : Java.Lang.Object, Android.Runtime.IJavaObject, ContentPager.IQueryRunner, System.IDisposable {
	// constructors
	public LoaderQueryRunner (Android.Content.Context context, Android.App.LoaderManager loaderMgr);
	// properties
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public virtual void Cancel (Query query);
	public virtual bool IsRunning (Query query);
	public virtual void Query (Query query, ContentPager.IQueryRunnerCallback callback);
}
```

#### New Type: AndroidX.ContentPager.Content.Query

```csharp
public sealed class Query : Java.Lang.Object {
	// properties
	public int Id { get; }
	public int Limit { get; }
	public int Offset { get; }
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	public Android.Net.Uri Uri { get; }
}
```

### New Namespace AndroidX.Core.Location

#### New Type: AndroidX.Core.Location.LocationManagerCompat

```csharp
public sealed class LocationManagerCompat : Java.Lang.Object {
	// properties
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public static bool IsLocationEnabled (Android.Locations.LocationManager locationManager);
}
```

### New Namespace AndroidX.Core.Telephony.Mbms

#### New Type: AndroidX.Core.Telephony.Mbms.MbmsHelper

```csharp
public sealed class MbmsHelper : Java.Lang.Object {
	// properties
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public static string GetBestNameForService (Android.Content.Context context, Android.Telephony.Mbms.ServiceInfo serviceInfo);
	public static Java.Lang.ICharSequence GetBestNameForServiceFormatted (Android.Content.Context context, Android.Telephony.Mbms.ServiceInfo serviceInfo);
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
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public static Java.Lang.Object Read (AndroidX.VersionedParcelable.VersionedParcel parcel);
}
```

#### New Type: AndroidX.Medai2.Common.CallbackMediaItem

```csharp
public class CallbackMediaItem : AndroidX.Medai2.Common.MediaItem, Android.Runtime.IJavaObject, AndroidX.VersionedParcelable.IVersionedParcelable, System.IDisposable {
	// constructors
	protected CallbackMediaItem (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
	// properties
	public virtual DataSourceCallback DataSourceCallback { get; }
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }

	// inner types
	public sealed class Builder : AndroidX.Medai2.Common.MediaItem+Builder {
		// constructors
		public CallbackMediaItem.Builder (DataSourceCallback dsc2);
		// properties
		protected override IntPtr ThresholdClass { get; }
		protected override System.Type ThresholdType { get; }
	}
}
```

#### New Type: AndroidX.Medai2.Common.CallbackMediaItemParcelizer

```csharp
public sealed class CallbackMediaItemParcelizer : Java.Lang.Object {
	// constructors
	public CallbackMediaItemParcelizer ();
	// properties
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public static CallbackMediaItem Read (AndroidX.VersionedParcelable.VersionedParcel parcel);
	public static void Write (CallbackMediaItem obj, AndroidX.VersionedParcelable.VersionedParcel parcel);
}
```

#### New Type: AndroidX.Medai2.Common.DataSourceCallback

```csharp
public abstract class DataSourceCallback : Java.Lang.Object, Android.Runtime.IJavaObject, Java.IO.ICloseable, System.IDisposable {
	// constructors
	public DataSourceCallback ();
	protected DataSourceCallback (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
	// properties
	public virtual long Size { get; }
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public virtual void Close ();
	public virtual int ReadAt (long p0, byte[] p1, int p2, int p3);
}
```

#### New Type: AndroidX.Medai2.Common.FileMediaItem

```csharp
public class FileMediaItem : AndroidX.Medai2.Common.MediaItem, Android.Runtime.IJavaObject, AndroidX.VersionedParcelable.IVersionedParcelable, System.IDisposable {
	// constructors
	protected FileMediaItem (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
	// fields
	public static const long FdLengthUnknown;
	// properties
	public virtual long FileDescriptorLength { get; }
	public virtual long FileDescriptorOffset { get; }
	public virtual bool IsClosed { get; }
	public virtual Android.OS.ParcelFileDescriptor ParcelFileDescriptor { get; }
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public virtual void Close ();
	public virtual void DecreaseRefCount ();
	public virtual void IncreaseRefCount ();

	// inner types
	public sealed class Builder : AndroidX.Medai2.Common.MediaItem+Builder {
		// constructors
		public FileMediaItem.Builder (Android.OS.ParcelFileDescriptor pfd);
		// properties
		protected override IntPtr ThresholdClass { get; }
		protected override System.Type ThresholdType { get; }
		// methods
		public FileMediaItem.Builder SetFileDescriptorLength (long length);
		public FileMediaItem.Builder SetFileDescriptorOffset (long offset);
	}
}
```

#### New Type: AndroidX.Medai2.Common.FileMediaItemParcelizer

```csharp
public sealed class FileMediaItemParcelizer : Java.Lang.Object {
	// constructors
	public FileMediaItemParcelizer ();
	// properties
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public static FileMediaItem Read (AndroidX.VersionedParcelable.VersionedParcel parcel);
	public static void Write (FileMediaItem obj, AndroidX.VersionedParcelable.VersionedParcel parcel);
}
```

#### New Type: AndroidX.Medai2.Common.IBaseResult

```csharp
public interface IBaseResult : Android.Runtime.IJavaObject, System.IDisposable {
	// properties
	public virtual long CompletionTime { get; }
	public virtual MediaItem MediaItem { get; }
	public virtual int ResultCode { get; }
}
```

#### New Type: AndroidX.Medai2.Common.IRating

```csharp
public interface IRating : Android.Runtime.IJavaObject, AndroidX.VersionedParcelable.IVersionedParcelable, System.IDisposable {
	// properties
	public virtual bool IsRated { get; }
}
```

#### New Type: AndroidX.Medai2.Common.MediaItem

```csharp
public class MediaItem : AndroidX.VersionedParcelable.CustomVersionedParcelable, Android.Runtime.IJavaObject, AndroidX.VersionedParcelable.IVersionedParcelable, System.IDisposable {
	// constructors
	protected MediaItem (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
	// fields
	public static const long PositionUnknown;
	// properties
	public virtual long EndPosition { get; }
	public virtual string MediaId { get; }
	public virtual MediaMetadata Metadata { get; set; }
	public virtual long StartPosition { get; }
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public virtual void AddOnMetadataChangedListener (Java.Util.Concurrent.IExecutor executor, MediaItem.IOnMetadataChangedListener listener);
	public virtual void RemoveOnMetadataChangedListener (MediaItem.IOnMetadataChangedListener listener);

	// inner types
	public class Builder : Java.Lang.Object {
		// constructors
		public MediaItem.Builder ();
		protected MediaItem.Builder (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
		// properties
		protected override IntPtr ThresholdClass { get; }
		protected override System.Type ThresholdType { get; }
		// methods
		public virtual MediaItem Build ();
		public virtual MediaItem.Builder SetEndPosition (long position);
		public virtual MediaItem.Builder SetMetadata (MediaMetadata metadata);
		public virtual MediaItem.Builder SetStartPosition (long position);
	}
	public interface IOnMetadataChangedListener : Android.Runtime.IJavaObject, System.IDisposable {
		// methods
		public virtual void OnMetadataChanged (MediaItem p0);
	}
	public class MetadataChangedEventArgs : System.EventArgs {
		// constructors
		public MediaItem.MetadataChangedEventArgs (MediaItem p0);
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
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public static MediaItem Read (AndroidX.VersionedParcelable.VersionedParcel parcel);
	public static void Write (MediaItem obj, AndroidX.VersionedParcelable.VersionedParcel parcel);
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
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public bool ContainsKey (string key);
	public Android.Graphics.Bitmap GetBitmap (string key);
	public float GetFloat (string key);
	public long GetLong (string key);
	public Java.Lang.Object GetObject (string key);
	public IRating GetRating (string key);
	public string GetString (string key);
	public string GetText (string key);
	public Java.Lang.ICharSequence GetTextFormatted (string key);
	public System.Collections.Generic.ICollection<string> KeySet ();
	public int Size ();

	// inner types
	public sealed class BitmapEntry : Java.Lang.Object, Android.Runtime.IJavaObject, AndroidX.VersionedParcelable.IVersionedParcelable, System.IDisposable {
		// properties
		protected override IntPtr ThresholdClass { get; }
		protected override System.Type ThresholdType { get; }
	}
	public sealed class Builder : Java.Lang.Object {
		// constructors
		public MediaMetadata.Builder ();
		public MediaMetadata.Builder (MediaMetadata source);
		// properties
		protected override IntPtr ThresholdClass { get; }
		protected override System.Type ThresholdType { get; }
		// methods
		public MediaMetadata Build ();
		public MediaMetadata.Builder PutBitmap (string key, Android.Graphics.Bitmap value);
		public MediaMetadata.Builder PutFloat (string key, float value);
		public MediaMetadata.Builder PutLong (string key, long value);
		public MediaMetadata.Builder PutRating (string key, IRating value);
		public MediaMetadata.Builder PutString (string key, string value);
		public MediaMetadata.Builder PutText (string key, Java.Lang.ICharSequence value);
		public MediaMetadata.Builder PutText (string key, string value);
		public MediaMetadata.Builder SetExtras (Android.OS.Bundle extras);
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
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public static MediaMetadata Read (AndroidX.VersionedParcelable.VersionedParcel parcel);
	public static void Write (MediaMetadata obj, AndroidX.VersionedParcelable.VersionedParcel parcel);
}
```

#### New Type: AndroidX.Medai2.Common.MediaParcelUtils

```csharp
public class MediaParcelUtils : Java.Lang.Object {
	// constructors
	public MediaParcelUtils ();
	protected MediaParcelUtils (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
	// fields
	public static const string Tag = "MediaParcelUtils";
	// properties
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public static Java.Lang.Object FromParcelable (AndroidX.VersionedParcelable.ParcelImpl p);
	public static System.Collections.IList FromParcelableList (System.Collections.Generic.IList<AndroidX.VersionedParcelable.ParcelImpl> parcelList);
	public static AndroidX.VersionedParcelable.ParcelImpl ToParcelable (AndroidX.VersionedParcelable.IVersionedParcelable item);
	public static System.Collections.Generic.IList<AndroidX.VersionedParcelable.ParcelImpl> ToParcelableList (System.Collections.Generic.IList<AndroidX.VersionedParcelable.IVersionedParcelable> items);
}
```

#### New Type: AndroidX.Medai2.Common.ParcelImplListSlice

```csharp
public class ParcelImplListSlice : Java.Lang.Object, Android.OS.IParcelable, Android.Runtime.IJavaObject, System.IDisposable {
	// constructors
	public ParcelImplListSlice (System.Collections.Generic.IList<AndroidX.VersionedParcelable.ParcelImpl> list);
	protected ParcelImplListSlice (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
	// properties
	public static Android.OS.IParcelableCreator Creator { get; }
	public virtual System.Collections.Generic.IList<AndroidX.VersionedParcelable.ParcelImpl> List { get; }
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public virtual int DescribeContents ();
	public virtual void WriteToParcel (Android.OS.Parcel dest, Android.OS.ParcelableWriteFlags flags);
}
```

#### New Type: AndroidX.Medai2.Common.SessionPlayer

```csharp
public abstract class SessionPlayer : Java.Lang.Object, Android.Runtime.IJavaObject, Java.Lang.IAutoCloseable, System.IDisposable {
	// constructors
	public SessionPlayer ();
	protected SessionPlayer (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
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
	public virtual AndroidX.Media.AudioAttributesCompat AudioAttributes { get; }
	public virtual long BufferedPosition { get; }
	public virtual int BufferingState { get; }
	protected System.Collections.Generic.IList<AndroidX.Core.Util.Pair> Callbacks { get; }
	public virtual MediaItem CurrentMediaItem { get; }
	public virtual int CurrentMediaItemIndex { get; }
	public virtual long CurrentPosition { get; }
	public virtual long Duration { get; }
	public virtual int NextMediaItemIndex { get; }
	public virtual float PlaybackSpeed { get; }
	public virtual int PlayerState { get; }
	public virtual System.Collections.Generic.IList<MediaItem> Playlist { get; }
	public virtual MediaMetadata PlaylistMetadata { get; }
	public virtual int PreviousMediaItemIndex { get; }
	public virtual int RepeatMode { get; }
	public virtual int ShuffleMode { get; }
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	public virtual System.Collections.Generic.IList<SessionPlayer.TrackInfo> TrackInfoInternal { get; }
	public virtual VideoSize VideoSizeInternal { get; }
	// methods
	public virtual Google.Common.Util.Concurrent.IListenableFuture AddPlaylistItem (int p0, MediaItem p1);
	public virtual void Close ();
	public virtual Google.Common.Util.Concurrent.IListenableFuture DeselectTrackInternal (SessionPlayer.TrackInfo trackInfo);
	public virtual SessionPlayer.TrackInfo GetSelectedTrackInternal (int trackType);
	public virtual Google.Common.Util.Concurrent.IListenableFuture Pause ();
	public virtual Google.Common.Util.Concurrent.IListenableFuture Play ();
	public virtual Google.Common.Util.Concurrent.IListenableFuture Prepare ();
	public void RegisterPlayerCallback (Java.Util.Concurrent.IExecutor executor, SessionPlayer.PlayerCallback callback);
	public virtual Google.Common.Util.Concurrent.IListenableFuture RemovePlaylistItem (int p0);
	public virtual Google.Common.Util.Concurrent.IListenableFuture ReplacePlaylistItem (int p0, MediaItem p1);
	public virtual Google.Common.Util.Concurrent.IListenableFuture SeekTo (long p0);
	public virtual Google.Common.Util.Concurrent.IListenableFuture SelectTrackInternal (SessionPlayer.TrackInfo trackInfo);
	public virtual Google.Common.Util.Concurrent.IListenableFuture SetAudioAttributes (AndroidX.Media.AudioAttributesCompat p0);
	public virtual Google.Common.Util.Concurrent.IListenableFuture SetMediaItem (MediaItem p0);
	public virtual Google.Common.Util.Concurrent.IListenableFuture SetPlaybackSpeed (float p0);
	public virtual Google.Common.Util.Concurrent.IListenableFuture SetPlaylist (System.Collections.Generic.IList<MediaItem> p0, MediaMetadata p1);
	public virtual Google.Common.Util.Concurrent.IListenableFuture SetRepeatMode (int p0);
	public virtual Google.Common.Util.Concurrent.IListenableFuture SetShuffleMode (int p0);
	public virtual Google.Common.Util.Concurrent.IListenableFuture SetSurfaceInternal (Android.Views.Surface surface);
	public virtual Google.Common.Util.Concurrent.IListenableFuture SkipToNextPlaylistItem ();
	public virtual Google.Common.Util.Concurrent.IListenableFuture SkipToPlaylistItem (int p0);
	public virtual Google.Common.Util.Concurrent.IListenableFuture SkipToPreviousPlaylistItem ();
	public void UnregisterPlayerCallback (SessionPlayer.PlayerCallback callback);
	public virtual Google.Common.Util.Concurrent.IListenableFuture UpdatePlaylistMetadata (MediaMetadata p0);

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
		protected SessionPlayer.PlayerCallback (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
		// properties
		protected override IntPtr ThresholdClass { get; }
		protected override System.Type ThresholdType { get; }
		// methods
		public virtual void OnAudioAttributesChanged (SessionPlayer player, AndroidX.Media.AudioAttributesCompat attributes);
		public virtual void OnBufferingStateChanged (SessionPlayer player, MediaItem item, int buffState);
		public virtual void OnCurrentMediaItemChanged (SessionPlayer player, MediaItem item);
		public virtual void OnPlaybackCompleted (SessionPlayer player);
		public virtual void OnPlaybackSpeedChanged (SessionPlayer player, float playbackSpeed);
		public virtual void OnPlayerStateChanged (SessionPlayer player, int playerState);
		public virtual void OnPlaylistChanged (SessionPlayer player, System.Collections.Generic.IList<MediaItem> list, MediaMetadata metadata);
		public virtual void OnPlaylistMetadataChanged (SessionPlayer player, MediaMetadata metadata);
		public virtual void OnRepeatModeChanged (SessionPlayer player, int repeatMode);
		public virtual void OnSeekCompleted (SessionPlayer player, long position);
		public virtual void OnShuffleModeChanged (SessionPlayer player, int shuffleMode);
		public virtual void OnSubtitleData (SessionPlayer player, MediaItem item, SessionPlayer.TrackInfo track, SubtitleData data);
		public virtual void OnTrackDeselected (SessionPlayer player, SessionPlayer.TrackInfo trackInfo);
		public virtual void OnTrackInfoChanged (SessionPlayer player, System.Collections.Generic.IList<SessionPlayer.TrackInfo> trackInfos);
		public virtual void OnTrackSelected (SessionPlayer player, SessionPlayer.TrackInfo trackInfo);
		public virtual void OnVideoSizeChangedInternal (SessionPlayer player, MediaItem item, VideoSize size);
	}
	public class PlayerResult : Java.Lang.Object, Android.Runtime.IJavaObject, IBaseResult, System.IDisposable {
		// constructors
		public SessionPlayer.PlayerResult (int resultCode, MediaItem item);
		protected SessionPlayer.PlayerResult (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
		// properties
		public virtual long CompletionTime { get; }
		public virtual MediaItem MediaItem { get; }
		public virtual int ResultCode { get; }
		protected override IntPtr ThresholdClass { get; }
		protected override System.Type ThresholdType { get; }
		// methods
		public static Google.Common.Util.Concurrent.IListenableFuture CreateFuture (int resultCode);

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
		public SessionPlayer.PlayerResult.TrackInfo (int id, MediaItem item, int type, Android.Media.MediaFormat format);
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
		protected override IntPtr ThresholdClass { get; }
		protected override System.Type ThresholdType { get; }
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
	public SubtitleData (long startTimeUs, long durationUs, byte[] data);
	// fields
	public static const string MimetypeTextCea608 = "text/cea-608";
	public static const string MimetypeTextCea708 = "text/cea-708";
	public static const string MimetypeTextVtt = "text/vtt";
	// properties
	public long DurationUs { get; }
	public long StartTimeUs { get; }
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
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
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public static SubtitleData Read (AndroidX.VersionedParcelable.VersionedParcel parcel);
	public static void Write (SubtitleData obj, AndroidX.VersionedParcelable.VersionedParcel parcel);
}
```

#### New Type: AndroidX.Medai2.Common.TrackInfoParcelizer

```csharp
public sealed class TrackInfoParcelizer : Java.Lang.Object {
	// constructors
	public TrackInfoParcelizer ();
	// properties
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public static SessionPlayer.TrackInfo Read (AndroidX.VersionedParcelable.VersionedParcel parcel);
	public static void Write (SessionPlayer.TrackInfo obj, AndroidX.VersionedParcelable.VersionedParcel parcel);
}
```

#### New Type: AndroidX.Medai2.Common.UriMediaItem

```csharp
public class UriMediaItem : AndroidX.Medai2.Common.MediaItem, Android.Runtime.IJavaObject, AndroidX.VersionedParcelable.IVersionedParcelable, System.IDisposable {
	// constructors
	protected UriMediaItem (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
	// properties
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	public virtual Android.Net.Uri Uri { get; }
	public virtual System.Collections.Generic.IList<Java.Net.HttpCookie> UriCookies { get; }
	public virtual System.Collections.Generic.IDictionary<System.String,System.String> UriHeaders { get; }

	// inner types
	public sealed class Builder : AndroidX.Medai2.Common.MediaItem+Builder {
		// constructors
		public UriMediaItem.Builder (Android.Net.Uri uri);
		public UriMediaItem.Builder (Android.Net.Uri uri, System.Collections.Generic.IDictionary<System.String,System.String> headers, System.Collections.Generic.IList<Java.Net.HttpCookie> cookies);
		// properties
		protected override IntPtr ThresholdClass { get; }
		protected override System.Type ThresholdType { get; }
	}
}
```

#### New Type: AndroidX.Medai2.Common.UriMediaItemParcelizer

```csharp
public sealed class UriMediaItemParcelizer : Java.Lang.Object {
	// constructors
	public UriMediaItemParcelizer ();
	// properties
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public static UriMediaItem Read (AndroidX.VersionedParcelable.VersionedParcel parcel);
	public static void Write (UriMediaItem obj, AndroidX.VersionedParcelable.VersionedParcel parcel);
}
```

#### New Type: AndroidX.Medai2.Common.VideoSize

```csharp
public sealed class VideoSize : Java.Lang.Object, Android.Runtime.IJavaObject, AndroidX.VersionedParcelable.IVersionedParcelable, System.IDisposable {
	// constructors
	public VideoSize (int width, int height);
	// properties
	public int Height { get; }
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	public int Width { get; }
}
```

#### New Type: AndroidX.Medai2.Common.VideoSizeParcelizer

```csharp
public sealed class VideoSizeParcelizer : Java.Lang.Object {
	// constructors
	public VideoSizeParcelizer ();
	// properties
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public static VideoSize Read (AndroidX.VersionedParcelable.VersionedParcel parcel);
	public static void Write (VideoSize obj, AndroidX.VersionedParcelable.VersionedParcel parcel);
}
```

### New Namespace AndroidX.Medai2.Common.Futures

#### New Type: AndroidX.Medai2.Common.Futures.AbstractResolvableFuture

```csharp
public abstract class AbstractResolvableFuture : Java.Lang.Object, Android.Runtime.IJavaObject, Google.Common.Util.Concurrent.IListenableFuture, Java.Util.Concurrent.IFuture, System.IDisposable {
	// constructors
	protected AbstractResolvableFuture ();
	protected AbstractResolvableFuture (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
	// properties
	public virtual bool IsCancelled { get; }
	public virtual bool IsDone { get; }
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public virtual void AddListener (Java.Lang.IRunnable listener, Java.Util.Concurrent.IExecutor executor);
	protected virtual void AfterDone ();
	public virtual bool Cancel (bool mayInterruptIfRunning);
	public virtual Java.Lang.Object Get ();
	public virtual Java.Lang.Object Get (long timeout, Java.Util.Concurrent.TimeUnit unit);
	protected virtual void InterruptTask ();
	protected virtual string PendingToString ();
	protected virtual bool Set (Java.Lang.Object value);
	protected virtual bool SetException (Java.Lang.Throwable throwable);
	protected virtual bool SetFuture (Google.Common.Util.Concurrent.IListenableFuture future);
	protected bool WasInterrupted ();
}
```

#### New Type: AndroidX.Medai2.Common.Futures.ResolvableFuture

```csharp
public sealed class ResolvableFuture : AndroidX.Medai2.Common.Futures.AbstractResolvableFuture, Android.Runtime.IJavaObject, Google.Common.Util.Concurrent.IListenableFuture, Java.Util.Concurrent.IFuture, System.IDisposable {
	// properties
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public static ResolvableFuture Create ();
	public bool Set (Java.Lang.Object value);
	public bool SetException (Java.Lang.Throwable throwable);
	public bool SetFuture (Google.Common.Util.Concurrent.IListenableFuture future);
}
```

### New Namespace AndroidX.Media2.Session

#### New Type: AndroidX.Media2.Session.CommandButtonParcelizer

```csharp
public sealed class CommandButtonParcelizer : Java.Lang.Object {
	// constructors
	public CommandButtonParcelizer ();
	// properties
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public static MediaSession.CommandButton Read (AndroidX.VersionedParcelable.VersionedParcel parcel);
	public static void Write (MediaSession.CommandButton obj, AndroidX.VersionedParcelable.VersionedParcel parcel);
}
```

#### New Type: AndroidX.Media2.Session.ConnectionRequestParcelizer

```csharp
public sealed class ConnectionRequestParcelizer : Java.Lang.Object {
	// constructors
	public ConnectionRequestParcelizer ();
	// properties
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public static Java.Lang.Object Read (AndroidX.VersionedParcelable.VersionedParcel parcel);
}
```

#### New Type: AndroidX.Media2.Session.ConnectionResultParcelizer

```csharp
public sealed class ConnectionResultParcelizer : Java.Lang.Object {
	// constructors
	public ConnectionResultParcelizer ();
	// properties
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public static AndroidX.VersionedParcelable.CustomVersionedParcelable Read (AndroidX.VersionedParcelable.VersionedParcel parcel);
}
```

#### New Type: AndroidX.Media2.Session.HeartRating

```csharp
public sealed class HeartRating : Java.Lang.Object, Android.Runtime.IJavaObject, AndroidX.Medai2.Common.IRating, AndroidX.VersionedParcelable.IVersionedParcelable, System.IDisposable {
	// constructors
	public HeartRating ();
	public HeartRating (bool hasHeart);
	// properties
	public bool HasHeart { get; }
	public virtual bool IsRated { get; }
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
}
```

#### New Type: AndroidX.Media2.Session.HeartRatingParcelizer

```csharp
public sealed class HeartRatingParcelizer : Java.Lang.Object {
	// constructors
	public HeartRatingParcelizer ();
	// properties
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public static HeartRating Read (AndroidX.VersionedParcelable.VersionedParcel parcel);
	public static void Write (HeartRating obj, AndroidX.VersionedParcelable.VersionedParcel parcel);
}
```

#### New Type: AndroidX.Media2.Session.IMediaController

```csharp
public interface IMediaController : Android.OS.IInterface, Android.Runtime.IJavaObject, System.IDisposable {
	// methods
	public virtual void OnAllowedCommandsChanged (int p0, AndroidX.VersionedParcelable.ParcelImpl p1);
	public virtual void OnBufferingStateChanged (int p0, AndroidX.VersionedParcelable.ParcelImpl p1, int p2, long p3, long p4, long p5);
	public virtual void OnChildrenChanged (int p0, string p1, int p2, AndroidX.VersionedParcelable.ParcelImpl p3);
	public virtual void OnConnected (int p0, AndroidX.VersionedParcelable.ParcelImpl p1);
	public virtual void OnCurrentMediaItemChanged (int p0, AndroidX.VersionedParcelable.ParcelImpl p1, int p2, int p3, int p4);
	public virtual void OnCustomCommand (int p0, AndroidX.VersionedParcelable.ParcelImpl p1, Android.OS.Bundle p2);
	public virtual void OnDisconnected (int p0);
	public virtual void OnLibraryResult (int p0, AndroidX.VersionedParcelable.ParcelImpl p1);
	public virtual void OnPlaybackCompleted (int p0);
	public virtual void OnPlaybackInfoChanged (int p0, AndroidX.VersionedParcelable.ParcelImpl p1);
	public virtual void OnPlaybackSpeedChanged (int p0, long p1, long p2, float p3);
	public virtual void OnPlayerStateChanged (int p0, long p1, long p2, int p3);
	public virtual void OnPlaylistChanged (int p0, AndroidX.Medai2.Common.ParcelImplListSlice p1, AndroidX.VersionedParcelable.ParcelImpl p2, int p3, int p4, int p5);
	public virtual void OnPlaylistMetadataChanged (int p0, AndroidX.VersionedParcelable.ParcelImpl p1);
	public virtual void OnRepeatModeChanged (int p0, int p1, int p2, int p3, int p4);
	public virtual void OnSearchResultChanged (int p0, string p1, int p2, AndroidX.VersionedParcelable.ParcelImpl p3);
	public virtual void OnSeekCompleted (int p0, long p1, long p2, long p3);
	public virtual void OnSessionResult (int p0, AndroidX.VersionedParcelable.ParcelImpl p1);
	public virtual void OnSetCustomLayout (int p0, System.Collections.Generic.IList<AndroidX.VersionedParcelable.ParcelImpl> p1);
	public virtual void OnShuffleModeChanged (int p0, int p1, int p2, int p3, int p4);
	public virtual void OnSubtitleData (int p0, AndroidX.VersionedParcelable.ParcelImpl p1, AndroidX.VersionedParcelable.ParcelImpl p2, AndroidX.VersionedParcelable.ParcelImpl p3);
	public virtual void OnTrackDeselected (int p0, AndroidX.VersionedParcelable.ParcelImpl p1);
	public virtual void OnTrackInfoChanged (int p0, System.Collections.Generic.IList<AndroidX.VersionedParcelable.ParcelImpl> p1, AndroidX.VersionedParcelable.ParcelImpl p2, AndroidX.VersionedParcelable.ParcelImpl p3, AndroidX.VersionedParcelable.ParcelImpl p4, AndroidX.VersionedParcelable.ParcelImpl p5);
	public virtual void OnTrackSelected (int p0, AndroidX.VersionedParcelable.ParcelImpl p1);
	public virtual void OnVideoSizeChanged (int p0, AndroidX.VersionedParcelable.ParcelImpl p1, AndroidX.VersionedParcelable.ParcelImpl p2);
}
```

#### New Type: AndroidX.Media2.Session.IMediaSession

```csharp
public interface IMediaSession : Android.OS.IInterface, Android.Runtime.IJavaObject, System.IDisposable {
	// methods
	public virtual void AddPlaylistItem (IMediaController p0, int p1, int p2, string p3);
	public virtual void AdjustVolume (IMediaController p0, int p1, int p2, int p3);
	public virtual void Connect (IMediaController p0, int p1, AndroidX.VersionedParcelable.ParcelImpl p2);
	public virtual void DeselectTrack (IMediaController p0, int p1, AndroidX.VersionedParcelable.ParcelImpl p2);
	public virtual void FastForward (IMediaController p0, int p1);
	public virtual void GetChildren (IMediaController p0, int p1, string p2, int p3, int p4, AndroidX.VersionedParcelable.ParcelImpl p5);
	public virtual void GetItem (IMediaController p0, int p1, string p2);
	public virtual void GetLibraryRoot (IMediaController p0, int p1, AndroidX.VersionedParcelable.ParcelImpl p2);
	public virtual void GetSearchResult (IMediaController p0, int p1, string p2, int p3, int p4, AndroidX.VersionedParcelable.ParcelImpl p5);
	public virtual void OnControllerResult (IMediaController p0, int p1, AndroidX.VersionedParcelable.ParcelImpl p2);
	public virtual void OnCustomCommand (IMediaController p0, int p1, AndroidX.VersionedParcelable.ParcelImpl p2, Android.OS.Bundle p3);
	public virtual void Pause (IMediaController p0, int p1);
	public virtual void Play (IMediaController p0, int p1);
	public virtual void PlayFromMediaId (IMediaController p0, int p1, string p2, Android.OS.Bundle p3);
	public virtual void PlayFromSearch (IMediaController p0, int p1, string p2, Android.OS.Bundle p3);
	public virtual void PlayFromUri (IMediaController p0, int p1, Android.Net.Uri p2, Android.OS.Bundle p3);
	public virtual void Prepare (IMediaController p0, int p1);
	public virtual void PrepareFromMediaId (IMediaController p0, int p1, string p2, Android.OS.Bundle p3);
	public virtual void PrepareFromSearch (IMediaController p0, int p1, string p2, Android.OS.Bundle p3);
	public virtual void PrepareFromUri (IMediaController p0, int p1, Android.Net.Uri p2, Android.OS.Bundle p3);
	public virtual void Release (IMediaController p0, int p1);
	public virtual void RemovePlaylistItem (IMediaController p0, int p1, int p2);
	public virtual void ReplacePlaylistItem (IMediaController p0, int p1, int p2, string p3);
	public virtual void Rewind (IMediaController p0, int p1);
	public virtual void Search (IMediaController p0, int p1, string p2, AndroidX.VersionedParcelable.ParcelImpl p3);
	public virtual void SeekTo (IMediaController p0, int p1, long p2);
	public virtual void SelectTrack (IMediaController p0, int p1, AndroidX.VersionedParcelable.ParcelImpl p2);
	public virtual void SetMediaItem (IMediaController p0, int p1, string p2);
	public virtual void SetPlaybackSpeed (IMediaController p0, int p1, float p2);
	public virtual void SetPlaylist (IMediaController p0, int p1, System.Collections.Generic.IList<string> p2, AndroidX.VersionedParcelable.ParcelImpl p3);
	public virtual void SetRating (IMediaController p0, int p1, string p2, AndroidX.VersionedParcelable.ParcelImpl p3);
	public virtual void SetRepeatMode (IMediaController p0, int p1, int p2);
	public virtual void SetShuffleMode (IMediaController p0, int p1, int p2);
	public virtual void SetSurface (IMediaController p0, int p1, Android.Views.Surface p2);
	public virtual void SetVolumeTo (IMediaController p0, int p1, int p2, int p3);
	public virtual void SkipBackward (IMediaController p0, int p1);
	public virtual void SkipForward (IMediaController p0, int p1);
	public virtual void SkipToNextItem (IMediaController p0, int p1);
	public virtual void SkipToPlaylistItem (IMediaController p0, int p1, int p2);
	public virtual void SkipToPreviousItem (IMediaController p0, int p1);
	public virtual void Subscribe (IMediaController p0, int p1, string p2, AndroidX.VersionedParcelable.ParcelImpl p3);
	public virtual void Unsubscribe (IMediaController p0, int p1, string p2);
	public virtual void UpdatePlaylistMetadata (IMediaController p0, int p1, AndroidX.VersionedParcelable.ParcelImpl p2);
}
```

#### New Type: AndroidX.Media2.Session.IMediaSessionService

```csharp
public interface IMediaSessionService : Android.OS.IInterface, Android.Runtime.IJavaObject, System.IDisposable {
	// methods
	public virtual void Connect (IMediaController p0, AndroidX.VersionedParcelable.ParcelImpl p1);
}
```

#### New Type: AndroidX.Media2.Session.LibraryParamsParcelizer

```csharp
public sealed class LibraryParamsParcelizer : Java.Lang.Object {
	// constructors
	public LibraryParamsParcelizer ();
	// properties
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public static MediaLibraryService.LibraryParams Read (AndroidX.VersionedParcelable.VersionedParcel parcel);
	public static void Write (MediaLibraryService.LibraryParams obj, AndroidX.VersionedParcelable.VersionedParcel parcel);
}
```

#### New Type: AndroidX.Media2.Session.LibraryResult

```csharp
public class LibraryResult : AndroidX.VersionedParcelable.CustomVersionedParcelable, Android.Runtime.IJavaObject, AndroidX.VersionedParcelable.IVersionedParcelable, System.IDisposable {
	// constructors
	public LibraryResult (int resultCode);
	protected LibraryResult (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
	public LibraryResult (int resultCode, AndroidX.Medai2.Common.MediaItem item, MediaLibraryService.LibraryParams params);
	public LibraryResult (int resultCode, System.Collections.Generic.IList<AndroidX.Medai2.Common.MediaItem> items, MediaLibraryService.LibraryParams params);
	// properties
	public virtual long CompletionTime { get; }
	public virtual MediaLibraryService.LibraryParams LibraryParams { get; }
	public virtual AndroidX.Medai2.Common.MediaItem MediaItem { get; }
	public virtual System.Collections.Generic.IList<AndroidX.Medai2.Common.MediaItem> MediaItems { get; }
	public virtual int ResultCode { get; }
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }

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
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public static LibraryResult Read (AndroidX.VersionedParcelable.VersionedParcel parcel);
	public static void Write (LibraryResult obj, AndroidX.VersionedParcelable.VersionedParcel parcel);
}
```

#### New Type: AndroidX.Media2.Session.MediaController

```csharp
public class MediaController : Java.Lang.Object, Android.Runtime.IJavaObject, Java.Lang.IAutoCloseable, System.IDisposable {
	// constructors
	protected MediaController (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
	// properties
	public virtual SessionCommandGroup AllowedCommands { get; }
	public virtual long BufferedPosition { get; }
	public virtual int BufferingState { get; }
	public virtual SessionToken ConnectedToken { get; }
	public virtual AndroidX.Medai2.Common.MediaItem CurrentMediaItem { get; }
	public virtual int CurrentMediaItemIndex { get; }
	public virtual long CurrentPosition { get; }
	public virtual long Duration { get; }
	public virtual System.Collections.Generic.IList<AndroidX.Core.Util.Pair> ExtraCallbacks { get; }
	public virtual bool IsConnected { get; }
	public virtual int NextMediaItemIndex { get; }
	public virtual float PlaybackSpeed { get; }
	public virtual int PlayerState { get; }
	public virtual System.Collections.Generic.IList<AndroidX.Medai2.Common.MediaItem> Playlist { get; }
	public virtual AndroidX.Medai2.Common.MediaMetadata PlaylistMetadata { get; }
	public virtual int PreviousMediaItemIndex { get; }
	public virtual int RepeatMode { get; }
	public virtual Android.App.PendingIntent SessionActivity { get; }
	public virtual int ShuffleMode { get; }
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	public virtual System.Collections.Generic.IList<AndroidX.Medai2.Common.SessionPlayer.TrackInfo> TrackInfo { get; }
	public virtual AndroidX.Medai2.Common.VideoSize VideoSize { get; }
	// methods
	public virtual Google.Common.Util.Concurrent.IListenableFuture AddPlaylistItem (int index, string mediaId);
	public virtual Google.Common.Util.Concurrent.IListenableFuture AdjustVolume (int direction, int flags);
	public virtual void Close ();
	public virtual Google.Common.Util.Concurrent.IListenableFuture DeselectTrack (AndroidX.Medai2.Common.SessionPlayer.TrackInfo trackInfo);
	public virtual Google.Common.Util.Concurrent.IListenableFuture FastForward ();
	public virtual MediaController.PlaybackInfo GetPlaybackInfo ();
	public virtual AndroidX.Medai2.Common.SessionPlayer.TrackInfo GetSelectedTrack (int trackType);
	public virtual void NotifyControllerCallback (MediaController.IControllerCallbackRunnable callbackRunnable);
	public virtual Google.Common.Util.Concurrent.IListenableFuture Pause ();
	public virtual Google.Common.Util.Concurrent.IListenableFuture Play ();
	public virtual Google.Common.Util.Concurrent.IListenableFuture PlayFromMediaId (string mediaId, Android.OS.Bundle extras);
	public virtual Google.Common.Util.Concurrent.IListenableFuture PlayFromSearch (string query, Android.OS.Bundle extras);
	public virtual Google.Common.Util.Concurrent.IListenableFuture PlayFromUri (Android.Net.Uri uri, Android.OS.Bundle extras);
	public virtual Google.Common.Util.Concurrent.IListenableFuture Prepare ();
	public virtual Google.Common.Util.Concurrent.IListenableFuture PrepareFromMediaId (string mediaId, Android.OS.Bundle extras);
	public virtual Google.Common.Util.Concurrent.IListenableFuture PrepareFromSearch (string query, Android.OS.Bundle extras);
	public virtual Google.Common.Util.Concurrent.IListenableFuture PrepareFromUri (Android.Net.Uri uri, Android.OS.Bundle extras);
	public virtual void RegisterExtraCallback (Java.Util.Concurrent.IExecutor executor, MediaController.ControllerCallback callback);
	public virtual Google.Common.Util.Concurrent.IListenableFuture RemovePlaylistItem (int index);
	public virtual Google.Common.Util.Concurrent.IListenableFuture ReplacePlaylistItem (int index, string mediaId);
	public virtual Google.Common.Util.Concurrent.IListenableFuture Rewind ();
	public virtual Google.Common.Util.Concurrent.IListenableFuture SeekTo (long pos);
	public virtual Google.Common.Util.Concurrent.IListenableFuture SelectTrack (AndroidX.Medai2.Common.SessionPlayer.TrackInfo trackInfo);
	public virtual Google.Common.Util.Concurrent.IListenableFuture SendCustomCommand (SessionCommand command, Android.OS.Bundle args);
	public virtual Google.Common.Util.Concurrent.IListenableFuture SetMediaItem (string mediaId);
	public virtual Google.Common.Util.Concurrent.IListenableFuture SetPlaybackSpeed (float speed);
	public virtual Google.Common.Util.Concurrent.IListenableFuture SetPlaylist (System.Collections.Generic.IList<string> list, AndroidX.Medai2.Common.MediaMetadata metadata);
	public virtual Google.Common.Util.Concurrent.IListenableFuture SetRating (string mediaId, AndroidX.Medai2.Common.IRating rating);
	public virtual Google.Common.Util.Concurrent.IListenableFuture SetRepeatMode (int repeatMode);
	public virtual Google.Common.Util.Concurrent.IListenableFuture SetShuffleMode (int shuffleMode);
	public virtual Google.Common.Util.Concurrent.IListenableFuture SetSurface (Android.Views.Surface surface);
	public virtual void SetTimeDiff (Java.Lang.Long timeDiff);
	public virtual Google.Common.Util.Concurrent.IListenableFuture SetVolumeTo (int value, int flags);
	public virtual Google.Common.Util.Concurrent.IListenableFuture SkipBackward ();
	public virtual Google.Common.Util.Concurrent.IListenableFuture SkipForward ();
	public virtual Google.Common.Util.Concurrent.IListenableFuture SkipToNextPlaylistItem ();
	public virtual Google.Common.Util.Concurrent.IListenableFuture SkipToPlaylistItem (int index);
	public virtual Google.Common.Util.Concurrent.IListenableFuture SkipToPreviousPlaylistItem ();
	public virtual void UnregisterExtraCallback (MediaController.ControllerCallback callback);
	public virtual Google.Common.Util.Concurrent.IListenableFuture UpdatePlaylistMetadata (AndroidX.Medai2.Common.MediaMetadata metadata);

	// inner types
	public sealed class Builder : Java.Lang.Object {
		// constructors
		public MediaController.Builder (Android.Content.Context context);
		// properties
		protected override IntPtr ThresholdClass { get; }
		protected override System.Type ThresholdType { get; }
		// methods
		public MediaController Build ();
	}
	public abstract class BuilderBase : Java.Lang.Object {
		// constructors
		protected MediaController.BuilderBase (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
		// properties
		protected override IntPtr ThresholdClass { get; }
		protected override System.Type ThresholdType { get; }
		// methods
		public virtual Java.Lang.Object SetConnectionHints (Android.OS.Bundle connectionHints);
		public virtual Java.Lang.Object SetControllerCallback (Java.Util.Concurrent.IExecutor executor, Java.Lang.Object callback);
		public virtual Java.Lang.Object SetSessionCompatToken (Android.Support.V4.Media.Session.MediaSessionCompat.Token compatToken);
		public virtual Java.Lang.Object SetSessionToken (SessionToken token);
	}
	public abstract class ControllerCallback : Java.Lang.Object {
		// constructors
		public MediaController.ControllerCallback ();
		protected MediaController.ControllerCallback (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
		// properties
		protected override IntPtr ThresholdClass { get; }
		protected override System.Type ThresholdType { get; }
		// methods
		public virtual void OnAllowedCommandsChanged (MediaController controller, SessionCommandGroup commands);
		public virtual void OnBufferingStateChanged (MediaController controller, AndroidX.Medai2.Common.MediaItem item, int state);
		public virtual void OnConnected (MediaController controller, SessionCommandGroup allowedCommands);
		public virtual void OnCurrentMediaItemChanged (MediaController controller, AndroidX.Medai2.Common.MediaItem item);
		public virtual SessionResult OnCustomCommand (MediaController controller, SessionCommand command, Android.OS.Bundle args);
		public virtual void OnDisconnected (MediaController controller);
		public virtual void OnPlaybackCompleted (MediaController controller);
		public virtual void OnPlaybackInfoChanged (MediaController controller, MediaController.PlaybackInfo info);
		public virtual void OnPlaybackSpeedChanged (MediaController controller, float speed);
		public virtual void OnPlayerStateChanged (MediaController controller, int state);
		public virtual void OnPlaylistChanged (MediaController controller, System.Collections.Generic.IList<AndroidX.Medai2.Common.MediaItem> list, AndroidX.Medai2.Common.MediaMetadata metadata);
		public virtual void OnPlaylistMetadataChanged (MediaController controller, AndroidX.Medai2.Common.MediaMetadata metadata);
		public virtual void OnRepeatModeChanged (MediaController controller, int repeatMode);
		public virtual void OnSeekCompleted (MediaController controller, long position);
		public virtual int OnSetCustomLayout (MediaController controller, System.Collections.Generic.IList<MediaSession.CommandButton> layout);
		public virtual void OnShuffleModeChanged (MediaController controller, int shuffleMode);
		public virtual void OnSubtitleData (MediaController controller, AndroidX.Medai2.Common.MediaItem item, AndroidX.Medai2.Common.SessionPlayer.TrackInfo track, AndroidX.Medai2.Common.SubtitleData data);
		public virtual void OnTrackDeselected (MediaController controller, AndroidX.Medai2.Common.SessionPlayer.TrackInfo trackInfo);
		public virtual void OnTrackInfoChanged (MediaController controller, System.Collections.Generic.IList<AndroidX.Medai2.Common.SessionPlayer.TrackInfo> trackInfos);
		public virtual void OnTrackSelected (MediaController controller, AndroidX.Medai2.Common.SessionPlayer.TrackInfo trackInfo);
		public virtual void OnVideoSizeChanged (MediaController controller, AndroidX.Medai2.Common.MediaItem item, AndroidX.Medai2.Common.VideoSize videoSize);
	}
	public interface IControllerCallbackRunnable : Android.Runtime.IJavaObject, System.IDisposable {
		// methods
		public virtual void Run (MediaController.ControllerCallback p0);
	}
	public interface IMediaControllerImpl : Android.Runtime.IJavaObject, Java.Lang.IAutoCloseable, System.IDisposable {
		// properties
		public virtual SessionCommandGroup AllowedCommands { get; }
		public virtual Android.Support.V4.Media.MediaBrowserCompat BrowserCompat { get; }
		public virtual long BufferedPosition { get; }
		public virtual int BufferingState { get; }
		public virtual SessionToken ConnectedToken { get; }
		public virtual Android.Content.Context Context { get; }
		public virtual AndroidX.Medai2.Common.MediaItem CurrentMediaItem { get; }
		public virtual int CurrentMediaItemIndex { get; }
		public virtual long CurrentPosition { get; }
		public virtual long Duration { get; }
		public virtual bool IsConnected { get; }
		public virtual int NextMediaItemIndex { get; }
		public virtual MediaController.PlaybackInfo PlaybackInfo { get; }
		public virtual float PlaybackSpeed { get; }
		public virtual int PlayerState { get; }
		public virtual System.Collections.Generic.IList<AndroidX.Medai2.Common.MediaItem> Playlist { get; }
		public virtual AndroidX.Medai2.Common.MediaMetadata PlaylistMetadata { get; }
		public virtual int PreviousMediaItemIndex { get; }
		public virtual int RepeatMode { get; }
		public virtual Android.App.PendingIntent SessionActivity { get; }
		public virtual int ShuffleMode { get; }
		public virtual System.Collections.Generic.IList<AndroidX.Medai2.Common.SessionPlayer.TrackInfo> TrackInfo { get; }
		public virtual AndroidX.Medai2.Common.VideoSize VideoSize { get; }
		// methods
		public virtual Google.Common.Util.Concurrent.IListenableFuture AddPlaylistItem (int p0, string p1);
		public virtual Google.Common.Util.Concurrent.IListenableFuture AdjustVolume (int p0, int p1);
		public virtual Google.Common.Util.Concurrent.IListenableFuture DeselectTrack (AndroidX.Medai2.Common.SessionPlayer.TrackInfo p0);
		public virtual Google.Common.Util.Concurrent.IListenableFuture FastForward ();
		public virtual AndroidX.Medai2.Common.SessionPlayer.TrackInfo GetSelectedTrack (int p0);
		public virtual Google.Common.Util.Concurrent.IListenableFuture Pause ();
		public virtual Google.Common.Util.Concurrent.IListenableFuture Play ();
		public virtual Google.Common.Util.Concurrent.IListenableFuture PlayFromMediaId (string p0, Android.OS.Bundle p1);
		public virtual Google.Common.Util.Concurrent.IListenableFuture PlayFromSearch (string p0, Android.OS.Bundle p1);
		public virtual Google.Common.Util.Concurrent.IListenableFuture PlayFromUri (Android.Net.Uri p0, Android.OS.Bundle p1);
		public virtual Google.Common.Util.Concurrent.IListenableFuture Prepare ();
		public virtual Google.Common.Util.Concurrent.IListenableFuture PrepareFromMediaId (string p0, Android.OS.Bundle p1);
		public virtual Google.Common.Util.Concurrent.IListenableFuture PrepareFromSearch (string p0, Android.OS.Bundle p1);
		public virtual Google.Common.Util.Concurrent.IListenableFuture PrepareFromUri (Android.Net.Uri p0, Android.OS.Bundle p1);
		public virtual Google.Common.Util.Concurrent.IListenableFuture RemovePlaylistItem (int p0);
		public virtual Google.Common.Util.Concurrent.IListenableFuture ReplacePlaylistItem (int p0, string p1);
		public virtual Google.Common.Util.Concurrent.IListenableFuture Rewind ();
		public virtual Google.Common.Util.Concurrent.IListenableFuture SeekTo (long p0);
		public virtual Google.Common.Util.Concurrent.IListenableFuture SelectTrack (AndroidX.Medai2.Common.SessionPlayer.TrackInfo p0);
		public virtual Google.Common.Util.Concurrent.IListenableFuture SendCustomCommand (SessionCommand p0, Android.OS.Bundle p1);
		public virtual Google.Common.Util.Concurrent.IListenableFuture SetMediaItem (string p0);
		public virtual Google.Common.Util.Concurrent.IListenableFuture SetPlaybackSpeed (float p0);
		public virtual Google.Common.Util.Concurrent.IListenableFuture SetPlaylist (System.Collections.Generic.IList<string> p0, AndroidX.Medai2.Common.MediaMetadata p1);
		public virtual Google.Common.Util.Concurrent.IListenableFuture SetRating (string p0, AndroidX.Medai2.Common.IRating p1);
		public virtual Google.Common.Util.Concurrent.IListenableFuture SetRepeatMode (int p0);
		public virtual Google.Common.Util.Concurrent.IListenableFuture SetShuffleMode (int p0);
		public virtual Google.Common.Util.Concurrent.IListenableFuture SetSurface (Android.Views.Surface p0);
		public virtual Google.Common.Util.Concurrent.IListenableFuture SetVolumeTo (int p0, int p1);
		public virtual Google.Common.Util.Concurrent.IListenableFuture SkipBackward ();
		public virtual Google.Common.Util.Concurrent.IListenableFuture SkipForward ();
		public virtual Google.Common.Util.Concurrent.IListenableFuture SkipToNextItem ();
		public virtual Google.Common.Util.Concurrent.IListenableFuture SkipToPlaylistItem (int p0);
		public virtual Google.Common.Util.Concurrent.IListenableFuture SkipToPreviousItem ();
		public virtual Google.Common.Util.Concurrent.IListenableFuture UpdatePlaylistMetadata (AndroidX.Medai2.Common.MediaMetadata p0);
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
		protected override IntPtr ThresholdClass { get; }
		protected override System.Type ThresholdType { get; }
	}
}
```

#### New Type: AndroidX.Media2.Session.MediaControllerStub

```csharp
public abstract class MediaControllerStub : Android.OS.Binder, Android.OS.IInterface, Android.Runtime.IJavaObject, IMediaController, System.IDisposable {
	// constructors
	public MediaControllerStub ();
	protected MediaControllerStub (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
	// properties
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public virtual Android.OS.IBinder AsBinder ();
	public static IMediaController AsInterface (Android.OS.IBinder obj);
	public virtual void OnAllowedCommandsChanged (int p0, AndroidX.VersionedParcelable.ParcelImpl p1);
	public virtual void OnBufferingStateChanged (int p0, AndroidX.VersionedParcelable.ParcelImpl p1, int p2, long p3, long p4, long p5);
	public virtual void OnChildrenChanged (int p0, string p1, int p2, AndroidX.VersionedParcelable.ParcelImpl p3);
	public virtual void OnConnected (int p0, AndroidX.VersionedParcelable.ParcelImpl p1);
	public virtual void OnCurrentMediaItemChanged (int p0, AndroidX.VersionedParcelable.ParcelImpl p1, int p2, int p3, int p4);
	public virtual void OnCustomCommand (int p0, AndroidX.VersionedParcelable.ParcelImpl p1, Android.OS.Bundle p2);
	public virtual void OnDisconnected (int p0);
	public virtual void OnLibraryResult (int p0, AndroidX.VersionedParcelable.ParcelImpl p1);
	public virtual void OnPlaybackCompleted (int p0);
	public virtual void OnPlaybackInfoChanged (int p0, AndroidX.VersionedParcelable.ParcelImpl p1);
	public virtual void OnPlaybackSpeedChanged (int p0, long p1, long p2, float p3);
	public virtual void OnPlayerStateChanged (int p0, long p1, long p2, int p3);
	public virtual void OnPlaylistChanged (int p0, AndroidX.Medai2.Common.ParcelImplListSlice p1, AndroidX.VersionedParcelable.ParcelImpl p2, int p3, int p4, int p5);
	public virtual void OnPlaylistMetadataChanged (int p0, AndroidX.VersionedParcelable.ParcelImpl p1);
	public virtual void OnRepeatModeChanged (int p0, int p1, int p2, int p3, int p4);
	public virtual void OnSearchResultChanged (int p0, string p1, int p2, AndroidX.VersionedParcelable.ParcelImpl p3);
	public virtual void OnSeekCompleted (int p0, long p1, long p2, long p3);
	public virtual void OnSessionResult (int p0, AndroidX.VersionedParcelable.ParcelImpl p1);
	public virtual void OnSetCustomLayout (int p0, System.Collections.Generic.IList<AndroidX.VersionedParcelable.ParcelImpl> p1);
	public virtual void OnShuffleModeChanged (int p0, int p1, int p2, int p3, int p4);
	public virtual void OnSubtitleData (int p0, AndroidX.VersionedParcelable.ParcelImpl p1, AndroidX.VersionedParcelable.ParcelImpl p2, AndroidX.VersionedParcelable.ParcelImpl p3);
	public virtual void OnTrackDeselected (int p0, AndroidX.VersionedParcelable.ParcelImpl p1);
	public virtual void OnTrackInfoChanged (int p0, System.Collections.Generic.IList<AndroidX.VersionedParcelable.ParcelImpl> p1, AndroidX.VersionedParcelable.ParcelImpl p2, AndroidX.VersionedParcelable.ParcelImpl p3, AndroidX.VersionedParcelable.ParcelImpl p4, AndroidX.VersionedParcelable.ParcelImpl p5);
	public virtual void OnTrackSelected (int p0, AndroidX.VersionedParcelable.ParcelImpl p1);
	public virtual bool OnTransact (int code, Android.OS.Parcel data, Android.OS.Parcel reply, int flags);
	public virtual void OnVideoSizeChanged (int p0, AndroidX.VersionedParcelable.ParcelImpl p1, AndroidX.VersionedParcelable.ParcelImpl p2);
}
```

#### New Type: AndroidX.Media2.Session.MediaLibraryService

```csharp
public abstract class MediaLibraryService : AndroidX.Media2.Session.MediaSessionService {
	// constructors
	public MediaLibraryService ();
	protected MediaLibraryService (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
	// fields
	public static const string ServiceInterface = "androidx.media2.session.MediaLibraryService";
	// properties
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }

	// inner types
	public sealed class LibraryParams : Java.Lang.Object, Android.Runtime.IJavaObject, AndroidX.VersionedParcelable.IVersionedParcelable, System.IDisposable {
		// properties
		public Android.OS.Bundle Extras { get; }
		public bool IsOffline { get; }
		public bool IsRecent { get; }
		public bool IsSuggested { get; }
		protected override IntPtr ThresholdClass { get; }
		protected override System.Type ThresholdType { get; }

		// inner types
		public sealed class Builder : Java.Lang.Object {
			// constructors
			public MediaLibraryService.LibraryParams.Builder ();
			// properties
			protected override IntPtr ThresholdClass { get; }
			protected override System.Type ThresholdType { get; }
			// methods
			public MediaLibraryService.LibraryParams Build ();
			public MediaLibraryService.LibraryParams.Builder SetExtras (Android.OS.Bundle extras);
			public MediaLibraryService.LibraryParams.Builder SetOffline (bool offline);
			public MediaLibraryService.LibraryParams.Builder SetRecent (bool recent);
			public MediaLibraryService.LibraryParams.Builder SetSuggested (bool suggested);
		}
	}
	public sealed class MediaLibrarySession : AndroidX.Media2.Session.MediaSession, Android.Runtime.IJavaObject, Java.Lang.IAutoCloseable, System.IDisposable {
		// properties
		protected override IntPtr ThresholdClass { get; }
		protected override System.Type ThresholdType { get; }
		// methods
		public void NotifyChildrenChanged (string parentId, int itemCount, MediaLibraryService.LibraryParams params);
		public void NotifyChildrenChanged (MediaSession.ControllerInfo controller, string parentId, int itemCount, MediaLibraryService.LibraryParams params);
		public void NotifySearchResultChanged (MediaSession.ControllerInfo controller, string query, int itemCount, MediaLibraryService.LibraryParams params);

		// inner types
		public sealed class Builder : Java.Lang.Object {
			// constructors
			public MediaLibraryService.LibraryParams.MediaLibrarySession.Builder (MediaLibraryService service, AndroidX.Medai2.Common.SessionPlayer player, Java.Util.Concurrent.IExecutor callbackExecutor, MediaLibraryService.MediaLibrarySession.MediaLibrarySessionCallback callback);
			// properties
			protected override IntPtr ThresholdClass { get; }
			protected override System.Type ThresholdType { get; }
			// methods
			public MediaLibraryService.MediaLibrarySession Build ();
			public MediaLibraryService.MediaLibrarySession.Builder SetId (string id);
			public MediaLibraryService.MediaLibrarySession.Builder SetSessionActivity (Android.App.PendingIntent pi);
		}
		public class MediaLibrarySessionCallback : AndroidX.Media2.Session.MediaSession+SessionCallback {
			// constructors
			public MediaLibraryService.LibraryParams.MediaLibrarySession.MediaLibrarySessionCallback ();
			protected MediaLibraryService.LibraryParams.MediaLibrarySession.MediaLibrarySessionCallback (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
			// properties
			protected override IntPtr ThresholdClass { get; }
			protected override System.Type ThresholdType { get; }
			// methods
			public virtual LibraryResult OnGetChildren (MediaLibraryService.MediaLibrarySession session, MediaSession.ControllerInfo controller, string parentId, int page, int pageSize, MediaLibraryService.LibraryParams params);
			public virtual LibraryResult OnGetItem (MediaLibraryService.MediaLibrarySession session, MediaSession.ControllerInfo controller, string mediaId);
			public virtual LibraryResult OnGetLibraryRoot (MediaLibraryService.MediaLibrarySession session, MediaSession.ControllerInfo controller, MediaLibraryService.LibraryParams params);
			public virtual LibraryResult OnGetSearchResult (MediaLibraryService.MediaLibrarySession session, MediaSession.ControllerInfo controller, string query, int page, int pageSize, MediaLibraryService.LibraryParams params);
			public virtual int OnSearch (MediaLibraryService.MediaLibrarySession session, MediaSession.ControllerInfo controller, string query, MediaLibraryService.LibraryParams params);
			public virtual int OnSubscribe (MediaLibraryService.MediaLibrarySession session, MediaSession.ControllerInfo controller, string parentId, MediaLibraryService.LibraryParams params);
			public virtual int OnUnsubscribe (MediaLibraryService.MediaLibrarySession session, MediaSession.ControllerInfo controller, string parentId);
		}
	}
}
```

#### New Type: AndroidX.Media2.Session.MediaNotificationHandler

```csharp
public class MediaNotificationHandler : Java.Lang.Object {
	// constructors
	public MediaNotificationHandler (MediaSessionService service);
	protected MediaNotificationHandler (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
	// properties
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public virtual void OnPlayerStateChanged (MediaSession session, int state);
	public virtual void OnSessionClosed (MediaSession session);
	public virtual MediaSessionService.MediaNotification OnUpdateNotification (MediaSession session);
}
```

#### New Type: AndroidX.Media2.Session.MediaSession

```csharp
public class MediaSession : Java.Lang.Object, Android.Runtime.IJavaObject, Java.Lang.IAutoCloseable, System.IDisposable {
	// constructors
	protected MediaSession (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
	// properties
	public virtual System.Collections.Generic.IList<MediaSession.ControllerInfo> ConnectedControllers { get; }
	public virtual string Id { get; }
	public virtual bool IsClosed { get; }
	public virtual AndroidX.Medai2.Common.SessionPlayer Player { get; }
	public virtual Android.Support.V4.Media.Session.MediaSessionCompat SessionCompat { get; }
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	public virtual SessionToken Token { get; }
	// methods
	public virtual void BroadcastCustomCommand (SessionCommand command, Android.OS.Bundle args);
	public virtual void Close ();
	public virtual Google.Common.Util.Concurrent.IListenableFuture SendCustomCommand (MediaSession.ControllerInfo controller, SessionCommand command, Android.OS.Bundle args);
	public virtual void SetAllowedCommands (MediaSession.ControllerInfo controller, SessionCommandGroup commands);
	public virtual Google.Common.Util.Concurrent.IListenableFuture SetCustomLayout (MediaSession.ControllerInfo controller, System.Collections.Generic.IList<MediaSession.CommandButton> layout);
	public virtual void UpdatePlayer (AndroidX.Medai2.Common.SessionPlayer player);

	// inner types
	public sealed class Builder : Java.Lang.Object {
		// constructors
		public MediaSession.Builder (Android.Content.Context context, AndroidX.Medai2.Common.SessionPlayer player);
		// properties
		protected override IntPtr ThresholdClass { get; }
		protected override System.Type ThresholdType { get; }
		// methods
		public MediaSession Build ();
		public MediaSession.Builder SetId (string id);
		public MediaSession.Builder SetSessionActivity (Android.App.PendingIntent pi);
		public MediaSession.Builder SetSessionCallback (Java.Util.Concurrent.IExecutor executor, MediaSession.SessionCallback callback);
	}
	public abstract class BuilderBase : Java.Lang.Object {
		// constructors
		protected MediaSession.BuilderBase (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
		// properties
		protected override IntPtr ThresholdClass { get; }
		protected override System.Type ThresholdType { get; }
		// methods
		public virtual Java.Lang.Object SetExtras (Android.OS.Bundle extras);
	}
	public sealed class CommandButton : Java.Lang.Object, Android.Runtime.IJavaObject, AndroidX.VersionedParcelable.IVersionedParcelable, System.IDisposable {
		// properties
		public SessionCommand Command { get; }
		public string DisplayName { get; }
		public Java.Lang.ICharSequence DisplayNameFormatted { get; }
		public Android.OS.Bundle Extras { get; }
		public int IconResId { get; }
		public bool IsEnabled { get; }
		protected override IntPtr ThresholdClass { get; }
		protected override System.Type ThresholdType { get; }

		// inner types
		public sealed class Builder : Java.Lang.Object {
			// constructors
			public MediaSession.CommandButton.Builder ();
			// properties
			protected override IntPtr ThresholdClass { get; }
			protected override System.Type ThresholdType { get; }
			// methods
			public MediaSession.CommandButton Build ();
			public MediaSession.CommandButton.Builder SetCommand (SessionCommand command);
			public MediaSession.CommandButton.Builder SetDisplayName (Java.Lang.ICharSequence displayName);
			public MediaSession.CommandButton.Builder SetDisplayName (string displayName);
			public MediaSession.CommandButton.Builder SetEnabled (bool enabled);
			public MediaSession.CommandButton.Builder SetExtras (Android.OS.Bundle extras);
			public MediaSession.CommandButton.Builder SetIconResId (int resId);
		}
	}
	public abstract class ControllerCb : Java.Lang.Object {
		// constructors
		protected MediaSession.CommandButton.ControllerCb (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
		// properties
		protected override IntPtr ThresholdClass { get; }
		protected override System.Type ThresholdType { get; }
	}
	public sealed class ControllerInfo : Java.Lang.Object {
		// properties
		public Android.OS.Bundle ConnectionHints { get; }
		public bool IsTrusted { get; }
		public string PackageName { get; }
		public AndroidX.Media.MediaSessionManager.RemoteUserInfo RemoteUserInfo { get; }
		protected override IntPtr ThresholdClass { get; }
		protected override System.Type ThresholdType { get; }
		public int Uid { get; }
	}
	public abstract class SessionCallback : Java.Lang.Object {
		// constructors
		public MediaSession.CommandButton.SessionCallback ();
		protected MediaSession.CommandButton.SessionCallback (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
		// properties
		protected override IntPtr ThresholdClass { get; }
		protected override System.Type ThresholdType { get; }
		// methods
		public virtual int OnCommandRequest (MediaSession session, MediaSession.ControllerInfo controller, SessionCommand command);
		public virtual SessionCommandGroup OnConnect (MediaSession session, MediaSession.ControllerInfo controller);
		public virtual AndroidX.Medai2.Common.MediaItem OnCreateMediaItem (MediaSession session, MediaSession.ControllerInfo controller, string mediaId);
		public virtual SessionResult OnCustomCommand (MediaSession session, MediaSession.ControllerInfo controller, SessionCommand customCommand, Android.OS.Bundle args);
		public virtual void OnDisconnected (MediaSession session, MediaSession.ControllerInfo controller);
		public virtual int OnFastForward (MediaSession session, MediaSession.ControllerInfo controller);
		public virtual int OnPlayFromMediaId (MediaSession session, MediaSession.ControllerInfo controller, string mediaId, Android.OS.Bundle extras);
		public virtual int OnPlayFromSearch (MediaSession session, MediaSession.ControllerInfo controller, string query, Android.OS.Bundle extras);
		public virtual int OnPlayFromUri (MediaSession session, MediaSession.ControllerInfo controller, Android.Net.Uri uri, Android.OS.Bundle extras);
		public virtual void OnPostConnect (MediaSession session, MediaSession.ControllerInfo controller);
		public virtual int OnPrepareFromMediaId (MediaSession session, MediaSession.ControllerInfo controller, string mediaId, Android.OS.Bundle extras);
		public virtual int OnPrepareFromSearch (MediaSession session, MediaSession.ControllerInfo controller, string query, Android.OS.Bundle extras);
		public virtual int OnPrepareFromUri (MediaSession session, MediaSession.ControllerInfo controller, Android.Net.Uri uri, Android.OS.Bundle extras);
		public virtual int OnRewind (MediaSession session, MediaSession.ControllerInfo controller);
		public virtual int OnSetRating (MediaSession session, MediaSession.ControllerInfo controller, string mediaId, AndroidX.Medai2.Common.IRating rating);
		public virtual int OnSkipBackward (MediaSession session, MediaSession.ControllerInfo controller);
		public virtual int OnSkipForward (MediaSession session, MediaSession.ControllerInfo controller);

		// inner types
		public abstract class ForegroundServiceEventCallback : Java.Lang.Object {
			// constructors
			protected MediaSession.CommandButton.SessionCallback.ForegroundServiceEventCallback (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
			// properties
			protected override IntPtr ThresholdClass { get; }
			protected override System.Type ThresholdType { get; }
			// methods
			public virtual void OnPlayerStateChanged (MediaSession session, int state);
			public virtual void OnSessionClosed (MediaSession session);
		}
	}
}
```

#### New Type: AndroidX.Media2.Session.MediaSessionManager

```csharp
public sealed class MediaSessionManager : Java.Lang.Object {
	// properties
	public System.Collections.Generic.ICollection<SessionToken> SessionServiceTokens { get; }
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public static MediaSessionManager GetInstance (Android.Content.Context context);
}
```

#### New Type: AndroidX.Media2.Session.MediaSessionService

```csharp
public abstract class MediaSessionService : Android.App.Service {
	// constructors
	public MediaSessionService ();
	protected MediaSessionService (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
	// fields
	public static const string ServiceInterface = "androidx.media2.session.MediaSessionService";
	// properties
	public System.Collections.Generic.IList<MediaSession> Sessions { get; }
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public void AddSession (MediaSession session);
	public override Android.OS.IBinder OnBind (Android.Content.Intent intent);
	public virtual MediaSession OnGetSession (MediaSession.ControllerInfo p0);
	public virtual MediaSessionService.MediaNotification OnUpdateNotification (MediaSession session);
	public void RemoveSession (MediaSession session);

	// inner types
	public interface IMediaSessionServiceImpl : Android.Runtime.IJavaObject, System.IDisposable {
		// properties
		public virtual System.Collections.Generic.IList<MediaSession> Sessions { get; }
		// methods
		public virtual void AddSession (MediaSession p0);
		public virtual Android.OS.IBinder OnBind (Android.Content.Intent p0);
		public virtual void OnCreate (MediaSessionService p0);
		public virtual void OnDestroy ();
		public virtual int OnStartCommand (Android.Content.Intent p0, int p1, int p2);
		public virtual MediaSessionService.MediaNotification OnUpdateNotification (MediaSession p0);
		public virtual void RemoveSession (MediaSession p0);
	}
	public class MediaNotification : Java.Lang.Object {
		// constructors
		public MediaSessionService.MediaNotification (int notificationId, Android.App.Notification notification);
		protected MediaSessionService.MediaNotification (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
		// properties
		public virtual Android.App.Notification Notification { get; }
		public virtual int NotificationId { get; }
		protected override IntPtr ThresholdClass { get; }
		protected override System.Type ThresholdType { get; }
	}
}
```

#### New Type: AndroidX.Media2.Session.MediaSessionServiceStub

```csharp
public abstract class MediaSessionServiceStub : Android.OS.Binder, Android.OS.IInterface, Android.Runtime.IJavaObject, IMediaSessionService, System.IDisposable {
	// constructors
	public MediaSessionServiceStub ();
	protected MediaSessionServiceStub (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
	// properties
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public virtual Android.OS.IBinder AsBinder ();
	public static IMediaSessionService AsInterface (Android.OS.IBinder obj);
	public virtual void Connect (IMediaController p0, AndroidX.VersionedParcelable.ParcelImpl p1);
	public virtual bool OnTransact (int code, Android.OS.Parcel data, Android.OS.Parcel reply, int flags);
}
```

#### New Type: AndroidX.Media2.Session.MediaSessionStub

```csharp
public abstract class MediaSessionStub : Android.OS.Binder, Android.OS.IInterface, Android.Runtime.IJavaObject, IMediaSession, System.IDisposable {
	// constructors
	public MediaSessionStub ();
	protected MediaSessionStub (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
	// properties
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public virtual void AddPlaylistItem (IMediaController p0, int p1, int p2, string p3);
	public virtual void AdjustVolume (IMediaController p0, int p1, int p2, int p3);
	public virtual Android.OS.IBinder AsBinder ();
	public static IMediaSession AsInterface (Android.OS.IBinder obj);
	public virtual void Connect (IMediaController p0, int p1, AndroidX.VersionedParcelable.ParcelImpl p2);
	public virtual void DeselectTrack (IMediaController p0, int p1, AndroidX.VersionedParcelable.ParcelImpl p2);
	public virtual void FastForward (IMediaController p0, int p1);
	public virtual void GetChildren (IMediaController p0, int p1, string p2, int p3, int p4, AndroidX.VersionedParcelable.ParcelImpl p5);
	public virtual void GetItem (IMediaController p0, int p1, string p2);
	public virtual void GetLibraryRoot (IMediaController p0, int p1, AndroidX.VersionedParcelable.ParcelImpl p2);
	public virtual void GetSearchResult (IMediaController p0, int p1, string p2, int p3, int p4, AndroidX.VersionedParcelable.ParcelImpl p5);
	public virtual void OnControllerResult (IMediaController p0, int p1, AndroidX.VersionedParcelable.ParcelImpl p2);
	public virtual void OnCustomCommand (IMediaController p0, int p1, AndroidX.VersionedParcelable.ParcelImpl p2, Android.OS.Bundle p3);
	public virtual bool OnTransact (int code, Android.OS.Parcel data, Android.OS.Parcel reply, int flags);
	public virtual void Pause (IMediaController p0, int p1);
	public virtual void Play (IMediaController p0, int p1);
	public virtual void PlayFromMediaId (IMediaController p0, int p1, string p2, Android.OS.Bundle p3);
	public virtual void PlayFromSearch (IMediaController p0, int p1, string p2, Android.OS.Bundle p3);
	public virtual void PlayFromUri (IMediaController p0, int p1, Android.Net.Uri p2, Android.OS.Bundle p3);
	public virtual void Prepare (IMediaController p0, int p1);
	public virtual void PrepareFromMediaId (IMediaController p0, int p1, string p2, Android.OS.Bundle p3);
	public virtual void PrepareFromSearch (IMediaController p0, int p1, string p2, Android.OS.Bundle p3);
	public virtual void PrepareFromUri (IMediaController p0, int p1, Android.Net.Uri p2, Android.OS.Bundle p3);
	public virtual void Release (IMediaController p0, int p1);
	public virtual void RemovePlaylistItem (IMediaController p0, int p1, int p2);
	public virtual void ReplacePlaylistItem (IMediaController p0, int p1, int p2, string p3);
	public virtual void Rewind (IMediaController p0, int p1);
	public virtual void Search (IMediaController p0, int p1, string p2, AndroidX.VersionedParcelable.ParcelImpl p3);
	public virtual void SeekTo (IMediaController p0, int p1, long p2);
	public virtual void SelectTrack (IMediaController p0, int p1, AndroidX.VersionedParcelable.ParcelImpl p2);
	public virtual void SetMediaItem (IMediaController p0, int p1, string p2);
	public virtual void SetPlaybackSpeed (IMediaController p0, int p1, float p2);
	public virtual void SetPlaylist (IMediaController p0, int p1, System.Collections.Generic.IList<string> p2, AndroidX.VersionedParcelable.ParcelImpl p3);
	public virtual void SetRating (IMediaController p0, int p1, string p2, AndroidX.VersionedParcelable.ParcelImpl p3);
	public virtual void SetRepeatMode (IMediaController p0, int p1, int p2);
	public virtual void SetShuffleMode (IMediaController p0, int p1, int p2);
	public virtual void SetSurface (IMediaController p0, int p1, Android.Views.Surface p2);
	public virtual void SetVolumeTo (IMediaController p0, int p1, int p2, int p3);
	public virtual void SkipBackward (IMediaController p0, int p1);
	public virtual void SkipForward (IMediaController p0, int p1);
	public virtual void SkipToNextItem (IMediaController p0, int p1);
	public virtual void SkipToPlaylistItem (IMediaController p0, int p1, int p2);
	public virtual void SkipToPreviousItem (IMediaController p0, int p1);
	public virtual void Subscribe (IMediaController p0, int p1, string p2, AndroidX.VersionedParcelable.ParcelImpl p3);
	public virtual void Unsubscribe (IMediaController p0, int p1, string p2);
	public virtual void UpdatePlaylistMetadata (IMediaController p0, int p1, AndroidX.VersionedParcelable.ParcelImpl p2);
}
```

#### New Type: AndroidX.Media2.Session.MediaUtils

```csharp
public class MediaUtils : Java.Lang.Object {
	// constructors
	protected MediaUtils (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
	// fields
	public static const int CurrentVersion;
	public static const string Tag = "MediaUtils";
	public static const int TransactionSizeLimitInBytes;
	public static const int Version0;
	// properties
	public static Java.Util.Concurrent.IExecutor DirectExecutor { get; }
	public static AndroidX.Media.MediaBrowserServiceCompat.BrowserRoot SDefaultBrowserRoot { get; }
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public static System.Collections.Generic.IList<AndroidX.VersionedParcelable.ParcelImpl> ConvertCommandButtonListToParcelImplList (System.Collections.Generic.IList<MediaSession.CommandButton> commandButtonList);
	public static System.Collections.Generic.IList<AndroidX.Medai2.Common.MediaItem> ConvertMediaItemListToMediaItemList (System.Collections.Generic.IList<Android.Support.V4.Media.MediaBrowserCompat.MediaItem> items);
	public static AndroidX.Medai2.Common.ParcelImplListSlice ConvertMediaItemListToParcelImplListSlice (System.Collections.Generic.IList<AndroidX.Medai2.Common.MediaItem> mediaItemList);
	public static System.Collections.Generic.IList<AndroidX.Medai2.Common.MediaItem> ConvertParcelImplListSliceToMediaItemList (AndroidX.Medai2.Common.ParcelImplListSlice listSlice);
	public static System.Collections.Generic.IList<AndroidX.Medai2.Common.MediaItem> ConvertQueueItemListToMediaItemList (System.Collections.Generic.IList<Android.Support.V4.Media.Session.MediaSessionCompat.QueueItem> items);
	public static System.Collections.Generic.IList<MediaSession.CommandButton> ConvertToCustomLayout (Android.Support.V4.Media.Session.PlaybackStateCompat state);
	public static MediaLibraryService.LibraryParams ConvertToLibraryParams (Android.Content.Context context, Android.OS.Bundle legacyBundle);
	public static AndroidX.Medai2.Common.MediaItem ConvertToMediaItem (Android.Support.V4.Media.MediaBrowserCompat.MediaItem item);
	public static AndroidX.Medai2.Common.MediaItem ConvertToMediaItem (Android.Support.V4.Media.MediaDescriptionCompat descriptionCompat);
	public static AndroidX.Medai2.Common.MediaItem ConvertToMediaItem (Android.Support.V4.Media.MediaMetadataCompat metadataCompat);
	public static AndroidX.Medai2.Common.MediaItem ConvertToMediaItem (Android.Support.V4.Media.Session.MediaSessionCompat.QueueItem item);
	public static Android.Support.V4.Media.MediaBrowserCompat.MediaItem ConvertToMediaItem (AndroidX.Medai2.Common.MediaItem item2);
	public static System.Collections.Generic.IList<Android.Support.V4.Media.MediaBrowserCompat.MediaItem> ConvertToMediaItemList (System.Collections.Generic.IList<AndroidX.Medai2.Common.MediaItem> items);
	public static AndroidX.Medai2.Common.MediaMetadata ConvertToMediaMetadata (Java.Lang.ICharSequence queueTitle);
	public static AndroidX.Medai2.Common.MediaMetadata ConvertToMediaMetadata (string queueTitle);
	public static Android.Support.V4.Media.MediaMetadataCompat ConvertToMediaMetadataCompat (AndroidX.Medai2.Common.MediaMetadata metadata);
	public static int ConvertToPlaybackStateCompatState (int playerState, int bufferingState);
	public static int ConvertToPlayerState (Android.Support.V4.Media.Session.PlaybackStateCompat state);
	public static System.Collections.Generic.IList<Android.Support.V4.Media.Session.MediaSessionCompat.QueueItem> ConvertToQueueItemList (System.Collections.Generic.IList<AndroidX.Medai2.Common.MediaItem> items);
	public static AndroidX.Medai2.Common.IRating ConvertToRating (Android.Support.V4.Media.RatingCompat ratingCompat);
	public static Android.Support.V4.Media.RatingCompat ConvertToRatingCompat (AndroidX.Medai2.Common.IRating rating);
	public static Android.OS.Bundle ConvertToRootHints (MediaLibraryService.LibraryParams params);
	public static SessionCommandGroup ConvertToSessionCommandGroup (long sessionFlags, Android.Support.V4.Media.Session.PlaybackStateCompat state);
	public static Android.Support.V4.Media.MediaDescriptionCompat CreateMediaDescriptionCompat (string mediaId);
	public static bool IsUnparcelableBundle (Android.OS.Bundle bundle);
	public static void KeepUnparcelableBundlesOnly (System.Collections.Generic.IList<Android.OS.Bundle> bundles);
	public static System.Collections.IList RemoveNullElements (System.Collections.IList list);
	public static int ToBufferingState (int playbackStateCompatState);
	public static MediaController.PlaybackInfo ToPlaybackInfo2 (Android.Support.V4.Media.Session.MediaControllerCompat.PlaybackInfo info);
	public static System.Collections.IList TruncateListBySize (System.Collections.IList list, int sizeLimitInBytes);
	public static AndroidX.Medai2.Common.MediaItem UpcastForPreparceling (AndroidX.Medai2.Common.MediaItem item);
}
```

#### New Type: AndroidX.Media2.Session.PercentageRating

```csharp
public sealed class PercentageRating : Java.Lang.Object, Android.Runtime.IJavaObject, AndroidX.Medai2.Common.IRating, AndroidX.VersionedParcelable.IVersionedParcelable, System.IDisposable {
	// constructors
	public PercentageRating ();
	public PercentageRating (float percent);
	// properties
	public virtual bool IsRated { get; }
	public float PercentRating { get; }
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
}
```

#### New Type: AndroidX.Media2.Session.PercentageRatingParcelizer

```csharp
public sealed class PercentageRatingParcelizer : Java.Lang.Object {
	// constructors
	public PercentageRatingParcelizer ();
	// properties
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public static PercentageRating Read (AndroidX.VersionedParcelable.VersionedParcel parcel);
	public static void Write (PercentageRating obj, AndroidX.VersionedParcelable.VersionedParcel parcel);
}
```

#### New Type: AndroidX.Media2.Session.PlaybackInfoParcelizer

```csharp
public sealed class PlaybackInfoParcelizer : Java.Lang.Object {
	// constructors
	public PlaybackInfoParcelizer ();
	// properties
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public static MediaController.PlaybackInfo Read (AndroidX.VersionedParcelable.VersionedParcel parcel);
	public static void Write (MediaController.PlaybackInfo obj, AndroidX.VersionedParcelable.VersionedParcel parcel);
}
```

#### New Type: AndroidX.Media2.Session.SessionCommand

```csharp
public sealed class SessionCommand : Java.Lang.Object, Android.Runtime.IJavaObject, AndroidX.VersionedParcelable.IVersionedParcelable, System.IDisposable {
	// constructors
	public SessionCommand (int commandCode);
	public SessionCommand (string action, Android.OS.Bundle extras);
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
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }

	// inner types
	public interface ICommandCode : Android.Runtime.IJavaObject, Java.Lang.Annotation.IAnnotation, System.IDisposable {
	}
	public interface ICommandVersion : Android.Runtime.IJavaObject, Java.Lang.Annotation.IAnnotation, System.IDisposable {
	}
	public sealed class Range : Java.Lang.Object {
		// properties
		public int Lower { get; set; }
		protected override IntPtr ThresholdClass { get; }
		protected override System.Type ThresholdType { get; }
		public int Upper { get; set; }
	}
}
```

#### New Type: AndroidX.Media2.Session.SessionCommandGroup

```csharp
public sealed class SessionCommandGroup : Java.Lang.Object, Android.Runtime.IJavaObject, AndroidX.VersionedParcelable.IVersionedParcelable, System.IDisposable {
	// constructors
	public SessionCommandGroup ();
	public SessionCommandGroup (System.Collections.Generic.ICollection<SessionCommand> commands);
	// properties
	public System.Collections.Generic.ICollection<SessionCommand> Commands { get; }
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public bool HasCommand (SessionCommand command);
	public bool HasCommand (int commandCode);

	// inner types
	public sealed class Builder : Java.Lang.Object {
		// constructors
		public SessionCommandGroup.Builder ();
		public SessionCommandGroup.Builder (SessionCommandGroup commandGroup);
		// properties
		protected override IntPtr ThresholdClass { get; }
		protected override System.Type ThresholdType { get; }
		// methods
		public SessionCommandGroup.Builder AddAllPredefinedCommands (int version);
		public SessionCommandGroup.Builder AddCommand (SessionCommand command);
		public SessionCommandGroup Build ();
		public SessionCommandGroup.Builder RemoveCommand (SessionCommand command);
	}
}
```

#### New Type: AndroidX.Media2.Session.SessionCommandGroupParcelizer

```csharp
public sealed class SessionCommandGroupParcelizer : Java.Lang.Object {
	// constructors
	public SessionCommandGroupParcelizer ();
	// properties
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public static SessionCommandGroup Read (AndroidX.VersionedParcelable.VersionedParcel parcel);
	public static void Write (SessionCommandGroup obj, AndroidX.VersionedParcelable.VersionedParcel parcel);
}
```

#### New Type: AndroidX.Media2.Session.SessionCommandParcelizer

```csharp
public sealed class SessionCommandParcelizer : Java.Lang.Object {
	// constructors
	public SessionCommandParcelizer ();
	// properties
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public static SessionCommand Read (AndroidX.VersionedParcelable.VersionedParcel parcel);
	public static void Write (SessionCommand obj, AndroidX.VersionedParcelable.VersionedParcel parcel);
}
```

#### New Type: AndroidX.Media2.Session.SessionResult

```csharp
public class SessionResult : AndroidX.VersionedParcelable.CustomVersionedParcelable, Android.Runtime.IJavaObject, AndroidX.VersionedParcelable.IVersionedParcelable, System.IDisposable {
	// constructors
	public SessionResult (int resultCode, Android.OS.Bundle customCommandResult);
	protected SessionResult (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
	// fields
	public static const int ResultSuccess;
	// properties
	public virtual long CompletionTime { get; }
	public virtual Android.OS.Bundle CustomCommandResult { get; }
	public virtual AndroidX.Medai2.Common.MediaItem MediaItem { get; }
	public virtual int ResultCode { get; }
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }

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
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public static SessionResult Read (AndroidX.VersionedParcelable.VersionedParcel parcel);
	public static void Write (SessionResult obj, AndroidX.VersionedParcelable.VersionedParcel parcel);
}
```

#### New Type: AndroidX.Media2.Session.SessionToken

```csharp
public sealed class SessionToken : Java.Lang.Object, Android.Runtime.IJavaObject, AndroidX.VersionedParcelable.IVersionedParcelable, System.IDisposable {
	// constructors
	public SessionToken (Android.Content.Context context, Android.Content.ComponentName serviceComponent);
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
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	public int Type { get; }
	public int Uid { get; }
	// methods
	public static void CreateSessionToken (Android.Content.Context context, Android.Support.V4.Media.Session.MediaSessionCompat.Token compatToken, Java.Util.Concurrent.IExecutor executor, SessionToken.IOnSessionTokenCreatedListener listener);

	// inner types
	public interface IOnSessionTokenCreatedListener : Android.Runtime.IJavaObject, System.IDisposable {
		// methods
		public virtual void OnSessionTokenCreated (Android.Support.V4.Media.Session.MediaSessionCompat.Token p0, SessionToken p1);
	}
	public interface ISessionTokenImpl : Android.Runtime.IJavaObject, AndroidX.VersionedParcelable.IVersionedParcelable, System.IDisposable {
		// properties
		public virtual Java.Lang.Object Binder { get; }
		public virtual Android.Content.ComponentName ComponentName { get; }
		public virtual Android.OS.Bundle Extras { get; }
		public virtual bool IsLegacySession { get; }
		public virtual string PackageName { get; }
		public virtual string ServiceName { get; }
		public virtual int Type { get; }
		public virtual int Uid { get; }
	}
	public interface ITokenType : Android.Runtime.IJavaObject, Java.Lang.Annotation.IAnnotation, System.IDisposable {
	}
	public class SessionTokenCreatedEventArgs : System.EventArgs {
		// constructors
		public SessionToken.SessionTokenCreatedEventArgs (Android.Support.V4.Media.Session.MediaSessionCompat.Token p0, SessionToken p1);
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
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public static Java.Lang.Object Read (AndroidX.VersionedParcelable.VersionedParcel parcel);
}
```

#### New Type: AndroidX.Media2.Session.SessionTokenImplLegacyParcelizer

```csharp
public sealed class SessionTokenImplLegacyParcelizer : Java.Lang.Object {
	// constructors
	public SessionTokenImplLegacyParcelizer ();
	// properties
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public static AndroidX.VersionedParcelable.CustomVersionedParcelable Read (AndroidX.VersionedParcelable.VersionedParcel parcel);
}
```

#### New Type: AndroidX.Media2.Session.SessionTokenParcelizer

```csharp
public sealed class SessionTokenParcelizer : Java.Lang.Object {
	// constructors
	public SessionTokenParcelizer ();
	// properties
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public static SessionToken Read (AndroidX.VersionedParcelable.VersionedParcel parcel);
	public static void Write (SessionToken obj, AndroidX.VersionedParcelable.VersionedParcel parcel);
}
```

#### New Type: AndroidX.Media2.Session.StarRating

```csharp
public sealed class StarRating : Java.Lang.Object, Android.Runtime.IJavaObject, AndroidX.Medai2.Common.IRating, AndroidX.VersionedParcelable.IVersionedParcelable, System.IDisposable {
	// constructors
	public StarRating (int maxStars);
	public StarRating (int maxStars, float starRating);
	// properties
	public virtual bool IsRated { get; }
	public int MaxStars { get; }
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
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
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public static StarRating Read (AndroidX.VersionedParcelable.VersionedParcel parcel);
	public static void Write (StarRating obj, AndroidX.VersionedParcelable.VersionedParcel parcel);
}
```

#### New Type: AndroidX.Media2.Session.ThumbRating

```csharp
public sealed class ThumbRating : Java.Lang.Object, Android.Runtime.IJavaObject, AndroidX.Medai2.Common.IRating, AndroidX.VersionedParcelable.IVersionedParcelable, System.IDisposable {
	// constructors
	public ThumbRating ();
	public ThumbRating (bool thumbIsUp);
	// properties
	public virtual bool IsRated { get; }
	public bool IsThumbUp { get; }
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
}
```

#### New Type: AndroidX.Media2.Session.ThumbRatingParcelizer

```csharp
public sealed class ThumbRatingParcelizer : Java.Lang.Object {
	// constructors
	public ThumbRatingParcelizer ();
	// properties
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public static ThumbRating Read (AndroidX.VersionedParcelable.VersionedParcel parcel);
	public static void Write (ThumbRating obj, AndroidX.VersionedParcelable.VersionedParcel parcel);
}
```

### New Namespace AndroidX.Media2.Session.Futures

#### New Type: AndroidX.Media2.Session.Futures.AbstractResolvableFuture

```csharp
public abstract class AbstractResolvableFuture : Java.Lang.Object, Android.Runtime.IJavaObject, Google.Common.Util.Concurrent.IListenableFuture, Java.Util.Concurrent.IFuture, System.IDisposable {
	// constructors
	protected AbstractResolvableFuture ();
	protected AbstractResolvableFuture (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
	// properties
	public virtual bool IsCancelled { get; }
	public virtual bool IsDone { get; }
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public virtual void AddListener (Java.Lang.IRunnable listener, Java.Util.Concurrent.IExecutor executor);
	protected virtual void AfterDone ();
	public virtual bool Cancel (bool mayInterruptIfRunning);
	public virtual Java.Lang.Object Get ();
	public virtual Java.Lang.Object Get (long timeout, Java.Util.Concurrent.TimeUnit unit);
	protected virtual void InterruptTask ();
	protected virtual string PendingToString ();
	protected virtual bool Set (Java.Lang.Object value);
	protected virtual bool SetException (Java.Lang.Throwable throwable);
	protected virtual bool SetFuture (Google.Common.Util.Concurrent.IListenableFuture future);
	protected bool WasInterrupted ();
}
```

#### New Type: AndroidX.Media2.Session.Futures.ResolvableFuture

```csharp
public sealed class ResolvableFuture : AndroidX.Media2.Session.Futures.AbstractResolvableFuture, Android.Runtime.IJavaObject, Google.Common.Util.Concurrent.IListenableFuture, Java.Util.Concurrent.IFuture, System.IDisposable {
	// properties
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public static ResolvableFuture Create ();
	public bool Set (Java.Lang.Object value);
	public bool SetException (Java.Lang.Throwable throwable);
	public bool SetFuture (Google.Common.Util.Concurrent.IListenableFuture future);
}
```

### New Namespace AndroidX.Media2.Widget

#### New Type: AndroidX.Media2.Widget.MediaControlView

```csharp
public class MediaControlView : Android.Views.ViewGroup {
	// constructors
	public MediaControlView (Android.Content.Context context);
	public MediaControlView (Android.Content.Context context, Android.Util.IAttributeSet attrs);
	protected MediaControlView (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
	public MediaControlView (Android.Content.Context context, Android.Util.IAttributeSet attrs, int defStyleAttr);
	// properties
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// events
	public event System.EventHandler<MediaControlView.FullScreenEventArgs> FullScreen;
	// methods
	protected override void OnLayout (bool changed, int left, int top, int right, int bottom);
	public override void OnVisibilityAggregated (bool p0);
	public virtual void RequestPlayButtonFocus ();
	public virtual void SetMediaController (AndroidX.Media2.Session.MediaController controller);
	public virtual void SetOnFullScreenListener (MediaControlView.IOnFullScreenListener listener);
	public virtual void SetPlayer (AndroidX.Medai2.Common.SessionPlayer player);

	// inner types
	public class FullScreenEventArgs : System.EventArgs {
		// constructors
		public MediaControlView.FullScreenEventArgs (Android.Views.View p0, bool p1);
		// properties
		public Android.Views.View P0 { get; }
		public bool P1 { get; }
	}
	public interface IOnFullScreenListener : Android.Runtime.IJavaObject, System.IDisposable {
		// methods
		public virtual void OnFullScreen (Android.Views.View p0, bool p1);
	}
}
```

#### New Type: AndroidX.Media2.Widget.VideoView

```csharp
public class VideoView : Android.Views.ViewGroup {
	// constructors
	public VideoView (Android.Content.Context context);
	public VideoView (Android.Content.Context context, Android.Util.IAttributeSet attrs);
	protected VideoView (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
	public VideoView (Android.Content.Context context, Android.Util.IAttributeSet attrs, int defStyleAttr);
	// fields
	public static const int ViewTypeSurfaceview;
	public static const int ViewTypeTextureview;
	// properties
	public virtual MediaControlView MediaControlView { get; }
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	public virtual int ViewType { get; set; }
	// events
	public event System.EventHandler<VideoView.ViewTypeChangedEventArgs> ViewTypeChanged;
	// methods
	public override Android.Views.ViewGroup.LayoutParams GenerateLayoutParams (Android.Util.IAttributeSet p0);
	protected override void OnLayout (bool changed, int left, int top, int right, int bottom);
	public override void OnVisibilityAggregated (bool p0);
	public virtual void SetMediaControlView (MediaControlView mediaControlView, long intervalMs);
	public virtual void SetMediaController (AndroidX.Media2.Session.MediaController controller);
	public virtual void SetOnViewTypeChangedListener (VideoView.IOnViewTypeChangedListener listener);
	public virtual void SetPlayer (AndroidX.Medai2.Common.SessionPlayer player);
	public override bool ShouldDelayChildPressedState ();

	// inner types
	public interface IOnViewTypeChangedListener : Android.Runtime.IJavaObject, System.IDisposable {
		// methods
		public virtual void OnViewTypeChanged (Android.Views.View p0, int p1);
	}
	public class ViewTypeChangedEventArgs : System.EventArgs {
		// constructors
		public VideoView.ViewTypeChangedEventArgs (Android.Views.View p0, int p1);
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
	public ActionOnlyNavDirections (int actionId);
	// properties
	public virtual int ActionId { get; }
	public virtual Android.OS.Bundle Arguments { get; }
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
}
```

#### New Type: AndroidX.Navigation.ActivityNavigator

```csharp
public class ActivityNavigator : AndroidX.Navigation.Navigator {
	// constructors
	public ActivityNavigator (Android.Content.Context context);
	protected ActivityNavigator (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
	// properties
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public static void ApplyPopAnimationsToPendingTransition (Android.App.Activity activity);
	public override Java.Lang.Object CreateDestination ();
	public override NavDestination Navigate (Java.Lang.Object destination, Android.OS.Bundle args, NavOptions navOptions, Navigator.IExtras navigatorExtras);
	public override bool PopBackStack ();

	// inner types
	public class Destination : AndroidX.Navigation.NavDestination {
		// constructors
		public ActivityNavigator.Destination (Navigator activityNavigator);
		public ActivityNavigator.Destination (NavigatorProvider navigatorProvider);
		protected ActivityNavigator.Destination (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
		// properties
		public string Action { get; }
		public Android.Content.ComponentName Component { get; }
		public Android.Net.Uri Data { get; }
		public string DataPattern { get; }
		public Android.Content.Intent Intent { get; }
		public string TargetPackage { get; }
		protected override IntPtr ThresholdClass { get; }
		protected override System.Type ThresholdType { get; }
		// methods
		public ActivityNavigator.Destination SetAction (string action);
		public ActivityNavigator.Destination SetComponentName (Android.Content.ComponentName name);
		public ActivityNavigator.Destination SetData (Android.Net.Uri data);
		public ActivityNavigator.Destination SetDataPattern (string dataPattern);
		public ActivityNavigator.Destination SetIntent (Android.Content.Intent intent);
		public ActivityNavigator.Destination SetTargetPackage (string packageName);
	}
	public sealed class Extras : Java.Lang.Object, Android.Runtime.IJavaObject, Navigator.IExtras, System.IDisposable {
		// properties
		public AndroidX.Core.App.ActivityOptionsCompat ActivityOptions { get; }
		public int Flags { get; }
		protected override IntPtr ThresholdClass { get; }
		protected override System.Type ThresholdType { get; }

		// inner types
		public sealed class Builder : Java.Lang.Object {
			// constructors
			public ActivityNavigator.Extras.Builder ();
			// properties
			protected override IntPtr ThresholdClass { get; }
			protected override System.Type ThresholdType { get; }
			// methods
			public ActivityNavigator.Extras.Builder AddFlags (int flags);
			public ActivityNavigator.Extras Build ();
			public ActivityNavigator.Extras.Builder SetActivityOptions (AndroidX.Core.App.ActivityOptionsCompat activityOptions);
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
	public virtual int ActionId { get; }
	public virtual Android.OS.Bundle Arguments { get; }
}
```

#### New Type: AndroidX.Navigation.INavHost

```csharp
public interface INavHost : Android.Runtime.IJavaObject, System.IDisposable {
	// properties
	public virtual NavController NavController { get; }
}
```

#### New Type: AndroidX.Navigation.NavAction

```csharp
public sealed class NavAction : Java.Lang.Object {
	// constructors
	public NavAction (int destinationId);
	public NavAction (int destinationId, NavOptions navOptions);
	public NavAction (int destinationId, NavOptions navOptions, Android.OS.Bundle defaultArgs);
	// properties
	public Android.OS.Bundle DefaultArguments { get; set; }
	public int DestinationId { get; }
	public NavOptions NavOptions { get; set; }
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
}
```

#### New Type: AndroidX.Navigation.NavArgument

```csharp
public sealed class NavArgument : Java.Lang.Object {
	// properties
	public Java.Lang.Object DefaultValue { get; }
	public bool IsDefaultValuePresent { get; }
	public bool IsNullable { get; }
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	public NavType Type { get; }

	// inner types
	public sealed class Builder : Java.Lang.Object {
		// constructors
		public NavArgument.Builder ();
		// properties
		protected override IntPtr ThresholdClass { get; }
		protected override System.Type ThresholdType { get; }
		// methods
		public NavArgument Build ();
		public NavArgument.Builder SetDefaultValue (Java.Lang.Object defaultValue);
		public NavArgument.Builder SetIsNullable (bool isNullable);
		public NavArgument.Builder SetType (NavType type);
	}
}
```

#### New Type: AndroidX.Navigation.NavController

```csharp
public class NavController : Java.Lang.Object {
	// constructors
	public NavController (Android.Content.Context context);
	protected NavController (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
	// fields
	public static const string KeyDeepLinkIntent = "android-support-nav:controller:deepLinkIntent";
	// properties
	public virtual NavDestination CurrentDestination { get; }
	public virtual NavGraph Graph { get; set; }
	public virtual NavInflater NavInflater { get; }
	public virtual NavigatorProvider NavigatorProvider { get; }
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// events
	public event System.EventHandler<NavController.DestinationChangedEventArgs> DestinationChanged;
	// methods
	public virtual void AddOnDestinationChangedListener (NavController.IOnDestinationChangedListener listener);
	public virtual NavDeepLinkBuilder CreateDeepLink ();
	public virtual AndroidX.Lifecycle.IViewModelStoreOwner GetViewModelStoreOwner (int navGraphId);
	public virtual bool HandleDeepLink (Android.Content.Intent intent);
	public virtual void Navigate (Android.Net.Uri deepLink);
	public virtual void Navigate (INavDirections directions);
	public virtual void Navigate (int resId);
	public virtual void Navigate (Android.Net.Uri deepLink, NavOptions navOptions);
	public virtual void Navigate (INavDirections directions, NavOptions navOptions);
	public virtual void Navigate (INavDirections directions, Navigator.IExtras navigatorExtras);
	public virtual void Navigate (int resId, Android.OS.Bundle args);
	public virtual void Navigate (Android.Net.Uri deepLink, NavOptions navOptions, Navigator.IExtras navigatorExtras);
	public virtual void Navigate (int resId, Android.OS.Bundle args, NavOptions navOptions);
	public virtual void Navigate (int resId, Android.OS.Bundle args, NavOptions navOptions, Navigator.IExtras navigatorExtras);
	public virtual bool NavigateUp ();
	public virtual bool PopBackStack ();
	public virtual bool PopBackStack (int destinationId, bool inclusive);
	public virtual void RemoveOnDestinationChangedListener (NavController.IOnDestinationChangedListener listener);
	public virtual void RestoreState (Android.OS.Bundle navState);
	public virtual Android.OS.Bundle SaveState ();
	public virtual void SetGraph (int graphResId);
	public virtual void SetGraph (NavGraph graph, Android.OS.Bundle startDestinationArgs);
	public virtual void SetGraph (int graphResId, Android.OS.Bundle startDestinationArgs);

	// inner types
	public class DestinationChangedEventArgs : System.EventArgs {
		// constructors
		public NavController.DestinationChangedEventArgs (NavController p0, NavDestination p1, Android.OS.Bundle p2);
		// properties
		public NavController P0 { get; }
		public NavDestination P1 { get; }
		public Android.OS.Bundle P2 { get; }
	}
	public interface IOnDestinationChangedListener : Android.Runtime.IJavaObject, System.IDisposable {
		// methods
		public virtual void OnDestinationChanged (NavController p0, NavDestination p1, Android.OS.Bundle p2);
	}
}
```

#### New Type: AndroidX.Navigation.NavDeepLinkBuilder

```csharp
public sealed class NavDeepLinkBuilder : Java.Lang.Object {
	// constructors
	public NavDeepLinkBuilder (Android.Content.Context context);
	// properties
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public Android.App.PendingIntent CreatePendingIntent ();
	public AndroidX.Core.App.TaskStackBuilder CreateTaskStackBuilder ();
	public NavDeepLinkBuilder SetArguments (Android.OS.Bundle args);
	public NavDeepLinkBuilder SetComponentName (Android.Content.ComponentName componentName);
	public NavDeepLinkBuilder SetComponentName (Java.Lang.Class activityClass);
	public NavDeepLinkBuilder SetDestination (int destId);
	public NavDeepLinkBuilder SetGraph (NavGraph navGraph);
	public NavDeepLinkBuilder SetGraph (int navGraphId);
}
```

#### New Type: AndroidX.Navigation.NavDestination

```csharp
public class NavDestination : Java.Lang.Object {
	// constructors
	public NavDestination (Navigator navigator);
	public NavDestination (string navigatorName);
	protected NavDestination (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
	// properties
	public System.Collections.Generic.IDictionary<System.String,AndroidX.Navigation.NavArgument> Arguments { get; }
	public int Id { get; set; }
	public string Label { get; set; }
	public Java.Lang.ICharSequence LabelFormatted { get; set; }
	public string NavigatorName { get; }
	public NavGraph Parent { get; }
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public void AddArgument (string argumentName, NavArgument argument);
	public void AddDeepLink (string uriPattern);
	public NavAction GetAction (int id);
	public virtual bool HasDeepLink (Android.Net.Uri deepLink);
	public virtual void OnInflate (Android.Content.Context context, Android.Util.IAttributeSet attrs);
	protected static Java.Lang.Class ParseClassFromName (Android.Content.Context context, string name, Java.Lang.Class expectedClassType);
	public void PutAction (int actionId, NavAction action);
	public void PutAction (int actionId, int destId);
	public void RemoveAction (int actionId);
	public void RemoveArgument (string argumentName);

	// inner types
	public class DeepLinkMatch : Java.Lang.Object, Android.Runtime.IJavaObject, Java.Lang.IComparable, System.IDisposable {
		// constructors
		protected NavDestination.DeepLinkMatch (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
		// properties
		protected override IntPtr ThresholdClass { get; }
		protected override System.Type ThresholdType { get; }
		// methods
		public virtual int CompareTo (Java.Lang.Object p0);
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
	public NavGraph (Navigator navGraphNavigator);
	protected NavGraph (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
	// properties
	public int StartDestination { get; set; }
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public void AddAll (NavGraph other);
	public void AddDestination (NavDestination node);
	public void AddDestinations (NavDestination[] nodes);
	public void AddDestinations (System.Collections.Generic.ICollection<NavDestination> nodes);
	public void Clear ();
	public NavDestination FindNode (int resid);
	public virtual Java.Util.IIterator Iterator ();
	public void Remove (NavDestination node);
}
```

#### New Type: AndroidX.Navigation.NavGraphNavigator

```csharp
public class NavGraphNavigator : AndroidX.Navigation.Navigator {
	// constructors
	public NavGraphNavigator (NavigatorProvider navigatorProvider);
	protected NavGraphNavigator (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
	// properties
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public override Java.Lang.Object CreateDestination ();
	public override NavDestination Navigate (Java.Lang.Object destination, Android.OS.Bundle args, NavOptions navOptions, Navigator.IExtras navigatorExtras);
	public override bool PopBackStack ();
}
```

#### New Type: AndroidX.Navigation.NavHostController

```csharp
public sealed class NavHostController : AndroidX.Navigation.NavController {
	// constructors
	public NavHostController (Android.Content.Context context);
	// properties
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public void EnableOnBackPressed (bool enabled);
	public void SetLifecycleOwner (AndroidX.Lifecycle.ILifecycleOwner owner);
	public void SetOnBackPressedDispatcher (AndroidX.Activity.OnBackPressedDispatcher dispatcher);
	public void SetViewModelStore (AndroidX.Lifecycle.ViewModelStore viewModelStore);
}
```

#### New Type: AndroidX.Navigation.NavInflater

```csharp
public sealed class NavInflater : Java.Lang.Object {
	// constructors
	public NavInflater (Android.Content.Context context, NavigatorProvider navigatorProvider);
	// properties
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public NavGraph Inflate (int graphResId);
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
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public bool ShouldLaunchSingleTop ();

	// inner types
	public sealed class Builder : Java.Lang.Object {
		// constructors
		public NavOptions.Builder ();
		// properties
		protected override IntPtr ThresholdClass { get; }
		protected override System.Type ThresholdType { get; }
		// methods
		public NavOptions Build ();
		public NavOptions.Builder SetEnterAnim (int enterAnim);
		public NavOptions.Builder SetExitAnim (int exitAnim);
		public NavOptions.Builder SetLaunchSingleTop (bool singleTop);
		public NavOptions.Builder SetPopEnterAnim (int popEnterAnim);
		public NavOptions.Builder SetPopExitAnim (int popExitAnim);
		public NavOptions.Builder SetPopUpTo (int destinationId, bool inclusive);
	}
}
```

#### New Type: AndroidX.Navigation.NavType

```csharp
public abstract class NavType : Java.Lang.Object {
	// constructors
	protected NavType (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
	// properties
	public static NavType BoolArrayType { get; }
	public static NavType BoolType { get; }
	public static NavType FloatArrayType { get; }
	public static NavType FloatType { get; }
	public static NavType IntArrayType { get; }
	public static NavType IntType { get; }
	public virtual bool IsNullableAllowed { get; }
	public static NavType LongArrayType { get; }
	public static NavType LongType { get; }
	public virtual string Name { get; }
	public static NavType ReferenceType { get; }
	public static NavType StringArrayType { get; }
	public static NavType StringType { get; }
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public static NavType FromArgType (string type, string packageName);
	public virtual Java.Lang.Object Get (Android.OS.Bundle p0, string p1);
	public virtual Java.Lang.Object ParseValue (string p0);

	// inner types
	public sealed class EnumType : AndroidX.Navigation.NavType+SerializableType {
		// constructors
		public NavType.EnumType (Java.Lang.Class type);
		// properties
		protected override IntPtr ThresholdClass { get; }
		protected override System.Type ThresholdType { get; }
	}
	public sealed class ParcelableArrayType : AndroidX.Navigation.NavType {
		// constructors
		public NavType.ParcelableArrayType (Java.Lang.Class type);
		// properties
		public override string Name { get; }
		protected override IntPtr ThresholdClass { get; }
		protected override System.Type ThresholdType { get; }
		// methods
		public override Java.Lang.Object Get (Android.OS.Bundle bundle, string key);
		public override Java.Lang.Object ParseValue (string value);
		public void Put (Android.OS.Bundle bundle, string key, Java.Lang.Object[] value);
	}
	public sealed class ParcelableType : AndroidX.Navigation.NavType {
		// constructors
		public NavType.ParcelableType (Java.Lang.Class type);
		// properties
		public override string Name { get; }
		protected override IntPtr ThresholdClass { get; }
		protected override System.Type ThresholdType { get; }
		// methods
		public override Java.Lang.Object Get (Android.OS.Bundle bundle, string key);
		public override Java.Lang.Object ParseValue (string value);
		public void Put (Android.OS.Bundle bundle, string key, Java.Lang.Object value);
	}
	public sealed class SerializableArrayType : AndroidX.Navigation.NavType {
		// constructors
		public NavType.SerializableArrayType (Java.Lang.Class type);
		// properties
		public override string Name { get; }
		protected override IntPtr ThresholdClass { get; }
		protected override System.Type ThresholdType { get; }
		// methods
		public override Java.Lang.Object Get (Android.OS.Bundle bundle, string key);
		public override Java.Lang.Object ParseValue (string value);
		public void Put (Android.OS.Bundle bundle, string key, Java.Lang.Object[] value);
	}
	public class SerializableType : AndroidX.Navigation.NavType {
		// constructors
		public NavType.SerializableType (Java.Lang.Class type);
		protected NavType.SerializableType (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
		// properties
		public override string Name { get; }
		protected override IntPtr ThresholdClass { get; }
		protected override System.Type ThresholdType { get; }
		// methods
		public override Java.Lang.Object Get (Android.OS.Bundle bundle, string key);
		public override Java.Lang.Object ParseValue (string value);
		public virtual void Put (Android.OS.Bundle bundle, string key, Java.Lang.Object value);
	}
}
```

#### New Type: AndroidX.Navigation.Navigation

```csharp
public sealed class Navigation : Java.Lang.Object {
	// properties
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public static Android.Views.View.IOnClickListener CreateNavigateOnClickListener (INavDirections directions);
	public static Android.Views.View.IOnClickListener CreateNavigateOnClickListener (int resId);
	public static Android.Views.View.IOnClickListener CreateNavigateOnClickListener (int resId, Android.OS.Bundle args);
	public static NavController FindNavController (Android.Views.View view);
	public static NavController FindNavController (Android.App.Activity activity, int viewId);
	public static void SetViewNavController (Android.Views.View view, NavController controller);
}
```

#### New Type: AndroidX.Navigation.Navigator

```csharp
public abstract class Navigator : Java.Lang.Object {
	// constructors
	public Navigator ();
	protected Navigator (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
	// properties
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public virtual Java.Lang.Object CreateDestination ();
	public virtual NavDestination Navigate (Java.Lang.Object p0, Android.OS.Bundle p1, NavOptions p2, Navigator.IExtras p3);
	public virtual void OnRestoreState (Android.OS.Bundle savedState);
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
	protected NavigatorProvider (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
	// properties
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public Navigator AddNavigator (Navigator navigator);
	public virtual Navigator AddNavigator (string name, Navigator navigator);
	public Java.Lang.Object GetNavigator (Java.Lang.Class navigatorClass);
	public virtual Java.Lang.Object GetNavigator (string name);
}
```

### New Namespace AndroidX.Navigation.Fragment

#### New Type: AndroidX.Navigation.Fragment.DialogFragmentNavigator

```csharp
public sealed class DialogFragmentNavigator : AndroidX.Navigation.Navigator {
	// constructors
	public DialogFragmentNavigator (Android.Content.Context context, AndroidX.Fragment.App.FragmentManager manager);
	// properties
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public override Java.Lang.Object CreateDestination ();
	public override AndroidX.Navigation.NavDestination Navigate (Java.Lang.Object destination, Android.OS.Bundle args, AndroidX.Navigation.NavOptions navOptions, AndroidX.Navigation.Navigator.IExtras navigatorExtras);
	public override bool PopBackStack ();

	// inner types
	public class Destination : AndroidX.Navigation.NavDestination, Android.Runtime.IJavaObject, AndroidX.Navigation.IFloatingWindow, System.IDisposable {
		// constructors
		public DialogFragmentNavigator.Destination (AndroidX.Navigation.Navigator fragmentNavigator);
		public DialogFragmentNavigator.Destination (AndroidX.Navigation.NavigatorProvider navigatorProvider);
		protected DialogFragmentNavigator.Destination (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
		// properties
		public string ClassName { get; }
		protected override IntPtr ThresholdClass { get; }
		protected override System.Type ThresholdType { get; }
		// methods
		public DialogFragmentNavigator.Destination SetClassName (string className);
	}
}
```

#### New Type: AndroidX.Navigation.Fragment.FragmentNavigator

```csharp
public class FragmentNavigator : AndroidX.Navigation.Navigator {
	// constructors
	protected FragmentNavigator (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
	public FragmentNavigator (Android.Content.Context context, AndroidX.Fragment.App.FragmentManager manager, int containerId);
	// properties
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public override Java.Lang.Object CreateDestination ();

	[Obsolete ("deprecated")]
public virtual AndroidX.Fragment.App.Fragment InstantiateFragment (Android.Content.Context context, AndroidX.Fragment.App.FragmentManager fragmentManager, string className, Android.OS.Bundle args);
	public override AndroidX.Navigation.NavDestination Navigate (Java.Lang.Object destination, Android.OS.Bundle args, AndroidX.Navigation.NavOptions navOptions, AndroidX.Navigation.Navigator.IExtras navigatorExtras);
	public override bool PopBackStack ();

	// inner types
	public class Destination : AndroidX.Navigation.NavDestination {
		// constructors
		public FragmentNavigator.Destination (AndroidX.Navigation.Navigator fragmentNavigator);
		public FragmentNavigator.Destination (AndroidX.Navigation.NavigatorProvider navigatorProvider);
		protected FragmentNavigator.Destination (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
		// properties
		public string ClassName { get; }
		protected override IntPtr ThresholdClass { get; }
		protected override System.Type ThresholdType { get; }
		// methods
		public FragmentNavigator.Destination SetClassName (string className);
	}
	public sealed class Extras : Java.Lang.Object, Android.Runtime.IJavaObject, AndroidX.Navigation.Navigator.IExtras, System.IDisposable {
		// properties
		public System.Collections.Generic.IDictionary<Android.Views.View,System.String> SharedElements { get; }
		protected override IntPtr ThresholdClass { get; }
		protected override System.Type ThresholdType { get; }

		// inner types
		public sealed class Builder : Java.Lang.Object {
			// constructors
			public FragmentNavigator.Extras.Builder ();
			// properties
			protected override IntPtr ThresholdClass { get; }
			protected override System.Type ThresholdType { get; }
			// methods
			public FragmentNavigator.Extras.Builder AddSharedElement (Android.Views.View sharedElement, string name);
			public FragmentNavigator.Extras.Builder AddSharedElements (System.Collections.Generic.IDictionary<Android.Views.View,System.String> sharedElements);
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
	protected NavHostFragment (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
	// properties
	public virtual AndroidX.Navigation.NavController NavController { get; }
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public static NavHostFragment Create (int graphResId);
	public static NavHostFragment Create (int graphResId, Android.OS.Bundle startDestinationArgs);

	[Obsolete ("deprecated")]
protected virtual AndroidX.Navigation.Navigator CreateFragmentNavigator ();
	public static AndroidX.Navigation.NavController FindNavController (AndroidX.Fragment.App.Fragment fragment);
	protected virtual void OnCreateNavController (AndroidX.Navigation.NavController navController);
}
```

### New Namespace AndroidX.Navigation.UI

#### New Type: AndroidX.Navigation.UI.AppBarConfiguration

```csharp
public sealed class AppBarConfiguration : Java.Lang.Object {
	// properties
	public AndroidX.DrawerLayout.Widget.DrawerLayout DrawerLayout { get; }
	public AppBarConfiguration.IOnNavigateUpListener FallbackOnNavigateUpListener { get; }
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	public System.Collections.Generic.ICollection<Java.Lang.Integer> TopLevelDestinations { get; }

	// inner types
	public sealed class Builder : Java.Lang.Object {
		// constructors
		public AppBarConfiguration.Builder (Android.Views.IMenu topLevelMenu);
		public AppBarConfiguration.Builder (AndroidX.Navigation.NavGraph navGraph);
		public AppBarConfiguration.Builder (System.Collections.Generic.ICollection<Java.Lang.Integer> topLevelDestinationIds);
		public AppBarConfiguration.Builder (int[] topLevelDestinationIds);
		// properties
		protected override IntPtr ThresholdClass { get; }
		protected override System.Type ThresholdType { get; }
		// methods
		public AppBarConfiguration Build ();
		public AppBarConfiguration.Builder SetDrawerLayout (AndroidX.DrawerLayout.Widget.DrawerLayout drawerLayout);
		public AppBarConfiguration.Builder SetFallbackOnNavigateUpListener (AppBarConfiguration.IOnNavigateUpListener fallbackOnNavigateUpListener);
	}
	public interface IOnNavigateUpListener : Android.Runtime.IJavaObject, System.IDisposable {
		// methods
		public virtual bool OnNavigateUp ();
	}
	public class NavigateUpEventArgs : System.EventArgs {
		// constructors
		public AppBarConfiguration.NavigateUpEventArgs (bool handled);
		// properties
		public bool Handled { get; set; }
	}
}
```

#### New Type: AndroidX.Navigation.UI.NavigationUI

```csharp
public sealed class NavigationUI : Java.Lang.Object {
	// properties
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public static bool NavigateUp (AndroidX.Navigation.NavController navController, AndroidX.DrawerLayout.Widget.DrawerLayout drawerLayout);
	public static bool NavigateUp (AndroidX.Navigation.NavController navController, AppBarConfiguration configuration);
	public static bool OnNavDestinationSelected (Android.Views.IMenuItem item, AndroidX.Navigation.NavController navController);
	public static void SetupActionBarWithNavController (AndroidX.AppCompat.App.AppCompatActivity activity, AndroidX.Navigation.NavController navController);
	public static void SetupActionBarWithNavController (AndroidX.AppCompat.App.AppCompatActivity activity, AndroidX.Navigation.NavController navController, AndroidX.DrawerLayout.Widget.DrawerLayout drawerLayout);
	public static void SetupActionBarWithNavController (AndroidX.AppCompat.App.AppCompatActivity activity, AndroidX.Navigation.NavController navController, AppBarConfiguration configuration);
	public static void SetupWithNavController (AndroidX.AppCompat.Widget.Toolbar toolbar, AndroidX.Navigation.NavController navController);
	public static void SetupWithNavController (Google.Android.Material.BottomNavigation.BottomNavigationView bottomNavigationView, AndroidX.Navigation.NavController navController);
	public static void SetupWithNavController (Google.Android.Material.Navigation.NavigationView navigationView, AndroidX.Navigation.NavController navController);
	public static void SetupWithNavController (AndroidX.AppCompat.Widget.Toolbar toolbar, AndroidX.Navigation.NavController navController, AndroidX.DrawerLayout.Widget.DrawerLayout drawerLayout);
	public static void SetupWithNavController (AndroidX.AppCompat.Widget.Toolbar toolbar, AndroidX.Navigation.NavController navController, AppBarConfiguration configuration);
	public static void SetupWithNavController (Google.Android.Material.AppBar.CollapsingToolbarLayout collapsingToolbarLayout, AndroidX.AppCompat.Widget.Toolbar toolbar, AndroidX.Navigation.NavController navController);
	public static void SetupWithNavController (Google.Android.Material.AppBar.CollapsingToolbarLayout collapsingToolbarLayout, AndroidX.AppCompat.Widget.Toolbar toolbar, AndroidX.Navigation.NavController navController, AndroidX.DrawerLayout.Widget.DrawerLayout drawerLayout);
	public static void SetupWithNavController (Google.Android.Material.AppBar.CollapsingToolbarLayout collapsingToolbarLayout, AndroidX.AppCompat.Widget.Toolbar toolbar, AndroidX.Navigation.NavController navController, AppBarConfiguration configuration);
}
```

### New Namespace AndroidX.Paging

#### New Type: AndroidX.Paging.AsyncPagedListDiffer

```csharp
public class AsyncPagedListDiffer : Java.Lang.Object {
	// constructors
	public AsyncPagedListDiffer (AndroidX.RecyclerView.Widget.IListUpdateCallback listUpdateCallback, AndroidX.RecyclerView.Widget.AsyncDifferConfig config);
	public AsyncPagedListDiffer (AndroidX.RecyclerView.Widget.RecyclerView.Adapter adapter, AndroidX.RecyclerView.Widget.DiffUtil.ItemCallback diffCallback);
	protected AsyncPagedListDiffer (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
	// properties
	public virtual PagedList CurrentList { get; }
	public virtual int ItemCount { get; }
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public virtual void AddPagedListListener (AsyncPagedListDiffer.IPagedListListener listener);
	public virtual Java.Lang.Object GetItem (int index);
	public virtual void RemovePagedListListener (AsyncPagedListDiffer.IPagedListListener listener);
	public virtual void SubmitList (PagedList pagedList);
	public virtual void SubmitList (PagedList pagedList, Java.Lang.IRunnable commitCallback);

	// inner types
	public interface IPagedListListener : Android.Runtime.IJavaObject, System.IDisposable {
		// methods
		public virtual void OnCurrentListChanged (PagedList p0, PagedList p1);
	}
	public class PagedListEventArgs : System.EventArgs {
		// constructors
		public AsyncPagedListDiffer.PagedListEventArgs (PagedList p0, PagedList p1);
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
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public AndroidX.Lifecycle.LiveData Build ();
	public LivePagedListBuilder SetBoundaryCallback (PagedList.BoundaryCallback boundaryCallback);
	public LivePagedListBuilder SetFetchExecutor (Java.Util.Concurrent.IExecutor fetchExecutor);
	public LivePagedListBuilder SetInitialLoadKey (Java.Lang.Object key);
}
```

#### New Type: AndroidX.Paging.PagedList

```csharp
public abstract class PagedList : Java.Util.AbstractList {
	// constructors
	protected PagedList (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
	// properties
	public virtual bool IsDetached { get; }
	public virtual bool IsImmutable { get; }
	public virtual Java.Lang.Object LastKey { get; }
	public virtual int LoadedCount { get; }
	public virtual int PositionOffset { get; }
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public virtual void AddWeakCallback (System.Collections.IList previousSnapshot, PagedList.Callback callback);
	public virtual void Detach ();
	public override Java.Lang.Object Get (int index);
	public virtual PagedList.Config GetConfig ();
	public virtual void LoadAround (int index);
	public virtual void RemoveWeakCallback (PagedList.Callback callback);
	public override int Size ();
	public virtual System.Collections.IList Snapshot ();

	// inner types
	public abstract class BoundaryCallback : Java.Lang.Object {
		// constructors
		public PagedList.BoundaryCallback ();
		protected PagedList.BoundaryCallback (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
		// properties
		protected override IntPtr ThresholdClass { get; }
		protected override System.Type ThresholdType { get; }
		// methods
		public virtual void OnItemAtEndLoaded (Java.Lang.Object itemAtEnd);
		public virtual void OnItemAtFrontLoaded (Java.Lang.Object itemAtFront);
		public virtual void OnZeroItemsLoaded ();
	}
	public sealed class Builder : Java.Lang.Object {
		// properties
		protected override IntPtr ThresholdClass { get; }
		protected override System.Type ThresholdType { get; }
		// methods
		public PagedList Build ();
		public PagedList.Builder SetBoundaryCallback (PagedList.BoundaryCallback boundaryCallback);
		public PagedList.Builder SetFetchExecutor (Java.Util.Concurrent.IExecutor fetchExecutor);
		public PagedList.Builder SetInitialKey (Java.Lang.Object initialKey);
		public PagedList.Builder SetNotifyExecutor (Java.Util.Concurrent.IExecutor notifyExecutor);
	}
	public abstract class Callback : Java.Lang.Object {
		// constructors
		public PagedList.Callback ();
		protected PagedList.Callback (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
		// properties
		protected override IntPtr ThresholdClass { get; }
		protected override System.Type ThresholdType { get; }
		// methods
		public virtual void OnChanged (int p0, int p1);
		public virtual void OnInserted (int p0, int p1);
		public virtual void OnRemoved (int p0, int p1);
	}
	public class Config : Java.Lang.Object {
		// constructors
		protected PagedList.Config (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
		// fields
		public static const int MaxSizeUnbounded;
		// properties
		public bool EnablePlaceholders { get; set; }
		public int InitialLoadSizeHint { get; set; }
		public int MaxSize { get; set; }
		public int PageSize { get; set; }
		public int PrefetchDistance { get; set; }
		protected override IntPtr ThresholdClass { get; }
		protected override System.Type ThresholdType { get; }

		// inner types
		public sealed class Builder : Java.Lang.Object {
			// constructors
			public PagedList.Config.Builder ();
			// properties
			protected override IntPtr ThresholdClass { get; }
			protected override System.Type ThresholdType { get; }
			// methods
			public PagedList.Config Build ();
			public PagedList.Config.Builder SetEnablePlaceholders (bool enablePlaceholders);
			public PagedList.Config.Builder SetInitialLoadSizeHint (int initialLoadSizeHint);
			public PagedList.Config.Builder SetMaxSize (int maxSize);
			public PagedList.Config.Builder SetPageSize (int pageSize);
			public PagedList.Config.Builder SetPrefetchDistance (int prefetchDistance);
		}
	}
}
```

#### New Type: AndroidX.Paging.PagedListAdapter

```csharp
public abstract class PagedListAdapter : AndroidX.RecyclerView.Widget.RecyclerView+Adapter {
	// constructors
	protected PagedListAdapter (AndroidX.RecyclerView.Widget.AsyncDifferConfig config);
	protected PagedListAdapter (AndroidX.RecyclerView.Widget.DiffUtil.ItemCallback diffCallback);
	protected PagedListAdapter (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
	// properties
	public virtual PagedList CurrentList { get; }
	public override int ItemCount { get; }
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	protected virtual Java.Lang.Object GetItem (int position);

	[Obsolete ("deprecated")]
public virtual void OnCurrentListChanged (PagedList currentList);
	public virtual void OnCurrentListChanged (PagedList previousList, PagedList currentList);
	public virtual void SubmitList (PagedList pagedList);
	public virtual void SubmitList (PagedList pagedList, Java.Lang.IRunnable commitCallback);
}
```

### New Namespace AndroidX.Room.Guava

#### New Type: AndroidX.Room.Guava.GuavaRoom

```csharp
public class GuavaRoom : Java.Lang.Object {
	// constructors
	protected GuavaRoom (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
	// properties
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods

	[Obsolete ("deprecated")]
public static Google.Common.Util.Concurrent.IListenableFuture CreateListenableFuture (AndroidX.Room.RoomDatabase roomDatabase, Java.Util.Concurrent.ICallable callable);
	public static Google.Common.Util.Concurrent.IListenableFuture CreateListenableFuture (AndroidX.Room.RoomDatabase roomDatabase, bool inTransaction, Java.Util.Concurrent.ICallable callable);

	[Obsolete ("deprecated")]
public static Google.Common.Util.Concurrent.IListenableFuture CreateListenableFuture (Java.Util.Concurrent.ICallable callable, AndroidX.Room.RoomSQLiteQuery query, bool releaseQuery);

	[Obsolete ("deprecated")]
public static Google.Common.Util.Concurrent.IListenableFuture CreateListenableFuture (AndroidX.Room.RoomDatabase roomDatabase, Java.Util.Concurrent.ICallable callable, AndroidX.Room.RoomSQLiteQuery query, bool releaseQuery);
	public static Google.Common.Util.Concurrent.IListenableFuture CreateListenableFuture (AndroidX.Room.RoomDatabase roomDatabase, bool inTransaction, Java.Util.Concurrent.ICallable callable, AndroidX.Room.RoomSQLiteQuery query, bool releaseQuery);
	public static Google.Common.Util.Concurrent.IListenableFuture CreateListenableFuture (AndroidX.Room.RoomDatabase roomDatabase, bool inTransaction, Java.Util.Concurrent.ICallable callable, AndroidX.Room.RoomSQLiteQuery query, bool releaseQuery, Android.OS.CancellationSignal cancellationSignal);
}
```

### New Namespace AndroidX.SavedState

#### New Type: AndroidX.SavedState.ISavedStateRegistryOwner

```csharp
public interface ISavedStateRegistryOwner : Android.Runtime.IJavaObject, AndroidX.Lifecycle.ILifecycleOwner, System.IDisposable {
	// properties
	public virtual SavedStateRegistry SavedStateRegistry { get; }
}
```

#### New Type: AndroidX.SavedState.SavedStateRegistry

```csharp
public sealed class SavedStateRegistry : Java.Lang.Object {
	// properties
	public bool IsRestored { get; }
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public Android.OS.Bundle ConsumeRestoredStateForKey (string key);
	public void RegisterSavedStateProvider (string key, SavedStateRegistry.ISavedStateProvider provider);
	public void RunOnNextRecreation (Java.Lang.Class clazz);
	public void UnregisterSavedStateProvider (string key);

	// inner types
	public interface IAutoRecreated : Android.Runtime.IJavaObject, System.IDisposable {
		// methods
		public virtual void OnRecreated (ISavedStateRegistryOwner p0);
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
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public static SavedStateRegistryController Create (ISavedStateRegistryOwner owner);
	public void PerformRestore (Android.OS.Bundle savedState);
	public void PerformSave (Android.OS.Bundle outBundle);
}
```

### New Namespace AndroidX.ViewPager2.Adapter

#### New Type: AndroidX.ViewPager2.Adapter.FragmentStateAdapter

```csharp
public abstract class FragmentStateAdapter : AndroidX.RecyclerView.Widget.RecyclerView+Adapter, Android.Runtime.IJavaObject, IStatefulAdapter, System.IDisposable {
	// constructors
	public FragmentStateAdapter (AndroidX.Fragment.App.Fragment fragment);
	public FragmentStateAdapter (AndroidX.Fragment.App.FragmentActivity fragmentActivity);
	public FragmentStateAdapter (AndroidX.Fragment.App.FragmentManager fragmentManager, AndroidX.Lifecycle.Lifecycle lifecycle);
	protected FragmentStateAdapter (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
	// properties
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public virtual bool ContainsItem (long itemId);
	public virtual AndroidX.Fragment.App.Fragment CreateFragment (int p0);
	public void OnBindViewHolder (FragmentViewHolder holder, int position);
	public override AndroidX.RecyclerView.Widget.RecyclerView.ViewHolder OnCreateViewHolder (Android.Views.ViewGroup parent, int viewType);
	public bool OnFailedToRecycleView (FragmentViewHolder holder);
	public void OnViewAttachedToWindow (FragmentViewHolder holder);
	public void OnViewRecycled (FragmentViewHolder holder);
	public virtual void RestoreState (Android.OS.IParcelable savedState);
	public virtual Android.OS.IParcelable SaveState ();
	public override void SetHasStableIds (bool hasStableIds);

	// inner types
	public class FragmentMaxLifecycleEnforcer : Java.Lang.Object {
		// constructors
		protected FragmentStateAdapter.FragmentMaxLifecycleEnforcer (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
		// properties
		protected override IntPtr ThresholdClass { get; }
		protected override System.Type ThresholdType { get; }
	}
}
```

#### New Type: AndroidX.ViewPager2.Adapter.FragmentViewHolder

```csharp
public sealed class FragmentViewHolder : AndroidX.RecyclerView.Widget.RecyclerView+ViewHolder {
	// properties
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
}
```

#### New Type: AndroidX.ViewPager2.Adapter.IStatefulAdapter

```csharp
public interface IStatefulAdapter : Android.Runtime.IJavaObject, System.IDisposable {
	// methods
	public virtual void RestoreState (Android.OS.IParcelable p0);
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
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public void AddTransformer (ViewPager2.IPageTransformer transformer);
	public void RemoveTransformer (ViewPager2.IPageTransformer transformer);
	public virtual void TransformPage (Android.Views.View page, float position);
}
```

#### New Type: AndroidX.ViewPager2.Widget.MarginPageTransformer

```csharp
public sealed class MarginPageTransformer : Java.Lang.Object, Android.Runtime.IJavaObject, ViewPager2.IPageTransformer, System.IDisposable {
	// constructors
	public MarginPageTransformer (int marginPx);
	// properties
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	// methods
	public virtual void TransformPage (Android.Views.View page, float position);
}
```

#### New Type: AndroidX.ViewPager2.Widget.ViewPager2

```csharp
public sealed class ViewPager2 : Android.Views.ViewGroup {
	// constructors
	public ViewPager2 (Android.Content.Context context);
	public ViewPager2 (Android.Content.Context context, Android.Util.IAttributeSet attrs);
	public ViewPager2 (Android.Content.Context context, Android.Util.IAttributeSet attrs, int defStyleAttr);
	public ViewPager2 (Android.Content.Context context, Android.Util.IAttributeSet attrs, int defStyleAttr, int defStyleRes);
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
	protected override IntPtr ThresholdClass { get; }
	protected override System.Type ThresholdType { get; }
	public bool UserInputEnabled { get; set; }
	// methods
	public void AddItemDecoration (AndroidX.RecyclerView.Widget.RecyclerView.ItemDecoration decor);
	public void AddItemDecoration (AndroidX.RecyclerView.Widget.RecyclerView.ItemDecoration decor, int index);
	public bool BeginFakeDrag ();
	protected override void DispatchRestoreInstanceState (Android.Util.SparseArray container);
	public bool EndFakeDrag ();
	public bool FakeDragBy (float offsetPxFloat);
	public AndroidX.RecyclerView.Widget.RecyclerView.ItemDecoration GetItemDecorationAt (int index);
	public void InvalidateItemDecorations ();
	protected override void OnLayout (bool changed, int l, int t, int r, int b);
	public void RegisterOnPageChangeCallback (ViewPager2.OnPageChangeCallback callback);
	public void RemoveItemDecoration (AndroidX.RecyclerView.Widget.RecyclerView.ItemDecoration decor);
	public void RemoveItemDecorationAt (int index);
	public void RequestTransform ();
	public void SetCurrentItem (int item, bool smoothScroll);
	public void SetPageTransformer (ViewPager2.IPageTransformer transformer);
	public void UnregisterOnPageChangeCallback (ViewPager2.OnPageChangeCallback callback);

	// inner types
	public interface IOffscreenPageLimit : Android.Runtime.IJavaObject, Java.Lang.Annotation.IAnnotation, System.IDisposable {
	}
	public interface IOrientation : Android.Runtime.IJavaObject, Java.Lang.Annotation.IAnnotation, System.IDisposable {
	}
	public interface IPageTransformer : Android.Runtime.IJavaObject, System.IDisposable {
		// methods
		public virtual void TransformPage (Android.Views.View p0, float p1);
	}
	public interface IScrollState : Android.Runtime.IJavaObject, Java.Lang.Annotation.IAnnotation, System.IDisposable {
	}
	public abstract class OnPageChangeCallback : Java.Lang.Object {
		// constructors
		public ViewPager2.OnPageChangeCallback ();
		protected ViewPager2.OnPageChangeCallback (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
		// properties
		protected override IntPtr ThresholdClass { get; }
		protected override System.Type ThresholdType { get; }
		// methods
		public virtual void OnPageScrollStateChanged (int state);
		public virtual void OnPageScrolled (int position, float positionOffset, int positionOffsetPixels);
		public virtual void OnPageSelected (int position);
	}
	public class SavedState : Android.Views.View+BaseSavedState {
		// constructors
		protected ViewPager2.SavedState (IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer);
		// properties
		public static Android.OS.IParcelableCreator Creator { get; }
		protected override IntPtr ThresholdClass { get; }
		protected override System.Type ThresholdType { get; }
	}
}
```

### New Namespace Google.Common.Util.Concurrent

#### New Type: Google.Common.Util.Concurrent.IListenableFuture

```csharp
public interface IListenableFuture : Android.Runtime.IJavaObject, Java.Util.Concurrent.IFuture, System.IDisposable {
	// methods
	public virtual void AddListener (Java.Lang.IRunnable p0, Java.Util.Concurrent.IExecutor p1);
}
```

