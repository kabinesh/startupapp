using System;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Acr.UserDialogs;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using SmartSchoolApp.Models;
using SmartSchoolApp.Models.ServiceModels;
using Xamarin.Forms;

namespace SmartSchoolApp.ViewModels
{
    public class AddEditGroupMessageViewModel : ViewModelBase, INotifyPropertyChanged
    {
        private GroupMessage groupMessage;

        public GroupMessage GroupMessage
        {
            get
            {
                return groupMessage;
            }

            set
            {
                groupMessage = value;
                RaisePropertyChanged(nameof(GroupMessage));
            }
        }

        public ICommand SaveMessage { get; set; }

        public AddEditGroupMessageViewModel()
        {
            MessengerInstance.Register<NotificationMessage<GroupMessage>>(this, UpdateGroupMessage);
            SaveMessage = new Command(async () => await SaveGroupMessage());

        }

        private void UpdateGroupMessage(NotificationMessage<GroupMessage> notificationMessage)
        {
            GroupMessage = notificationMessage.Content;
        }

        private async Task SaveGroupMessage()
        {
            try
            {
                GroupMessageResponse groupMessageResponse;
                GroupMessage.AuthToken = "62ssqhyw";

                if (GroupMessage.Id > 0)
                {
                    groupMessageResponse = await App.RestApiService.UpdateGroupMessage(GroupMessage);
                }
                else
                {
                    GroupMessage.DateTime = DateTime.Now;
                    groupMessageResponse = await App.RestApiService.SaveGroupMessage(GroupMessage);
                }

                if (groupMessageResponse.Status == "success")
                {
                    await App.RootPage.PopNavigationPage();
                    MessengerInstance.Send(new NotificationMessage("Update group message list view records"));
                    UserDialogs.Instance.Toast("Message added successfully");
                }

            }
            catch (Exception)
            {

            }
        }

    }
}
