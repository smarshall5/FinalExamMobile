using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalExamMobile.Data;
using FinalExamMobile.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FinalExamMobile.Data;
using FinalExamMobile.Models;

namespace FinalExamMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuoteFinderPage : ContentPage
    {
        
        public QuoteFinderPage()
        {
            InitializeComponent();
            RestService rest = new RestService();
            var data = rest.RefreshDataAsync();
            
        }

    }
}