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
    public partial class modificarComponente : AgregarComponente
    {
        private List<Componente> componentes;

        private Componente componente;

        private DiscoDuro discoDuroModificar;

        public Componente Componente
        {
            get { return this.componente; }
        }

        public modificarComponente(Componente componenteAEditar)
        {
            InitializeComponent();

            this.componente = componenteAEditar;

            base.txtId.Text = Convert.ToInt32(componenteAEditar.id).ToString();
            base.txtId.Enabled = false;
            base.txtNombre.Text = componenteAEditar.nombre;
            base.txtFechaEntrega.Text = Convert.ToDateTime(componenteAEditar.fechaEntrega).ToString();
            //base.comboBox8.Items.Clear();
            //base.comboBox9.Items.Clear();
            base.txtPrecio.Text = componenteAEditar.precio.ToString();
            base.txtNumeroTransferencia.Text = componenteAEditar.numeroDeTransferencia.ToString();

            //Componente
            base.comboBox1.Enabled = false;

            //DiscoDuro
            base.comboBox2.Enabled = false;
            base.txtTamanio.Enabled = false;
            base.txtCapacidad.Enabled = false;
            base.comboBox3.Enabled = false;
            base.txtFechaCreacion.Enabled = false;

            //MemoriaRAM
            base.txtVelocidad.Enabled = false;
            base.comboBox5.Enabled = false;
            base.comboBox4.Enabled = false;
            base.txtFechaCreacionMemoria.Enabled = false;
            base.txtFechaCreacionMemoria.Enabled = false;
            base.txtCapacidadMemoria.Enabled = false;

            //TarjetaGrafica
            base.comboBox6.Enabled = false;
            base.comboBox7.Enabled = false;
            base.txtModelo.Enabled = false;
            base.txtTamanioTarjeta.Enabled = false;
            base.txtFechaCreacionTarjeta.Enabled = false;


        }

        protected override void button1_Click(object sender, EventArgs e)
        {
            //Pedido de la persona(Componente)
            int id = Convert.ToInt32(txtId.Text);
            string nombre = txtNombre.Text;
            DateTime fechaEntrega = Convert.ToDateTime(txtFechaEntrega.Text);
            EtipoEntrega tipoEntrega = (EtipoEntrega)comboBox8.SelectedIndex;
            Epago metodoPago = (Epago)comboBox9.SelectedIndex;
            double precio = Convert.ToDouble(txtPrecio.Text);
            int numeroTransferencia = Convert.ToInt32(txtNumeroTransferencia.Text);

            Componente componente = new Componente(id, nombre, fechaEntrega, tipoEntrega, metodoPago, precio, numeroTransferencia);

            Administracion.ModificarDatos(componente, id);

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
