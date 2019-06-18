using System;
using SmartSchoolApp.Models;
using Xamarin.Forms;

namespace SmartSchoolApp.Views
{
    public class GalleryDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate SingleImageTemplate { get; set; }

        public DataTemplate TwoImageTemplate { get; set; }

        public DataTemplate ThreeImageTemplate { get; set; }

        public DataTemplate FourImageTemplate { get; set; }

        public DataTemplate FiveImageTemplate { get; set; }


        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var imageCount = ((Event)item).ImageCount;
            DataTemplate dataTemplate;

            switch (imageCount)
            {
                case 1:
                    dataTemplate = SingleImageTemplate;
                    break;
                case 2:
                    dataTemplate = TwoImageTemplate;
                    break;
                case 3:
                    dataTemplate = ThreeImageTemplate;
                    break;
                case 4:
                    dataTemplate = FourImageTemplate;
                    break;
                case 5:
                    dataTemplate = FiveImageTemplate;
                    break;
                default:
                    dataTemplate = SingleImageTemplate;
                    break;

            }

            return dataTemplate;
        }
    }
}
