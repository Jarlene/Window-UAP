using Windows.UI.Xaml.Controls;

namespace WeiMain
{
    public sealed partial class PlayPage : Page
    {
        public PlayPage()
        {
            this.InitializeComponent();
            Prepage.Click += (sender, e) => {
                this.Frame.Navigate(typeof(MainPage));
            };
        }
    }
}
