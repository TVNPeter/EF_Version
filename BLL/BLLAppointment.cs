using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_Version.DAL;
namespace EF_Version.BLL
{
    internal class BLLAppointment
    {
        private DALAppointment repo = new DALAppointment();
        public bool Add(Appointment a, out string err)
        {
            try
            {
                repo.AddAppointment(a);
                err = string.Empty;
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }
        public bool Update(Appointment a, out string err)
        {
            try
            {
                repo.UpdateAppointment(a);
                err = string.Empty;
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }
        public List<Appointment> GetAll()
        {
            string err;
            try
            {
                err = string.Empty;
                return repo.GetAppointments();
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return null;
            }
        }
        public List<Appointment> GetByPatientID(int patientID, out string err)
        {
            try
            {
                err = string.Empty;
                return repo.GetAppointmentsByPatientId(patientID);
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return null;
            }
        }
        public List<Appointment> GetByDoctorID(int doctorID, out string err)
        {
            try
            {
                err = string.Empty;
                return repo.GetAppointmentsByDoctorId(doctorID);
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return null;
            }
        }
        public Appointment GetByID(int id, out string err)
        {
            try
            {
                err = string.Empty;
                return repo.GetAppointmentById(id);
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return null;
            }
        }
        public List<Appointment> GetByDate(DateTime date, out string err)
        {
            try
            {
                err = string.Empty;
                var appointments = repo.GetAppointmentsByDate(date);

                return appointments.OrderBy(a => a.AppointmentDate).ToList();
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return null;
            }
        }
        public bool UpdateFee(int appointmentId, double fee, out string err)
        {
            err = string.Empty;
            try
            {
                var appointment = repo.GetAppointmentById(appointmentId);
                if (appointment == null)
                {
                    err = "Appointment not found.";
                    return false;
                }

                appointment.Fee = fee;
                repo.UpdateAppointment(appointment);
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }
    }
}
