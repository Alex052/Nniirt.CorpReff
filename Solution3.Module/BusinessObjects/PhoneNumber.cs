using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;
using DevExpress.ExpressApp.DC;
using System.ComponentModel;

namespace Solution3.Module.BusinessObjects
{
    [DefaultProperty("Number")]
    public class PhoneNumber : XPObject
    {
        
        
        
        public PhoneNumber(Session session) :
            base(session)
        {
        }
        public LinkType Type { get; set; }

        public string Number
        {
            get;
            set;
        }
        [Association("Employee-PhoneNumber")]
        public XPCollection<Employee> Employee
        {
            get { return GetCollection<Employee>("Employee"); }
        }
        

        
}
    public enum LinkType
        {
        
            Mobile = 0,
            Gorod = 1,
            Vnutr = 2,
        }

    }
