using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace FCI
{
    [Activity(Label = "SEMATERIALS")]
    public class SEMATERIALS : Activity
    {
        List<TableItem> tableItems;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.sematerials);
            ListView sematerialsss = FindViewById<ListView>(Resource.Id.listView5);

            tableItems = new List<TableItem>();

          

            tableItems.Add(new TableItem("Computer Vision", GetString(Resource.String.COMPUTERVISION), Resource.Drawable.se));

            tableItems.Add(new TableItem("Distributed Database Systems", GetString(Resource.String.DistributedDatabaseSystems), Resource.Drawable.se));          

            tableItems.Add(new TableItem("Embedded Microprocessor Systems Design", GetString(Resource.String.EmbeddedMicroprocessorSystemsDesign), Resource.Drawable.se));

            tableItems.Add(new TableItem("Real time systems", GetString(Resource.String.Realtimesystems), Resource.Drawable.se));

            sematerialsss.Adapter = new HomeScreenAdapter(this, tableItems);
            sematerialsss.ItemClick += OnListItemClick;
        }

        void OnListItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            var listView = sender as ListView;
            var t = tableItems[e.Position];

            if (t.Heading == "Computer Vision")
            {
                var url = Android.Net.Uri.Parse("https://en.wikipedia.org/wiki/Computer_vision");
                var websiteintent = new Intent(Intent.ActionView, url);
                StartActivity(websiteintent);
            }

            if (t.Heading == "Real time systems")
            {
                var url = Android.Net.Uri.Parse("https://en.wikipedia.org/wiki/Real-time_operating_system");
                var websiteintent = new Intent(Intent.ActionView, url);
                StartActivity(websiteintent);
            }
        }

        
    }
}