using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QAForum.Controllers
{
    public class PostController : ForumRepositoryBaseController
    {
        // GET: Post
        public ActionResult Index(int threadId)
        {
            return View(forumRepository.GetPostsByThread(threadId));
        }

        // GET: Post/Details/5
        public ActionResult Details(int id)
        {
            return View(forumRepository.GetPostByID(id));
        }

        // POST: Post/Create
        [HttpPost]
        public ActionResult Create(Post post)
        {
            try
            {
                forumRepository.AddPost(post);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // POST: Post/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Post post)
        {
            try
            {
                forumRepository.UpdatePost(id, post);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // POST: Post/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Post post)
        {
            try
            {
                forumRepository.DeletePost(id, post);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
