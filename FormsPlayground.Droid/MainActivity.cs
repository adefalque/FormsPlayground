using Android.App;
using Android.Widget;
using Android.OS;
using CachedImageCircle.Forms.Plugin.Droid;
using FormsPlayground.Core;
using Xamarin.Forms.Platform.Android;

namespace FormsPlayground.Droid
{
    [Activity(Label = "FormsPlayground.Droid", MainLauncher = true)]
    public class MainActivity : FormsApplicationActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Xamarin.Forms.Forms.Init(this, savedInstanceState);
            ImageCircleRenderer.Init();

            LoadApplication(new App());
        }
    }
}

