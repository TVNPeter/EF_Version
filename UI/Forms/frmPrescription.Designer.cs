namespace EF_Version.Presentation.Forms
{
    partial class frmPrescription
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
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.dgv_Medications = new System.Windows.Forms.DataGridView();
            this.txt_AID = new System.Windows.Forms.TextBox();
            this.txt_diagnosis = new System.Windows.Forms.TextBox();
            this.txt_note = new System.Windows.Forms.TextBox();
            this.txt_PID = new System.Windows.Forms.TextBox();
            this.lb_prescription = new System.Windows.Forms.Label();
            this.lb_appointment = new System.Windows.Forms.Label();
            this.lb_diagnosis = new System.Windows.Forms.Label();
            this.lb_note = new System.Windows.Forms.Label();
            this.btn_AddMedicine = new System.Windows.Forms.Button();
            this.btn_RemoveMedicine = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Medications)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(356, 330);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(65, 38);
            this.btn_Cancel.TabIndex = 34;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(131, 326);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(65, 42);
            this.btn_Save.TabIndex = 33;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // dgv_Medications
            // 
            this.dgv_Medications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Medications.Location = new System.Drawing.Point(8, 101);
            this.dgv_Medications.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_Medications.Name = "dgv_Medications";
            this.dgv_Medications.RowHeadersWidth = 51;
            this.dgv_Medications.RowTemplate.Height = 24;
            this.dgv_Medications.Size = new System.Drawing.Size(584, 222);
            this.dgv_Medications.TabIndex = 32;
            // 
            // txt_AID
            // 
            this.txt_AID.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_AID.Location = new System.Drawing.Point(163, 37);
            this.txt_AID.Margin = new System.Windows.Forms.Padding(2);
            this.txt_AID.Name = "txt_AID";
            this.txt_AID.ReadOnly = true;
            this.txt_AID.Size = new System.Drawing.Size(81, 20);
            this.txt_AID.TabIndex = 31;
            // 
            // txt_diagnosis
            // 
            this.txt_diagnosis.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_diagnosis.Location = new System.Drawing.Point(319, 6);
            this.txt_diagnosis.Margin = new System.Windows.Forms.Padding(2);
            this.txt_diagnosis.Name = "txt_diagnosis";
            this.txt_diagnosis.Size = new System.Drawing.Size(270, 20);
            this.txt_diagnosis.TabIndex = 30;
            // 
            // txt_note
            // 
            this.txt_note.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_note.Location = new System.Drawing.Point(79, 71);
            this.txt_note.Margin = new System.Windows.Forms.Padding(2);
            this.txt_note.Name = "txt_note";
            this.txt_note.Size = new System.Drawing.Size(513, 20);
            this.txt_note.TabIndex = 28;
            // 
            // txt_PID
            // 
            this.txt_PID.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_PID.Location = new System.Drawing.Point(150, 8);
            this.txt_PID.Margin = new System.Windows.Forms.Padding(2);
            this.txt_PID.Name = "txt_PID";
            this.txt_PID.ReadOnly = true;
            this.txt_PID.Size = new System.Drawing.Size(81, 20);
            this.txt_PID.TabIndex = 27;
            // 
            // lb_prescription
            // 
            this.lb_prescription.AutoSize = true;
            this.lb_prescription.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_prescription.Location = new System.Drawing.Point(22, 7);
            this.lb_prescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_prescription.Name = "lb_prescription";
            this.lb_prescription.Size = new System.Drawing.Size(124, 21);
            this.lb_prescription.TabIndex = 26;
            this.lb_prescription.Text = "Prescription ID:";
            // 
            // lb_appointment
            // 
            this.lb_appointment.AutoSize = true;
            this.lb_appointment.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_appointment.Location = new System.Drawing.Point(22, 39);
            this.lb_appointment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_appointment.Name = "lb_appointment";
            this.lb_appointment.Size = new System.Drawing.Size(142, 21);
            this.lb_appointment.TabIndex = 25;
            this.lb_appointment.Text = "Appointment ID:";
            // 
            // lb_diagnosis
            // 
            this.lb_diagnosis.AutoSize = true;
            this.lb_diagnosis.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_diagnosis.Location = new System.Drawing.Point(236, 6);
            this.lb_diagnosis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_diagnosis.Name = "lb_diagnosis";
            this.lb_diagnosis.Size = new System.Drawing.Size(86, 21);
            this.lb_diagnosis.TabIndex = 24;
            this.lb_diagnosis.Text = "Diagnosis:";
            // 
            // lb_note
            // 
            this.lb_note.AutoSize = true;
            this.lb_note.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_note.Location = new System.Drawing.Point(26, 71);
            this.lb_note.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_note.Name = "lb_note";
            this.lb_note.Size = new System.Drawing.Size(53, 21);
            this.lb_note.TabIndex = 22;
            this.lb_note.Text = "Note:";
            // 
            // btn_AddMedicine
            // 
            this.btn_AddMedicine.Location = new System.Drawing.Point(254, 37);
            this.btn_AddMedicine.Margin = new System.Windows.Forms.Padding(2);
            this.btn_AddMedicine.Name = "btn_AddMedicine";
            this.btn_AddMedicine.Size = new System.Drawing.Size(105, 25);
            this.btn_AddMedicine.TabIndex = 35;
            this.btn_AddMedicine.Text = "Add Medicine";
            this.btn_AddMedicine.UseVisualStyleBackColor = true;
            // 
            // btn_RemoveMedicine
            // 
            this.btn_RemoveMedicine.Location = new System.Drawing.Point(407, 38);
            this.btn_RemoveMedicine.Margin = new System.Windows.Forms.Padding(2);
            this.btn_RemoveMedicine.Name = "btn_RemoveMedicine";
            this.btn_RemoveMedicine.Size = new System.Drawing.Size(105, 25);
            this.btn_RemoveMedicine.TabIndex = 36;
            this.btn_RemoveMedicine.Text = "Remove Medicine";
            this.btn_RemoveMedicine.UseVisualStyleBackColor = true;
            // 
            // frmPrescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 387);
            this.Controls.Add(this.btn_RemoveMedicine);
            this.Controls.Add(this.btn_AddMedicine);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.dgv_Medications);
            this.Controls.Add(this.txt_AID);
            this.Controls.Add(this.txt_diagnosis);
            this.Controls.Add(this.txt_note);
            this.Controls.Add(this.txt_PID);
            this.Controls.Add(this.lb_prescription);
            this.Controls.Add(this.lb_appointment);
            this.Controls.Add(this.lb_diagnosis);
            this.Controls.Add(this.lb_note);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPrescription";
            this.Text = "frmPrescription";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Medications)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.DataGridView dgv_Medications;
        private System.Windows.Forms.TextBox txt_AID;
        private System.Windows.Forms.TextBox txt_diagnosis;
        private System.Windows.Forms.TextBox txt_note;
        private System.Windows.Forms.TextBox txt_PID;
        private System.Windows.Forms.Label lb_prescription;
        private System.Windows.Forms.Label lb_appointment;
        private System.Windows.Forms.Label lb_diagnosis;
        private System.Windows.Forms.Label lb_note;
        private System.Windows.Forms.Button btn_AddMedicine;
        private System.Windows.Forms.Button btn_RemoveMedicine;
    }
}