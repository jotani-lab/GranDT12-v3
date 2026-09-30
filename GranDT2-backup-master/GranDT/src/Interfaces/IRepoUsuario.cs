using System;
using System.Collections.Generic;
public interface IRepoUsuario
{
    public void AgregarUsuario(Usuario usuario);
    public void EliminarUsuario(Usuario usuario);
    public void ActualizarUsuario(Usuario usuario);
    public void GenerarPlantilla(Usuario usuario, Plantilla plantilla);
    public List<Usuario> ObtenerUsuarios();
}