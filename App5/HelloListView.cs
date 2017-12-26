using System;

using Android.App;
using Android.OS;
using Android.Widget;
using static Android.Widget.AdapterView;
using Android.Support.V7.App;

namespace App5
{
    [Activity(Label = "HelloListView")]
    public class HelloListView : AppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.HelloListView);

            string[] countries = Resources.GetStringArray(Resource.Array.countries_array);



            ListView listView = FindViewById<ListView>(Resource.Id.list_view);
            listView.Adapter = new ArrayAdapter<string>(this, Resource.Layout.list_item, countries);
            listView.TextFilterEnabled = true;
            listView.ItemClick += delegate (object sender, ItemClickEventArgs args)
            {
                // When clicked, show a toast with the TextView text
                Toast.MakeText(Application, ((TextView)args.View).Text, ToastLength.Short).Show();
            };

        }
    }
}