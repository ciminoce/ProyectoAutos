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

        public void Borrar(int marcaId)
        {
            try
            {
                conexion.Open();
                string cadenaComando = "DELETE FROM Marcas WHERE MarcaId=@id";
                SqlCommand comando = new SqlCommand(cadenaComando, conexion);
                comando.Parameters.AddWithValue("@id", marcaId);
                comando.ExecuteNonQuery();
                conexion.Close();

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Editar(Marca marca)
        {
            try
            {
                conexion.Open();
                string cadenaComando = "UPDATE Marcas SET NombreMarca=@nombre WHERE MarcaId=@id";
                SqlCommand comando = new SqlCommand(cadenaComando, conexion);
                comando.Parameters.AddWithValue("@nombre", marca.Nombre);
                comando.Parameters.AddWithValue("@id", marca.MarcaId);
                comando.ExecuteNonQuery();
                conexion.Close();

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        public void Agregar(Marca marca)
        {
            try
            {
                conexion.Open();
                string cadenaComando = "INSERT INTO Marcas VALUES(@nombre)";
                SqlCommand comando = new SqlCommand(cadenaComando, conexion);
                comando.Parameters.AddWithValue("@nombre", marca.Nombre);
                comando.ExecuteNonQuery();
                cadenaComando = "SELECT @@IDENTITY";
                comando=new SqlCommand(cadenaComando,conexion);
                marca.MarcaId =(int)(decimal) comando.ExecuteScalar();
                conexion.Close();

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
