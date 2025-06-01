using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace EF_Version
{
    public class Account
    {
        public Account() { }
        public Account(string username, string password, string role, int userid)
        {
            Username = username;
            Password = password;
            Role = role;
            UserId = userid;
        }
        [Key]
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public int UserId { get; set; }
        public virtual Doctor Doctor { get; set; } // Navigation property for Doctor
        public virtual Secretary Secretary { get; set; } // Navigation property for Secretary
        public virtual Admin Admin { get; set; } // Navigation property for Admin
    }
}