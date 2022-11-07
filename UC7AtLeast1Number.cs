using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UC7
{
    internal class UC7AtLeast1Number
    {
        public string password = "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9]).{8,}$";
        public string password1 = "aparnaMishra123";
        public void Validate()
        {
            Func<string, bool> result = (password1) => Regex.IsMatch(password1, password);
            Console.WriteLine(result(password1));
        }
    }
}
