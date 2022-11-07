using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UC3
{
    internal class UC3Email
    {
        public string Email = "^[A-Z]{3}[.][a-z]{3}@[a-z]{2}[.][a-z]{2}$";//YAS.raj@co.in
        public string Email1 = "YAS.raj@co.in";
        public void Validate()
        {
            Func<string, bool> result = (Email1) => Regex.IsMatch(Email1, Email);
            Console.WriteLine(result(Email1));
        }

    }
}
