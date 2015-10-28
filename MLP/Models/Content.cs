using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MLP.Models
{
    public class Content
    {
        public int ContentId { get; set; }

      
        public string Description { get; set; }

        public int ModuleId { get; set; }

        public virtual Module Module { get; set; }
    }
}