# API diff: AndroidX.Merged.dll

## AndroidX.Merged.dll

### Namespace AndroidX.Lifecycle

#### Type Changed: AndroidX.Lifecycle.CompositeGeneratedAdaptersObserver

Removed interface:

```csharp
IGenericLifecycleObserver
```


#### Type Changed: AndroidX.Lifecycle.IGenericLifecycleObserver

Removed method:

```csharp
public virtual void OnStateChanged (ILifecycleOwner, Lifecycle.Event);
```


#### Type Changed: AndroidX.Lifecycle.Lifecycling

Removed constructor:

```csharp
public Lifecycling ();
```


#### Type Changed: AndroidX.Lifecycle.LiveData

#### Type Changed: AndroidX.Lifecycle.LiveData.LifecycleBoundObserver

Removed interface:

```csharp
IGenericLifecycleObserver
```



#### Type Changed: AndroidX.Lifecycle.SingleGeneratedAdapterObserver

Removed interface:

```csharp
IGenericLifecycleObserver
```



### Namespace AndroidX.Room

#### Type Changed: AndroidX.Room.DatabaseConfiguration

Removed constructor:

```csharp
public DatabaseConfiguration (Android.Content.Context, string, AndroidX.Sqlite.Db.ISupportSQLiteOpenHelperFactory, RoomDatabase.MigrationContainer, System.Collections.Generic.IList<RoomDatabase.Callback>, bool, RoomDatabase.JournalMode, bool, System.Collections.Generic.ICollection<Java.Lang.Integer>);
```


#### Type Changed: AndroidX.Room.RoomMasterTable

Removed constructor:

```csharp
public RoomMasterTable ();
```



### Namespace AndroidX.Room.Util

#### Type Changed: AndroidX.Room.Util.StringUtil

Removed constructor:

```csharp
public StringUtil ();
```



### Namespace AndroidX.ConstraintLayout.Widget

#### Type Changed: AndroidX.ConstraintLayout.Widget.ConstraintLayout

Modified fields:

```diff
-public const string Version = "ConstraintLayout-1.1.0";
+public const string Version = "ConstraintLayout-1.1.3";
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

#### Type Changed: AndroidX.ConstraintLayout.Solver.Widgets.Optimizer

Modified fields:

```diff
-public const int OptimizationStandard = 3;
+public const int OptimizationStandard = 7;
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



### Namespace AndroidX.VectorDrawable.Graphics.Drawable

#### Type Changed: AndroidX.VectorDrawable.Graphics.Drawable.VectorDrawableCompat

Removed property:

```csharp
public Android.Graphics.ColorFilter ColorFilter { get; }
```



### Namespace AndroidX.Core.View

#### Type Changed: AndroidX.Core.View.GestureDetectorCompat

#### Type Changed: AndroidX.Core.View.GestureDetectorCompat.GestureDetectorCompatImplBase

Removed interfaces:

```csharp
Android.Runtime.IJavaObject
GestureDetectorCompat.IGestureDetectorCompatImpl
System.IDisposable
```




### Namespace AndroidX.Preference

#### Type Changed: AndroidX.Preference.MultiSelectListPreference

Modified base type:

```diff
-Android.Support.V7.Preference.Internal.AbstractMultiSelectListPreference
+AndroidX.Preference.DialogPreference
```


#### Type Changed: AndroidX.Preference.PreferenceFragment

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



#### Type Changed: AndroidX.Preference.DialogPreferenceITargetFragmentExtensions

Removed method:

```csharp
public static Preference FindPreference (this DialogPreference.ITargetFragment, string);
```


#### Type Changed: AndroidX.Preference.DropDownPreference

Removed method:

```csharp
public virtual int FindSpinnerIndexOfValue (string);
```


#### Type Changed: AndroidX.Preference.Preference

Removed property:

```csharp
public Android.Content.ISharedPreferences SharedPreferences { get; }
```

Removed methods:

```csharp
public void ClearWasDetached ();
protected virtual Preference FindPreferenceInHierarchy (string);
public bool WasDetached ();
```


#### Type Changed: AndroidX.Preference.PreferenceFragmentCompat

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


#### Type Changed: AndroidX.Preference.PreferenceGroup

Removed methods:

```csharp
public virtual Preference FindPreference (Java.Lang.ICharSequence);
public Preference FindPreference (string);
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


#### Type Changed: AndroidX.Preference.TwoStatePreference

#### Type Changed: AndroidX.Preference.TwoStatePreference.SavedState

Removed constructors:

```csharp
public TwoStatePreference.SavedState (Android.OS.IParcelable);
public TwoStatePreference.SavedState (Android.OS.Parcel);
```




### Namespace AndroidX.Core.App

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




#### Type Changed: AndroidX.Core.App.ShareCompat

Modified fields:

```diff
-public const string ExtraCallingActivity = "android.support.v4.app.EXTRA_CALLING_ACTIVITY";
+public const string ExtraCallingActivity = "androidx.core.app.EXTRA_CALLING_ACTIVITY";
-public const string ExtraCallingPackage = "android.support.v4.app.EXTRA_CALLING_PACKAGE";
+public const string ExtraCallingPackage = "androidx.core.app.EXTRA_CALLING_PACKAGE";
```


#### Removed Type AndroidX.Core.App.SupportActivity

### Namespace AndroidX.Fragment.App

#### Type Changed: AndroidX.Fragment.App.FragmentActivity

Modified base type:

```diff
-Android.App.Activity
+AndroidX.Activity.ComponentActivity
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

#### Removed Type AndroidX.Fragment.App.FragmentActivity.NonConfigurationInstances


### Namespace AndroidX.Loader.Content

#### Type Changed: AndroidX.Loader.Content.AsyncTaskLoader

Removed method:

```csharp
public virtual void WaitForLoader ();
```



### Namespace AndroidX.Core.Content

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




### Namespace AndroidX.Media

#### Type Changed: AndroidX.Media.AudioAttributesCompat

Removed methods:

```csharp
public static AudioAttributesCompat FromBundle (Android.OS.Bundle);
public virtual Android.OS.Bundle ToBundle ();
```


#### Type Changed: AndroidX.Media.MediaBrowserServiceCompat

#### Type Changed: AndroidX.Media.MediaBrowserServiceCompat.MediaBrowserServiceImplBase

Removed interfaces:

```csharp
Android.Runtime.IJavaObject
MediaBrowserServiceCompat.IMediaBrowserServiceImpl
System.IDisposable
```



#### Type Changed: AndroidX.Media.AudioAttributesImplBaseParcelizer

Removed method:

```csharp
public static Java.Lang.Object Read (AndroidX.VersionedParcelable.VersionedParcel);
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




### Namespace Android.Support.V4.Media.Session

#### Type Changed: Android.Support.V4.Media.Session.MediaControllerCompat

Removed property:

```csharp
public Android.OS.Bundle SessionToken2Bundle { get; }
```

#### Type Changed: Android.Support.V4.Media.Session.MediaControllerCompat.MediaControllerImplBase

Removed interfaces:

```csharp
Android.Runtime.IJavaObject
MediaControllerCompat.IMediaControllerImpl
System.IDisposable
```



#### Type Changed: Android.Support.V4.Media.Session.MediaSessionCompat

Removed constructor:

```csharp
public MediaSessionCompat (Android.Content.Context, string, Android.OS.Bundle);
```

Removed field:

```csharp
public static const string KeySessionToken2Bundle = "android.support.v4.media.session.SESSION_TOKEN2_BUNDLE";
```

#### Type Changed: Android.Support.V4.Media.Session.MediaSessionCompat.MediaSessionImplBase.MediaSessionImplBase

Removed constructor:

```csharp
public MediaSessionCompat.MediaSessionImplBase (Android.Content.Context, string, Android.Content.ComponentName, Android.App.PendingIntent);
```

Removed interfaces:

```csharp
Android.Runtime.IJavaObject
MediaSessionCompat.IMediaSessionImpl
System.IDisposable
```


#### Type Changed: Android.Support.V4.Media.Session.MediaSessionCompat.MediaSessionImplBase.Token

Removed property:

```csharp
public Android.OS.Bundle SessionToken2Bundle { get; set; }
```




### Namespace AndroidX.Core.Text

#### Type Changed: AndroidX.Core.Text.TextDirectionHeuristicsCompat

#### Removed Type AndroidX.Core.Text.TextDirectionHeuristicsCompat.ITextDirectionAlgorithm


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



### Namespace AndroidX.MediaRouter.App

#### Type Changed: AndroidX.MediaRouter.App.MediaRouteChooserDialogFragment

Removed method:

```csharp
public virtual Android.Support.V7.App.MediaRouteDevicePickerDialog OnCreateDevicePickerDialog (Android.Content.Context);
```


#### Type Changed: AndroidX.MediaRouter.App.MediaRouteControllerDialogFragment

Removed method:

```csharp
public virtual Android.Support.V7.App.MediaRouteCastDialog OnCreateCastDialog (Android.Content.Context);
```



### Namespace AndroidX.AppCompat.Graphics.Drawable

#### Type Changed: AndroidX.AppCompat.Graphics.Drawable.AnimatedStateListDrawableCompat

Modified base type:

```diff
-Android.Graphics.Drawables.Drawable
+AndroidX.AppCompat.Graphics.Drawable.DrawableContainer
```

Removed methods:

```csharp
public override Android.Graphics.Drawables.Drawable.ConstantState GetConstantState ();
public override void SetAlpha (int);
```



### Namespace AndroidX.MediaRouter.Media

#### Type Changed: AndroidX.MediaRouter.Media.MediaRouter

#### Removed Type AndroidX.MediaRouter.Media.MediaRouter.RouteGroup


### Namespace AndroidX.RecyclerView.Widget

#### Type Changed: AndroidX.RecyclerView.Widget.DividerItemDecoration

Removed method:

```csharp
public virtual void SetDrawable (Android.Graphics.Drawables.Drawable);
```


#### Type Changed: AndroidX.RecyclerView.Widget.RecyclerView

#### Type Changed: AndroidX.RecyclerView.Widget.RecyclerView.Adapter

Modified properties:

```diff
 public bool HasStableIds { get; ---set;--- }
```


#### Type Changed: AndroidX.RecyclerView.Widget.RecyclerView.ViewFlinger

Removed methods:

```csharp
public virtual void SmoothScrollBy (int, int);
public virtual void SmoothScrollBy (int, int, Android.Views.Animations.IInterpolator);
public virtual void SmoothScrollBy (int, int, int);
public virtual void SmoothScrollBy (int, int, int, int);
```




### Namespace AndroidX.AppCompat.View.Menu

#### Type Changed: AndroidX.AppCompat.View.Menu.MenuPopupHelper

Removed interfaces:

```csharp
Android.Runtime.IJavaObject
Android.Support.V7.View.Menu.IMenuHelper
System.IDisposable
```



### Namespace AndroidX.AppCompat.Widget

#### Type Changed: AndroidX.AppCompat.Widget.AppCompatDrawableManager

#### Removed Type AndroidX.AppCompat.Widget.AppCompatDrawableManager.AsldcInflateDelegate

#### Type Changed: AndroidX.AppCompat.Widget.DialogTitle

Modified base type:

```diff
-Android.Widget.TextView
+AndroidX.AppCompat.Widget.AppCompatTextView
```


#### Type Changed: AndroidX.AppCompat.Widget.ListPopupWindow

Removed method:

```csharp
public virtual void SetEpicenterBounds (Android.Graphics.Rect);
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



### Namespace AndroidX.Slice.Widget

#### Type Changed: AndroidX.Slice.Widget.LargeSliceAdapter

Removed method:

```csharp
public virtual void OnBindViewHolder (int);
```



### Namespace AndroidX.VersionedParcelable

#### Type Changed: AndroidX.VersionedParcelable.VersionedParcel

Removed constructor:

```csharp
public VersionedParcel ();
```

Modified methods:

```diff
 ---static--- protected Java.Lang.Object ReadFromParcel (string parcelCls, VersionedParcel versionedParcel)
 ---static--- protected void WriteToParcel (Java.Lang.Object val, VersionedParcel versionedParcel)
```



### Namespace AndroidX.WebKit.Internal

#### Type Changed: AndroidX.WebKit.Internal.WebViewFeatureInternal

Removed method:

```csharp
public static string[] GetWebViewApkFeaturesForTesting ();
```



### Namespace AndroidX.Work

#### Type Changed: AndroidX.Work.WorkInfo

Removed constructor:

```csharp
public WorkInfo (Java.Util.UUID, WorkInfo.State, Data, System.Collections.Generic.IList<string>);
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
