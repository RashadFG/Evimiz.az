using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Evimiz.Models
{
    public class Order
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Adınızı daxil edin"), StringLength(100, ErrorMessage = "Adınızın uzunluğu 100 herfden  artıq ola bilməz")]
        public string FirstLastName { get; set; }

        [Required(ErrorMessage = "Sifariş başlığını əlavə edin"), StringLength(100, ErrorMessage = "Sifariş başlığını 100 hərfdən artiq ola bilməz")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Sifariş başlığını əlavə edin"), StringLength(200, ErrorMessage = "Sifariş haqqında 200 hərfdən artiq ola bilməz")]
        public string Info { get; set; }

        public int NumberKeyCodeId { get; set; }
        public virtual NumberKeyCode NumberKeyCode { get; set; }

        public int? NumberKeyCodeSecondId { get; set; }
        public virtual NumberKeyCodeSecond NumberKeyCodeSecond { get; set; }

        [DataType(DataType.PhoneNumber, ErrorMessage = "Düzgun nömrə daxil edin"), StringLength(7, ErrorMessage = "Nömrənin  uzunluğu 7 reqemden artıq ola bilməz")]
        public string FirstNumber { get; set; }

        [DataType(DataType.PhoneNumber, ErrorMessage = "Düzgun nömrə daxil edin"), StringLength(7, ErrorMessage = "Nömrənin  uzunluğu 7 reqemden artıq ola bilməz")]
        public string LastNumber{ get; set; }

        public int PropertyCategoryId { get; set; }
        public virtual PropertyCategory PropertyCategory { get; set; }

        public int? RentId { get; set; }
        public virtual Rent Rent { get; set; }
    }
}
