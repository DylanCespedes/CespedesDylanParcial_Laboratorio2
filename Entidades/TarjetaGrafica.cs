using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Entidades
{

    /// <summary>
    /// Clase hija nro3: TarjetaGrafica
    /// Esta clase se encarga de guardar informacion y descripcion de la tarjeta grafica
    /// </summary>
    /// <returns></returns>

    public class TarjetaGrafica : Componente
    {
        public EmarcaTarjeta marcaTarjeta;

        public EserieNvidia serieNvidia;

        public int modelo;

        public int tamanioMemoria;

        public DateTime fechaCreacionTarjeta;

        [JsonConstructor]
        public TarjetaGrafica(EmarcaTarjeta marcaTarjeta, EserieNvidia serieNvidia, int modelo, int tamanioMemoria, DateTime fechaCreacionTarjeta, int id, string nombre, DateTime fechaEntrega, EtipoEntrega tipoEntrega, Epago metodoPago, double precio, int numeroDeTransferencia) : base(id, nombre, fechaEntrega, tipoEntrega, metodoPago, precio, numeroDeTransferencia)
        {
            this.marcaTarjeta = marcaTarjeta;
            this.serieNvidia = serieNvidia;
            this.modelo = modelo;
            this.tamanioMemoria = tamanioMemoria;
            this.fechaCreacionTarjeta = fechaCreacionTarjeta;
        }

        /// <summary>
        /// Su constructor con sus parametros y una sobrecarga
        /// </summary>
        /// <param name="modelo"></param>
        /// <param name="tamanioMemoria"></param>
        /// <param name="fechaCreacionTarjeta"></param>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="fechaEntrega"></param>
        /// <param name="tipoEntrega"></param>
        /// <param name="metodoPago"></param>
        /// <param name="precio"></param>
        /// <param name="numeroDeTransferencia"></param>

        public TarjetaGrafica(int modelo, int tamanioMemoria, DateTime fechaCreacionTarjeta, int id, string nombre, DateTime fechaEntrega, EtipoEntrega tipoEntrega, Epago metodoPago, double precio, int numeroDeTransferencia) : this(EmarcaTarjeta.Intel, EserieNvidia.GTX, modelo, tamanioMemoria, fechaCreacionTarjeta, id, nombre, fechaEntrega, tipoEntrega, metodoPago, precio, numeroDeTransferencia)
        {

        }

        public TarjetaGrafica()
        {

        }
        /*
        public override void PromocionDescuento()
        {

        }
        */

        protected override string Mostrar()
        {
            //Aca tengo que concatenar los datos de base.mostrar + los atributos de TarjetaGrafica.
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Marca del producto: " + marcaTarjeta);
            stringBuilder.AppendLine("Serie de Nvidia: " + serieNvidia);
            stringBuilder.AppendLine("Fecha de fabricacion del producto: " + fechaCreacionTarjeta);


            return stringBuilder.ToString();
        }

        public override string ToString()
        {

            return Mostrar();
        }


    }
}
