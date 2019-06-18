using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Acr.UserDialogs;
using SmartSchoolApp.Models;
using SmartSchoolApp.Models.ServiceModels;
using Xamarin.Forms;

namespace SmartSchoolApp.ViewModels
{
    public class AddEditGroupMessageViewModel
    {
        public GroupMessage GroupMessage { get; set; }

        public ICommand SaveMessage { get; set; }

        public AddEditGroupMessageViewModel()
        {
            SaveMessage = new Command(async () => await SaveGroupMessage());
        }

        private async Task SaveGroupMessage()
        {
            try
            {
                GroupMessage.DateTime = DateTime.Now;
                GroupMessage.AuthToken = "62ssqhyw";
                var response = await App.RestApiService.SaveGroupMessage(GroupMessage);
                if (response.Status == "success")
                {
                    await App.RootPage.PopNavigationPage();
                    UserDialogs.Instance.Toast("Message added successfully");
                }
            }
            catch (Exception)
            {

            }

        }

    }
}
