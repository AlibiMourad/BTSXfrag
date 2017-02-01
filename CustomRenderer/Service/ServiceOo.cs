using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BTSxfrag.Mode;
using Plugin.RestClient;

namespace BTSxfrag.Service
{
    public class ServiceOo
    {

        public async Task<List<Ooredo>> GetOoredoesAsync()
        {

            RestClient<Ooredo> restClient = new RestClient<Ooredo>();
            var list = await restClient.GetAsync("Ooredoes/");

            return list;

        }
    }
}
