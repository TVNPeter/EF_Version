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
    public partial class frmAddMedicines : Form
    {
        List<Medication> medication;
        int prepID;
        BLLPrescriptionDetail servicePrepDetail = new BLLPrescriptionDetail();
        BLLMedicine serviceMedicine = new BLLMedicine();
        public frmAddMedicines()
        {
            InitializeComponent();
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        }
        public frmAddMedicines(List<Medication> list, int PrepID)
        {
            InitializeComponent();
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            medication = list;
            prepID = PrepID;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            try
            {
                int mid = Convert.ToInt32(txt_MID.Text);
                int quantity = Convert.ToInt32(txt_Quantity.Text);
                string frequency = txt_Frequency.Text;
                string medName = txt_Name.Text;
                string dosage = txt_Dosage.Text;

                Medication newMedication = new Medication(prepID, mid, medName, dosage, quantity, frequency);
                medication.Add(newMedication);
                PrescriptionDetail newPrepDetail = new PrescriptionDetail
                {
                    PrescriptionID = prepID,
                    MedicineID = mid,
                    Quantity = quantity,
                    Frequency = frequency,
                    IsDeleted = false
                };
                string err;
                servicePrepDetail.Add(newPrepDetail, out err);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_Medicines_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Medicines.CurrentRow == null) return;
            int r = dgv_Medicines.CurrentCell.RowIndex;

            txt_MID.Text = dgv_Medicines.Rows[r].Cells[0].Value.ToString();
            txt_Name.Text = dgv_Medicines.Rows[r].Cells[1].Value.ToString();
            txt_Dosage.Text = dgv_Medicines.Rows[r].Cells[2].Value.ToString();
        }
        private void LoadData()
        {
            var data = serviceMedicine.GetAll(out string err);
            if (err != string.Empty)
            {
                MessageBox.Show($"Error loading medicines: {err}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dgv_Medicines.AutoGenerateColumns = false;

            dgv_Medicines.Columns[0].DataPropertyName = "MedicineID";
            dgv_Medicines.Columns[1].DataPropertyName = "Name";
            dgv_Medicines.Columns[2].DataPropertyName = "Dosage";
            dgv_Medicines.Columns[3].DataPropertyName = "Price";

            dgv_Medicines.DataSource = data;
            dgv_Medicines.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void frmAddMedicines_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
