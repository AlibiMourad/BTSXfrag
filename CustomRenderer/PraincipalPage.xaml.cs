using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BTSxfrag.View;
using Xamarin.Forms;

namespace BTSxfrag
{
    public partial class PraincipalPage : ContentPage
    {
        public Page pa;
        public TabbedPage p;
        public PraincipalPage()
        {
            InitializeComponent();
        }

        private async void ButtonMap(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GPSpage());
        }

        private async void ButtonAssmbli(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TypeRadioPage());
        }

        private async void ClicTools(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OutilPage());
        }

        private async void ClicedIfconfig(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new IfconfugPage());
        }
    }

    internal abstract class pa
    {
       
    }
}
