<<<<<<< HEAD
﻿using Entidades;
using System;
=======
﻿using System;
>>>>>>> 7333da0049bfc9e43ffd321b2e3b5e71319bf970
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
<<<<<<< HEAD

    public partial class AlmacenDeComponentes : Form
    {
        private List<Usuario> usuario;

        public AlmacenDeComponentes()
        {
            InitializeComponent();

            usuario = new List<Usuario>();

            string FechaActual = DateTime.Now.ToString("yyyy-MM-dd");

            label3.Text = FechaActual;
=======
    public partial class AlmacenDeComponentes : Form
    {
        public AlmacenDeComponentes()
        {
            InitializeComponent();
>>>>>>> 7333da0049bfc9e43ffd321b2e3b5e71319bf970
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
           var btnAgregar = new AgregarComponente();
            btnAgregar.Enabled = true;
            btnAgregar.ShowDialog();
            //this.Show();
            //this.Hide();
=======
            var btnAgregar = new AgregarComponente();
            this.Hide();
            btnAgregar.ShowDialog();
            this.Show();
>>>>>>> 7333da0049bfc9e43ffd321b2e3b5e71319bf970
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            var columna = dataGridView1.Columns["id"];

            DataGridViewRow filaSeleccionada = dataGridView1.Rows[0];

            int indiceColumna = dataGridView1.Columns["id"].Index;

            object valorCelda = filaSeleccionada.Cells[indiceColumna].Value;

            Componente componenteEncontrado = Administracion.componentes.Find(x => x.numeroDeTransferencia == (int)valorCelda);



=======
>>>>>>> 7333da0049bfc9e43ffd321b2e3b5e71319bf970

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            try
            {
                string numeroTransferencia = dataGridView1.SelectedRows[0].Cells["numeroTransferencia"].Value.ToString();

                DialogResult result = MessageBox.Show("Estas seguro que quieres eliminar este pedido de la lista?", "Aviso!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Administracion.EliminarComponente(Convert.ToInt32(numeroTransferencia));
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = Administracion.componentes;
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Seleccione un curso al que quieres eliminar", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
=======

>>>>>>> 7333da0049bfc9e43ffd321b2e3b5e71319bf970
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
<<<<<<< HEAD

        private void AlmacenDeComponentes_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Administracion.componentes;

            usuario = Usuario.DesealizarUsuariosJson();

            label5.Text = usuario[0].nombre;
            
        }
=======
>>>>>>> 7333da0049bfc9e43ffd321b2e3b5e71319bf970
    }
}
