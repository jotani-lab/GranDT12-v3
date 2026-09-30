using System;
public class Posicion
{
    public ushort IdPosicion {get; set;}
    public required string NombrePosicion {get; set;}

    public bool EsValido()
    {
        if (string.IsNullOrWhiteSpace(NombrePosicion))
            return false;            
        return true;
    }
}