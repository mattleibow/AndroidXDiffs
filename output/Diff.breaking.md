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
public virtual void OnStateChanged (ILifecycleOwner p0, Lifecycle.Event p1);
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


#### Type Changed: AndroidX.Lifecycle.Transformations

Modified methods:

```diff
-public LiveData Map (LiveData source, AndroidX.Arch.Core.Util.IFunction func)
+public LiveData Map (LiveData source, AndroidX.Arch.Core.Util.IFunction mapFunction)
-public LiveData SwitchMap (LiveData trigger, AndroidX.Arch.Core.Util.IFunction func---switchMapFunction---)
+public LiveData SwitchMap (LiveData source, AndroidX.Arch.Core.Util.IFunction +++func+++switchMapFunction)
```



### Namespace AndroidX.Room

#### Type Changed: AndroidX.Room.DatabaseConfiguration

Removed constructor:

```csharp
public DatabaseConfiguration (Android.Content.Context context, string name, AndroidX.Sqlite.Db.ISupportSQLiteOpenHelperFactory sqliteOpenHelperFactory, RoomDatabase.MigrationContainer migrationContainer, System.Collections.Generic.IList<Android.Arch.Persistence.Room.RoomDatabase.Callback> callbacks, bool allowMainThreadQueries, RoomDatabase.JournalMode journalMode, bool requireMigration, System.Collections.Generic.ICollection<Java.Lang.Integer> migrationNotRequiredFrom);
```


#### Type Changed: AndroidX.Room.RoomDatabase

#### Type Changed: AndroidX.Room.RoomDatabase.MigrationContainer

Removed method:

```csharp
public virtual System.Collections.Generic.IList<Android.Arch.Persistence.Room.Migration.Migration> FindMigrationPath (int start, int end);
```



#### Type Changed: AndroidX.Room.RoomMasterTable

Removed constructor:

```csharp
public RoomMasterTable ();
```


#### Type Changed: AndroidX.Room.RoomOpenHelper

#### Type Changed: AndroidX.Room.RoomOpenHelper.HelperDelegate

Modified methods:

```diff
-protected abstract void ValidateMigration (AndroidX.Sqlite.Db.ISupportSQLiteDatabase p0---db---)
+protected virtual void ValidateMigration (AndroidX.Sqlite.Db.ISupportSQLiteDatabase +++p0+++db)
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

#### Type Changed: AndroidX.ConstraintLayout.Solver.Widgets.ConstraintWidget

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


#### Type Changed: AndroidX.ConstraintLayout.Solver.Widgets.ConstraintWidgetContainer

Modified properties:

```diff
-public virtual System.Collections.Generic.IList<Android.Support.Constraints.Solver.Widgets.Guideline> HorizontalGuidelines { get; }
+public virtual System.Collections.Generic.IList<Guideline> HorizontalGuidelines { get; }
-public virtual System.Collections.Generic.IList<Android.Support.Constraints.Solver.Widgets.Guideline> VerticalGuidelines { get; }
+public virtual System.Collections.Generic.IList<Guideline> VerticalGuidelines { get; }
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



### Namespace Google.Android.Material.Behavior

#### Type Changed: Google.Android.Material.Behavior.SwipeDismissBehavior

Modified methods:

```diff
-public virtual bool OnInterceptTouchEvent (AndroidX.CoordinatorLayout.Widget.CoordinatorLayout parent, Java.Lang.Object child, Android.Views.MotionEvent event_)
+public virtual bool OnInterceptTouchEvent (AndroidX.CoordinatorLayout.Widget.CoordinatorLayout parent, Java.Lang.Object child, Android.Views.MotionEvent e)
-public virtual bool OnTouchEvent (AndroidX.CoordinatorLayout.Widget.CoordinatorLayout parent, Java.Lang.Object child, Android.Views.MotionEvent event_)
+public virtual bool OnTouchEvent (AndroidX.CoordinatorLayout.Widget.CoordinatorLayout parent, Java.Lang.Object child, Android.Views.MotionEvent e)
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
public Android.Graphics.ColorFilter ColorFilter { get; }
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

#### Type Changed: AndroidX.Core.View.GestureDetectorCompat

#### Type Changed: AndroidX.Core.View.GestureDetectorCompat.GestureDetectorCompatImplBase

Removed interfaces:

```csharp
Android.Runtime.IJavaObject
GestureDetectorCompat.IGestureDetectorCompatImpl
System.IDisposable
```



#### Type Changed: AndroidX.Core.View.ViewCompat

Modified methods:

```diff
-public bool HasAccessibilityDelegate (Android.Views.View v)
+public bool HasAccessibilityDelegate (Android.Views.View view)
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
public virtual Preference FindPreference (Java.Lang.ICharSequence key);
public Preference FindPreference (string key);
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



#### Type Changed: AndroidX.Preference.DialogPreferenceITargetFragmentExtensions

Removed method:

```csharp
public static Preference FindPreference (this DialogPreference.ITargetFragment self, string key);
```


#### Type Changed: AndroidX.Preference.DropDownPreference

Removed method:

```csharp
public virtual int FindSpinnerIndexOfValue (string value);
```


#### Type Changed: AndroidX.Preference.Preference

Removed property:

```csharp
public Android.Content.ISharedPreferences SharedPreferences { get; }
```

Removed methods:

```csharp
public void ClearWasDetached ();
protected virtual Preference FindPreferenceInHierarchy (string key);
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
public virtual Preference FindPreference (Java.Lang.ICharSequence key);
public Preference FindPreference (string key);
```


#### Type Changed: AndroidX.Preference.PreferenceGroup

Removed methods:

```csharp
public virtual Preference FindPreference (Java.Lang.ICharSequence key);
public Preference FindPreference (string key);
```


#### Type Changed: AndroidX.Preference.PreferenceManager

Removed property:

```csharp
public Android.Content.ISharedPreferences SharedPreferences { get; }
```

Removed methods:

```csharp
public virtual Preference FindPreference (Java.Lang.ICharSequence key);
public Preference FindPreference (string key);
public static Android.Content.ISharedPreferences GetDefaultSharedPreferences (Android.Content.Context context);
```


#### Type Changed: AndroidX.Preference.TwoStatePreference

#### Type Changed: AndroidX.Preference.TwoStatePreference.SavedState

Removed constructors:

```csharp
public TwoStatePreference.SavedState (Android.OS.IParcelable superState);
public TwoStatePreference.SavedState (Android.OS.Parcel source);
```




### Namespace AndroidX.Leanback.App

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


#### Type Changed: AndroidX.Leanback.App.GuidedStepSupportFragment

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



### Namespace AndroidX.Leanback.Media

#### Type Changed: AndroidX.Leanback.Media.PlaybackGlue

Modified properties:

```diff
-protected virtual System.Collections.Generic.IList<Android.Support.V17.Leanback.Media.PlaybackGlue.PlayerCallback> PlayerCallbacks { get; }
+protected virtual System.Collections.Generic.IList<PlaybackGlue.PlayerCallback> PlayerCallbacks { get; }
```



### Namespace AndroidX.Leanback.Widget

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



#### Type Changed: AndroidX.Leanback.Widget.GuidedActionAdapter

Removed constructor:

```csharp
public GuidedActionAdapter (System.Collections.Generic.IList<Android.Support.V17.Leanback.Widget.GuidedAction> actions, GuidedActionAdapter.IClickListener clickListener, GuidedActionAdapter.IFocusListener focusListener, GuidedActionsStylist presenter, bool isSubAdapter);
```

Modified properties:

```diff
-public virtual System.Collections.Generic.IList<Android.Support.V17.Leanback.Widget.GuidedAction> Actions { get; set; }
+public virtual System.Collections.Generic.IList<GuidedAction> Actions { get; set; }
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



### Namespace AndroidX.Leanback.Widget.Picker

#### Type Changed: AndroidX.Leanback.Widget.Picker.Picker

Removed method:

```csharp
public virtual void SetColumns (System.Collections.Generic.IList<Android.Support.V17.Leanback.Widget.Picker.PickerColumn> columns);
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

Removed method:

```csharp
public static System.Collections.Generic.IList<Android.Support.V4.App.NotificationCompat.Action> GetInvisibleActions (Android.App.Notification notification);
```

#### Type Changed: AndroidX.Core.App.NotificationCompat.MessagingStyle.MessagingStyle

Modified properties:

```diff
-public virtual System.Collections.Generic.IList<Android.Support.V4.App.NotificationCompat.MessagingStyle.Message> Messages { get; }
+public virtual System.Collections.Generic.IList<NotificationCompat.MessagingStyle.Message> Messages { get; }
```


#### Type Changed: AndroidX.Core.App.NotificationCompat.MessagingStyle.WearableExtender

Modified properties:

```diff
-public System.Collections.Generic.IList<Android.Support.V4.App.NotificationCompat.Action> Actions { get; }
+public System.Collections.Generic.IList<NotificationCompat.Action> Actions { get; }
```

Removed method:

```csharp
public NotificationCompat.WearableExtender AddActions (System.Collections.Generic.IList<Android.Support.V4.App.NotificationCompat.Action> actions);
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

#### Type Changed: AndroidX.Fragment.App.FragmentController

Removed methods:

```csharp
public virtual System.Collections.Generic.IList<Android.Support.V4.App.Fragment> GetActiveFragments (System.Collections.Generic.IList<Android.Support.V4.App.Fragment> actives);

[Obsolete ("deprecated")]
public virtual void RestoreAllState (Android.OS.IParcelable state, System.Collections.Generic.IList<Android.Support.V4.App.Fragment> nonConfigList);

[Obsolete ("deprecated")]
public virtual System.Collections.Generic.IList<Android.Support.V4.App.Fragment> RetainNonConfig ();
```


#### Type Changed: AndroidX.Fragment.App.FragmentManager

Modified properties:

```diff
-public abstract System.Collections.Generic.IList<Android.Support.V4.App.Fragment> Fragments { get; }
+public abstract System.Collections.Generic.IList<Fragment> Fragments { get; }
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
public void Apply (Android.Content.ISharedPreferencesEditor editor);
```




### Namespace AndroidX.Core.Graphics

#### Type Changed: AndroidX.Core.Graphics.PathUtils

Removed methods:

```csharp
public static System.Collections.Generic.ICollection<Android.Support.V4.Graphics.PathSegment> Flatten (Android.Graphics.Path path);
public static System.Collections.Generic.ICollection<Android.Support.V4.Graphics.PathSegment> Flatten (Android.Graphics.Path path, float error);
```



### Namespace AndroidX.Media

#### Type Changed: AndroidX.Media.AudioAttributesCompat

Removed methods:

```csharp
public static AudioAttributesCompat FromBundle (Android.OS.Bundle bundle);
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
public static Java.Lang.Object Read (AndroidX.VersionedParcelable.VersionedParcel parcel);
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
public MediaSessionCompat (Android.Content.Context context, string tag, Android.OS.Bundle token2Bundle);
```

Removed field:

```csharp
public static const string KeySessionToken2Bundle = "android.support.v4.media.session.SESSION_TOKEN2_BUNDLE";
```

#### Type Changed: Android.Support.V4.Media.Session.MediaSessionCompat.MediaSessionImplBase.MediaSessionImplBase

Removed constructor:

```csharp
public MediaSessionCompat.MediaSessionImplBase (Android.Content.Context context, string tag, Android.Content.ComponentName mbrComponent, Android.App.PendingIntent mbrIntent);
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




### Namespace AndroidX.Core.OS

#### Type Changed: AndroidX.Core.OS.LocaleListCompat

Modified methods:

```diff
-public LocaleListCompat Wrap (Java.Lang.Object object)
+public LocaleListCompat Wrap (Java.Lang.Object localeList)
```



### Namespace AndroidX.Core.Text

#### Type Changed: AndroidX.Core.Text.TextDirectionHeuristicsCompat

#### Removed Type AndroidX.Core.Text.TextDirectionHeuristicsCompat.ITextDirectionAlgorithm


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



### Namespace AndroidX.Core.View.Accessibiity

#### Type Changed: AndroidX.Core.View.Accessibiity.AccessibilityNodeInfoCompat

Modified properties:

```diff
-public virtual System.Collections.Generic.IList<Android.Support.V4.View.Accessibility.AccessibilityNodeInfoCompat.AccessibilityActionCompat> ActionList { get; }
+public virtual System.Collections.Generic.IList<AccessibilityNodeInfoCompat.AccessibilityActionCompat> ActionList { get; }
```

Removed methods:

```csharp
public virtual System.Collections.Generic.IList<Android.Support.V4.View.Accessibility.AccessibilityNodeInfoCompat> FindAccessibilityNodeInfosByText (string text);
public virtual System.Collections.Generic.IList<Android.Support.V4.View.Accessibility.AccessibilityNodeInfoCompat> FindAccessibilityNodeInfosByViewId (string viewId);
```


#### Type Changed: AndroidX.Core.View.Accessibiity.AccessibilityNodeProviderCompat

Removed method:

```csharp
public virtual System.Collections.Generic.IList<Android.Support.V4.View.Accessibility.AccessibilityNodeInfoCompat> FindAccessibilityNodeInfosByText (string text, int virtualViewId);
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

#### Type Changed: AndroidX.MediaRouter.App.MediaRouteChooserDialog

Removed method:

```csharp
public virtual void OnFilterRoutes (System.Collections.Generic.IList<Android.Support.V7.Media.MediaRouter.RouteInfo> routes);
```


#### Type Changed: AndroidX.MediaRouter.App.MediaRouteChooserDialogFragment

Removed method:

```csharp
public virtual Android.Support.V7.App.MediaRouteDevicePickerDialog OnCreateDevicePickerDialog (Android.Content.Context context);
```


#### Type Changed: AndroidX.MediaRouter.App.MediaRouteControllerDialogFragment

Removed method:

```csharp
public virtual Android.Support.V7.App.MediaRouteCastDialog OnCreateCastDialog (Android.Content.Context context);
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

#### Type Changed: AndroidX.Palette.Graphics.Palette.Builder

Removed constructor:

```csharp
public Palette.Builder (System.Collections.Generic.IList<Android.Support.V7.Graphics.Palette.Swatch> swatches);
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
public override void SetAlpha (int p0);
```



### Namespace AndroidX.MediaRouter.Media

#### Type Changed: AndroidX.MediaRouter.Media.MediaRouteProviderDescriptor

Modified properties:

```diff
-public System.Collections.Generic.IList<Android.Support.V7.Media.MediaRouteDescriptor> Routes { get; }
+public System.Collections.Generic.IList<MediaRouteDescriptor> Routes { get; }
```

#### Type Changed: AndroidX.MediaRouter.Media.MediaRouteProviderDescriptor.Builder

Removed method:

```csharp
public MediaRouteProviderDescriptor.Builder AddRoutes (System.Collections.Generic.ICollection<Android.Support.V7.Media.MediaRouteDescriptor> routes);
```



#### Type Changed: AndroidX.MediaRouter.Media.MediaRouter

Modified properties:

```diff
-public System.Collections.Generic.IList<Android.Support.V7.Media.MediaRouter.ProviderInfo> Providers { get; }
+public System.Collections.Generic.IList<MediaRouter.ProviderInfo> Providers { get; }
-public System.Collections.Generic.IList<Android.Support.V7.Media.MediaRouter.RouteInfo> Routes { get; }
+public System.Collections.Generic.IList<MediaRouter.RouteInfo> Routes { get; }
```

#### Type Changed: AndroidX.MediaRouter.Media.MediaRouter.ProviderInfo

Modified properties:

```diff
-public System.Collections.Generic.IList<Android.Support.V7.Media.MediaRouter.RouteInfo> Routes { get; }
+public System.Collections.Generic.IList<MediaRouter.RouteInfo> Routes { get; }
```


#### Removed Type AndroidX.MediaRouter.Media.MediaRouter.RouteGroup


### Namespace AndroidX.RecyclerView.Widget

#### Type Changed: AndroidX.RecyclerView.Widget.DividerItemDecoration

Removed method:

```csharp
public virtual void SetDrawable (Android.Graphics.Drawables.Drawable drawable);
```


#### Type Changed: AndroidX.RecyclerView.Widget.RecyclerView

Modified constructors:

```diff
-public RecyclerView (Android.Content.Context context, Android.Util.IAttributeSet attrs, int defStyle)
+public RecyclerView (Android.Content.Context context, Android.Util.IAttributeSet attrs, int defStyleAttr)
```

#### Type Changed: AndroidX.RecyclerView.Widget.RecyclerView.Adapter

Modified properties:

```diff
 public bool HasStableIds { get; ---set;--- }
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


#### Type Changed: AndroidX.RecyclerView.Widget.ItemTouchHelper.IViewDropHandler

Modified methods:

```diff
-public abstract void PrepareForDrop (Android.Views.View view, Android.Views.View target---p1---, int x---p2---, int y---p3---)
+public abstract void PrepareForDrop (Android.Views.View p0, Android.Views.View +++target+++p1, int +++x+++p2, int +++y+++p3)
```




### Namespace AndroidX.AppCompat.View.Menu

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
public virtual void SetEpicenterBounds (Android.Graphics.Rect bounds);
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



### Namespace AndroidX.Wear.Widget

#### Type Changed: AndroidX.Wear.Widget.WearableLinearLayoutManager

#### Type Changed: AndroidX.Wear.Widget.WearableLinearLayoutManager.LayoutCallback

Modified methods:

```diff
-public abstract void OnLayoutFinished (Android.Views.View child, AndroidX.RecyclerView.Widget.RecyclerView parent---p1---)
+public abstract void OnLayoutFinished (Android.Views.View p0, AndroidX.RecyclerView.Widget.RecyclerView +++parent+++p1)
```




### Namespace AndroidX.Slice.Widget

#### Type Changed: AndroidX.Slice.Widget.LargeSliceAdapter

Removed method:

```csharp
public virtual void OnBindViewHolder (int position);
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



### Namespace AndroidX.WebKit

#### Type Changed: AndroidX.WebKit.WebSettingsCompat

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



### Namespace AndroidX.WebKit.Internal

#### Type Changed: AndroidX.WebKit.Internal.WebViewFeatureInternal

Removed method:

```csharp
public static string[] GetWebViewApkFeaturesForTesting ();
```

Modified methods:

```diff
-public WebViewFeatureInternal GetFeature (string feature)
+public WebViewFeatureInternal GetFeature (string publicFeatureValue)
```



### Namespace AndroidX.Work

#### Type Changed: AndroidX.Work.WorkInfo

Removed constructor:

```csharp
public WorkInfo (Java.Util.UUID id, WorkInfo.State state, Data outputData, System.Collections.Generic.IList<string> tags);
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
