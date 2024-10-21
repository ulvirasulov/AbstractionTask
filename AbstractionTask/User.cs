using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AbstractionTask
{
    public class User:IAccount
    {
        private static int _id = 1;
        public int Id { get; }
        public string FullName { get; set; }
        public string Email { get; }
        private string _password;

        public User(string fullName, string email, string password)
        {
            Id = _id++;
            FullName = fullName;
            Email = email;

            if (PasswordChecker(password))
            {
                _password = password;
            }
            else
            {
                Console.WriteLine("Sifre teleblere cavab vermir!");
            }
        }

        public bool PasswordChecker(string password)
        {
            if (password.Length < 8)
            {
                return false;
            }
            bool boyukHerfVarmi = false;
            bool kicikHerfVarmi = false;
            bool reqemVarmi = false;

            foreach (char simvol in password)
            {
                if (char.IsUpper(simvol))
                {
                    boyukHerfVarmi = true;
                }
                if (char.IsLower(simvol))
                {
                    kicikHerfVarmi = true;
                }
                if (char.IsDigit(simvol))
                {
                    reqemVarmi = true;
                }

                if (boyukHerfVarmi && kicikHerfVarmi && reqemVarmi)
                {
                    return true;
                }
            }
            return false;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"id: {Id}, full name: {FullName}, email: {Email}");
        }
    }
}
