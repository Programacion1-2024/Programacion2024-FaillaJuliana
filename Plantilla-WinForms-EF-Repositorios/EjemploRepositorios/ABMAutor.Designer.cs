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
            Alta = new TabControl();
            Listado = new TabPage();
            dgv_Listado = new DataGridView();
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
            tabPage4 = new TabPage();
            dgv_ListadoAutor = new DataGridView();
            Alta.SuspendLayout();
            Listado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Listado).BeginInit();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_ListadoAutor).BeginInit();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Alta
            // 
            Alta.Anchor = AnchorStyles.None;
            Alta.Controls.Add(Listado);
            Alta.Controls.Add(tabPage2);
            Alta.Controls.Add(tabPage3);
            Alta.Controls.Add(tabPage4);
            Alta.Location = new Point(12, 12);
            Alta.Name = "Alta";
            Alta.SelectedIndex = 0;
            Alta.Size = new Size(769, 423);
            Alta.TabIndex = 1;
            // 
            // Listado
            // 
            Listado.BackColor = SystemColors.ActiveCaption;
            Listado.Controls.Add(dgv_Listado);
            Listado.Location = new Point(4, 29);
            Listado.Name = "Listado";
            Listado.Padding = new Padding(3);
            Listado.Size = new Size(761, 390);
            Listado.TabIndex = 0;
            Listado.Text = "Listado";
            // 
            // dgv_Listado
            // 
            dgv_Listado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Listado.Location = new Point(58, 22);
            dgv_Listado.Name = "dgv_Listado";
            dgv_Listado.RowHeadersWidth = 51;
            dgv_Listado.Size = new Size(658, 340);
            dgv_Listado.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = SystemColors.ActiveCaption;
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
            tabPage2.Size = new Size(761, 390);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Alta";
            // 
            // tb_biografia
            // 
            tb_biografia.Location = new Point(179, 226);
            tb_biografia.Multiline = true;
            tb_biografia.Name = "tb_biografia";
            tb_biografia.Size = new Size(434, 97);
            tb_biografia.TabIndex = 19;
            // 
            // tb_telefono
            // 
            tb_telefono.Location = new Point(452, 112);
            tb_telefono.Name = "tb_telefono";
            tb_telefono.Size = new Size(154, 27);
            tb_telefono.TabIndex = 18;
            // 
            // tb_apellido
            // 
            tb_apellido.Location = new Point(452, 53);
            tb_apellido.Name = "tb_apellido";
            tb_apellido.Size = new Size(154, 27);
            tb_apellido.TabIndex = 17;
            // 
            // tb_email
            // 
            tb_email.Location = new Point(179, 163);
            tb_email.Name = "tb_email";
            tb_email.Size = new Size(154, 27);
            tb_email.TabIndex = 16;
            // 
            // tb_nacionalidad
            // 
            tb_nacionalidad.Location = new Point(179, 107);
            tb_nacionalidad.Name = "tb_nacionalidad";
            tb_nacionalidad.Size = new Size(154, 27);
            tb_nacionalidad.TabIndex = 15;
            // 
            // tb_nombre
            // 
            tb_nombre.Location = new Point(179, 56);
            tb_nombre.Name = "tb_nombre";
            tb_nombre.Size = new Size(154, 27);
            tb_nombre.TabIndex = 14;
            // 
            // btn_guardarAlta
            // 
            btn_guardarAlta.Location = new Point(318, 341);
            btn_guardarAlta.Name = "btn_guardarAlta";
            btn_guardarAlta.Size = new Size(117, 28);
            btn_guardarAlta.TabIndex = 13;
            btn_guardarAlta.Text = "Guardar";
            btn_guardarAlta.UseVisualStyleBackColor = true;
            btn_guardarAlta.Click += btn_guardarAlta_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(42, 229);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 12;
            label6.Text = "Biografia";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(348, 115);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 10;
            label5.Text = "Telefono";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 170);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 8;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 110);
            label3.Name = "label3";
            label3.Size = new Size(98, 20);
            label3.TabIndex = 6;
            label3.Text = "Nacionalidad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(349, 56);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 4;
            label2.Text = "Apellido";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 56);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 2;
            label1.Text = "Nombre";
            // 
            // tabPage3
            // 
            tabPage3.BackColor = SystemColors.ActiveCaption;
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
            tabPage3.Size = new Size(761, 390);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Modificacion";
            // 
            // lb_Buscar
            // 
            lb_Buscar.AutoSize = true;
            lb_Buscar.Location = new Point(235, 18);
            lb_Buscar.Name = "lb_Buscar";
            lb_Buscar.Size = new Size(74, 20);
            lb_Buscar.TabIndex = 34;
            lb_Buscar.Text = "Busqueda";
            // 
            // cb_BuscarAutor
            // 
            cb_BuscarAutor.FormattingEnabled = true;
            cb_BuscarAutor.Location = new Point(338, 17);
            cb_BuscarAutor.Name = "cb_BuscarAutor";
            cb_BuscarAutor.Size = new Size(161, 28);
            cb_BuscarAutor.TabIndex = 33;
            cb_BuscarAutor.SelectedIndexChanged += cb_BuscarAutor_SelectedIndexChanged;
            // 
            // tb_biografiaMod
            // 
            tb_biografiaMod.Location = new Point(229, 235);
            tb_biografiaMod.Multiline = true;
            tb_biografiaMod.Name = "tb_biografiaMod";
            tb_biografiaMod.Size = new Size(434, 97);
            tb_biografiaMod.TabIndex = 32;
            // 
            // tb_telefonoMod
            // 
            tb_telefonoMod.Location = new Point(502, 121);
            tb_telefonoMod.Name = "tb_telefonoMod";
            tb_telefonoMod.Size = new Size(154, 27);
            tb_telefonoMod.TabIndex = 31;
            // 
            // tb_apellidoMod
            // 
            tb_apellidoMod.Location = new Point(502, 62);
            tb_apellidoMod.Name = "tb_apellidoMod";
            tb_apellidoMod.Size = new Size(154, 27);
            tb_apellidoMod.TabIndex = 30;
            // 
            // tb_emailMod
            // 
            tb_emailMod.Location = new Point(229, 172);
            tb_emailMod.Name = "tb_emailMod";
            tb_emailMod.Size = new Size(154, 27);
            tb_emailMod.TabIndex = 29;
            // 
            // tb_nacionalidadMod
            // 
            tb_nacionalidadMod.Location = new Point(229, 116);
            tb_nacionalidadMod.Name = "tb_nacionalidadMod";
            tb_nacionalidadMod.Size = new Size(154, 27);
            tb_nacionalidadMod.TabIndex = 28;
            // 
            // tb_nombreMod
            // 
            tb_nombreMod.Location = new Point(229, 65);
            tb_nombreMod.Name = "tb_nombreMod";
            tb_nombreMod.Size = new Size(154, 27);
            tb_nombreMod.TabIndex = 27;
            // 
            // btn_guardarMod
            // 
            btn_guardarMod.Location = new Point(368, 350);
            btn_guardarMod.Name = "btn_guardarMod";
            btn_guardarMod.Size = new Size(117, 28);
            btn_guardarMod.TabIndex = 26;
            btn_guardarMod.Text = "Guardar";
            btn_guardarMod.UseVisualStyleBackColor = true;
            // 
            // lb_biografiaMod
            // 
            lb_biografiaMod.AutoSize = true;
            lb_biografiaMod.Location = new Point(92, 238);
            lb_biografiaMod.Name = "lb_biografiaMod";
            lb_biografiaMod.Size = new Size(70, 20);
            lb_biografiaMod.TabIndex = 25;
            lb_biografiaMod.Text = "Biografia";
            // 
            // lb_telefonoMod
            // 
            lb_telefonoMod.AutoSize = true;
            lb_telefonoMod.Location = new Point(398, 124);
            lb_telefonoMod.Name = "lb_telefonoMod";
            lb_telefonoMod.Size = new Size(67, 20);
            lb_telefonoMod.TabIndex = 24;
            lb_telefonoMod.Text = "Telefono";
            // 
            // lb_emailMod
            // 
            lb_emailMod.AutoSize = true;
            lb_emailMod.Location = new Point(92, 179);
            lb_emailMod.Name = "lb_emailMod";
            lb_emailMod.Size = new Size(46, 20);
            lb_emailMod.TabIndex = 23;
            lb_emailMod.Text = "Email";
            // 
            // lb_nacionalidadMod
            // 
            lb_nacionalidadMod.AutoSize = true;
            lb_nacionalidadMod.Location = new Point(92, 119);
            lb_nacionalidadMod.Name = "lb_nacionalidadMod";
            lb_nacionalidadMod.Size = new Size(98, 20);
            lb_nacionalidadMod.TabIndex = 22;
            lb_nacionalidadMod.Text = "Nacionalidad";
            // 
            // lb_apellidoMod
            // 
            lb_apellidoMod.AutoSize = true;
            lb_apellidoMod.Location = new Point(399, 65);
            lb_apellidoMod.Name = "lb_apellidoMod";
            lb_apellidoMod.Size = new Size(66, 20);
            lb_apellidoMod.TabIndex = 21;
            lb_apellidoMod.Text = "Apellido";
            // 
            // lb_nombreMod
            // 
            lb_nombreMod.AutoSize = true;
            lb_nombreMod.Location = new Point(92, 65);
            lb_nombreMod.Name = "lb_nombreMod";
            lb_nombreMod.Size = new Size(64, 20);
            lb_nombreMod.TabIndex = 20;
            lb_nombreMod.Text = "Nombre";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(dgv_ListadoAutor);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(761, 390);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "'";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgv_ListadoAutor
            // 
            dgv_ListadoAutor.Anchor = AnchorStyles.None;
            dgv_ListadoAutor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ListadoAutor.Location = new Point(18, 26);
            dgv_ListadoAutor.Name = "dgv_ListadoAutor";
            dgv_ListadoAutor.RowHeadersWidth = 51;
            dgv_ListadoAutor.Size = new Size(724, 337);
            dgv_ListadoAutor.TabIndex = 0;
            // 
            // ABMAutor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Alta);
            Name = "ABMAutor";
            Text = "ABMAutor";
            Load += ABMAutor_Load;
            Alta.ResumeLayout(false);
            Listado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_Listado).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_ListadoAutor).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private TabControl Alta;
        private TabPage Listado;
        private TabPage tabPage2;
        private TabPage tabPage4;
        private DataGridView dgv_ListadoAutor;
        private DataGridView dgv_Listado;
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
        private TabPage tabPage3;
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
        private Label lb_Buscar;
        private ComboBox cb_BuscarAutor;
    }
}