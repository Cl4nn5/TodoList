using System;
using System.Collections;
using HelloWorld.Class;

namespace HelloWorld
{
    class HelloWorld
    {
        private static void Main(string[] args)
        {
#if DEBUG
    Console.WriteLine("디버그 모드입니다.");
#endif
            float number1 = 2_2.7F;

            double number2 = -13;
            Console.WriteLine(number1);
            Console.WriteLine(number2);

        }
    }
}
