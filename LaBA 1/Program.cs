using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaBA_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число:");
            int age = Convert.ToInt32(Console.ReadLine());
            int li = Convert.ToInt32(Math.Pow(age, 2));
            Console.WriteLine("Число в квадрате  =  ");
            Console.WriteLine(li);
            Console.ReadKey();
        }
    }
}
