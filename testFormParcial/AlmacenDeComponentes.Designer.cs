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
            btnModificar = new Button();
            btnEliminar = new Button();
            btnCerrarSesion = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnOrdenamiento = new Button();
            menuStrip1 = new MenuStrip();
            cambiarToolStripMenuItem = new ToolStripMenuItem();
            agregarToolStripMenuItem = new ToolStripMenuItem();
            discoDuroToolStripMenuItem1 = new ToolStripMenuItem();
            memoriaRAMToolStripMenuItem1 = new ToolStripMenuItem();
            tarjetaGraficaToolStripMenuItem1 = new ToolStripMenuItem();
            discoDuroToolStripMenuItem = new ToolStripMenuItem();
            memoriaRAMToolStripMenuItem = new ToolStripMenuItem();
            tarjetaGraficaToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 63);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(935, 293);
            dataGridView1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(376, 33);
            label1.Name = "label1";
            label1.Size = new Size(179, 15);
            label1.TabIndex = 1;
            label1.Text = "Componentes para enviar/retirar";
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(101, 372);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(139, 46);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar ";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(651, 372);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(139, 46);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Location = new Point(808, 372);
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
            label2.Location = new Point(827, 33);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 6;
            label2.Text = "Usuario:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 33);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 7;
            label3.Text = "Lafecha";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 33);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 8;
            label4.Text = "Fecha:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(898, 33);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 9;
            label5.Text = "nombre";
            // 
            // btnOrdenamiento
            // 
            btnOrdenamiento.Location = new Point(338, 372);
            btnOrdenamiento.Name = "btnOrdenamiento";
            btnOrdenamiento.Size = new Size(217, 46);
            btnOrdenamiento.TabIndex = 10;
            btnOrdenamiento.Text = "Ordenar por:";
            btnOrdenamiento.UseVisualStyleBackColor = true;
            btnOrdenamiento.Click += btnOrdenamiento_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cambiarToolStripMenuItem, agregarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(959, 24);
            menuStrip1.TabIndex = 11;
            menuStrip1.Text = "menuStrip1";
            // 
            // cambiarToolStripMenuItem
            // 
            cambiarToolStripMenuItem.Name = "cambiarToolStripMenuItem";
            cambiarToolStripMenuItem.Size = new Size(12, 20);
            // 
            // agregarToolStripMenuItem
            // 
            agregarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { discoDuroToolStripMenuItem1, memoriaRAMToolStripMenuItem1, tarjetaGraficaToolStripMenuItem1 });
            agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            agregarToolStripMenuItem.Size = new Size(61, 20);
            agregarToolStripMenuItem.Text = "Agregar";
            // 
            // discoDuroToolStripMenuItem1
            // 
            discoDuroToolStripMenuItem1.Name = "discoDuroToolStripMenuItem1";
            discoDuroToolStripMenuItem1.Size = new Size(180, 22);
            discoDuroToolStripMenuItem1.Text = "Disco Duro";
            discoDuroToolStripMenuItem1.Click += discoDuroToolStripMenuItem1_Click;
            // 
            // memoriaRAMToolStripMenuItem1
            // 
            memoriaRAMToolStripMenuItem1.Name = "memoriaRAMToolStripMenuItem1";
            memoriaRAMToolStripMenuItem1.Size = new Size(180, 22);
            memoriaRAMToolStripMenuItem1.Text = "Memoria RAM";
            memoriaRAMToolStripMenuItem1.Click += memoriaRAMToolStripMenuItem1_Click;
            // 
            // tarjetaGraficaToolStripMenuItem1
            // 
            tarjetaGraficaToolStripMenuItem1.Name = "tarjetaGraficaToolStripMenuItem1";
            tarjetaGraficaToolStripMenuItem1.Size = new Size(180, 22);
            tarjetaGraficaToolStripMenuItem1.Text = "Tarjeta Grafica";
            tarjetaGraficaToolStripMenuItem1.Click += tarjetaGraficaToolStripMenuItem1_Click;
            // 
            // discoDuroToolStripMenuItem
            // 
            discoDuroToolStripMenuItem.Name = "discoDuroToolStripMenuItem";
            discoDuroToolStripMenuItem.Size = new Size(180, 22);
            discoDuroToolStripMenuItem.Text = "Disco Duro";
            // 
            // memoriaRAMToolStripMenuItem
            // 
            memoriaRAMToolStripMenuItem.Name = "memoriaRAMToolStripMenuItem";
            memoriaRAMToolStripMenuItem.Size = new Size(180, 22);
            memoriaRAMToolStripMenuItem.Text = "Memoria RAM";
            // 
            // tarjetaGraficaToolStripMenuItem
            // 
            tarjetaGraficaToolStripMenuItem.Name = "tarjetaGraficaToolStripMenuItem";
            tarjetaGraficaToolStripMenuItem.Size = new Size(180, 22);
            tarjetaGraficaToolStripMenuItem.Text = "Tarjeta Grafica";
            // 
            // AlmacenDeComponentes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(959, 430);
            Controls.Add(btnOrdenamiento);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnCerrarSesion);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "AlmacenDeComponentes";
            Text = "Almacen";
            FormClosing += AlmacenDeComponentes_FormClosing;
            Load += AlmacenDeComponentes_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnCerrarSesion;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnOrdenamiento;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem cambiarToolStripMenuItem;
        private ToolStripMenuItem discoDuroToolStripMenuItem;
        private ToolStripMenuItem memoriaRAMToolStripMenuItem;
        private ToolStripMenuItem tarjetaGraficaToolStripMenuItem;
        private ToolStripMenuItem agregarToolStripMenuItem;
        private ToolStripMenuItem discoDuroToolStripMenuItem1;
        private ToolStripMenuItem memoriaRAMToolStripMenuItem1;
        private ToolStripMenuItem tarjetaGraficaToolStripMenuItem1;
    }
}
