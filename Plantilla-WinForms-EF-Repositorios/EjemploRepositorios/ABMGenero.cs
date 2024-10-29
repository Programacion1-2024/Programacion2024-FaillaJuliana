using CEntidades.Entidades;
using CLogica.Contracts;
using CLogica.Implementations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPresentacion
{
    public partial class ABMGenero : Form
    {
        private IPersonaLogic _personaLogic;
        private IAutorLogic _autorLogic;
        private IEditorialLogic _editorialLogic;
        private ILibroLogic _libroLogic;
        private IGeneroLogic _generoLogic;
        public ABMGenero(IPersonaLogic personaLogic, IAutorLogic autorLogic, IEditorialLogic editorialLogic, ILibroLogic libroLogic, IGeneroLogic generoLogic)
        {
            _generoLogic = generoLogic;
            _personaLogic = personaLogic;
            _editorialLogic = editorialLogic;
            _libroLogic = libroLogic;
            _autorLogic = autorLogic;
            InitializeComponent();
        }

        private void ABMGenero_Load(object sender, EventArgs e)
        {
            CargarCheckedBoxLibros();
            CargarListadoGeneros();
            CargarComboBoxIdGenero();
        }
        public void CargarListadoGeneros()
        {
            var generos = _generoLogic.ObtenerGeneros();
            var generoDetalle = generos.Select(a => new
            {
                a.IdGenero,
                a.Nombre,
                a.Descripcion
            }).ToList();

            dgv_listaGeneros.DataSource = generoDetalle;
            dgv_listaGeneros.Columns["Eliminar"].DisplayIndex = dgv_listaGeneros.Columns.Count - 1;
        }
        public void CargarComboBoxIdGenero()
        {
            var generos = _generoLogic.ObtenerGeneros();
            cb_idGeneroMod.Items.Clear();
            cb_idGeneroMod.Items.AddRange(generos.Select(a => $"{a.IdGenero}").ToArray());
        }
        public void CargarCheckedBoxLibros()
        {
            var libros = _libroLogic.ObtenerLibros()
                                    .Select(a => new
                                    {
                                        IdLibro = a.IdLibro,
                                        Titulo = a.Titulo
                                    }).ToList();
            check_librosAlta.DataSource = libros;
            check_librosAlta.DisplayMember = "Titulo";
            check_librosAlta.ValueMember = "IdLibro";

            check_librosMod.DataSource = libros;
            check_librosMod.DisplayMember = "Titulo";
            check_librosMod.ValueMember = "IdLibro";
        }
        public List<int> ObtenerLibrosSeleccionados()
        {
            List<int> libros = new List<int>();
            foreach (var items in check_librosAlta.SelectedItems)
            {
                var libro = (dynamic)items;
                libros.Add(libro.IdLibro);
            }
            return libros;
        }
        private void btn_guardarAlta_Click(object sender, EventArgs e)
        {
            string categoria = tb_categoriaAlta.Text;
            string descripcion = tb_descripcionAlta.Text;
            List<int> libros = ObtenerLibrosSeleccionados();

            if (string.IsNullOrEmpty(categoria) || (string.IsNullOrEmpty(descripcion) || (libros == null || !libros.Any())))
            {
                throw new Exception("Debes completar todos los campos");
            }

            try
            {
                _generoLogic.AltaGenero(descripcion, categoria, libros);
                MessageBox.Show("Genero guardado exitosamente");
                tb_categoriaAlta.Clear();
                tb_descripcionAlta.Clear();
                CargarListadoGeneros();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException?.Message ?? ex.Message);
            }
        }

        private void cb_idGeneroMod_SelectedIndexChanged(object sender, EventArgs e)
        {
            string idGenero = cb_idGeneroMod.Text;

            Genero generoBuscado = _generoLogic.ObtenerPorId(idGenero);

            if (generoBuscado != null)
            {
                tb_categoriaMod.Text = generoBuscado.Nombre;
                tb_descripcionMod.Text = generoBuscado.Descripcion;
                if (generoBuscado.Libros != null && generoBuscado.Libros.Any())
                {
                    var librosIds = generoBuscado.Libros.Select(a => a.IdLibro).ToList();
                }
            }
            else
            {
                MessageBox.Show("Genero no encontrado.");
            }
        }
        private void btn_guardarMod_Click(object sender, EventArgs e)
        {
            string idGenero = cb_idGeneroMod.Text;
            string descripcion = tb_descripcionMod.Text;
            string nombre = tb_categoriaMod.Text;
            List<int> libros = ObtenerLibrosSeleccionados();
           
            if (string.IsNullOrEmpty(nombre) || (string.IsNullOrEmpty(descripcion) || (libros == null || !libros.Any())))
            {
                throw new Exception("Debes completar todos los campos");
            }

            try
            {
                _generoLogic.ModificarGenero(idGenero, descripcion, nombre, libros);
                MessageBox.Show("Genero modificado exitosamente");
                CargarListadoGeneros();
                tb_categoriaMod.Clear();
                tb_descripcionMod.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgv_listaGeneros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string idGenero = dgv_listaGeneros.Rows[e.RowIndex].Cells["IdGenero"].Value.ToString();
                _generoLogic.EliminarGenero(idGenero);
                MessageBox.Show("Genero eliminado correctamente.");
                CargarListadoGeneros();
                CargarComboBoxIdGenero();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException?.Message ?? ex.Message);
            }
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

        private void librosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ABMLibro abmLibro = new ABMLibro(_libroLogic, _editorialLogic, _autorLogic, _personaLogic, _generoLogic);
            abmLibro.Show();
        }

        private void editorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ABMEditorial abmEditorial = new ABMEditorial(_editorialLogic, _autorLogic, _personaLogic, _libroLogic, _generoLogic);
            abmEditorial.Show();
        }

    }
}
