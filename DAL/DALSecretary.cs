using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Version.DAL
{
    internal class DALSecretary
    {
        ClinicContext context = new ClinicContext();
        public int GetLastSecretaryId()
        {
            return context.Secretaries.Any() ? context.Secretaries.Max(s => s.SecretaryID) : 0;
        }
        public List<Secretary> GetSecretaries()
        {
            return context.Secretaries.Where(s => s.IsDeleted != true).ToList();
        }

        public Secretary GetSecretaryById(int id)
        {
            return context.Secretaries.FirstOrDefault(s => s.SecretaryID == id && s.IsDeleted != true);
        }

        public List<Secretary> GetSecretariesByName(string name)
        {
            return context.Secretaries.Where(s => s.FullName.Contains(name) && s.IsDeleted != true).ToList();
        }

        public int AddSecretary(Secretary secretary)
        {
            context.Secretaries.Add(secretary);
            context.SaveChanges();
            return secretary.SecretaryID;
        }

        public void UpdateSecretary(Secretary secretary)
        {
            var existingSecretary = context.Secretaries.Find(secretary.SecretaryID);
            if (existingSecretary != null)
            {
                existingSecretary.FullName = secretary.FullName;
                existingSecretary.Phone = secretary.Phone;
                context.SaveChanges();
            }
        }

        public void DeleteSecretary(int id)
        {
            var secretary = context.Secretaries.Find(id);
            if (secretary != null)
            {
                secretary.IsDeleted = true; // Soft delete
                context.SaveChanges();
            }
        }
    }
}
