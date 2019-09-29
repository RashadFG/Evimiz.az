using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Evimiz.Models
{
    public class PropertyCategory
    {
        public PropertyCategory()
        {
            Orders = new HashSet<Order>();
            Advertisements = new HashSet<Advertisement>();
        }

        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; }

        public virtual ICollection<Advertisement> Advertisements { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
