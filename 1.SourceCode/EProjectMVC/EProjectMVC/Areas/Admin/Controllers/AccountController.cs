using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EProjectMVC.Areas.Admin.Controllers
{
    public class AccountController : Controller
    {
        // GET: /Admin/Acount/
        public ActionResult Index()
        {
            return RedirectToAction("Login", "Account", new { area = "Admin" });
        }
        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }
	}
}