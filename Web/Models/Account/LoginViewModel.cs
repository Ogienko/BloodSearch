using System.ComponentModel.DataAnnotations;

namespace Web.Models.Account {

    public class LoginViewModel {

        [Required]
        [Display(Name = "Адрес электронной почты")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Пароль")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}