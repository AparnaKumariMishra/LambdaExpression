using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UC5
{
    internal class UC5Min8Char
    {
        public string password = "^[a-z]{8,}$";
        public string password1 = "aparnamishra";
        public void Validate()
        {
            Func<string, bool> result = (password1) => Regex.IsMatch(password1, password);
            Console.WriteLine(result(password1));
        }

    }

}
