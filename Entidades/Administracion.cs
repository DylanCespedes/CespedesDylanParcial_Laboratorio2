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

        public static void ModificarDatos(Componente componenteEditar, int id)
        {
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

            JsonComponentes serialize = new JsonComponentes("../../../../Componentes.json");
            serialize.GuardarComponentesJson(Administracion.componentes);
        }

        public static void EliminarComponente(int componenteEliminar)
        {
            foreach (var componente in Administracion.componentes)
            {
                if (componenteEliminar == componente.id) 
                {
                    Administracion.componentes.Remove(componente);
                    break;
                }
            }

            JsonComponentes serialize = new JsonComponentes("../../../../Componentes.json");
            serialize.GuardarComponentesJson(Administracion.componentes);
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
