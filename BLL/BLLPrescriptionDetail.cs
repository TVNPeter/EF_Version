using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_Version.DAL;
namespace EF_Version.BLL
{
    internal class BLLPrescriptionDetail
    {
        ClinicContext db = new ClinicContext();
        public List<PrescriptionDetail> GetByPrescriptionId(int prescriptionId, out string err)
        {
            err = string.Empty;
            try
            {
                return db.PrescriptionDetails.Where(pd => pd.PrescriptionID == prescriptionId && pd.IsDeleted != true).ToList();
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return new List<PrescriptionDetail>();
            }
        }
        public PrescriptionDetail GetByPrescriptionAndMedicineId(int prescriptionId, int medicineId, out string err)
        {
            err = string.Empty;
            try
            {
                return db.PrescriptionDetails.FirstOrDefault(pd => pd.PrescriptionID == prescriptionId && pd.MedicineID == medicineId);
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return null;
            }
        }
        public bool Add(PrescriptionDetail detail, out string err)
        {
            err = string.Empty;
            try
            {
                db.PrescriptionDetails.Add(detail);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }
        public bool Update(PrescriptionDetail detail, out string err)
        {
            err = string.Empty;
            try
            {
                var existingDetail = db.PrescriptionDetails.Find(detail.PrescriptionID, detail.MedicineID);
                if (existingDetail == null)
                {
                    err = "Prescription detail not found.";
                    return false;
                }
                existingDetail.Quantity = detail.Quantity;
                existingDetail.Frequency = detail.Frequency;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }
        public bool Delete(int prescriptionId, int medicineId, out string err)
        {
            err = string.Empty;
            try
            {
                var detail = db.PrescriptionDetails.Find(prescriptionId, medicineId);
                if (detail == null)
                {
                    err = "Prescription detail not found.";
                    return false;
                }
                detail.IsDeleted = true; // Soft delete
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }
        public double CalculateTotalMedicationCost(int prescriptionId, out string err)
        {
            err = string.Empty;
            try
            {
                // Ensure the Include method is accessible by using System.Data.Entity
                var details = db.PrescriptionDetails
                    .Where(pd => pd.PrescriptionID == prescriptionId && pd.IsDeleted != true)
                    .Include(pd => pd.Medicine) // Include Medicine details
                    .ToList();

                double totalCost = 0;
                foreach (var detail in details)
                {
                    if (detail.Medicine != null)
                    {
                        totalCost += detail.Medicine.Price * detail.Quantity;
                    }
                }

                return totalCost;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return 0;
            }
        }
    }
}
