using System;
using System.Collections.Generic;

public interface IRepoPlantilla
{
    public void AgregarPlantilla(Plantilla plantilla);
    public void EliminarPlantilla(Plantilla plantilla);
    public List<Plantilla> ObtenerPlantillas();

    //funciones de plantilla

    public void AgregarFutbolista(Plantilla plantilla, Futbolista futbolista);
    public void EcharFutbolista(Plantilla plantilla, Futbolista futbolista);
    public List<Futbolista> ObtenerFutbolistas(Plantilla plantilla);
    public List<Futbolista> ObtenerTitulares(Plantilla plantilla, Posicion posicion);
    public List<Futbolista> ObtenerSuplentes(Plantilla plantilla, Posicion posicion);
    public void ComprobarValidez(Plantilla plantilla);
}