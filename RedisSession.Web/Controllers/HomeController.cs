using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RedisSession.Models;

namespace RedisSession.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //Test Add Redis Sesion
            var model = new TestSessionModel
            {
                Id = 1,
                TestName = "Test Redis Session Not put serialize attribute"
            };
            Session["TestSession"] = model;
            return View();
        }

        public ActionResult About()
        {
            //Test Ger Redis Sesion
            var model = Session["TestSession"] as TestSessionModel;

            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}