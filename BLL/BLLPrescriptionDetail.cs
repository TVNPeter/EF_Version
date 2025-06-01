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
        DALPrescriptionDetail repo = new DALPrescriptionDetail();

        public bool Add(PrescriptionDetail pd, out string err)
        {
            try
            {
                repo.AddPrescriptionDetail(pd);
                err = string.Empty;
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }
        public bool Update(PrescriptionDetail pd, out string err)
        {
            try
            {
                repo.UpdatePrescriptionDetail(pd);
                err = string.Empty;
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }
        public bool Delete(int PID, int MID, out string err)
        {
            try
            {
                repo.DeletePrescriptionDetail(PID, MID);
                err = string.Empty;
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }
        public PrescriptionDetail GetById(int PID, int MID, out string err)
        {
            try
            {
                var detail = repo.GetPrescriptionDetailById(PID, MID);
                if (detail == null)
                    throw new Exception("Prescription detail not found.");

                err = string.Empty;
                return detail;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return null;
            }
        }
        public PrescriptionDetail GetByPrescriptionAndMedicineId(int PID, int MID, out string err)
        {
            try
            {
                var detail = repo.GetPrescriptionDetailById(PID, MID);
                if (detail == null)
                    throw new Exception("Prescription detail not found.");
                err = string.Empty;
                return detail;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return null;
            }
        }
        public double CalculateTotalMedicationCost(int PreID, out string err)
        {
            try
            {
                using (var context = new ClinicContext())
                {
                    var totalCost = context.PrescriptionDetails
                        .Where(pd => pd.PrescriptionID == PreID)
                        .Sum(pd => pd.Quantity * pd.Medicine.Price);

                    err = string.Empty;
                    return totalCost;
                }
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return 0.0;
            }
        }
        public List<PrescriptionDetail> GetByPrescriptionId(int PreID, out string err)
        {
            try
            {
                err = string.Empty;
                return repo.GetPrescriptionDetailsByPrescriptionId(PreID);
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return null;
            }
        }
    }
}
