using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Evimiz.Models
{
    public class Villa
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Otaq sayını daxil edin")]
        public int RoomCount { get; set; }

        [Required(ErrorMessage = "Mərətbə sayını daxil edin")]
        public int Floor { get; set; }
    }
}