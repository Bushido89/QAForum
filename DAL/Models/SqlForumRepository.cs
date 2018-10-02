using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DAL.Models
{
    public class SqlForumRepository : IForumRepository
    {
        private ForumEntities forumDb = new ForumEntities();

        public IEnumerable<Forum> GetAllForums()
        {
            return forumDb.Forums.ToList();
        }

        public Forum GetForumById(int forumId)
        {
            return forumDb.Forums.Single(x => x.ForumID == forumId);
        }
    }
}