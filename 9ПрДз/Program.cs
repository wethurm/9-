using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9ПрДз
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "anna";
            string city = "Moscow";
            Console.WriteLine($"Привет, {name.ToUpper()[0]}{name.Substring(1)} из {city.ToUpper()}");
        }
    }
}
