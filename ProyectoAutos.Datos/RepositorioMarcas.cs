using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using ProyectoAutos.Entidades.DTOs.Marca;
using ProyectoAutos.Entidades.Entities;
using ProyectoAutos.Entidades.Mapas;

namespace ProyectoAutos.Datos
{
    public class RepositorioMarcas
    {
        private readonly SqlConnection _conexion;

        public RepositorioMarcas(SqlConnection conexion)
        {
            _conexion = conexion;
        }

        public List<MarcaDto> GetMarcas()
        {
            List<MarcaDto> lista=new List<MarcaDto>();
            try
            {
                string cadenaComando = "SELECT MarcaId, NombreMarca FROM Marcas";
                SqlCommand comando=new SqlCommand(cadenaComando,_conexion);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Marca marca = ConstruirMarca(reader);
                    MarcaDto marcaDto = Mapeador.ConvertirAMarcaDto(marca);
                    lista.Add(marcaDto);
                }
                reader.Close();
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
                string cadenaComando = "DELETE FROM Marcas WHERE MarcaId=@id";
                SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                comando.Parameters.AddWithValue("@id", marcaId);
                comando.ExecuteNonQuery();

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
                string cadenaComando = "UPDATE Marcas SET NombreMarca=@nombre WHERE MarcaId=@id";
                SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                comando.Parameters.AddWithValue("@nombre", marca.Nombre);
                comando.Parameters.AddWithValue("@id", marca.MarcaId);
                comando.ExecuteNonQuery();

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
                string cadenaComando = "INSERT INTO Marcas VALUES(@nombre)";
                SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                comando.Parameters.AddWithValue("@nombre", marca.Nombre);
                comando.ExecuteNonQuery();
                cadenaComando = "SELECT @@IDENTITY";
                comando=new SqlCommand(cadenaComando,_conexion);
                marca.MarcaId =(int)(decimal) comando.ExecuteScalar();

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool Existe(MarcaDto marcaDto)
        {
            try
            {
                SqlCommand comando;
                if (marcaDto.MarcaId==0)
                {
                    string cadenaComando = "SELECT MarcaId, NombreMarca FROM Marcas WHERE NombreMarca=@nombre";
                    comando = new SqlCommand(cadenaComando, _conexion);
                    comando.Parameters.AddWithValue("@nombre", marcaDto.Nombre);
                    
                }
                else
                {
                    string cadenaComando = "SELECT MarcaId, NombreMarca FROM Marcas WHERE NombreMarca=@nombre AND Marcaid<>@id";
                     comando = new SqlCommand(cadenaComando, _conexion);
                    comando.Parameters.AddWithValue("@nombre", marcaDto.Nombre);
                    comando.Parameters.AddWithValue("@id", marcaDto.MarcaId);


                }
                SqlDataReader reader = comando.ExecuteReader();
                return reader.HasRows;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }
    }
}
