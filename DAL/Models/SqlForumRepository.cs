using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DAL.Models
{
    public class SqlForumRepository : IForumRepository
    {
        private ForumEntities forumDb = new ForumEntities();

        public void AddForum(Forum forum)
        {
            forumDb.Forums.Add(forum);
            forumDb.SaveChanges();
        }

        public void AddPost(Post post)
        {
            forumDb.Posts.Add(post);
            forumDb.SaveChanges();
        }

        public void AddThread(Thread thread)
        {
            forumDb.Threads.Add(thread);
            forumDb.SaveChanges();
        }

        public void DeleteForum(Forum forum)
        {
            forumDb.Forums.Remove(forum);
            forumDb.SaveChanges();
        }

        public void DeletePost(Post post)
        {
            forumDb.Posts.Remove(post);
            forumDb.SaveChanges();
        }

        public void DeleteThread(Thread thread)
        {
            forumDb.Threads.Remove(thread);
            forumDb.SaveChanges();
        }

        public IEnumerable<Forum> GetAllForums()
        {
            return forumDb.Forums.ToList();
        }

        public IEnumerable<Post> GetAllPosts()
        {
            return forumDb.Posts.ToList();
        }

        public IEnumerable<Thread> GetAllThreads()
        {
            return forumDb.Threads.ToList();
        }

        public Forum GetForumById(int forumId)
        {
            return forumDb.Forums.Single(x => x.ForumID == forumId);
        }

        public Post GetPostByID(int postID)
        {
            return forumDb.Posts.Single(p => p.PostID == postID);
        }

        public IEnumerable<Post> GetPostsByThread(int threadID)
        {
            return GetThreadByID(threadID).Posts.ToList();
        }

        public Thread GetThreadByID(int threadID)
        {
            return forumDb.Threads.Single(t => t.ThreadID == threadID);
        }

        public IEnumerable<Thread> GetThreadsByForum(int forumID)
        {
            return GetForumById(forumID).Threads.ToList();
        }

        public void UpdateForum(Forum forum)
        {
            var forumBuffer = forumDb.Forums.Single(f => f.ForumID == forum.ForumID);
            forumBuffer = forum;
            forumDb.SaveChanges();
        }

        public void UpdatePost(Post post)
        {
            var postBuffer = forumDb.Posts.Single(p => p.PostID == post.PostID);
            postBuffer = post;
            forumDb.SaveChanges();
        }

        public void UpdateThread(Thread thread)
        {
            var threadBuffer = forumDb.Threads.Single(t => t.ThreadID == thread.ThreadID);
            threadBuffer = thread;
            forumDb.SaveChanges();
        }
    }
}