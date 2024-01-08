using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GetSpecification
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "Sample/Letter.txt";
            string text = File.ReadAllText(filePath);
            int characterNumber = text.Length;
            int stringNumber = text.Split('\n').Length;
            int symbolsNumber = text.Split(new[] { ' ', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries).Length;
            Console.WriteLine("Статистика файла:");
            Console.WriteLine("Количество символов: {0}", characterNumber);
            Console.WriteLine("Количество строк: {0}", stringNumber);
            Console.WriteLine("Количество слов: {0}", symbolsNumber);
            Console.ReadKey();






        }
    }
}
