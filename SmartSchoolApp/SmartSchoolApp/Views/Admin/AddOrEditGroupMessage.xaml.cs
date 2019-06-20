using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartSchoolApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartSchoolApp.Views.Admin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddOrEditGroupMessage : ContentPage
    {
        public AddOrEditGroupMessage()
        {
            InitializeComponent();

            BindingContext = App.Locator.AddEditGroupMessage;
        }
    }
}