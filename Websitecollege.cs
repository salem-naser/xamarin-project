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
using Android.Webkit;

namespace FCI
{
    [Activity(Label = "Websitecollege")]
    public class Websitecollege : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.websitecollege);
            WebView colegewebsite = FindViewById<WebView>(Resource.Id.webView1);
            colegewebsite.Settings.JavaScriptEnabled = true;
            colegewebsite.LoadUrl("http://csifac.mans.edu.eg/");
            colegewebsite.Settings.LoadWithOverviewMode = true;
            colegewebsite.SetWebViewClient(new HelloWebViewClient());
        }


        public class HelloWebViewClient : WebViewClient
        {
            public override bool ShouldOverrideUrlLoading(WebView view, string url)
            {
                view.LoadUrl(url);
                return true;
            }          
        }
    }
}