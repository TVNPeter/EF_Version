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
            // Tính toán thời gian bắt đầu và kết thúc của ngày
            DateTime startDate = new DateTime(date.Year, date.Month, date.Day, 0, 0, 0);
            DateTime endDate = new DateTime(date.Year, date.Month, date.Day, 23, 59, 59);
            
            return context.Appointments
                .Where(a => a.AppointmentDate >= startDate && 
                            a.AppointmentDate <= endDate && 
                            a.IsDeleted != true)
                .ToList();
        }
        public void AddAppointment(Appointment appointment)
        {
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    context.Appointments.Add(appointment);
                    context.Prescriptions.Add(new Prescription
                    {
                        AppointmentID = appointment.AppointmentID,
                        DateIssued = DateTime.Now,
                        Notes = "",
                        Diagnosis = "",
                        IsDeleted = false
                    });
                    context.SaveChanges();
                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }
        public void UpdateAppointment(Appointment appointment)
        {
            var existingAppointment = context.Appointments.Find(appointment.AppointmentID);
            if (existingAppointment != null)
            {
                existingAppointment.Fee = appointment.Fee;
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
