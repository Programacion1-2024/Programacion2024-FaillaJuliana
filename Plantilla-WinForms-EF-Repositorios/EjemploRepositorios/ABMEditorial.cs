using CLogica.Contracts;
using CEntidades.Entidades;
using System.Data;


namespace CPresentacion
{
    public partial class ABMEditorial : Form
    {
        private IEditorialLogic _editorialLogic;
        private IAutorLogic _autorLogic;
        private IPersonaLogic _personaLogic;
        public ABMEditorial(IEditorialLogic editorialLogic)
        {
            _editorialLogic = editorialLogic;
            InitializeComponent();
        }

        private void ABMEditorial_Load(object sender, EventArgs e)
        {
            CargarListaEditorial();
            CargarComboBoxEditorial();
        }

        public void CargarListaEditorial()
        {
            try
            {
                var editoriales = _editorialLogic.ObtenerEditoriales();

                var editorealesDetalle = editoriales.Select(e => new
                {
                    e.IdEditorial,
                    e.Descripcion,
                    e.Contacto,
                    e.Direccion
                }).ToList();

                dgv_ListadoEditoriales.DataSource = editorealesDetalle;
                dgv_ListadoEditoriales.Columns["Eliminar"].DisplayIndex = dgv_ListadoEditoriales.Columns.Count - 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la lista de autores: " + ex.Message);

            }
        }
        private void dgv_ListadoEditoriales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string idEditorial = dgv_ListadoEditoriales.Rows[e.RowIndex].Cells["IdEditorial"].Value.ToString();
                _editorialLogic.BajaEditorial(idEditorial);
                MessageBox.Show("Editorial eliminado correctamente.");
                CargarListaEditorial();
                CargarComboBoxEditorial();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException?.Message ?? ex.Message);
            }
        }
        private void CargarComboBoxEditorial()
        {
            try
            {
                var editoriales = _editorialLogic.ObtenerEditoriales();
                cb_IdEditorial.Items.Clear();
                cb_IdEditorial.Items.AddRange(editoriales.Select(a => $"{a.IdEditorial}").ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el combo de editorial: " + ex.Message);
            }
        }
        private void btn_GuardatAltaEditorial_Click(object sender, EventArgs e)
        {
            string descripcion = tb_NombreEditorial.Text.Trim();
            string contacto = tb_ContactoEditorial.Text.Trim();
            string direccion = tb_DireccionEditorial.Text.Trim();

            if (string.IsNullOrEmpty(descripcion) || string.IsNullOrEmpty(contacto) || string.IsNullOrEmpty(direccion))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.");
                return;
            }
            try
            {
                _editorialLogic.AltaEditorial(descripcion, contacto, direccion);
                MessageBox.Show("Editorial guardada correctamente.");
                CargarListaEditorial();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException?.Message ?? ex.Message);
            }
        }
        private void cb_IdEditorial_SelectedIndexChanged(object sender, EventArgs e)
        {
            string idEditorial = cb_IdEditorial.Text.Trim();
            if (string.IsNullOrEmpty(idEditorial))
            {
                MessageBox.Show("Por favor, seleccione una editorial.");
                return;
            }

            Editorial editorialBuscada = _editorialLogic.ObtenerPorIdEditorial(idEditorial);

            if (editorialBuscada != null)
            {
                tb_NombreEditorialMod.Text = editorialBuscada.Descripcion;
                tb_ContactoEditorialMod.Text = editorialBuscada.Contacto;
                tb_DireccionEditorialMod.Text = editorialBuscada.Direccion;
            }
            else
            {
                MessageBox.Show("Editorial no encontrado.");
            }
        }
        private void btn_GuardarEditorialMod_Click(object sender, EventArgs e)
        {
            string idEditorial = cb_IdEditorial.Text.Trim();
            string descripcion = tb_NombreEditorialMod.Text.Trim();
            string contacto = tb_ContactoEditorialMod.Text.Trim();
            string direccion = tb_DireccionEditorialMod.Text.Trim();

            if (string.IsNullOrEmpty(descripcion) || string.IsNullOrEmpty(contacto) || string.IsNullOrEmpty(direccion))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.");
                return;
            }
            try

            {
                _editorialLogic.ModificarEditorial(idEditorial, descripcion, contacto, direccion);
                MessageBox.Show("Editorial guardada correctamente.");
                CargarListaEditorial();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException?.Message ?? ex.Message);
            }
        }
        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio inicio = new Inicio(_personaLogic, _autorLogic, _editorialLogic);
            inicio.Show();
        }

        private void autoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ABMAutor abmAutor = new ABMAutor(_autorLogic, _personaLogic);
            abmAutor.Show();
        }

        
    }
}
