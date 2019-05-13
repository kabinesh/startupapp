using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SmartSchoolApp.Views;
using Acr.UserDialogs;
using System.Net.Http;
using SmartSchoolApp.Helpers;
using SmartSchoolApp.Interface;
using SmartSchoolApp.Services;
using GalaSoft.MvvmLight.Ioc;
using DLToolkit.Forms.Controls;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace SmartSchoolApp
{
    public partial class App : Application
    {
        private static readonly string baseUrl = "http://sms.shanehospitalfurniture.com";

        public static IRestApi RestApiService { get; private set; }

        public App()
        {
            InitializeComponent();

            FlowListView.Init();

            SetupService();

            MainPage = new LoginPage();
        }

        public void SetupService()
        {
            var httpClient = new HttpClient(new AuthenticatedHttpClientHandler())
            {
                BaseAddress = new Uri(baseUrl), //Todo need to update api url here.
                Timeout = TimeSpan.FromSeconds(60)
            };

            RestApiService = Refit.RestService.For<IRestApi>(httpClient);

        }

        private static ViewModelLocator _locator;
        public static ViewModelLocator Locator
        {
            get
            {
                return _locator ?? (_locator = new ViewModelLocator());
            }
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
