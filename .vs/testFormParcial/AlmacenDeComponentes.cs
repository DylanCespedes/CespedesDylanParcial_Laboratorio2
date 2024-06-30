using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testFormParcial
{

    public partial class AlmacenDeComponentes : Form
    {
        private List<Usuario> usuario;

        private List<DiscoDuro> lista1;
        private List<MemoriaRAM> lista2;
        private List<TarjetaGrafica> lista3;

        private int listaActual = 1;

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

            ElegirComponente ElegirComponente = new ElegirComponente();

            DialogResult dialogResult = ElegirComponente.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Administracion.discoDuros;

                MessageBox.Show("El componente se ha agregado correctamente!!!", "Aviso!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            DiscoDuro discoDuroEncontrado;
            MemoriaRAM memoriaRamEncontrada;
            TarjetaGrafica tarjetaGraficaEncontrada;

            string columna = "valor";

            if (dataGridView1.Columns.Contains(columna))
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    var prueba = dataGridView1.SelectedRows[0].Cells["valor"].Value;

                    if (Enum.TryParse(typeof(Ecomponentes), prueba.ToString(), out var estado))
                    {
                        Ecomponentes valor = (Ecomponentes)estado;

                        if (valor == Ecomponentes.DiscoDuro)
                        {
                            EmarcaDisco tipoMarca;
                            Ecolor tipoColor;

                            Epago metodoPago;
                            EtipoEntrega tipoEntrega;

                            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);
                            string tamanio = dataGridView1.SelectedRows[0].Cells["tamanio"].Value.ToString();
                            string capacidad = dataGridView1.SelectedRows[0].Cells["capacidad"].Value.ToString();
                            DateTime fechaCreacion = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells["fechaCreacion"].Value);


                            string nombre = dataGridView1.SelectedRows[0].Cells["nombre"].Value.ToString();
                            DateTime fechaEntrega = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells["fechaEntrega"].Value);
                            int precio = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["precio"].Value);
                            int numeroDeTransferencia = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["numeroDeTransferencia"].Value);

                            var columnaTipoMarca = dataGridView1.SelectedRows[0].Cells["tipoMarca"].Value;
                            if (columnaTipoMarca != null)
                            {
                                int intValue;
                                if (int.TryParse(columnaTipoMarca.ToString(), out intValue))
                                {
                                    tipoMarca = (EmarcaDisco)intValue;
                                }
                            }

                            var columnaTipoColor = dataGridView1.SelectedRows[0].Cells["color"].Value;
                            if (columnaTipoColor != null)
                            {
                                int intValue;

                                if (int.TryParse(columnaTipoColor.ToString(), out intValue))
                                {
                                    tipoColor = (Ecolor)intValue;
                                }
                            }

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

                            discoDuroEncontrado = Administracion.BuscarDiscoDuro(id);

                            modificarComponentes modificarComponente = new modificarComponentes(discoDuroEncontrado);
                            modificarComponente.Show();

                            dataGridView1.DataSource = null;
                            dataGridView1.DataSource = Administracion.discoDuros;
                        }

                        if (valor == Ecomponentes.MemoriaRAM)
                        {
                            Epago metodoPago;
                            EtipoEntrega tipoEntrega;

                            EcolorMemoria colorMemoria;
                            EmarcaMemoria marcaMemoria;

                            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);
                            int velocidad = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["velocidad"].Value);
                            DateTime fechaCreacionMemoria = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells["fechaCreacionMemoria"].Value);
                            int capacidad = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["capacidad"].Value);

                            string nombre = dataGridView1.SelectedRows[0].Cells["nombre"].Value.ToString();
                            DateTime fechaEntrega = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells["fechaEntrega"].Value);
                            int precio = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["precio"].Value);
                            int numeroDeTransferencia = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["numeroDeTransferencia"].Value);

                            var columnaColor = dataGridView1.SelectedRows[0].Cells["colorMemoria"].Value;
                            if (columnaColor != null)
                            {
                                int intValue;
                                if (int.TryParse(columnaColor.ToString(), out intValue))
                                {
                                    colorMemoria = (EcolorMemoria)intValue;
                                }
                            }

                            var columnaMarcaMemoria = dataGridView1.SelectedRows[0].Cells["marcaMemoria"].Value;
                            if (columnaMarcaMemoria != null)
                            {
                                int intValue;

                                if (int.TryParse(columnaMarcaMemoria.ToString(), out intValue))
                                {
                                    marcaMemoria = (EmarcaMemoria)intValue;
                                }
                            }

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

                            memoriaRamEncontrada = Administracion.BuscarMemoriaRAM(id);
                            
                            modificarComponentes modificarComponente = new modificarComponentes(memoriaRamEncontrada);
                            modificarComponente.Show();

                            dataGridView1.DataSource = null;
                            dataGridView1.DataSource = Administracion.memoriaRAM;

                        }

                        if (valor == Ecomponentes.TarjetaGrafica)
                        {
                            Epago metodoPago;
                            EtipoEntrega tipoEntrega;

                            EmarcaTarjeta marcaTarjeta;
                            EserieNvidia serieNvidia;

                            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);
                            int modelo = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["modelo"].Value);
                            DateTime fechaCreacionTarjeta = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells["fechaCreacionTarjeta"].Value);

                            string nombre = dataGridView1.SelectedRows[0].Cells["nombre"].Value.ToString();
                            DateTime fechaEntrega = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells["fechaEntrega"].Value);
                            int precio = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["precio"].Value);
                            int numeroDeTransferencia = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["numeroDeTransferencia"].Value);

                            var columnaMarcaTarjeta = dataGridView1.SelectedRows[0].Cells["marcaTarjeta"].Value;
                            if (columnaMarcaTarjeta != null)
                            {
                                int intValue;
                                if (int.TryParse(columnaMarcaTarjeta.ToString(), out intValue))
                                {
                                    marcaTarjeta = (EmarcaTarjeta)intValue;
                                }
                            }

                            var columnaSeriaNvidia = dataGridView1.SelectedRows[0].Cells["serieNvidia"].Value;
                            if (columnaSeriaNvidia != null)
                            {
                                int intValue;

                                if (int.TryParse(columnaSeriaNvidia.ToString(), out intValue))
                                {
                                    serieNvidia = (EserieNvidia)intValue;
                                }
                            }

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

                            tarjetaGraficaEncontrada = Administracion.BuscarTarjetaGrafica(id);

                            modificarComponentes modificarComponente = new modificarComponentes(tarjetaGraficaEncontrada);
                            modificarComponente.Show();

                            dataGridView1.DataSource = null;
                            dataGridView1.DataSource = Administracion.tarjetaGrafica;

                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Cambia de lista para poder modificar el producto", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            string columna = "valor";

            if (dataGridView1.Columns.Contains(columna))
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    var prueba = dataGridView1.SelectedRows[0].Cells["valor"].Value;

                    if (Enum.TryParse(typeof(Ecomponentes), prueba.ToString(), out var estado))
                    {
                        Ecomponentes valor = (Ecomponentes)estado;

                        if (valor == Ecomponentes.DiscoDuro)
                        {
                            if (this.dataGridView1.SelectedRows.Count > 0)
                            {
                                EmarcaDisco tipoMarca;
                                Ecolor color;

                                Epago metodoPago;
                                EtipoEntrega tipoEntrega;

                                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);

                                string tamanio = dataGridView1.SelectedRows[0].Cells["tamanio"].Value.ToString();
                                string capacidad = dataGridView1.SelectedRows[0].Cells["capacidad"].Value.ToString();
                                DateTime fechaCreacionDisco = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells["fechaCreacion"].Value);

                                string nombre = dataGridView1.SelectedRows[0].Cells["nombre"].Value.ToString();
                                DateTime fechaEntrega = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells["fechaEntrega"].Value);
                                int precio = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["precio"].Value);
                                int numeroDeTransferencia = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["numeroDeTransferencia"].Value);

                                var columnaMarcaDisco = dataGridView1.SelectedRows[0].Cells["tipoMarca"].Value;
                                if(columnaMarcaDisco != null)
                                {
                                    int intValue;
                                    if(int.TryParse(columnaMarcaDisco.ToString(), out intValue)) 
                                    {
                                        tipoMarca = (EmarcaDisco)intValue;
                                    }
                                }

                                var columnaColor = dataGridView1.SelectedRows[0].Cells["color"].Value;
                                if(columnaColor != null ) 
                                {
                                    int intValue;
                                    if(int.TryParse(columnaColor.ToString(), out intValue))
                                    {
                                        color = (Ecolor)intValue;
                                    }
                                }

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

                                DiscoDuro discoDuroEliminar = new DiscoDuro
                                {
                                    id = id,
                                    tamanio = tamanio,
                                    fechaCreacion = fechaCreacionDisco,

                                    nombre = nombre,
                                    fechaEntrega = fechaEntrega,
                                    precio = precio,
                                    numeroDeTransferencia = numeroDeTransferencia
                                };

                                DialogResult result = MessageBox.Show($"Estas seguro que quieres eliminar este pedido para {nombre} de la lista?", "Aviso!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                                if (result == DialogResult.Yes) 
                                {
                                    string mensaje = Administracion.EliminarDiscoDuro(id);

                                    dataGridView1.DataSource = null;
                                    dataGridView1.DataSource = Administracion.discoDuros;
                                }
                                else
                                {
                                    MessageBox.Show("Eliminacion cancelada", "Aviso!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }

                            }
                        }

                        if (valor == Ecomponentes.MemoriaRAM)
                        {

                            EcolorMemoria colorMemoria;
                            EmarcaMemoria marcaMemoria;

                            Epago metodoPago;
                            EtipoEntrega tipoEntrega;

                            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);

                            int velocidad = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["velocidad"].Value);
                            DateTime fechaCreacionMemoria = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells["fechaCreacionMemoria"].Value);
                            int capacidad = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["capacidad"].Value);

                            string nombre = dataGridView1.SelectedRows[0].Cells["nombre"].Value.ToString();
                            DateTime fechaEntrega = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells["fechaEntrega"].Value);
                            int precio = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["precio"].Value);
                            int numeroDeTransferencia = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["numeroDeTransferencia"].Value);

                            var columnaColorMemoria = dataGridView1.SelectedRows[0].Cells["colorMemoria"].Value;
                            if(columnaColorMemoria != null)
                            {
                                int intValue;
                                if (int.TryParse(columnaColorMemoria.ToString(), out intValue))
                                {
                                    colorMemoria = (EcolorMemoria)intValue;
                                }
                            }

                            var columnaMarcaMemoria = dataGridView1.SelectedRows[0].Cells["marcaMemoria"].Value;
                            if (columnaMarcaMemoria != null) 
                            {
                                int intValue;
                                if(int.TryParse(columnaMarcaMemoria.ToString(), out intValue))
                                {
                                    marcaMemoria = (EmarcaMemoria)intValue;
                                }
                            }

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

                            MemoriaRAM memoriaRamEliminar = new MemoriaRAM
                            {
                                id = id,
                                velocidad = velocidad,
                                fechaCreacionMemoria = fechaCreacionMemoria,
                                capacidad = capacidad,

                                nombre = nombre,
                                fechaEntrega = fechaEntrega,
                                precio = precio,
                                numeroDeTransferencia = numeroDeTransferencia
                            };

                            DialogResult result = MessageBox.Show($"Estas seguro que quieres eliminar este pedido para {nombre} de la lista?", "Aviso!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (result == DialogResult.Yes)
                            {
                                string mensaje = Administracion.EliminarMemoriaRAM(id);

                                dataGridView1.DataSource = null;
                                dataGridView1.DataSource = Administracion.memoriaRAM;
                            }
                            else
                            {
                                MessageBox.Show("Eliminacion cancelada", "Aviso!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }

                        }

                        if (valor == Ecomponentes.TarjetaGrafica)
                        {
                            EmarcaTarjeta marcaTarjeta;
                            EserieNvidia serieNvidia;

                            Epago metodoPago;
                            EtipoEntrega tipoEntrega;

                            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);

                            int modelo = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["modelo"].Value);
                            int tamanioMemoria = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["tamanioMemoria"].Value);
                            DateTime fechaCreacionTarjeta = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells["fechaCreacionTarjeta"].Value);

                            string nombre = dataGridView1.SelectedRows[0].Cells["nombre"].Value.ToString();
                            DateTime fechaEntrega = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells["fechaEntrega"].Value);
                            int precio = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["precio"].Value);
                            int numeroDeTransferencia = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["numeroDeTransferencia"].Value);

                            var columnaMarcaTarjeta = dataGridView1.SelectedRows[0].Cells["marcaTarjeta"].Value;
                            if (columnaMarcaTarjeta != null)
                            {
                                int intValue;
                                if (int.TryParse(columnaMarcaTarjeta.ToString(), out intValue))
                                {
                                    marcaTarjeta = (EmarcaTarjeta)intValue;
                                }
                            }

                            var columnaSerieNvidia = dataGridView1.SelectedRows[0].Cells["serieNvidia"].Value;
                            if (columnaSerieNvidia != null) 
                            {
                                int intValue;
                                if(int.TryParse(columnaSerieNvidia.ToString(), out intValue))
                                {
                                    serieNvidia = (EserieNvidia)intValue;
                                }
                            }

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


                            TarjetaGrafica tarjetaGraficaEliminar = new TarjetaGrafica
                            {
                                id = id,
                                modelo = modelo,
                                tamanioMemoria = tamanioMemoria,
                                fechaCreacionTarjeta = fechaCreacionTarjeta,

                                nombre = nombre,
                                fechaEntrega = fechaEntrega,
                                precio = precio,
                                numeroDeTransferencia = numeroDeTransferencia
                            };

                            DialogResult result = MessageBox.Show($"Estas seguro que quieres eliminar este pedido para {nombre} de la lista?", "Aviso!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (result == DialogResult.Yes)
                            {
                                string mensaje = Administracion.EliminarTarjetaGrafica(id);

                                dataGridView1.DataSource = null;
                                dataGridView1.DataSource = Administracion.tarjetaGrafica;
                            }
                            else
                            {
                                MessageBox.Show("Eliminacion cancelada", "Aviso!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Cambia de lista para poder eliminar el producto", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AlmacenDeComponentes_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = Administracion.listaCombinada;


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

            switch (listaActual)
            {
                case 1:
                    MostrarListaDiscoDuro(lista1);
                    btnOrdenamiento.Text = "Mostrar: Disco Duro";
                    break;
                case 2:
                    MostrarListaMemoria(lista2);
                    btnOrdenamiento.Text = "Mostrar: Memoria RAM";
                    break;
                case 3:
                    MostrarListaTarjeta(lista3);
                    btnOrdenamiento.Text = "Mostrar: Tarjeta Grafica";
                    break;
                default:
                    break;

            }

            listaActual++;
            if (listaActual > 3) 
            {
                listaActual = 1;
            }

        }
        
        private void MostrarListaDiscoDuro(List<DiscoDuro> lista)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Administracion.discoDuros;
        }

        private void MostrarListaMemoria(List<MemoriaRAM> lista)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Administracion.memoriaRAM;
        }

        private void MostrarListaTarjeta(List<TarjetaGrafica> lista)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource= Administracion.tarjetaGrafica;
        }
    }
}
