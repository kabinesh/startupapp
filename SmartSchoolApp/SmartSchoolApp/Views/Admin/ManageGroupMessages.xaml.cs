using SmartSchoolApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartSchoolApp.Views.Admin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ManageGroupMessages : ContentPage
    {
        public ManageGroupMessages()
        {
            InitializeComponent();

            BindingContext = App.Locator.ManageGroupMessage;
        }

        private async void NavigateToAddGropMessageView(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddOrEditGroupMessage());
        }

        private async void NavigateToEditGropMessageView(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddOrEditGroupMessage());
            var message = (sender as MenuItem).CommandParameter as GroupMessage;
        }

        private void DeleteGroupMessage(object sender, EventArgs e)
        {
            var message = (sender as MenuItem).CommandParameter as Models.GroupMessage;
            (BindingContext as ManageGroupMessageViewModel).GroupMessages.Remove(message);
        }
    }
}