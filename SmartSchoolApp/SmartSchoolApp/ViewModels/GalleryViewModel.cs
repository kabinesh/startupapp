using Acr.UserDialogs;
using Rg.Plugins.Popup.Services;
using SmartSchoolApp.Interface;
using SmartSchoolApp.Models;
using SmartSchoolApp.Views;
using SmartSchoolApp.Views.Popup;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace SmartSchoolApp.ViewModels
{
    public class GalleryViewModel : BaseViewModel
    {
        INavigation _navigation;

        IRestApi _restApi;

        public GalleryViewModel(INavigation navigation)
        {
            _navigation = navigation;

            _restApi = App.RestApiService;

            EventsGallery = new ObservableCollection<Event>();

            GetEventsGalleryAsync();
           
        }

        private async Task GetEventsGalleryAsync()
        {

            try
            {
                UserDialogs.Instance.ShowLoading("Loading");

                var response = await _restApi.GetEventsGallery();

                if (response != null)
                {
                    EventsGallery = new ObservableCollection<Event>(response.GalleryDetails);
                }
            }
            catch(Exception ex)
            {

            }
            finally
            {
                UserDialogs.Instance.HideLoading();
            }
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
                return new Command((obj) =>
                {
                    _navigation.PushAsync(new ImageCarouselPage((Event)obj));
                });
            }
        }
    }
}
