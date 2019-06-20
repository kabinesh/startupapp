using Refit;
using SmartSchoolApp.Models;
using SmartSchoolApp.Models.ServiceModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace SmartSchoolApp.Interface
{
    [Headers("Content-Type", "application/json")]
    public interface IRestApi
    {
        [Get("/GetEvents")]
        Task<Event> GetAllEvents();

        [Post("/user/login")]
        Task<LoginResponse> Login([Body] User user);

        [Get("/post/get?AuthToken=62ssqhyw")]
        Task<GroupMessageResponse> GetGroupMessages();

        [Post("/post/add")]
        Task<GroupMessageResponse> SaveGroupMessage([Body] GroupMessage groupMessage);

        [Post("/post/edit")]
        Task<GroupMessageResponse> UpdateGroupMessage([Body] GroupMessage groupMessage);

        [Post("/post/delete")]
        Task<GroupMessageResponse> DeleteGroupMessage([Body] GroupMessage groupMessage);

        [Get("/gallery/get?AuthToken=dj3ku5rn")]
        Task<EventsGalleryResponse> GetEventsGallery();

    }
}
