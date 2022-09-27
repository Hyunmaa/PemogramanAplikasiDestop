using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minggu6
{
    public partial class frmUtama : Form
    {
        public frmUtama()
        {
            InitializeComponent();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(txtNRP.Text, txtNama.Text, txtNilai.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // dataGridView1.Rows[2].Cells[1].Value = textBox1.Text;
            int baris = dataGridView1.CurrentCell.RowIndex;
            int kolom = dataGridView1.CurrentCell.ColumnIndex;

            dataGridView1.Rows[baris].Cells[kolom].Value = textBox1.Text;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // int rowIndex = dataGridView1.CurrentCell.RowIndex;
            // dataGridView1.Rows.RemoveAt(rowIndex);
            if(e.ColumnIndex == 3 && e.RowIndex < dataGridView1.Rows.Count - 1)
            {
                int baris = dataGridView1.CurrentCell.RowIndex;
                MessageBox.Show(
                    dataGridView1.Rows[baris].Cells[0].Value + " " +
                    dataGridView1.Rows[baris].Cells[1].Value + " " +
                    dataGridView1.Rows[baris].Cells[2].Value + " ");
            }
        }

        private void frmUtama_Load(object sender, EventArgs e)
        {

        }
    }
}
