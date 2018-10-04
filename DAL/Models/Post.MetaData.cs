using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web;
using System.Web.Script.Serialization;

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

            [StringLength(255)]
            [DisplayName("Post")]
            [DataType(DataType.MultilineText)]
            public string PostBody { get; set; }

            
            public Thread Thread { get; set; }
        }
    }
}
