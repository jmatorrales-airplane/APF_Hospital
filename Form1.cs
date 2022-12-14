using APF_Hospital.Controller;
using APF_Hospital.Forms;

namespace APF_Hospital
{
    public partial class Hospital : Form
    {
        public Hospital()
        {
            InitializeComponent();
        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            FormPaciente formPaciente = new FormPaciente();
            formPaciente.ShowDialog();
        }
    }
}