using System.Collections.Generic;
using System.Linq;
using Adapt.Providers;
using  Adapt.Target;

namespace Adapt.Adaptors
{
    /// <summary>
    /// Adapter for acme company
    /// </summary>
    /// 
    /// 
    /// adapter for Acme
    public class AcmeCompanyAdapter:ICompany
    {
        public List<User> UserList()
        {
            AcmeDataProvider acmaDataProvider=new AcmeDataProvider();
            var data = (List<dynamic>) acmaDataProvider.BadDataList;
            return data.Select(x => new User { Name = x.isim, SurName = x.Soyisim }).ToList();
        }
    }
}