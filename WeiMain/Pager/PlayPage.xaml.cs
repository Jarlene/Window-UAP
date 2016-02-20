using Windows.UI.Xaml.Controls;

namespace WeiMain.Pager
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
