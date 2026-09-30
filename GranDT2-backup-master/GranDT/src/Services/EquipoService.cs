using System;
using System.Collections.Generic;


public class EquipoService

{
    private readonly IRepoEquipo _repoEquipo;

    public EquipoService(IRepoEquipo repoEquipo)
    {
        _repoEquipo = repoEquipo;
    }

    public void AgregarEquipo(Equipo equipo)
    {
        var equiposExistentes = _repoEquipo.ObtenerEquipos();

        // Verificar que no haya más de 32 equipos
        if (equiposExistentes.Count >= 32)
            throw new InvalidOperationException("No se pueden agregar más de 32 equipos.");

        // Verificar que el nombre no se repita
        if (equiposExistentes.Exists(e => e.Nombre.Equals(equipo.Nombre, StringComparison.OrdinalIgnoreCase)))
            throw new InvalidOperationException("Ya existe un equipo con ese nombre.");

        _repoEquipo.AgregarEquipo(equipo);
    }

}