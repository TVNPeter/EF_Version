namespace EF_Version.Presentation.Forms
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnl = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Hello = new System.Windows.Forms.Label();
            this.pb_Exit = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Appointments = new System.Windows.Forms.Button();
            this.btn_Doctor = new System.Windows.Forms.Button();
            this.btn_Patients = new System.Windows.Forms.Button();
            this.btn_Medicines = new System.Windows.Forms.Button();
            this.btn_DashBoard = new System.Windows.Forms.Button();
            this.btn_Secretary = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl
            // 
            this.pnl.Location = new System.Drawing.Point(0, 131);
            this.pnl.Margin = new System.Windows.Forms.Padding(4);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(1238, 846);
            this.pnl.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BlueViolet;
            this.panel1.Controls.Add(this.lbl_Hello);
            this.panel1.Controls.Add(this.pb_Exit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1238, 77);
            this.panel1.TabIndex = 3;
            // 
            // lbl_Hello
            // 
            this.lbl_Hello.AutoSize = true;
            this.lbl_Hello.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hello.Location = new System.Drawing.Point(820, 23);
            this.lbl_Hello.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Hello.Name = "lbl_Hello";
            this.lbl_Hello.Size = new System.Drawing.Size(47, 21);
            this.lbl_Hello.TabIndex = 25;
            this.lbl_Hello.Text = "Hello";
            // 
            // pb_Exit
            // 
            this.pb_Exit.Image = ((System.Drawing.Image)(resources.GetObject("pb_Exit.Image")));
            this.pb_Exit.Location = new System.Drawing.Point(1150, 0);
            this.pb_Exit.Margin = new System.Windows.Forms.Padding(4);
            this.pb_Exit.Name = "pb_Exit";
            this.pb_Exit.Size = new System.Drawing.Size(72, 63);
            this.pb_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Exit.TabIndex = 2;
            this.pb_Exit.TabStop = false;
            this.pb_Exit.Click += new System.EventHandler(this.pb_Exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(82, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "FIE\'s Clinic";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1240, 77);
            this.panel2.TabIndex = 4;
            // 
            // btn_Appointments
            // 
            this.btn_Appointments.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Appointments.Location = new System.Drawing.Point(692, 77);
            this.btn_Appointments.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Appointments.Name = "btn_Appointments";
            this.btn_Appointments.Size = new System.Drawing.Size(175, 58);
            this.btn_Appointments.TabIndex = 2;
            this.btn_Appointments.Text = "Appointments";
            this.btn_Appointments.UseVisualStyleBackColor = true;
            this.btn_Appointments.Click += new System.EventHandler(this.btn_Appointments_Click);
            // 
            // btn_Doctor
            // 
            this.btn_Doctor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Doctor.Location = new System.Drawing.Point(428, 77);
            this.btn_Doctor.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Doctor.Name = "btn_Doctor";
            this.btn_Doctor.Size = new System.Drawing.Size(125, 58);
            this.btn_Doctor.TabIndex = 1;
            this.btn_Doctor.Text = "Doctors";
            this.btn_Doctor.UseVisualStyleBackColor = true;
            this.btn_Doctor.Click += new System.EventHandler(this.btn_Doctor_Click);
            // 
            // btn_Patients
            // 
            this.btn_Patients.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Patients.Location = new System.Drawing.Point(240, 85);
            this.btn_Patients.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Patients.Name = "btn_Patients";
            this.btn_Patients.Size = new System.Drawing.Size(161, 58);
            this.btn_Patients.TabIndex = 0;
            this.btn_Patients.Text = "Patients";
            this.btn_Patients.UseVisualStyleBackColor = true;
            this.btn_Patients.Click += new System.EventHandler(this.btn_Patients_Click);
            // 
            // btn_Medicines
            // 
            this.btn_Medicines.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Medicines.Location = new System.Drawing.Point(966, 77);
            this.btn_Medicines.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Medicines.Name = "btn_Medicines";
            this.btn_Medicines.Size = new System.Drawing.Size(256, 58);
            this.btn_Medicines.TabIndex = 3;
            this.btn_Medicines.Text = "Medicines";
            this.btn_Medicines.UseVisualStyleBackColor = true;
            this.btn_Medicines.Click += new System.EventHandler(this.btn_Medicines_Click);
            // 
            // btn_DashBoard
            // 
            this.btn_DashBoard.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DashBoard.Location = new System.Drawing.Point(0, 77);
            this.btn_DashBoard.Margin = new System.Windows.Forms.Padding(4);
            this.btn_DashBoard.Name = "btn_DashBoard";
            this.btn_DashBoard.Size = new System.Drawing.Size(260, 58);
            this.btn_DashBoard.TabIndex = 1;
            this.btn_DashBoard.Text = "Dash Board";
            this.btn_DashBoard.UseVisualStyleBackColor = true;
            this.btn_DashBoard.Click += new System.EventHandler(this.btn_DashBoard_Click);
            // 
            // btn_Secretary
            // 
            this.btn_Secretary.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Secretary.Location = new System.Drawing.Point(549, 77);
            this.btn_Secretary.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Secretary.Name = "btn_Secretary";
            this.btn_Secretary.Size = new System.Drawing.Size(135, 58);
            this.btn_Secretary.TabIndex = 2;
            this.btn_Secretary.Text = "Secretary";
            this.btn_Secretary.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 979);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Secretary);
            this.Controls.Add(this.btn_DashBoard);
            this.Controls.Add(this.btn_Medicines);
            this.Controls.Add(this.btn_Patients);
            this.Controls.Add(this.btn_Appointments);
            this.Controls.Add(this.pnl);
            this.Controls.Add(this.btn_Doctor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.Button btn_Patients;
        private System.Windows.Forms.Button btn_Doctor;
        private System.Windows.Forms.Button btn_Appointments;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pb_Exit;
        private System.Windows.Forms.Label lbl_Hello;
        private System.Windows.Forms.Button btn_Medicines;
        private System.Windows.Forms.Button btn_DashBoard;
        private System.Windows.Forms.Button btn_Secretary;
    }
}