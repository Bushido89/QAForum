using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DAL.Models
{
    [MetadataType(typeof(MetaData))]
    public partial class Forum
    {
        internal sealed class MetaData
        {
            [DisplayName("Title")]
            public string ForumTitle { get; set; }
        }
    }
}