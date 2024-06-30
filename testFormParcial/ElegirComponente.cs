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
    public partial class ElegirComponente : Form
    {
        public DiscoDuro componenteDiscoDuro;
        public MemoriaRAM componenteMemoriaRAM;
        public TarjetaGrafica componenteTarjetaGrafica;

        public ElegirComponente()
        {
            InitializeComponent();
        }

        private void btnDisco_Click(object sender, EventArgs e)
        {
            

            AgregarComponente agregarComponente = new AgregarComponente(Ecomponentes.DiscoDuro);
            DialogResult dialogResult = agregarComponente.ShowDialog();

            if (dialogResult == DialogResult.OK) 
            {
                this.componenteDiscoDuro = agregarComponente.componenteDiscoDuro;

                Administracion.discoDuros.Add(componenteDiscoDuro);

                JsonComponentes serializerDiscoDuro = new JsonComponentes("../../../../DiscoDuro.json");
                serializerDiscoDuro.GuardarDiscoDuroJson(Administracion.discoDuros);

                this.DialogResult = DialogResult.OK;
            }
            
            
        }

        private void btnMemoria_Click(object sender, EventArgs e)
        {
            AgregarComponente agregarComponente = new AgregarComponente(Ecomponentes.MemoriaRAM);
            DialogResult dialogResult = agregarComponente.ShowDialog();

            if (dialogResult == DialogResult.OK) 
            {
                this.componenteMemoriaRAM = agregarComponente.componenteMemoriaRAM;

                Administracion.memoriaRAM.Add(componenteMemoriaRAM);

                JsonComponentes serializerMemoriaRAM = new JsonComponentes("../../../../MemoriaRAM.json");
                serializerMemoriaRAM.GuardarMemoriaRAMJson(Administracion.memoriaRAM);

                this.DialogResult = DialogResult.OK;
            }


        }

        private void btnTarjeta_Click(object sender, EventArgs e)
        {
            AgregarComponente agregarComponente = new AgregarComponente(Ecomponentes.TarjetaGrafica);
            DialogResult dialogResult = agregarComponente.ShowDialog();

            if (dialogResult == DialogResult.OK) 
            {
                this.componenteTarjetaGrafica = agregarComponente.componenteTarjetaGrafica;

                Administracion.tarjetaGrafica.Add(componenteTarjetaGrafica);

                JsonComponentes serializerTarjetaGrafica = new JsonComponentes("../../../../TarjetaGrafica.json");
                serializerTarjetaGrafica.GuardarTarjetaGraficaJson(Administracion.tarjetaGrafica);

                this.DialogResult = DialogResult.OK;
            }

        }
    }
}
