using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QAForum.Controllers
{
    public class ForumController : ForumRepositoryBaseController
    {
        // GET: Forum
        [OutputCache(Duration = 10)]
        public ActionResult Index()
        {
            ViewBag.Message = "QA Forums List";
            return View(forumRepository.GetAllForums());
        }

        // GET: Forum/Details/5
        public ActionResult Details(int id)
        {
            ViewBag.Message = "Forum Detail";
            return View(forumRepository.GetForumById(id));
        }

        // POST: Forum/Create
        [HttpPost]
        public ActionResult Create(Forum forum)
        {
            try
            {
                forumRepository.AddForum(forum);
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                return View(ex);
            }
        }

        // POST: Forum/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Forum forum)
        {
            try
            {
                forumRepository.UpdateForum(id, forum);
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                return View(ex);
            }
        }

        // POST: Forum/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Forum forum)
        {
            try
            {
                forumRepository.DeleteForum(id, forum);
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                return View(ex);
            }
        }
    }
}
