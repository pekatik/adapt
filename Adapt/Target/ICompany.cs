using System;
using System.Collections.Generic;
using System.Text;

namespace Adapt.Target
{

    // our target is interface. It may have been abstract class
    public  interface ICompany
    {
        List<User> UserList();
    }

}
