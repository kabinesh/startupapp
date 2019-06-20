using GalaSoft.MvvmLight;
using SmartSchoolApp.Interface;
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
    public class GroupMessageViewModel : ViewModelBase, INotifyPropertyChanged
    {
        private GroupMessageService groupMessageService;
        private IRestApi restApi;
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
            restApi = App.RestApiService;
            UpdateGroupMessageList();
        }

        public async Task UpdateGroupMessageList()
        {
            try
            {
                var response = await restApi.GetGroupMessages();
                GroupMessages = response.PostDetails;
            }
            catch (Exception e)
            {

            }
        }

        protected void OnPropertyChanged(string property)
        {
            if (PropertyChanged == null)
                return;

            PropertyChanged(this, new PropertyChangedEventArgs(property));
        }
    }
}
