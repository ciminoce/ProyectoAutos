using System.Collections.Generic;
using ProyectoAutos.Datos;
using ProyectoAutos.Entidades.Entities;

namespace ProyectoAutos.Servicios
{
    public class ServicioTipos
    {
        private  RepositorioTipos repositorio;
        private ConexionBd conexionBd;

        public ServicioTipos()
        {
            
        }
        public List<Tipo> GetLista()
        {
            conexionBd=new ConexionBd();
            repositorio=new RepositorioTipos(conexionBd.AbrirConexion());
            var lista= repositorio.GetLista();
            conexionBd.CerrarConexion();
            return lista;
        }

        public void Agregar(Tipo tipo)
        {
            conexionBd=new ConexionBd();
            repositorio=new RepositorioTipos(conexionBd.AbrirConexion());
            repositorio.Agregar(tipo);
            conexionBd.CerrarConexion();
        }

        public void Borrar(int tipoId)
        {
            conexionBd=new ConexionBd();
            repositorio=new RepositorioTipos(conexionBd.AbrirConexion());
            repositorio.Borrar(tipoId);
            conexionBd.CerrarConexion();

        }

        public void Editar(Tipo tipo)
        {
            conexionBd=new ConexionBd();
            repositorio=new RepositorioTipos(conexionBd.AbrirConexion());
            repositorio.Editar(tipo);
            conexionBd.CerrarConexion();
        }

        public bool Existe(Tipo tipo)
        {
            conexionBd=new ConexionBd();
            repositorio=new RepositorioTipos(conexionBd.AbrirConexion());
            var existe = repositorio.Existe(tipo);
            conexionBd.CerrarConexion();
            return existe;
        }
    }
}
