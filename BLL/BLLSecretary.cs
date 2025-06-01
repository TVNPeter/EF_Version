using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Version.BLL
{
    internal class BLLSecretary
    {
        DAL.DALSecretary repo = new DAL.DALSecretary();
        public int GetLastSecretaryId()
        {
            return repo.GetSecretaries().Any() ? repo.GetSecretaries().Max(s => s.SecretaryID) : 0;
        }
        public bool Add(Secretary s, out string err, out int newId)
        {
            try
            {
                newId = repo.AddSecretary(s);
                err = string.Empty;
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                newId = 0;
                return false;
            }
        }

        public bool Update(Secretary s, out string err)
        {
            try
            {
                repo.UpdateSecretary(s);
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
                repo.DeleteSecretary(id);
                err = string.Empty;
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }

        public List<Secretary> GetAll(out string err)
        {
            try
            {
                err = string.Empty;
                return repo.GetSecretaries();
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return new List<Secretary>();
            }
        }

        public Secretary GetById(int id, out string err)
        {
            try
            {
                err = string.Empty;
                return repo.GetSecretaryById(id);
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return null;
            }
        }

        public List<Secretary> GetByName(string name, out string err)
        {
            try
            {
                err = string.Empty;
                return repo.GetSecretariesByName(name);
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return new List<Secretary>();
            }
        }
    }
}
