using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BTSxfrag.Mode;
using Plugin.Geolocator;
using Xamarin.Forms;

namespace BTSxfrag
{
    public partial class GPSpage : ContentPage
    {
        public List<TunisieTelecom> lista = null;
        public List<Ooredo> listo = null;
        public List<Orange> listr = null;
        public double x, y;
        public GPSpage()
        {
            InitializeComponent();
            Button2.IsVisible = false;


        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            var test = Device.OnPlatform(
                iOS: true,
                Android: true,
                WinPhone: false);


            if (test)
            {
            
            var locator = CrossGeolocator.Current;
            locator.DesiredAccuracy = 50;
            //  var pos = await locator.GetPositionAsync(-1, null, false);

            var position = await locator.GetPositionAsync(timeoutMilliseconds: 10000);
            //var position = await locator.GetPositionAsync( 10);
            LogitudeLabel.Text = "Longitude : "+position.Longitude.ToString();
            LatitudeLabel.Text = "Latitude :  " +position.Latitude.ToString();
            x = position.Longitude;
            y = position.Latitude;
        }
            else
            {
                x = 34.7745;  // a1 = a ;   // si j'ai pas de l'internet et il y a un ERROR en LOcation en windows 
                y = 10.76101; //b1 = b ;   // et si  Service GPS est desactive ...
                LogitudeLabel.Text = "Longitude : " + x.ToString();
                LatitudeLabel.Text = "Latitude :  "+ y.ToString();
            }

           Button2.IsVisible = true;

        }

        private async void clicOK(object sender, EventArgs e)
        {
            /*var lista=new List<TunisieTelecom>
            {
                new TunisieTelecom()
                {
                    Id = 0,
                    x = this.x,
                    y=this.y,
                }
            };*/
            // await Navigation.PushAsync(new MapPage(lista, listo, listr, "Xamarin"));
           
           await Navigation.PushAsync(new HomePage(x,y));
        }

        private async void Button_Cancel(object sender, EventArgs e)
        {
                       await Navigation.PushAsync(new PraincipalPage());
        }
    }
}
