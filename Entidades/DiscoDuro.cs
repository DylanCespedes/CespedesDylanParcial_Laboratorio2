using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DiscoDuro : Componente
    {

        public EmarcaDisco tipoMarca;

        public int tamanio;

        public string capacidad;

        public Ecolor color;

        public DateTime fechaCreacion;

        public DiscoDuro(EmarcaDisco tipoMarca, int tamanio, string capacidad, Ecolor color, DateTime fechaCreacion, int id, string nombre, DateTime fechaEntrega, EtipoEntrega tipoEntrega, Epago metodoPago, double precio, int numeroDeTransferencia) : base(id, nombre, fechaEntrega, tipoEntrega, metodoPago, precio, numeroDeTransferencia)
        {
            this.tipoMarca = tipoMarca;
            this.tamanio = tamanio;
            this.capacidad = capacidad;
            this.color = color;
            this.fechaCreacion = fechaCreacion;
        }

        public DiscoDuro(int tamanio, string capacidad, Ecolor color, DateTime fechaCreacion, int id, string nombre, DateTime fechaEntrega, EtipoEntrega tipoEntrega, Epago metodoPago, double precio, int numeroDeTransferencia) : this(EmarcaDisco.Seagate, tamanio, capacidad, Ecolor.Blanco, fechaCreacion, id, nombre, fechaEntrega, tipoEntrega, metodoPago, precio, numeroDeTransferencia)
        {

        }

        public override void PromocionDescuento()
        {

        }

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
