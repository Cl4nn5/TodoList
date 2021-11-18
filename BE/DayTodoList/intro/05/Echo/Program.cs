using System;

namespace Echo
{
    class Program
    {
        //static void Main(string[] args)
        static void Main()
        {
            Console.WriteLine("글자 입력 후 엔터를 누르세요.");
            string userInput = Console.ReadLine();
            Console.WriteLine("숫자 입력 후 엔터를 누르세요.");
            string userInput2 = Console.ReadLine();

            Console.Write("입력한 글은 \"");
            Console.Write(userInput);
            Console.WriteLine("\" 입니다.");
            
            if (int.TryParse(userInput2, out int ParseInputNum) == true)
            {
                Console.WriteLine("값이 {0}에서 {1}로 변환되었습니다", userInput2, ParseInputNum);
            }

        }
    }
}
