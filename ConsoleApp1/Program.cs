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

            Console.WriteLine("Сложение двух чисел и умножение суммы на 2 ");

            Console.Write("Введите первое число a - ");

            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите второе число b ");

            int b = Convert.ToInt32(Console.ReadLine());

            int num = a + b;

            Console.WriteLine("Сумма вервого и второго числа состовляет " + num, "ffffffffffffffffffffff") ;

            num = num * 2;

            Console.WriteLine("Сумма вервого и второго числа состовляет " + num);

            Console.ReadLine();
        }
    }
}
