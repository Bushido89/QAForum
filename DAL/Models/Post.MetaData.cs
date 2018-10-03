using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    [MetadataType(typeof(MetaData))]
    public partial class Post
    {
        private class MetaData
        {
            [DisplayName("Posted:")]
            public string PostDateTime { get; set; }

            public void hax()
            {
                
            }
        }
    }
}
