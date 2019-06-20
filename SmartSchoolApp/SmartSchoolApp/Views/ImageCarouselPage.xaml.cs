using SmartSchoolApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartSchoolApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ImageCarouselPage : CarouselPage
	{

		public ImageCarouselPage (Event currentEvent)
		{
			InitializeComponent ();

            Title = currentEvent.Msg;
            SetCarouselPages(currentEvent);
           
		}

        void SetCarouselPages(Event currentEvent)
        {

            foreach(var image in currentEvent.ImgUrl)
            {
                var contentPage = new ContentPage();

                contentPage.Content = new Image { Source = string.Format("{0}{1}",App.BaseUrl, image), HorizontalOptions = LayoutOptions.CenterAndExpand, VerticalOptions = LayoutOptions.CenterAndExpand, Aspect = Aspect.AspectFit };

                this.Children.Add(contentPage);
            }

        }
	}
}