using System;
using Media;
using Media_Rave.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Media_Rave
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new LoginPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
