using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "C# это современный язык программирования.";
            Console.WriteLine($"Количество символов в строке: {text.Length}");
            Console.WriteLine($"Количество слов в строке: {text.Split(' ').Length}");
            Console.WriteLine($"Индекс слова язык: {text.IndexOf("язык")}");
            if (text.StartsWith("C#"))
                Console.WriteLine("Строка начинается с C#");
            else
                Console.WriteLine("Строка не начинается с C#");
        }
    }
}
