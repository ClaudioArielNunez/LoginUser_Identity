using Microsoft.AspNetCore.Identity;

namespace Login_Identity.Models
{
    public class CustomIdentityErrorDescriber : IdentityErrorDescriber
    {
        //Sobre escrituras de mensaje de error cuando la password es menor a 8 caracteres
        public override IdentityError PasswordTooShort(int length)
        {
            return new IdentityError
            {
                Code = nameof(PasswordTooShort),
                Description = $"La contraseña debe tener al menos {length} caracteres."
            };
        }

        //Sobre escrituras de mensaje de error cuando la password no tiene al menos una mayúscula
        public override IdentityError PasswordRequiresUpper()
        {
            return new IdentityError
            {
                Code = nameof(PasswordRequiresUpper),
                Description = "El password debe tener al menos una letra mayúscula"
            };
        }
    }
}
