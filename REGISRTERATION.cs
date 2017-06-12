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
    [Activity(Label = "REGISRTERATION")]
    public class REGISRTERATION : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Registeration);
            WebView rege= FindViewById<WebView>(Resource.Id.webView2);
            rege.Settings.JavaScriptEnabled = true;
            rege.LoadUrl("file:///android_asset/index.html");
            rege.Settings.LoadWithOverviewMode = true;
            rege.SetWebViewClient(new HelloWebViewClient());
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