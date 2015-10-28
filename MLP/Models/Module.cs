using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MLP.Models
{
    public class Module
    {
        public Module()
        {
            Contents = new HashSet<Content>();
        }

        public int ModuleId { get; set; }

        public string ModuleName { get; set; }

        public int CourseId { get; set; }

        public virtual ICollection<Content> Contents { get; set; }

        public virtual Course Course { get; set; }
    }
}