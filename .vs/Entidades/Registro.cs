using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Registro
    {
        //Manejar los componentes

        static string nombreCarpeta = "Archivos";
        static string archivoDiscoDuri = "DiscoDuro.json";
        static string archivoMemoriaRAM = "MemoriaRAM.json";
        static string archivoTarjeta = "TarjetaGrafica.json";

        public static List<DiscoDuro> LeerArchivoDiscoDuro()
        {
            List<DiscoDuro> listaDisco = new List<DiscoDuro>();

            string path = "../../../../DiscoDuro.json";
            string urlCarpeta = CombinarUrl(path, nombreCarpeta);
            string urlArchivo = "../../../../DiscoDuro.json";

            if (!ValidarExistenciaArchivo(urlArchivo))
            {
                crearArchivo(urlArchivo);
            }

            return listaDisco;
        }

        public static List<MemoriaRAM> LeerArchivoMemoriaRAM()
        {
            List<MemoriaRAM> listaMemoria = new List<MemoriaRAM>();

            string path = "../../../../MemoriaRAM.json";
            string urlCarpeta = CombinarUrl(path, nombreCarpeta);
            string urlArchivo = "../../../../MemoriaRAM.json";

            if (!ValidarExistenciaArchivo(urlArchivo))
            {
                crearArchivo(urlArchivo);
            }

            return listaMemoria;
        }

        public static List<TarjetaGrafica> LeerArchivoTarjetaGrafica()
        {
            List<TarjetaGrafica> listaTarjeta = new List<TarjetaGrafica>();

            string path = "../../../../TarjetaGrafica.json";
            string urlCarpeta = CombinarUrl(path, nombreCarpeta);
            string urlArchivo = "../../../../TarjetaGrafica.json";

            if (!ValidarExistenciaArchivo(urlArchivo))
            {
                crearArchivo(urlArchivo);
            }

            return listaTarjeta;
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
        




    }
}
