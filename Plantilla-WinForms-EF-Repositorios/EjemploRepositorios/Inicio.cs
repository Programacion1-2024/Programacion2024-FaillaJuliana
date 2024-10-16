using CEntidades.Entidades;
using CLogica.Contracts;
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


        public Inicio(IPersonaLogic personaLogic, IAutorLogic autorLogic )
        {
            _personaLogic = personaLogic;
            _autorLogic = autorLogic;
            InitializeComponent();
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
            ABMAutor abmautores = new ABMAutor(_autorLogic, _personaLogic);
            abmautores.Show();
        }

    }
}
