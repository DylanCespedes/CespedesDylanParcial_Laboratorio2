using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Administracion
    {
        public static List<Componente> componentes {  get; set; }

        public static void InicializarSistema()
        {
            
            JsonComponentes serializer = new JsonComponentes("../../../../Componentes.json");
            Administracion.componentes = Registro.LeerArchivoComponente();
            Administracion.componentes = serializer.LeerComponentesJson();

        }

        public static string ModificarDatos(Componente componenteEditar, int id)
        {
            string mensaje = "";

            foreach (var componente in Administracion.componentes)
            {
                if(id == componente.id)
                {
                    componente.nombre = componenteEditar.nombre;
                    componente.fechaEntrega = componenteEditar.fechaEntrega;
                    componente.tipoEntrega = componenteEditar.tipoEntrega;
                    componente.metodoPago = componenteEditar.metodoPago;
                    componente.precio = componenteEditar.precio;
                    componente.numeroDeTransferencia = componenteEditar.numeroDeTransferencia;
                    break;
                }
            }



            try
            {
                JsonComponentes serialize = new JsonComponentes("../../../../Componentes.json");
                serialize.GuardarComponentesJson(Administracion.componentes);

                mensaje = "Se serializo correctamente";
            }
            catch (ArchivoSinUbicacionExcepcion e) 
            {
                mensaje = e.Message;
            }

            return mensaje;

            //Hacer esto mismo en las otros serialize de guardar componente json
        }


        public static string EliminarComponente(int componenteEliminar)
        {
            string retorno = "";

            foreach (var componente in Administracion.componentes)
            {
                if (componenteEliminar == componente.id)
                {
                    Administracion.componentes.Remove(componente);
                    retorno = "Se elimino el componente " + componente.nombre + "/n";
                    break;
                }
            }

            try
            {
                JsonComponentes serialize = new JsonComponentes("../../../../Componentes.json");
                serialize.GuardarComponentesJson(Administracion.componentes);

                retorno += "y se actualizo en la lista de Json";
            }
            catch (ArchivoSinUbicacionExcepcion e)
            {
                retorno += e.Message;
            }

            return retorno;

        }

        public static Componente BuscarComponente(int id)
        {
            foreach(var componente in Administracion.componentes)
            {
                if(componente.id == id)
                {
                    return componente;
                }
            }

            return null;
        }
    }
}
