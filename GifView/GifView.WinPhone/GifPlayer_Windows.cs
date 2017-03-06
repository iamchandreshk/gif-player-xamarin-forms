using GifView;
using GifView.WinPhone;
using Windows.UI;
using Xamarin.Forms.Platform.WinRT;

[assembly: ExportRenderer(typeof(GifPlayer), typeof(GifPlayer_Windows))]
namespace GifView.WinPhone
{
    public class GifPlayer_Windows : ViewRenderer<GifPlayer, Windows.UI.Xaml.Controls.WebView>
    {
        protected override void OnElementChanged(ElementChangedEventArgs<GifPlayer> e)
        {
            base.OnElementChanged(e);
            string imgSource = "Assets/" + e.NewElement.Uri;
            string htmlString = string.Format(@"<html><body><img src='{0}' /></body></html>", imgSource);
            var webView = new Windows.UI.Xaml.Controls.WebView();
            webView.DefaultBackgroundColor = Colors.Transparent;
            webView.NavigateToString(htmlString);
            this.SetNativeControl(webView);
        }
    }
}
