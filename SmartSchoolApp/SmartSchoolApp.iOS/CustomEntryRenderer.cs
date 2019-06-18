using System;
using SmartSchoolApp.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(Entry), typeof(CustomEntryRenderer))]
namespace SmartSchoolApp.iOS
{
    public class CustomEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.BorderStyle = UITextBorderStyle.RoundedRect;
                Control.Layer.BorderColor = Color.FromHex("673ab7").ToCGColor();
                Control.Layer.BorderWidth = 1;
                Control.Layer.CornerRadius = 3;
            }
        }
    }
}
