using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TemperatureConverter.Models;
using Xamarin.Forms;

namespace TemperatureConverter.Views
{
    public class FarenheitPage : ContentPage
    {
        Entry Farenheit;
        Button _Convert;

        public FarenheitPage()
        {
            this.Title = "Farenheit to Celsuis Converter";
            StackLayout stack = new StackLayout();
            Farenheit = new Entry();
            Farenheit.Keyboard = Keyboard.Numeric;
            Farenheit.Placeholder = "Enter Temperature";
            stack.Children.Add(Farenheit);
            _Convert = new Button();
            _Convert.Text = "Convert To Celsuis";
            _Convert.Clicked += _Convert_Clicked; ;
            stack.Children.Add(_Convert);
            Content = stack;
        }

        private async void _Convert_Clicked(object sender, EventArgs e)
        {
            Temperature temperature = new Temperature()
            {
                Converter = Convert.ToDecimal(Farenheit.Text)
            };
            await DisplayAlert("Result", $"{(temperature.Converter - 32 ) * 5 / 9}C", "Ok");
        }
    }
}