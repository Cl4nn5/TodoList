using System;
using System.ComponentModel;

namespace Calculator
{
    class Program
    {
        //static void Main(string[] args)
        static void Main()
        {
            Console.WriteLine("첫 번째 숫자를 입력해주세요");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("두 번째 숫자를 입력해주세요");
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("연산자");
            string inputOperator = Console.ReadLine();

            Console.WriteLine($"{number1}{inputOperator}{number2}");
        }
    }
}
