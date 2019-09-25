using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Evimiz.ViewModels
{
    public class ForgetPasswordViewModel
    {
        [Required(ErrorMessage = "Emailinizi daxil edin"), EmailAddress(ErrorMessage = "Düzgun email daxil edin"), DataType(DataType.EmailAddress, ErrorMessage = "Düzgun email daxil edin")]
        public string Email { get; set; }
    }
}
