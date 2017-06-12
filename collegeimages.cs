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
using Android.Support.V4.View;
using Android.Support.V7.App;

namespace FCI
{
    [Activity(Label = "collegeimages", Theme = "@style/MyTheme")]
    public class collegeimages : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.images);
            ViewPager viewpager1 = FindViewById<ViewPager>(Resource.Id.viewPager);
            ImageAdapter adapter = new ImageAdapter(this);
            viewpager1.Adapter = adapter;

        }
    }
}