using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace SmartSchoolApp.ViewModels
{
   public class HomeViewModel : BaseViewModel
    {
        public HomeViewModel()
        {
            SlideShowSource = new ObservableCollection<View>
            {
                new Image{ Source="blackbord.jpg", Aspect= Aspect.AspectFill},
                new Image{ Source="writing.jpg", Aspect= Aspect.AspectFill},
            };
        }

        ObservableCollection<View> _SlideShowSource;
        public ObservableCollection<View> SlideShowSource
        {
            set
            {
                _SlideShowSource = value;
                OnPropertyChanged("SlideShowSource");
            }
            get
            {
                return _SlideShowSource;
            }
        }
    }
}
