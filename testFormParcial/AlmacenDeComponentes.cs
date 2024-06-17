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

    public partial class AlmacenDeComponentes : Form
    {
        private List<Usuario> usuario;

        private string campoOrdenado = "id";

        public AlmacenDeComponentes()
        {
            InitializeComponent();

            usuario = new List<Usuario>();

            string FechaActual = DateTime.Now.ToString("yyyy-MM-dd");

            label3.Text = FechaActual;

            this.btnOrdenamiento.Click += new System.EventHandler(this.btnOrdenamiento_Click);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var btnAgregar = new AgregarComponente();
            btnAgregar.Enabled = true;

            DialogResult dialogResult = btnAgregar.ShowDialog();


            if (dialogResult == DialogResult.OK)
            {

                Componente componente = btnAgregar.Componente;


                //Hacer lo mismo con tarjeta grafica y con memoriaRAM
                if (componente is DiscoDuro)
                {
                    DiscoDuro discoDuro = (DiscoDuro)componente;
                    Administracion.componentes.Add(discoDuro);
                }

                if (componente is MemoriaRAM)
                {
                    MemoriaRAM memoriaRAM = (MemoriaRAM)componente;
                    Administracion.componentes.Add(memoriaRAM);
                }

                if (componente is TarjetaGrafica)
                {
                    TarjetaGrafica tarjetaGrafica = (TarjetaGrafica)componente;
                    Administracion.componentes.Add(tarjetaGrafica);
                }

                JsonComponentes serializer = new JsonComponentes("../../../../Componentes.json");
                serializer.GuardarComponentesJson(Administracion.componentes);

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Administracion.componentes;

                MessageBox.Show("El pedido se ha creado correctamente!!!", "Aviso!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Componente componenteEncontrado;

            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                Epago metodoPago;
                EtipoEntrega tipoEntrega;

                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);


                string nombre = dataGridView1.SelectedRows[0].Cells["nombre"].Value.ToString();
                DateTime fechaEntrega = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells["fechaEntrega"].Value);
                int precio = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["precio"].Value);

                int numeroDeTransferencia = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["numeroDeTransferencia"].Value);

                var columnaMetodoPago = dataGridView1.SelectedRows[0].Cells["metodoPago"].Value;
                if (columnaMetodoPago != null)
                {
                    int intValue;
                    if (int.TryParse(columnaMetodoPago.ToString(), out intValue))
                    {
                        metodoPago = (Epago)intValue;
                    }
                }

                var columnatipoEntrega = dataGridView1.SelectedRows[0].Cells["tipoEntrega"].Value;
                if (columnatipoEntrega != null)
                {
                    int intValue;
                    if (int.TryParse(columnatipoEntrega.ToString(), out intValue))
                    {
                        tipoEntrega = (EtipoEntrega)intValue;
                    }
                }

                componenteEncontrado = Administracion.BuscarComponente(id);



                modificarComponente modificarComponente = new modificarComponente(componenteEncontrado);
                modificarComponente.ShowDialog();

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Administracion.componentes;

            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                Epago metodoPago;
                EtipoEntrega tipoEntrega;

                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);

                string nombre = dataGridView1.SelectedRows[0].Cells["nombre"].Value.ToString();
                DateTime fechaEntrega = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells["fechaEntrega"].Value);
                int precio = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["precio"].Value);
                int numeroDeTransferencia = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["numeroDeTransferencia"].Value);

                var columnaMetodoPago = dataGridView1.SelectedRows[0].Cells["metodoPago"].Value;
                if (columnaMetodoPago != null)
                {
                    int intValue;
                    if (int.TryParse(columnaMetodoPago.ToString(), out intValue))
                    {
                        metodoPago = (Epago)intValue;
                    }
                }

                var columnatipoEntrega = dataGridView1.SelectedRows[0].Cells["tipoEntrega"].Value;
                if (columnatipoEntrega != null)
                {
                    int intValue;
                    if (int.TryParse(columnatipoEntrega.ToString(), out intValue))
                    {
                        tipoEntrega = (EtipoEntrega)intValue;
                    }
                }

                Componente componenteBorrar = new Componente
                {
                    id = id,
                    nombre = nombre,
                    fechaEntrega = fechaEntrega,
                    precio = precio,
                    numeroDeTransferencia = numeroDeTransferencia,
                };

                DialogResult result = MessageBox.Show($"Estas seguro que quieres eliminar este pedido para {nombre} de la lista?", "Aviso!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string mensaje = Administracion.EliminarComponente(id);

                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = Administracion.componentes;

                    MessageBox.Show(mensaje, "Aviso!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Eliminacion cancelada", "Aviso!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }

        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AlmacenDeComponentes_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Administracion.componentes;

            usuario = Usuario.DesealizarUsuariosJson();

            label5.Text = usuario[0].nombre;

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Programmatic;
            }

        }

        private void AlmacenDeComponentes_FormClosing(object sender, FormClosingEventArgs e)
        {
            var resultado = MessageBox.Show("¿Estas seguro que quieres cerrar sesion y cerrar esta aplicacion?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else
            {
                e.Cancel = true;

            }
        }

        private void btnOrdenamiento_Click(object sender, EventArgs e)
        {
            switch (campoOrdenado)
            {
                case "id":
                    Administracion.componentes = Administracion.componentes.OrderBy(c => c.id).ToList();
                    campoOrdenado = "nombre";
                    btnOrdenamiento.Text = "Ordenar por: ID";
                    break;
                case "nombre":
                    Administracion.componentes = Administracion.componentes.OrderBy(c => c.nombre).ToList();
                    campoOrdenado = "precio";
                    btnOrdenamiento.Text = "Ordenar por: Nombre";
                    break;
                case "precio":
                    Administracion.componentes = Administracion.componentes.OrderBy(c => c.precio).ToList();
                    campoOrdenado = "id";
                    btnOrdenamiento.Text = "Ordenar por: Precio";
                    break;
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Administracion.componentes;
                    
            
        }
    }
}
