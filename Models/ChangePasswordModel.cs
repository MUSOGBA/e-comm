using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OrnekSite.Models
{
    public class ChangePasswordModel
    {
        [Required]
        [DisplayName("Eski Şifre")]
        public string OldPassword { get; set; }
        [Required]
        [DisplayName("Yeni Şifre")]
        [StringLength(100,MinimumLength =5,ErrorMessage ="Şifreniz En az 5 karakter içermelidir!...")]
        public string NewPassword { get; set; }
        [Required]
        [DisplayName("Yeni Şifre")]
        [Compare("NewPassword",ErrorMessage ="Şifreler Uyuşmuyor...")]
        public string ConNewPassword { get; set; }
    }
}