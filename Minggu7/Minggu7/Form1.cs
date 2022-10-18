using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Minggu7
{
    public partial class Form1 : Form
    { 
        //Membuat dataset
        DataSet1 ds;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("jp-JP");
            ds = new DataSet1();
            dataGridView1.DataSource = ds.Tables["Mahasiswa"];
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[3].DefaultCellStyle.Format = "C0";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRow dr = ds.Tables["mahasiswa"].NewRow();
            dr["nrp"] = textBox1.Text;
            dr[1] = textBox2.Text;
            dr[2] = textBox3.Text;
            dr["uangjajan"] = numericUpDown1.Value;
            ds.Tables["mahasiswa"].Rows.Add(dr);
        }

        int idx = -1;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idx = e.RowIndex;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ds.Tables["mahasiswa"].Rows.RemoveAt(idx);
        }

        void kembalikanWarna()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[3].Style.BackColor = SystemColors.Control;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kembalikanWarna();
            for (int i = 0; i < ds.Tables["mahasiswa"].Rows.Count; i++)
            {
                if (Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value) >= numericUpDown1.Value)
                {
                    dataGridView1.Rows[i].Cells[3].Style.BackColor = Color.Lime;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ds.Tables["mahasiswa"].Rows[idx][3].ToString());
        }

        // Codingan untuk menampilkan data setelah di klik
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Text = ds.Tables["mahasiswa"].Rows[idx][1].ToString();
            textBox3.Text = ds.Tables["mahasiswa"].Rows[idx][2].ToString();
            numericUpDown1.Value = Convert.ToInt32(ds.Tables["mahasiswa"].Rows[idx][3].ToString());
            
        }

        // Codingan button untuk UPDATE
        private void button5_Click(object sender, EventArgs e)
        {
            ds.Tables["mahasiswa"].Rows[idx][1] = textBox2.Text;
            ds.Tables["mahasiswa"].Rows[idx][2] = textBox3.Text;
            ds.Tables["mahasiswa"].Rows[idx][3] = numericUpDown1.Value;
        }
    }
}
