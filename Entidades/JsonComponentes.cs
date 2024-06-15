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

        private string urlFullPath;

        public JsonComponentes(string path)
        {
            this.urlFullPath = "../../../../Componentes.json";
            //this.urlFullPath += "Documentos";
        }

        public void GuardarComponentesJson(List<Componente> listaComponentes)
        {
            try
            {
                JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions();
                jsonSerializerOptions.WriteIndented = true;
                var json = JsonSerializer.Serialize(listaComponentes, jsonSerializerOptions);



                using (var write = new StreamWriter(this.urlFullPath))
                {
                    write.WriteLine(json);
                }
            }
            catch (Exception ex) 
            {
                throw new ArchivoSinUbicacionExcepcion();
            }
        }

        public List<Componente> LeerComponentesJson()
        {
            List<Componente> listaComp = new List<Componente>();
            using (var reader = new StreamReader(this.urlFullPath))
            {
                string listaSerializada = reader.ReadToEnd();
                //List<Componente> listaComponentes = JsonSerializer.Deserialize<List<Componente>>(listaSerializada);
                
                if(listaSerializada != null)
                {
                    listaComp = JsonSerializer.Deserialize<List<Componente>>(listaSerializada);
                    
                }

                
            }

            return listaComp;
        }

    }
}

