using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using ProyectoAutos.Entidades.Entities;

namespace ProyectoAutos.Datos
{
    public class RepositorioMarcas
    {
        private readonly SqlConnection conexion;
        public RepositorioMarcas()
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings["MiConexion"].ToString();
            conexion=new SqlConnection(cadenaConexion);
        }

        public List<Marca> GetMarcas()
        {
            List<Marca> lista=new List<Marca>();
            try
            {
                conexion.Open();
                string cadenaComando = "SELECT MarcaId, NombreMarca FROM Marcas";
                SqlCommand comando=new SqlCommand(cadenaComando,conexion);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Marca marca = ConstruirMarca(reader);
                    lista.Add(marca);
                }
                reader.Close();
                conexion.Close();
                return lista;
            }
            catch (Exception e)
            {
                
                throw new Exception(e.Message);
            }
        }

        private Marca ConstruirMarca(SqlDataReader reader)
        {
            return new Marca
            {
                MarcaId = reader.GetInt32(0),
                Nombre = reader.GetString(1)
            };
        }
    }
}
