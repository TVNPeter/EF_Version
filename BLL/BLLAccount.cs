using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_Version.DAL;
namespace EF_Version.BLL
{
    internal class BLLAccount
    {
        DALAccount repo = new DALAccount();
        public List<Account> GetAllAccounts(out string err)
        {
            try
            {
                var accounts = repo.GetAccounts();
                err = string.Empty;
                return accounts;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return null;
            }
        }
        public Account GetAccountByUsername(string username, out string err)
        {
            try
            {
                var account = repo.GetAccountByUsername(username);
                if (account == null)
                {
                    err = "Account not found";
                    return null;
                }
                err = string.Empty;
                return account;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return null;
            }
        }
        public bool AddAccount(Account account, out string err)
        {
            try
            {
                repo.AddAccount(account);
                err = string.Empty;
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }
        public bool UpdateAccount(Account account, out string err)
        {
            try
            {
                repo.UpdateAccount(account);
                err = string.Empty;
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }
        public bool DeleteAccount(string username, out string err)
        {
            try
            {
                repo.DeleteAccount(username);
                err = string.Empty;
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
