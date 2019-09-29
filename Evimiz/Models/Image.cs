using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Evimiz.Models
{
    public class Image
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public bool IsMainPhoto { get; set; }

        public int AdvertisementId { get; set; }
        public virtual Advertisement Advertisement { get; set; }
    }
}
