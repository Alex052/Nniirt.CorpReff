using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;
using DevExpress.Persistent.Validation;

namespace Solution3.Module.BusinessObjects
{
    public class Employee : XPObject
    {
        private PhoneNumber phoneNumber;

        public Employee(Session session) :
            base(session)
        {
        }
        [DisplayName("Имя")]
        public string Name
        {
            get;
            set;
        }
        [DisplayName("Отчество")]
        public string Patronic
        {
         get;set;
        }
        [DisplayName("Фамилия")]
        public string Surname
        {
            get;
            set;
        }
        [DisplayName("Должность")]
        public string Position
        {
            get;
            set;
        }
        [DisplayName("ФИО")]
        public string FullName { get { return string.Format("{0} {1} {2}",Surname, Name, Patronic); } }

        [Association("Employee-PhoneNumber")]
        [RuleRequiredField(
            "RuleRequiredField for Solution3.Employee.PhoneNumber",
            DefaultContexts.Save,
            "Position cannot be empty")]
        [DisplayName("Номер телефона")]
        public PhoneNumber PhoneNumber
        {
            get;
            set;
        }
    }
    }

