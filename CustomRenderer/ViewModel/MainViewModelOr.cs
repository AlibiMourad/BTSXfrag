using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using BTSxfrag.Mode;
using BTSxfrag.Service;
using Xamarin.Forms;

namespace BTSxfrag.ViewModel
{
    public class MainViewModelOr : INotifyPropertyChanged
    {

        public Color Color=Color.Fuchsia;

        private List<Orange> _listOranges;


        public List<Orange> ListOranges
        {
            get { return _listOranges; }
            set
            {
                _listOranges = value;
                OnPropertyChanged();
            }
        }


        public MainViewModelOr()
        {
            InitializeDataAsync();


        }

        private async Task InitializeDataAsync()
        {
            var serviceOr = new ServiceOr();
            ListOranges = await serviceOr.GetOrangesAsync();
        }

        // public double GetXList(int i) => ListTunisieTelecoms[i].x;
        // public double GetYList(int i) => ListTunisieTelecoms[i].y;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }






    }
}
