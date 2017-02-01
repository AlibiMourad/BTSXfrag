using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace BTSxfrag
{
    
    public partial class TypeRadioPage1 : ContentPage
    {
        public string typeRadio;
        public TypeRadioPage1(string type)
        {
            InitializeComponent();
            typeRadio = type;
        }

        private async void ClicGPRS(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageAssambl(typeRadio,"GPRS"));
        }

        private async void ClicEqupement(object sender, EventArgs e)
        {
          //  await Navigation.PushAsync(new PageAssambl(typeRadio, "Equipement"));
            await Navigation.PushAsync(new NextPage(0, 0));
        }

        private async void ClicRAdio(object sender, EventArgs e)
        {
            //  await Navigation.PushAsync(new PageAssambl(typeRadio, "Radio"));
            await Navigation.PushAsync(new NextPage(0, 0));
        }
    }
}
