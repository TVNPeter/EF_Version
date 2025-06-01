using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Version.DAL
{
    internal class DALDoctor
    {
        private ClinicContext context = new ClinicContext();
        public int GetLastDoctorId()
        {
            return context.Doctors.Any() ? context.Doctors.Max(d => d.DoctorID) : 0;
        }
        public List<Doctor> GetDoctors()
        {
            return context.Doctors.Where(d => d.IsDeleted != true).ToList();
        }
        public Doctor GetDoctorById(int id)
        {
            return context.Doctors.FirstOrDefault(d => d.DoctorID == id && d.IsDeleted != true);
        }
        public List<Doctor> GetDoctorsBySpecialty(string specialty)
        {
            return context.Doctors.Where(d => d.Specialty == specialty && d.IsDeleted != true).ToList();
        }
        public List<Doctor> GetDoctorsByName(string name)
        {
            return context.Doctors.Where(d => d.FullName.Contains(name) && d.IsDeleted != true).ToList();
        }
        public int AddDoctor(Doctor doctor)
        {
            context.Doctors.Add(doctor);
            context.SaveChanges();
            return doctor.DoctorID;
        }
        public void UpdateDoctor(Doctor doctor)
        {
            var existingDoctor = context.Doctors.Find(doctor.DoctorID);
            if (existingDoctor != null)
            {
                existingDoctor.FullName = doctor.FullName;
                existingDoctor.Specialty = doctor.Specialty;
                existingDoctor.Phone = doctor.Phone;
                context.SaveChanges();
            }
        }
        public void DeleteDoctor(int id)
        {
            var doctor = context.Doctors.Find(id);
            if (doctor != null)
            {
                doctor.IsDeleted = true; // Soft delete
                context.SaveChanges();
            }
        }
    }
}
