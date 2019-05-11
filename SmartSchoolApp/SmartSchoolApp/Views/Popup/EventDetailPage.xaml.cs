using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using SmartSchoolApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartSchoolApp.Views.Popup
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EventDetailPage : PopupPage
	{
		public EventDetailPage (GalleryViewModel viewModel)
		{
			InitializeComponent ();

            BindingContext = viewModel;

            var tapGestureRecognizer = new TapGestureRecognizer();

            tapGestureRecognizer.Tapped += (s, e) => {
                PopupNavigation.Instance.PopAllAsync();
            };
            close.GestureRecognizers.Add(tapGestureRecognizer);
        }
	}
}