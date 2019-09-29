using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Evimiz.Models
{
    public class NumberKeyCode
    {
        public NumberKeyCode()
        {
            Advertisements = new HashSet<Advertisement>();
        }

        public int Id { get; set; }

        [Required(ErrorMessage = "Provayderi daxil edin")]
        public string Kcode { get; set; }

        public virtual ICollection<Advertisement> Advertisements { get; set; }

    }
}
