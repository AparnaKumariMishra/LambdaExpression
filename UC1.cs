using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LambdaExpression
{
    internal class UC1
    {
        public string Firstdigit = "^[A-Z]{1}[a-z]{2}$";
        public string Firstdigit1 = "Raj";
        public void Validate()
        {
            Func<string, bool> result = (Firstdigit1) => Regex.IsMatch(Firstdigit1, Firstdigit);
            Console.WriteLine(result(Firstdigit1));
        }
    }
}
