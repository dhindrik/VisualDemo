using System;
using VisualDemo.iOS.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using UIKit;

[assembly: ExportRenderer(typeof(Xamarin.Forms.Label), typeof(LeetLabelRenderer), new[] { typeof(VisualDemo.LeetVisual) })]
namespace VisualDemo.iOS.Renderers
{
    public class LeetLabelRenderer : LabelRenderer
    {

        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            Control.TextColor = UIColor.White;
        }
    }
}
