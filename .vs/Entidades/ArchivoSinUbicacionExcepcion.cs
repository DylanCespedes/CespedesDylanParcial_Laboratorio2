using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades 
{
    public class ArchivoSinUbicacionExcepcion : Exception
    {
        public ArchivoSinUbicacionExcepcion():base("El archivo no se encuentra en la ubicacion buscada")
        {
            
        }

        public ArchivoSinUbicacionExcepcion(string msg) : base(msg) 
        {
        
        }
    }
}
