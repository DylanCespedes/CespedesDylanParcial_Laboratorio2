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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            string rutaArchivo = "registro.txt";
            string file = Path.GetFullPath(rutaArchivo);


            string contenido = File.ReadAllText(rutaArchivo);

            richTextBox1.Text = contenido;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
