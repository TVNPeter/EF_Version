using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Version.DAL
{
    internal class DALMedicine
    {
        private ClinicContext context = new ClinicContext();
        public List<Medicine> GetMedicines()
        {
            return context.Medicines.Where(m => m.IsDeleted != true).ToList();
        }
        public Medicine GetMedicineById(int id)
        {
            return context.Medicines.FirstOrDefault(m => m.MedicineID == id && m.IsDeleted != true);
        }
        public List<Medicine> GetMedicinesByName(string name)
        {
            return context.Medicines.Where(m => m.Name.Contains(name) && m.IsDeleted != true).ToList();
        }
        public void AddMedicine(Medicine medicine)
        {
            context.Medicines.Add(medicine);
            context.SaveChanges();
        }
        public void UpdateMedicine(Medicine medicine)
        {
            var existingMedicine = context.Medicines.Find(medicine.MedicineID);
            if (existingMedicine != null)
            {
                existingMedicine.Name = medicine.Name;
                existingMedicine.Dosage = medicine.Dosage;
                existingMedicine.Price = medicine.Price;
                context.SaveChanges();
            }
        }
        public void DeleteMedicine(int id)
        {
            var medicine = context.Medicines.Find(id);
            if (medicine != null)
            {
                medicine.IsDeleted = true; // Soft delete
                context.SaveChanges();
            }
        }
    }
}
