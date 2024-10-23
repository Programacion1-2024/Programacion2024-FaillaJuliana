namespace CPresentacion
{
    partial class ABMAutor
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            tabPage3 = new TabPage();
            lb_Buscar = new Label();
            cb_BuscarAutor = new ComboBox();
            tb_biografiaMod = new TextBox();
            tb_telefonoMod = new TextBox();
            tb_apellidoMod = new TextBox();
            tb_emailMod = new TextBox();
            tb_nacionalidadMod = new TextBox();
            tb_nombreMod = new TextBox();
            btn_guardarMod = new Button();
            lb_biografiaMod = new Label();
            lb_telefonoMod = new Label();
            lb_emailMod = new Label();
            lb_nacionalidadMod = new Label();
            lb_apellidoMod = new Label();
            lb_nombreMod = new Label();
            tabPage2 = new TabPage();
            tb_biografia = new TextBox();
            tb_telefono = new TextBox();
            tb_apellido = new TextBox();
            tb_email = new TextBox();
            tb_nacionalidad = new TextBox();
            tb_nombre = new TextBox();
            btn_guardarAlta = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Listado = new TabPage();
            dgv_Listado = new DataGridView();
            Eliminar = new DataGridViewButtonColumn();
            Inicio = new TabControl();
            menuStrip1 = new MenuStrip();
            inicioToolStripMenuItem = new ToolStripMenuItem();
            autoresToolStripMenuItem = new ToolStripMenuItem();
            librosToolStripMenuItem = new ToolStripMenuItem();
            editorialToolStripMenuItem = new ToolStripMenuItem();
            ventaToolStripMenuItem = new ToolStripMenuItem();
            préstamoToolStripMenuItem = new ToolStripMenuItem();
            copiaLibroToolStripMenuItem = new ToolStripMenuItem();
            clienteToolStripMenuItem = new ToolStripMenuItem();
            empleadoToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            tabPage3.SuspendLayout();
            tabPage2.SuspendLayout();
            Listado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Listado).BeginInit();
            Inicio.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.Tan;
            tabPage3.Controls.Add(lb_Buscar);
            tabPage3.Controls.Add(cb_BuscarAutor);
            tabPage3.Controls.Add(tb_biografiaMod);
            tabPage3.Controls.Add(tb_telefonoMod);
            tabPage3.Controls.Add(tb_apellidoMod);
            tabPage3.Controls.Add(tb_emailMod);
            tabPage3.Controls.Add(tb_nacionalidadMod);
            tabPage3.Controls.Add(tb_nombreMod);
            tabPage3.Controls.Add(btn_guardarMod);
            tabPage3.Controls.Add(lb_biografiaMod);
            tabPage3.Controls.Add(lb_telefonoMod);
            tabPage3.Controls.Add(lb_emailMod);
            tabPage3.Controls.Add(lb_nacionalidadMod);
            tabPage3.Controls.Add(lb_apellidoMod);
            tabPage3.Controls.Add(lb_nombreMod);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(897, 514);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Modificacion";
            // 
            // lb_Buscar
            // 
            lb_Buscar.Anchor = AnchorStyles.None;
            lb_Buscar.AutoSize = true;
            lb_Buscar.Location = new Point(291, 73);
            lb_Buscar.Name = "lb_Buscar";
            lb_Buscar.Size = new Size(74, 20);
            lb_Buscar.TabIndex = 34;
            lb_Buscar.Text = "Busqueda";
            // 
            // cb_BuscarAutor
            // 
            cb_BuscarAutor.Anchor = AnchorStyles.None;
            cb_BuscarAutor.FormattingEnabled = true;
            cb_BuscarAutor.Location = new Point(394, 72);
            cb_BuscarAutor.Name = "cb_BuscarAutor";
            cb_BuscarAutor.Size = new Size(161, 28);
            cb_BuscarAutor.TabIndex = 33;
            cb_BuscarAutor.SelectedIndexChanged += cb_BuscarAutor_SelectedIndexChanged;
            // 
            // tb_biografiaMod
            // 
            tb_biografiaMod.Anchor = AnchorStyles.None;
            tb_biografiaMod.Location = new Point(285, 290);
            tb_biografiaMod.Multiline = true;
            tb_biografiaMod.Name = "tb_biografiaMod";
            tb_biografiaMod.Size = new Size(434, 97);
            tb_biografiaMod.TabIndex = 32;
            // 
            // tb_telefonoMod
            // 
            tb_telefonoMod.Anchor = AnchorStyles.None;
            tb_telefonoMod.Location = new Point(558, 176);
            tb_telefonoMod.Name = "tb_telefonoMod";
            tb_telefonoMod.Size = new Size(154, 27);
            tb_telefonoMod.TabIndex = 31;
            // 
            // tb_apellidoMod
            // 
            tb_apellidoMod.Anchor = AnchorStyles.None;
            tb_apellidoMod.Location = new Point(558, 117);
            tb_apellidoMod.Name = "tb_apellidoMod";
            tb_apellidoMod.Size = new Size(154, 27);
            tb_apellidoMod.TabIndex = 30;
            // 
            // tb_emailMod
            // 
            tb_emailMod.Anchor = AnchorStyles.None;
            tb_emailMod.Location = new Point(285, 227);
            tb_emailMod.Name = "tb_emailMod";
            tb_emailMod.Size = new Size(154, 27);
            tb_emailMod.TabIndex = 29;
            // 
            // tb_nacionalidadMod
            // 
            tb_nacionalidadMod.Anchor = AnchorStyles.None;
            tb_nacionalidadMod.Location = new Point(285, 171);
            tb_nacionalidadMod.Name = "tb_nacionalidadMod";
            tb_nacionalidadMod.Size = new Size(154, 27);
            tb_nacionalidadMod.TabIndex = 28;
            // 
            // tb_nombreMod
            // 
            tb_nombreMod.Anchor = AnchorStyles.None;
            tb_nombreMod.Location = new Point(285, 120);
            tb_nombreMod.Name = "tb_nombreMod";
            tb_nombreMod.Size = new Size(154, 27);
            tb_nombreMod.TabIndex = 27;
            // 
            // btn_guardarMod
            // 
            btn_guardarMod.Anchor = AnchorStyles.None;
            btn_guardarMod.Location = new Point(438, 416);
            btn_guardarMod.Name = "btn_guardarMod";
            btn_guardarMod.Size = new Size(117, 37);
            btn_guardarMod.TabIndex = 26;
            btn_guardarMod.Text = "Guardar";
            btn_guardarMod.UseVisualStyleBackColor = true;
            btn_guardarMod.Click += btn_guardarMod_Click;
            // 
            // lb_biografiaMod
            // 
            lb_biografiaMod.Anchor = AnchorStyles.None;
            lb_biografiaMod.AutoSize = true;
            lb_biografiaMod.Location = new Point(148, 293);
            lb_biografiaMod.Name = "lb_biografiaMod";
            lb_biografiaMod.Size = new Size(70, 20);
            lb_biografiaMod.TabIndex = 25;
            lb_biografiaMod.Text = "Biografia";
            // 
            // lb_telefonoMod
            // 
            lb_telefonoMod.Anchor = AnchorStyles.None;
            lb_telefonoMod.AutoSize = true;
            lb_telefonoMod.Location = new Point(454, 179);
            lb_telefonoMod.Name = "lb_telefonoMod";
            lb_telefonoMod.Size = new Size(67, 20);
            lb_telefonoMod.TabIndex = 24;
            lb_telefonoMod.Text = "Telefono";
            // 
            // lb_emailMod
            // 
            lb_emailMod.Anchor = AnchorStyles.None;
            lb_emailMod.AutoSize = true;
            lb_emailMod.Location = new Point(148, 234);
            lb_emailMod.Name = "lb_emailMod";
            lb_emailMod.Size = new Size(46, 20);
            lb_emailMod.TabIndex = 23;
            lb_emailMod.Text = "Email";
            // 
            // lb_nacionalidadMod
            // 
            lb_nacionalidadMod.Anchor = AnchorStyles.None;
            lb_nacionalidadMod.AutoSize = true;
            lb_nacionalidadMod.Location = new Point(148, 174);
            lb_nacionalidadMod.Name = "lb_nacionalidadMod";
            lb_nacionalidadMod.Size = new Size(98, 20);
            lb_nacionalidadMod.TabIndex = 22;
            lb_nacionalidadMod.Text = "Nacionalidad";
            // 
            // lb_apellidoMod
            // 
            lb_apellidoMod.Anchor = AnchorStyles.None;
            lb_apellidoMod.AutoSize = true;
            lb_apellidoMod.Location = new Point(455, 120);
            lb_apellidoMod.Name = "lb_apellidoMod";
            lb_apellidoMod.Size = new Size(66, 20);
            lb_apellidoMod.TabIndex = 21;
            lb_apellidoMod.Text = "Apellido";
            // 
            // lb_nombreMod
            // 
            lb_nombreMod.Anchor = AnchorStyles.None;
            lb_nombreMod.AutoSize = true;
            lb_nombreMod.Location = new Point(148, 120);
            lb_nombreMod.Name = "lb_nombreMod";
            lb_nombreMod.Size = new Size(64, 20);
            lb_nombreMod.TabIndex = 20;
            lb_nombreMod.Text = "Nombre";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Tan;
            tabPage2.Controls.Add(tb_biografia);
            tabPage2.Controls.Add(tb_telefono);
            tabPage2.Controls.Add(tb_apellido);
            tabPage2.Controls.Add(tb_email);
            tabPage2.Controls.Add(tb_nacionalidad);
            tabPage2.Controls.Add(tb_nombre);
            tabPage2.Controls.Add(btn_guardarAlta);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label1);
            tabPage2.ForeColor = SystemColors.ControlText;
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(897, 514);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Alta";
            // 
            // tb_biografia
            // 
            tb_biografia.Anchor = AnchorStyles.None;
            tb_biografia.Location = new Point(287, 293);
            tb_biografia.Multiline = true;
            tb_biografia.Name = "tb_biografia";
            tb_biografia.Size = new Size(422, 108);
            tb_biografia.TabIndex = 19;
            // 
            // tb_telefono
            // 
            tb_telefono.Anchor = AnchorStyles.None;
            tb_telefono.Location = new Point(560, 179);
            tb_telefono.Name = "tb_telefono";
            tb_telefono.Size = new Size(142, 27);
            tb_telefono.TabIndex = 18;
            // 
            // tb_apellido
            // 
            tb_apellido.Anchor = AnchorStyles.None;
            tb_apellido.Location = new Point(560, 120);
            tb_apellido.Name = "tb_apellido";
            tb_apellido.Size = new Size(142, 27);
            tb_apellido.TabIndex = 17;
            // 
            // tb_email
            // 
            tb_email.Anchor = AnchorStyles.None;
            tb_email.Location = new Point(287, 230);
            tb_email.Name = "tb_email";
            tb_email.Size = new Size(142, 27);
            tb_email.TabIndex = 16;
            // 
            // tb_nacionalidad
            // 
            tb_nacionalidad.Anchor = AnchorStyles.None;
            tb_nacionalidad.Location = new Point(287, 174);
            tb_nacionalidad.Name = "tb_nacionalidad";
            tb_nacionalidad.Size = new Size(142, 27);
            tb_nacionalidad.TabIndex = 15;
            // 
            // tb_nombre
            // 
            tb_nombre.Anchor = AnchorStyles.None;
            tb_nombre.Location = new Point(287, 123);
            tb_nombre.Name = "tb_nombre";
            tb_nombre.Size = new Size(142, 27);
            tb_nombre.TabIndex = 14;
            // 
            // btn_guardarAlta
            // 
            btn_guardarAlta.Anchor = AnchorStyles.None;
            btn_guardarAlta.Location = new Point(432, 425);
            btn_guardarAlta.Name = "btn_guardarAlta";
            btn_guardarAlta.Size = new Size(110, 41);
            btn_guardarAlta.TabIndex = 13;
            btn_guardarAlta.Text = "Guardar";
            btn_guardarAlta.UseVisualStyleBackColor = true;
            btn_guardarAlta.Click += btn_guardarAlta_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(150, 296);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 12;
            label6.Text = "Biografia";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(456, 182);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 10;
            label5.Text = "Telefono";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(150, 237);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 8;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(150, 177);
            label3.Name = "label3";
            label3.Size = new Size(98, 20);
            label3.TabIndex = 6;
            label3.Text = "Nacionalidad";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(457, 123);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 4;
            label2.Text = "Apellido";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(150, 123);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 2;
            label1.Text = "Nombre";
            // 
            // Listado
            // 
            Listado.BackColor = Color.Tan;
            Listado.Controls.Add(dgv_Listado);
            Listado.Location = new Point(4, 29);
            Listado.Name = "Listado";
            Listado.Padding = new Padding(3);
            Listado.Size = new Size(897, 514);
            Listado.TabIndex = 0;
            Listado.Text = "Listado";
            // 
            // dgv_Listado
            // 
            dgv_Listado.Anchor = AnchorStyles.None;
            dgv_Listado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Listado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Listado.Columns.AddRange(new DataGridViewColumn[] { Eliminar });
            dgv_Listado.Location = new Point(28, 18);
            dgv_Listado.Name = "dgv_Listado";
            dgv_Listado.RowHeadersWidth = 51;
            dgv_Listado.Size = new Size(846, 471);
            dgv_Listado.TabIndex = 0;
            dgv_Listado.CellContentClick += dgv_Listado_CellContentClick;
            // 
            // Eliminar
            // 
            Eliminar.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Eliminar.FlatStyle = FlatStyle.System;
            Eliminar.HeaderText = "";
            Eliminar.MinimumWidth = 6;
            Eliminar.Name = "Eliminar";
            Eliminar.Text = "Eliminar";
            Eliminar.UseColumnTextForButtonValue = true;
            Eliminar.Width = 24;
            // 
            // Inicio
            // 
            Inicio.Anchor = AnchorStyles.None;
            Inicio.Controls.Add(Listado);
            Inicio.Controls.Add(tabPage2);
            Inicio.Controls.Add(tabPage3);
            Inicio.Location = new Point(0, 55);
            Inicio.Name = "Inicio";
            Inicio.SelectedIndex = 0;
            Inicio.Size = new Size(905, 547);
            Inicio.TabIndex = 1;
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { inicioToolStripMenuItem, autoresToolStripMenuItem, librosToolStripMenuItem, editorialToolStripMenuItem, ventaToolStripMenuItem, préstamoToolStripMenuItem, copiaLibroToolStripMenuItem, clienteToolStripMenuItem, empleadoToolStripMenuItem, toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(917, 52);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "Menu";
            // 
            // inicioToolStripMenuItem
            // 
            inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            inicioToolStripMenuItem.Size = new Size(59, 48);
            inicioToolStripMenuItem.Text = "Inicio";
            inicioToolStripMenuItem.Click += inicioToolStripMenuItem_Click;
            // 
            // autoresToolStripMenuItem
            // 
            autoresToolStripMenuItem.Name = "autoresToolStripMenuItem";
            autoresToolStripMenuItem.Size = new Size(60, 48);
            autoresToolStripMenuItem.Text = "Autor";
            // 
            // librosToolStripMenuItem
            // 
            librosToolStripMenuItem.Name = "librosToolStripMenuItem";
            librosToolStripMenuItem.Size = new Size(57, 48);
            librosToolStripMenuItem.Text = "Libro";
            // 
            // editorialToolStripMenuItem
            // 
            editorialToolStripMenuItem.Name = "editorialToolStripMenuItem";
            editorialToolStripMenuItem.Size = new Size(79, 48);
            editorialToolStripMenuItem.Text = "Editorial";
            editorialToolStripMenuItem.Click += editorialToolStripMenuItem_Click;
            // 
            // ventaToolStripMenuItem
            // 
            ventaToolStripMenuItem.Name = "ventaToolStripMenuItem";
            ventaToolStripMenuItem.Size = new Size(60, 48);
            ventaToolStripMenuItem.Text = "Venta";
            // 
            // préstamoToolStripMenuItem
            // 
            préstamoToolStripMenuItem.Name = "préstamoToolStripMenuItem";
            préstamoToolStripMenuItem.Size = new Size(85, 48);
            préstamoToolStripMenuItem.Text = "Préstamo";
            // 
            // copiaLibroToolStripMenuItem
            // 
            copiaLibroToolStripMenuItem.Name = "copiaLibroToolStripMenuItem";
            copiaLibroToolStripMenuItem.Size = new Size(96, 48);
            copiaLibroToolStripMenuItem.Text = "CopiaLibro";
            // 
            // clienteToolStripMenuItem
            // 
            clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            clienteToolStripMenuItem.Size = new Size(69, 48);
            clienteToolStripMenuItem.Text = "Cliente";
            // 
            // empleadoToolStripMenuItem
            // 
            empleadoToolStripMenuItem.Name = "empleadoToolStripMenuItem";
            empleadoToolStripMenuItem.Size = new Size(91, 48);
            empleadoToolStripMenuItem.Text = "Empleado";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(14, 48);
            // 
            // ABMAutor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(917, 614);
            Controls.Add(menuStrip1);
            Controls.Add(Inicio);
            Name = "ABMAutor";
            Text = "ABMAutor";
            Load += ABMAutor_Load;
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            Listado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_Listado).EndInit();
            Inicio.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private TabPage tabPage3;
        private Label lb_Buscar;
        private ComboBox cb_BuscarAutor;
        private TextBox tb_biografiaMod;
        private TextBox tb_telefonoMod;
        private TextBox tb_apellidoMod;
        private TextBox tb_emailMod;
        private TextBox tb_nacionalidadMod;
        private TextBox tb_nombreMod;
        private Button btn_guardarMod;
        private Label lb_biografiaMod;
        private Label lb_telefonoMod;
        private Label lb_emailMod;
        private Label lb_nacionalidadMod;
        private Label lb_apellidoMod;
        private Label lb_nombreMod;
        private TabPage tabPage2;
        private TextBox tb_biografia;
        private TextBox tb_telefono;
        private TextBox tb_apellido;
        private TextBox tb_email;
        private TextBox tb_nacionalidad;
        private TextBox tb_nombre;
        private Button btn_guardarAlta;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TabPage Listado;
        private TabControl Inicio;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem inicioToolStripMenuItem;
        private ToolStripMenuItem autoresToolStripMenuItem;
        private ToolStripMenuItem librosToolStripMenuItem;
        private ToolStripMenuItem editorialToolStripMenuItem;
        private ToolStripMenuItem ventaToolStripMenuItem;
        private ToolStripMenuItem préstamoToolStripMenuItem;
        private ToolStripMenuItem copiaLibroToolStripMenuItem;
        private ToolStripMenuItem clienteToolStripMenuItem;
        private ToolStripMenuItem empleadoToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private DataGridView dgv_Listado;
        private DataGridViewButtonColumn Eliminar;
    }
}