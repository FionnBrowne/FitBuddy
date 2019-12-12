using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace FitBuddy.ViewModels
{
    public class healthyTipsViewModel : BaseViewModel
    {
        public healthyTipsViewModel()
        {
            Title = "Healthy Tips";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://www.cdc.gov/healthyweight/assessing/bmi/index.html")));
        }

        public ICommand OpenWebCommand { get; }
    }
}