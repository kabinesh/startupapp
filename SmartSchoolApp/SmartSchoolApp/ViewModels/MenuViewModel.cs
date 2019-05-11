using SmartSchoolApp.Models;
using SmartSchoolApp.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SmartSchoolApp.ViewModels
{
    public class MenuViewModel : BaseViewModel
    {
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }

        public List<HomeMenuItem> MenuItems { get; set; }

        public MenuViewModel()
        {
            SetMenuItems();
        }

        void SetMenuItems()
        {
            MenuItems = new List<HomeMenuItem>
            {
                new HomeMenuItem {Id = MenuItemType.SchoolInfo, Title="Home" },
                new HomeMenuItem {Id= MenuItemType.GroupMessage, Title="Group Message"},
                new HomeMenuItem {Id = MenuItemType.EventCalendar, Title="Event Calendar" },
                new HomeMenuItem {Id = MenuItemType.Notifications,Title="Notifications"},
                new HomeMenuItem {Id = MenuItemType.Logout, Title= "Logout"},
                new HomeMenuItem {Id = MenuItemType.Login, Title="Login"}
            };
        }

        private HomeMenuItem _homeMenuItem;

        public HomeMenuItem SelectedMenuItem
        {

            get
            {
                return _homeMenuItem;
            }
            set
            {
                _homeMenuItem = value;
            }
        }
    }
}
