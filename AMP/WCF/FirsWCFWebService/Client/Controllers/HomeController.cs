using Client.FirstWebServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Client.Controllers
{
    public class HomeController : Controller
    {

        HelloWorldserviceClient client = new HelloWorldserviceClient();
        public ActionResult Index()
        {
            ViewBag.Message = client.Message();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            int x = client.add(5, 7);
            ViewBag.Z = x;

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}