
namespace Minggu6
{
    partial class frmUtama
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NRP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nilai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtNRP = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtNilai = new System.Windows.Forms.TextBox();
            this.lbNRP = new System.Windows.Forms.Label();
            this.lbNama = new System.Windows.Forms.Label();
            this.lbNilai = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NRP,
            this.Nama,
            this.Nilai,
            this.Action});
            this.dataGridView1.Location = new System.Drawing.Point(12, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(506, 362);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // NRP
            // 
            this.NRP.HeaderText = "NRP";
            this.NRP.Name = "NRP";
            // 
            // Nama
            // 
            this.Nama.HeaderText = "Nama";
            this.Nama.Name = "Nama";
            // 
            // Nilai
            // 
            this.Nilai.HeaderText = "Nilai";
            this.Nilai.Name = "Nilai";
            // 
            // Action
            // 
            this.Action.HeaderText = "Action";
            this.Action.Name = "Action";
            this.Action.Text = "Delete";
            this.Action.UseColumnTextForButtonValue = true;
            // 
            // txtNRP
            // 
            this.txtNRP.Location = new System.Drawing.Point(582, 52);
            this.txtNRP.Name = "txtNRP";
            this.txtNRP.Size = new System.Drawing.Size(100, 20);
            this.txtNRP.TabIndex = 1;
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(582, 91);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(100, 20);
            this.txtNama.TabIndex = 2;
            // 
            // txtNilai
            // 
            this.txtNilai.Location = new System.Drawing.Point(582, 129);
            this.txtNilai.Name = "txtNilai";
            this.txtNilai.Size = new System.Drawing.Size(100, 20);
            this.txtNilai.TabIndex = 3;
            // 
            // lbNRP
            // 
            this.lbNRP.AutoSize = true;
            this.lbNRP.Location = new System.Drawing.Point(525, 58);
            this.lbNRP.Name = "lbNRP";
            this.lbNRP.Size = new System.Drawing.Size(36, 13);
            this.lbNRP.TabIndex = 4;
            this.lbNRP.Text = "NRP :";
            // 
            // lbNama
            // 
            this.lbNama.AutoSize = true;
            this.lbNama.Location = new System.Drawing.Point(525, 98);
            this.lbNama.Name = "lbNama";
            this.lbNama.Size = new System.Drawing.Size(41, 13);
            this.lbNama.TabIndex = 5;
            this.lbNama.Text = "Nama :";
            // 
            // lbNilai
            // 
            this.lbNilai.AutoSize = true;
            this.lbNilai.Location = new System.Drawing.Point(525, 136);
            this.lbNilai.Name = "lbNilai";
            this.lbNilai.Size = new System.Drawing.Size(33, 13);
            this.lbNilai.TabIndex = 6;
            this.lbNilai.Text = "Nilai :";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(582, 167);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(524, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nama :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(582, 205);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(582, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 501);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbNilai);
            this.Controls.Add(this.lbNama);
            this.Controls.Add(this.lbNRP);
            this.Controls.Add(this.txtNilai);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtNRP);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmUtama";
            this.Text = "Form Utama";
            this.Load += new System.EventHandler(this.frmUtama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtNRP;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtNilai;
        private System.Windows.Forms.Label lbNRP;
        private System.Windows.Forms.Label lbNama;
        private System.Windows.Forms.Label lbNilai;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NRP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nilai;
        private System.Windows.Forms.DataGridViewButtonColumn Action;
    }
}

