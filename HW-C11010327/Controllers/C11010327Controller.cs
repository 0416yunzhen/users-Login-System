using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace HW_C11010327.Controllers
{
    public class C11010327Controller : Controller
    {
        // GET: C11010327
        public ActionResult Index()
        {
            return View();
        }

        
        public ActionResult member327(string myacc,string mypwd,string drone)
        {
            ViewBag.useracc = myacc ;
            ViewBag.userpwd = mypwd ;
            ViewBag.drone = drone ;
            ViewBag.userimg = drone+".jpg";
            return View();
        }

    }
}