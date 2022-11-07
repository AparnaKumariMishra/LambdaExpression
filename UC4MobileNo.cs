using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UC4
{
    internal class UC4MobileNo
    {
        public string MobileNo = "^[9][1][\\s]?[0-9]{10}$";
        public string MobileNumber = "91 9955819686";
        public void Validate()
        {
            Func<string, bool> result = (MobileNumber) => Regex.IsMatch(MobileNumber, MobileNo);
            Console.WriteLine(result(MobileNumber));
        }

    }
}
