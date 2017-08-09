using Android.App;
using Android.OS;
using MvvmCross.Core.ViewModels;
using MvvmCross.Forms.Core;
using MvvmCross.Platform;
using MxSync.Forms.Android;

namespace StyleDiary.Droid
{
    [Activity]
    public class MainActivity : MxFormsMainActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            var app = new MvxFormsApplication();
            LoadApplication(app);

            Mvx.Resolve<IMvxAppStart>().Start();
        }
    }
}

