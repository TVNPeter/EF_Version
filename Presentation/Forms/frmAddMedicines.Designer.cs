﻿namespace EF_Version.Presentation.Forms
{
    partial class frmAddMedicines
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddMedicines));
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.lb_fullname = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_Quantity = new System.Windows.Forms.TextBox();
            this.txt_Dosage = new System.Windows.Forms.TextBox();
            this.lb_doctor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Frequency = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(385, 10);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(27, 29);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 54;
            this.pictureBox4.TabStop = false;
            // 
            // txt_Name
            // 
            this.txt_Name.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_Name.Location = new System.Drawing.Point(155, 11);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(226, 22);
            this.txt_Name.TabIndex = 52;
            // 
            // lb_fullname
            // 
            this.lb_fullname.AutoSize = true;
            this.lb_fullname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_fullname.Location = new System.Drawing.Point(29, 11);
            this.lb_fullname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_fullname.Name = "lb_fullname";
            this.lb_fullname.Size = new System.Drawing.Size(62, 21);
            this.lb_fullname.TabIndex = 49;
            this.lb_fullname.Text = "Name:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 340);
            this.dataGridView1.TabIndex = 59;
            // 
            // txt_Quantity
            // 
            this.txt_Quantity.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_Quantity.Location = new System.Drawing.Point(557, 12);
            this.txt_Quantity.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Quantity.Name = "txt_Quantity";
            this.txt_Quantity.Size = new System.Drawing.Size(226, 22);
            this.txt_Quantity.TabIndex = 63;
            // 
            // txt_Dosage
            // 
            this.txt_Dosage.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_Dosage.Location = new System.Drawing.Point(155, 52);
            this.txt_Dosage.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Dosage.Name = "txt_Dosage";
            this.txt_Dosage.Size = new System.Drawing.Size(226, 22);
            this.txt_Dosage.TabIndex = 62;
            // 
            // lb_doctor
            // 
            this.lb_doctor.AutoSize = true;
            this.lb_doctor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_doctor.Location = new System.Drawing.Point(30, 52);
            this.lb_doctor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_doctor.Name = "lb_doctor";
            this.lb_doctor.Size = new System.Drawing.Size(74, 21);
            this.lb_doctor.TabIndex = 61;
            this.lb_doctor.Text = "Dosage:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(432, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 21);
            this.label1.TabIndex = 60;
            this.label1.Text = "Quantity:";
            // 
            // txt_Frequency
            // 
            this.txt_Frequency.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_Frequency.Location = new System.Drawing.Point(557, 53);
            this.txt_Frequency.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Frequency.Name = "txt_Frequency";
            this.txt_Frequency.Size = new System.Drawing.Size(226, 22);
            this.txt_Frequency.TabIndex = 65;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(432, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 21);
            this.label2.TabIndex = 64;
            this.label2.Text = "Frequency:";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(511, 450);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(72, 45);
            this.btn_Cancel.TabIndex = 66;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(246, 450);
            this.btn_OK.Margin = new System.Windows.Forms.Padding(2);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 49);
            this.btn_OK.TabIndex = 67;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            // 
            // frmAddMedicines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 502);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.txt_Frequency);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Quantity);
            this.Controls.Add(this.txt_Dosage);
            this.Controls.Add(this.lb_doctor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.lb_fullname);
            this.Name = "frmAddMedicines";
            this.Text = "frmMedicines";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label lb_fullname;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_Quantity;
        private System.Windows.Forms.TextBox txt_Dosage;
        private System.Windows.Forms.Label lb_doctor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Frequency;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_OK;
    }
}