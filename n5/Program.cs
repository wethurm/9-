using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string low_word = word.ToLower();
            int k = low_word.Length - 1;
            char f = 'a';
            char l = 'b';
            bool isPolindrom = true;
            for (int i = 0; i < low_word.Length / 2; i++)
            {
                f = low_word[i];
                l = low_word[k];
                if (f == l) { }
                else
                {
                    isPolindrom = false;
                    break;
                }

                k--;
            }

            if (isPolindrom)
            {
                Console.WriteLine($"{word} - полиндром");
            }
            else
            {
                Console.WriteLine($"{word} - не полиндром");
            }
        }
    }
}
