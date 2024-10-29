namespace CPresentacion
{
    partial class Inicio
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
            pictureBoxInicio = new PictureBox();
            colorDialog1 = new ColorDialog();
            label1 = new Label();
            generoToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxInicio).BeginInit();
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
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "Menu";
            // 
            // inicioToolStripMenuItem
            // 
            inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            inicioToolStripMenuItem.Size = new Size(59, 48);
            inicioToolStripMenuItem.Text = "Inicio";
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
            // pictureBoxInicio
            // 
            pictureBoxInicio.Anchor = AnchorStyles.None;
            pictureBoxInicio.Location = new Point(69, 158);
            pictureBoxInicio.Name = "pictureBoxInicio";
            pictureBoxInicio.Size = new Size(784, 414);
            pictureBoxInicio.TabIndex = 1;
            pictureBoxInicio.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(172, 90);
            label1.Name = "label1";
            label1.Size = new Size(568, 50);
            label1.TabIndex = 2;
            label1.Text = "Librería Programación";
            // 
            // generoToolStripMenuItem
            // 
            generoToolStripMenuItem.Name = "generoToolStripMenuItem";
            generoToolStripMenuItem.Size = new Size(71, 48);
            generoToolStripMenuItem.Text = "Genero";
            generoToolStripMenuItem.Click += generoToolStripMenuItem_Click;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(917, 614);
            Controls.Add(label1);
            Controls.Add(pictureBoxInicio);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Inicio";
            Text = "Inicio";
            Load += Inicio_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxInicio).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private PictureBox pictureBoxInicio;
        private ColorDialog colorDialog1;
        private Label label1;
        private ToolStripMenuItem generoToolStripMenuItem;
    }
}