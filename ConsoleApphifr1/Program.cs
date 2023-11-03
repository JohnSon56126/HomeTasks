using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApphifr1
{
   
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значения x, y, z:");

            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double z = double.Parse(Console.ReadLine());

            double v = (1 + Math.Pow(Math.Sin(x + y), 2)) / Math.Abs(x - 2 * y / (1 + Math.Pow(x, 2) * Math.Pow(y, 2))) * Math.Pow(x, Math.Abs(y)) + Math.Pow(Math.Cos(Math.Atan(1 / z)), 2);

            Console.WriteLine("Результат: " + Math.Round(v, 8)); 

            Console.ReadKey();
        }
    }
}

