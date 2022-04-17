using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_Core_Angular.Models
{
    public class Category
    {
        public int Id { get; set; }

        public string CategoryName { get; set; }

        public virtual ICollection<Post> Posts { get; set; }


    }
}
