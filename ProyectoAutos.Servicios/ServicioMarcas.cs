using System.Collections.Generic;
using ProyectoAutos.Datos;
using ProyectoAutos.Entidades.DTOs.Marca;
using ProyectoAutos.Entidades.Entities;
using ProyectoAutos.Entidades.Mapas;

namespace ProyectoAutos.Servicios
{
    public class ServicioMarcas
    {
        private RepositorioMarcas repositorio;
        private ConexionBd conexionBd;
        public ServicioMarcas()
        {

           
        }

        public List<MarcaDto> GetMarcas()
        {
            conexionBd=new ConexionBd();
            repositorio=new RepositorioMarcas(conexionBd.AbrirConexion());
            var lista= repositorio.GetMarcas();
            conexionBd.CerrarConexion();
            return lista;
        }

        public void Borrar(int MarcaId)
        {
            conexionBd=new ConexionBd();
            repositorio=new RepositorioMarcas(conexionBd.AbrirConexion());
            repositorio.Borrar(MarcaId);
            conexionBd.CerrarConexion();
        }

        public void Editar(MarcaDto marcaDto)
        {
            conexionBd=new ConexionBd();
            repositorio=new RepositorioMarcas(conexionBd.AbrirConexion());
            var marca = Mapeador.ConvertirAMarca(marcaDto);
            repositorio.Editar(marca);
            conexionBd.CerrarConexion();
        }

        public void Agregar(MarcaDto marcaDto)
        {
            conexionBd=new ConexionBd();
            repositorio=new RepositorioMarcas(conexionBd.AbrirConexion());
            var marca = Mapeador.ConvertirAMarca(marcaDto);
            repositorio.Agregar(marca);
            conexionBd.CerrarConexion();
        }

        public bool Existe(MarcaDto marcaDto)
        {
            conexionBd=new ConexionBd();
            repositorio=new RepositorioMarcas(conexionBd.AbrirConexion());
            var existe= repositorio.Existe(marcaDto);
            conexionBd.CerrarConexion();
            return existe;
        }
    }
}
