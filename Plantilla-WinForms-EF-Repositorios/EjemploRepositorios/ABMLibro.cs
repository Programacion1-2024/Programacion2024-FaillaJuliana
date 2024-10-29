using CEntidades.Entidades;
using CLogica.Contracts;
using CLogica.Implementations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CPresentacion
{
    public partial class ABMLibro : Form
    {
        private ILibroLogic _libroLogic;
        private IAutorLogic _autorLogic;
        private IPersonaLogic _personaLogic;
        private IEditorialLogic _editorialLogic;
        private IGeneroLogic _generoLogic;
        public ABMLibro(ILibroLogic libroLogic, IEditorialLogic editorialLogic, IAutorLogic autorLogic, IPersonaLogic personaLogic, IGeneroLogic generoLogic)
        {
            _editorialLogic = editorialLogic;
            _personaLogic = personaLogic;
            _autorLogic = autorLogic;
            _libroLogic = libroLogic;
            InitializeComponent();
            _generoLogic = generoLogic;
        }

        private void ABMLibro_Load(object sender, EventArgs e)
        {
            CargarComboBoxEditorial();
            CargarCheckBoxAutores();
            CargarListaLibros();
            CargarComboBoxLibros();
        }
        public void CargarListaLibros()
        {
            var libros = _libroLogic.ObtenerLibros();
            var librosConDetalles = libros.Select(a => new
            {
                a.IdLibro,
                a.ISBN,
                a.Titulo,
                a.Descripcion,
                a.FechaPublicacion,
                a.PrecioVenta,
                IdEditorial = a.Editorial.Descripcion,
                a.Generos
            }).ToList();
            dgv_ListadoLibros.DataSource = librosConDetalles;
            dgv_ListadoLibros.Columns["Eliminar"].DisplayIndex = dgv_ListadoLibros.Columns.Count - 1;

        }
        public void CargarComboBoxEditorial()
        {
            var editoriales = _editorialLogic.ObtenerEditoriales();

            cb_editorialAlta.DataSource = editoriales;
            cb_editorialAlta.DisplayMember = "Descripcion";
            cb_editorialMod.DataSource = editoriales;
            cb_editorialMod.DisplayMember = "Descripcion";
        }
        public void CargarCheckBoxAutores()
        {
            var autores = _autorLogic.ConsultaTodosLosAutores()
                    .Select(a => new
                    {
                        IdAutor = a.IdAutor,
                        NombreCompleto = $"{a.Persona.Nombre} {a.Persona.Apellido}"
                    }).ToList();

            listbox_autorAlta.DataSource = autores;
            listbox_autorAlta.DisplayMember = "NombreCompleto";
            listbox_autorAlta.ValueMember = "IdAutor";

            chech_autorMod.DataSource = autores;
            chech_autorMod.DisplayMember = "NombreCompleto";
            chech_autorMod.ValueMember = "IdAutor";

        }
        public List<int> ObtenerAutoresSeleccionados()
        {
            List<int> autoresSeleccionados = new List<int>();
            foreach (var item in listbox_autorAlta.SelectedItems)
            {
                var autor = (dynamic)item;
                autoresSeleccionados.Add(autor.IdAutor);
            }
            foreach (var item in chech_autorMod.SelectedItems)
            {
                var autor = (dynamic)item;
                autoresSeleccionados.Add(autor.IdAutor);
            }
            return autoresSeleccionados;
        }
        public void CargarComboBoxLibros()
        {
            try
            {
                var libros = _libroLogic.ObtenerLibros();
                cb_idLibroMod.Items.Clear();
                cb_idLibroMod.Items.AddRange(libros.Select(a => $"{a.IdLibro}").ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el combo de libro: " + ex.Message);
            }
        }
        private void cb_IdLibro_SelectedIndexChanged(object sender, EventArgs e)
        {
            string idLibro = cb_idLibroMod.Text;

            Libro libroBuscado = _libroLogic.ObtenerPorIdLibro(idLibro);

            if (libroBuscado != null)
            {
                tb_isbnMod.Text = libroBuscado.ISBN;
                tb_tituloMod.Text = libroBuscado.Titulo;
                tb_descripcionMod.Text = libroBuscado.Descripcion;
                tb_fechaPublicacionMod.Text = libroBuscado.FechaPublicacion.ToString("dd/MM/yyyy");
                tb_precioVentaMod.Text = libroBuscado.PrecioVenta.ToString();
                cb_editorialMod.Text = libroBuscado.Editorial?.Descripcion ?? "";
                var autoresIds = libroBuscado.Autores.Select(a => a.IdAutor).ToList();

            }
            else
            {
                MessageBox.Show("Libro no encontrado.");
            }
        }

        private void btn_guardarAlta_Click(object sender, EventArgs e)
        {
            string isbn = tb_isbnAlta.Text.Trim();
            string titulo = tb_tituloAlta.Text.Trim();
            string descripcion = tb_descripcionAlta.Text.Trim();
            string fechaPublicacion = tb_fechaPublicacionAlta.Text.Trim();
            string precioVenta = tb_precioventaAlta.Text.Trim();
            var editorialId = cb_editorialAlta.Text.ToString();
            List<int> autores = ObtenerAutoresSeleccionados();

            var editorial = _editorialLogic.ObtenerEditorialPorNombre(editorialId);

            if (string.IsNullOrEmpty(isbn) || (isbn.Length != 10 && isbn.Length != 13) || (string.IsNullOrEmpty(titulo) || (string.IsNullOrEmpty(descripcion))))
            {
                MessageBox.Show("Ingrese todos lo datos correctamente.");
                return;
            }

            if (!DateTime.TryParse(fechaPublicacion, out DateTime fecha))
            {
                MessageBox.Show("La fecha de publicación no es válida.");
                return;
            }

            if (!float.TryParse(precioVenta, out float precio))
            {
                MessageBox.Show("El precio de venta no es válido.");
                return;
            }

            try
            {
                _libroLogic.AltaLibro(isbn, titulo, descripcion, fecha, precio, editorial, autores);
                MessageBox.Show("Libro guardado correctamente.");
                tb_isbnAlta.Clear();
                tb_tituloAlta.Clear();
                tb_descripcionAlta.Clear();
                tb_fechaPublicacionAlta.Clear();
                tb_precioventaAlta.Clear();
                CargarListaLibros();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException?.Message ?? ex.Message);
            }
        }
        private void btn_guardarMod_Click(object sender, EventArgs e)
        {
            string idLibroMod = cb_idLibroMod.ValueMember;
            string isbn = tb_isbnMod.Text.Trim();
            string titulo = tb_tituloMod.Text.Trim();
            string descripcion = tb_descripcionMod.Text.Trim();
            string fechaPublicacion = tb_fechaPublicacionMod.Text.Trim();
            string precioVenta = tb_precioVentaMod.Text.Trim();
            var editorialId = cb_editorialMod.ValueMember.ToString();
            List<int> autores = ObtenerAutoresSeleccionados();

            var editorial = _editorialLogic.ObtenerEditorialPorNombre(editorialId);

            if (string.IsNullOrEmpty(isbn) || (isbn.Length != 10 && isbn.Length != 13) || (string.IsNullOrEmpty(titulo) || (string.IsNullOrEmpty(descripcion))))
            {
                MessageBox.Show("Ingrese todos lo datos correctamente.");
                return;
            }

            if (!DateTime.TryParse(fechaPublicacion, out DateTime fecha))
            {
                MessageBox.Show("La fecha de publicación no es válida.");
                return;
            }

            if (!float.TryParse(precioVenta, out float precio))
            {
                MessageBox.Show("El precio de venta no es válido.");
                return;
            }

            try
            {
                _libroLogic.ModificarLibro(idLibroMod, isbn, titulo, descripcion, fecha, precio, editorial, autores);
                MessageBox.Show("Libro modificado correctamente.");
                tb_isbnMod.Clear();
                tb_tituloMod.Clear();
                tb_descripcionMod.Clear();
                tb_fechaPublicacionMod.Clear();
                tb_precioVentaMod.Clear();
                CargarListaLibros();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException?.Message ?? ex.Message);
            }
        }
        private void dgv_ListadoLibros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string idLibro = dgv_ListadoLibros.Rows[e.RowIndex].Cells["IdAutor"].Value.ToString();
                _libroLogic.EliminarLibro(idLibro);
                MessageBox.Show("Autor eliminado correctamente.");
                CargarListaLibros();
                CargarComboBoxLibros(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException?.Message ?? ex.Message);
            }
        }
        private void textBox1_Click(object sender, EventArgs e)
        {
            tb_fechaPublicacionAlta.Clear();
            tb_fechaPublicacionAlta.ForeColor = Color.Black; // Cambia el color del texto a negro
        }
        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio inicio = new Inicio(_personaLogic, _autorLogic, _editorialLogic, _libroLogic, _generoLogic);
            inicio.Show();
        }

        private void autoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ABMAutor abmAutor = new ABMAutor(_autorLogic, _personaLogic, _editorialLogic, _libroLogic, _generoLogic);
            abmAutor.Show();

        }

        private void editorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ABMEditorial abmEditorial = new ABMEditorial(_editorialLogic, _autorLogic, _personaLogic, _libroLogic, _generoLogic);
            abmEditorial.Show();
        }
        private void generoToolStripItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ABMGenero abmGenero = new ABMGenero(_personaLogic, _autorLogic, _editorialLogic, _libroLogic, _generoLogic);
            abmGenero.Show();
        }

        
    }
}
    

