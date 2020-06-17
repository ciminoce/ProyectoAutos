using System.Collections.Generic;
using ProyectoAutos.Datos;
using ProyectoAutos.Entidades.Entities;

namespace ProyectoAutos.Servicios
{
    public class ServicioMarcas
    {
        private readonly RepositorioMarcas repositorio;
        public ServicioMarcas()
        {
            repositorio=new RepositorioMarcas();
        }

        public List<Marca> GetMarcas()
        {
            return repositorio.GetMarcas();
        }

        public void Borrar(int MarcaId)
        {
            repositorio.Borrar(MarcaId);
        }

        public void Editar(Marca marca)
        {
            repositorio.Editar(marca);
        }

        public void Agregar(Marca marca)
        {
            repositorio.Agregar(marca);
        }

        public bool Existe(Marca marca)
        {
            return repositorio.Existe(marca);
        }
    }
}
