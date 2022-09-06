using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minggu2_PhoneBook
{
    class PhoneBook
    {
        List<Contact> contacts;
        private int numOfContacts;

        public PhoneBook(int numOfContacts)
        {
            this.numOfContacts = numOfContacts;
            contacts = new List<Contact>();
        }

        public Boolean addContact(Contact contact)
        {
            if (contacts.Count >= numOfContacts) return false;
            contacts.Add(contact);
            return true;
        }

        public int getSize()
        {
            return contacts.Count;
        }

        public List<Contact> viewAllContact()
        {
            return contacts;
        }

        public List<Contact> viewEmergencyContact()
        {
            /*List<Contact> temp = new List<Contact>();
            foreach (var c in contacts)
            {
                if (c.EmergencyContact == true)
                {
                    temp.Add(c);
                }
            }
            return temp;*/

            return contacts.FindAll((x) => x.EmergencyContact == true);

        }

        public string searchContact(string name)
        {
            var x = contacts.Find((c) => c.Name == name);
            if (x is null)
                return "Contact Not Found";
            else
                return x.Name + " " + x.Phone;
        }

        public void delete(string name)
        {
            /*var x = contacts.Find((c) => c.Name == name);
            if (x != null)
                contacts.Remove(x);*/

            var jum = contacts.RemoveAll((x) => x.Name.ToLower() == name.ToLower());
            MessageBox.Show(jum + "Data Deleted");
        }

        public void deleteAll()
        {
            contacts.Clear();
        }

        public bool isEmpty()
        {
            return contacts.Count == 0;
        }

        public bool isFull()
        {
            return contacts.Count == numOfContacts;
        }
    }
}
