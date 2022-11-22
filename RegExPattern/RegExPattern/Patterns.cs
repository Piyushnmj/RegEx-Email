using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegExPattern
{
    public class Patterns
    {
        public void ValidateEMail(string eMail)
        {
            var regex = new Regex(@"^(\w)([_\+\-\.]{0,1}[\w])*[@][a-z0-9]{1,} *[.][a-z]{2,}[\.]{0,}[a-z]{0,}$");
            bool matchRes = regex.IsMatch(eMail);
            if (matchRes == true)
            {
                Console.WriteLine($"\n{eMail} is valid email address");
            }
            else
            {
                Console.WriteLine($"\n{eMail} is invalid email address");
            }
        }
    }
}
