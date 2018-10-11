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

            // Register our Services
            DependencyService.Register<ITVSeriesAPIService, TVSeriesAPIService>();

            // The root page of your application
            MainPage = new NavigationPage(new FirstView());
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
