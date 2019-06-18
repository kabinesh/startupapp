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
            authToken = "qg6vbl5y";
        }

        public async Task<ObservableCollection<GroupMessage>> GetGroupMessages()
        {
            try
            {
                var responseData = new { Status = "", PostDetails = new List<GroupMessage>() };

                var content = await httpClient.GetStringAsync(baseUrl + "/post/get?AuthToken=" + authToken);
                var data = JsonConvert.DeserializeAnonymousType(content, responseData);
                if (data.Status == "success")
                {
                    ObservableCollection<GroupMessage> groupMessages = new ObservableCollection<GroupMessage>(data.PostDetails);

                    return groupMessages;
                }

                return null;
            }
            catch (Exception)
            {
                return null;
            }


        }
    }
}
