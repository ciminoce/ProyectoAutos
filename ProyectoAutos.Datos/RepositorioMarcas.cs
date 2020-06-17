using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using ProyectoAutos.Entidades.Entities;

namespace ProyectoAutos.Datos
{
    public class RepositorioMarcas
    {
        private readonly SqlConnection _conexion;
        public RepositorioMarcas()
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings["MiConexion"].ToString();
            _conexion=new SqlConnection(cadenaConexion);
        }

        public List<Marca> GetMarcas()
        {
            List<Marca> lista=new List<Marca>();
            try
            {
                _conexion.Open();
                string cadenaComando = "SELECT MarcaId, NombreMarca FROM Marcas";
                SqlCommand comando=new SqlCommand(cadenaComando,_conexion);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Marca marca = ConstruirMarca(reader);
                    lista.Add(marca);
                }
                reader.Close();
                _conexion.Close();
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
                _conexion.Open();
                string cadenaComando = "DELETE FROM Marcas WHERE MarcaId=@id";
                SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                comando.Parameters.AddWithValue("@id", marcaId);
                comando.ExecuteNonQuery();
                _conexion.Close();

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
                _conexion.Open();
                string cadenaComando = "UPDATE Marcas SET NombreMarca=@nombre WHERE MarcaId=@id";
                SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                comando.Parameters.AddWithValue("@nombre", marca.Nombre);
                comando.Parameters.AddWithValue("@id", marca.MarcaId);
                comando.ExecuteNonQuery();
                _conexion.Close();

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
                _conexion.Open();
                string cadenaComando = "INSERT INTO Marcas VALUES(@nombre)";
                SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                comando.Parameters.AddWithValue("@nombre", marca.Nombre);
                comando.ExecuteNonQuery();
                cadenaComando = "SELECT @@IDENTITY";
                comando=new SqlCommand(cadenaComando,_conexion);
                marca.MarcaId =(int)(decimal) comando.ExecuteScalar();
                _conexion.Close();

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool Existe(Marca marca)
        {
            try
            {
                _conexion.Open();
                SqlCommand comando;
                if (marca.MarcaId==0)
                {
                    string cadenaComando = "SELECT MarcaId, NombreMarca FROM Marcas WHERE NombreMarca=@nombre";
                    comando = new SqlCommand(cadenaComando, _conexion);
                    comando.Parameters.AddWithValue("@nombre", marca.Nombre);
                    
                }
                else
                {
                    string cadenaComando = "SELECT MarcaId, NombreMarca FROM Marcas WHERE NombreMarca=@nombre AND Marcaid<>@id";
                     comando = new SqlCommand(cadenaComando, _conexion);
                    comando.Parameters.AddWithValue("@nombre", marca.Nombre);
                    comando.Parameters.AddWithValue("@id", marca.MarcaId);


                }
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    return true;
                }

                return false;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }
    }
}
