namespace QAForum.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ThreadModerator
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ThreadID { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid UserID { get; set; }

        public virtual Thread Thread { get; set; }
    }
}
