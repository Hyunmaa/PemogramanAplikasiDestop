using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minggu2_PhoneBook
{
    public partial class frmUtama : Form
    {
        PhoneBook pb;
        public frmUtama()
        {
            InitializeComponent();
            pb = new PhoneBook(2);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Contact temp = new Contact();
        }

        private void lblEmergency_Click(object sender, EventArgs e)
        {
            Contact temp = new Contact();
            temp.Name = boxName.Text;
            temp.Phone = boxPhoneNumber.Text;
            temp.EmergencyContact = chbEmergency.Checked;

            if(pb.addContact(temp))
            {
                MessageBox.Show("Contact Saved");
            }
            else
            {
                MessageBox.Show("Phone Book is Full");
            }

            updateList();
        }

        void updateList()
        {
           
        }

        private void listContact_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmUtama_Load(object sender, EventArgs e)
        {

        }

        private void btnShowEmergency_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void listContact2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
