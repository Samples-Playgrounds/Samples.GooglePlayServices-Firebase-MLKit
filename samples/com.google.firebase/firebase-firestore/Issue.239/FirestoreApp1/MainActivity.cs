using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Firebase.Firestore;
using Android.Gms.Tasks;
using Java.Lang;
using System;

namespace FirestoreApp1
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity, IOnCompleteListener, IOnFailureListener
    {
        Firebase.FirebaseApp fireApp;
        Firebase.Firestore.FirebaseFirestore fireFirestore;
        Firebase.Database.FirebaseDatabase fireDatabase;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            // Well, just config with your own name app in manifest.xml
            // and yout own "google-services.json" file config from Firebase. that's all.



            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            fireApp = Firebase.FirebaseApp.InitializeApp(this);
            fireFirestore = Firebase.Firestore.FirebaseFirestore.Instance;
            fireDatabase = Firebase.Database.FirebaseDatabase.Instance;

            Button btn1 = FindViewById(Resource.Id.Button1) as Button;
            btn1.Click += delegate
            {
                
                // So here it's crash the App.
                
                DocumentReference docRef = fireFirestore.Collection("collection1").Document("doc1");
                docRef.Get()
                    .AddOnCompleteListener(this)
                    .AddOnFailureListener(this);
            };

        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        public void OnComplete(Task task)
        {
            if (task.IsSuccessful)
            {
                DocumentSnapshot doc = task.Result as DocumentSnapshot;
                if (doc.Exists())
                {
                    Console.WriteLine($"Doc all read OK: {doc.Data}");
                }
            }
        }

        public void OnFailure(Java.Lang.Exception e)
        {
            Console.WriteLine($"Exception reading doc: {e.Message}");
        }
    }
}