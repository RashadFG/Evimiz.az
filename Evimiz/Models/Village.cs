﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Evimiz.Models
{
    public class Village
    {
        public Village()
        {
            Homes = new HashSet<Home>();
        }
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; }

        public virtual ICollection<Home> Homes { get; set; }

    }
}
