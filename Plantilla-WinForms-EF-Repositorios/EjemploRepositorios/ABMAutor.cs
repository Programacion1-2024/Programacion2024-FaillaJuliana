using CLogica.Contracts;
using CEntidades.Entidades;
using System.Data;
using CLogica.Implementations;


namespace CPresentacion
{
    public partial class ABMAutor : Form
    {
        private IAutorLogic _autorLogic;
        private IPersonaLogic _personaLogic;
        private IEditorialLogic _editorialLogic;
        private ILibroLogic _libroLogic;
        private IGeneroLogic _generoLogic;
        public ABMAutor(IAutorLogic autorLogic, IPersonaLogic personaLogic,IEditorialLogic editorialLogic,ILibroLogic libroLogic,IGeneroLogic generoLogic)
        {
            _editorialLogic = editorialLogic;
            _libroLogic = libroLogic;
            _autorLogic = autorLogic;
            _personaLogic = personaLogic;
            _generoLogic = generoLogic;
            InitializeComponent();
        }

        private void ABMAutor_Load(object sender, EventArgs e)
        {
            try
            {
                CargarListaAutores();
                CargarComboBoxAutores();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el formulario: " + ex.Message);
            }

        }


        private void CargarListaAutores()
        {
            try
            {
                var autores = _autorLogic.ConsultaTodosLosAutores();

                var autoresConDetalles = autores.Select(a => new
                {
                    a.IdAutor,
                    a.Persona.Nombre,
                    a.Persona.Apellido,
                    a.Biografia
                }).ToList();

                dgv_Listado.DataSource = autoresConDetalles;

                dgv_Listado.Columns["Eliminar"].DisplayIndex = dgv_Listado.Columns.Count - 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la lista de autores: " + ex.Message);
            }
        }

        private void CargarComboBoxAutores()
        {
            try
            {
                var autores = _autorLogic.ConsultaTodosLosAutores();
                cb_BuscarAutor.Items.Clear();
                cb_BuscarAutor.Items.AddRange(autores.Select(a => $"{a.IdAutor}").ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el combo de autores: " + ex.Message);
            }
        }


        private void cb_BuscarAutor_SelectedIndexChanged(object sender, EventArgs e)
        {
            string idAutor = cb_BuscarAutor.Text;

            if (string.IsNullOrEmpty(idAutor))
            {
                MessageBox.Show("Por favor, seleccione un autor.");
                return;
            }

            Autor autorBuscado = _autorLogic.ObtenerPorId(idAutor);

            if (autorBuscado != null)
            {
                tb_nombreMod.Text = autorBuscado.Persona.Nombre;
                tb_apellidoMod.Text = autorBuscado.Persona.Apellido;
                tb_biografiaMod.Text = autorBuscado.Biografia;
                tb_emailMod.Text = autorBuscado.Persona.Email;
                tb_nacionalidadMod.Text = autorBuscado.Persona.Nacionalidad;
                tb_telefonoMod.Text = autorBuscado.Persona.Telefono;
            }
            else
            {
                MessageBox.Show("Autor no encontrado.");
            }
        }

        private void btn_guardarAlta_Click(object sender, EventArgs e)
        {
            string nombre = tb_nombre.Text.Trim();
            string apellido = tb_apellido.Text.Trim();
            string nacionalidad = tb_nacionalidad.Text.Trim();
            string telefono = tb_telefono.Text.Trim();
            string email = tb_email.Text.Trim();
            string biografia = tb_biografia.Text.Trim();

            // Validación de campos
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.");
                return;
            }

            try
            {
                _autorLogic.AltaAutor(nombre, apellido, nacionalidad, telefono, email, biografia);
                MessageBox.Show("Autor guardado correctamente.");
                CargarListaAutores();
                CargarComboBoxAutores();
                tb_nombre.Clear();
                tb_apellido.Clear();
                tb_telefono.Clear();
                tb_email.Clear();
                tb_biografia.Clear();
                tb_nacionalidad.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException?.Message ?? ex.Message);
            }
        }

        private void btn_guardarMod_Click(object sender, EventArgs e)
        {
            string nombre = tb_nombreMod.Text.Trim();
            string apellido = tb_apellidoMod.Text.Trim();
            string nacionalidad = tb_nacionalidadMod.Text.Trim();
            string telefono = tb_telefonoMod.Text.Trim();
            string email = tb_emailMod.Text.Trim();
            string biografia = tb_biografiaMod.Text.Trim();
            string idAutor = cb_BuscarAutor.Text.Trim();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.");
                return;
            }

            try
            {
                _autorLogic.ModificarAutor(idAutor, nombre, apellido, nacionalidad, telefono, email, biografia);
                MessageBox.Show("Autor modificado correctamente.");
                CargarListaAutores();
                tb_nombreMod.Clear();
                tb_apellidoMod.Clear();
                tb_telefonoMod.Clear();
                tb_emailMod.Clear();
                tb_nacionalidadMod.Clear();
                tb_biografiaMod.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException?.Message ?? ex.Message);
            }
        }
        private void dgv_Listado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string idAutor = dgv_Listado.Rows[e.RowIndex].Cells["IdAutor"].Value.ToString();
                _autorLogic.BajaAutor(idAutor);
                MessageBox.Show("Autor eliminado correctamente.");
                CargarListaAutores();
                CargarComboBoxAutores();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException?.Message ?? ex.Message);
            }

        }

        private void editorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ABMEditorial editorial = new ABMEditorial(_editorialLogic, _autorLogic, _personaLogic, _libroLogic,_generoLogic);
            editorial.Show();
        }
        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio inicio = new Inicio(_personaLogic, _autorLogic, _editorialLogic, _libroLogic,_generoLogic);
            inicio.Show();
        }

        private void librosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ABMLibro abmLibro = new ABMLibro (_libroLogic, _editorialLogic,_autorLogic,_personaLogic,_generoLogic);
            abmLibro.Show();
        }
        private void generoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ABMGenero abmGenero = new ABMGenero(_personaLogic, _autorLogic, _editorialLogic, _libroLogic, _generoLogic);
            abmGenero.Show();
        }
    }
}
