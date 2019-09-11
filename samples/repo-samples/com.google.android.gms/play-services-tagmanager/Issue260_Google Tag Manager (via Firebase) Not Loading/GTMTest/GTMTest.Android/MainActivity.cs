using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Threading.Tasks;

namespace GTMTest.Droid
{
    [Activity(Label = "GTMTest", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());

            LogEvent("ScreenViewed_Testing");

            Task.Run(async () =>
            {
                await Task.Delay(3000);
                LogEvent("ScreenViewed_AnotherTest");
            });
        }

        private void LogEvent(string text)
        {
            var instance = Firebase.Analytics.FirebaseAnalytics.GetInstance(this);// Plugin.CurrentActivity.CrossCurrentActivity.Current.AppContext);
            using (var bundle = new Bundle())
            {
                bundle.PutString("testkey", "testval");

                instance.LogEvent(text, bundle);
            }
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}