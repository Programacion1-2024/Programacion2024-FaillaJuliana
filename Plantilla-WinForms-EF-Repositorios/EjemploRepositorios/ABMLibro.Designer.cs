namespace CPresentacion
{
    partial class ABMLibro
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
            generoToolStripMenuItem = new ToolStripMenuItem();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dgv_ListadoLibros = new DataGridView();
            Eliminar = new DataGridViewButtonColumn();
            tabPage2 = new TabPage();
            listbox_autorAlta = new CheckedListBox();
            lb_autorAlta = new Label();
            cb_editorialAlta = new ComboBox();
            lb_EditorialAlta = new Label();
            btn_guardarAlta = new Button();
            tb_precioventaAlta = new TextBox();
            tb_fechaPublicacionAlta = new TextBox();
            tb_descripcionAlta = new TextBox();
            tb_tituloAlta = new TextBox();
            tb_isbnAlta = new TextBox();
            lb_precioVentaAlta = new Label();
            lb_fechaPublicacionAlta = new Label();
            lb_descripcionAlta = new Label();
            lb_tituloAlta = new Label();
            lb_isbnAlta = new Label();
            tabPage3 = new TabPage();
            chech_autorMod = new CheckedListBox();
            lb_autorMod = new Label();
            lb_editorialMod = new Label();
            cb_editorialMod = new ComboBox();
            lb_idLibroMod = new Label();
            cb_idLibroMod = new ComboBox();
            btn_guardarMod = new Button();
            tb_precioVentaMod = new TextBox();
            tb_fechaPublicacionMod = new TextBox();
            tb_descripcionMod = new TextBox();
            tb_tituloMod = new TextBox();
            tb_isbnMod = new TextBox();
            lb_precioVentaMod = new Label();
            lb_fechaPublicacionMod = new Label();
            lb_descripcionMod = new Label();
            lb_tituloMod = new Label();
            lb_isbnMod = new Label();
            menuStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_ListadoLibros).BeginInit();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { inicioToolStripMenuItem, autoresToolStripMenuItem, librosToolStripMenuItem, editorialToolStripMenuItem, ventaToolStripMenuItem, préstamoToolStripMenuItem, copiaLibroToolStripMenuItem, clienteToolStripMenuItem, empleadoToolStripMenuItem, generoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(917, 52);
            menuStrip1.TabIndex = 1;
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
            autoresToolStripMenuItem.Click += autoresToolStripMenuItem_Click;
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
            // generoToolStripMenuItem
            // 
            generoToolStripMenuItem.Name = "generoToolStripMenuItem";
            generoToolStripMenuItem.Size = new Size(71, 48);
            generoToolStripMenuItem.Text = "Genero";
            generoToolStripMenuItem.Click += generoToolStripItem_Click;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.None;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(0, 46);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(917, 571);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Tan;
            tabPage1.Controls.Add(dgv_ListadoLibros);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(909, 538);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Listado";
            // 
            // dgv_ListadoLibros
            // 
            dgv_ListadoLibros.Anchor = AnchorStyles.None;
            dgv_ListadoLibros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_ListadoLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ListadoLibros.Columns.AddRange(new DataGridViewColumn[] { Eliminar });
            dgv_ListadoLibros.Location = new Point(8, 6);
            dgv_ListadoLibros.Name = "dgv_ListadoLibros";
            dgv_ListadoLibros.RowHeadersWidth = 51;
            dgv_ListadoLibros.Size = new Size(893, 521);
            dgv_ListadoLibros.TabIndex = 0;
            dgv_ListadoLibros.CellContentClick += dgv_ListadoLibros_CellContentClick;
            // 
            // Eliminar
            // 
            Eliminar.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Eliminar.HeaderText = "";
            Eliminar.MinimumWidth = 6;
            Eliminar.Name = "Eliminar";
            Eliminar.Resizable = DataGridViewTriState.True;
            Eliminar.Text = "Eliminar";
            Eliminar.UseColumnTextForButtonValue = true;
            Eliminar.Width = 24;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Tan;
            tabPage2.Controls.Add(listbox_autorAlta);
            tabPage2.Controls.Add(lb_autorAlta);
            tabPage2.Controls.Add(cb_editorialAlta);
            tabPage2.Controls.Add(lb_EditorialAlta);
            tabPage2.Controls.Add(btn_guardarAlta);
            tabPage2.Controls.Add(tb_precioventaAlta);
            tabPage2.Controls.Add(tb_fechaPublicacionAlta);
            tabPage2.Controls.Add(tb_descripcionAlta);
            tabPage2.Controls.Add(tb_tituloAlta);
            tabPage2.Controls.Add(tb_isbnAlta);
            tabPage2.Controls.Add(lb_precioVentaAlta);
            tabPage2.Controls.Add(lb_fechaPublicacionAlta);
            tabPage2.Controls.Add(lb_descripcionAlta);
            tabPage2.Controls.Add(lb_tituloAlta);
            tabPage2.Controls.Add(lb_isbnAlta);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(909, 538);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Alta";
            // 
            // listbox_autorAlta
            // 
            listbox_autorAlta.FormattingEnabled = true;
            listbox_autorAlta.Location = new Point(562, 252);
            listbox_autorAlta.Name = "listbox_autorAlta";
            listbox_autorAlta.Size = new Size(137, 26);
            listbox_autorAlta.TabIndex = 15;
            // 
            // lb_autorAlta
            // 
            lb_autorAlta.AutoSize = true;
            lb_autorAlta.Location = new Point(422, 253);
            lb_autorAlta.Name = "lb_autorAlta";
            lb_autorAlta.Size = new Size(46, 20);
            lb_autorAlta.TabIndex = 13;
            lb_autorAlta.Text = "Autor";
            // 
            // cb_editorialAlta
            // 
            cb_editorialAlta.FormattingEnabled = true;
            cb_editorialAlta.Location = new Point(265, 250);
            cb_editorialAlta.Name = "cb_editorialAlta";
            cb_editorialAlta.Size = new Size(125, 28);
            cb_editorialAlta.TabIndex = 12;
            // 
            // lb_EditorialAlta
            // 
            lb_EditorialAlta.AutoSize = true;
            lb_EditorialAlta.Location = new Point(158, 250);
            lb_EditorialAlta.Name = "lb_EditorialAlta";
            lb_EditorialAlta.Size = new Size(65, 20);
            lb_EditorialAlta.TabIndex = 11;
            lb_EditorialAlta.Text = "Editorial";
            // 
            // btn_guardarAlta
            // 
            btn_guardarAlta.Location = new Point(422, 429);
            btn_guardarAlta.Name = "btn_guardarAlta";
            btn_guardarAlta.Size = new Size(89, 34);
            btn_guardarAlta.TabIndex = 10;
            btn_guardarAlta.Text = "Guardar";
            btn_guardarAlta.UseVisualStyleBackColor = true;
            btn_guardarAlta.Click += btn_guardarAlta_Click;
            // 
            // tb_precioventaAlta
            // 
            tb_precioventaAlta.Location = new Point(569, 178);
            tb_precioventaAlta.Name = "tb_precioventaAlta";
            tb_precioventaAlta.Size = new Size(130, 27);
            tb_precioventaAlta.TabIndex = 9;
            // 
            // tb_fechaPublicacionAlta
            // 
            tb_fechaPublicacionAlta.ForeColor = SystemColors.ScrollBar;
            tb_fechaPublicacionAlta.Location = new Point(569, 114);
            tb_fechaPublicacionAlta.Name = "tb_fechaPublicacionAlta";
            tb_fechaPublicacionAlta.Size = new Size(130, 27);
            tb_fechaPublicacionAlta.TabIndex = 8;
            tb_fechaPublicacionAlta.Text = "DD/MM/AAAA";
            tb_fechaPublicacionAlta.Click += textBox1_Click;
            // 
            // tb_descripcionAlta
            // 
            tb_descripcionAlta.Location = new Point(265, 310);
            tb_descripcionAlta.Multiline = true;
            tb_descripcionAlta.Name = "tb_descripcionAlta";
            tb_descripcionAlta.Size = new Size(434, 78);
            tb_descripcionAlta.TabIndex = 7;
            // 
            // tb_tituloAlta
            // 
            tb_tituloAlta.Location = new Point(260, 185);
            tb_tituloAlta.Name = "tb_tituloAlta";
            tb_tituloAlta.Size = new Size(130, 27);
            tb_tituloAlta.TabIndex = 6;
            // 
            // tb_isbnAlta
            // 
            tb_isbnAlta.Location = new Point(260, 121);
            tb_isbnAlta.Name = "tb_isbnAlta";
            tb_isbnAlta.Size = new Size(130, 27);
            tb_isbnAlta.TabIndex = 5;
            // 
            // lb_precioVentaAlta
            // 
            lb_precioVentaAlta.AutoSize = true;
            lb_precioVentaAlta.Location = new Point(422, 185);
            lb_precioVentaAlta.Name = "lb_precioVentaAlta";
            lb_precioVentaAlta.Size = new Size(91, 20);
            lb_precioVentaAlta.TabIndex = 4;
            lb_precioVentaAlta.Text = "Precio Venta";
            // 
            // lb_fechaPublicacionAlta
            // 
            lb_fechaPublicacionAlta.AutoSize = true;
            lb_fechaPublicacionAlta.Location = new Point(422, 121);
            lb_fechaPublicacionAlta.Name = "lb_fechaPublicacionAlta";
            lb_fechaPublicacionAlta.Size = new Size(127, 20);
            lb_fechaPublicacionAlta.TabIndex = 3;
            lb_fechaPublicacionAlta.Text = "Fecha Publicacion";
            // 
            // lb_descripcionAlta
            // 
            lb_descripcionAlta.AutoSize = true;
            lb_descripcionAlta.Location = new Point(158, 310);
            lb_descripcionAlta.Name = "lb_descripcionAlta";
            lb_descripcionAlta.Size = new Size(87, 20);
            lb_descripcionAlta.TabIndex = 2;
            lb_descripcionAlta.Text = "Descripcion";
            // 
            // lb_tituloAlta
            // 
            lb_tituloAlta.AutoSize = true;
            lb_tituloAlta.Location = new Point(158, 192);
            lb_tituloAlta.Name = "lb_tituloAlta";
            lb_tituloAlta.Size = new Size(47, 20);
            lb_tituloAlta.TabIndex = 1;
            lb_tituloAlta.Text = "Titulo";
            // 
            // lb_isbnAlta
            // 
            lb_isbnAlta.AutoSize = true;
            lb_isbnAlta.Location = new Point(164, 128);
            lb_isbnAlta.Name = "lb_isbnAlta";
            lb_isbnAlta.Size = new Size(41, 20);
            lb_isbnAlta.TabIndex = 0;
            lb_isbnAlta.Text = "ISBN";
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.Tan;
            tabPage3.Controls.Add(chech_autorMod);
            tabPage3.Controls.Add(lb_autorMod);
            tabPage3.Controls.Add(lb_editorialMod);
            tabPage3.Controls.Add(cb_editorialMod);
            tabPage3.Controls.Add(lb_idLibroMod);
            tabPage3.Controls.Add(cb_idLibroMod);
            tabPage3.Controls.Add(btn_guardarMod);
            tabPage3.Controls.Add(tb_precioVentaMod);
            tabPage3.Controls.Add(tb_fechaPublicacionMod);
            tabPage3.Controls.Add(tb_descripcionMod);
            tabPage3.Controls.Add(tb_tituloMod);
            tabPage3.Controls.Add(tb_isbnMod);
            tabPage3.Controls.Add(lb_precioVentaMod);
            tabPage3.Controls.Add(lb_fechaPublicacionMod);
            tabPage3.Controls.Add(lb_descripcionMod);
            tabPage3.Controls.Add(lb_tituloMod);
            tabPage3.Controls.Add(lb_isbnMod);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(909, 538);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Modificacion";
            // 
            // chech_autorMod
            // 
            chech_autorMod.FormattingEnabled = true;
            chech_autorMod.Location = new Point(597, 257);
            chech_autorMod.Name = "chech_autorMod";
            chech_autorMod.Size = new Size(137, 26);
            chech_autorMod.TabIndex = 27;
            // 
            // lb_autorMod
            // 
            lb_autorMod.AutoSize = true;
            lb_autorMod.Location = new Point(436, 257);
            lb_autorMod.Name = "lb_autorMod";
            lb_autorMod.Size = new Size(46, 20);
            lb_autorMod.TabIndex = 26;
            lb_autorMod.Text = "Autor";
            // 
            // lb_editorialMod
            // 
            lb_editorialMod.AutoSize = true;
            lb_editorialMod.Location = new Point(169, 248);
            lb_editorialMod.Name = "lb_editorialMod";
            lb_editorialMod.Size = new Size(65, 20);
            lb_editorialMod.TabIndex = 25;
            lb_editorialMod.Text = "Editorial";
            // 
            // cb_editorialMod
            // 
            cb_editorialMod.FormattingEnabled = true;
            cb_editorialMod.Location = new Point(275, 249);
            cb_editorialMod.Name = "cb_editorialMod";
            cb_editorialMod.Size = new Size(130, 28);
            cb_editorialMod.TabIndex = 24;
            // 
            // lb_idLibroMod
            // 
            lb_idLibroMod.AutoSize = true;
            lb_idLibroMod.Location = new Point(278, 106);
            lb_idLibroMod.Name = "lb_idLibroMod";
            lb_idLibroMod.Size = new Size(60, 20);
            lb_idLibroMod.TabIndex = 23;
            lb_idLibroMod.Text = "Id Libro";
            // 
            // cb_idLibroMod
            // 
            cb_idLibroMod.FormattingEnabled = true;
            cb_idLibroMod.Location = new Point(406, 98);
            cb_idLibroMod.Name = "cb_idLibroMod";
            cb_idLibroMod.Size = new Size(135, 28);
            cb_idLibroMod.TabIndex = 22;
            cb_idLibroMod.SelectedIndexChanged += cb_IdLibro_SelectedIndexChanged;
            // 
            // btn_guardarMod
            // 
            btn_guardarMod.Location = new Point(436, 404);
            btn_guardarMod.Name = "btn_guardarMod";
            btn_guardarMod.Size = new Size(89, 34);
            btn_guardarMod.TabIndex = 21;
            btn_guardarMod.Text = "Guardar";
            btn_guardarMod.UseVisualStyleBackColor = true;
            btn_guardarMod.Click += btn_guardarMod_Click;
            // 
            // tb_precioVentaMod
            // 
            tb_precioVentaMod.Location = new Point(597, 190);
            tb_precioVentaMod.Name = "tb_precioVentaMod";
            tb_precioVentaMod.Size = new Size(130, 27);
            tb_precioVentaMod.TabIndex = 20;
            // 
            // tb_fechaPublicacionMod
            // 
            tb_fechaPublicacionMod.Location = new Point(597, 142);
            tb_fechaPublicacionMod.Name = "tb_fechaPublicacionMod";
            tb_fechaPublicacionMod.Size = new Size(130, 27);
            tb_fechaPublicacionMod.TabIndex = 19;
            // 
            // tb_descripcionMod
            // 
            tb_descripcionMod.Location = new Point(275, 315);
            tb_descripcionMod.Multiline = true;
            tb_descripcionMod.Name = "tb_descripcionMod";
            tb_descripcionMod.Size = new Size(452, 83);
            tb_descripcionMod.TabIndex = 18;
            // 
            // tb_tituloMod
            // 
            tb_tituloMod.Location = new Point(275, 190);
            tb_tituloMod.Name = "tb_tituloMod";
            tb_tituloMod.Size = new Size(130, 27);
            tb_tituloMod.TabIndex = 17;
            // 
            // tb_isbnMod
            // 
            tb_isbnMod.Location = new Point(275, 143);
            tb_isbnMod.Name = "tb_isbnMod";
            tb_isbnMod.Size = new Size(130, 27);
            tb_isbnMod.TabIndex = 16;
            // 
            // lb_precioVentaMod
            // 
            lb_precioVentaMod.AutoSize = true;
            lb_precioVentaMod.Location = new Point(436, 197);
            lb_precioVentaMod.Name = "lb_precioVentaMod";
            lb_precioVentaMod.Size = new Size(91, 20);
            lb_precioVentaMod.TabIndex = 15;
            lb_precioVentaMod.Text = "Precio Venta";
            // 
            // lb_fechaPublicacionMod
            // 
            lb_fechaPublicacionMod.AutoSize = true;
            lb_fechaPublicacionMod.Location = new Point(436, 143);
            lb_fechaPublicacionMod.Name = "lb_fechaPublicacionMod";
            lb_fechaPublicacionMod.Size = new Size(127, 20);
            lb_fechaPublicacionMod.TabIndex = 14;
            lb_fechaPublicacionMod.Text = "Fecha Publicacion";
            // 
            // lb_descripcionMod
            // 
            lb_descripcionMod.AutoSize = true;
            lb_descripcionMod.Location = new Point(172, 318);
            lb_descripcionMod.Name = "lb_descripcionMod";
            lb_descripcionMod.Size = new Size(87, 20);
            lb_descripcionMod.TabIndex = 13;
            lb_descripcionMod.Text = "Descripcion";
            // 
            // lb_tituloMod
            // 
            lb_tituloMod.AutoSize = true;
            lb_tituloMod.Location = new Point(172, 197);
            lb_tituloMod.Name = "lb_tituloMod";
            lb_tituloMod.Size = new Size(47, 20);
            lb_tituloMod.TabIndex = 12;
            lb_tituloMod.Text = "Titulo";
            // 
            // lb_isbnMod
            // 
            lb_isbnMod.AutoSize = true;
            lb_isbnMod.Location = new Point(172, 145);
            lb_isbnMod.Name = "lb_isbnMod";
            lb_isbnMod.Size = new Size(41, 20);
            lb_isbnMod.TabIndex = 11;
            lb_isbnMod.Text = "ISBN";
            // 
            // ABMLibro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(917, 614);
            Controls.Add(tabControl1);
            Controls.Add(menuStrip1);
            Name = "ABMLibro";
            Text = "ABMLibro";
            Load += ABMLibro_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_ListadoLibros).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

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
        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView dgv_ListadoLibros;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TextBox tb_precioventaAlta;
        private TextBox tb_fechaPublicacionAlta;
        private TextBox tb_descripcionAlta;
        private TextBox tb_tituloAlta;
        private TextBox tb_isbnAlta;
        private Label lb_precioVentaAlta;
        private Label lb_fechaPublicacionAlta;
        private Label lb_descripcionAlta;
        private Label lb_tituloAlta;
        private Label lb_isbnAlta;
        private Button btn_guardarAlta;
        private Label lb_idLibroMod;
        private ComboBox cb_idLibroMod;
        private Button btn_guardarMod;
        private TextBox tb_precioVentaMod;
        private TextBox tb_fechaPublicacionMod;
        private TextBox tb_descripcionMod;
        private TextBox tb_tituloMod;
        private TextBox tb_isbnMod;
        private Label lb_precioVentaMod;
        private Label lb_fechaPublicacionMod;
        private Label lb_descripcionMod;
        private Label lb_tituloMod;
        private Label lb_isbnMod;
        private ComboBox cb_editorialAlta;
        private Label lb_EditorialAlta;
        private Label lb_editorialMod;
        private ComboBox cb_editorialMod;
        private Label lb_autorAlta;
        private CheckedListBox listbox_autorAlta;
        private CheckedListBox chech_autorMod;
        private Label lb_autorMod;
        private DataGridViewButtonColumn Eliminar;
        private ToolStripMenuItem generoToolStripMenuItem;
    }
}