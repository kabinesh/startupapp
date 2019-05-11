using System;
using System.Collections.Generic;
using System.Text;

namespace SmartSchoolApp.Models
{
    public enum MenuItemType
    {
        SchoolInfo,
        Notifications,
        EventCalendar,
        Logout,
        Login,
        GroupMessage
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
