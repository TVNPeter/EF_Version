using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Version.DAL
{
    internal class DALAppointment
    {
        ClinicContext context = new ClinicContext();
        public List<Appointment> GetAppointments()
        {
            return context.Appointments.Where(a => a.IsDeleted != true).ToList();
        }
        public Appointment GetAppointmentById(int id)
        {
            return context.Appointments.FirstOrDefault(a => a.AppointmentID == id && a.IsDeleted != true);
        }
        public List<Appointment> GetAppointmentsByPatientId(int patientId)
        {
            return context.Appointments.Where(a => a.PatientID == patientId && a.IsDeleted != true).ToList();
        }
        public List<Appointment> GetAppointmentsByDoctorId(int doctorId)
        {
            return context.Appointments.Where(a => a.DoctorID == doctorId && a.IsDeleted != true).ToList();
        }
        public List<Appointment> GetAppointmentsByDate(DateTime date)
        {
            return context.Appointments.Where(a => a.AppointmentDate.Date == date.Date && a.IsDeleted != true).ToList();
        }
        public void AddAppointment(Appointment appointment)
        {
            context.Appointments.Add(appointment);
            context.SaveChanges();
        }
        public void UpdateAppointment(Appointment appointment)
        {
            var existingAppointment = context.Appointments.Find(appointment.AppointmentID);
            if (existingAppointment != null)
            {
                existingAppointment.Status = appointment.Status;
                context.SaveChanges();
            }
        }
        public void DeleteAppointment(int id)
        {
            var appointment = context.Appointments.Find(id);
            if (appointment != null)
            {
                appointment.IsDeleted = true; // Soft delete
                context.SaveChanges();
            }
        }
    }
}
