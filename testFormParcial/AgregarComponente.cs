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
        private List<Componente> componentes;

        private Componente componente;

        public Componente Componente
        {
            get { return this.componente; }
        }



        public AgregarComponente()
        {
            InitializeComponent();

            componentes = new List<Componente>();

            //Cargar de enumerados componentes a elegir
            CargarComponentes();
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

            if (comboBox1.SelectedIndex == 0)
            {
                //Disco Duro
                EmarcaDisco marcaDisco = (EmarcaDisco)comboBox2.SelectedIndex;
                string tamanio = txtTamanio.Text;
                string capacidad = txtCapacidad.Text;
                Ecolor color = (Ecolor)comboBox3.SelectedIndex;
                DateTime fechaCreacionDisco = Convert.ToDateTime(txtFechaCreacion.Text);

                this.componente = new DiscoDuro(marcaDisco, tamanio, capacidad, color, fechaCreacionDisco, id, nombre, fechaEntrega, tipoEntrega, metodoPago, precio, numeroTransferencia);

            }

            if (comboBox1.SelectedIndex == 1) 
            {
                //Memoria RAM
                int velocidad = Convert.ToInt32(txtVelocidad.Text);
                EcolorMemoria colorMemoria = (EcolorMemoria)comboBox5.SelectedIndex;
                EmarcaMemoria marcaMemoria = (EmarcaMemoria)comboBox6.SelectedIndex;
                DateTime fechaCreacionMemoria = Convert.ToDateTime(txtFechaCreacionMemoria.Text);
                int capacidadMemoria = Convert.ToInt32(txtCapacidadMemoria.Text);

                this.componente = new MemoriaRAM(velocidad, colorMemoria, marcaMemoria, fechaCreacionMemoria, capacidadMemoria, id, nombre, fechaEntrega, tipoEntrega, metodoPago, precio, numeroTransferencia);

            }

            if (comboBox1.SelectedIndex == 2) 
            {
                //Tarjeta Grafica
                EmarcaTarjeta marcaTarjeta = (EmarcaTarjeta)comboBox6.SelectedIndex;
                EserieNvidia serieNvidia = (EserieNvidia)comboBox7.SelectedIndex;
                int modelo = Convert.ToInt32(txtModelo.Text);
                int tamanioTarjeta = Convert.ToInt16(txtTamanioTarjeta.Text);
                DateTime fechaCreacionTarjeta = Convert.ToDateTime(txtFechaCreacionTarjeta.Text);

                this.componente = new TarjetaGrafica(marcaTarjeta, serieNvidia, modelo, tamanioTarjeta, fechaCreacionTarjeta, id, nombre, fechaEntrega, tipoEntrega, metodoPago, precio, numeroTransferencia);

            }

            this.DialogResult = DialogResult.OK;

            this.Close();
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex == 0)
            {
                comboBox2.Enabled = true;

                comboBox3.Enabled = true;

                txtTamanio.Enabled = true;

                txtCapacidad.Enabled = true;

                txtFechaCreacion.Enabled = true;

                txtFechaCreacionMemoria.Enabled = false;
                Enabled = true;

                txtCapacidadMemoria.Enabled = false;
                Enabled = true;

                //////////////////////////////////////////

                txtVelocidad.Enabled = false;

                comboBox5.Enabled = false;

                comboBox4.Enabled = false;

                txtFechaCreacionMemoria.Enabled = false;

                txtCapacidadMemoria.Enabled = false;

                //////////////////////////////////////////


                comboBox6.Enabled = false;

                comboBox7.Enabled = false;

                txtModelo.Enabled = false;

                txtTamanioTarjeta.Enabled = false;

                txtFechaCreacionTarjeta.Enabled = false;

            }
            else if (comboBox1.SelectedIndex == 1)
            {
                comboBox2.Enabled = false;

                comboBox3.Enabled = false;

                txtTamanio.Enabled = false;

                txtCapacidad.Enabled = false;

                txtFechaCreacion.Enabled = false;

                txtFechaCreacionMemoria.Enabled = false;
                Enabled = true;

                txtCapacidadMemoria.Enabled = false;
                Enabled = true;

                //////////////////////////////////////////

                txtVelocidad.Enabled = true;

                comboBox5.Enabled = true;

                comboBox4.Enabled = true;

                txtFechaCreacionMemoria.Enabled = true;

                txtCapacidadMemoria.Enabled = true;

                //////////////////////////////////////////


                comboBox6.Enabled = false;

                comboBox7.Enabled = false;

                txtModelo.Enabled = false;

                txtTamanioTarjeta.Enabled = false;

                txtFechaCreacionTarjeta.Enabled = false;
            }
            else if (comboBox1.SelectedIndex == 2) 
            {

                comboBox2.Enabled = false;

                comboBox3.Enabled = false;

                txtTamanio.Enabled = false;

                txtCapacidad.Enabled = false;

                txtFechaCreacion.Enabled = false;

                txtFechaCreacionMemoria.Enabled = false;
                Enabled = true;

                txtCapacidadMemoria.Enabled = false;
                Enabled = true;

                //////////////////////////////////////////

                txtVelocidad.Enabled = false;

                comboBox5.Enabled = false;

                comboBox4.Enabled = false;

                txtFechaCreacionMemoria.Enabled = false;

                txtCapacidadMemoria.Enabled = false;

                //////////////////////////////////////////


                comboBox6.Enabled = true;

                comboBox7.Enabled = true;

                txtModelo.Enabled = true;

                txtTamanioTarjeta.Enabled = true;

                txtFechaCreacionTarjeta.Enabled = true;
            }

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
            comboBox1.DataSource = Enum.GetValues(typeof(Ecomponentes));
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
