using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCProject.Areas.MyAdmin.Controllers
{
    public class AccountsController : Controller
    {
        // GET: MyAdmin/Accounts
        public ActionResult Login()
        {
            return View();
        }
    }
}