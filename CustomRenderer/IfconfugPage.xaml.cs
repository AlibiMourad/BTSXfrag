using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace BTSxfrag
{
    public partial class IfconfugPage : ContentPage
    {
        public IfconfugPage()
        {
            InitializeComponent();
            EntryIp.BackgroundColor = Color.Gray;
            EntryMasque.BackgroundColor = Color.Gray;
            EntryCapteur.BackgroundColor = Color.Gray;
            EntryVers.BackgroundColor = Color.Gray;
            EntryIp.TextColor = Color.Black;
            EntryMasque.TextColor = Color.Black;
            EntryCapteur.TextColor = Color.Black;
            EntryVers.TextColor = Color.Black;

        }

        private async void ClicSave(object sender, EventArgs e)
        {
            if ((EntryIp.Text ==null) ||( EntryMasque.Text == null) || (EntryCapteur.Text == null) ||( EntryVers.Text == null))
            {
                LabelError.IsVisible = true;
            }
            else
            {    
            await Navigation.PushAsync(new Save(EntryIp.Text, EntryMasque.Text, EntryCapteur.Text, EntryVers.Text));
            }
        }
    }
}
