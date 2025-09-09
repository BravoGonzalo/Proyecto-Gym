using Proyecto_Gym.Business;
using Proyecto_Gym.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Proyecto_Gym.Domain.Persona;

namespace Proyecto_Gym.WinForms
{
    public partial class RegisterForm : Form
    {
        private ClienteService clienteService;
        private EntrenadorService entrenadorService;
        public RegisterForm()
        {
            InitializeComponent();
            clienteService = new ClienteService();
            entrenadorService = new EntrenadorService();
        }
        
        private void btnRegistrarEntrenador_Click(object sender, EventArgs e)
        {
            try
            {
                Entrenador entrenador = new Entrenador
                {
                    nombre = txtNombre.Text,
                    apellido = txtApellido.Text,
                    dni = long.Parse(txtDni.Text),
                    direccion = txtDireccion.Text,
                    telefono = txtTelefono.Text,
                    email = txtEmail.Text,
                    genero = (Sexo)cmbGenero.SelectedIndex,
                };

                entrenadorService.CrearEntrenador(entrenador);

                MessageBox.Show("Entrenador registrado correctamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var login = new Form1(); 
                login.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar entrenador: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVolverLogin_Click(object sender, EventArgs e)
        {
            var loginForm = new Form1(); 
            loginForm.Show();
            this.Close();
        }
    }
}
