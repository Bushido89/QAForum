using System;
using System.Data.Entity;

namespace QAForum.Models
{
    public class QAContext : DbContext
    {
        public QAContext() : base()
        {

        }
        public DbSet<Student> Students { get; set; }

        public System.Data.Entity.DbSet<QAForum.Models.Forum> Fora { get; set; }
    }
}
