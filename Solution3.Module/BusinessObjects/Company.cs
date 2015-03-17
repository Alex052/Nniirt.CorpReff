using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;

namespace Solution3.Module.BusinessObjects
{
    public class Company : XPObject
    {

        public Company(Session session) :
            base(session)
        {
        }
        [DisplayName("Имя")]
        public string Name
        {
            get;
            set;
        }
        [DisplayName("ИНН")]
        public string Inn
        {
            get;
            set;
        }
        [DisplayName("БИК")]
        public string Bik
        {
            get;
            set;
        }
        [DisplayName("Статус")]
        public int Status
        {
            get;
            set;
        }
        
    }
}
