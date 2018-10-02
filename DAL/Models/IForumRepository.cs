using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DAL.Models
{
    public interface IForumRepository
    {
        IEnumerable<Forum> GetAllForums();

        Forum GetForumById(int forumId);
        
    }
}