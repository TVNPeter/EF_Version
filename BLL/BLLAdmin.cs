using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_Version.DAL;
namespace EF_Version.BLL
{
    internal class BLLAdmin
    {
        DALAdmin repo = new DALAdmin();
        public List<Admin> GetAllAdmins(out string err)
        {
            try
            {
                var admins = repo.GetAdmins();
                err = string.Empty;
                return admins;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return null;
            }
        }
        public Admin GetAdminById(int id, out string err)
        {
            try
            {
                var admin = repo.GetAdmins().FirstOrDefault(a => a.AdminID == id);
                if (admin == null)
                {
                    err = "Admin not found";
                    return null;
                }
                err = string.Empty;
                return admin;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return null;
            }
        }
    }
}
