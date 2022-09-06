
namespace Minggu2_PhoneBook
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
            this.boxName = new System.Windows.Forms.TextBox();
            this.boxPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblEmergency = new System.Windows.Forms.Label();
            this.chbEmergency = new System.Windows.Forms.CheckBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.listContact = new System.Windows.Forms.ListBox();
            this.btnShowAllContact = new System.Windows.Forms.Button();
            this.btnShowEmergency = new System.Windows.Forms.Button();
            this.txtSearchContact = new System.Windows.Forms.TextBox();
            this.btnSearchContact = new System.Windows.Forms.Button();
            this.btnDeleteContact = new System.Windows.Forms.Button();
            this.listContact2 = new System.Windows.Forms.ListBox();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.btnIsFull = new System.Windows.Forms.Button();
            this.btnIsEmpty = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // boxName
            // 
            this.boxName.Location = new System.Drawing.Point(130, 39);
            this.boxName.Name = "boxName";
            this.boxName.Size = new System.Drawing.Size(200, 20);
            this.boxName.TabIndex = 0;
            // 
            // boxPhoneNumber
            // 
            this.boxPhoneNumber.Location = new System.Drawing.Point(130, 65);
            this.boxPhoneNumber.Name = "boxPhoneNumber";
            this.boxPhoneNumber.Size = new System.Drawing.Size(200, 20);
            this.boxPhoneNumber.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(24, 36);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 23);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblName.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.Location = new System.Drawing.Point(24, 62);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(100, 23);
            this.lblPhoneNumber.TabIndex = 3;
            this.lblPhoneNumber.Text = "Phone Number";
            this.lblPhoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEmergency
            // 
            this.lblEmergency.Location = new System.Drawing.Point(24, 87);
            this.lblEmergency.Name = "lblEmergency";
            this.lblEmergency.Size = new System.Drawing.Size(100, 23);
            this.lblEmergency.TabIndex = 4;
            this.lblEmergency.Text = "Type";
            this.lblEmergency.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblEmergency.Click += new System.EventHandler(this.lblEmergency_Click);
            // 
            // chbEmergency
            // 
            this.chbEmergency.AutoSize = true;
            this.chbEmergency.Location = new System.Drawing.Point(131, 91);
            this.chbEmergency.Name = "chbEmergency";
            this.chbEmergency.Size = new System.Drawing.Size(119, 17);
            this.chbEmergency.TabIndex = 5;
            this.chbEmergency.Text = "Emergency Contact";
            this.chbEmergency.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(131, 114);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(79, 32);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add Contact";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // listContact
            // 
            this.listContact.FormattingEnabled = true;
            this.listContact.Location = new System.Drawing.Point(390, 36);
            this.listContact.Name = "listContact";
            this.listContact.Size = new System.Drawing.Size(145, 303);
            this.listContact.TabIndex = 7;
            this.listContact.SelectedIndexChanged += new System.EventHandler(this.listContact_SelectedIndexChanged);
            // 
            // btnShowAllContact
            // 
            this.btnShowAllContact.Location = new System.Drawing.Point(27, 168);
            this.btnShowAllContact.Name = "btnShowAllContact";
            this.btnShowAllContact.Size = new System.Drawing.Size(87, 37);
            this.btnShowAllContact.TabIndex = 8;
            this.btnShowAllContact.Text = "Show All Contact";
            this.btnShowAllContact.UseVisualStyleBackColor = true;
            // 
            // btnShowEmergency
            // 
            this.btnShowEmergency.Location = new System.Drawing.Point(27, 211);
            this.btnShowEmergency.Name = "btnShowEmergency";
            this.btnShowEmergency.Size = new System.Drawing.Size(87, 37);
            this.btnShowEmergency.TabIndex = 9;
            this.btnShowEmergency.Text = "Show Emergency";
            this.btnShowEmergency.UseVisualStyleBackColor = true;
            this.btnShowEmergency.Click += new System.EventHandler(this.btnShowEmergency_Click);
            // 
            // txtSearchContact
            // 
            this.txtSearchContact.Location = new System.Drawing.Point(27, 270);
            this.txtSearchContact.Name = "txtSearchContact";
            this.txtSearchContact.Size = new System.Drawing.Size(100, 20);
            this.txtSearchContact.TabIndex = 10;
            // 
            // btnSearchContact
            // 
            this.btnSearchContact.Location = new System.Drawing.Point(133, 269);
            this.btnSearchContact.Name = "btnSearchContact";
            this.btnSearchContact.Size = new System.Drawing.Size(100, 20);
            this.btnSearchContact.TabIndex = 11;
            this.btnSearchContact.Text = "Search Contact";
            this.btnSearchContact.UseVisualStyleBackColor = true;
            // 
            // btnDeleteContact
            // 
            this.btnDeleteContact.Location = new System.Drawing.Point(239, 270);
            this.btnDeleteContact.Name = "btnDeleteContact";
            this.btnDeleteContact.Size = new System.Drawing.Size(100, 20);
            this.btnDeleteContact.TabIndex = 12;
            this.btnDeleteContact.Text = "Delete Contact";
            this.btnDeleteContact.UseVisualStyleBackColor = true;
            this.btnDeleteContact.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // listContact2
            // 
            this.listContact2.FormattingEnabled = true;
            this.listContact2.Location = new System.Drawing.Point(541, 36);
            this.listContact2.Name = "listContact2";
            this.listContact2.Size = new System.Drawing.Size(145, 303);
            this.listContact2.TabIndex = 13;
            this.listContact2.SelectedIndexChanged += new System.EventHandler(this.listContact2_SelectedIndexChanged);
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.Location = new System.Drawing.Point(24, 319);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(100, 34);
            this.btnDeleteAll.TabIndex = 14;
            this.btnDeleteAll.Text = "Delete All";
            this.btnDeleteAll.UseVisualStyleBackColor = true;
            // 
            // btnIsFull
            // 
            this.btnIsFull.Location = new System.Drawing.Point(133, 319);
            this.btnIsFull.Name = "btnIsFull";
            this.btnIsFull.Size = new System.Drawing.Size(100, 34);
            this.btnIsFull.TabIndex = 15;
            this.btnIsFull.Text = "is Full";
            this.btnIsFull.UseVisualStyleBackColor = true;
            // 
            // btnIsEmpty
            // 
            this.btnIsEmpty.Location = new System.Drawing.Point(239, 319);
            this.btnIsEmpty.Name = "btnIsEmpty";
            this.btnIsEmpty.Size = new System.Drawing.Size(100, 34);
            this.btnIsEmpty.TabIndex = 16;
            this.btnIsEmpty.Text = "is Empty";
            this.btnIsEmpty.UseVisualStyleBackColor = true;
            // 
            // frmUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(698, 461);
            this.Controls.Add(this.btnIsEmpty);
            this.Controls.Add(this.btnIsFull);
            this.Controls.Add(this.btnDeleteAll);
            this.Controls.Add(this.listContact2);
            this.Controls.Add(this.btnDeleteContact);
            this.Controls.Add(this.btnSearchContact);
            this.Controls.Add(this.txtSearchContact);
            this.Controls.Add(this.btnShowEmergency);
            this.Controls.Add(this.btnShowAllContact);
            this.Controls.Add(this.listContact);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.chbEmergency);
            this.Controls.Add(this.lblEmergency);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.boxPhoneNumber);
            this.Controls.Add(this.boxName);
            this.Name = "frmUtama";
            this.Text = "Form Utama";
            this.Load += new System.EventHandler(this.frmUtama_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox boxName;
        private System.Windows.Forms.TextBox boxPhoneNumber;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblEmergency;
        private System.Windows.Forms.CheckBox chbEmergency;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox listContact;
        private System.Windows.Forms.Button btnShowAllContact;
        private System.Windows.Forms.Button btnShowEmergency;
        private System.Windows.Forms.TextBox txtSearchContact;
        private System.Windows.Forms.Button btnSearchContact;
        private System.Windows.Forms.Button btnDeleteContact;
        private System.Windows.Forms.ListBox listContact2;
        private System.Windows.Forms.Button btnDeleteAll;
        private System.Windows.Forms.Button btnIsFull;
        private System.Windows.Forms.Button btnIsEmpty;
    }
}

