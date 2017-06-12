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
    [Activity(Label = "IFMATERIALS")]
    public class IFMATERIALS : Activity
    {
        List<TableItem> tableItems;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.informationtechnology);
            ListView itmaterials = FindViewById<ListView>(Resource.Id.listView4);

            tableItems = new List<TableItem>();

            tableItems.Add(new TableItem("Artificial Intelligence", GetString(Resource.String.artificialintel), Resource.Drawable.it));

            tableItems.Add(new TableItem("OPERATING SYSTEM", GetString(Resource.String.OPERATINGSYSTEM), Resource.Drawable.it));

            tableItems.Add(new TableItem("Computer Networks", GetString(Resource.String.COMPUTERNETWORKS), Resource.Drawable.it));
            tableItems.Add(new TableItem("Computer Vision", GetString(Resource.String.ComputerVision), Resource.Drawable.it));

            itmaterials.Adapter = new HomeScreenAdapter(this, tableItems);
            itmaterials.ItemClick += OnListItemClick;
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