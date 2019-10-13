using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Evimiz.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {
            Advertisements = new HashSet<Advertisement>();
        }

        [Required(ErrorMessage ="Adınızı daxil edin"), StringLength(100,ErrorMessage = "Adınızın uzunluğu 100 herfden  artıq ola bilməz")]
        public string Firstname { get; set; }

        [StringLength(100, ErrorMessage = "Soyadanızın uzunluğu 100 herfden  artıq ola bilməz")]
        public string Lastname { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime RegisterDate { get; set; }

        public int NumberKeyCodeId { get; set; }
        public virtual NumberKeyCode NumberKeyCode { get; set; }

        public int? NumberKeyCodeSecondId { get; set; }
        public virtual NumberKeyCodeSecond NumberKeyCodeSecond { get; set; }

        [DataType(DataType.PhoneNumber,ErrorMessage ="Düzgun nömrə daxil edin"),StringLength(7, ErrorMessage = "Nömrənin  uzunluğu 7 reqemden artıq ola bilməz")]
        public string SecondPhonenumber { get; set; }

        [StringLength(100)]
        public string UserImageUrl { get; set; }

        [StringLength(700, ErrorMessage = "Məlumatın uzunluğu çoxdur")]
        public string Agencyabout { get; set; }

        public bool İsAgent { get; set; }

        public bool İsUser { get; set; }

        [StringLength(100)]
        public string AgencyImageUrl { get; set; }

        public int? RegionId { get; set; }
        public virtual Region Region { get; set; }

        [NotMapped]
        public IFormFile UserPhoto { get; set; }

        [NotMapped]
        public IFormFile AgencyPhoto { get; set; }

        public virtual ICollection<Advertisement> Advertisements { get; set; }
    }
}
