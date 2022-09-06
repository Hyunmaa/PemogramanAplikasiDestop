using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minggu2_PhoneBook
{
    class Contact
    {
        public String Name { get; set; } //Getter Setter by C#
        public String Phone { get; set; }
        private Boolean emergency;

        public Boolean EmergencyContact //Getter Setter by JAVA
        {
            get { return emergency; }
            set { emergency = value; }
        }

        public Contact()
        {
            Name = "";
            Phone = "";
            emergency = false;
        }

        public Contact(string name, string phone, bool emergencyContact)
        {
            Name = name;
            Phone = phone;
            EmergencyContact = emergencyContact;
        }

        public override string ToString()
        {
            return "Name : " + Name + Environment.NewLine + Phone + Environment.NewLine + "Emergency: " + emergency + Environment.NewLine;
        }
    }
}
