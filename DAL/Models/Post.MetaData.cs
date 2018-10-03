using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DAL.Models
{
    [MetadataType(typeof(MetaData))]
    public partial class Post
    {
        private class MetaData
        {
            [DisplayName("Posted:")]
            public string PostDateTime { get; set; }

            [DisplayName("User")]
            public Guid? UserID { get; set; }
        }
    }
}
