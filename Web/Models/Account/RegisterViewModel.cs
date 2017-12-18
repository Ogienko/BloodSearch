using System.ComponentModel.DataAnnotations;

namespace Web.Models.Account {

    public class RegisterViewModel {

        [Required]
        [StringLength(256, ErrorMessage = "Значение {0} должно содержать не более {1} символов")]
        [Display(Name = "Адрес электронной почты")]
        [RegularExpression(@"^[a-zA-Z0-9!#$%&'*+/=?^`{|}~]+(?:[\._-][a-zA-Z0-9!#$%&'*+/=?^`{|}~]+)*@(?:[a-zA-Z0-9](?:[a-zA-Z0-9-]*[a-zA-Z0-9])?\.)+[a-zA-Z0-9](?:[a-zA-Z0-9-]*[a-zA-Z0-9])?$", ErrorMessage = "Введен E-mail неверного формата")]
        public string Email { get; set; }

        [Required]
        [StringLength(64, ErrorMessage = "Значение {0} должно содержать не менее {2} символов", MinimumLength = 6)]
        [Display(Name = "Пароль")]
        [DataType(DataType.Password)]
        [RegularExpression(@"^\S.*\S$", ErrorMessage = "Введен пароль неверного формата")]
        public string Password { get; set; }

        public string Name { get; set; }

        public string Phone { get; set; }
    }
}