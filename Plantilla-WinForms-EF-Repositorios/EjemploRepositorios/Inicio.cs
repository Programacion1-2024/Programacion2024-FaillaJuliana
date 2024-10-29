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
    public partial class Inicio : Form
    {
        private IPersonaLogic _personaLogic;
        private IAutorLogic _autorLogic;
        private IEditorialLogic _editorialLogic;
        private ILibroLogic _libroLogic;
        private IGeneroLogic _generoLogic;

        public Inicio(IPersonaLogic personaLogic, IAutorLogic autorLogic, IEditorialLogic editorialLogic, ILibroLogic libroLogic, IGeneroLogic generoLogic)
        {
            _personaLogic = personaLogic;
            _autorLogic = autorLogic;
            _editorialLogic = editorialLogic;
            _libroLogic = libroLogic;
            InitializeComponent();
            _generoLogic = generoLogic;
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            string imagePath = Path.Combine(Application.StartupPath, "Resources", "ImagenInicio.jpg");

            // Verifica si el archivo existe
            if (File.Exists(imagePath))
            {
                pictureBoxInicio.Image = Image.FromFile(imagePath);
                pictureBoxInicio.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                MessageBox.Show("La imagen no se encuentra en la ruta especificada.");
            }
        }

        private void autoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ABMAutor abmautores = new ABMAutor(_autorLogic, _personaLogic, _editorialLogic, _libroLogic, _generoLogic);
            abmautores.Show();
        }

        private void editorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ABMEditorial abmEditorial = new ABMEditorial(_editorialLogic, _autorLogic, _personaLogic, _libroLogic,_generoLogic);
            abmEditorial.Show();
        }

        private void librosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ABMLibro abmLibro = new ABMLibro(_libroLogic, _editorialLogic, _autorLogic, _personaLogic,_generoLogic);
            abmLibro.Show();
        }

        private void generoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ABMGenero abmGenero = new ABMGenero(_personaLogic, _autorLogic,_editorialLogic,_libroLogic, _generoLogic);
            abmGenero.Show();
        }
    }
}
