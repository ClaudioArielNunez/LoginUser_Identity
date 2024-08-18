using System.ComponentModel.DataAnnotations;

namespace Login_Identity.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "El {0} es requerido")]
        [Display(Name = "Nombre")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "El {0} es requerido")]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }

        [Required(ErrorMessage = "El {0} es requerido")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [Compare("Password", ErrorMessage = "El password no coincide")]
        [Display(Name = "Confirmar Password")]
        public string? ConfirmPassword { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Name = "Dirección")]
        public string? Address { get; set; }
    }
}
