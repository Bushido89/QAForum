using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QAForum.Controllers
{
    public class HomeController : Controller
    {
        private IForumRepository forumRepository = null;

        public HomeController() : this(new SqlForumRepository())
        {

        }

        public HomeController(IForumRepository aForumRepository)
        {
            forumRepository = aForumRepository;
        }

        public ActionResult OldIndex()
        {
            return View();
        }

        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to the QA Forums Web Site!";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "The UK’s leading learning company.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "You can contact QA.";

            return View();
        }
    }
}