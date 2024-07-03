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
            cadenaConexion = @"Server = DESKTOP-IT61SAQ\SQLEXPRESS; Database=Cespedes.Dylan.Parcial; Trusted_Connection = True;";
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

                command.CommandText = "INSERT INTO DiscoDuros (tipoMarca, tamanio, capacidad, color, fechaCreacion) VALUES (@tipoMarca, @tamanio, @capacidad, @color, @fechaCreacion)";

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
                    string query = "UPDATE DiscoDuros SET tipoMarca = @tipoMarca, tamanio = @tamanio, capacidad = @capacidad, color = @color, fechaCreacion = @fechaCreacion WHERE id = @id";
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

                string sql = "DELETE FROM DiscoDuros ";
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



        public List<MemoriaRAM> ObtenerListaMemoriaRAM()
        {
            var memoriaRAM = new List<MemoriaRAM>();

            try
            {
                var command = new SqlCommand
                {
                    CommandType = CommandType.Text,
                    CommandText = "SELECT * FROM MemoriaRAM",
                    Connection = conexion,
                };

                conexion.Open();

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        EcolorMemoria colorEnum;
                        EmarcaMemoria tipoMarcaEnum;

                        var velocidad = Convert.ToInt32(reader["velocidad"]);
                        var color = reader["colorMemoria"].ToString();
                        Enum.TryParse(color, out colorEnum);
                        var tipoMarca = reader["marcaMemoria"].ToString();
                        Enum.TryParse(tipoMarca, out tipoMarcaEnum);
                        var fechaCreacionMemoria = Convert.ToDateTime(reader["fechaCreacionMemoria"]);
                        var capacidad = Convert.ToInt32(reader["capacidad"]);

                        var memoriaRamSQL = new MemoriaRAM
                        {
                            velocidad = velocidad,
                            colorMemoria = colorEnum,
                            marcaMemoria = tipoMarcaEnum,
                            fechaCreacionMemoria = fechaCreacionMemoria,
                            capacidad = capacidad
                        };

                        memoriaRAM.Add(memoriaRamSQL);

                    }
                }


                return memoriaRAM;
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

        public bool AgregarMemoriaRAM(MemoriaRAM param)
        {
            bool rta = true;

            try
            {

                command = new SqlCommand();

                command.CommandText = "INSERT INTO MemoriaRAM (velocidad, colorMemoria, marcaMemoria, fechaCreacionMemoria, capacidad) VALUES (@velocidad, @colorMemoria, @marcaMemoria, @fechaCreacionMemoria, @capacidad)";

                command.Parameters.AddWithValue("@velocidad", param.velocidad);
                command.Parameters.AddWithValue("@colorMemoria", param.colorMemoria);
                command.Parameters.AddWithValue("@marcaMemoria", param.marcaMemoria);
                command.Parameters.AddWithValue("@fechaCreacionMemoria", param.fechaCreacionMemoria);
                command.Parameters.AddWithValue("@capacidad", param.capacidad);


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
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

            return rta;
        }

        public bool ModificarMemoriaRAM(MemoriaRAM param)
        {
            bool rta = false;

            var memoriaRam = new List<MemoriaRAM>();

            try
            {
                using (SqlConnection conn = new SqlConnection(cadenaConexion))
                {
                    string query = "UPDATE MemoriaRAM SET velocidad = @velocidad, colorMemoria = @colorMemoria, marcaMemoria = @marcaMemoria, fechaCreacionMemoria = @fechaCreacionMemoria, capacidad = @capacidad WHERE id = @id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", param.id);
                    cmd.Parameters.AddWithValue("@velocidad", param.velocidad);
                    cmd.Parameters.AddWithValue("@colorMemoria", param.colorMemoria);
                    cmd.Parameters.AddWithValue("@marcaMemoria", param.marcaMemoria);
                    cmd.Parameters.AddWithValue("@fechaCreacionMemoria", param.fechaCreacionMemoria);
                    cmd.Parameters.AddWithValue("@capacidad", param.capacidad);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }


            }
            catch (Exception)
            {
                rta = false;
            }
            finally
            {
                if (conexion.State == System.Data.ConnectionState.Closed)
                {
                    conexion.Close();
                }
            }

            return rta;
        }

        public bool EliminarMemoriaRAM(int id)
        {
            bool rta = true;

            try
            {
                command = new SqlCommand();

                command.Parameters.AddWithValue("@id", id);

                string sql = "DELETE FROM MemoriaRAM ";
                sql += "WHERE id = @id";

                command.CommandType = CommandType.Text;
                command.CommandText = sql;
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
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

            return rta;
        }

        public List<TarjetaGrafica> ObtenerListaTarjetaGrafica()
        {
            var tarjetagrafica = new List<TarjetaGrafica>();

            try
            {
                var command = new SqlCommand
                {
                    CommandType = CommandType.Text,
                    CommandText = "SELECT * FROM TarjetaGrafica",
                    Connection = conexion,
                };

                conexion.Open();

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        EserieNvidia serieEnum;
                        EmarcaTarjeta tipoMarcaEnum;

                        var tipoMarca = reader["marcaTarjeta"].ToString();
                        Enum.TryParse(tipoMarca, out tipoMarcaEnum);
                        var serie = reader["serieNvidia"].ToString();
                        Enum.TryParse(serie, out serieEnum);
                        var modelo = Convert.ToInt32(reader["modelo"]);
                        var tamanioMemoria = Convert.ToInt32(reader["tamanioMemoria"]);
                        var fechaCreacionTarjeta = Convert.ToDateTime(reader["fechaCreacionTarjeta"]);

                        var tarjetaGraficaSQL = new TarjetaGrafica
                        {
                            marcaTarjeta = tipoMarcaEnum,
                            serieNvidia = serieEnum,
                            modelo = modelo,
                            tamanioMemoria = tamanioMemoria,
                            fechaCreacionTarjeta = fechaCreacionTarjeta
                        };

                        tarjetagrafica.Add(tarjetaGraficaSQL);

                    }
                }


                return tarjetagrafica;
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

        public bool AgregarTarjetaGrafica(TarjetaGrafica param)
        {
            bool rta = true;

            try
            {

                command = new SqlCommand();

                command.CommandText = "INSERT INTO TarjetaGrafia (marcaTarjeta, serieNvidia, modelo, tamanioMemoria, fechaCreacionTarjeta) VALUES (@marcaTarjeta, @serieNvidia, @modelo, @tamanioMemoria, @fechaCreacionTarjeta)";

                command.Parameters.AddWithValue("@marcaTarjeta", param.marcaTarjeta);
                command.Parameters.AddWithValue("@serieNvidia", param.serieNvidia);
                command.Parameters.AddWithValue("@modelo", param.modelo);
                command.Parameters.AddWithValue("@tamanioMemoria", param.tamanioMemoria);
                command.Parameters.AddWithValue("@fechaCreacionTarjeta", param.fechaCreacionTarjeta);


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
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

            return rta;
        }

        public bool ModificarTarjetaGrafica(TarjetaGrafica param)
        {
            bool rta = false;

            var tarjetaGrafica = new List<TarjetaGrafica>();

            try
            {
                using (SqlConnection conn = new SqlConnection(cadenaConexion))
                {
                    string query = "UPDATE TarjetaGrafica SET marcaTarjeta = @marcaTarjeta, serieNvidia = @serieNvidia, modelo = @modelo, tamanioMemoria = @tamanioMemoria, fechaCreacionTarjeta = @fechaCreacionTarjeta WHERE id = @id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", param.id);
                    cmd.Parameters.AddWithValue("@marcaTarjeta", param.marcaTarjeta);
                    cmd.Parameters.AddWithValue("@serieNvidia", param.serieNvidia);
                    cmd.Parameters.AddWithValue("@modelo", param.modelo);
                    cmd.Parameters.AddWithValue("@tamanioMemoria", param.tamanioMemoria);
                    cmd.Parameters.AddWithValue("@fechaCreacionTarjeta", param.fechaCreacionTarjeta);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }


            }
            catch (Exception)
            {
                rta = false;
            }
            finally
            {
                if (conexion.State == System.Data.ConnectionState.Closed)
                {
                    conexion.Close();
                }
            }

            return rta;
        }

        public bool EliminarTarjetaGrafica(int id)
        {
            bool rta = true;

            try
            {
                command = new SqlCommand();

                command.Parameters.AddWithValue("@id", id);

                string sql = "DELETE FROM TarjetaGrafica ";
                sql += "WHERE id = @id";

                command.CommandType = CommandType.Text;
                command.CommandText = sql;
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
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

            return rta;
        }
    }
}
