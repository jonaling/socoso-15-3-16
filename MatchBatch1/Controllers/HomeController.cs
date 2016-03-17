using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MatchBatch1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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

        public ActionResult Item1()
        {
            return View();
        }
        public ActionResult Search()
        {
            return View();
        }
        public ActionResult Profile()
        {
            return View();
        }
        public ActionResult Match2()
        {
            return View();
        }
        public ActionResult Match3()
        {
            return View();
        }
        public ActionResult Posts()
        {
            return View();
        }
        public ActionResult SetPage()
        {
            return View();
        }
        public ActionResult Upload1()
        {
            return View();
        }
        public ActionResult Upload2()
        {
            return View();
        }
        public ActionResult OfficeWear()
        {
            return View();
        }
    }
}