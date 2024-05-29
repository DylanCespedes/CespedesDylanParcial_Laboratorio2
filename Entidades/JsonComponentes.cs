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

<<<<<<< HEAD
        public JsonComponentes(string path)
        {
            this.urlFullPath = "../../../../Componentes.json";
            //this.urlFullPath += "Documentos";
=======
        public JsonComponentes(string urlFullPath)
        {
            this.urlFullPath = urlFullPath;
>>>>>>> 7333da0049bfc9e43ffd321b2e3b5e71319bf970
        }

        public void GuardarComponentesJson(List<Componente> listaComponentes)
        {
            JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions();
            jsonSerializerOptions.WriteIndented = true;
            var json = JsonSerializer.Serialize(listaComponentes, jsonSerializerOptions);

            using (var write = new StreamWriter(this.urlFullPath))
            {
                write.WriteLine(json);
            }
        }

        public List<Componente> LeerComponentesJson()
        {
<<<<<<< HEAD
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

=======
            using (var reader = new StreamReader(this.urlFullPath))
            {
                string listaSerializada = reader.ReadToEnd();
                List<Componente> listaComponentes = JsonSerializer.Deserialize<List<Componente>>(listaSerializada);

                return listaComponentes;
            }
        }
>>>>>>> 7333da0049bfc9e43ffd321b2e3b5e71319bf970
    }
}

