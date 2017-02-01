using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using BTSxfrag.Mode;
using BTSxfrag.Service;

namespace BTSxfrag.ViewModel
{
    public class MainViewModelOo : INotifyPropertyChanged
    {



        private List<Ooredo> _listOoredos;


        public List<Ooredo> ListOoredos
        {
            get { return _listOoredos; }
            set
            {
                _listOoredos = value;
                OnPropertyChanged();
            }
        }


        public MainViewModelOo()
        {
            InitializeDataAsync();


        }

        private async Task InitializeDataAsync()
        {
            var serviceOo = new ServiceOo();
            ListOoredos = await serviceOo.GetOoredoesAsync();
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
