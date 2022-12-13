using APF_Hospital.Controller;

namespace APF_Hospital
{
    public partial class Hospital : Form
    {
        public Hospital()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegistrarPaciente registrarPaciente = new RegistrarPaciente();

            string nombre = tbNombre.Text;
            string direccion = tbDireccion.Text;
            string dni = tbDni.Text;
            int dIngreso = Convert.ToInt32(tbDingreso.Text);
            char pronostico = Convert.ToChar(tbPronostico.Text);
            bool esPaciente = true;
            bool estaMuerto = false;

            registrarPaciente.registroPaciente(nombre, direccion, dni, dIngreso, pronostico, esPaciente, estaMuerto);
        }
    }
}