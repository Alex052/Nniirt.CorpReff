using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;

namespace Solution3.Module.BusinessObjects
{
    public class Division : XPObject
    {
        public Division(Session session) :
            base(session)
        {
        }
        [DisplayName("Название")]
        public string Name
        {
            get;
            set;
        }
    }
}
