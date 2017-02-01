using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BTSxfrag.Mode;
using BTSxfrag.Service;
using BTSxfrag.ViewModel;
using Xamarin.Forms;

namespace BTSxfrag.View
{

    public partial class HomePageOo : ContentPage
    {


        public double a, b;
        public HomePageOo( double a, double b)
        {
            InitializeComponent();
            this.a = a;
            this.b = b;
        }
        public List<TunisieTelecom> lista = null;
        public List<Ooredo> listo = null;
        public List<Orange> listr = null;
        private async void GoMap(object sender, EventArgs e)
        {

            listo = new List<Ooredo>((IEnumerable<Ooredo>)MyListOo.ItemsSource);

            await Navigation.PushAsync(new MapPage(lista, listo, listr, "Oo",a,b));
        }

        private async  void TapGestureRecognizer_OnTapped(object sender, EventArgs e)
        {

            listo = new List<Ooredo>((IEnumerable<Ooredo>)MyListOo.ItemsSource);

            await Navigation.PushAsync(new MapPage(lista, listo, listr, "Oo",a,b));
        }
    }
}
