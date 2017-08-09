using System.Reflection;
using MvvmCross.Platform.IoC;
using MxSync.Forms;

namespace StyleDiary
{
    public class StyleDiaryApp : MxFormsApp
    {
        public override void Initialize()
        {
            base.Initialize();
            CreatableTypes(typeof(StyleDiaryApp).GetTypeInfo().Assembly).EndingWith("Service").AsInterfaces().RegisterAsLazySingleton();
            CreatableTypes(typeof(StyleDiaryApp).GetTypeInfo().Assembly).EndingWith("Repository").AsInterfaces().RegisterAsLazySingleton();

            //RegisterAppStart<DataEntryViewModel>();
        }
    }
}