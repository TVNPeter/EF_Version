using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_Version;
namespace EF_Version.DAL
{
    internal class DALAccount
    {
        ClinicContext context = new ClinicContext();
        public List<Account> GetAccounts()
        {
            return context.Accounts.Where(a => a.IsDeleted != true).ToList();
        }
        public Account GetAccountByUsername(string username)
        {
            return context.Accounts.FirstOrDefault(a => a.Username == username && a.IsDeleted != true);
        }
        public void AddAccount(Account account)
        {
            //Hash password before saving
            account.Password = PasswordHelper.HashPassword(account.Password);
            context.Accounts.Add(account);
            context.SaveChanges();
        }
        public void UpdateAccount(Account account)
        {
            var existingAccount = context.Accounts.Find(account.Username);
            if (existingAccount != null)
            {
                existingAccount.Username = account.Username;
                existingAccount.Password = account.Password;
                context.SaveChanges();
            }
        }
        public void DeleteAccount(string username)
        {
            var account = context.Accounts.FirstOrDefault(a => a.Username == username);
            if (account != null)
            {
                account.IsDeleted = true; // Soft delete
                context.SaveChanges();
            }
        }
    }
}
