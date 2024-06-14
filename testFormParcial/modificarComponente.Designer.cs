namespace testFormParcial
{
    partial class modificarComponente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // button1
            // 
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Click += button2_Click;
            // 
            // comboBox2
            // 
            comboBox2.DataSource = new EmarcaDisco[]
    {
    EmarcaDisco.Kingston,
    EmarcaDisco.Seagate,
    EmarcaDisco.Sandisk
    };
            //comboBox2.Items.AddRange(new object[] { EmarcaDisco.Kingston, EmarcaDisco.Seagate, EmarcaDisco.Sandisk });
            // 
            // comboBox3
            // 
            comboBox3.DataSource = new Ecolor[]
    {
    Ecolor.Blanco,
    Ecolor.Negro,
    Ecolor.Plateado
    };
            //comboBox3.Items.AddRange(new object[] { Ecolor.Blanco, Ecolor.Negro, Ecolor.Plateado });
            // 
            // comboBox4
            // 
            comboBox4.DataSource = new EmarcaMemoria[]
    {
    EmarcaMemoria.ADATA,
    EmarcaMemoria.Corsair,
    EmarcaMemoria.Crucial,
    EmarcaMemoria.Gskill,
    EmarcaMemoria.Kingston
    };
            //comboBox4.Items.AddRange(new object[] { EmarcaMemoria.ADATA, EmarcaMemoria.Corsair, EmarcaMemoria.Crucial, EmarcaMemoria.Gskill, EmarcaMemoria.Kingston });
            // 
            // comboBox5
            // 
            comboBox5.DataSource = new EcolorMemoria[]
    {
    EcolorMemoria.Verde,
    EcolorMemoria.Negro
    };
            //comboBox5.Items.AddRange(new object[] { EcolorMemoria.Verde, EcolorMemoria.Negro });
            // 
            // comboBox6
            // 
            comboBox6.DataSource = new EmarcaTarjeta[]
    {
    EmarcaTarjeta.AMD,
    EmarcaTarjeta.ASUS,
    EmarcaTarjeta.NVIDIA,
    EmarcaTarjeta.Intel,
    EmarcaTarjeta.MSI,
    EmarcaTarjeta.Sapphire,
    EmarcaTarjeta.Zotac,
    EmarcaTarjeta.GigabyteTecnology
    };
            //comboBox6.Items.AddRange(new object[] { EmarcaTarjeta.AMD, EmarcaTarjeta.ASUS, EmarcaTarjeta.NVIDIA, EmarcaTarjeta.Intel, EmarcaTarjeta.MSI, EmarcaTarjeta.Sapphire, EmarcaTarjeta.Zotac, EmarcaTarjeta.GigabyteTecnology });
            // 
            // comboBox7
            // 
            comboBox7.DataSource = new EserieNvidia[]
    {
    EserieNvidia.RTX,
    EserieNvidia.GTX
    };
            //comboBox7.Items.AddRange(new object[] { EserieNvidia.RTX, EserieNvidia.GTX });
            // 
            // comboBox8
            // 
            comboBox8.DataSource = new EtipoEntrega[]
    {
    EtipoEntrega.Envio,
    EtipoEntrega.Local
    };
            //comboBox8.Items.AddRange(new object[] { EtipoEntrega.Envio, EtipoEntrega.Local });
            // 
            // comboBox9
            // 
            comboBox9.DataSource = new Epago[]
    {
    Epago.Efectivo,
    Epago.TarjetaDeCredito,
    Epago.TarjetaDeDebito,
    Epago.Aplicacion
    };
            //comboBox9.Items.AddRange(new object[] { Epago.Efectivo, Epago.TarjetaDeCredito, Epago.TarjetaDeDebito, Epago.Aplicacion });
            // 
            // modificarComponente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(865, 386);
            Name = "modificarComponente";
            Text = "modificarComponente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}