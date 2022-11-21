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
        public void ValidatePinCode(string eMail)
        {
            // Part1: abc is mandatory
            // Part2: ensure @ and validate mandatory part bridgelabz
            var regex = new Regex(@"^([a][b][c])\@([b][r][i][d][g][e][l][a][b][z])");
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
