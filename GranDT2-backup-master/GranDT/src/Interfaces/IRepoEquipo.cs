using System;
using System.Collections.Generic;
 
public interface IRepoEquipo
{   
    public void AgregarEquipo(Equipo equipo);
    public void EliminarEquipo(Equipo equipo);
    public void ActualizarEquipo(Equipo equipo);
    public List<Equipo> ObtenerEquipos();
}