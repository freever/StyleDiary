using MxSync.Services.AnalyticsService;
using MxSync.Services.AppConfigService;
using MxSync.Services.DeviceService;
using MxSync.Services.NavigationService;
using MxSync.ViewModels.Base;

namespace StyleDiary.ViewModels
{
    public class ColourPickerViewModel : MxViewModel
    {
        public ColourPickerViewModel(IMxAnalyticsService analayticsService, IMxAppConfigService appConfigService, IMxDeviceService deviceService, IMxNavigationService navigationService) : base(analayticsService, appConfigService, deviceService, navigationService)
        {
        }
    }
}