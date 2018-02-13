using System.Collections.Generic;
using System.Linq;
using Adapt.Providers;

namespace Adapt.Adaptors
{
    /// <summary>
    /// Adapter for acme company
    /// </summary>
    public class AcmeCompanyAdapter : Adapter
    {
        public override List<User> UserList()
        {
            var data = (List<dynamic>)AcmeDataProvider.BadDataList;
            return data.Select(x => new User { Name = x.isim, SurName = x.Soyisim }).ToList();
        }
    }
}