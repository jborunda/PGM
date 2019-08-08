using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.Services
{
    public class PasswordService
    {

        public static StringBuilder GeneratePassword(int length)
        {
            Random random = new Random();
            char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            char[] lowAlpha = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            char[] numbers = "1234567890".ToCharArray();
            StringBuilder password = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                int index = random.Next();
                if (index % 3 == 0) { password.Insert(i, alpha[index % 26]); }
                if (index % 3 == 1) { password.Insert(i, lowAlpha[index % 26]); }
                if (index % 3 == 2) { password.Insert(i, numbers[index % 10]); }
            }

            return password;
        }
    }
}
