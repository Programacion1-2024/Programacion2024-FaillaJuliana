using CNegocio.Contracts;

namespace Carniceria
{
    public partial class VistaUsuario : Form
    {
        private ICorteLogic _corteLogic { get; set; }
        public VistaUsuario(ICorteLogic corte)
        {
            _corteLogic = corte;
            InitializeComponent();
        }

        private void VistaUsuario_Load(object sender, EventArgs e)
        {
            var cortes = _corteLogic.ObtenerCortes();
            dataGridView1.DataSource = cortes;
        }
    }
}
