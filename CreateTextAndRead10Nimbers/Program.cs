using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CreateTextAndRead10Nimbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\C#\Домашние задания\HomeWork8\HomeWork8\CreateTextAndRead10Nimbers\bin\Debug\Logs.txt";
            Random random = new Random();
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                for (int i = 0; i < 10; i++)
                {
                    sw.WriteLine(random.Next(1, 30));
                }
            }
            int k = 0;
            using (StreamReader sr = new StreamReader(path))
            {
                for (int i = 0; i < 10; i++)
                {
                    Convert.ToInt32(sr.ReadLine());
                    k += Convert.ToInt32(sr.ReadLine());
                }
            }
            Console.WriteLine("Сумма чисел = {0}", k);
            Console.ReadKey();
        }
    }
}
