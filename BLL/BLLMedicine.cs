using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_Version.DAL;
namespace EF_Version.BLL
{
    internal class BLLMedicine
    {
        DALMedicine repo = new DALMedicine();
        public bool Add(Medicine m, out string err)
        {
            try
            {
                repo.AddMedicine(m);
                err = string.Empty;
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }
        public bool Update(Medicine m, out string err)
        {
            try
            {
                repo.UpdateMedicine(m);
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
                repo.DeleteMedicine(id);
                err = string.Empty;
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }
        public List<Medicine> GetAll(out string err)
        {
            try
            {
                err = string.Empty;
                return repo.GetMedicines();
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return new List<Medicine>();
            }
        }
        public Medicine GetById(int id, out string err)
        {
            try
            {
                err = string.Empty;
                return repo.GetMedicineById(id);
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return null;
            }
        }
        public List<Medicine> GetByName(string name, out string err)
        {
            try
            {
                err = string.Empty;
                return repo.GetMedicinesByName(name);
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return new List<Medicine>();
            }
        }
    }
}
