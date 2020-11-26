using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TemperatureConverter.Models;
using Xamarin.Forms;

namespace TemperatureConverter.Views
{
    public class CelsuisPage : ContentPage
    {
        Entry _Celsuis;
        Button _Convert;
        public CelsuisPage()
        {
            this.Title = "Celsuis to Farenheit Converter";
            StackLayout stack = new StackLayout();
            _Celsuis = new Entry();
            _Celsuis.Keyboard = Keyboard.Numeric;
            _Celsuis.Placeholder = "Enter Temperature";
            stack.Children.Add(_Celsuis);
            _Convert = new Button();
            _Convert.Text = "Convert To Farenheit";
            _Convert.Clicked += _Convert_Clicked;
            stack.Children.Add(_Convert);
            Content = stack;
        }

        private async void _Convert_Clicked(object sender, EventArgs e)
        {
            Temperature temperature = new Temperature()
            {
                Converter = Convert.ToDecimal(_Celsuis.Text)
            };
            await DisplayAlert("Result", $"{(temperature.Converter * 9/5) + 32}F", "Ok");
        }
    }
}