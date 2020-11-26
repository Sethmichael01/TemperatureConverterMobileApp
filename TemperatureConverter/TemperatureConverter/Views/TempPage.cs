using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace TemperatureConverter.Views
{
    public class TempPage : ContentPage
    {
        public TempPage()
        {
            BackgroundColor = Color.Blue;
            this.Title = "Temperature Converter";
            StackLayout stack = new StackLayout();
            //Celsuis Button
            Button celsuis = new Button();
            celsuis.Text = "Convert Celsuis Temperature to Farenheit";
            celsuis.Clicked += Celsuis_Clicked;
            stack.Children.Add(celsuis);
            //farenheit Button
            Button farenheit = new Button();
            farenheit.Text = "Convert Farenheit Temperature to Celsuis";
            farenheit.Clicked += Farenheit_Clicked;
            stack.Children.Add(farenheit);
            //Linear Equation
            Button eqn = new Button();
            eqn.Text = "Linear Equation Solver";
            eqn.Clicked += Eqn_Clicked;
            stack.Children.Add(eqn);
            Content = stack;
        }

        private async void Eqn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LinearEquationPage());
        }

        private async void Farenheit_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FarenheitPage());
        }

        private async void Celsuis_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CelsuisPage());
        }
    }
}