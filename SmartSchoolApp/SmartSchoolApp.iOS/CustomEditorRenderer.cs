using System;
using SmartSchoolApp.iOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(Editor), typeof(CustomEditorRenderer))]
namespace SmartSchoolApp.iOS
{
    public class CustomEditorRenderer : EditorRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Editor> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.Layer.CornerRadius = 3;
                Control.Layer.BorderColor = Color.FromHex("673ab7").ToCGColor();
                Control.Layer.BorderWidth = 1;
            }
        }
    }
}
