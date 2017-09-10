using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using APIWebApplication.data;

namespace APIWebApplication.web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Get(string word)
        {
            Repository repo = new Repository();
            User user = repo.GetUser(word);
            return Json(new { user = user == null ? null: user }, JsonRequestBehavior.AllowGet);
        }
    }
}