using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Entidades
{

    /// <summary>
    /// Clase hija nro1: DiscoDuro
    /// Este se encarga de guardar la informacion y las descripciones del DiscoDuro.
    /// </summary>
    /// <returns></returns>

    public class DiscoDuro : Componente
    {

        public EmarcaDisco tipoMarca;

        public string tamanio;

        public string capacidad;

        public Ecolor color;

        public DateTime fechaCreacion;

        [JsonConstructor]
        public DiscoDuro(EmarcaDisco tipoMarca, string tamanio, string capacidad, Ecolor color, DateTime fechaCreacion, int id, string nombre, DateTime fechaEntrega, EtipoEntrega tipoEntrega, Epago metodoPago, double precio, int numeroDeTransferencia) : base(id, nombre, fechaEntrega, tipoEntrega, metodoPago, precio, numeroDeTransferencia)
        {
            this.tipoMarca = tipoMarca;
            this.tamanio = tamanio;
            this.capacidad = capacidad;
            this.color = color;
            this.fechaCreacion = fechaCreacion;
        }

        /// <summary>
        /// Su constructor con sus parametros y una sobrecarga
        /// </summary>
        /// <param name="tamanio"></param>
        /// <param name="capacidad"></param>
        /// <param name="color"></param>
        /// <param name="fechaCreacion"></param>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="fechaEntrega"></param>
        /// <param name="tipoEntrega"></param>
        /// <param name="metodoPago"></param>
        /// <param name="precio"></param>
        /// <param name="numeroDeTransferencia"></param>

        public DiscoDuro(string tamanio, string capacidad, Ecolor color, DateTime fechaCreacion, int id, string nombre, DateTime fechaEntrega, EtipoEntrega tipoEntrega, Epago metodoPago, double precio, int numeroDeTransferencia) : this(EmarcaDisco.Seagate, tamanio, capacidad, Ecolor.Blanco, fechaCreacion, id, nombre, fechaEntrega, tipoEntrega, metodoPago, precio, numeroDeTransferencia)
        {

        }

        public DiscoDuro()
        {

        }
        /*
        public override void PromocionDescuento()
        {

        }

        */
        protected override string Mostrar()
        {
            //Aca tengo que concatenar los datos de base.mostrar + los atributos del disco duro.
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Marca del producto:" + tipoMarca);
            stringBuilder.AppendLine("Color del producto" + color);
            stringBuilder.AppendLine("Fecha de fabricacion del producto: " + fechaCreacion);

            return stringBuilder.ToString();
        }

        public override string ToString()
        {
            return Mostrar();
        }



    }
}
