using System;

public class Equipo
{
    public int idEquipo {get; set;}
    public string Nombre {get; set;} = string.Empty; //falta poner que no se puedan repetir y poner de limite 32

    public bool EsValido()
    {
        if (string.IsNullOrWhiteSpace(Nombre) || Nombre.Length > 32)
            return false;

        
        return true;
    }
}