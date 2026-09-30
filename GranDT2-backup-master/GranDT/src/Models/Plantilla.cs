using System;
public class Plantilla
{
    public double Presupuesto {get ; set;}
    public int CantJugadoresmax {get ; set;} = 20;

    public bool EsValido()
    {
        if (Presupuesto < 0 || CantJugadoresmax <= 0)
            return false;
        
        if (Presupuesto > 99999999.99 || CantJugadoresmax > 20)
            return false;
        return true;
    }
    
}