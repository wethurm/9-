using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            for(int i = 1; i <=10; i++)
            {
                if (i != 10)
                {
                    sb.Append(i.ToString());
                    sb.Append(",");
                }
                else { sb.Append(i.ToString()); }
            }
            sb.Insert(0, "Числа: ");
            sb.Insert(sb.Length, ".");
            string final = sb.ToString();
            Console.WriteLine(final);
        }
    }
}
