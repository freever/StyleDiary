
using Windows.ApplicationModel.Activation;
using Windows.UI.Xaml.Controls;
using MvvmCross.Core.ViewModels;
using MxSync.Forms.Windows.Setup;

namespace StyleDiary.UWP
{
    public class Setup : MxFormsWindowsSetup
    {

        public Setup(Frame rootFrame, LaunchActivatedEventArgs launchActivatedEventArgs)
            : base(rootFrame, launchActivatedEventArgs, typeof(StyleDiaryApp))
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new StyleDiaryApp();
        }
    }
}