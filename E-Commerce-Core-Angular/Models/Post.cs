using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_Core_Angular.Models
{
    public class Post : EntityBase
    {

        public string Title { get; set; }

        public string Content { get; set; }

        public virtual Category Categories { get; set; }

    }
}
