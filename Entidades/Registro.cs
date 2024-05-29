using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
<<<<<<< HEAD
    public class Registro
    {
        //Manejar los componentes

        static string nombreCarpeta = "Archivos";
        static string archivoComponentes = "Componentes.json";

        public static List<Componente> LeerArchivoComponente()
        {
            List<Componente> listaComponentes = new List<Componente>();

            string path = "../../../../Componentes.json";
            string urlCarpeta = CombinarUrl(path, nombreCarpeta);
            string urlArchivo = "../../../../Componentes.json";

            if (!ValidarExistenciaArchivo(urlArchivo))
            {
                crearArchivo(urlArchivo);
            }

            return listaComponentes;
        }
        public static List<Componente> LeerArchivoJson()
        {
            List<Componente> componente = new List<Componente>();

            string path = "../../../../Componentes.json";
            string urlCarpeta = CombinarUrl(path, nombreCarpeta);
            string urlArchivo = "../../../../Componentes.json";

            if (!ValidarExistenciaArchivo(urlArchivo))
            {
                crearArchivo(urlArchivo);
            }

            return componente;
        }

        protected static string LeerArchivo(string path)
        {
            string jsonResponse;
            using (StreamReader reader = new StreamReader(path))
            {
                jsonResponse = reader.ReadToEnd();
            }

            return jsonResponse;
        }

        protected static bool BuscarCarpetaArchivo(string urlCarpeta)
        {

            if (!Directory.Exists(urlCarpeta))
            {
                CrearCarpetaArchivo(urlCarpeta);
                return false;
            }
            return true;
        }

        private static string CombinarUrl(string path1, string path2)
        {
            return Path.Combine(path1, path2);
        }

        private static void CrearCarpetaArchivo(string urlPath)
        {
            Directory.CreateDirectory(urlPath);
        }

        private static bool ValidarExistenciaArchivo(string urlArchivo)
        {
            if (!File.Exists(urlArchivo))
            {
                return false;
            }
            return true;
        }

        private static void crearArchivo(string pathArchivo)
        {
            using (var writer = new StreamWriter(pathArchivo, true))
            {
                writer.WriteLine();
            }
        }
        



=======
    internal class Registro
    {
        //Manejar los componentes

>>>>>>> 7333da0049bfc9e43ffd321b2e3b5e71319bf970

    }
}
