using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.Class
{
    public class Class1
    {
        delegate int dgUserInfo(int userIdx);

        void getAge()
        {
            dgUserInfo _userInfo = new dgUserInfo(AddTen);

        }

        int AddTen(int userIdx)
        {
            // idx를 조회하여 age를 가져왔다고 침
            int addTen = userIdx + 10;

            return addTen;
        }

        void Run(dgUserInfo m)
        {
            int i = m(123);

            Console.WriteLine(i);
        }
    }
}
