using VisualDemo.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Android.Content;

[assembly: ExportRenderer(typeof(Xamarin.Forms.ContentPage), typeof(LeetContentPageRenderer), new[] { typeof(VisualDemo.LeetVisual) })]
namespace VisualDemo.Droid.Renderers
{
    public class LeetContentPageRenderer : PageRenderer
    {
        public LeetContentPageRenderer(Context context) : base(context)
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<Page> e)
        {
            base.OnElementChanged(e);

            SetBackgroundColor(Color.FromHex("#002B55").ToAndroid());
        }
    }
}
