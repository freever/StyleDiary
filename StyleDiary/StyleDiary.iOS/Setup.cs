using MvvmCross.Core.ViewModels;
using MvvmCross.iOS.Platform;
using MxSync.Forms.iOS.Setup;
using UIKit;

namespace StyleDiary.iOS
{
    public class Setup : MxFormsIosSetup
    {
        public Setup(MvxApplicationDelegate applicationDelegate, UIWindow window) : base(applicationDelegate, window)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new StyleDiaryApp();
        }
    }
}