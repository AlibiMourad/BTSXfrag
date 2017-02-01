using System.Collections.Generic;
using System.ComponentModel;
using BTSxfrag.Mode;
using BTSxfrag.Service;
using BTSxfrag.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace BTSxfrag
{
	public partial class MapPage :   ContentPage , INotifyPropertyChanged
	{
	    public double a1, a2, b1, b2;
	    
	   
	    public int Lg;
        public MapPage(List<TunisieTelecom> lista, List<Ooredo> listo, List<Orange> listr, string opera,double a,double b)
        {
			InitializeComponent ();
            if (lista != null) { Lg = lista.Count; }
            if (listo != null) { Lg =  listo.Count ; }
            if (listr != null) { Lg =  listr.Count; }
            // (a1,b1) Mon Position  
              a1 = a ;
              b1 = b ;   

            customMap.CustomPins = new List<CustomPin> { };

            var pin1 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(a1, b1),
                    Label = "Votre Position ",
                    Address = "Your Location"
                },
                Id = "Xamarin",
                Url = ""
            }; customMap.Pins.Add(pin1.Pin);customMap.CustomPins.Add(pin1);

            for(int i = 0 ; i < Lg ; i++)
            {
              
                
                string add="", titl="";
                if (lista != null){ a2 = lista[i].x; b2 = lista[i].y; add = lista[i].address; titl = lista[i].address; }
                if (listo != null){ a2 = listo[i].x; b2 = listo[i].y; add = listo[i].address; titl = listo[i].address; }
                if (listr != null){ a2 = listr[i].x; b2 = listr[i].y; add = listr[i].address; titl = listr[i].address; }
                var pin2 = new CustomPin
                {
                    Pin = new Pin
                    {
                        Type = PinType.Place, Position = new Position(a2, b2), Label = titl, Address = add
                    },
                    Id = opera,
                    Url = ""
                };
                customMap.Pins.Add(pin2.Pin); customMap.CustomPins.Add( pin2);

            }

            customMap.MoveToRegion (MapSpan.FromCenterAndRadius (new Position (a1, b1), Distance.FromMiles (1.3 )));
		}
    }
}
