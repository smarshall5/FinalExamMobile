using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FinalExamMobile.Models;

namespace FinalExamMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuoteViewPage : ContentPage
    {
        public QuoteViewPage()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();

            AllQuotes.ItemsSource = await App.Database.GetQuoteAsync();


        }
        private async void onRefreshClicked(object sender, EventArgs e)
        {
            AllQuotes.ItemsSource = await App.Database.GetQuoteAsync();
        }

        }
}