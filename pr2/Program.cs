using System;

namespace SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Введите первое целое число:");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе целое число:");
            int number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите третье целое число:");
            int number3 = int.Parse(Console.ReadLine());

            int sum = number1 + number2 + number3;

            Console.WriteLine($"Сумма чисел в прямом порядке: {number1} + {number2} + {number3} = {sum}");
            Console.WriteLine($"Сумма чисел в обратном порядке: {number3} + {number2} + {number1} = {sum}");
        }
    }
}
