﻿using MvvmCross.Core.ViewModels;
using MvvmCross.iOS.Platform;
using MvvmCross.Platform;
using MxSync.Forms.iOS.Setup;
using MxSync.Services.IocService;
using UIKit;

namespace StyleDiary.iOS
{
    public class Setup : MxFormsIosSetup
    {
        public Setup(MvxApplicationDelegate applicationDelegate, UIWindow window) : base(applicationDelegate, window, typeof(StyleDiaryApp))
        {
        }

        protected override IMvxApplication CreateApp()
        {
            Mvx.RegisterSingleton<IMxIocService>(new MxIocService());
            return new StyleDiaryApp();
        }
    }
}