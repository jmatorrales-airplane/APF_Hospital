using APF_Hospital.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APF_Hospital.Forms
{
    public partial class FormPaciente : Form
    {
        public FormPaciente()
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hospital hospital = new Hospital();
            hospital.ShowDialog();
            //this.Close();
        }
    }
}
