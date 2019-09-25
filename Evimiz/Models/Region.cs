using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Evimiz.Models
{
    public class Region
    {
        public Region()
        {
            Advertisement = new HashSet<Advertisement>();
            İstifadəçilər = new HashSet<İstifadəçi>();
        }

        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; }

        public int CityId { get; set; }
        public virtual City City { get; set; }

        public virtual ICollection<Advertisement> Advertisement { get; set; }
        public virtual ICollection<İstifadəçi> İstifadəçilər { get; set; }
    }
}
