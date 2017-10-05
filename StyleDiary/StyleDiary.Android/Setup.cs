using Android.Content;
using MvvmCross.Core.ViewModels;
using MxSync.Forms.Android.Setup;

namespace StyleDiary.Droid
{
    public class Setup : MxFormsAndroidSetup
    {
        public Setup(Context applicationContext) : base(applicationContext, typeof(StyleDiaryApp))
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new StyleDiaryApp();
        }
    }
}