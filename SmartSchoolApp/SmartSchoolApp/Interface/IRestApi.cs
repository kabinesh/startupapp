using Refit;
using SmartSchoolApp.Models;
using SmartSchoolApp.Models.ServiceModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SmartSchoolApp.Interface
{
    [Headers("Content-Type","application/json")]
    public interface IRestApi
    {
        [Get("/GetEvents")]
        Task<Event> GetAllEvents();

        [Get("/user/login")]
        Task<LoginResponse> Login(User user);
    }
}
