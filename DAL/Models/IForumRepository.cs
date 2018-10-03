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

        IEnumerable<Thread> GetAllThreads();

        IEnumerable<Post> GetAllPosts();
        
        Thread GetThreadByID(int ThreadID);

        Post GetPostByID(int PostID);

        IEnumerable<Thread> GetThreadsByForum(int ForumID);

        IEnumerable<Post> GetPostsByThread(int ThreadID);

        void AddForum(Forum forum);

        void AddThread(Thread thread);

        void AddPost(Post post);

        void UpdateForum(int id, Forum forum);

        void UpdateThread(int id, Thread thread);

        void UpdatePost(int id, Post post);

        void DeleteForum(int id, Forum forum);

        void DeleteThread(int id, Thread thread);

        void DeletePost(int id, Post post);
    }
}