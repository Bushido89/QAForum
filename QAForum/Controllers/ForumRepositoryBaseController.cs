using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QAForum.Controllers
{
    public class ForumRepositoryBaseController : Controller
    {
        protected internal IForumRepository forumRepository = null;

        public ForumRepositoryBaseController() : this(new SqlForumRepository())
        {

        }

        public ForumRepositoryBaseController(IForumRepository forumRepository)
        {
            this.forumRepository = forumRepository;
        }
    }
}