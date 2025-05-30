namespace EF_Version.Presentation.Usercontrol
{
    partial class uc_Patient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_Patient));
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Change = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.dgv_Patients = new System.Windows.Forms.DataGridView();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.dTP_BD = new System.Windows.Forms.DateTimePicker();
            this.cb_gender = new System.Windows.Forms.ComboBox();
            this.txt_fullname = new System.Windows.Forms.TextBox();
            this.txt_patient = new System.Windows.Forms.TextBox();
            this.lb_address = new System.Windows.Forms.Label();
            this.lb_birthday = new System.Windows.Forms.Label();
            this.lb_gender = new System.Windows.Forms.Label();
            this.lb_fullname = new System.Windows.Forms.Label();
            this.lb_patient = new System.Windows.Forms.Label();
            this.btn_Reload = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Patients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(474, 15);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(92, 37);
            this.btn_Delete.TabIndex = 31;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(513, 94);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(81, 45);
            this.btn_Save.TabIndex = 30;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(711, 21);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(80, 32);
            this.btn_Cancel.TabIndex = 29;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // btn_Change
            // 
            this.btn_Change.Location = new System.Drawing.Point(598, 102);
            this.btn_Change.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Change.Name = "btn_Change";
            this.btn_Change.Size = new System.Drawing.Size(79, 29);
            this.btn_Change.TabIndex = 28;
            this.btn_Change.Text = "Change";
            this.btn_Change.UseVisualStyleBackColor = true;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(598, 15);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(86, 33);
            this.btn_Add.TabIndex = 27;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            // 
            // dgv_Patients
            // 
            this.dgv_Patients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Patients.Location = new System.Drawing.Point(41, 234);
            this.dgv_Patients.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_Patients.Name = "dgv_Patients";
            this.dgv_Patients.RowHeadersWidth = 51;
            this.dgv_Patients.RowTemplate.Height = 24;
            this.dgv_Patients.Size = new System.Drawing.Size(750, 288);
            this.dgv_Patients.TabIndex = 26;
            // 
            // txt_Address
            // 
            this.txt_Address.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_Address.Location = new System.Drawing.Point(161, 188);
            this.txt_Address.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(443, 22);
            this.txt_Address.TabIndex = 25;
            // 
            // dTP_BD
            // 
            this.dTP_BD.Location = new System.Drawing.Point(167, 148);
            this.dTP_BD.Margin = new System.Windows.Forms.Padding(2);
            this.dTP_BD.Name = "dTP_BD";
            this.dTP_BD.Size = new System.Drawing.Size(238, 22);
            this.dTP_BD.TabIndex = 24;
            // 
            // cb_gender
            // 
            this.cb_gender.FormattingEnabled = true;
            this.cb_gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cb_gender.Location = new System.Drawing.Point(169, 107);
            this.cb_gender.Margin = new System.Windows.Forms.Padding(2);
            this.cb_gender.Name = "cb_gender";
            this.cb_gender.Size = new System.Drawing.Size(105, 24);
            this.cb_gender.TabIndex = 23;
            // 
            // txt_fullname
            // 
            this.txt_fullname.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_fullname.Location = new System.Drawing.Point(169, 64);
            this.txt_fullname.Margin = new System.Windows.Forms.Padding(2);
            this.txt_fullname.Name = "txt_fullname";
            this.txt_fullname.Size = new System.Drawing.Size(292, 22);
            this.txt_fullname.TabIndex = 22;
            // 
            // txt_patient
            // 
            this.txt_patient.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_patient.Location = new System.Drawing.Point(169, 23);
            this.txt_patient.Margin = new System.Windows.Forms.Padding(2);
            this.txt_patient.Name = "txt_patient";
            this.txt_patient.Size = new System.Drawing.Size(90, 22);
            this.txt_patient.TabIndex = 21;
            // 
            // lb_address
            // 
            this.lb_address.AutoSize = true;
            this.lb_address.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_address.Location = new System.Drawing.Point(37, 186);
            this.lb_address.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_address.Name = "lb_address";
            this.lb_address.Size = new System.Drawing.Size(76, 21);
            this.lb_address.TabIndex = 20;
            this.lb_address.Text = "Address:";
            // 
            // lb_birthday
            // 
            this.lb_birthday.AutoSize = true;
            this.lb_birthday.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_birthday.Location = new System.Drawing.Point(37, 146);
            this.lb_birthday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_birthday.Name = "lb_birthday";
            this.lb_birthday.Size = new System.Drawing.Size(88, 21);
            this.lb_birthday.TabIndex = 19;
            this.lb_birthday.Text = "BirthDate:";
            // 
            // lb_gender
            // 
            this.lb_gender.AutoSize = true;
            this.lb_gender.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_gender.Location = new System.Drawing.Point(37, 106);
            this.lb_gender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_gender.Name = "lb_gender";
            this.lb_gender.Size = new System.Drawing.Size(74, 21);
            this.lb_gender.TabIndex = 18;
            this.lb_gender.Text = "Gender:";
            // 
            // lb_fullname
            // 
            this.lb_fullname.AutoSize = true;
            this.lb_fullname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_fullname.Location = new System.Drawing.Point(37, 63);
            this.lb_fullname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_fullname.Name = "lb_fullname";
            this.lb_fullname.Size = new System.Drawing.Size(90, 21);
            this.lb_fullname.TabIndex = 17;
            this.lb_fullname.Text = "Full Name:";
            // 
            // lb_patient
            // 
            this.lb_patient.AutoSize = true;
            this.lb_patient.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_patient.Location = new System.Drawing.Point(37, 21);
            this.lb_patient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_patient.Name = "lb_patient";
            this.lb_patient.Size = new System.Drawing.Size(92, 21);
            this.lb_patient.TabIndex = 16;
            this.lb_patient.Text = "Patient ID:";
            // 
            // btn_Reload
            // 
            this.btn_Reload.Location = new System.Drawing.Point(711, 106);
            this.btn_Reload.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Reload.Name = "btn_Reload";
            this.btn_Reload.Size = new System.Drawing.Size(87, 33);
            this.btn_Reload.TabIndex = 44;
            this.btn_Reload.Text = "Reload";
            this.btn_Reload.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(263, 19);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(474, 64);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 47;
            this.pictureBox2.TabStop = false;
            // 
            // uc_Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Reload);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Change);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.dgv_Patients);
            this.Controls.Add(this.txt_Address);
            this.Controls.Add(this.dTP_BD);
            this.Controls.Add(this.cb_gender);
            this.Controls.Add(this.txt_fullname);
            this.Controls.Add(this.txt_patient);
            this.Controls.Add(this.lb_address);
            this.Controls.Add(this.lb_birthday);
            this.Controls.Add(this.lb_gender);
            this.Controls.Add(this.lb_fullname);
            this.Controls.Add(this.lb_patient);
            this.Name = "uc_Patient";
            this.Size = new System.Drawing.Size(825, 541);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Patients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Change;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.DataGridView dgv_Patients;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.DateTimePicker dTP_BD;
        private System.Windows.Forms.ComboBox cb_gender;
        private System.Windows.Forms.TextBox txt_fullname;
        private System.Windows.Forms.TextBox txt_patient;
        private System.Windows.Forms.Label lb_address;
        private System.Windows.Forms.Label lb_birthday;
        private System.Windows.Forms.Label lb_gender;
        private System.Windows.Forms.Label lb_fullname;
        private System.Windows.Forms.Label lb_patient;
        private System.Windows.Forms.Button btn_Reload;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
