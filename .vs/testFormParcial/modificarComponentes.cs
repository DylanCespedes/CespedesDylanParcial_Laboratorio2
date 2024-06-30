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
    public partial class modificarComponentes : Form
    {
        private DiscoDuro discoduro = new DiscoDuro();

        private MemoriaRAM memoriaram = new MemoriaRAM();

        private TarjetaGrafica tarjetagrafica = new TarjetaGrafica();


        private DiscoDuro discoDuroModificar;

        private MemoriaRAM memoriaRamModificar;

        private TarjetaGrafica TarjetaGraficaModificar;

        public DiscoDuro Discoduro
        {
            get { return this.Discoduro; }
        }

        public MemoriaRAM Memoriaram
        {
            get { return this.Memoriaram; }
        }

        public TarjetaGrafica Tarjetagrafica
        {
            get { return this.Tarjetagrafica; }
        }

        public modificarComponentes(DiscoDuro discoDuroAEditar)
        {
            InitializeComponent();

            this.discoduro = discoDuroAEditar;

            txtId.Text = Convert.ToInt32(discoDuroAEditar.id).ToString();
            txtId.Enabled = false;
            txtTamanio.Text = discoDuroAEditar.tamanio.ToString();
            txtCapacidad.Text = discoDuroAEditar.capacidad.ToString();
            txtFechaCreacion.Text = Convert.ToDateTime(discoDuroAEditar.fechaCreacion).ToString();

            txtNombre.Text = discoDuroAEditar.nombre;
            txtFechaEntrega.Text = Convert.ToDateTime(discoDuroAEditar.fechaEntrega).ToString();
            txtPrecio.Text = discoDuroAEditar.precio.ToString();
            txtNumeroTransferencia.Text = discoDuroAEditar.numeroDeTransferencia.ToString();


            //MemoriaRAM
            txtVelocidad.Enabled = false;
            comboBox5.Enabled = false;
            comboBox4.Enabled = false;
            txtFechaCreacionMemoria.Enabled = false;
            txtFechaCreacionMemoria.Enabled = false;
            txtCapacidadMemoria.Enabled = false;

            //TarjetaGrafica
            comboBox6.Enabled = false;
            comboBox7.Enabled = false;
            txtModelo.Enabled = false;
            txtTamanioTarjeta.Enabled = false;
            txtFechaCreacionTarjeta.Enabled = false;


        }

        public modificarComponentes(MemoriaRAM memoriaRamAEditar)
        {
            InitializeComponent();

            this.memoriaram = memoriaRamAEditar;

            txtId.Text = Convert.ToInt32(memoriaRamAEditar.id).ToString();
            txtId.Enabled = false;
            txtVelocidad.Text = Convert.ToInt32(memoriaRamAEditar.velocidad).ToString();
            txtFechaCreacionMemoria.Text = Convert.ToDateTime(memoriaRamAEditar.fechaCreacionMemoria).ToString();

            txtNombre.Text = memoriaRamAEditar.nombre;
            txtFechaEntrega.Text = Convert.ToDateTime(memoriaRamAEditar.fechaEntrega).ToString();
            txtPrecio.Text = memoriaRamAEditar.precio.ToString();
            txtNumeroTransferencia.Text = memoriaRamAEditar.numeroDeTransferencia.ToString();

            //DiscoDuro
            comboBox2.Enabled = false;
            txtTamanio.Enabled = false;
            txtCapacidad.Enabled = false;
            comboBox3.Enabled = false;
            txtFechaCreacion.Enabled = false;

            //TarjetaGrafica
            comboBox6.Enabled = false;
            comboBox7.Enabled = false;
            txtModelo.Enabled = false;
            txtTamanioTarjeta.Enabled = false;
            txtFechaCreacionTarjeta.Enabled = false;
        }

        public modificarComponentes(TarjetaGrafica tarjetaGraficaAEditar)
        {
            InitializeComponent();


            this.tarjetagrafica = tarjetaGraficaAEditar;

            txtId.Text = Convert.ToInt32(tarjetaGraficaAEditar.id).ToString();
            txtId.Enabled = false;
            txtModelo.Text = tarjetagrafica.modelo.ToString();
            txtTamanioTarjeta.Text = Convert.ToInt32(tarjetaGraficaAEditar.tamanioMemoria).ToString();
            txtFechaCreacionTarjeta.Text = Convert.ToDateTime(tarjetaGraficaAEditar.fechaCreacionTarjeta).ToString();

            txtNombre.Text = tarjetaGraficaAEditar.nombre;
            txtFechaEntrega.Text = Convert.ToDateTime(tarjetaGraficaAEditar.fechaEntrega).ToString();
            txtPrecio.Text = tarjetaGraficaAEditar.precio.ToString();
            txtNumeroTransferencia.Text = tarjetaGraficaAEditar.numeroDeTransferencia.ToString();

            //DiscoDuro
            comboBox2.Enabled = false;
            txtTamanio.Enabled = false;
            txtCapacidad.Enabled = false;
            comboBox3.Enabled = false;
            txtFechaCreacion.Enabled = false;

            //MemoriaRAM
            txtVelocidad.Enabled = false;
            comboBox5.Enabled = false;
            comboBox4.Enabled = false;
            txtFechaCreacionMemoria.Enabled = false;
            txtFechaCreacionMemoria.Enabled = false;
            txtCapacidadMemoria.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(txtId.Text);
            string nombre = txtNombre.Text;
            DateTime fechaEntrega = Convert.ToDateTime(txtFechaEntrega.Text);
            EtipoEntrega tipoEntrega = (EtipoEntrega)comboBox8.SelectedIndex;
            Epago metodoPago = (Epago)comboBox9.SelectedIndex;
            double precio = Convert.ToDouble(txtPrecio.Text);
            int numeroTransferencia = Convert.ToInt32(txtNumeroTransferencia.Text);

            if (discoduro is not null)
            {

                EmarcaDisco marcaDisco = (EmarcaDisco)comboBox2.SelectedIndex;
                string tamanio = txtTamanio.Text;
                string capacidad = txtCapacidad.Text;
                Ecolor color = (Ecolor)comboBox3.SelectedIndex;
                DateTime fechaCreacionDisco = Convert.ToDateTime(txtFechaCreacion.Text);

                DiscoDuro componenteDiscoDuro = new DiscoDuro(id, marcaDisco, tamanio, capacidad, color, fechaCreacionDisco, nombre, fechaEntrega, tipoEntrega, metodoPago, precio, numeroTransferencia);

                string mensaje = Administracion.ModificarDiscoDuro(componenteDiscoDuro, id);

                MessageBox.Show(mensaje, "Aviso!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (memoriaram is null)
            {
                int velocidad = Convert.ToInt32(txtVelocidad.Text);
                EcolorMemoria colorMemoria = (EcolorMemoria)comboBox5.SelectedIndex;
                EmarcaMemoria marcaMemoria = (EmarcaMemoria)comboBox4.SelectedIndex;
                DateTime fechaCreacionMemoria = Convert.ToDateTime(txtFechaCreacionMemoria.Text);
                int capacidad = Convert.ToInt32(txtCapacidadMemoria.Text);

                MemoriaRAM componenteMemoriaRAM = new MemoriaRAM(id, velocidad, colorMemoria, marcaMemoria, fechaCreacionMemoria, capacidad, nombre, fechaEntrega, tipoEntrega, metodoPago, precio, numeroTransferencia);

                string mensaje = Administracion.ModificarMemoriaRAM(componenteMemoriaRAM, id);

                MessageBox.Show(mensaje, "Aviso!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(tarjetagrafica is not null)
            {
                EmarcaTarjeta marcaTarjeta = (EmarcaTarjeta)comboBox6.SelectedIndex;
                EserieNvidia serieNvidia = (EserieNvidia)comboBox7.SelectedIndex;
                int modelo = Convert.ToInt32(txtModelo.Text);
                int tamanioMemoria = Convert.ToInt32(txtTamanioTarjeta.Text);
                DateTime fechaCreacionTarjeta = Convert.ToDateTime(txtFechaCreacionTarjeta);

                TarjetaGrafica componenteTarjetaGrafica = new TarjetaGrafica(id, marcaTarjeta, serieNvidia, modelo, tamanioMemoria, fechaCreacionTarjeta, nombre, fechaCreacionTarjeta, tipoEntrega, metodoPago, precio, numeroTransferencia);

                string mensaje = Administracion.ModificarTarjetaGrafica(componenteTarjetaGrafica, id);

                MessageBox.Show(mensaje, "Aviso!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            

            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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

        private void modificarComponentes_Load(object sender, EventArgs e)
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

        // //////////////////////////////////////////////////////////////// //

    }
}
