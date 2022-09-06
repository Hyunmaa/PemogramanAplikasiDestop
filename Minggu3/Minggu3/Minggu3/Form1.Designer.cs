
namespace Minggu3
{
    partial class Form1
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPertama = new System.Windows.Forms.Button();
            this.btnKedua = new System.Windows.Forms.Button();
            this.btnKetiga = new System.Windows.Forms.Button();
            this.btnKeempat = new System.Windows.Forms.Button();
            this.btnKelima = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.LightCoral;
            this.btnClose.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(655, 285);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(92, 43);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPertama
            // 
            this.btnPertama.Location = new System.Drawing.Point(53, 34);
            this.btnPertama.Name = "btnPertama";
            this.btnPertama.Size = new System.Drawing.Size(75, 23);
            this.btnPertama.TabIndex = 1;
            this.btnPertama.Text = "10";
            this.btnPertama.UseVisualStyleBackColor = true;
            this.btnPertama.Click += new System.EventHandler(this.btnPertama_Click);
            // 
            // btnKedua
            // 
            this.btnKedua.Location = new System.Drawing.Point(178, 33);
            this.btnKedua.Name = "btnKedua";
            this.btnKedua.Size = new System.Drawing.Size(75, 23);
            this.btnKedua.TabIndex = 2;
            this.btnKedua.Text = "10";
            this.btnKedua.UseVisualStyleBackColor = true;
            this.btnKedua.Click += new System.EventHandler(this.btnPertama_Click);
            // 
            // btnKetiga
            // 
            this.btnKetiga.Location = new System.Drawing.Point(315, 33);
            this.btnKetiga.Name = "btnKetiga";
            this.btnKetiga.Size = new System.Drawing.Size(75, 23);
            this.btnKetiga.TabIndex = 3;
            this.btnKetiga.Text = "10";
            this.btnKetiga.UseVisualStyleBackColor = true;
            this.btnKetiga.Click += new System.EventHandler(this.btnPertama_Click);
            // 
            // btnKeempat
            // 
            this.btnKeempat.Location = new System.Drawing.Point(460, 33);
            this.btnKeempat.Name = "btnKeempat";
            this.btnKeempat.Size = new System.Drawing.Size(75, 23);
            this.btnKeempat.TabIndex = 4;
            this.btnKeempat.Text = "10";
            this.btnKeempat.UseVisualStyleBackColor = true;
            this.btnKeempat.Click += new System.EventHandler(this.btnPertama_Click);
            // 
            // btnKelima
            // 
            this.btnKelima.Location = new System.Drawing.Point(610, 33);
            this.btnKelima.Name = "btnKelima";
            this.btnKelima.Size = new System.Drawing.Size(75, 23);
            this.btnKelima.TabIndex = 5;
            this.btnKelima.Text = "10";
            this.btnKelima.UseVisualStyleBackColor = true;
            this.btnKelima.Click += new System.EventHandler(this.btnPertama_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKelima);
            this.Controls.Add(this.btnKeempat);
            this.Controls.Add(this.btnKetiga);
            this.Controls.Add(this.btnKedua);
            this.Controls.Add(this.btnPertama);
            this.Controls.Add(this.btnClose);
            this.Name = "Form1";
            this.Text = "frmUtama";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPertama;
        private System.Windows.Forms.Button btnKedua;
        private System.Windows.Forms.Button btnKetiga;
        private System.Windows.Forms.Button btnKeempat;
        private System.Windows.Forms.Button btnKelima;
    }
}

