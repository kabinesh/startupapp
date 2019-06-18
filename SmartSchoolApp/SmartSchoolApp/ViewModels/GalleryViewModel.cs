using Rg.Plugins.Popup.Services;
using SmartSchoolApp.Models;
using SmartSchoolApp.Views;
using SmartSchoolApp.Views.Popup;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace SmartSchoolApp.ViewModels
{
    public class GalleryViewModel : BaseViewModel
    {
        INavigation _navigation;
        public GalleryViewModel(INavigation navigation)
        {
            _navigation= navigation;

            EventsGallery = new ObservableCollection<Event>
            {
                new Event{ Id =1 , Name="Playing", Date="11 Mar 2019", ImageCount=1, Photo="image1.jpg", Description="Visit to Kuttralam - with all the students and parents" },
                new Event{ Id =2 , Name="Writing", Date="11 Mar 2019", ImageCount=2, Photo="image2.jpg", Description="Visit to Kuttralam - with all the students and parents"},
                new Event{ Id =1 , Name="Playing", Date="11 Mar 2019", ImageCount=3, Photo="image3.jpg", Description="Visit to Kuttralam - with all the students and parents"},
                new Event{ Id =2 , Name="Writing", Date="11 Mar 2019", ImageCount=4, Photo="image4.jpg", Description="Visit to Kuttralam - with all the students and parents"},
                new Event{ Id =1 , Name="Playing", Date="11 Mar 2019", ImageCount=5, Photo="image5.jpg", Description="Visit to Kuttralam - with all the students and parents"},
                new Event{ Id =2 , Name="Writing", Date="11 Mar 2019", ImageCount=1, Photo="image2.jpg", Description="Visit to Kuttralam - with all the students and parents"},
                new Event{ Id =2 , Name="Writing", Date="11 Mar 2019", ImageCount=1, Photo="image4.jpg", Description="Visit to Kuttralam - with all the students and parents"},
                new Event{ Id =1 , Name="Playing", Date="11 Mar 2019", ImageCount=1, Photo="image5.jpg", Description="Visit to Kuttralam - with all the students and parents"},
            };
        }

        public ObservableCollection<Event> EventsGallery
        {
            get; set;
        }

        public Event SelectedEvent
        {
            get; set;
        }

        public ICommand ItemClickCommand
        {
            get
            {
                return new Command(() =>
                {
                    PopupNavigation.Instance.PushAsync(new EventDetailPage(this));
                });
            }
        }

        public ICommand CarouselCommand
        {
            get
            {
                return new Command((obj) => {
                    var currentevent=new Event { Id = 1, Name = "Playing", Date = "11 Mar 2019", ImageCount = 1, Photo = "image1.jpg", Description = "Visit to Kuttralam - with all the students and parents",
                        Images=new List<string> {"image1.jpg","image2.jpg","image3.jpg" }
                    };
                    _navigation.PushAsync(new ImageCarouselPage(currentevent));
                });
            }
        }
    }
}
