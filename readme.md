# ERRORS Encountered

1. Do not request Window.FEATURE_ACTION_BAR and set android:windowActionBar to false in your theme to use a Toolbar instead.
    - [Tutoral](https://developer.xamarin.com/guides/android/user_interface/controls/tool-bar/part-1-replacing-the-action-bar/)
    - [Solution](https://github.com/bkhezry/ExtraWebView/issues/1)
	https://stackoverflow.com/questions/47959122/xamarin-replacing-the-action-bar-android-7-1-api-25/47966157#47966157
	
	You need to use a Theme.AppCompat theme (or descendant) with this activity
- - https://stackoverflow.com/a/30019988/3563013


showAsAction=“ifRoom” doesn't show the item even when there is plenty of room
- https://stackoverflow.com/questions/15917973/showasaction-ifroom-doesnt-show-the-item-even-when-there-is-plenty-of-room

“Parse Error : There is a problem parsing the package” while installing Android application
https://stackoverflow.com/a/3268903/3563013
https://stackoverflow.com/questions/1492401/parse-error-there-is-a-problem-parsing-the-package-while-installing-android

Failure [INSTALL_FAILED_NO_MATCHING_ABIS: Failed to extract native libraries, res=-113]
-https://stackoverflow.com/a/41969077/3563013


APP CRASH ERROR AFTER PUBLISH
- https://stackoverflow.com/a/1501361/3563013


Severity	Code	Description	Project	File	Line	Suppression State
Error		2: error: Error: Float types not allowed (at 'versionCode' with value '1.1').	App5	C:\Users\Kabue\source\repos\App5\App5\obj\Release\android\manifest\AndroidManifest.xml		
- https://forums.xamarin.com/discussion/49075/android-app-versioning


Xamarin.Android Support Andoid 4.0 (API 14) and above
- https://stackoverflow.com/q/47983875/3563013
- https://stackoverflow.com/a/40195191/3563013
- https://forums.xamarin.com/discussion/48814/android-api-14-installed-but-missing
- https://forums.xamarin.com/discussion/35951/xamarin-android-requiring-api-14


