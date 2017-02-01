using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BTSxfrag.Mode;
using Plugin.RestClient;

namespace BTSxfrag.Service
{
    public class ServiceTt
    {
      
        public async Task<List<TunisieTelecom>> GeTunisieTelecomsAsync()
        {
            
          RestClient<TunisieTelecom> restClient=new RestClient<TunisieTelecom>();
            var list = await restClient.GetAsync("TunisieTelecoms/");
           
            return list;
                
        }
    }
}
