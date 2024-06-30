namespace testFormParcial
{
    partial class ElegirComponente
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
            btnDisco = new Button();
            btnMemoria = new Button();
            btnTarjeta = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnDisco
            // 
            btnDisco.Location = new Point(169, 46);
            btnDisco.Name = "btnDisco";
            btnDisco.Size = new Size(149, 59);
            btnDisco.TabIndex = 0;
            btnDisco.Text = "Disco Duro";
            btnDisco.UseVisualStyleBackColor = true;
            btnDisco.Click += btnDisco_Click;
            // 
            // btnMemoria
            // 
            btnMemoria.Location = new Point(169, 111);
            btnMemoria.Name = "btnMemoria";
            btnMemoria.Size = new Size(149, 59);
            btnMemoria.TabIndex = 1;
            btnMemoria.Text = "Memoria RAM";
            btnMemoria.UseVisualStyleBackColor = true;
            btnMemoria.Click += btnMemoria_Click;
            // 
            // btnTarjeta
            // 
            btnTarjeta.Location = new Point(169, 176);
            btnTarjeta.Name = "btnTarjeta";
            btnTarjeta.Size = new Size(149, 59);
            btnTarjeta.TabIndex = 2;
            btnTarjeta.Text = "Tarjeta Grafica";
            btnTarjeta.UseVisualStyleBackColor = true;
            btnTarjeta.Click += btnTarjeta_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(179, 9);
            label1.Name = "label1";
            label1.Size = new Size(123, 15);
            label1.TabIndex = 3;
            label1.Text = "Elige un componente:";
            // 
            // ElegirComponente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(499, 260);
            Controls.Add(label1);
            Controls.Add(btnTarjeta);
            Controls.Add(btnMemoria);
            Controls.Add(btnDisco);
            Name = "ElegirComponente";
            Text = "ElegirComponente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDisco;
        private Button btnMemoria;
        private Button btnTarjeta;
        private Label label1;
    }
}