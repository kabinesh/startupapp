using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SmartSchoolApp.Models.ServiceModels
{
    public class GroupMessageResponse
    {
        public string Status { get; set; }

        public ObservableCollection<GroupMessage> PostDetails { get; set; }
    }
}
