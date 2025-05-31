using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Version.DAL
{
    internal class DALPrescriptionDetail
    {
        private ClinicContext context = new ClinicContext();
        public PrescriptionDetail GetPrescriptionDetailById(int PID, int MID)
        {
            return context.PrescriptionDetails.FirstOrDefault(pd => pd.PrescriptionID == PID && pd.MedicineID == MID && pd.IsDeleted != true);
        }
        public void AddPrescriptionDetail(PrescriptionDetail prescriptionDetail)
        {
            if (prescriptionDetail == null) throw new ArgumentNullException(nameof(prescriptionDetail));
            context.PrescriptionDetails.Add(prescriptionDetail);
            context.SaveChanges();
        }
        public void UpdatePrescriptionDetail(PrescriptionDetail prescriptionDetail)
        {
            if (prescriptionDetail == null) throw new ArgumentNullException(nameof(prescriptionDetail));
            var existingPrescriptionDetail = context.PrescriptionDetails.FirstOrDefault(pd => pd.PrescriptionID == prescriptionDetail.PrescriptionID && pd.MedicineID == prescriptionDetail.MedicineID && pd.IsDeleted != true);
            if (existingPrescriptionDetail != null)
            {
                existingPrescriptionDetail.Quantity = prescriptionDetail.Quantity;
                existingPrescriptionDetail.Frequency = prescriptionDetail.Frequency;
                context.SaveChanges();
            }
        }
        public void DeletePrescriptionDetail(int PID, int MID)
        {
            var prescriptionDetail = context.PrescriptionDetails.FirstOrDefault(pd => pd.PrescriptionID == PID && pd.MedicineID == MID && pd.IsDeleted != true);
            if (prescriptionDetail != null)
            {
                prescriptionDetail.IsDeleted = true;
                context.SaveChanges();
            }
        }
    }
}
