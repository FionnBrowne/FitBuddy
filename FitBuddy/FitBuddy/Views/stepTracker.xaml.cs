using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FitBuddy.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class stepTracker : ContentPage
    {
        public stepTracker()
        {
            InitializeComponent();
        }
        private void btn_clicked(object sender, EventArgs e)
        {
            //all calculations will be made here for steps
            float height;
            float distance;
            float time;

            double stepsTaken;
            double stepsPerMin;
            double avgStrideLength;
            

            //converting input values from xaml page
            height = (float)Convert.ToDecimal(EntryHeight.Text);
            distance = (float)Convert.ToDecimal(EntryDistance.Text);
            time = (float)Convert.ToDecimal(EntryTime.Text);
            //calculations
            avgStrideLength = height * 0.415;
            stepsTaken = distance / (avgStrideLength/100);
            stepsPerMin = stepsTaken / time;
            //output back to screen

            stepsT.Text = stepsTaken.ToString("0.#");
            stepsPM.Text = stepsPerMin.ToString("0.#");
            averageSL.Text = avgStrideLength.ToString("0.# cm");
        }
    }
}