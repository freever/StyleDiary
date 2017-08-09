using MxSync.Forms.Pages;
using StyleDiary.ViewModels;
using Xamarin.Forms;

namespace StyleDiary.Pages
{
    public class ColourPickerPage : MxContentPage<ColourPickerViewModel>
    {
        public ColourPickerPage()
        {
            Content = new StackLayout
            {
                Children =
                {
                    new Label{Text = "Pick a colour!"}
                }
            };
        }
    }
}