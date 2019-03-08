using System;
using VisualDemo.iOS.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using UIKit;

[assembly: ExportRenderer(typeof(Xamarin.Forms.ListView), typeof(ListViewRenderer), new[] { typeof(VisualDemo.LeetVisual) })]
namespace VisualDemo.iOS.Renderers
{
    public class LeetListViewRenderer : ListViewRenderer
    {

        protected override void OnElementChanged(ElementChangedEventArgs<ListView> e)
        {
            base.OnElementChanged(e);

            BackgroundColor = Color.Transparent.ToUIColor();
        }
    }
}
