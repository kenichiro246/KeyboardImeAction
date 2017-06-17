using Android.Views.InputMethods;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(KeyboardImeAction.CustomEntry), typeof(KeyboardImeAction.Droid.CustomEntryDroid))]
namespace KeyboardImeAction.Droid
{
    class CustomEntryDroid : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.ImeOptions = (ImeAction)(ImeFlags.NoExtractUi | ImeFlags.NoFullscreen);
            }
        }
    }
}