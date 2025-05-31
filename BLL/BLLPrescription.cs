using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_Version.DAL;
namespace EF_Version.BLL
{
    internal class BLLPrescription
    {
        private DALPrescription repo = new DALPrescription();
        public bool Update(Prescription p, out string err)
        {
            try
            {
                repo.UpdatePrescription(p);
                err = string.Empty;
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }
        public bool Add(Prescription p, out string err)
        {
            try
            {
                repo.AddPrescription(p);
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
                repo.DeletePrescription(id);
                err = string.Empty;
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }
        public Prescription GetById(int id, out string err)
        {
            try
            {
                err = string.Empty;
                return repo.GetPrescriptionById(id);
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return null;
            }
        }
    }
}
