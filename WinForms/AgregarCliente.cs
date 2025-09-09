using Proyecto_Gym.Domain;
using Proyecto_Gym.Business;
using System;
using System.Windows.Forms;

namespace Proyecto_Gym.WinForms
{
    public partial class AgregarCliente : Form
    {
        private ClienteService clienteService;

        public AgregarCliente()
        {
            InitializeComponent();
            clienteService = new ClienteService();
            if (cmbGenero.Items.Count > 0)
                cmbGenero.SelectedIndex = 0;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                    string.IsNullOrWhiteSpace(txtApellido.Text) ||
                    string.IsNullOrWhiteSpace(txtDni.Text))
                {
                    MessageBox.Show("Nombre, Apellido y DNI son obligatorios.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Cliente cliente = new Cliente();
                cliente.nombre = txtNombre.Text;
                cliente.apellido = txtApellido.Text;
                cliente.dni = Convert.ToInt64(txtDni.Text);
                cliente.direccion = txtDireccion.Text;
                cliente.telefono = txtTelefono.Text;
                cliente.email = txtEmail.Text;
                cliente.genero = (Persona.Sexo)cmbGenero.SelectedIndex;
                cliente.pago = chkPago.Checked;

                clienteService.CrearCliente(cliente);

                MessageBox.Show("Cliente guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
