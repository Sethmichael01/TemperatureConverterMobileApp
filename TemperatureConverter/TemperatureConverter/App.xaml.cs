using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TemperatureConverter.Services;
using TemperatureConverter.Views;

namespace TemperatureConverter
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new TempPage())
            {
                BarBackgroundColor = Color.Black,
                BarTextColor = Color.White
            };
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
