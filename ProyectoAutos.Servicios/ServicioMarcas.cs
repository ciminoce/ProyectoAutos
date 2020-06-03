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
    }
}
