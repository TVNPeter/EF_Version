﻿using EF_Version.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EF_Version.Presentation.Forms;
namespace EF_Version.UI.Forms
{
    public partial class frmLogin : Form
    {
        private BLLAccount accountService = new BLLAccount();
        private List<Account> accounts;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void pb_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            accounts = accountService.GetAllAccounts(out string err);
            if (!string.IsNullOrEmpty(err))
            {
                MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_Username.Text) || string.IsNullOrWhiteSpace(txt_Password.Text))
            {
                MessageBox.Show("Please enter both username and password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string username = txt_Username.Text.Trim();
            string password = txt_Password.Text.Trim();
            password = PasswordHelper.HashPassword(password);
            var account = accounts.FirstOrDefault(a => a.Username == username && a.Password == password && a.IsDeleted != true);
            if (account != null)
            {
                this.Hide();
                frmMain mainForm = new frmMain(account.Role, account.UserId);
                mainForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
