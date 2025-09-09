using Proyecto_Gym.Business;
using Proyecto_Gym.Domain;
using System;
using System.Windows.Forms;

namespace Proyecto_Gym.WinForms
{
    public partial class EntrenadorForm : Form
    {
        private ClienteService clienteService;
        private Entrenador entrenador;

        public EntrenadorForm(Entrenador e)
        {
            InitializeComponent();
            entrenador = e;
            clienteService = new ClienteService();
        }

        private void EntrenadorForm_Load(object sender, EventArgs e)
        {
            lblEntrenador.Text = $"Entrenador: {entrenador.nombre} {entrenador.apellido}";
            dgvClientes.DataSource = clienteService.TraerTodos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var formAgregar = new AgregarCliente();
            formAgregar.ShowDialog();
            dgvClientes.DataSource = clienteService.TraerTodos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            // Aquí deberías abrir un formulario para modificar el cliente seleccionado.
            dgvClientes.DataSource = clienteService.TraerTodos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow == null) return;
            int id = Convert.ToInt32(dgvClientes.CurrentRow.Cells["Id"].Value);
            clienteService.EliminarCliente(id);
            dgvClientes.DataSource = clienteService.TraerTodos();
        }

        private void btnCrearRutina_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow == null) return;
            int id = Convert.ToInt32(dgvClientes.CurrentRow.Cells["Id"].Value);
            Cliente c = clienteService.TraerPorId(id);
            new RutinaForm(c).Show();
        }
    }
}
