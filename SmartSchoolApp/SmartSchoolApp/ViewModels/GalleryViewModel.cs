using SmartSchoolApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace SmartSchoolApp.ViewModels
{
   public class GalleryViewModel : BaseViewModel
    {
        public GalleryViewModel()
        {
            EventsGallery = new ObservableCollection<Event>
            {
                new Event{ Id =1 , Name="11th May 2019 : Playing", Photo="image1.jpg" },
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
    }
}
