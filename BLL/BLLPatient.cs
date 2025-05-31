using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_Version.DAL; 

namespace EF_Version.BLL
{
    internal class BLLPatient
    {
        DAL.DALPatient repo = new DAL.DALPatient();
        public bool Add(Patient p, out string err)
        {
            try
            {
                repo.AddPatient(p);
                err = string.Empty;
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }
        public bool Update(Patient p, out string err)
        {
            try
            {
                repo.UpdatePatient(p);
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
                repo.DeletePatient(id);
                err = string.Empty;
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }
        public List<Patient> GetAll(out string err)
        {
            try
            {
                err = string.Empty;
                return repo.GetPatients();
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return new List<Patient>();
            }
        }
        public Patient GetById(int id, out string err)
        {
            try
            {
                err = string.Empty;
                return repo.GetPatientById(id);
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return null;
            }
        }
        public List<Patient> GetByName(string name, out string err)
        {
            try
            {
                err = string.Empty;
                return repo.GetPatientsByName(name);
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return new List<Patient>();
            }
        }
    }
}
