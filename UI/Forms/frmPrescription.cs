using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EF_Version.BLL;

namespace EF_Version.Presentation.Forms
{
    public partial class frmPrescription : Form
    {
        private int PreID;
        private int AID;
        Prescription prescription;
        BLLPrescription service = new BLLPrescription();
        BLLPrescriptionDetail serviceDetail = new BLLPrescriptionDetail();
        List<Medication> medication = new List<Medication>();
        public frmPrescription()
        {
            InitializeComponent();
        }
        public frmPrescription(int aID)
        {
            InitializeComponent();
            AID = aID;
            prescription = service.GetByAppointmentId(AID, out string err);
            PreID = prescription.PrescriptionID;
            txt_AID.Text = AID.ToString();
            txt_PID.Text = PreID.ToString();
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Note.Text) || string.IsNullOrWhiteSpace(txt_Diagnosis.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            prescription.Notes = txt_Note.Text;
            prescription.Diagnosis = txt_Diagnosis.Text;
            prescription.DateIssued = DateTime.Now;
            string err;
            try
            {
                bool success = service.Update(prescription, out err);
                if (success)
                {
                    MessageBox.Show("Prescription updated successfully.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"Error updating prescription: {err}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void btn_RemoveMedicine_Click(object sender, EventArgs e)
        {
            if (dgv_Medication.CurrentRow == null) return;
            int r = dgv_Medication.CurrentCell.RowIndex;
        }

        private void btn_AddMedicine_Click(object sender, EventArgs e)
        {
            frmAddMedicines addMedicinesForm = new frmAddMedicines(medication, PreID);
            addMedicinesForm.ShowDialog();
        }
        private void LoadData()
        {
            try
            {
                dgv_Medication.AutoGenerateColumns = false;

                dgv_Medication.Columns[0].DataPropertyName = "PrescriptionID";
                dgv_Medication.Columns[1].DataPropertyName = "MedicineID";
                dgv_Medication.Columns[2].DataPropertyName = "MedicineName";
                dgv_Medication.Columns[3].DataPropertyName = "Dosage";
                dgv_Medication.Columns[4].DataPropertyName = "Quantity";
                dgv_Medication.Columns[5].DataPropertyName = "Frequency";

                dgv_Medication.DataSource = medication;
                dgv_Medication.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmPrescription_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_Reload_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
