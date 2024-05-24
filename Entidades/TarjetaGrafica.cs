using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TarjetaGrafica : Componente
    {
        public EmarcaTarjeta marcaTarjeta;

        public EserieNvidia serieNvidia;

        public int modelo;

        public int tamanioMemoria;

        public DateTime fechaCreacionTarjeta;

        public TarjetaGrafica(EmarcaTarjeta marcaTarjeta, EserieNvidia serieNvidia, int modelo, int tamanioMemoria, DateTime fechaCreacionTarjeta, int id, string nombre, DateTime fechaEntrega, EtipoEntrega tipoEntrega, Epago metodoPago, double precio, int numeroDeTransferencia) : base(id, nombre, fechaEntrega, tipoEntrega, metodoPago, precio, numeroDeTransferencia)
        {
            this.marcaTarjeta = marcaTarjeta;
            this.serieNvidia = serieNvidia;
            this.modelo = modelo;
            this.tamanioMemoria = tamanioMemoria;
            this.fechaCreacionTarjeta = fechaCreacionTarjeta;
        }

        public TarjetaGrafica(int modelo, int tamanioMemoria, DateTime fechaCreacionTarjeta, int id, string nombre, DateTime fechaEntrega, EtipoEntrega tipoEntrega, Epago metodoPago, double precio, int numeroDeTransferencia) : this(EmarcaTarjeta.Intel, EserieNvidia.GTX, modelo, tamanioMemoria, fechaCreacionTarjeta, id, nombre, fechaEntrega, tipoEntrega, metodoPago, precio, numeroDeTransferencia)
        {

        }

        public TarjetaGrafica()
        {

        }

        public override void PromocionDescuento()
        {

        }

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
