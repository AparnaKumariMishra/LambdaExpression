using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UC2
{
    internal class UC2LastName
    {
        public string LastName = "^[A-Z]{1}[a-z]{2}$";
        public string LastName1 = "Sah";
        public void Validate()
        {
            Func<string, bool> result = (LastName1) => Regex.IsMatch(LastName1, LastName);
            Console.WriteLine(result(LastName1));
        }
    }
}
