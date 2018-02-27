using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
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

        public ActionResult Choose()
        {
            ViewBag.Message = "Your test choose page.";

            return View();
        }

        public ActionResult Customize()
        {
            ViewBag.Message = "Your test choose page.";

            return View();
        }

        public ActionResult Confirm()
        {
            ViewBag.Message = "Your test choose page.";

            return View();
        }

        public ActionResult OneStory()
        {
            ViewBag.Message = "Your test choose page.";

            return View();
        }

        public ActionResult TwoStory()
        {
            ViewBag.Message = "Your test choose page.";

            return View();
        }

        public ActionResult SingleFamily()
        {
            ViewBag.Message = "Your test choose page.";

            return View();
        }

        public ActionResult RanchStyle()
        {
            ViewBag.Message = "Your test choose page.";

            return View();
        }

        public ActionResult Doors()
        {
            ViewBag.Message = "Your test choose page.";

            return View();
        }

        public ActionResult Windows()
        {
            ViewBag.Message = "Your test choose page.";

            return View();
        }

        public ActionResult Roof()
        {
            ViewBag.Message = "Your test choose page.";

            return View();
        }

        public ActionResult Flooring()
        {
            ViewBag.Message = "Your test choose page.";

            return View();
        }

        public ActionResult Feedback()
        {
            ViewBag.Message = "Your feedback page.";

            return View();
        }
    }
}