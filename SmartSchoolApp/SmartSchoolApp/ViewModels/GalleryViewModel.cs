using Rg.Plugins.Popup.Services;
using SmartSchoolApp.Models;
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
        public GalleryViewModel()
        {
            EventsGallery = new ObservableCollection<Event>
            {
                new Event{ Id =1 , Name="11th May 2019 : Playing", Photo="image1.jpg" ,Description="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged." },
                new Event{ Id =2 , Name="11th May 2019 : Writing", Photo="image2.jpg" },
                new Event{ Id =1 , Name="11th May 2019 : Playing", Photo="image3.jpg" },
                new Event{ Id =2 , Name="11th May 2019 : Writing", Photo="image4.jpg" },
                new Event{ Id =1 , Name="11th May 2019 : Playing", Photo="image5.jpg" },
                new Event{ Id =2 , Name="11th May 2019 : Writing", Photo="image2.jpg" },
                new Event{ Id =2 , Name="11th May 2019 : Writing", Photo="image4.jpg" },
                new Event{ Id =1 , Name="11th May 2019 : Playing", Photo="image5.jpg" },
            };
        }

        public ObservableCollection<Event> EventsGallery
        {
            get;set;
        }

        public Event SelectedEvent
        {
            get;set;
        }

        public ICommand ItemClickCommand
        {
            get
            {
                return new Command(() => {
                    PopupNavigation.Instance.PushAsync(new EventDetailPage(this));
                });
            }
        }
    }
}
