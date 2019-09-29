using Evimiz.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Evimiz.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Adınızı daxil edin"), StringLength(100, ErrorMessage = "Adınızın uzunluğu 100 herfden  artıq ola bilməz")]
        public string Firstname { get; set; }

        [StringLength(100, ErrorMessage = "Soyadanızın uzunluğu 100 herfden  artıq ola bilməz")]
        public string Lastname { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime RegisterDate { get; set; }

        public int NumberKeyCodeId { get; set; }
        public virtual NumberKeyCode NumberKeyCode { get; set; }

        public int? NumberKeyCodeSecondId { get; set; }
        public virtual NumberKeyCodeSecond NumberKeyCodeSecond { get; set; }

        [DataType(DataType.PhoneNumber,ErrorMessage ="Düzgün nömrə daxil edin"), StringLength(7, ErrorMessage = "Nömrənin  uzunluğu 7 reqemden artıq ola bilməz")]
        public string SecondPhonenumber { get; set; }

        [StringLength(100)]
        public string UserImageUrl { get; set; }

        [StringLength(700, ErrorMessage = "Məlumatın uzunluğu çoxdur")]
        public string Agencyabout { get; set; }

        [StringLength(100)]
        public string AgencyImageUrl { get; set; }

        public int? RegionId { get; set; }
        public virtual Region Region { get; set; }

        [Required(ErrorMessage = "Emailinizi daxil edin"), EmailAddress(ErrorMessage = "Düzgun email daxil edin"), DataType(DataType.EmailAddress, ErrorMessage = "Düzgun email daxil edin")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Nömrə daxil edin"), DataType(DataType.PhoneNumber, ErrorMessage = "Düzgün nömrə daxil edin"), StringLength(7, ErrorMessage = "Nömrənin  uzunluğu 7 reqemden artıq ola bilməz")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "İstifadəçi adınızı daxil edin"), StringLength(100, ErrorMessage = "İstifadəçi adınız 100 hərfden artıq ola bilməz")]
        public string Username { get; set; }

        [Required(ErrorMessage = "İstifadəçi parolunuzu daxil edin"), DataType(DataType.Password, ErrorMessage = "Düzgün şifrə qəbul edin")]
        public string Password { get; set; }

        [Compare(nameof(Password),ErrorMessage ="Təsdiq şifrəniz şifrə ilə eyni olmalıdır")]
        [Required(ErrorMessage = "Təsdiq parolunuzu daxil edin"), DataType(DataType.Password,ErrorMessage ="Düzgün şifrə qəbul edin")]
        public string ConfirePassword { get; set; }

        public bool İsAgent { get; set; }

        public bool İsUser { get; set; }

        [NotMapped]
        public IFormFile UserPhoto { get; set; }

        [NotMapped]
        public IFormFile AgencyPhoto { get; set; }
    }
}
