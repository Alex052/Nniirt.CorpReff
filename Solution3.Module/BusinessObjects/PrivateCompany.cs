using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;

namespace Solution3.Module.BusinessObjects
{
    public class PrivateCompany : Company
    {
        public PrivateCompany(Session session) :
            base(session)
        {
        }
    }
}
