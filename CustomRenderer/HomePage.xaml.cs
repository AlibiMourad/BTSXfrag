using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BTSxfrag.View;
using Xamarin.Forms;

namespace BTSxfrag
{
    public partial class HomePage : ContentPage
    {
        public double a, b;
        public HomePage(double x,double y)
        {
            InitializeComponent();
            Button1.IsVisible = false;
            Button2.IsVisible = false;
            Button3.IsVisible = false;
            
         Button1.IsVisible= Device.OnPlatform(
            iOS: true,
            Android: true,
            WinPhone: false);
            Button2.IsVisible = Device.OnPlatform(
                      iOS: true,
                      Android: true,
                      WinPhone: false);
            Button3.IsVisible = Device.OnPlatform(
          iOS: true,
          Android: true,
          WinPhone: false);

            a = x;
            b = y;
        }

        public HomePage()
        {
        }

        private async void ButtonTt(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HomePageTt(a,b));
        }

        private async void ButtonOo(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HomePageOo(a,b));
        }

        private async void ButtonOr(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HomePageOr(a,b));
        }
    }
}
