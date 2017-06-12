using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;
using Android.Views;


namespace FCI
{
    [Activity(Label = "FCI", MainLauncher = true, Icon = "@drawable/fciimage")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
             SetContentView (Resource.Layout.Main);
            Button nextpage = FindViewById<Button>(Resource.Id.button1);
            ImageView collgeimage = FindViewById<ImageView>(Resource.Id.imageView1);
            TextView collegename = FindViewById<TextView>(Resource.Id.textView1);
            Button REGISTE = FindViewById<Button>(Resource.Id.REGESTUDENT);
            
            nextpage.Click += delegate {

                Intent departs = new Intent(this, typeof(Departments));
                StartActivity(departs);
                OverridePendingTransition(Android.Resource.Animation.SlideInLeft, Android.Resource.Animation.SlideOutRight);

            };
            REGISTE.Click += REGISTE_Click;
            collgeimage.Click += Collgeimage_Click;
        }

        private void Collgeimage_Click(object sender, System.EventArgs e)
        {
            Intent collimagess = new Intent(this, typeof(collegeimages));
            StartActivity(collimagess);
            OverridePendingTransition(Resource.Animation.SlideIintop, Resource.Animation.Slideoutbottom);
        }

        private void REGISTE_Click(object sender, System.EventArgs e)
        {
            Intent gergis = new Intent(this, typeof(REGISRTERATION));
            StartActivity(gergis);
            OverridePendingTransition(Android.Resource.Animation.SlideInLeft, Android.Resource.Animation.SlideOutRight);
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.main_menu, menu);
            return base.OnCreateOptionsMenu(menu);
        }
        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Resource.Id.departmentsicon:

                    Intent dep = new Intent(this, typeof(Departments));
                    StartActivity(dep);
                    OverridePendingTransition(Resource.Animation.SlideIintop, Resource.Animation.Slideoutbottom);
                    break;


                case Resource.Id.departmentsmenu:
                    Intent dep2 = new Intent(this, typeof(Departments));
                    StartActivity(dep2);
                    OverridePendingTransition(Resource.Animation.SlideIintop, Resource.Animation.Slideoutbottom);
                    break;


                case Resource.Id.website:
                    //var url = Android.Net.Uri.Parse("http://csifac.mans.edu.eg/");
                    // var websiteintent = new Intent(Intent.ActionView, url);
                    // StartActivity(websiteintent);

                    Intent website = new Intent(this, typeof(Websitecollege));
                    StartActivity(website);
                    OverridePendingTransition(Resource.Animation.SlideIintop, Resource.Animation.Slideoutbottom);
                    break;

                case Resource.Id.location:
                    var url2 = Android.Net.Uri.Parse("geo:31.042258, 31.351897");
                    var locationintent = new Intent(Intent.ActionView, url2);
                    StartActivity(locationintent);
                    break;
                case Resource.Id.images:
                    Intent collimages = new Intent(this, typeof(collegeimages));
                    StartActivity(collimages);
                    OverridePendingTransition(Resource.Animation.SlideIintop, Resource.Animation.Slideoutbottom);

                    break;
            }
            return base.OnOptionsItemSelected(item);
        }
    }
}

