using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Entidades
{
    public class MemoriaRAM : Componente
    {
        public int velocidad;

        public EcolorMemoria colorMemoria;

        public EmarcaMemoria marcaMemoria;

        public DateTime fechaCreacionMemoria;

        public int capacidad;

        [JsonConstructor]
        public MemoriaRAM(int velocidad, EcolorMemoria colorMemoria, EmarcaMemoria marcaMemoria, DateTime fechaCreacionMemoria, int capacidad, int id, string nombre, DateTime fechaEntrega, EtipoEntrega tipoEntrega, Epago metodoPago, double precio, int numeroDeTransferencia) : base(id, nombre, fechaEntrega, tipoEntrega, metodoPago, precio, numeroDeTransferencia)
        {
            this.velocidad = velocidad;
            this.colorMemoria = colorMemoria;
            this.marcaMemoria = marcaMemoria;
            this.fechaCreacionMemoria = fechaCreacionMemoria;
            this.capacidad = capacidad;
        }

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
