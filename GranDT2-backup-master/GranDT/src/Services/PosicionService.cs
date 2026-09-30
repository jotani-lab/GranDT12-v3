using System;
using System.Collections.Generic;

public class PosicionService : IRepoPosicion
{
    public List<Posicion> ObtenerPosiciones()
    {
        List<Posicion> posiciones = new List<Posicion>();
        {
            new Posicion { IdPosicion = 1, NombrePosicion = "Arquero" };
            new Posicion { IdPosicion = 2, NombrePosicion = "Defensor" };
            new Posicion { IdPosicion = 3, NombrePosicion = "Mediocampista" };
            new Posicion { IdPosicion = 4, NombrePosicion = "Delantero" };
        }
        return posiciones;
    }
}