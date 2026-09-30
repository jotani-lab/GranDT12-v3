using System.Collections.Generic;

public interface IRepoFutbolista
{
            void AgregarFutbolista(Futbolista futbolista);

            Futbolista? ObtenerFutbolistaPorId(int id);

            List<Futbolista> ObtenerFutbolistas();

            void ActualizarFutbolista(Futbolista futbolista);

            void BorrarFutbolista(int id);

            List<Futbolista> ObtenerFutbolistasPorNombre(string nombre);

            // Buscar futbolistas por posición
            List<Futbolista> ObtenerFutbolistasPorPosicion(string posicion);
}
