using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fruits = "яблоко, банан, апельсин, киви, груша";
            string[] fr = fruits.Split(',');
            for(int i  = 0; i < fr.Length; i++)
            {
                fr[i] = fr[i].Trim();
            }
            Array.Sort(fr);
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < fr.Length; i++)
            {
                sb.Append(fr[i] + "; ");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
