using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;
using System.ComponentModel;


namespace Solution3.Module.BusinessObjects
{
    [DefaultProperty("Number")]
    public class Building : XPObject
    {
            public Building(Session session) :
            base(session)
        {
        }

            public string Number
            {
                get;
                set;
            }
        
            public DateTime YearOfBuild
            {
                get;
                set;
            }

        [Association("Room-Building")]
        public XPCollection<Room> Room
        {
            get { return GetCollection<Room>("Room"); }
        }
    }
}
