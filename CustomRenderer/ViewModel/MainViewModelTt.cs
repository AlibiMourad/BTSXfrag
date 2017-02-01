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
   public class MainViewModelTt :INotifyPropertyChanged
   {
      


       private List<TunisieTelecom> _listTunisieTelecoms;
     

       public List<TunisieTelecom> ListTunisieTelecoms
       {
           get { return _listTunisieTelecoms; }
           set
           {
               _listTunisieTelecoms = value;
               OnPropertyChanged();
           }
       }
      

        public  MainViewModelTt()
       {
           InitializeDataAsync();

          
       }

       private async Task InitializeDataAsync()
       {
            var serviceTt = new ServiceTt();
            ListTunisieTelecoms = await serviceTt.GeTunisieTelecomsAsync();
            
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
