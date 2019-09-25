﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Evimiz.Models
{
    public class PropertyRepair
    {
        public PropertyRepair()
        {
            Advertisements = new HashSet<Advertisement>();
        }

        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; }

        public virtual ICollection<Advertisement> Advertisements { get; set; }
    }
}
