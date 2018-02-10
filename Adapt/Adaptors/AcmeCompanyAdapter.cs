using System.Collections.Generic;
using System.Linq;
using Adapt.Providers;
using  Adapt.Target;

namespace Adapt.Adaptors
{
    /// <summary>
    /// Adapter for acme company
    /// </summary>
    public class AcmeCompanyAdapter:ICompanyAdapter
    {
        public List<User> UserList()
        {
            AcmeDataProvider acmeDataProvider=new AcmeDataProvider();

            var data = (List<dynamic>)acmeDataProvider.BadDataList;
            return data.Select(x => new User { Name = x.isim, SurName = x.Soyisim }).ToList();
        }
    }
}