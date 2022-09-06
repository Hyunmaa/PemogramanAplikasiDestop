using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minggu3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // MessageBox.Show("Message di constructor setelah initialize");
            // Load Database
            // Mengisi komponen komponen seperti combo box, listbox

            for (int i = 0; i < 10; i++)
            {
                Button btn = new Button();
                btn.Text = "10";
                btn.Left = btnPertama.Left + i * 40;
                btn.Top = btnPertama.Top + 40;
                btn.Width = 35;
                btn.Click += new System.EventHandler(this.btnPertama_Click);
                this.Controls.Add(btn);
            }

            foreach (var item in this.Controls)
            {
                if(item is Button)
                {
                    Button btn = (Button)item;
                    if(btn.Text == "Tutup Form")
                    {
                        MessageBox.Show(btn.Name);
                    }
                }
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            // MessageBox.Show("Message di form shown");
            // Digunakan untuk mengatur tampilan komponen
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DialogResult dialog
            MessageBox.Show(e.CloseReason.ToString());
            var dialog = MessageBox.Show("Apakah anda yakin ingin menutup program?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if(dialog == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            //var dialog = MessageBox.Show("Apakah anda yakin ingin menutup program?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            //if (dialog == DialogResult.OK)
            //{
            //    this.Close();
            //}
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void btnPertama_Click(object sender, EventArgs e)
        {
            var tempBtn = (Button)sender;
            tempBtn.Text = Convert.ToInt32(tempBtn.Text) - 1 + "";
        }
    }
}
