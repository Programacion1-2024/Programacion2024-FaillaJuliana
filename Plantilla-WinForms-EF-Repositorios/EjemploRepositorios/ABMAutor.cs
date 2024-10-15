using CLogica.Contracts;
using CEntidades.Entidades;
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
    public partial class ABMAutor : Form
    {
        private IAutorLogic _autorLogic;
        private IPersonaLogic _personaLogic;
        public ABMAutor(IAutorLogic autorLogic, IPersonaLogic personaLogic)
        {
            _autorLogic = autorLogic;
            _personaLogic = personaLogic;

            InitializeComponent();
        }

        private void ABMAutor_Load(object sender, EventArgs e)
        {
            CargarListaAutores();
            CargarComboBoxAutores();

        }
        private void CargarListaAutores()
        {
            try
            {
                var autores = _autorLogic.ObtenerTodosLosAutoresParaListado();
                dgv_Listado.DataSource = autores;
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
                var autores = _autorLogic.ObtenerTodosLosAutoresParaListado();
                cb_BuscarAutor.Items.Clear();
                cb_BuscarAutor.Items.AddRange(autores.Select(a => $"{a.Persona.Nombre} {a.Persona.Apellido}").ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el combo de autores: " + ex.Message);
            }
        }

        private void cb_BuscarAutor_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombreCompletoSeleccionado = cb_BuscarAutor.Text;

            if (string.IsNullOrEmpty(nombreCompletoSeleccionado))
            {
                MessageBox.Show("Por favor, seleccione un autor.");
                return;
            }

            var partes = nombreCompletoSeleccionado.Split(' ');
            if (partes.Length < 2) // Asegúrate de que hay al menos nombre y apellido
            {
                MessageBox.Show("Por favor, seleccione un autor válido.");
                return;
            }

            var nombre = partes[0];
            var apellido = partes[1];

            Autor autorBuscado = _autorLogic.ObtenerAutorPorNombreYApellido(nombre, apellido);

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
                CargarListaAutores(); // Opcional: vuelve a cargar la lista de autores
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException?.Message ?? ex.Message);
            }
        }



    }
}
