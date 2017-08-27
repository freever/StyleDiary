using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using MxSync.Enums;
using MxSync.Forms.Services;
using StyleDiary.ViewModels;

namespace StyleDiary
{
    public class StyleDiaryAppStart : IMvxAppStart
    {
        public void Start(object hint = null)
        {

            var navigationService = Mvx.Resolve<IMxFormsNavigationService>();
            ((MxFormsNavigationService)navigationService).ShowView(typeof(ColourPickerViewModel), MxViewFrame.None);
        }
    }
}