using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FinalExamMobile.Services;
using FinalExamMobile.Views;
using FinalExamMobile.Data;

namespace FinalExamMobile
{
    public partial class App : Application
    {
        private static QuoteDatabase _database;
        public static QuoteDatabase Database => _database ?? (_database = new QuoteDatabase());

        public static QuoteManager QuoteManager { get; set; }
        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            QuoteManager = new QuoteManager(new RestService());

            MainPage = new MainPage();
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
