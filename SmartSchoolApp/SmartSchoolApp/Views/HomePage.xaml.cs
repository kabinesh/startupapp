using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using SmartSchoolApp.Models;
using SmartSchoolApp.Views;
using SmartSchoolApp.ViewModels;

namespace SmartSchoolApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        ItemsViewModel viewModel;

        public HomePage()
        {
            InitializeComponent();

            BindingContext =new HomeViewModel();
        }

       
    }
}