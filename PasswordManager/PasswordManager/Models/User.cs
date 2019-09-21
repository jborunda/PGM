using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PasswordManager.Models
{
    public class User
    {
        [Required]
        public int UserID { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public Password UserPassword { get; set; }



        public User(int UserID, string UserName, string Email, Password UserPassword)
        {
            this.UserID = UserID;
            this.UserName = UserName;
            this.Email = Email;
            this.UserPassword = UserPassword;
        }


    }
}
