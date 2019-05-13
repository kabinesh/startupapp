using SmartSchoolApp.Models;
using SmartSchoolApp.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;

namespace SmartSchoolApp.ViewModels
{
    public class GroupMessageViewModel : INotifyPropertyChanged
    {
        private GroupMessageService groupMessageService;
        private ObservableCollection<GroupMessage> groupMessages;

        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<GroupMessage> GroupMessages
        {
            get
            {
                return groupMessages;
            }
            set
            {
                groupMessages = value;
                OnPropertyChanged(nameof(GroupMessages));
            }
        }


        public GroupMessageViewModel()
        {
            groupMessageService = new GroupMessageService();
            GetGroupMessages();
        }

        private async Task GetGroupMessages()
        {
            GroupMessages = await groupMessageService.GetGroupMessages();
        }

        protected void OnPropertyChanged(string property)
        {
            if (PropertyChanged == null)
                return;

            PropertyChanged(this, new PropertyChangedEventArgs(property));
        }
    }
}
