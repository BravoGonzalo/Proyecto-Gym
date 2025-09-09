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
        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = new Cliente
                {
                    nombre = txtNombre.Text,
                    apellido = txtApellido.Text,
                    dni = long.Parse(txtDni.Text),
                    direccion = txtDireccion.Text,
                    telefono = txtTelefono.Text,
                    email = txtEmail.Text,
                    genero = (Sexo)cmbGenero.SelectedIndex,
                    pago = chkPago.Checked,
                    rutinaxdia = new List<Rutina>()
                };

                clienteService.CrearCliente(cliente);

                MessageBox.Show("Cliente registrado correctamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                    clientes = new List<Cliente>()
                };

                entrenadorService.CrearEntrenador(entrenador);

                MessageBox.Show("Entrenador registrado correctamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar entrenador: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
