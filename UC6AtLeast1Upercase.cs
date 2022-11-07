using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UC6
{
    internal class UC6AtLeast1Upercase
    {
        public string password = "^[a-zA-Z]{8,}$";
        public string password1 = "aparnaMishra";
        public void Validate()
        {
            Func<string, bool> result = (password1) => Regex.IsMatch(password1, password);
            Console.WriteLine(result(password1));
        }
    }
}
