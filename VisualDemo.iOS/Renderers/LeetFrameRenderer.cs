using System;
using VisualDemo.iOS.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(Xamarin.Forms.Frame), typeof(LeetFrameRenderer), new[] { typeof(VisualDemo.LeetVisual) })]
namespace VisualDemo.iOS.Renderers
{
    public class LeetFrameRenderer : FrameRenderer
    {
        public LeetFrameRenderer()
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Frame> e)
        {
            base.OnElementChanged(e);

            Element.BackgroundColor = Color.FromHex("#80C565");
        }
    }
}
