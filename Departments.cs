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
using Android.Media;

namespace FCI
{
    [Activity(Label = "Departments")]
    public class Departments : Activity
    {
        List<TableItem> tableItems;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.departments);
            ListView listdeparts = FindViewById<ListView>(Resource.Id.listView1);


           tableItems = new List<TableItem>();

            tableItems.Add(new TableItem("COMPUTER CSIENCE", GetString(Resource.String.CSDEPARTMENT), Resource.Drawable.cs));

           

            tableItems.Add(new TableItem("INFORMATION SYSTEM", GetString(Resource.String.ISDEPARTMENTDEFDEF), Resource.Drawable.database));

            tableItems.Add(new TableItem("SOFTWARE ENGINEERING", GetString(Resource.String.SEDEPARTMENTDEFDEF), Resource.Drawable.se));

            tableItems.Add(new TableItem("INFORMATION TECHNOLOGY", GetString(Resource.String.ITDEPARTMENTDEF), Resource.Drawable.it));

            listdeparts.Adapter = new HomeScreenAdapter(this, tableItems);
            listdeparts.ItemClick += OnListItemClick;
        }
        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.second_menu, menu);
            return base.OnCreateOptionsMenu(menu);
        }
        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {

                case Resource.Id.website:
                    Intent website = new Intent(this, typeof(Websitecollege));
                    StartActivity(website);
                    OverridePendingTransition(Resource.Animation.SlideIintop, Resource.Animation.Slideoutbottom);
                    break;

                case Resource.Id.location:
                    var url2 = Android.Net.Uri.Parse("geo:33.441375,44.226514");
                    var locationintent = new Intent(Intent.ActionView, url2);
                    StartActivity(locationintent);                   
                    break;





            }
            return base.OnOptionsItemSelected(item);
        }
        
        void OnListItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            var listView = sender as ListView;
            var t = tableItems[e.Position];

            if (t.Heading== "COMPUTER CSIENCE")
            {
                Intent csactivity = new Intent(this, typeof(CSMATERIAL));
                StartActivity(csactivity);
                OverridePendingTransition(Resource.Animation.SlideIintop, Resource.Animation.Slideoutbottom);
                MediaPlayer COMPUTERCSIENCEMEDIA = MediaPlayer.Create(this, Resource.Raw.CS);
                COMPUTERCSIENCEMEDIA.Start();

            }

            if (t.Heading == "INFORMATION TECHNOLOGY")
            {
                Intent csactivity = new Intent(this, typeof(IFMATERIALS));
                StartActivity(csactivity);
                OverridePendingTransition(Resource.Animation.SlideIintop, Resource.Animation.Slideoutbottom);
                MediaPlayer COMPUTERCSIENCEMEDIA = MediaPlayer.Create(this, Resource.Raw.it);
                COMPUTERCSIENCEMEDIA.Start();
            }

            if (t.Heading == "SOFTWARE ENGINEERING")
            {
                Intent csactivity = new Intent(this, typeof(SEMATERIALS));
                StartActivity(csactivity);
                OverridePendingTransition(Resource.Animation.SlideIintop, Resource.Animation.Slideoutbottom);
                MediaPlayer COMPUTERCSIENCEMEDIA = MediaPlayer.Create(this, Resource.Raw.se);
                COMPUTERCSIENCEMEDIA.Start();
            }

            if (t.Heading == "INFORMATION SYSTEM")
            {
                Intent csactivity = new Intent(this, typeof(ISMATERIAL));
                StartActivity(csactivity);
                OverridePendingTransition(Resource.Animation.SlideIintop, Resource.Animation.Slideoutbottom);
                MediaPlayer COMPUTERCSIENCEMEDIA = MediaPlayer.Create(this, Resource.Raw.Is);
                COMPUTERCSIENCEMEDIA.Start();
            }
        }


    }
}