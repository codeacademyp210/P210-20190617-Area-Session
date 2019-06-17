using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AreaDemo.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        // GET: Admin/Home
        public ActionResult Index()
        {
            if (Session["isLogin"] != null && (bool)Session["isLogin"] == true)
            {
                return View();
            }
            return RedirectToAction("Index", "Login");
        }


    }
}