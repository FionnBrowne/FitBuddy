using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace FitBuddy.ViewModels
{
    public class stepTrackerViewModel : BaseViewModel
    {
        public stepTrackerViewModel()
        {
            //Title = "Step tracker";

           // OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://xamarin.com/platform")));
        }

        public ICommand OpenWebCommand { get; }
    }
}