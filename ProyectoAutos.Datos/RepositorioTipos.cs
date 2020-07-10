using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using ProyectoAutos.Entidades.Entities;

namespace ProyectoAutos.Datos
{
    public class RepositorioTipos
    {
        private readonly SqlConnection conexion;

        public RepositorioTipos(SqlConnection conexion)
        {
            this.conexion = conexion;
        }
        public List<Tipo> GetLista()
        {
            try
            {
                List<Tipo> lista=new List<Tipo>();
                string cadenaComando = "SELECT TipoId, Descripcion FROM Tipos";
                SqlCommand comando=new SqlCommand(cadenaComando,conexion);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Tipo tipo = ConstruirTipo(reader);
                    lista.Add(tipo);

                }
                reader.Close();
                return lista;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private Tipo ConstruirTipo(SqlDataReader reader)
        {
            return new Tipo()
            {
                TipoId = reader.GetInt32(0),
                Descripcion = reader.GetString(1)
            };
        }

        public void Agregar(Tipo tipo)
        {
            try
            {
                string cadenaComando = "INSERT INTO Tipos VALUES(@desc)";
                SqlCommand comando=new SqlCommand(cadenaComando, conexion);
                comando.Parameters.AddWithValue("@desc", tipo.Descripcion);
                comando.ExecuteNonQuery();
                cadenaComando = "SELECT @@IDENTITY";
                comando=new SqlCommand(cadenaComando,conexion);
                int id = (int) (decimal) comando.ExecuteScalar();
                tipo.TipoId = id;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Borrar(int tipoId)
        {
            try
            {
                string cadenaComando = "DELETE FROM Tipos WHERE TipoId=@id";
                SqlCommand comando=new SqlCommand(cadenaComando,conexion);
                comando.Parameters.AddWithValue("@id", tipoId);
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Editar(Tipo tipo)
        {
            try
            {

                string cadenaComando = "UPDATE Tipos SET Descripcion=@desc WHERE TipoId=@id";
                SqlCommand comando = new SqlCommand(cadenaComando, conexion);
                comando.Parameters.AddWithValue("@desc", tipo.Descripcion);
                comando.Parameters.AddWithValue("@id", tipo.TipoId);
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        public bool Existe(Tipo tipo)
        {
            try
            {
                if (tipo.TipoId==0)
                {
                    string cadenaComando = "SELECT TipoId, Descripcion FROM Tipos WHERE Descripcion=@desc";
                    SqlCommand comando=new SqlCommand(cadenaComando,conexion);
                    comando.Parameters.AddWithValue("@desc", tipo.Descripcion);
                    SqlDataReader reader = comando.ExecuteReader();
                    return reader.HasRows;
                }
                else
                {
                    string cadenaComando = "SELECT TipoId, Descripcion FROM Tipos WHERE Descripcion=@desc AND TipoId<>@id";
                    SqlCommand comando = new SqlCommand(cadenaComando, conexion);
                    comando.Parameters.AddWithValue("@desc", tipo.Descripcion);
                    comando.Parameters.AddWithValue("@id", tipo.TipoId);
                    SqlDataReader reader = comando.ExecuteReader();
                    return reader.HasRows;
                }
            }
            catch (Exception e)
            {
                
                throw new Exception(e.Message);
            }
        }
    }
}
