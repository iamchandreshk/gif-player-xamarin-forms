using GifView;
using GifView.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(GifPlayer), typeof(GifPlayer_Android))]
namespace GifView.Droid
{
    public class GifPlayer_Android : ViewRenderer<GifPlayer, Android.Webkit.WebView>
    {
        protected override void OnElementChanged(ElementChangedEventArgs<GifPlayer> e)
        {
            base.OnElementChanged(e);
            string imgSource = "file:///android_asset/" + e.NewElement.Uri;
            string htmlString = string.Format(@"<html><body><img src='{0}' /></body></html>", imgSource);
            var webView = new global::Android.Webkit.WebView(this.Context);
            webView.SetBackgroundColor(Android.Graphics.Color.Transparent);
            webView.LoadDataWithBaseURL("", htmlString, "text/html", "utf-8", null);
            this.SetNativeControl(webView);
        }
    }
}