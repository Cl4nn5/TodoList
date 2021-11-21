using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Windows.Forms;

namespace DayTodoList.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var ht = Sample();
            MessageBox.Show(ht.ToString());

            Console.WriteLine(ht);

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public Hashtable Sample()
        {
            Hashtable temp = new Hashtable();

            temp.Add("name", "KIM");
            temp.Add("name2", "LEE");
            temp.Add("age", 1);

            return temp;
        }

    }
}