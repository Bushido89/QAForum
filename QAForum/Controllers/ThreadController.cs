using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL.Models;

namespace QAForum.Controllers
{
    public class ThreadController : ForumRepositoryBaseController
    {
        // GET: Thread
        public ActionResult Index(int forumId)
        {
            var threads = forumRepository.GetThreadsByForum(forumId);
            return View(threads);
        }

        // GET: Thread/Details/5
        public ActionResult Details(int id)
        {
            var thread = forumRepository.GetThreadByID(id);
            return View(thread);
        }

        // POST: Thread/Create
        [HttpPost]
        public ActionResult Create(Thread thread)
        {
            try
            {
                forumRepository.AddThread(thread);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // POST: Thread/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Thread thread)
        {
            try
            {
                forumRepository.UpdateThread(id, thread);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // POST: Thread/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Thread thread)
        {
            try
            {
                forumRepository.DeleteThread(id, thread);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
