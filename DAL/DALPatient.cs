using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Version.DAL
{
    internal class DALPatient
    {
        ClinicContext context = new ClinicContext();
        public List<Patient> GetPatients()
        {
            return context.Patients.Where(p => p.IsDeleted != true).ToList();
        }
        public Patient GetPatientById(int id)
        {
            return context.Patients.FirstOrDefault(p => p.PatientID == id && p.IsDeleted != true);
        }
        public List<Patient> GetPatientsByName(string name)
        {
            return context.Patients.Where(p => p.FullName.Contains(name) && p.IsDeleted != true).ToList();
        }
        public void AddPatient(Patient patient)
        {
            context.Patients.Add(patient);
            context.SaveChanges();
        }
        public void UpdatePatient(Patient patient)
        {
            var existingPatient = context.Patients.Find(patient.PatientID);
            if (existingPatient != null)
            {
                existingPatient.FullName = patient.FullName;
                existingPatient.Gender = patient.Gender;
                existingPatient.Address = patient.Address;
                existingPatient.Phone = patient.Phone;
                existingPatient.BirthDate = patient.BirthDate;
            }
        }
        public void DeletePatient(int id)
        {
            var patient = context.Patients.Find(id);
            if (patient != null)
            {
                patient.IsDeleted = true; // Soft delete
                context.SaveChanges();
            }
        }
    }
}
