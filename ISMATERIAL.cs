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
    [Activity(Label = "ISMATERIAL")]
    public class ISMATERIAL : Activity
    {
        List<TableItem> tableItems;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.ismaterial);
            ListView isdeparmtss = FindViewById<ListView>(Resource.Id.listView3);

            tableItems = new List<TableItem>();

            tableItems.Add(new TableItem("Management Information Systems", GetString(Resource.String.ManagemenInformationSystems), Resource.Drawable.database));

            tableItems.Add(new TableItem("Economics for S/W Development", GetString(Resource.String.EconomicsforWDevelopment), Resource.Drawable.database));

            tableItems.Add(new TableItem("Information Engineer", GetString(Resource.String.InformationEngineer), Resource.Drawable.database));

            tableItems.Add(new TableItem("Electronic Commerce", GetString(Resource.String.ElectroniCommerce), Resource.Drawable.database));

            tableItems.Add(new TableItem("Library Automation ", GetString(Resource.String.LibraryAutomation), Resource.Drawable.database));

            tableItems.Add(new TableItem("Electronic Commerce", GetString(Resource.String.ElectroniCommerce), Resource.Drawable.database));

            tableItems.Add(new TableItem("Distributed Database Systems", GetString(Resource.String.DistributedDatabaseSystems), Resource.Drawable.database));

            isdeparmtss.Adapter = new HomeScreenAdapter(this, tableItems);
            isdeparmtss.ItemClick += OnListItemClick;
        }

        void OnListItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            var listView = sender as ListView;
            var t = tableItems[e.Position];

            if (t.Heading == "ARTIFITIAL")
            {
                var url = Android.Net.Uri.Parse("https://developer.xamarin.com");
                var websiteintent = new Intent(Intent.ActionView, url);
                StartActivity(websiteintent);
            }

            if (t.Heading == "OPERATING SYSTEM")
            {
                var url = Android.Net.Uri.Parse("https://developer.xamarin.com");
                var websiteintent = new Intent(Intent.ActionView, url);
                StartActivity(websiteintent);
            }
        }

       
    }
}