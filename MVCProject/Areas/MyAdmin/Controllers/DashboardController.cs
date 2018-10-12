using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCProject.Areas.MyAdmin.Controllers
{
    public class DashboardController : Controller
    {
        // GET: MyAdmin/Dashboard
        public ActionResult Index()
        {
            return View();
        }
    }
}