using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Evimiz.Models
{
    public class News
    {
        public int Id { get; set; }

        public int ViewCount { get; set; }

        [StringLength(100)]
        public string ImageUrl { get; set; }

        [Required(ErrorMessage ="Xəbər başlığını əlavə edin"), StringLength(60,ErrorMessage = "Xəbər başlığını 60 hərfdən artiq ola bilməz")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Xəbər haqqıda məlumat əlavə edin")]
        public string Info { get; set; }

        public DateTime PublishDate { get; set; }

        [Required(ErrorMessage = "MMüəllifi əlavə edin"), StringLength(100,ErrorMessage = "Müəllifin adı 100 hərfdən artiq ola bilməz")]
        public string Author { get; set; }

        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
