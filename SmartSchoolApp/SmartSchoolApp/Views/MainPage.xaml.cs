using Acr.UserDialogs;
using SmartSchoolApp.Models;
using SmartSchoolApp.Views.Admin;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartSchoolApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public MainPage()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;

            MenuPages.Add((int)MenuItemType.SchoolInfo, (NavigationPage)Detail);

        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)MenuItemType.SchoolInfo:
                        MenuPages.Add(id, new NavigationPage(new HomePage()));
                        break;
                    case (int)MenuItemType.EventCalendar:
                        MenuPages.Add(id, new NavigationPage(new EventCalendarPage()));
                        break;
                    case (int)MenuItemType.Notifications:
                        MenuPages.Add(id, new NavigationPage(new NotificationsPage()));
                        break;
                    case (int)MenuItemType.Logout:
                        Application.Current.MainPage = new LoginPage();
                        UserDialogs.Instance.Toast("You have been logged out successfully");
                        return;
                    case (int)MenuItemType.GroupMessage:
                        MenuPages.Add(id, new NavigationPage(new GroupMessage()));
                        break;

                    case (int)MenuItemType.Gallery:
                        MenuPages.Add(id, new NavigationPage(new GalleryPage()));
                        break;
                    case (int)MenuItemType.ManageGroupMessages:
                        MenuPages.Add(id, new NavigationPage(new ManageGroupMessages()));
                        break;

                }
            }

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
        }
    }
}