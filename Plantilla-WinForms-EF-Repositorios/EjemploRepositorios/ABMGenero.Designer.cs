namespace CPresentacion
{
    partial class ABMGenero
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
            toolStripMenuItem1 = new ToolStripMenuItem();
            generoToolStripMenuItem = new ToolStripMenuItem();
            tabControl1 = new TabControl();
            Listado = new TabPage();
            dgv_listaGeneros = new DataGridView();
            Eliminar = new DataGridViewButtonColumn();
            tabPage2 = new TabPage();
            tb_descripcionAlta = new TextBox();
            tb_categoriaAlta = new TextBox();
            check_librosAlta = new CheckedListBox();
            btn_guardarAlta = new Button();
            lb_librosAlta = new Label();
            lb_descripcionAlta = new Label();
            lb_categoriaAlta = new Label();
            tabPage3 = new TabPage();
            lb_idGeneroMod = new Label();
            cb_idGeneroMod = new ComboBox();
            tb_descripcionMod = new TextBox();
            tb_categoriaMod = new TextBox();
            check_librosMod = new CheckedListBox();
            btn_guardarMod = new Button();
            lb_librosMod = new Label();
            lb_descripcionMod = new Label();
            lb_categoriaMod = new Label();
            menuStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            Listado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_listaGeneros).BeginInit();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { inicioToolStripMenuItem, autoresToolStripMenuItem, librosToolStripMenuItem, editorialToolStripMenuItem, ventaToolStripMenuItem, préstamoToolStripMenuItem, copiaLibroToolStripMenuItem, clienteToolStripMenuItem, empleadoToolStripMenuItem, toolStripMenuItem1, generoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(915, 52);
            menuStrip1.TabIndex = 4;
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
            librosToolStripMenuItem.Click += librosToolStripMenuItem_Click;
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
            // generoToolStripMenuItem
            // 
            generoToolStripMenuItem.Name = "generoToolStripMenuItem";
            generoToolStripMenuItem.Size = new Size(71, 48);
            generoToolStripMenuItem.Text = "Genero";
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.None;
            tabControl1.Controls.Add(Listado);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(8, 44);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(898, 561);
            tabControl1.TabIndex = 5;
            // 
            // Listado
            // 
            Listado.BackColor = Color.Tan;
            Listado.Controls.Add(dgv_listaGeneros);
            Listado.Location = new Point(4, 29);
            Listado.Name = "Listado";
            Listado.Padding = new Padding(3);
            Listado.Size = new Size(890, 528);
            Listado.TabIndex = 0;
            Listado.Text = "Listado";
            // 
            // dgv_listaGeneros
            // 
            dgv_listaGeneros.Anchor = AnchorStyles.None;
            dgv_listaGeneros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_listaGeneros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_listaGeneros.Columns.AddRange(new DataGridViewColumn[] { Eliminar });
            dgv_listaGeneros.Location = new Point(20, 18);
            dgv_listaGeneros.Name = "dgv_listaGeneros";
            dgv_listaGeneros.RowHeadersWidth = 51;
            dgv_listaGeneros.Size = new Size(855, 502);
            dgv_listaGeneros.TabIndex = 0;
            dgv_listaGeneros.CellContentClick += dgv_listaGeneros_CellContentClick;
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
            tabPage2.Controls.Add(tb_descripcionAlta);
            tabPage2.Controls.Add(tb_categoriaAlta);
            tabPage2.Controls.Add(check_librosAlta);
            tabPage2.Controls.Add(btn_guardarAlta);
            tabPage2.Controls.Add(lb_librosAlta);
            tabPage2.Controls.Add(lb_descripcionAlta);
            tabPage2.Controls.Add(lb_categoriaAlta);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(890, 528);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Alta";
            // 
            // tb_descripcionAlta
            // 
            tb_descripcionAlta.Location = new Point(407, 195);
            tb_descripcionAlta.Multiline = true;
            tb_descripcionAlta.Name = "tb_descripcionAlta";
            tb_descripcionAlta.Size = new Size(373, 124);
            tb_descripcionAlta.TabIndex = 6;
            // 
            // tb_categoriaAlta
            // 
            tb_categoriaAlta.Location = new Point(407, 129);
            tb_categoriaAlta.Name = "tb_categoriaAlta";
            tb_categoriaAlta.Size = new Size(138, 27);
            tb_categoriaAlta.TabIndex = 5;
            // 
            // check_librosAlta
            // 
            check_librosAlta.FormattingEnabled = true;
            check_librosAlta.Location = new Point(407, 344);
            check_librosAlta.Name = "check_librosAlta";
            check_librosAlta.Size = new Size(138, 26);
            check_librosAlta.TabIndex = 4;
            // 
            // btn_guardarAlta
            // 
            btn_guardarAlta.Location = new Point(416, 408);
            btn_guardarAlta.Name = "btn_guardarAlta";
            btn_guardarAlta.Size = new Size(95, 36);
            btn_guardarAlta.TabIndex = 3;
            btn_guardarAlta.Text = "Guardar";
            btn_guardarAlta.UseVisualStyleBackColor = true;
            btn_guardarAlta.Click += btn_guardarAlta_Click;
            // 
            // lb_librosAlta
            // 
            lb_librosAlta.AutoSize = true;
            lb_librosAlta.Location = new Point(263, 344);
            lb_librosAlta.Name = "lb_librosAlta";
            lb_librosAlta.Size = new Size(49, 20);
            lb_librosAlta.TabIndex = 2;
            lb_librosAlta.Text = "Libros";
            // 
            // lb_descripcionAlta
            // 
            lb_descripcionAlta.AutoSize = true;
            lb_descripcionAlta.Location = new Point(263, 198);
            lb_descripcionAlta.Name = "lb_descripcionAlta";
            lb_descripcionAlta.Size = new Size(87, 20);
            lb_descripcionAlta.TabIndex = 1;
            lb_descripcionAlta.Text = "Descripcion";
            // 
            // lb_categoriaAlta
            // 
            lb_categoriaAlta.AutoSize = true;
            lb_categoriaAlta.Location = new Point(263, 136);
            lb_categoriaAlta.Name = "lb_categoriaAlta";
            lb_categoriaAlta.Size = new Size(79, 20);
            lb_categoriaAlta.TabIndex = 0;
            lb_categoriaAlta.Text = "Catergoria";
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.Tan;
            tabPage3.Controls.Add(lb_idGeneroMod);
            tabPage3.Controls.Add(cb_idGeneroMod);
            tabPage3.Controls.Add(tb_descripcionMod);
            tabPage3.Controls.Add(tb_categoriaMod);
            tabPage3.Controls.Add(check_librosMod);
            tabPage3.Controls.Add(btn_guardarMod);
            tabPage3.Controls.Add(lb_librosMod);
            tabPage3.Controls.Add(lb_descripcionMod);
            tabPage3.Controls.Add(lb_categoriaMod);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(890, 528);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Modificacion";
            // 
            // lb_idGeneroMod
            // 
            lb_idGeneroMod.AutoSize = true;
            lb_idGeneroMod.Location = new Point(255, 81);
            lb_idGeneroMod.Name = "lb_idGeneroMod";
            lb_idGeneroMod.Size = new Size(74, 20);
            lb_idGeneroMod.TabIndex = 15;
            lb_idGeneroMod.Text = "Id Genero";
            // 
            // cb_idGeneroMod
            // 
            cb_idGeneroMod.FormattingEnabled = true;
            cb_idGeneroMod.Location = new Point(399, 78);
            cb_idGeneroMod.Name = "cb_idGeneroMod";
            cb_idGeneroMod.Size = new Size(138, 28);
            cb_idGeneroMod.TabIndex = 14;
            cb_idGeneroMod.SelectedIndexChanged += cb_idGeneroMod_SelectedIndexChanged;
            // 
            // tb_descripcionMod
            // 
            tb_descripcionMod.Location = new Point(390, 208);
            tb_descripcionMod.Multiline = true;
            tb_descripcionMod.Name = "tb_descripcionMod";
            tb_descripcionMod.Size = new Size(389, 123);
            tb_descripcionMod.TabIndex = 13;
            // 
            // tb_categoriaMod
            // 
            tb_categoriaMod.Location = new Point(399, 142);
            tb_categoriaMod.Name = "tb_categoriaMod";
            tb_categoriaMod.Size = new Size(138, 27);
            tb_categoriaMod.TabIndex = 12;
            // 
            // check_librosMod
            // 
            check_librosMod.FormattingEnabled = true;
            check_librosMod.Location = new Point(399, 369);
            check_librosMod.Name = "check_librosMod";
            check_librosMod.Size = new Size(138, 26);
            check_librosMod.TabIndex = 11;
            // 
            // btn_guardarMod
            // 
            btn_guardarMod.Location = new Point(410, 430);
            btn_guardarMod.Name = "btn_guardarMod";
            btn_guardarMod.Size = new Size(95, 36);
            btn_guardarMod.TabIndex = 10;
            btn_guardarMod.Text = "Guardar";
            btn_guardarMod.UseVisualStyleBackColor = true;
            btn_guardarMod.Click += btn_guardarMod_Click;
            // 
            // lb_librosMod
            // 
            lb_librosMod.AutoSize = true;
            lb_librosMod.Location = new Point(255, 369);
            lb_librosMod.Name = "lb_librosMod";
            lb_librosMod.Size = new Size(49, 20);
            lb_librosMod.TabIndex = 9;
            lb_librosMod.Text = "Libros";
            // 
            // lb_descripcionMod
            // 
            lb_descripcionMod.AutoSize = true;
            lb_descripcionMod.Location = new Point(255, 211);
            lb_descripcionMod.Name = "lb_descripcionMod";
            lb_descripcionMod.Size = new Size(87, 20);
            lb_descripcionMod.TabIndex = 8;
            lb_descripcionMod.Text = "Descripcion";
            // 
            // lb_categoriaMod
            // 
            lb_categoriaMod.AutoSize = true;
            lb_categoriaMod.Location = new Point(255, 149);
            lb_categoriaMod.Name = "lb_categoriaMod";
            lb_categoriaMod.Size = new Size(79, 20);
            lb_categoriaMod.TabIndex = 7;
            lb_categoriaMod.Text = "Catergoria";
            // 
            // ABMGenero
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 614);
            Controls.Add(tabControl1);
            Controls.Add(menuStrip1);
            Name = "ABMGenero";
            Text = ";";
            Load += ABMGenero_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            Listado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_listaGeneros).EndInit();
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
        private ToolStripMenuItem toolStripMenuItem1;
        private TabControl tabControl1;
        private TabPage Listado;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private ToolStripMenuItem generoToolStripMenuItem;
        private Label lb_librosAlta;
        private Label lb_descripcionAlta;
        private Label lb_categoriaAlta;
        private Button btn_guardarAlta;
        private DataGridView dgv_listaGeneros;
        private TextBox tb_descripcionAlta;
        private TextBox tb_categoriaAlta;
        private CheckedListBox check_librosAlta;
        private Label lb_idGeneroMod;
        private ComboBox cb_idGeneroMod;
        private TextBox tb_descripcionMod;
        private TextBox tb_categoriaMod;
        private CheckedListBox check_librosMod;
        private Button btn_guardarMod;
        private Label lb_librosMod;
        private Label lb_descripcionMod;
        private Label lb_categoriaMod;
        private DataGridViewButtonColumn Eliminar;
    }
}