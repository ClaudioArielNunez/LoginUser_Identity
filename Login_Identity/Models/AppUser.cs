using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Login_Identity.Models
{
    public class AppUser : IdentityUser
    {
        //Ambos establecen una longitud máxima para una cadena
        //El 1º Se utiliza principalmente para validar datos en formularios y para fines de presentación en la capa de aplicación.
        //El 2º Se utiliza principalmente para asegurar que los datos en la base de datos no excedan la longitud especificada.
        [StringLength(100)]
        [MaxLength(100)]
        [Required]
        public string Name { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;


    }
}
