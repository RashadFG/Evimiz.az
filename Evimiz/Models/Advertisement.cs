using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Evimiz.Models
{
    public class Advertisement
    {
        public int Id { get; set; }
        
        public int PropertyCategoryId { get; set; }
        public virtual PropertyCategory PropertyCategory { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        [Required(ErrorMessage = "Mülkün sahəni daxil edin")]
        public int Area { get; set; }

        [StringLength(100)]
        public string ImageUrl { get; set; }

        [Required(ErrorMessage = "Qiyməti daxil edin")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Mulk haqqında məlumat daxil edin"), 
        StringLength(200, ErrorMessage ="Elan haqqında məlumat  daxil edin")]
        public string About { get; set; }

        public int PropertyRepairId { get; set; }
        public virtual PropertyRepair PropertyRepair { get; set; }

        public int PropertyDocumentId { get; set; }
        public virtual PropertyDocument PropertyDocument { get; set; }

        public DateTime PublishDate { get; set; }

        [Required(ErrorMessage = "Ünvanı daxil edin"),
        StringLength(200, ErrorMessage = "Ünvan uzunluğu maksimum 200 herflidir")]
        public string Address { get; set; }

        public int? NumberKeyCodeId { get; set; }
        public virtual NumberKeyCode NumberKeyCode { get; set; }

        public int? NumberKeyCodeSecondId { get; set; }
        public virtual NumberKeyCodeSecond NumberKeyCodeSecond { get; set; }

        [DataType(DataType.PhoneNumber), StringLength(7, ErrorMessage = "Düzgün Nömrə daxil edin")]
        public string FirstPhoneNumber { get; set; }

        [DataType(DataType.PhoneNumber), StringLength(7, ErrorMessage = "Düzgün Nömrə daxil edin")]
        public string SecondPhoneNumber { get; set; }

        public string İstifadəçiId { get; set; }
        public virtual İstifadəçi User { get; set; }

        public bool IsVip { get; set; }

        public bool IsConfirmed { get; set; }

        public bool IsDeleted { get; set; }

        public bool IsPremium { get; set; }

        public bool IsFavoruite { get; set; }

        public int RegionId { get; set; }
        public virtual Region Region { get; set; }

        public int? MetronId { get; set; }
        public virtual Metro Metro { get; set; }

        public int? VillageId { get; set; }
        public virtual Village Village { get; set; }

        public int HomeId { get; set; }
        public virtual Home Home { get; set; }

        public virtual ICollection<Image> Images { get; set; }

        [NotMapped]
        public IFormFile Photo { get; set; }

        [NotMapped]
        public ICollection<IFormFile> AllPhotos { get; set; }
    }
}
