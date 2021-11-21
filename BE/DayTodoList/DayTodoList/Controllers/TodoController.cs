using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DayTodoList.Controllers
{
    public class TodoController : HomeController
    {
        delegate int dgUserInfo(int userIdx);

        void getAge()
        {
            dgUserInfo _userInfo = new dgUserInfo(IdxToAge);
            
        }

        private int IdxToAge(int userIdx)
        {
            // idx를 조회하여 age를 가져왔다고 침
            int userAge = userIdx + 10;

            return userAge;
        }

        void Run(dgUserInfo m)
        {
            int i = m(123);

            Console.WriteLine(i);
        }
    }
}