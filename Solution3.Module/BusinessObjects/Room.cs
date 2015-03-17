using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;
using DevExpress.Persistent.Validation;

namespace Solution3.Module.BusinessObjects
{
    public class Room : XPObject
    {
        private Building building;

        public Room(Session session) :
            base(session)
        {
        }
        [DisplayName("Номер")]
        public string Number
        {
            get;
            set;
        }



        [Association("Room-Building")]
        [RuleRequiredField(
            "RuleRequiredField for Solution3.Room.Building",
            DefaultContexts.Save,
            "Position cannot be empty")]
        [DisplayName("Строение")]
        public Building Building
        {
            get;
            set;
        }
    }
    
}
