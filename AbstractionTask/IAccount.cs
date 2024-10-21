using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionTask
{
    public interface IAccount
    {
        bool PasswordChecker(string password);
        void ShowInfo();
    }
}
