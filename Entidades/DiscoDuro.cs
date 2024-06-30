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

        public int id { get; set; }

        public EmarcaDisco tipoMarca { get; set; }

        public string tamanio { get; set; }

        public string capacidad { get; set; }

        public Ecolor color { get; set; }

        public DateTime fechaCreacion { get; set; }

        public Ecomponentes valor { get; set; }

        [JsonConstructor]
        public DiscoDuro(int id, EmarcaDisco tipoMarca, string tamanio, string capacidad, Ecolor color, DateTime fechaCreacion, string nombre, DateTime fechaEntrega, EtipoEntrega tipoEntrega, Epago metodoPago, double precio, int numeroDeTransferencia) : base(nombre, fechaEntrega, tipoEntrega, metodoPago, precio, numeroDeTransferencia)
        {
            this.id = id;
            this.tipoMarca = tipoMarca;
            this.tamanio = tamanio;
            this.capacidad = capacidad;
            this.color = color;
            this.fechaCreacion = fechaCreacion;
            this.valor = Ecomponentes.DiscoDuro;
        }

        /// <summary>
        /// Su constructor con sus parametros y una sobrecarga
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="tamanio"></param>
        /// <param name="capacidad"></param>
        /// <param name="color"></param>
        /// <param name="fechaCreacion"></param>
        /// <param name="valor"></param>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="fechaEntrega"></param>
        /// <param name="tipoEntrega"></param>
        /// <param name="metodoPago"></param>
        /// <param name="precio"></param>
        /// <param name="numeroDeTransferencia"></param>

        public DiscoDuro(int id, string tamanio, string capacidad, Ecolor color, DateTime fechaCreacion, string nombre, DateTime fechaEntrega, EtipoEntrega tipoEntrega, Epago metodoPago, double precio, int numeroDeTransferencia) : this(id, EmarcaDisco.Seagate, tamanio, capacidad, Ecolor.Blanco, fechaCreacion, nombre, fechaEntrega, tipoEntrega, metodoPago, precio, numeroDeTransferencia)
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
