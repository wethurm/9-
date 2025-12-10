using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = "+79161234567";
            Console.WriteLine($"{number.Substring(0, 2)}" + " (" + $"{number.Substring(2, 3)}" + ") " + $"{number.Substring(5, 3)}" + "-" + $"{number.Substring(8, 2)}" + "-" + $"{number.Substring(10, 2)}");
        }
    }
}
