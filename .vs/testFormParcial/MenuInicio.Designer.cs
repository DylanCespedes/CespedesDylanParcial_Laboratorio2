namespace testFormParcial
{
    partial class MenuInicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtCorreo = new TextBox();
            txtClave = new TextBox();
            label3 = new Label();
            btnIngresar = new Button();
            btnVisor = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 35);
            label1.Name = "label1";
            label1.Size = new Size(191, 15);
            label1.TabIndex = 0;
            label1.Text = "Centro de componentes para la PC";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 66);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 1;
            label2.Text = "Correo";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(52, 84);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(239, 23);
            txtCorreo.TabIndex = 2;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(52, 141);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(239, 23);
            txtClave.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 123);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 3;
            label3.Text = "Clave";
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(52, 190);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(109, 47);
            btnIngresar.TabIndex = 5;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnVisor
            // 
            btnVisor.Location = new Point(181, 190);
            btnVisor.Name = "btnVisor";
            btnVisor.Size = new Size(110, 47);
            btnVisor.TabIndex = 6;
            btnVisor.Text = "Mostrar visor de inicio sesion";
            btnVisor.UseVisualStyleBackColor = true;
            btnVisor.Click += btnVisor_Click;
            // 
            // MenuInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 64, 0);
            ClientSize = new Size(352, 291);
            Controls.Add(btnVisor);
            Controls.Add(btnIngresar);
            Controls.Add(txtClave);
            Controls.Add(label3);
            Controls.Add(txtCorreo);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MenuInicio";
            Text = "MenuInicioSesion";
            FormClosing += MenuInicio_FormClosing;
            Load += MenuInicio_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtCorreo;
        private TextBox txtClave;
        private Label label3;
        private Button btnIngresar;
        private Button btnVisor;
    }
}
