using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Drawing;
using System.Data;


namespace Entidades.BaseSQL
{
    public class GestorDeDatos
    {
        private static SqlConnection conexion;
        private static string cadenaConexion;
        private static SqlCommand? command;

        static GestorDeDatos()
        {
            cadenaConexion = @"Server = .; Database=Cespedes.Dylan.Parcial; Trusted_Connection = True;";
            conexion = new SqlConnection(cadenaConexion);

            command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = conexion;
        }

        public GestorDeDatos()
        {
            conexion = new SqlConnection(GestorDeDatos.cadenaConexion);
        }

        public List<DiscoDuro> ObtenerListaDiscoDuro()
        {
            var discoDuro = new List<DiscoDuro>();

            try
            {
                var command = new SqlCommand
                {
                    CommandType = CommandType.Text,
                    CommandText = "SELECT * FROM DiscoDuro",
                    Connection = conexion,
                };

                conexion.Open();

                using (var reader = command.ExecuteReader())    
                {
                    while (reader.Read())
                    {
                        Ecolor colorEnum;
                        EmarcaDisco tipoMarcaEnum;

                        var tipoMarca = reader["tipoMarca"].ToString();
                        Enum.TryParse(tipoMarca, out tipoMarcaEnum);
                        var tamanio = reader["tamanio"].ToString();
                        var capacidad = reader["capacidad"].ToString();
                        var color = reader["color"].ToString();
                        Enum.TryParse(color, out colorEnum);
                        var fechaCreacion = Convert.ToDateTime(reader["fechaCreacion"]);

                        var discoDuroSQL = new DiscoDuro
                        {
                            tipoMarca = tipoMarcaEnum,
                            tamanio = tamanio,
                            capacidad = capacidad,
                            color = colorEnum,
                            fechaCreacion = fechaCreacion
                        };

                        discoDuro.Add(discoDuroSQL);

                    }
                }


                return discoDuro;
            }
            catch (Exception)
            {
                throw new Exception("Hubo un error en la conexion de la base de datos");
            }
            finally
            {
                conexion.Close();
            }
        }

        public bool AgregarDiscoDuro(DiscoDuro param)
        {
            bool rta = true;

            try
            {

                command = new SqlCommand();

                command.CommandText = "INSERT INTO DiscoDuro (id, tipoMarca, tamanio, capacidad, color, fechaCreacion) VALUES (@id, @tipoMarca, @tamanio, @capacidad, @color, @fechaCreacion)";

                command.Parameters.AddWithValue("@id", param.id);
                command.Parameters.AddWithValue("@tipoMarca", param.tipoMarca);
                command.Parameters.AddWithValue("@tamanio", param.tamanio);
                command.Parameters.AddWithValue("@capacidad", param.capacidad);
                command.Parameters.AddWithValue("@color", param.color);
                command.Parameters.AddWithValue("@fechaCreacion", param.fechaCreacion);


                command.CommandType = CommandType.Text;
                command.Connection = conexion;

                conexion.Open();

                int filasAfectadas = command.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    rta = false;
                }
            }
            catch (Exception)
            {
                rta = false;
            }
            finally
            {
                if(conexion.State == ConnectionState.Open) 
                {
                    conexion.Close();
                }
            }

            return rta;
        }

        public bool ModificarDiscoDuro(DiscoDuro param) 
        {
            bool rta = false;

            var discoDuro = new List<DiscoDuro>();

            try
            {
                using (SqlConnection conn = new SqlConnection(cadenaConexion))
                {
                    string query = "UPDATE DiscoDuro SET tipoMarca = @tipoMarca, tamanio = @tamanio, capacidad = @capacidad, color = @color, fechaCreacion = @fechaCreacion WHERE id = @id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", param.id);
                    cmd.Parameters.AddWithValue("@tipoMarca", param.tipoMarca);
                    cmd.Parameters.AddWithValue("@tamanio", param.tamanio);
                    cmd.Parameters.AddWithValue("@capacidad", param.capacidad);
                    cmd.Parameters.AddWithValue("@color", param.color);
                    cmd.Parameters.AddWithValue("@fechaCreacion", param.fechaCreacion);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }


            }
            catch(Exception) 
            {
                rta = false;
            }
            finally 
            {
                if(conexion.State == System.Data.ConnectionState.Closed)
                {
                    conexion.Close();
                }
            }

            return rta;
        }

        public bool EliminarDiscoDuro(int id)
        {
            bool rta = true;

            try
            {
                command = new SqlCommand();

                command.Parameters.AddWithValue("@id", id);

                string sql = "DELETE FROM DiscoDuro ";
                sql += "WHERE id = @id";

                command.CommandType = CommandType.Text;
                command.CommandText = sql;
                command.Connection = conexion;

                conexion.Open();

                int filasAfectadas = command.ExecuteNonQuery();

                if(filasAfectadas == 0)
                {
                    rta = false;
                }

            }
            catch(Exception)
            {
                rta = false;
            
            }
            finally
            {
                if(conexion.State == ConnectionState.Open) 
                {
                    conexion.Close();
                }
            }

            return rta;
        }



    }
}
