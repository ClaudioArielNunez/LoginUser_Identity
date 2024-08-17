using System.ComponentModel.DataAnnotations;

namespace Login_Identity.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "El {0} es requerido")]
        [Display(Name = "Usuario")]
        public string? UserName { get; set; }

        [Required(ErrorMessage = "El {0} es requerido")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [Display(Name = "Recuérdame")]
        public bool RememberMe { get; set; }

    }
}
