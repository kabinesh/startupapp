using Newtonsoft.Json;
using SmartSchoolApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SmartSchoolApp.Services
{
    public class GroupMessageService
    {
        private string baseUrl = "http://sms.shanehospitalfurniture.com";
        private HttpClient httpClient;
        private string authToken;

        public GroupMessageService()
        {
            httpClient = new HttpClient();
            authToken = "co6m1mo3";
        }

        public async Task<ObservableCollection<GroupMessage>> GetGroupMessages()
        {
            var objectDefnition = new { Status ="", PostDetails = new List<GroupMessage>() };
            var content = await httpClient.GetStringAsync(baseUrl + "/post/get?AuthToken=" + authToken);
            var data = JsonConvert.DeserializeAnonymousType(content, objectDefnition);
    
           
            ObservableCollection<GroupMessage> groupMessages = new ObservableCollection<GroupMessage>(data.PostDetails);
            return groupMessages;
        }
    }
}
