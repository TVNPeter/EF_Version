using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Version.DAL
{
    internal class DALPrescription
    {
        ClinicContext context = new ClinicContext();
        public Prescription GetPrescriptionById(int id)
        {
            return context.Prescriptions.FirstOrDefault(p => p.PrescriptionID == id && p.IsDeleted != true);
        }
        public Prescription GetPrescriptionsByAppointmentId(int appointmentId)
        {
            return context.Prescriptions.FirstOrDefault(p => p.AppointmentID == appointmentId && p.IsDeleted != true);
        }
        public void AddPrescription(Prescription prescription)
        {
            if (prescription == null) throw new ArgumentNullException(nameof(prescription));
            context.Prescriptions.Add(prescription);
            context.SaveChanges();
        }
        public void UpdatePrescription(Prescription prescription)
        {
            if (prescription == null) throw new ArgumentNullException(nameof(prescription));
            var existingPrescription = context.Prescriptions.FirstOrDefault(p => p.PrescriptionID == prescription.PrescriptionID && p.IsDeleted != true);
            if (existingPrescription != null)
            {
                existingPrescription.DateIssued = prescription.DateIssued;
                existingPrescription.Notes = prescription.Notes;
                existingPrescription.Diagnosis = prescription.Diagnosis;
                context.SaveChanges();
            }
        }
        public void DeletePrescription(int id)
        {
            var prescription = context.Prescriptions.FirstOrDefault(p => p.PrescriptionID == id && p.IsDeleted != true);
            if (prescription != null)
            {
                prescription.IsDeleted = true;
                context.SaveChanges();
            }
        }
    }
}
