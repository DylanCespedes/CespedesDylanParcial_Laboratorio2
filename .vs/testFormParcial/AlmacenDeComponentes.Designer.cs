namespace testFormParcial
{
    partial class AlmacenDeComponentes
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnCerrarSesion = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnOrdenamiento = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 39);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1053, 293);
            dataGridView1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(429, 9);
            label1.Name = "label1";
            label1.Size = new Size(238, 15);
            label1.TabIndex = 1;
            label1.Text = "Pedidos de componentes para enviar/retirar";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(12, 348);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(139, 46);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(171, 348);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(139, 46);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar ";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(769, 348);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(139, 46);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Location = new Point(926, 348);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(139, 46);
            btnCerrarSesion.TabIndex = 4;
            btnCerrarSesion.Text = "Cerrar sesion";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(896, 9);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 6;
            label2.Text = "Usuario:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 9);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 7;
            label3.Text = "Lafecha";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 8;
            label4.Text = "Fecha:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(967, 9);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 9;
            label5.Text = "nombre";
            // 
            // btnOrdenamiento
            // 
            btnOrdenamiento.Location = new Point(429, 348);
            btnOrdenamiento.Name = "btnOrdenamiento";
            btnOrdenamiento.Size = new Size(238, 46);
            btnOrdenamiento.TabIndex = 10;
            btnOrdenamiento.Text = "Haz click para cambiar de listado de componente";
            btnOrdenamiento.UseVisualStyleBackColor = true;
            btnOrdenamiento.Click += btnOrdenamiento_Click;
            // 
            // AlmacenDeComponentes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1077, 406);
            Controls.Add(btnOrdenamiento);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnCerrarSesion);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "AlmacenDeComponentes";
            Text = "Almacen";
            FormClosing += AlmacenDeComponentes_FormClosing;
            Load += AlmacenDeComponentes_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnCerrarSesion;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnOrdenamiento;
    }
}
