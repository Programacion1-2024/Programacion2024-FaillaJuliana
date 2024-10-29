namespace CPresentacion
{
    partial class ABMEditorial
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
            ListadoEditores = new TabControl();
            Listado = new TabPage();
            dgv_ListadoEditoriales = new DataGridView();
            Eliminar = new DataGridViewButtonColumn();
            AltaEditorial = new TabPage();
            btn_GuardatAltaEditorial = new Button();
            tb_DireccionEditorial = new TextBox();
            label3 = new Label();
            label2 = new Label();
            tb_ContactoEditorial = new TextBox();
            tb_NombreEditorial = new TextBox();
            label1 = new Label();
            tabPage1 = new TabPage();
            cb_IdEditorial = new ComboBox();
            lb_IdEditorialMod = new Label();
            btn_GuardarEditorialMod = new Button();
            tb_DireccionEditorialMod = new TextBox();
            lb_DireccionEditorialMod = new Label();
            lb_ContactoEditorialMod = new Label();
            tb_ContactoEditorialMod = new TextBox();
            tb_NombreEditorialMod = new TextBox();
            lb_NombreEditorialMod = new Label();
            generoToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            ListadoEditores.SuspendLayout();
            Listado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_ListadoEditoriales).BeginInit();
            AltaEditorial.SuspendLayout();
            tabPage1.SuspendLayout();
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
            menuStrip1.TabIndex = 3;
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
            // ListadoEditores
            // 
            ListadoEditores.Anchor = AnchorStyles.None;
            ListadoEditores.Controls.Add(Listado);
            ListadoEditores.Controls.Add(AltaEditorial);
            ListadoEditores.Controls.Add(tabPage1);
            ListadoEditores.Location = new Point(12, 55);
            ListadoEditores.Name = "ListadoEditores";
            ListadoEditores.SelectedIndex = 0;
            ListadoEditores.Size = new Size(891, 547);
            ListadoEditores.TabIndex = 4;
            // 
            // Listado
            // 
            Listado.BackColor = Color.Tan;
            Listado.Controls.Add(dgv_ListadoEditoriales);
            Listado.Location = new Point(4, 29);
            Listado.Name = "Listado";
            Listado.Padding = new Padding(3);
            Listado.Size = new Size(883, 514);
            Listado.TabIndex = 0;
            Listado.Text = "Listado";
            // 
            // dgv_ListadoEditoriales
            // 
            dgv_ListadoEditoriales.Anchor = AnchorStyles.None;
            dgv_ListadoEditoriales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_ListadoEditoriales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ListadoEditoriales.Columns.AddRange(new DataGridViewColumn[] { Eliminar });
            dgv_ListadoEditoriales.Location = new Point(19, 27);
            dgv_ListadoEditoriales.Name = "dgv_ListadoEditoriales";
            dgv_ListadoEditoriales.RowHeadersWidth = 51;
            dgv_ListadoEditoriales.Size = new Size(843, 475);
            dgv_ListadoEditoriales.TabIndex = 0;
            dgv_ListadoEditoriales.CellContentClick += dgv_ListadoEditoriales_CellContentClick;
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
            // AltaEditorial
            // 
            AltaEditorial.BackColor = Color.Tan;
            AltaEditorial.Controls.Add(btn_GuardatAltaEditorial);
            AltaEditorial.Controls.Add(tb_DireccionEditorial);
            AltaEditorial.Controls.Add(label3);
            AltaEditorial.Controls.Add(label2);
            AltaEditorial.Controls.Add(tb_ContactoEditorial);
            AltaEditorial.Controls.Add(tb_NombreEditorial);
            AltaEditorial.Controls.Add(label1);
            AltaEditorial.Location = new Point(4, 29);
            AltaEditorial.Name = "AltaEditorial";
            AltaEditorial.Padding = new Padding(3);
            AltaEditorial.Size = new Size(883, 514);
            AltaEditorial.TabIndex = 1;
            AltaEditorial.Text = "Alta";
            // 
            // btn_GuardatAltaEditorial
            // 
            btn_GuardatAltaEditorial.Location = new Point(418, 334);
            btn_GuardatAltaEditorial.Name = "btn_GuardatAltaEditorial";
            btn_GuardatAltaEditorial.Size = new Size(95, 36);
            btn_GuardatAltaEditorial.TabIndex = 6;
            btn_GuardatAltaEditorial.Text = "Guardar";
            btn_GuardatAltaEditorial.UseVisualStyleBackColor = true;
            btn_GuardatAltaEditorial.Click += btn_GuardatAltaEditorial_Click;
            // 
            // tb_DireccionEditorial
            // 
            tb_DireccionEditorial.Location = new Point(409, 257);
            tb_DireccionEditorial.Name = "tb_DireccionEditorial";
            tb_DireccionEditorial.Size = new Size(126, 27);
            tb_DireccionEditorial.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(325, 264);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 4;
            label3.Text = "Direccion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(326, 202);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 3;
            label2.Text = "Contacto";
            // 
            // tb_ContactoEditorial
            // 
            tb_ContactoEditorial.Location = new Point(409, 199);
            tb_ContactoEditorial.Name = "tb_ContactoEditorial";
            tb_ContactoEditorial.Size = new Size(126, 27);
            tb_ContactoEditorial.TabIndex = 2;
            // 
            // tb_NombreEditorial
            // 
            tb_NombreEditorial.Location = new Point(409, 146);
            tb_NombreEditorial.Name = "tb_NombreEditorial";
            tb_NombreEditorial.Size = new Size(129, 27);
            tb_NombreEditorial.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(326, 149);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Tan;
            tabPage1.Controls.Add(cb_IdEditorial);
            tabPage1.Controls.Add(lb_IdEditorialMod);
            tabPage1.Controls.Add(btn_GuardarEditorialMod);
            tabPage1.Controls.Add(tb_DireccionEditorialMod);
            tabPage1.Controls.Add(lb_DireccionEditorialMod);
            tabPage1.Controls.Add(lb_ContactoEditorialMod);
            tabPage1.Controls.Add(tb_ContactoEditorialMod);
            tabPage1.Controls.Add(tb_NombreEditorialMod);
            tabPage1.Controls.Add(lb_NombreEditorialMod);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(883, 514);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Modificacion";
            // 
            // cb_IdEditorial
            // 
            cb_IdEditorial.FormattingEnabled = true;
            cb_IdEditorial.Location = new Point(422, 96);
            cb_IdEditorial.Name = "cb_IdEditorial";
            cb_IdEditorial.Size = new Size(128, 28);
            cb_IdEditorial.TabIndex = 15;
            cb_IdEditorial.SelectedIndexChanged += cb_IdEditorial_SelectedIndexChanged;
            // 
            // lb_IdEditorialMod
            // 
            lb_IdEditorialMod.AutoSize = true;
            lb_IdEditorialMod.Location = new Point(325, 98);
            lb_IdEditorialMod.Name = "lb_IdEditorialMod";
            lb_IdEditorialMod.Size = new Size(82, 20);
            lb_IdEditorialMod.TabIndex = 14;
            lb_IdEditorialMod.Text = "Id Editorial";
            // 
            // btn_GuardarEditorialMod
            // 
            btn_GuardarEditorialMod.Location = new Point(428, 336);
            btn_GuardarEditorialMod.Name = "btn_GuardarEditorialMod";
            btn_GuardarEditorialMod.Size = new Size(101, 40);
            btn_GuardarEditorialMod.TabIndex = 13;
            btn_GuardarEditorialMod.Text = "Guardar";
            btn_GuardarEditorialMod.UseVisualStyleBackColor = true;
            btn_GuardarEditorialMod.Click += btn_GuardarEditorialMod_Click;
            // 
            // tb_DireccionEditorialMod
            // 
            tb_DireccionEditorialMod.Location = new Point(419, 259);
            tb_DireccionEditorialMod.Name = "tb_DireccionEditorialMod";
            tb_DireccionEditorialMod.Size = new Size(126, 27);
            tb_DireccionEditorialMod.TabIndex = 12;
            // 
            // lb_DireccionEditorialMod
            // 
            lb_DireccionEditorialMod.AutoSize = true;
            lb_DireccionEditorialMod.Location = new Point(335, 266);
            lb_DireccionEditorialMod.Name = "lb_DireccionEditorialMod";
            lb_DireccionEditorialMod.Size = new Size(72, 20);
            lb_DireccionEditorialMod.TabIndex = 11;
            lb_DireccionEditorialMod.Text = "Direccion";
            // 
            // lb_ContactoEditorialMod
            // 
            lb_ContactoEditorialMod.AutoSize = true;
            lb_ContactoEditorialMod.Location = new Point(336, 204);
            lb_ContactoEditorialMod.Name = "lb_ContactoEditorialMod";
            lb_ContactoEditorialMod.Size = new Size(69, 20);
            lb_ContactoEditorialMod.TabIndex = 10;
            lb_ContactoEditorialMod.Text = "Contacto";
            // 
            // tb_ContactoEditorialMod
            // 
            tb_ContactoEditorialMod.Location = new Point(419, 201);
            tb_ContactoEditorialMod.Name = "tb_ContactoEditorialMod";
            tb_ContactoEditorialMod.Size = new Size(126, 27);
            tb_ContactoEditorialMod.TabIndex = 9;
            // 
            // tb_NombreEditorialMod
            // 
            tb_NombreEditorialMod.Location = new Point(419, 148);
            tb_NombreEditorialMod.Name = "tb_NombreEditorialMod";
            tb_NombreEditorialMod.Size = new Size(129, 27);
            tb_NombreEditorialMod.TabIndex = 8;
            // 
            // lb_NombreEditorialMod
            // 
            lb_NombreEditorialMod.AutoSize = true;
            lb_NombreEditorialMod.Location = new Point(336, 151);
            lb_NombreEditorialMod.Name = "lb_NombreEditorialMod";
            lb_NombreEditorialMod.Size = new Size(64, 20);
            lb_NombreEditorialMod.TabIndex = 7;
            lb_NombreEditorialMod.Text = "Nombre";
            // 
            // generoToolStripMenuItem
            // 
            generoToolStripMenuItem.Name = "generoToolStripMenuItem";
            generoToolStripMenuItem.Size = new Size(71, 48);
            generoToolStripMenuItem.Text = "Genero";
            // 
            // ABMEditorial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(915, 614);
            Controls.Add(ListadoEditores);
            Controls.Add(menuStrip1);
            Name = "ABMEditorial";
            Text = "ABMEditorial";
            Load += ABMEditorial_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ListadoEditores.ResumeLayout(false);
            Listado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_ListadoEditoriales).EndInit();
            AltaEditorial.ResumeLayout(false);
            AltaEditorial.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
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
        private TabControl ListadoEditores;
        private TabPage Listado;
        private DataGridView dgv_ListadoEditoriales;
        private TabPage AltaEditorial;
        private Label label1;
        private TextBox tb_ContactoEditorial;
        private TextBox tb_NombreEditorial;
        private Label label2;
        private Label label3;
        private TextBox tb_DireccionEditorial;
        private Button btn_GuardatAltaEditorial;
        private TabPage tabPage1;
        private ComboBox cb_IdEditorial;
        private Label lb_IdEditorialMod;
        private Button btn_GuardarEditorialMod;
        private TextBox tb_DireccionEditorialMod;
        private Label lb_DireccionEditorialMod;
        private Label lb_ContactoEditorialMod;
        private TextBox tb_ContactoEditorialMod;
        private TextBox tb_NombreEditorialMod;
        private Label lb_NombreEditorialMod;
        private DataGridViewButtonColumn Eliminar;
        private ToolStripMenuItem generoToolStripMenuItem;
    }
}