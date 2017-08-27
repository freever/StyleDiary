using System;
using System.Reflection;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.IoC;
using MxSync;
using MxSync.Forms;
using StyleDiary.ViewModels;

namespace StyleDiary
{
    public class StyleDiaryApp : MxApp
    {
        public override void Initialize()
        {
            base.Initialize();

            CreatableTypes(typeof(StyleDiaryApp).GetTypeInfo().Assembly).EndingWith("Service").AsInterfaces().RegisterAsLazySingleton();
            CreatableTypes(typeof(StyleDiaryApp).GetTypeInfo().Assembly).EndingWith("Repository").AsInterfaces().RegisterAsLazySingleton();

            RegisterAppStart<ColourPickerViewModel>();
        }

        public StyleDiaryApp() : base(new StyleDiaryAppStart())
        {
        }
    }
}