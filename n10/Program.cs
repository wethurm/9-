using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            Random random = new Random();

            for (int i = 0; i < 3; i++)
                sb.Append((char)('a' + random.Next(26)));

            for (int i = 0; i < 3; i++)
                sb.Append(random.Next(0, 10));

            for (int i = 0; i < 2; i++)
                sb.Append((char)('A' + random.Next(26)));

            string password = new string(sb.ToString().OrderBy(x => random.Next()).ToArray());

            Console.WriteLine(password);
        }
    }
}
