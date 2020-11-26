using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TemperatureConverter.Models;
using Xamarin.Forms;

namespace TemperatureConverter.Views
{
    public class LinearEquationPage : ContentPage
    {
        Entry _first;
        Entry _second;
        Entry _third;
        Button _solve;
        public LinearEquationPage()
        {
            this.Title = "Linear Equation Solver (ax^2 + b = c)";
            StackLayout stack = new StackLayout();
            //First Input
            _first = new Entry();
            _first.Keyboard = Keyboard.Default;
            _first.Placeholder = "Enter First Coeficient";
            stack.Children.Add(_first);
            //Second  Input
            _second = new Entry();
            _second.Keyboard = Keyboard.Default;
            _second.Placeholder = "Enter Second Coeficient";
            stack.Children.Add(_second);
            //Third Input
            _third = new Entry();
            _third.Keyboard = Keyboard.Default;
            _third.Placeholder = "Enter Third Coeficient";
            stack.Children.Add(_third);
            //Solve Button
            _solve = new Button();
            _solve.Text = "Solve";
            _solve.Clicked += _solve_Clicked;
            stack.Children.Add(_solve);
            Content = stack;
        }

        private async void _solve_Clicked(object sender, EventArgs e)
        {
            LinearEquation linearEquation = new LinearEquation()
            {
                a = Convert.ToInt32(_first.Text),
                b = Convert.ToInt32(_second.Text),
                c = Convert.ToInt32(_third.Text)
            };
            int x = (linearEquation.c - linearEquation.b) / linearEquation.a;
            int b = (linearEquation.c + linearEquation.b) / linearEquation.a;
            await DisplayAlert("Answer", $"{linearEquation.a}x + {linearEquation.b} = {x} \n{linearEquation.a}x - {linearEquation.b} = {b} \nx1 = {x} \nx2 = {b}", "Ok");

        }
    }
}