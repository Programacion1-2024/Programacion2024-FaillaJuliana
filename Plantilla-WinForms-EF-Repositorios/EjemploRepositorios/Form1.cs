using CEntidades.Entidades;
using CLogica.Contracts;

namespace EjemploRepositorios
{
    public partial class Form1 : Form
    {
        private IAutorLogic _exampleLogic;

        public Form1(IAutorLogic exampleLogic)
        {
            _exampleLogic = exampleLogic;
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            List<Autor> examples = await _exampleLogic.GetAll();
        }
    }
}
