using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace WeiMain.Pager
{
    public sealed partial class SplashPager : Page
    {
        public SplashPager()
        {
            this.InitializeComponent();
        }

        private void GotoMainPager()
        {
            this.Frame.Navigate(typeof(MainPage));
        }

    }
}
