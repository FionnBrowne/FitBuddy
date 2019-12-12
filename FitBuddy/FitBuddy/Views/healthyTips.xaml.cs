using System;
using System.Windows.Input;

using System.Collections.Generic;  
using System.Linq;  
using System.Text;  
using System.Threading.Tasks; 
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FitBuddy.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class healthyTips: ContentPage
    {
        public healthyTips()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
           // var Url = "https://www.c-sharpcorner.com/members/ajith-kumar51";
           // Browser.Source = Url;
        }
    }

}