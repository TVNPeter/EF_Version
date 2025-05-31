namespace EF_Version.Presentation.Usercontrol
{
    partial class uc_Appointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_Appointment));
            this.dgv_Appointments = new System.Windows.Forms.DataGridView();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.cb_patientid = new System.Windows.Forms.ComboBox();
            this.txt_appointment = new System.Windows.Forms.TextBox();
            this.lb_appointments = new System.Windows.Forms.Label();
            this.lb_patient = new System.Windows.Forms.Label();
            this.cb_doctorid = new System.Windows.Forms.Label();
            this.lb_appointment = new System.Windows.Forms.Label();
            this.btn_Reload = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_Status = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Appointments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Appointments
            // 
            this.dgv_Appointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Appointments.Location = new System.Drawing.Point(16, 144);
            this.dgv_Appointments.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_Appointments.Name = "dgv_Appointments";
            this.dgv_Appointments.RowHeadersWidth = 51;
            this.dgv_Appointments.RowTemplate.Height = 24;
            this.dgv_Appointments.Size = new System.Drawing.Size(580, 275);
            this.dgv_Appointments.TabIndex = 42;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(424, 47);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(58, 36);
            this.btn_Add.TabIndex = 38;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(501, 47);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(58, 36);
            this.btn_Delete.TabIndex = 37;
            this.btn_Delete.Text = "Cancel";
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(193, 106);
            this.date.Margin = new System.Windows.Forms.Padding(2);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(180, 20);
            this.date.TabIndex = 36;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(129, 75);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(70, 21);
            this.comboBox3.TabIndex = 35;
            // 
            // cb_patientid
            // 
            this.cb_patientid.FormattingEnabled = true;
            this.cb_patientid.Location = new System.Drawing.Point(129, 47);
            this.cb_patientid.Margin = new System.Windows.Forms.Padding(2);
            this.cb_patientid.Name = "cb_patientid";
            this.cb_patientid.Size = new System.Drawing.Size(70, 21);
            this.cb_patientid.TabIndex = 33;
            // 
            // txt_appointment
            // 
            this.txt_appointment.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_appointment.Location = new System.Drawing.Point(167, 19);
            this.txt_appointment.Margin = new System.Windows.Forms.Padding(2);
            this.txt_appointment.Name = "txt_appointment";
            this.txt_appointment.Size = new System.Drawing.Size(86, 20);
            this.txt_appointment.TabIndex = 31;
            // 
            // lb_appointments
            // 
            this.lb_appointments.AutoSize = true;
            this.lb_appointments.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_appointments.Location = new System.Drawing.Point(26, 18);
            this.lb_appointments.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_appointments.Name = "lb_appointments";
            this.lb_appointments.Size = new System.Drawing.Size(142, 21);
            this.lb_appointments.TabIndex = 30;
            this.lb_appointments.Text = "Appointment ID:";
            // 
            // lb_patient
            // 
            this.lb_patient.AutoSize = true;
            this.lb_patient.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_patient.Location = new System.Drawing.Point(26, 46);
            this.lb_patient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_patient.Name = "lb_patient";
            this.lb_patient.Size = new System.Drawing.Size(92, 21);
            this.lb_patient.TabIndex = 29;
            this.lb_patient.Text = "Patient ID:";
            // 
            // cb_doctorid
            // 
            this.cb_doctorid.AutoSize = true;
            this.cb_doctorid.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_doctorid.Location = new System.Drawing.Point(26, 76);
            this.cb_doctorid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cb_doctorid.Name = "cb_doctorid";
            this.cb_doctorid.Size = new System.Drawing.Size(89, 21);
            this.cb_doctorid.TabIndex = 28;
            this.cb_doctorid.Text = "Doctor ID:";
            // 
            // lb_appointment
            // 
            this.lb_appointment.AutoSize = true;
            this.lb_appointment.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_appointment.Location = new System.Drawing.Point(26, 106);
            this.lb_appointment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_appointment.Name = "lb_appointment";
            this.lb_appointment.Size = new System.Drawing.Size(164, 21);
            this.lb_appointment.TabIndex = 27;
            this.lb_appointment.Text = "Appointment date:";
            // 
            // btn_Reload
            // 
            this.btn_Reload.Location = new System.Drawing.Point(424, 90);
            this.btn_Reload.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Reload.Name = "btn_Reload";
            this.btn_Reload.Size = new System.Drawing.Size(135, 36);
            this.btn_Reload.TabIndex = 43;
            this.btn_Reload.Text = "Reload";
            this.btn_Reload.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(375, 100);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(268, 19);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 47;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(203, 44);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 48;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(203, 75);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(20, 24);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 49;
            this.pictureBox4.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(398, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 21);
            this.label1.TabIndex = 50;
            this.label1.Text = "Status:";
            // 
            // cb_Status
            // 
            this.cb_Status.FormattingEnabled = true;
            this.cb_Status.Items.AddRange(new object[] {
            "Scheduled",
            "Cancelled",
            "Completed"});
            this.cb_Status.Location = new System.Drawing.Point(478, 15);
            this.cb_Status.Margin = new System.Windows.Forms.Padding(2);
            this.cb_Status.Name = "cb_Status";
            this.cb_Status.Size = new System.Drawing.Size(70, 21);
            this.cb_Status.TabIndex = 51;
            // 
            // uc_Appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cb_Status);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Reload);
            this.Controls.Add(this.dgv_Appointments);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.date);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.cb_patientid);
            this.Controls.Add(this.txt_appointment);
            this.Controls.Add(this.lb_appointments);
            this.Controls.Add(this.lb_patient);
            this.Controls.Add(this.cb_doctorid);
            this.Controls.Add(this.lb_appointment);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "uc_Appointment";
            this.Size = new System.Drawing.Size(619, 440);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Appointments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Appointments;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox cb_patientid;
        private System.Windows.Forms.TextBox txt_appointment;
        private System.Windows.Forms.Label lb_appointments;
        private System.Windows.Forms.Label lb_patient;
        private System.Windows.Forms.Label cb_doctorid;
        private System.Windows.Forms.Label lb_appointment;
        private System.Windows.Forms.Button btn_Reload;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_Status;
    }
}
