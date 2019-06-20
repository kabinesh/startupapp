using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Acr.UserDialogs;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using SmartSchoolApp.Models;
using SmartSchoolApp.Views.Admin;
using Xamarin.Forms;

namespace SmartSchoolApp.ViewModels
{
    public class ManageGroupMessageViewModel : GroupMessageViewModel
    {
        public GroupMessage GroupMessage { get; set; }

        public ICommand NavigateToEditGropMessageView { get; set; }

        public ICommand NavigateToAddMessageView { get; set; }

        public ICommand DeleteGroupMessage { get; set; }

        public ManageGroupMessageViewModel()
        {
            NavigateToEditGropMessageView = new Command<GroupMessage>(async (groupMessage) => await NavigateToEditMessageView(groupMessage));
            NavigateToAddMessageView = new Command(async () => await NavigateToAddMessageViewPage());
            DeleteGroupMessage = new Command<GroupMessage>(async (gm) => await DeleteMessage(gm));
            MessengerInstance.Register<NotificationMessage>(this, RefreshGroupMessageList);
        }

        private async void RefreshGroupMessageList(NotificationMessage notificationMessage)
        {
            await UpdateGroupMessageList();
        }

        private async Task NavigateToAddMessageViewPage()
        {
            await (Application.Current.MainPage as Views.MainPage).PushNavigationPage(new AddOrEditGroupMessage());

            MessengerInstance.Send(new NotificationMessage<GroupMessage>(new GroupMessage(), "Naviagte to Add View"));
        }

        private async Task NavigateToEditMessageView(GroupMessage groupMessage)
        {
            GroupMessage = groupMessage;
            await (Application.Current.MainPage as Views.MainPage).PushNavigationPage(new AddOrEditGroupMessage());

            MessengerInstance.Send(new NotificationMessage<GroupMessage>(groupMessage, "Naviagte to edit View"));
        }

        private async Task DeleteMessage(GroupMessage groupMessage)
        {
            groupMessage.AuthToken = "62ssqhyw";
            GroupMessages.Remove(groupMessage);
            var response = await App.RestApiService.DeleteGroupMessage(groupMessage);
            if (response.Status == "success")
            {
                UserDialogs.Instance.Toast("Messge deleted sucesfully");
            }
        }
    }
}
