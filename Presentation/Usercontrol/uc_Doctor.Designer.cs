namespace EF_Version.Presentation.Usercontrol
{
    partial class uc_Doctor
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_Doctor));
            this.btn_Change = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.dgv_Doctors = new System.Windows.Forms.DataGridView();
            this.cb_speciality = new System.Windows.Forms.ComboBox();
            this.txt_working = new System.Windows.Forms.TextBox();
            this.txt_fullname = new System.Windows.Forms.TextBox();
            this.txt_doctor = new System.Windows.Forms.TextBox();
            this.lb_doctor = new System.Windows.Forms.Label();
            this.lb_fullname = new System.Windows.Forms.Label();
            this.lb_speciality = new System.Windows.Forms.Label();
            this.lb_workingday = new System.Windows.Forms.Label();
            this.btn_Reload = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Doctors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Change
            // 
            this.btn_Change.Location = new System.Drawing.Point(688, 15);
            this.btn_Change.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Change.Name = "btn_Change";
            this.btn_Change.Size = new System.Drawing.Size(91, 63);
            this.btn_Change.TabIndex = 34;
            this.btn_Change.Text = "Change";
            this.btn_Change.UseVisualStyleBackColor = true;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(604, 99);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(91, 63);
            this.btn_Save.TabIndex = 33;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(571, 17);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(91, 63);
            this.btn_Add.TabIndex = 32;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(509, 99);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(91, 63);
            this.btn_Cancel.TabIndex = 31;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(449, 2);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(91, 63);
            this.btn_Delete.TabIndex = 30;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // dgv_Doctors
            // 
            this.dgv_Doctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Doctors.Location = new System.Drawing.Point(36, 182);
            this.dgv_Doctors.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_Doctors.Name = "dgv_Doctors";
            this.dgv_Doctors.RowHeadersWidth = 51;
            this.dgv_Doctors.RowTemplate.Height = 24;
            this.dgv_Doctors.Size = new System.Drawing.Size(743, 338);
            this.dgv_Doctors.TabIndex = 29;
            // 
            // cb_speciality
            // 
            this.cb_speciality.FormattingEnabled = true;
            this.cb_speciality.Location = new System.Drawing.Point(127, 99);
            this.cb_speciality.Margin = new System.Windows.Forms.Padding(2);
            this.cb_speciality.Name = "cb_speciality";
            this.cb_speciality.Size = new System.Drawing.Size(226, 24);
            this.cb_speciality.TabIndex = 28;
            // 
            // txt_working
            // 
            this.txt_working.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_working.Location = new System.Drawing.Point(148, 144);
            this.txt_working.Margin = new System.Windows.Forms.Padding(2);
            this.txt_working.Name = "txt_working";
            this.txt_working.Size = new System.Drawing.Size(315, 22);
            this.txt_working.TabIndex = 27;
            // 
            // txt_fullname
            // 
            this.txt_fullname.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_fullname.Location = new System.Drawing.Point(127, 58);
            this.txt_fullname.Margin = new System.Windows.Forms.Padding(2);
            this.txt_fullname.Name = "txt_fullname";
            this.txt_fullname.Size = new System.Drawing.Size(226, 22);
            this.txt_fullname.TabIndex = 26;
            // 
            // txt_doctor
            // 
            this.txt_doctor.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_doctor.Location = new System.Drawing.Point(127, 14);
            this.txt_doctor.Margin = new System.Windows.Forms.Padding(2);
            this.txt_doctor.Name = "txt_doctor";
            this.txt_doctor.Size = new System.Drawing.Size(226, 22);
            this.txt_doctor.TabIndex = 25;
            // 
            // lb_doctor
            // 
            this.lb_doctor.AutoSize = true;
            this.lb_doctor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_doctor.Location = new System.Drawing.Point(32, 14);
            this.lb_doctor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_doctor.Name = "lb_doctor";
            this.lb_doctor.Size = new System.Drawing.Size(89, 21);
            this.lb_doctor.TabIndex = 24;
            this.lb_doctor.Text = "Doctor ID:";
            // 
            // lb_fullname
            // 
            this.lb_fullname.AutoSize = true;
            this.lb_fullname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_fullname.Location = new System.Drawing.Point(32, 57);
            this.lb_fullname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_fullname.Name = "lb_fullname";
            this.lb_fullname.Size = new System.Drawing.Size(88, 21);
            this.lb_fullname.TabIndex = 23;
            this.lb_fullname.Text = "Full name:";
            // 
            // lb_speciality
            // 
            this.lb_speciality.AutoSize = true;
            this.lb_speciality.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_speciality.Location = new System.Drawing.Point(32, 102);
            this.lb_speciality.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_speciality.Name = "lb_speciality";
            this.lb_speciality.Size = new System.Drawing.Size(85, 21);
            this.lb_speciality.TabIndex = 22;
            this.lb_speciality.Text = "Specialty:";
            // 
            // lb_workingday
            // 
            this.lb_workingday.AutoSize = true;
            this.lb_workingday.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_workingday.Location = new System.Drawing.Point(32, 143);
            this.lb_workingday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_workingday.Name = "lb_workingday";
            this.lb_workingday.Size = new System.Drawing.Size(116, 21);
            this.lb_workingday.TabIndex = 21;
            this.lb_workingday.Text = "Working days:";
            // 
            // btn_Reload
            // 
            this.btn_Reload.Location = new System.Drawing.Point(698, 102);
            this.btn_Reload.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Reload.Name = "btn_Reload";
            this.btn_Reload.Size = new System.Drawing.Size(127, 44);
            this.btn_Reload.TabIndex = 44;
            this.btn_Reload.Text = "Reload";
            this.btn_Reload.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(357, 57);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(27, 29);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 48;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(357, 94);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(27, 29);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 47;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(467, 137);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 46;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(357, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // uc_Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Reload);
            this.Controls.Add(this.btn_Change);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.dgv_Doctors);
            this.Controls.Add(this.cb_speciality);
            this.Controls.Add(this.txt_working);
            this.Controls.Add(this.txt_fullname);
            this.Controls.Add(this.txt_doctor);
            this.Controls.Add(this.lb_doctor);
            this.Controls.Add(this.lb_fullname);
            this.Controls.Add(this.lb_speciality);
            this.Controls.Add(this.lb_workingday);
            this.Name = "uc_Doctor";
            this.Size = new System.Drawing.Size(825, 541);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Doctors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Change;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.DataGridView dgv_Doctors;
        private System.Windows.Forms.ComboBox cb_speciality;
        private System.Windows.Forms.TextBox txt_working;
        private System.Windows.Forms.TextBox txt_fullname;
        private System.Windows.Forms.TextBox txt_doctor;
        private System.Windows.Forms.Label lb_doctor;
        private System.Windows.Forms.Label lb_fullname;
        private System.Windows.Forms.Label lb_speciality;
        private System.Windows.Forms.Label lb_workingday;
        private System.Windows.Forms.Button btn_Reload;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}
