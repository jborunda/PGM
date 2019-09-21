using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PasswordManager.Models
{
    public class Password
    {
        string PasswordContent { get; set; }
        int PasswordID { get; set; }
        
        public Password(string PasswordContent, int PasswordID)
        {
            this.PasswordContent = PasswordContent;
            this.PasswordID = PasswordID;
        }


    }
}
