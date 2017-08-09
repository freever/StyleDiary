using MvvmCross.Core.ViewModels;
using MvvmCross.Forms.Core;
using MvvmCross.Platform;

namespace StyleDiary.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();

            var start = Mvx.Resolve<IMvxAppStart>();
            start.Start();

            LoadApplication(MvxFormsApplication.Current);
        }
    }
}
