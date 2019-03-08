using Android.Content;
using VisualDemo.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Xamarin.Forms.Label), typeof(LeetLabelRenderer), new[] { typeof(VisualDemo.LeetVisual) })]
namespace VisualDemo.Droid.Renderers
{
    public class LeetLabelRenderer : LabelRenderer
    {

        public LeetLabelRenderer(Context context) : base(context)
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            Control.SetTextColor(Color.White.ToAndroid());
        }
    }
}
