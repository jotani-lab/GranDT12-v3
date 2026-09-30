//De nuestros usuarios, es importante conocer su nombre, apellido, email (único por cada usuario),
//fecha de nacimiento y contraseña. El sistema deberá soportar hasta 2000 usuarios. Es importante tener en cuenta que
//para la persistencia del usuario, mediante un algoritmo de encriptación, todas las contraseñas tendrán una longitud 
//fija de 64 caracteres.
using System;

public class Usuario
{
    public int idUsuario { get; set; }
    public required string Nombre { get; set; } = string.Empty;
    public required string Apellido { get; set; } = string.Empty;
    public required string Email { get; set; } = string.Empty; //falta poner que sea unico
    public DateTime FechaNacimiento { get; set; }
    public required string Contrasenia { get; set; } = string.Empty;

    public bool EsValido()
    {
        if (string.IsNullOrWhiteSpace(Nombre) || string.IsNullOrWhiteSpace(Apellido))
            return false;

        if (!Email.Contains("@"))
            return false;
            
        return true;
    }
}