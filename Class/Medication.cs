using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EF_Version
{
    public class Medication
    {
        public Medication() { }
        public Medication(int prescriptionId, int medicineId, string medicineName, string dosage, int quantity, string frequency)
        {
            PrescriptionID = prescriptionId;
            MedicineID = medicineId;
            MedicineName = medicineName;
            Dosage = dosage;
            Quantity = quantity;
            Frequency = frequency;
        }
        public int PrescriptionID { get; set; }
        public int MedicineID { get; set; }
        public string MedicineName { get; set; }
        public string Dosage { get; set; }
        public int Quantity { get; set; }
        public string Frequency { get; set; }
    }
}