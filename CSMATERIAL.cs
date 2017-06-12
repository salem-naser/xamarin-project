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
    [Activity(Label = "CSMATERIAL")]
    public class CSMATERIAL : Activity
    {
        List<TableItem> tableItems;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.csmaterial);
            ListView listcsmaterial = FindViewById<ListView>(Resource.Id.listView2);

            tableItems = new List<TableItem>();

            tableItems.Add(new TableItem("Artificial Intelligence", GetString(Resource.String.artificialintel), Resource.Drawable.cs));

            tableItems.Add(new TableItem("Operating System", GetString(Resource.String.OPERATINGSYSTEM), Resource.Drawable.cs));

            tableItems.Add(new TableItem("Image Processing", GetString(Resource.String.IMAGEPROCESSING), Resource.Drawable.cs));
            tableItems.Add(new TableItem("Computer Networks", GetString(Resource.String.COMPUTERNETWORKS), Resource.Drawable.cs));

            tableItems.Add(new TableItem("Computer Vision", GetString(Resource.String.COMPUTERVISION), Resource.Drawable.cs));

            tableItems.Add(new TableItem("Natural Language Processing", GetString(Resource.String.NATURALLANGUEPROCESSING), Resource.Drawable.cs));

            tableItems.Add(new TableItem("Neural Networks", GetString(Resource.String.NEURALNETWORK), Resource.Drawable.se));

            tableItems.Add(new TableItem("Distributed Computing", GetString(Resource.String.DISTRIBUTEDCOMPUTING), Resource.Drawable.cs));

            listcsmaterial.Adapter = new HomeScreenAdapter(this, tableItems);
            listcsmaterial.ItemClick += OnListItemClick;


        }
        void OnListItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            var listView = sender as ListView;
            var t = tableItems[e.Position];

            if (t.Heading == "Artificial Intelligence")
            {
                var url = Android.Net.Uri.Parse("https://en.wikipedia.org/wiki/Artificial_intelligence");
                var websiteintent = new Intent(Intent.ActionView, url);
                StartActivity(websiteintent);
            }

            if (t.Heading == "Operating System")
            {
                var url = Android.Net.Uri.Parse("https://en.wikipedia.org/wiki/Operating_system");
                var websiteintent = new Intent(Intent.ActionView, url);
                StartActivity(websiteintent);
            }
        }
            
    }
}