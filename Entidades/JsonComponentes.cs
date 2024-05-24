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

        public JsonComponentes(string urlFullPath)
        {
            this.urlFullPath = urlFullPath;
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
            using (var reader = new StreamReader(this.urlFullPath))
            {
                string listaSerializada = reader.ReadToEnd();
                List<Componente> listaComponentes = JsonSerializer.Deserialize<List<Componente>>(listaSerializada);

                return listaComponentes;
            }
        }
    }
}

