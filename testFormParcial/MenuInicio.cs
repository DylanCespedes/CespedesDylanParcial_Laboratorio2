using Entidades;

namespace testFormParcial
{
    public partial class MenuInicio : Form
    {
        private List<Usuario> usuarios;

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
    }
}
