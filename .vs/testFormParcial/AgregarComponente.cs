using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testFormParcial
{
    public partial class AgregarComponente : Form
    {
        private List<DiscoDuro> discoDuro;

        private List<MemoriaRAM> memoriaRAM;

        private List<TarjetaGrafica> tarjetaGraficas;

        public DiscoDuro componenteDiscoDuro;

        public MemoriaRAM componenteMemoriaRAM;

        public TarjetaGrafica componenteTarjetaGrafica;

        private Ecomponentes componenteElegido;

        public DiscoDuro DiscoDuro
        {
            get { return this.DiscoDuro; }
        }

        public MemoriaRAM MemoriaRAM
        {
            get { return this.MemoriaRAM;  }
        }

        public TarjetaGrafica TarjetaGrafica
        {
            get { return this.TarjetaGrafica; }
        }

        

        public AgregarComponente()
        {
            InitializeComponent();

        }

        public AgregarComponente(Ecomponentes componente) :this()
        {
            this.componenteElegido = componente;

            switch(this.componenteElegido) 
            {
                case Ecomponentes.DiscoDuro:
                    discoDuro = new List<DiscoDuro>();


                    comboBox2.Enabled = true;

                    comboBox3.Enabled = true;

                    txtTamanio.Enabled = true;

                    txtCapacidad.Enabled = true;

                    txtFechaCreacion.Enabled = true;

                    ////////////////////////////
                    
                    txtVelocidad.Enabled = false;

                    comboBox5.Enabled = false;

                    comboBox4.Enabled = false;

                    txtFechaCreacionMemoria.Enabled = false;

                    txtCapacidadMemoria.Enabled = false;

                    ////////////////////////////

                    comboBox6.Enabled = false;

                    comboBox7.Enabled = false;

                    txtModelo.Enabled = false;

                    txtTamanioTarjeta.Enabled = false;

                    txtFechaCreacionTarjeta.Enabled = false;

                    break;

                case Ecomponentes.MemoriaRAM:
                    memoriaRAM = new List<MemoriaRAM>();

                    comboBox2.Enabled = false;

                    comboBox3.Enabled = false;

                    txtTamanio.Enabled = false;

                    txtCapacidad.Enabled = false;

                    txtFechaCreacion.Enabled = false;

                    ////////////////////////////

                    txtVelocidad.Enabled = true;

                    comboBox5.Enabled = true;

                    comboBox4.Enabled = true;

                    txtFechaCreacionMemoria.Enabled = true;

                    txtCapacidadMemoria.Enabled = true;

                    ////////////////////////////

                    comboBox6.Enabled = false;

                    comboBox7.Enabled = false;

                    txtModelo.Enabled = false;

                    txtTamanioTarjeta.Enabled = false;

                    txtFechaCreacionTarjeta.Enabled = false;

                    break;

                case Ecomponentes.TarjetaGrafica:
                    tarjetaGraficas = new List<TarjetaGrafica>();

                    comboBox2.Enabled = false;

                    comboBox3.Enabled = false;

                    txtTamanio.Enabled = false;

                    txtCapacidad.Enabled = false;

                    txtFechaCreacion.Enabled = false;

                    ////////////////////////////

                    txtVelocidad.Enabled = false;

                    comboBox5.Enabled = false;

                    comboBox4.Enabled = false;

                    txtFechaCreacionMemoria.Enabled = false;

                    txtCapacidadMemoria.Enabled = false;

                    ////////////////////////////

                    comboBox6.Enabled = true;

                    comboBox7.Enabled = true;

                    txtModelo.Enabled = true;

                    txtTamanioTarjeta.Enabled = true;

                    txtFechaCreacionTarjeta.Enabled = true;

                    break;
            }
        }

        protected virtual void button1_Click(object sender, EventArgs e)
        {

            //Pedido de la persona(Componente)
            int id = Convert.ToInt32(txtId.Text);
            string nombre = txtNombre.Text;
            DateTime fechaEntrega = Convert.ToDateTime(txtFechaEntrega.Text);
            EtipoEntrega tipoEntrega = (EtipoEntrega)comboBox8.SelectedIndex;
            Epago metodoPago = (Epago)comboBox9.SelectedIndex;
            double precio = Convert.ToDouble(txtPrecio.Text);
            int numeroTransferencia = Convert.ToInt32(txtNumeroTransferencia.Text);

            if (this.componenteElegido == Ecomponentes.DiscoDuro)
            {

                EmarcaDisco marcaDisco = (EmarcaDisco)comboBox2.SelectedIndex;
                string tamanio = txtTamanio.Text;
                string capacidad = txtCapacidad.Text;
                Ecolor color = (Ecolor)comboBox3.SelectedIndex;
                DateTime fechaCreacionDisco = Convert.ToDateTime(txtFechaCreacion.Text);

                this.componenteDiscoDuro = new DiscoDuro(id, marcaDisco, tamanio, capacidad, color, fechaCreacionDisco, nombre, fechaEntrega, tipoEntrega, metodoPago, precio, numeroTransferencia);
            }
            else if (this.componenteElegido == Ecomponentes.MemoriaRAM)
            {
                int velocidad = Convert.ToInt32(txtVelocidad.Text);
                EcolorMemoria colorMemoria = (EcolorMemoria)comboBox5.SelectedIndex;
                EmarcaMemoria marcaMemoria = (EmarcaMemoria)comboBox6.SelectedIndex;
                DateTime fechaCreacionMemoria = Convert.ToDateTime(txtFechaCreacionMemoria.Text);
                int capacidadMemoria = Convert.ToInt32(txtCapacidadMemoria.Text);

                this.componenteMemoriaRAM = new MemoriaRAM(id, velocidad, colorMemoria, marcaMemoria, fechaCreacionMemoria, capacidadMemoria, nombre, fechaEntrega, tipoEntrega, metodoPago, precio, numeroTransferencia);
            }
            else
            {
                EmarcaTarjeta marcaTarjeta = (EmarcaTarjeta)comboBox6.SelectedIndex;
                EserieNvidia serieNvidia = (EserieNvidia)comboBox7.SelectedIndex;
                int modelo = Convert.ToInt32(txtModelo.Text);
                int tamanioTarjeta = Convert.ToInt16(txtTamanioTarjeta.Text);
                DateTime fechaCreacionTarjeta = Convert.ToDateTime(txtFechaCreacionTarjeta.Text);

                this.componenteTarjetaGrafica = new TarjetaGrafica(id, marcaTarjeta, serieNvidia, modelo, tamanioTarjeta, fechaCreacionTarjeta, nombre, fechaEntrega, tipoEntrega, metodoPago, precio, numeroTransferencia);
            }

            this.DialogResult = DialogResult.OK;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        

        // //////////////////////////////////////////////////////////////// //
        //CARGAS DE ENUMERADOS

        private void CargarModelosDiscoDuro()
        {
            comboBox2.DataSource = Enum.GetValues(typeof(EmarcaDisco));
        }

        private void CargarColorDiscoDuro()
        {
            comboBox3.DataSource = Enum.GetValues(typeof(Ecolor));
        }

        // //////////////////////////////////////////////////////////////// //

        private void CargarColorMemoria()
        {
            comboBox5.DataSource = Enum.GetValues(typeof(EcolorMemoria));
        }

        private void CargarModeloMemoria()
        {
            comboBox4.DataSource = Enum.GetValues(typeof(EmarcaMemoria));
        }

        // //////////////////////////////////////////////////////////////// //

        private void CargarModeloTarjeta()
        {
            comboBox6.DataSource = Enum.GetValues(typeof(EmarcaTarjeta));
        }

        private void CargarSerieNvidia()
        {
            comboBox7.DataSource = Enum.GetValues(typeof(EserieNvidia));
        }

        // //////////////////////////////////////////////////////////////// //

        private void CargarTipoEntrega()
        {
            comboBox8.DataSource = Enum.GetValues(typeof(EtipoEntrega));
        }

        private void CargarMetodoPago()
        {
            comboBox9.DataSource = Enum.GetValues(typeof(Epago));
        }

        // //////////////////////////////////////////////////////////////// //

        private void CargarComponentes()
        {

        }

        private void AgregarComponente_Load(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void AgregarComponente_Load_1(object sender, EventArgs e)
        {
            
            //Carga de enumerados Disco Duro
            CargarModelosDiscoDuro();
            CargarColorDiscoDuro();

            //Carga de enumerados Memoria RAM

            CargarModeloMemoria();
            CargarColorMemoria();

            //Carga de enumerados Tarjeta Grafica

            CargarModeloTarjeta();
            CargarSerieNvidia();

            //Cargar de enumerados Componente

            CargarTipoEntrega();
            CargarMetodoPago();
            
        }
    }
}
