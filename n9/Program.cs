using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string wword = word.ToLower();
            StringBuilder sb = new StringBuilder();
            foreach (char s in wword)
            {
                sb.Append((char)((s - 'a' + 3) % 26 + 'a'));
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
