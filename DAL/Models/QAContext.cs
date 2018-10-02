using System;
using System.Data.Entity;

namespace DAL.Models
{
    public class QAContext : DbContext
    {
        public QAContext() : base()
        {

        }
        public DbSet<Student> Students { get; set; }

        public System.Data.Entity.DbSet<DAL.Models.Forum> Fora { get; set; }
    }
}
