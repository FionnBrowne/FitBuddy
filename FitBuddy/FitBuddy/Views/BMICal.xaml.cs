using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FitBuddy.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BMICal : ContentPage
    {
        public BMICal()
        {
            InitializeComponent();
        }
        private void btn_clicked(object sender, EventArgs e)
        {
            float height;
            float weight;
            

            //converting input values from xaml page
            height = (float)Convert.ToDecimal(EntryHeight.Text);
            weight = (float)Convert.ToDecimal(EntryWeight.Text);

            float bmi = weight / ((height/100) * (height/100)); 
            BMI.Text = bmi.ToString("0.# Kgs/m*2");

            if (bmi<18.5)
            {
                position.Text= "You are underweight" ;
            }
            else if(bmi>=24.9 && bmi<=18.5)
            {
                position.Text = "You are at a healthy weight";
            }
            else if (bmi >= 25 && bmi <= 29.9)
            {
                position.Text = "You are are slightly over weight";
            }
            else if (bmi >= 30 && bmi <= 34.9)
            {
                position.Text = "You are are slightly obese" ;
            }
            else if (bmi >= 35 && bmi <= 39.9)
            {
                position.Text = "You are are moderetly obese" ;
            }
            else if(bmi >= 40)
            {
                position.Text = "You are are severly obese";
            }


        }
    }
}