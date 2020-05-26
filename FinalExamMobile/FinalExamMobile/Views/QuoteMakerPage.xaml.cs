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
    public partial class QuoteMakerPage : ContentPage
    {
        
        public QuoteMakerPage()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();

            ListView.ItemsSource = await App.Database.GetQuoteAsync();
        }

        private async void OnSaveClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NewQuote.Text)) return;
            if (string.IsNullOrEmpty(NewAuthor.Text)) return;
            var fullQuote = new Quote
            {
                quote = NewQuote.Text,
                author = NewAuthor.Text,
                category = NewCategory.Text,
                imageURL = NewImage.Text


            };
            await App.Database.SaveQuoteAsync(fullQuote);

            ListView.ItemsSource = await App.Database.GetQuoteAsync();
        }
    }
}