using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamFormsTVSeries.Services;
using XamFormsTVSeries.Views;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace XamFormsTVSeries
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // TODO: AC. Register TVShow Service in DependencyService

            // TODO: AD. Set the MainPage un nuevo NavigationPage que vaya al FirstView
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
