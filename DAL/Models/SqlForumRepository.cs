using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DAL.Models
{
    public class SqlForumRepository : IForumRepository, IDisposable
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

        public void DeleteForum(int id, Forum forum)
        {
            forumDb.Forums.Remove(forumDb.Forums.Single(f => f.ForumID == id));
            forumDb.SaveChanges();
        }

        public void DeletePost(int id, Post post)
        {
            forumDb.Posts.Remove(forumDb.Posts.Single(p => p.PostID == id));
            forumDb.SaveChanges();
        }

        public void DeleteThread(int id, Thread thread)
        {
            forumDb.Threads.Remove(forumDb.Threads.Single(t => t.ThreadID == id));
            forumDb.SaveChanges();
        }

        public void Dispose()
        {
            //TODO: Implementation
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

        public void UpdateForum(int id, Forum forum)
        {
            var forumBuffer = forumDb.Forums.Single(f => f.ForumID == id);
            forum.ForumID = id;
            forumDb.Entry(forumBuffer).CurrentValues.SetValues(forum);
            forumDb.SaveChanges();
        }

        public void UpdatePost(int id, Post post)
        {
            var postBuffer = forumDb.Posts.Single(p => p.PostID == id);
            post.PostID = id;
            forumDb.Entry(postBuffer).CurrentValues.SetValues(post);
            forumDb.SaveChanges();
        }

        public void UpdateThread(int id, Thread thread)
        {
            var threadBuffer = forumDb.Threads.Single(t => t.ThreadID == id);
            thread.ThreadID = id;
            forumDb.Entry(threadBuffer).CurrentValues.SetValues(thread);
            forumDb.SaveChanges();
        }
    }
}