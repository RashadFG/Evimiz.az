using Evimiz.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Evimiz.ViewModels
{
    public class EditAgentPRofileViewModel
    {


        [Required(ErrorMessage = "Adınızı daxil edin"), StringLength(100, ErrorMessage = "Adınızın uzunluğu 100 herfden  artıq ola bilməz")]
        public string Firstname { get; set; }

        [StringLength(100)]
        public string AgencyImageUrl { get; set; }

        [StringLength(700, ErrorMessage = "Məlumatın uzunluğu çoxdur")]
        public string Agencyabout { get; set; }

        public int? RegionId { get; set; }
        public virtual Region Region { get; set; }

        [Required(ErrorMessage = "Emailinizi daxil edin"), EmailAddress(ErrorMessage = "Düzgun email daxil edin"), DataType(DataType.EmailAddress, ErrorMessage = "Düzgun email daxil edin")]
        public string Email { get; set; }

        public int NumberKeyCodeId { get; set; }

        [Required(ErrorMessage = "Nömrə daxil edin"), DataType(DataType.PhoneNumber, ErrorMessage = "Düzgün nömrə daxil edin"), StringLength(7, ErrorMessage = "Nömrənin  uzunluğu 7 reqemden artıq ola bilməz")]
        public string PhoneNumber { get; set; }

        public int NumberKeyCodeSecondId { get; set; }

        [DataType(DataType.PhoneNumber, ErrorMessage = "Düzgün nömrə daxil edin"), StringLength(7, ErrorMessage = "Nömrənin  uzunluğu 7 reqemden artıq ola bilməz")]
        public string SecondPhonenumber { get; set; }

        [DataType(DataType.Password, ErrorMessage = "Düzgün şifrə daxil edin")]
        public string CurrentPassword { get; set; }

        [DataType(DataType.Password, ErrorMessage = "Düzgün şifrə daxil edin")]
        public string NewPassword { get; set; }

        [NotMapped]
        public IFormFile AgencyPhoto { get; set; }
    }
}
