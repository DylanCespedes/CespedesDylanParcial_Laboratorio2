using Entidades;

namespace testFormParcial
{
    public partial class MenuInicio : Form
    {
        private List<Usuario> usuarios;

        private string archivoRegistro = "registro.txt";

        public MenuInicio()
        {
            InitializeComponent();
            usuarios = new List<Usuario>();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            string jsonUbicacion = "../../../../MOCK_DATA.json";

            if (File.Exists(jsonUbicacion))
            {
                string jsonContent = File.ReadAllText(jsonUbicacion);
                usuarios = Usuario.DesealizarUsuariosJson();

                string ingresoCorreo = txtCorreo.Text;
                string ingresoClave = txtClave.Text;

                Usuario usuarioVerificado = usuarios.Find(e => e.correo == ingresoCorreo && e.clave == ingresoClave);

                if (usuarioVerificado != null)
                {
                    RegistrarInicioSesion(usuarioVerificado);

                    txtClave.Clear();
                    txtCorreo.Clear();

                    var btnIngresar = new AlmacenDeComponentes();
                    this.Hide();
                    btnIngresar.ShowDialog();
                    this.Show();

                    //Si entra abre el formulario principal
                }
                else
                {
                    MessageBox.Show("Correo y/o Clave invalido, Vuelve a intentarlo", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void MenuInicio_Load(object sender, EventArgs e)
        {
            Administracion.InicializarSistema();
        }

        private bool RegistrarInicioSesion(Usuario usuario)
        {

            DateTime fechaActual = DateTime.Now;

            string registro = $"{fechaActual}: Se inicio con exito para {usuario.nombre} {usuario.apellido} ({usuario.correo})";

            try
            {
                if (!File.Exists(archivoRegistro))
                {
                    using (StreamWriter sw = File.CreateText(archivoRegistro))
                    {
                        sw.WriteLine(registro);
                    }
                }
                else
                {
                    using (StreamWriter sw = File.AppendText(archivoRegistro))
                    {
                        sw.WriteLine(registro);
                        sw.Close();
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al iniciar sesion: {ex.Message}", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
        }

        private void MenuInicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnVisor_Click(object sender, EventArgs e)
        {
            var btnMostrarRegistro = new Registro();
            btnMostrarRegistro.Show();
            this.Show();
        }
    }
}
