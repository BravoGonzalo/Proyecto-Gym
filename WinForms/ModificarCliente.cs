using Proyecto_Gym.Domain;
using Proyecto_Gym.Business;
using System;
using System.Windows.Forms;

namespace Proyecto_Gym.WinForms
{
    public partial class ModificarCliente : Form
    {
        private ClienteService clienteService;
        private Cliente cliente;

        public ModificarCliente(Cliente clienteSeleccionado)
        {
            InitializeComponent();
            clienteService = new ClienteService();
            cliente = clienteSeleccionado;
        }

        private void ModificarCliente_Load(object sender, EventArgs e)
        {
            txtNombre.Text = cliente.nombre;
            txtApellido.Text = cliente.apellido;
            txtDni.Text = cliente.dni.ToString();
            txtDireccion.Text = cliente.direccion;
            txtTelefono.Text = cliente.telefono;
            txtEmail.Text = cliente.email;
            cmbGenero.SelectedIndex = (int)cliente.genero;
            chkPago.Checked = cliente.pago;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                cliente.nombre = txtNombre.Text;
                cliente.apellido = txtApellido.Text;
                cliente.dni = Convert.ToInt64(txtDni.Text);
                cliente.direccion = txtDireccion.Text;
                cliente.telefono = txtTelefono.Text;
                cliente.email = txtEmail.Text;
                cliente.genero = (Persona.Sexo)cmbGenero.SelectedIndex;
                cliente.pago = chkPago.Checked;

                clienteService.ModificarCliente(cliente);

                MessageBox.Show("Cliente modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var id = (long)dgvClientes.Rows[e.RowIndex].Cells["Id"].Value;
                var cliente = clienteService.TraerPorId(id);
                var formModificar = new ModificarCliente(cliente);
                formModificar.ShowDialog();
                dgvClientes.DataSource = clienteService.TraerTodos();
            }
        }
    }
}
