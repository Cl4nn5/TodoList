using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBall
{
    class Program
    {
        //static void Main(string[] args)
        static void Main()
        {
            Console.WriteLine("룰 설명");
            Console.WriteLine("컴퓨터가 수비수가 되어 세 자릿수를 하나 골랐습니다.");
            Console.WriteLine("각 숫자는 0~9중에 하나이며 중복되는 숫자는 없습니다.\n"+
                              "모든 숫자의 위치를 맞히면 승리합니다.");
            Console.WriteLine("스트라이크\t: 숫자와 순서가 다 맞는 경우");
            Console.WriteLine("    볼 \t\t: 숫자만 맞고 순서가 틀린 경우");
            Console.WriteLine("  아  웃 \t: 숫자가 틀린 경우\n");
            Console.WriteLine("=> 수비수가 고른 숫자");

            int num1 = 3, num2 = 1, num3 = 9;

            Console.WriteLine($"{num1}\n" +
                              $"{num2}\n" +
                              $"{num3}");

            num1 = 8;
            num2 = 2;
            num3 = 0;

            Console.WriteLine($"{num1}\n" +
                              $"{num2}\n" +
                              $"{num3}");

            string[] arrText = new[] {"첫", "두", "세"};

            // 공격수의 숫자 선택
            int[] guess = new int[3];

            // 공격수 차례
            for (int i = 0; i < arrText.Length; i++)
            {
                Console.WriteLine($">> {arrText[i]} 번째 숫자를 입력하세요");
                guess[i] = int.Parse(Console.ReadLine() ?? "0");
            }

            Console.WriteLine(">> 공격수가 고른 숫자");
            foreach (var pickNumber in guess)
            {
                Console.WriteLine(pickNumber);
            }

        }
    }
}
