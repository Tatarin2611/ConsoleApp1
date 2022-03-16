using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("сложение двух чисел");

            Console.Write("Введите первое число - ");

            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите второе число - ");

            int b = Convert.ToInt32(Console.ReadLine());

            int num = a + b;

            Console.WriteLine("Сумма вервого и второго числа состовляет " + num) ;

            Console.ReadLine();
        }
    }
}
