using Android.Content;
using VisualDemo.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Xamarin.Forms.Frame), typeof(LeetFrameRenderer), new[] { typeof(VisualDemo.LeetVisual) })]
namespace VisualDemo.Droid.Renderers
{
    public class LeetFrameRenderer : FrameRenderer
    {
        public LeetFrameRenderer(Context context) : base(context)
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<Frame> e)
        {
            base.OnElementChanged(e);

            Element.BackgroundColor = Color.FromHex("#80C565");
        }
    }
}
