using System;
using VisualDemo.iOS.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(Xamarin.Forms.ContentPage), typeof(LeetContentPageRenderer), new[] { typeof(VisualDemo.LeetVisual) })]
namespace VisualDemo.iOS.Renderers
{
    public class LeetContentPageRenderer : PageRenderer
    {

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            View.BackgroundColor = Color.FromHex("#002B55").ToUIColor();
        }
    }
}
