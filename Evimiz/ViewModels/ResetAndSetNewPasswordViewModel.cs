using System.ComponentModel.DataAnnotations;

namespace Evimiz.ViewModels
{
    public class ResetAndSetNewPasswordViewModel
    {
        [Required(ErrorMessage = "İstifadəçi parolunuzu daxil edin"), DataType(DataType.Password, ErrorMessage = "Düzgün şifrə qəbul edin")]
        public string NewPassword { get; set; }

        [Required(ErrorMessage = "İstifadəçi parolunuzu daxil edin"), DataType(DataType.Password, ErrorMessage = "Düzgün şifrə qəbul edin"), Compare("NewPassword", ErrorMessage = "Daxil etdiyiniz şifrə ilə uyğun gəlmir")]
        public string ConfirmNewPassword { get; set; }

        public string UserId { get; set; }
        public string PasswordResetToken { get; set; }
    }
}
