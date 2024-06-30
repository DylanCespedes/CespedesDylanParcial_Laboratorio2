using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Administracion
    {
        public static List<Componente> listaCombinada {  get; set; }

        
        public static List<DiscoDuro> discoDuros { get; set; }

        public static List<MemoriaRAM> memoriaRAM {  get; set; }

        public static List<TarjetaGrafica> tarjetaGrafica {  get; set; }

        public static void InicializarSistema()
        {

            JsonComponentes serializerDisco = new JsonComponentes("../../../../DiscoDuro.json");
            JsonComponentes serializerMemoria = new JsonComponentes("../../../../MemoriaRAM.json");
            JsonComponentes serializerTarjeta = new JsonComponentes("../../../../TarjetaGrafica.json");
            Administracion.discoDuros = Registro.LeerArchivoDiscoDuro();
            Administracion.memoriaRAM = Registro.LeerArchivoMemoriaRAM();
            Administracion.tarjetaGrafica = Registro.LeerArchivoTarjetaGrafica();
            Administracion.discoDuros = serializerDisco.LeerDiscoDuroJson();
            Administracion.memoriaRAM = serializerMemoria.LeerMemoriaRAMJson();
            Administracion.tarjetaGrafica = serializerTarjeta.LeerTarjetaGraficaJson();

            listaCombinada = new List<Componente>();

            listaCombinada.AddRange(discoDuros);
            listaCombinada.AddRange(memoriaRAM);
            listaCombinada.AddRange(tarjetaGrafica);

        }

        public static string ModificarDiscoDuro(DiscoDuro discoDuroEditar, int id)
        {
            string mensaje = "";

            foreach (var discoduro in Administracion.discoDuros)
            {
                if (id == discoduro.id)
                {
                    discoduro.tipoMarca = discoDuroEditar.tipoMarca;
                    discoduro.tamanio = discoDuroEditar.tamanio;
                    discoduro.capacidad = discoDuroEditar.capacidad;
                    discoduro.color = discoDuroEditar.color;
                    discoduro.fechaCreacion = discoDuroEditar.fechaCreacion;
                    discoduro.numeroDeTransferencia = discoDuroEditar.numeroDeTransferencia;

                    discoduro.nombre = discoDuroEditar.nombre;
                    discoduro.fechaEntrega = discoDuroEditar.fechaEntrega;
                    discoduro.tipoEntrega = discoDuroEditar.tipoEntrega;
                    discoduro.metodoPago = discoDuroEditar.metodoPago;
                    discoduro.precio = discoDuroEditar.precio;
                    discoduro.numeroDeTransferencia = discoDuroEditar.numeroDeTransferencia;
                    break;
                }
            }


            try
            {
                JsonComponentes serialize = new JsonComponentes("../../../../DiscoDuro.json");
                serialize.GuardarDiscoDuroJson(Administracion.discoDuros);

                mensaje = "Se serializo correctamente";
            }
            catch (ArchivoSinUbicacionExcepcion e)
            {
                mensaje = e.Message;
            }

            return mensaje;

            
        }

        public static string ModificarMemoriaRAM(MemoriaRAM memoriaRamEditar, int id)
        {
            string mensaje = "";

            foreach (var memoriaram in Administracion.memoriaRAM)
            {
                if (id == memoriaram.id)
                {
                    
                    memoriaram.marcaMemoria = memoriaRamEditar.marcaMemoria;
                    memoriaram.velocidad = memoriaRamEditar.velocidad;
                    memoriaram.colorMemoria = memoriaRamEditar.colorMemoria;
                    memoriaram.marcaMemoria = memoriaRamEditar.marcaMemoria;
                    memoriaram.fechaCreacionMemoria = memoriaRamEditar.fechaCreacionMemoria;
                    memoriaram.capacidad = memoriaRamEditar.capacidad;

                    memoriaram.nombre = memoriaram.nombre;
                    memoriaram.fechaEntrega = memoriaram.fechaEntrega;
                    memoriaram.tipoEntrega = memoriaram.tipoEntrega;
                    memoriaram.metodoPago = memoriaram.metodoPago;
                    memoriaram.precio = memoriaram.precio;
                    memoriaram.numeroDeTransferencia = memoriaram.numeroDeTransferencia;
                    break;
                }
            }


            try
            {
                JsonComponentes serialize = new JsonComponentes("../../../../MemoriaRAM.json");
                serialize.GuardarMemoriaRAMJson(Administracion.memoriaRAM);

                mensaje = "Se serializo correctamente";
            }
            catch (ArchivoSinUbicacionExcepcion e)
            {
                mensaje = e.Message;
            }

            return mensaje;

            //Hacer esto mismo en las otros serialize de guardar componente json
        }

        public static string EliminarDiscoDuro(int discoDuroEliminar)
        {
            string retorno = "";

            foreach (var discoduro in Administracion.discoDuros)
            {
                if (discoDuroEliminar == discoduro.id)
                {
                    Administracion.discoDuros.Remove(discoduro);
                    retorno = "Se elimino el Disco Duro \n";
                    break;
                }
            }

            try
            {
                JsonComponentes serialize = new JsonComponentes("../../../../DiscoDuro.json");
                serialize.GuardarDiscoDuroJson(Administracion.discoDuros);

                retorno += "y se actualizo en la lista de Json";
            }
            catch (ArchivoSinUbicacionExcepcion e)
            {
                retorno += e.Message;
            }

            return retorno;
        }

        public static string EliminarMemoriaRAM(int memoriaRAMEliminar)
        {
            string retorno = "";

            foreach (var memoriaram in Administracion.memoriaRAM)
            {
                if (memoriaRAMEliminar == memoriaram.id)
                {
                    Administracion.memoriaRAM.Remove(memoriaram);
                    retorno = "Se elimino la memoria ram \n";
                    break;
                }
            }

            try
            {
                JsonComponentes serialize = new JsonComponentes("../../../../MemoriaRAM.json");
                serialize.GuardarMemoriaRAMJson(Administracion.memoriaRAM);

                retorno += "y se actualizo en la lista de Json";
            }
            catch (ArchivoSinUbicacionExcepcion e)
            {
                retorno += e.Message;
            }

            return retorno;
        }

        public static string EliminarTarjetaGrafica(int tarjetaGraficaEliminar)
        {
            string retorno = "";

            foreach (var tarjetagrafica in Administracion.tarjetaGrafica)
            {
                if (tarjetaGraficaEliminar == tarjetagrafica.id)
                {
                    Administracion.tarjetaGrafica.Remove(tarjetagrafica);
                    retorno = "Se elimino la tarjeta grafica \n";
                    break;
                }
            }

            try
            {
                JsonComponentes serialize = new JsonComponentes("../../../../TarjetaGrafica.json");
                serialize.GuardarTarjetaGraficaJson(Administracion.tarjetaGrafica);

                retorno += "y se actualizo en la lista de Json";
            }
            catch (ArchivoSinUbicacionExcepcion e)
            {
                retorno += e.Message;
            }

            return retorno;
        }

        public static string ModificarTarjetaGrafica(TarjetaGrafica tarjetaGraficaEditar, int id)
        {
            string mensaje = "";

            foreach (var tarjetagrafica in Administracion.tarjetaGrafica)
            {
                if (id == tarjetagrafica.id)
                {

                    tarjetagrafica.marcaTarjeta = tarjetagrafica.marcaTarjeta;
                    tarjetagrafica.serieNvidia = tarjetagrafica.serieNvidia;
                    tarjetagrafica.modelo = tarjetagrafica.modelo;
                    tarjetagrafica.tamanioMemoria = tarjetagrafica.tamanioMemoria;
                    tarjetagrafica.fechaCreacionTarjeta = tarjetagrafica.fechaCreacionTarjeta;

                    tarjetagrafica.nombre = tarjetagrafica.nombre;
                    tarjetagrafica.fechaEntrega = tarjetagrafica.fechaEntrega;
                    tarjetagrafica.tipoEntrega = tarjetagrafica.tipoEntrega;
                    tarjetagrafica.metodoPago = tarjetagrafica.metodoPago;
                    tarjetagrafica.precio = tarjetagrafica.precio;
                    tarjetagrafica.numeroDeTransferencia = tarjetagrafica.numeroDeTransferencia;
                    break;
                }
            }


            try
            {
                JsonComponentes serialize = new JsonComponentes("../../../../TarjetaGrafica.json");
                serialize.GuardarTarjetaGraficaJson(Administracion.tarjetaGrafica);

                mensaje = "Se serializo correctamente";
            }
            catch (ArchivoSinUbicacionExcepcion e)
            {
                mensaje = e.Message;
            }

            return mensaje;

            //Hacer esto mismo en las otros serialize de guardar componente json
        }

        public static DiscoDuro BuscarDiscoDuro(int id)
        {
            foreach (var discoduro in Administracion.discoDuros)
            {
                if (discoduro.id == id)
                {
                    return discoduro;
                }
            }

            return null;
        }

        public static MemoriaRAM BuscarMemoriaRAM(int id)
        {
            foreach (var memoriaram in Administracion.memoriaRAM)
            {
                if (memoriaram.id == id)
                {
                    return memoriaram;
                }
            }

            return null;
        }

        public static TarjetaGrafica BuscarTarjetaGrafica(int id)
        {
            foreach (var tarjetagrafica in Administracion.tarjetaGrafica)
            {
                if (tarjetagrafica.id == id)
                {
                    return tarjetagrafica;
                }
            }

            return null;
        }
    }
}
