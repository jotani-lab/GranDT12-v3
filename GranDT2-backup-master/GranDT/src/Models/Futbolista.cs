using System;
public class Futbolista
{
    // nombres, apellidos, apodo (opcional), fecha de nacimiento  y 
    // equipo al que pertenece. A su vez, cada jugador posee una 
    // cotización, es decir, el monto de contratarlo en las plantillas 
    // de los usuarios.

    public int IdJugador {get; set;}
    public required string Nombre {get; set;} = string.Empty;
    public required string Apellido {get; set;} = string.Empty;
    public string? Apodo {get; set;}
    public required string Posicion { get; set; }
    public DateOnly FechaNacimiento {get; set;}
    public required double Cotizacion {get; set;}

    public bool EsValido()
    {
        if (string.IsNullOrWhiteSpace(Nombre) || string.IsNullOrWhiteSpace(Apellido) || string.IsNullOrWhiteSpace(Posicion))
            return false;
            
        return true;
    }
}
