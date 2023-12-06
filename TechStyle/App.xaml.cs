using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
namespace TechStyle
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Device.SetFlags(new string[] { "RadioButton_Experimental" });
            MainPage = new NavigationPage(new MainPage());
        }
    }
}
