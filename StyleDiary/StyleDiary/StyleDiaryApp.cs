using System;
using System.Reflection;
using MvvmCross.Platform.IoC;
using MxSync.Forms;
using StyleDiary.ViewModels;

namespace StyleDiary
{
    public class StyleDiaryApp : MxFormsApp
    {
        public override void Initialize()
        {
            try
            {
                base.Initialize();
            }
            catch (Exception e)
            {
                
            }
            CreatableTypes(typeof(StyleDiaryApp).GetTypeInfo().Assembly).EndingWith("Service").AsInterfaces().RegisterAsLazySingleton();
            CreatableTypes(typeof(StyleDiaryApp).GetTypeInfo().Assembly).EndingWith("Repository").AsInterfaces().RegisterAsLazySingleton();

            RegisterAppStart<ColourPickerViewModel>();
        }
    }
}