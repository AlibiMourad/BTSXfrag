using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace BTSxfrag
{
    public partial class TypeRadioPage : ContentPage
    {
        public TypeRadioPage()
        {
            InitializeComponent();
        }

        private async void ClicH(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TypeRadioPage1("HuwAui"));
        }

        private async void clicA(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TypeRadioPage1("AlcaTel"));
        }

        private async void clicN(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TypeRadioPage1("NoKia"));
        }
    }
}
