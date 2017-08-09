using Android.App;
using Android.Content.PM;
using Android.OS;
using MxSync.Forms.Android;

namespace StyleDiary.Droid
{
    [Activity(Label = "StyleDiary", MainLauncher = true, NoHistory = true, ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashScreen : MxSplashScreenActivity<MainActivity>
    {
        public SplashScreen() : base(Resource.Layout.SplashScreen)
        { }

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            Xamarin.Forms.Forms.Init(this, bundle);
        }
    }
}