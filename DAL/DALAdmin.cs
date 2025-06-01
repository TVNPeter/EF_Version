using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Version.DAL
{
    internal class DALAdmin
    {
        ClinicContext db = new ClinicContext();
        public DALAdmin() { }
        public List<Admin> GetAdmins()
        {
            return db.Admins.ToList();
        }
    }
}
