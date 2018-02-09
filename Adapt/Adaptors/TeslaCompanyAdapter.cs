using System.Collections.Generic;
using Adapt.Providers;
using Newtonsoft.Json;

namespace Adapt.Adaptors
{
    /// <summary>
    /// Adapter for tesla company
    /// </summary>
    public class TeslaCompanyAdapter
    {
        public List<User> UserList()
        {
            //I guess this coder was blind :D
            var data = TeslaDataProvider.Getir;
            
            var jsonData = JsonConvert.DeserializeObject<dynamic>(data);
            var response = new List<User>();
            foreach (var item in jsonData.Data)
            {
                response.Add(new User {Name = item.adı, SurName = item.soyadı});
            }
            return response;
        }
    }
}