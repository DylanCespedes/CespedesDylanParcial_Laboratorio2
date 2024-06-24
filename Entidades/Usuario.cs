using System.Text.Json;
using System.Text;

namespace Entidades
{
    public class Usuario
    {
        //Esta clase tiene que tener los atributos del archivo MOCK_DATA.json y no olvidarse los requisitos para deserealizar el JSON y un constructor sin parametros.

        //Pasar todas las entidades aca

        public string apellido { get; set; }

        public string nombre { get; set; }

        public int legajo { get; set; }

        public string correo { get; set; }

        public string clave { get; set; }

        public string perfil { get; set; }

        public Usuario(string apellido, string nombre, int legajo, string correo, string clave, string perfil)
        {
            this.apellido = apellido;
            this.nombre = nombre;
            this.legajo = legajo;
            this.correo = correo;
            this.clave = clave;
            this.perfil = perfil;

        }

        public Usuario(int legajo, string correo, string clave, string perfil) : base()
        {
            this.legajo = legajo;
        }

        public Usuario()
        {

        }

        public static List<Usuario> DesealizarUsuariosJson()
        {
            List<Usuario> auxList = new List<Usuario>();

            using (StreamReader sr = new StreamReader("../../../../MOCK_DATA.json"))
            {
                string jsonUsuarios = sr.ReadToEnd();
                auxList = JsonSerializer.Deserialize<List<Usuario>>(jsonUsuarios);
            }

            return auxList;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Email: {this.correo}");
            stringBuilder.AppendLine($"Clave: {this.clave}");

            return stringBuilder.ToString();
        }

    }
}
