using MxSync.Forms.Pages;
using StyleDiary.ViewModels;
using Xamarin.Forms;

namespace StyleDiary.Pages
{
    public class ColourPickerPage : MxContentPage<ColourPickerViewModel>
    {
        private double _red;
        private double _green;
        private double _blue;

        public ColourPickerPage()
        {
            
            Slider redSlider = new Slider(0, 255, 100);
            redSlider.ValueChanged += (sender, args) =>
            {
                _red = args.NewValue / 255;
                BackgroundColor = new Color(_red, _green, _blue);
            };

            var greenSlider = new Slider(0, 255, 150);
            greenSlider.ValueChanged += (sender, args) =>
            {
                _green = args.NewValue / 255;
                BackgroundColor = new Color(_red, _green, _blue);
            };

            var blueSlider = new Slider(0, 255, 200);
            blueSlider.ValueChanged += (sender, args) =>
            {
                _blue = args.NewValue / 255;
                BackgroundColor = new Color(_red, _green, _blue);
            };

            Content = new StackLayout
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand,

                Children =
                {

                    new Label { Text = "RED" },
                    redSlider,
                    new Label { Text = "_________________________________" },

                    new Label { Text = "GREEN" },
                    greenSlider,
                    new Label { Text = "_________________________________" },

                    new Label { Text = "BLUE" },
                    blueSlider
                    
                }
            };
        }
    }
}