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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException?.Message ?? ex.Message);
            }
        }

    }
}
