using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string email = "user.example@gmail.com";
            string f_part = email.Split('@')[0];
            string s_part = email.Split('@')[1];
            for(int i = 0; i < f_part.Length; i++)
            {
                Console.Write('*');
            }
            Console.Write('@' + $"{s_part}");
        }
    }
}
