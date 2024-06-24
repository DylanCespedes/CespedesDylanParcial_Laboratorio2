using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Entidades
{

    /// <summary>
    /// Clase hija nro2: MemoriaRAM
    /// Esta clase se encarga de guardar la informacion y las descripciones del la memoria ram
    /// </summary>
    /// <returns></returns>
    public class MemoriaRAM : Componente
    {
        public int velocidad;

        public EcolorMemoria colorMemoria;

        public EmarcaMemoria marcaMemoria;

        public DateTime fechaCreacionMemoria;

        public int capacidad;

        /// <summary>
        /// Su constructor con sus parametros y una sobrecarga
        /// </summary>
        /// <param name="velocidad"></param>
        /// <param name="colorMemoria"></param>
        /// <param name="marcaMemoria"></param>
        /// <param name="fechaCreacionMemoria"></param>
        /// <param name="capacidad"></param>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="fechaEntrega"></param>
        /// <param name="tipoEntrega"></param>
        /// <param name="metodoPago"></param>
        /// <param name="precio"></param>
        /// <param name="numeroDeTransferencia"></param>

        [JsonConstructor]
        public MemoriaRAM(int velocidad, EcolorMemoria colorMemoria, EmarcaMemoria marcaMemoria, DateTime fechaCreacionMemoria, int capacidad, int id, string nombre, DateTime fechaEntrega, EtipoEntrega tipoEntrega, Epago metodoPago, double precio, int numeroDeTransferencia) : base(id, nombre, fechaEntrega, tipoEntrega, metodoPago, precio, numeroDeTransferencia)
        {
            this.velocidad = velocidad;
            this.colorMemoria = colorMemoria;
            this.marcaMemoria = marcaMemoria;
            this.fechaCreacionMemoria = fechaCreacionMemoria;
            this.capacidad = capacidad;
        }

        /// <summary>
        /// Este constructor sobrecargado se encarga del guardado en la lista del mismo componente
        /// 
        /// </summary>
        /// <param name="velocidad"></param>
        /// <param name="fechaCreacionMemoria"></param>
        /// <param name="capacidad"></param>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="fechaEntrega"></param>
        /// <param name="tipoEntrega"></param>
        /// <param name="metodoPago"></param>
        /// <param name="precio"></param>
        /// <param name="numeroDeTransferencia"></param>
        public MemoriaRAM(int velocidad, DateTime fechaCreacionMemoria, int capacidad, int id, string nombre, DateTime fechaEntrega, EtipoEntrega tipoEntrega, Epago metodoPago, double precio, int numeroDeTransferencia) : this(velocidad, EcolorMemoria.Negro, EmarcaMemoria.Corsair, fechaCreacionMemoria, capacidad, id, nombre, fechaEntrega, tipoEntrega, metodoPago, precio, numeroDeTransferencia)
        {

        }

        public MemoriaRAM()
        {

        }
        /*
        public override void PromocionDescuento()
        {

        }
        */

        protected override string Mostrar()
        {
            //Aca tengo que concatenar los datos de base.mostrar + los atributos de MemoriaRAM.
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Marca del producto:" + marcaMemoria);
            stringBuilder.AppendLine("Color del producto: " + colorMemoria);
            stringBuilder.AppendLine("Fecha de fabricacion del producto: " + fechaCreacionMemoria);

            return stringBuilder.ToString();
        }

        public override string ToString()
        {
            return Mostrar();
        }
    }
}
