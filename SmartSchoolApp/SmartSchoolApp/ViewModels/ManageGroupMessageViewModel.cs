using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using SmartSchoolApp.Views.Admin;
using SmartSchoolApp.Models;
using Xamarin.Forms;

namespace SmartSchoolApp.ViewModels
{
    public class ManageGroupMessageViewModel : GroupMessageViewModel
    {
        public GroupMessage GroupMessage { get; set; }

        public ICommand NavigateToEditGropMessageView { get; set; }

        public ICommand DeleteGroupMessage { get; set; }

        public ManageGroupMessageViewModel()
        {
            NavigateToEditGropMessageView = new Command<GroupMessage>(async (groupMessage) => await NavigateToEditMessageView(groupMessage));
            DeleteGroupMessage = new Command(DeleteMessage);
        }


        private async Task NavigateToEditMessageView(GroupMessage groupMessage)
        {
            GroupMessage = groupMessage;
            await (Application.Current.MainPage as Views.MainPage).PushNavigationPage(new AddOrEditGroupMessage());
        }

        private void DeleteMessage()
        {

        }
    }
}
