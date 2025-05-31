using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_Version.DAL;
namespace EF_Version.BLL
{
    internal class BLLDoctor
    {
        DALDoctor repo = new DALDoctor();
        public bool Add(Doctor d, out string err)
        {
            try
            {
                repo.AddDoctor(d);
                err = string.Empty;
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }
        public bool Update(Doctor d, out string err)
        {
            try
            {
                repo.UpdateDoctor(d);
                err = string.Empty;
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }
        public bool Delete(int id, out string err)
        {
            try
            {
                repo.DeleteDoctor(id);
                err = string.Empty;
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }
        public List<Doctor> GetAll(out string err)
        {
            try
            {
                err = string.Empty;
                return repo.GetDoctors();
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return null;
            }
        }
        public Doctor GetById(int id, out string err)
        {
            try
            {
                err = string.Empty;
                return repo.GetDoctorById(id);
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return null;
            }
        }
        public List<Doctor> GetBySpecialty(string specialty, out string err)
        {
            try
            {
                err = string.Empty;
                return repo.GetDoctorsBySpecialty(specialty);
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return null;
            }
        }
        public List<Doctor> GetByName(string name, out string err)
        {
            try
            {
                err = string.Empty;
                return repo.GetDoctorsByName(name);
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return null;
            }
        }
    }
}
