using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
<<<<<<< HEAD
using System.Text.Json.Serialization;
=======
>>>>>>> 7333da0049bfc9e43ffd321b2e3b5e71319bf970
using System.Threading.Tasks;

namespace Entidades
{
    public class DiscoDuro : Componente
    {

        public EmarcaDisco tipoMarca;

<<<<<<< HEAD
        public string tamanio;
=======
        public int tamanio;
>>>>>>> 7333da0049bfc9e43ffd321b2e3b5e71319bf970

        public string capacidad;

        public Ecolor color;

        public DateTime fechaCreacion;

<<<<<<< HEAD
        [JsonConstructor]
        public DiscoDuro(EmarcaDisco tipoMarca, string tamanio, string capacidad, Ecolor color, DateTime fechaCreacion, int id, string nombre, DateTime fechaEntrega, EtipoEntrega tipoEntrega, Epago metodoPago, double precio, int numeroDeTransferencia) : base(id, nombre, fechaEntrega, tipoEntrega, metodoPago, precio, numeroDeTransferencia)
=======
        public DiscoDuro(EmarcaDisco tipoMarca, int tamanio, string capacidad, Ecolor color, DateTime fechaCreacion, int id, string nombre, DateTime fechaEntrega, EtipoEntrega tipoEntrega, Epago metodoPago, double precio, int numeroDeTransferencia) : base(id, nombre, fechaEntrega, tipoEntrega, metodoPago, precio, numeroDeTransferencia)
>>>>>>> 7333da0049bfc9e43ffd321b2e3b5e71319bf970
        {
            this.tipoMarca = tipoMarca;
            this.tamanio = tamanio;
            this.capacidad = capacidad;
            this.color = color;
            this.fechaCreacion = fechaCreacion;
        }

<<<<<<< HEAD
        public DiscoDuro(string tamanio, string capacidad, Ecolor color, DateTime fechaCreacion, int id, string nombre, DateTime fechaEntrega, EtipoEntrega tipoEntrega, Epago metodoPago, double precio, int numeroDeTransferencia) : this(EmarcaDisco.Seagate, tamanio, capacidad, Ecolor.Blanco, fechaCreacion, id, nombre, fechaEntrega, tipoEntrega, metodoPago, precio, numeroDeTransferencia)
=======
        public DiscoDuro(int tamanio, string capacidad, Ecolor color, DateTime fechaCreacion, int id, string nombre, DateTime fechaEntrega, EtipoEntrega tipoEntrega, Epago metodoPago, double precio, int numeroDeTransferencia) : this(EmarcaDisco.Seagate, tamanio, capacidad, Ecolor.Blanco, fechaCreacion, id, nombre, fechaEntrega, tipoEntrega, metodoPago, precio, numeroDeTransferencia)
>>>>>>> 7333da0049bfc9e43ffd321b2e3b5e71319bf970
        {

        }

<<<<<<< HEAD
        public DiscoDuro()
        {

        }
        /*
=======
>>>>>>> 7333da0049bfc9e43ffd321b2e3b5e71319bf970
        public override void PromocionDescuento()
        {

        }

<<<<<<< HEAD
        */
=======
>>>>>>> 7333da0049bfc9e43ffd321b2e3b5e71319bf970
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
