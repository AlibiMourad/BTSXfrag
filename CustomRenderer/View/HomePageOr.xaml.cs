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

    public partial class HomePageOr : ContentPage
    {

        public double a, b;

        public HomePageOr(double a,double b)
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

            listr = new List<Orange>((IEnumerable<Orange>)MyListOr.ItemsSource);
            await Navigation.PushAsync(new MapPage(lista, listo, listr, "Or",a,b));
        }
    }
}
