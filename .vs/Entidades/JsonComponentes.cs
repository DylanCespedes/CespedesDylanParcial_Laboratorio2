using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Entidades
{
    public class JsonComponentes
    {


        private string urlFullPathDisco;

        private string urlFullPathMemoria;

        private string urlFullPathTarjeta;

        public JsonComponentes(string path)
        {
            this.urlFullPathDisco = "../../../../DiscoDuro.json";
            this.urlFullPathMemoria = "../../../../MemoriaRAM.json";
            this.urlFullPathTarjeta = "../../../../TarjetaGrafica.json";
            //this.urlFullPath += "Documentos";
        }

        public void GuardarDiscoDuroJson(List<DiscoDuro> listaDiscoDuro)
        {
            try
            {
                JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions();
                jsonSerializerOptions.WriteIndented = true;
                var json = JsonSerializer.Serialize(listaDiscoDuro, jsonSerializerOptions);



                using (var write = new StreamWriter(this.urlFullPathDisco))
                {
                    write.WriteLine(json);
                }
            }
            catch (Exception ex)
            {
                throw new ArchivoSinUbicacionExcepcion();
            }
        }

        public void GuardarMemoriaRAMJson(List<MemoriaRAM> listaMemoria)
        {
            try
            {
                JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions();
                jsonSerializerOptions.WriteIndented = true;
                var json = JsonSerializer.Serialize(listaMemoria, jsonSerializerOptions);



                using (var write = new StreamWriter(this.urlFullPathMemoria))
                {
                    write.WriteLine(json);
                }
            }
            catch (Exception ex)
            {
                throw new ArchivoSinUbicacionExcepcion();
            }
        }

        public void GuardarTarjetaGraficaJson(List<TarjetaGrafica> listaTarjeta)
        {
            try
            {
                JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions();
                jsonSerializerOptions.WriteIndented = true;
                var json = JsonSerializer.Serialize(listaTarjeta, jsonSerializerOptions);



                using (var write = new StreamWriter(this.urlFullPathTarjeta))
                {
                    write.WriteLine(json);
                }
            }
            catch (Exception ex)
            {
                throw new ArchivoSinUbicacionExcepcion();
            }
        }

        public List<DiscoDuro> LeerDiscoDuroJson()
        {
            List<DiscoDuro> listaDisco = new List<DiscoDuro>();
            using (var reader = new StreamReader(this.urlFullPathDisco))
            {
                string listaSerializada = reader.ReadToEnd();
                //List<Componente> listaComponentes = JsonSerializer.Deserialize<List<Componente>>(listaSerializada);

                if (listaSerializada != null)
                {
                    listaDisco = JsonSerializer.Deserialize<List<DiscoDuro>>(listaSerializada);

                }

            }

            return listaDisco;
        }

        public List<MemoriaRAM> LeerMemoriaRAMJson()
        {
            List<MemoriaRAM> listaMemoria = new List<MemoriaRAM>();
            using (var reader = new StreamReader(this.urlFullPathMemoria))
            {
                string listaSerializada = reader.ReadToEnd();
                //List<Componente> listaComponentes = JsonSerializer.Deserialize<List<Componente>>(listaSerializada);

                if (listaSerializada != null)
                {
                    listaMemoria = JsonSerializer.Deserialize<List<MemoriaRAM>>(listaSerializada);

                }

            }

            return listaMemoria;
        }

        public List<TarjetaGrafica> LeerTarjetaGraficaJson()
        {
            List<TarjetaGrafica> listaTarjeta = new List<TarjetaGrafica>();
            using (var reader = new StreamReader(this.urlFullPathTarjeta))
            {
                string listaSerializada = reader.ReadToEnd();
                //List<Componente> listaComponentes = JsonSerializer.Deserialize<List<Componente>>(listaSerializada);

                if (listaSerializada != null)
                {
                    listaTarjeta = JsonSerializer.Deserialize<List<TarjetaGrafica>>(listaSerializada);

                }

            }

            return listaTarjeta;
        }
    }
}

