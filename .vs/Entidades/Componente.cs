using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Entidades
{

    //El desealizador no podia leer estos datos de la clase padre ya que como es abstracto impedia leer lo que lleva adentro

    /// <summary>
    /// Clase padre: Componente
    /// Esta clase padre se encarga de registrar y guarda los pedidos de los clientes
    /// </summary>
    /// <returns></returns>

    public abstract class Componente
    {

        public string nombre { get; set; }

        public DateTime fechaEntrega { get; set; }

        public EtipoEntrega tipoEntrega { get; set; }

        public Epago metodoPago { get; set; }

        public double precio { get; set; }

        public int numeroDeTransferencia { get; set; }

        public Componente(string nombre, DateTime fechaEntrega, EtipoEntrega tipoEntrega, Epago metodoPago, double precio, int numeroDeTransferencia) : this(nombre, precio)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.fechaEntrega = fechaEntrega;
            this.tipoEntrega = tipoEntrega;
            this.metodoPago = metodoPago;
            this.numeroDeTransferencia = numeroDeTransferencia;
        }

        /// <summary>
        /// Un constructor con los parametros del pedido y una sobrecarga
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="tipoEntrega"></param>
        /// <param name="fechaEntrega"></param>
        /// <param name="precio"></param>
        /// <param name="numeroDeTransferencia"></param>
        public Componente(string nombre, EtipoEntrega tipoEntrega, DateTime fechaEntrega, double precio, int numeroDeTransferencia) : this(nombre, fechaEntrega, tipoEntrega, Epago.Efectivo, precio, numeroDeTransferencia)
        {

        }

        public Componente(string nombre, double precio)
        {
            this.nombre = nombre;
            this.precio = precio;
        }

        public Componente()
        {

        }

        //Este nombre lo tengo que cambiar con algo que yo necesite
        //public abstract void PromocionDescuento();

        public override string ToString()
        {
            return Mostrar();
        }


        public static bool operator ==(Componente c1, Componente c2)
        {
            return c1.precio == c2.precio;

        }

        public static bool operator !=(Componente c1, Componente c2)
        {
            return !(c1 == c2);
        }

        public override bool Equals(object? obj)
        {
            bool componenteDiferente = false;

            if (obj is Componente)
            {
                Componente componente = (Componente)obj;

                if (componente == this)
                {
                    componenteDiferente = true;
                }
            }

            return componenteDiferente;
        }


        public override int GetHashCode()
        {
            return numeroDeTransferencia;
        }

        protected virtual string Mostrar()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("ID:" + numeroDeTransferencia.ToString());
            stringBuilder.AppendLine("Nombre:" + nombre);

            return stringBuilder.ToString();
        }

        public double calcularPrecio(double numero1, double numero2)
        {
            return this.precio = numero1 + numero2;
        }

        public double calcularPrecio(double num1, double num2, double num3)
        {
            return this.precio = num1 + num2 + num3;
        }

    }
}
