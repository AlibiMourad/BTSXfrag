using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BTSxfrag.Mode;
using Plugin.RestClient;

namespace BTSxfrag.Service
{
    public class ServiceOr
    {

        public async Task<List<Orange>> GetOrangesAsync()
        {

            RestClient<Orange> restClient = new RestClient<Orange>();
            var list = await restClient.GetAsync("Oranges/");

            return list;

        }
    }
}
