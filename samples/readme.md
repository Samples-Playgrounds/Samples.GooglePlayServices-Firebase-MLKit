# Readme

Google.Play.Services and Firebase repro samples.

## Samples

*	Build fails when install Xamarin.GooglePlayServices.Ads.Lite in .NET MAUI RC1 #603

	*	GPS

	*	https://github.com/xamarin/GooglePlayServicesComponents/issues/603

		*	https://github.com/nacompllo/AdsLiteIssue

*	Unable to recognize single digit characters from receipts #566

	*	FB

	*	https://github.com/xamarin/GooglePlayServicesComponents/issues/566

		*	https://github.com/manan-itsol/MlKitTextRecognitionSample

*	.NET 6 packages don't download the native Java dependencies #553

	*	GPS-FB-MLKit

		*	https://github.com/xamarin/GooglePlayServicesComponents/issues/553

			*	https://github.com/xamarin/GooglePlayServicesComponents/files/7695638/Archive.zip

*	[BUG] Crash at runtime Xamarin.Firebase.InAppMessaging.Display 120.1.0.2 #551

	*	FB

	*	https://github.com/xamarin/GooglePlayServicesComponents/issues/551

		*	https://github.com/xamarin/GooglePlayServicesComponents/files/7682503/AppTest.zip



*   Issue228-not_logged/archive_20190702/firebaseperfunoexperiment
    *   javac ACW errors
    *   unable to update to 28.0.0.2 because of Uno.UI 
*   Issue228-not_logged/perf_preview/FirebasePerf
    *   javac ACW errors

## `Issue228-not_logged/firebaseperfunoexperiment.Droid`

###   turned off aapt2 

```
```

### update to 28.0.0.2

```
Version conflict detected for Xamarin.Android.Support.Compat. Install/reference Xamarin.Android.Support.Compat 28.0.0.2 directly to project firebaseperfunoexperiment.Droid to resolve this issue. 
 firebaseperfunoexperiment.Droid -> Xamarin.Android.Support.v7.AppCompat 28.0.0.2 -> Xamarin.Android.Support.Compat (>= 28.0.0.2) 
 firebaseperfunoexperiment.Droid -> Uno.UI 1.46.0-dev.1978 -> Xamarin.Android.Support.v4 28.0.0.1 -> Xamarin.Android.Support.Compat (= 28.0.0.1).
```

## `Issue173-no_network_call/s1`


## `Issue228-not_logged/FirebasePerf`

```
Version conflict detected for Xamarin.Android.Support.Core.UI. Install/reference Xamarin.Android.Support.Core.UI 28.0.0.2 directly to project FirebasePerf.Android to resolve this issue. 
 FirebasePerf.Android -> Xamarin.Android.Support.v7.AppCompat 28.0.0.2 -> Xamarin.Android.Support.Fragment 28.0.0.2 -> Xamarin.Android.Support.Core.UI (>= 28.0.0.2) 
 FirebasePerf.Android -> Xamarin.Android.Support.Design 28.0.0.1 -> Xamarin.Android.Support.Core.UI (= 28.0.0.1).
```

```
Version conflict detected for Xamarin.Android.Support.VersionedParcelable. Install/reference Xamarin.Android.Support.VersionedParcelable 28.0.0.2 directly to project FirebasePerf.Android to resolve this issue. 
 FirebasePerf.Android -> Xamarin.Android.Support.v4 28.0.0.2 -> Xamarin.Android.Support.Media.Compat 28.0.0.2 -> Xamarin.Android.Support.VersionedParcelable (>= 28.0.0.2) 
 FirebasePerf.Android -> Xamarin.Android.Support.Compat 28.0.0.1 -> Xamarin.Android.Support.VersionedParcelable (= 28.0.0.1).
```

## `Issue228-not_logged/firebaseperfunoexperiment`

`javac` ACW errors:

```
Error:  error: package com.google.android.gms.tasks does not exist
		com.google.android.gms.tasks.OnCompleteListener
Error:  error: package com.google.android.gms.tasks does not exist
	public void onComplete (com.google.android.gms.tasks.Task p0)
Error:  error: package com.google.android.gms.tasks does not exist
	private native void n_onComplete (com.google.android.gms.tasks.Task p0);
Error:  error: package com.google.android.gms.common.api.GoogleApiClient does not exist
		com.google.android.gms.common.api.GoogleApiClient.OnConnectionFailedListener
Error:  error: package com.google.android.gms.common does not exist
	public void onConnectionFailed (com.google.android.gms.common.ConnectionResult p0)
Error:  error: package com.google.android.gms.common does not exist
	private native void n_onConnectionFailed (com.google.android.gms.common.ConnectionResult p0);
error: package com.google.android.gms.common.api.GoogleApiClient does not exist
		com.google.android.gms.common.api.GoogleApiClient.ConnectionCallbacks
Error:  error: package com.google.android.gms.common.api does not exist
		com.google.android.gms.common.api.ResultCallback
Error:  error: package com.google.android.gms.common.api does not exist
	public void onResult (com.google.android.gms.common.api.Result p0)
Error:  error: package com.google.android.gms.common.api does not exist
	private native void n_onResult (com.google.android.gms.common.api.Result p0);
Error:  error: package com.google.android.gms.common.api does not exist
		com.google.android.gms.common.api.ResultCallback
Error:  error: package com.google.android.gms.common.api does not exist
	public void onResult (com.google.android.gms.common.api.Result p0)
Error:  error: package com.google.android.gms.common.api does not exist
	private native void n_onResult (com.google.android.gms.common.api.Result p0);
Error:  error: package com.google.firebase does not exist
		com.google.firebase.FirebaseAppLifecycleListener
Error:  error: package com.google.firebase does not exist
	public void onDeleted (java.lang.String p0, com.google.firebase.FirebaseOptions p1)
Error:  error: package com.google.firebase does not exist
	private native void n_onDeleted (java.lang.String p0, com.google.firebase.FirebaseOptions p1);
Error:  error: package com.google.firebase.FirebaseApp does not exist
		com.google.firebase.FirebaseApp.BackgroundStateChangeListener
Error:  error: package com.google.firebase.FirebaseApp does not exist
		com.google.firebase.FirebaseApp.IdTokenListenersCountChangedListener
Error:  error: package com.google.firebase.FirebaseApp does not exist
		com.google.firebase.FirebaseApp.IdTokenListener
Error:  error: package com.google.firebase.internal does not exist
	public void onIdTokenChanged (com.google.firebase.internal.InternalTokenResult p0)
Error:  error: package com.google.firebase.internal does not exist
	private native void n_onIdTokenChanged (com.google.firebase.internal.InternalTokenResult p0);
Error:  error: package com.google.android.gms.tasks does not exist
		com.google.android.gms.tasks.OnSuccessListener
Error:  error: package com.google.android.gms.tasks does not exist
		com.google.android.gms.tasks.OnCanceledListener
Error:  error: package com.google.android.gms.tasks does not exist
		com.google.android.gms.tasks.OnFailureListener
Error:  error: package com.google.android.gms.tasks does not exist
		com.google.android.gms.tasks.OnTokenCanceledListener
Error:  error: package com.google.android.gms.tasks does not exist
		com.google.android.gms.tasks.OnCompleteListener
Error:  error: package com.google.android.gms.tasks does not exist
	public void onComplete (com.google.android.gms.tasks.Task p0)
Error:  error: package com.google.android.gms.tasks does not exist
	private native void n_onComplete (com.google.android.gms.tasks.Task p0);
Error:  error: package com.google.android.gms.dynamic does not exist
		com.google.android.gms.dynamic.OnDelegateCreatedListener
Error:  error: package com.google.android.gms.dynamic does not exist
	public void onDelegateCreated (com.google.android.gms.dynamic.LifecycleDelegate p0)
Error:  error: package com.google.android.gms.dynamic does not exist
	private native void n_onDelegateCreated (com.google.android.gms.dynamic.LifecycleDelegate p0);
Error:  error: package com.google.android.gms.security.ProviderInstaller does not exist
		com.google.android.gms.security.ProviderInstaller.ProviderInstallListener
Error:  error: package com.google.android.gms.common.images.ImageManager does not exist
		com.google.android.gms.common.images.ImageManager.OnImageLoadedListener
Error:  error: package com.google.android.gms.common.api.PendingResult does not exist
		com.google.android.gms.common.api.PendingResult.StatusListener
Error:  error: package com.google.android.gms.common.api does not exist
	public void onComplete (com.google.android.gms.common.api.Status p0)
Error:  error: package com.google.android.gms.common.api does not exist
	private native void n_onComplete (com.google.android.gms.common.api.Status p0);
Error:  error: package com.google.android.gms.common.api.GoogleApiClient does not exist
		com.google.android.gms.common.api.GoogleApiClient.OnConnectionFailedListener
Error:  error: package com.google.android.gms.common does not exist
	public void onConnectionFailed (com.google.android.gms.common.ConnectionResult p0)
Error:  error: package com.google.android.gms.common does not exist
	private native void n_onConnectionFailed (com.google.android.gms.common.ConnectionResult p0);
Error:  error: package com.google.android.gms.common.api.internal does not exist
		com.google.android.gms.common.api.internal.SignInConnectionListener
Error:  error: package com.google.android.gms.common.api.internal.BackgroundDetector does not exist
		com.google.android.gms.common.api.internal.BackgroundDetector.BackgroundStateChangeListener
```

original errors (formatted, line breaks added)

```
./samples/com.google.firebase/firebase-perf/Issue228-not_logged/archive_20190702/firebaseperfunoexperiment/firebaseperfunoexperiment.Droid/obj/Debug/android/src/md5dab4f5c7853fd57f3a9c9a523364ac69/AwaitableTaskCompleteListener_1.java(31,31): 
Error:  error: package com.google.android.gms.tasks does not exist
		com.google.android.gms.tasks.OnCompleteListener
 (firebaseperfunoexperiment.Droid) javac
./samples/com.google.firebase/firebase-perf/Issue228-not_logged/archive_20190702/firebaseperfunoexperiment/firebaseperfunoexperiment.Droid/obj/Debug/android/src/md5dab4f5c7853fd57f3a9c9a523364ac69/AwaitableTaskCompleteListener_1.java(54,54): 
Error:  error: package com.google.android.gms.tasks does not exist
	public void onComplete (com.google.android.gms.tasks.Task p0)
 (firebaseperfunoexperiment.Droid) javac
./samples/com.google.firebase/firebase-perf/Issue228-not_logged/archive_20190702/firebaseperfunoexperiment/firebaseperfunoexperiment.Droid/obj/Debug/android/src/md5dab4f5c7853fd57f3a9c9a523364ac69/AwaitableTaskCompleteListener_1.java(64,64): 
Error:  error: package com.google.android.gms.tasks does not exist
	private native void n_onComplete (com.google.android.gms.tasks.Task p0);
 (firebaseperfunoexperiment.Droid) javac
./samples/com.google.firebase/firebase-perf/Issue228-not_logged/archive_20190702/firebaseperfunoexperiment/firebaseperfunoexperiment.Droid/obj/Debug/android/src/md513074be467e0034b6ca192c1689af813/GoogleApiClientOnConnectionFailedListenerImpl.java(52,52): 
Error:  error: package com.google.android.gms.common.api.GoogleApiClient does not exist
		com.google.android.gms.common.api.GoogleApiClient.OnConnectionFailedListener
 (firebaseperfunoexperiment.Droid) javac
./samples/com.google.firebase/firebase-perf/Issue228-not_logged/archive_20190702/firebaseperfunoexperiment/firebaseperfunoexperiment.Droid/obj/Debug/android/src/md513074be467e0034b6ca192c1689af813/GoogleApiClientOnConnectionFailedListenerImpl.java(63,63): 
Error:  error: package com.google.android.gms.common does not exist
	public void onConnectionFailed (com.google.android.gms.common.ConnectionResult p0)
 (firebaseperfunoexperiment.Droid) javac
./samples/com.google.firebase/firebase-perf/Issue228-not_logged/archive_20190702/firebaseperfunoexperiment/firebaseperfunoexperiment.Droid/obj/Debug/android/src/md513074be467e0034b6ca192c1689af813/GoogleApiClientOnConnectionFailedListenerImpl.java(73,73): 
Error:  error: package com.google.android.gms.common does not exist
	private native void n_onConnectionFailed (com.google.android.gms.common.ConnectionResult p0);
 (firebaseperfunoexperiment.Droid) javac
./samples/com.google.firebase/firebase-perf/Issue228-not_logged/archive_20190702/firebaseperfunoexperiment/firebaseperfunoexperiment.Droid/obj/Debug/android/src/md513074be467e0034b6ca192c1689af813/GoogleApiClientConnectionCallbacksImpl.java(52,52): Error:  
error: package com.google.android.gms.common.api.GoogleApiClient does not exist
		com.google.android.gms.common.api.GoogleApiClient.ConnectionCallbacks
 (firebaseperfunoexperiment.Droid) javac
./samples/com.google.firebase/firebase-perf/Issue228-not_logged/archive_20190702/firebaseperfunoexperiment/firebaseperfunoexperiment.Droid/obj/Debug/android/src/md513d0258903c37fed2a3d17a14e8551a2/AwaitableResultCallback_1.java(36,36): 
Error:  error: package com.google.android.gms.common.api does not exist
		com.google.android.gms.common.api.ResultCallback
 (firebaseperfunoexperiment.Droid) javac
./samples/com.google.firebase/firebase-perf/Issue228-not_logged/archive_20190702/firebaseperfunoexperiment/firebaseperfunoexperiment.Droid/obj/Debug/android/src/md513d0258903c37fed2a3d17a14e8551a2/AwaitableResultCallback_1.java(57,57): 
Error:  error: package com.google.android.gms.common.api does not exist
	public void onResult (com.google.android.gms.common.api.Result p0)
 (firebaseperfunoexperiment.Droid) javac
./samples/com.google.firebase/firebase-perf/Issue228-not_logged/archive_20190702/firebaseperfunoexperiment/firebaseperfunoexperiment.Droid/obj/Debug/android/src/md513d0258903c37fed2a3d17a14e8551a2/AwaitableResultCallback_1.java(67,67): 
Error:  error: package com.google.android.gms.common.api does not exist
	private native void n_onResult (com.google.android.gms.common.api.Result p0);
 (firebaseperfunoexperiment.Droid) javac
./samples/com.google.firebase/firebase-perf/Issue228-not_logged/archive_20190702/firebaseperfunoexperiment/firebaseperfunoexperiment.Droid/obj/Debug/android/src/md513d0258903c37fed2a3d17a14e8551a2/ResultCallback_1.java(36,36).:  
Error:  error: package com.google.android.gms.common.api does not exist
		com.google.android.gms.common.api.ResultCallback
 (firebaseperfunoexperiment.Droid) javac
./samples/com.google.firebase/firebase-perf/Issue228-not_logged/archive_20190702/firebaseperfunoexperiment/firebaseperfunoexperiment.Droid/obj/Debug/android/src/md513d0258903c37fed2a3d17a14e8551a2/ResultCallback_1.java(57,57).:  
Error:  error: package com.google.android.gms.common.api does not exist
	public void onResult (com.google.android.gms.common.api.Result p0)
 (firebaseperfunoexperiment.Droid) javac
./samples/com.google.firebase/firebase-perf/Issue228-not_logged/archive_20190702/firebaseperfunoexperiment/firebaseperfunoexperiment.Droid/obj/Debug/android/src/md513d0258903c37fed2a3d17a14e8551a2/ResultCallback_1.java(67,67).:  
Error:  error: package com.google.android.gms.common.api does not exist
	private native void n_onResult (com.google.android.gms.common.api.Result p0);
 (firebaseperfunoexperiment.Droid) javac
./samples/com.google.firebase/firebase-perf/Issue228-not_logged/archive_20190702/firebaseperfunoexperiment/firebaseperfunoexperiment.Droid/obj/Debug/android/src/mono/com/google/firebase/FirebaseAppLifecycleListenerImplementor.java(22,22).:  
Error:  error: package com.google.firebase does not exist
		com.google.firebase.FirebaseAppLifecycleListener
 (firebaseperfunoexperiment.Droid) javac
./samples/com.google.firebase/firebase-perf/Issue228-not_logged/archive_20190702/firebaseperfunoexperiment/firebaseperfunoexperiment.Droid/obj/Debug/android/src/mono/com/google/firebase/FirebaseAppLifecycleListenerImplementor.java(65,65).:  
Error:  error: package com.google.firebase does not exist
	public void onDeleted (java.lang.String p0, com.google.firebase.FirebaseOptions p1)
 (firebaseperfunoexperiment.Droid) javac
./samples/com.google.firebase/firebase-perf/Issue228-not_logged/archive_20190702/firebaseperfunoexperiment/firebaseperfunoexperiment.Droid/obj/Debug/android/src/mono/com/google/firebase/FirebaseAppLifecycleListenerImplementor.java(75,75).:  
Error:  error: package com.google.firebase does not exist
	private native void n_onDeleted (java.lang.String p0, com.google.firebase.FirebaseOptions p1);
 (firebaseperfunoexperiment.Droid) javac
./samples/com.google.firebase/firebase-perf/Issue228-not_logged/archive_20190702/firebaseperfunoexperiment/firebaseperfunoexperiment.Droid/obj/Debug/android/src/mono/com/google/firebase/FirebaseApp_BackgroundStateChangeListenerImplementor.java(34,34).:  
Error:  error: package com.google.firebase.FirebaseApp does not exist
		com.google.firebase.FirebaseApp.BackgroundStateChangeListener
 (firebaseperfunoexperiment.Droid) javac
./samples/com.google.firebase/firebase-perf/Issue228-not_logged/archive_20190702/firebaseperfunoexperiment/firebaseperfunoexperiment.Droid/obj/Debug/android/src/mono/com/google/firebase/FirebaseApp_IdTokenListenersCountChangedListenerImplementor.java(34,34).:  
Error:  error: package com.google.firebase.FirebaseApp does not exist
		com.google.firebase.FirebaseApp.IdTokenListenersCountChangedListener
 (firebaseperfunoexperiment.Droid) javac
./samples/com.google.firebase/firebase-perf/Issue228-not_logged/archive_20190702/firebaseperfunoexperiment/firebaseperfunoexperiment.Droid/obj/Debug/android/src/mono/com/google/firebase/FirebaseApp_IdTokenListenerImplementor.java(34,34).:  
Error:  error: package com.google.firebase.FirebaseApp does not exist
		com.google.firebase.FirebaseApp.IdTokenListener
 (firebaseperfunoexperiment.Droid) javac
./samples/com.google.firebase/firebase-perf/Issue228-not_logged/archive_20190702/firebaseperfunoexperiment/firebaseperfunoexperiment.Droid/obj/Debug/android/src/mono/com/google/firebase/FirebaseApp_IdTokenListenerImplementor.java(60,60).:  
Error:  error: package com.google.firebase.internal does not exist
	public void onIdTokenChanged (com.google.firebase.internal.InternalTokenResult p0)
 (firebaseperfunoexperiment.Droid) javac
./samples/com.google.firebase/firebase-perf/Issue228-not_logged/archive_20190702/firebaseperfunoexperiment/firebaseperfunoexperiment.Droid/obj/Debug/android/src/mono/com/google/firebase/FirebaseApp_IdTokenListenerImplementor.java(70,70).:  
Error:  error: package com.google.firebase.internal does not exist
	private native void n_onIdTokenChanged (com.google.firebase.internal.InternalTokenResult p0);
 (firebaseperfunoexperiment.Droid) javac
./samples/com.google.firebase/firebase-perf/Issue228-not_logged/archive_20190702/firebaseperfunoexperiment/firebaseperfunoexperiment.Droid/obj/Debug/android/src/mono/com/google/android/gms/tasks/OnSuccessListenerImplementor.java(31,31).:  
Error:  error: package com.google.android.gms.tasks does not exist
		com.google.android.gms.tasks.OnSuccessListener
 (firebaseperfunoexperiment.Droid) javac
./samples/com.google.firebase/firebase-perf/Issue228-not_logged/archive_20190702/firebaseperfunoexperiment/firebaseperfunoexperiment.Droid/obj/Debug/android/src/mono/com/google/android/gms/tasks/OnCanceledListenerImplementor.java(31,31).:  
Error:  error: package com.google.android.gms.tasks does not exist
		com.google.android.gms.tasks.OnCanceledListener
 (firebaseperfunoexperiment.Droid) javac
./samples/com.google.firebase/firebase-perf/Issue228-not_logged/archive_20190702/firebaseperfunoexperiment/firebaseperfunoexperiment.Droid/obj/Debug/android/src/mono/com/google/android/gms/tasks/OnFailureListenerImplementor.java(31,31).:  
Error:  error: package com.google.android.gms.tasks does not exist
		com.google.android.gms.tasks.OnFailureListener
 (firebaseperfunoexperiment.Droid) javac
./samples/com.google.firebase/firebase-perf/Issue228-not_logged/archive_20190702/firebaseperfunoexperiment/firebaseperfunoexperiment.Droid/obj/Debug/android/src/mono/com/google/android/gms/tasks/OnTokenCanceledListenerImplementor.java(31,31).:  
Error:  error: package com.google.android.gms.tasks does not exist
		com.google.android.gms.tasks.OnTokenCanceledListener
 (firebaseperfunoexperiment.Droid) javac
./samples/com.google.firebase/firebase-perf/Issue228-not_logged/archive_20190702/firebaseperfunoexperiment/firebaseperfunoexperiment.Droid/obj/Debug/android/src/mono/com/google/android/gms/tasks/OnCompleteListenerImplementor.java(31,31).:  
Error:  error: package com.google.android.gms.tasks does not exist
		com.google.android.gms.tasks.OnCompleteListener
 (firebaseperfunoexperiment.Droid) javac
./samples/com.google.firebase/firebase-perf/Issue228-not_logged/archive_20190702/firebaseperfunoexperiment/firebaseperfunoexperiment.Droid/obj/Debug/android/src/mono/com/google/android/gms/tasks/OnCompleteListenerImplementor.java(54,54).:  
Error:  error: package com.google.android.gms.tasks does not exist
	public void onComplete (com.google.android.gms.tasks.Task p0)
 (firebaseperfunoexperiment.Droid) javac
./samples/com.google.firebase/firebase-perf/Issue228-not_logged/archive_20190702/firebaseperfunoexperiment/firebaseperfunoexperiment.Droid/obj/Debug/android/src/mono/com/google/android/gms/tasks/OnCompleteListenerImplementor.java(64,64).:  
Error:  error: package com.google.android.gms.tasks does not exist
	private native void n_onComplete (com.google.android.gms.tasks.Task p0);
 (firebaseperfunoexperiment.Droid) javac
./samples/com.google.firebase/firebase-perf/Issue228-not_logged/archive_20190702/firebaseperfunoexperiment/firebaseperfunoexperiment.Droid/obj/Debug/android/src/mono/com/google/android/gms/dynamic/OnDelegateCreatedListenerImplementor.java(33,33).:  
Error:  error: package com.google.android.gms.dynamic does not exist
		com.google.android.gms.dynamic.OnDelegateCreatedListener
 (firebaseperfunoexperiment.Droid) javac
./samples/com.google.firebase/firebase-perf/Issue228-not_logged/archive_20190702/firebaseperfunoexperiment/firebaseperfunoexperiment.Droid/obj/Debug/android/src/mono/com/google/android/gms/dynamic/OnDelegateCreatedListenerImplementor.java(63,63).:  
Error:  error: package com.google.android.gms.dynamic does not exist
	public void onDelegateCreated (com.google.android.gms.dynamic.LifecycleDelegate p0)
 (firebaseperfunoexperiment.Droid) javac
./samples/com.google.firebase/firebase-perf/Issue228-not_logged/archive_20190702/firebaseperfunoexperiment/firebaseperfunoexperiment.Droid/obj/Debug/android/src/mono/com/google/android/gms/dynamic/OnDelegateCreatedListenerImplementor.java(73,73).:  
Error:  error: package com.google.android.gms.dynamic does not exist
	private native void n_onDelegateCreated (com.google.android.gms.dynamic.LifecycleDelegate p0);
 (firebaseperfunoexperiment.Droid) javac
./samples/com.google.firebase/firebase-perf/Issue228-not_logged/archive_20190702/firebaseperfunoexperiment/firebaseperfunoexperiment.Droid/obj/Debug/android/src/mono/com/google/android/gms/security/ProviderInstaller_ProviderInstallListenerImplementor.java(52,52).:  
Error:  error: package com.google.android.gms.security.ProviderInstaller does not exist
		com.google.android.gms.security.ProviderInstaller.ProviderInstallListener
 (firebaseperfunoexperiment.Droid) javac
./samples/com.google.firebase/firebase-perf/Issue228-not_logged/archive_20190702/firebaseperfunoexperiment/firebaseperfunoexperiment.Droid/obj/Debug/android/src/mono/com/google/android/gms/common/images/ImageManager_OnImageLoadedListenerImplementor.java(52,52).:  
Error:  error: package com.google.android.gms.common.images.ImageManager does not exist
		com.google.android.gms.common.images.ImageManager.OnImageLoadedListener
 (firebaseperfunoexperiment.Droid) javac
./samples/com.google.firebase/firebase-perf/Issue228-not_logged/archive_20190702/firebaseperfunoexperiment/firebaseperfunoexperiment.Droid/obj/Debug/android/src/mono/com/google/android/gms/common/api/PendingResult_StatusListenerImplementor.java(50,50).:  
Error:  error: package com.google.android.gms.common.api.PendingResult does not exist
		com.google.android.gms.common.api.PendingResult.StatusListener
 (firebaseperfunoexperiment.Droid) javac
./samples/com.google.firebase/firebase-perf/Issue228-not_logged/archive_20190702/firebaseperfunoexperiment/firebaseperfunoexperiment.Droid/obj/Debug/android/src/mono/com/google/android/gms/common/api/PendingResult_StatusListenerImplementor.java(59,59).:  
Error:  error: package com.google.android.gms.common.api does not exist
	public void onComplete (com.google.android.gms.common.api.Status p0)
 (firebaseperfunoexperiment.Droid) javac
./samples/com.google.firebase/firebase-perf/Issue228-not_logged/archive_20190702/firebaseperfunoexperiment/firebaseperfunoexperiment.Droid/obj/Debug/android/src/mono/com/google/android/gms/common/api/PendingResult_StatusListenerImplementor.java(69,69).:  
Error:  error: package com.google.android.gms.common.api does not exist
	private native void n_onComplete (com.google.android.gms.common.api.Status p0);
 (firebaseperfunoexperiment.Droid) javac
./samples/com.google.firebase/firebase-perf/Issue228-not_logged/archive_20190702/firebaseperfunoexperiment/firebaseperfunoexperiment.Droid/obj/Debug/android/src/mono/com/google/android/gms/common/api/GoogleApiClient_OnConnectionFailedListenerImplementor.java(52,52).:  
Error:  error: package com.google.android.gms.common.api.GoogleApiClient does not exist
		com.google.android.gms.common.api.GoogleApiClient.OnConnectionFailedListener
 (firebaseperfunoexperiment.Droid) javac
./samples/com.google.firebase/firebase-perf/Issue228-not_logged/archive_20190702/firebaseperfunoexperiment/firebaseperfunoexperiment.Droid/obj/Debug/android/src/mono/com/google/android/gms/common/api/GoogleApiClient_OnConnectionFailedListenerImplementor.java(63,63).:  
Error:  error: package com.google.android.gms.common does not exist
	public void onConnectionFailed (com.google.android.gms.common.ConnectionResult p0)
 (firebaseperfunoexperiment.Droid) javac
./samples/com.google.firebase/firebase-perf/Issue228-not_logged/archive_20190702/firebaseperfunoexperiment/firebaseperfunoexperiment.Droid/obj/Debug/android/src/mono/com/google/android/gms/common/api/GoogleApiClient_OnConnectionFailedListenerImplementor.java(73,73).:  
Error:  error: package com.google.android.gms.common does not exist
	private native void n_onConnectionFailed (com.google.android.gms.common.ConnectionResult p0);
 (firebaseperfunoexperiment.Droid) javac
./samples/com.google.firebase/firebase-perf/Issue228-not_logged/archive_20190702/firebaseperfunoexperiment/firebaseperfunoexperiment.Droid/obj/Debug/android/src/mono/com/google/android/gms/common/api/internal/SignInConnectionListenerImplementor.java(45,45).:  
Error:  error: package com.google.android.gms.common.api.internal does not exist
		com.google.android.gms.common.api.internal.SignInConnectionListener
 (firebaseperfunoexperiment.Droid) javac
./samples/com.google.firebase/firebase-perf/Issue228-not_logged/archive_20190702/firebaseperfunoexperiment/firebaseperfunoexperiment.Droid/obj/Debug/android/src/mono/com/google/android/gms/common/api/internal/BackgroundDetector_BackgroundStateChangeListenerImplementor.java(64,64).:  
Error:  error: package com.google.android.gms.common.api.internal.BackgroundDetector does not exist
		com.google.android.gms.common.api.internal.BackgroundDetector.BackgroundStateChangeListener
 (firebaseperfunoexperiment.Droid)
 ```

 upgrade to 28.0.0.2

```
Version conflict detected for Xamarin.Android.Support.Compat. Install/reference Xamarin.Android.Support.Compat 28.0.0.2 directly to project firebaseperfunoexperiment.Droid to resolve this issue. 
 firebaseperfunoexperiment.Droid -> Xamarin.Android.Support.v7.AppCompat 28.0.0.2 -> Xamarin.Android.Support.Compat (>= 28.0.0.2) 
 firebaseperfunoexperiment.Droid -> Uno.UI 1.46.0-dev.1978 -> Xamarin.Android.Support.v4 28.0.0.1 -> Xamarin.Android.Support.Compat (= 28.0.0.1).
```