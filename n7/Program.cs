using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            for(int i  = 1; i < 6; i++)
            {
                for(int j = 1; j < 6; j++)
                {
                    sb.Append(i);
                    sb.Append(" * ");
                    sb.Append(j);
                    sb.Append($" = {i * j} ");
                }
                Console.WriteLine(sb.ToString());
                sb.AppendLine();
                sb.Length = 0;
            }
        }
    }
}
