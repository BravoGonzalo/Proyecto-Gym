using Microsoft.Data.SqlClient;
using Proyecto_Gym.Business;
using Proyecto_Gym.WinForms;

namespace Proyecto_Gym
{
    public partial class Form1 : Form
    {
        private readonly ClienteService _clienteService;
        private readonly EntrenadorService _entrenadorService;
        public Form1(ClienteService clienteService, EntrenadorService entrenadorService)
        {
            InitializeComponent();
            _clienteService = clienteService;
            _entrenadorService = entrenadorService;
        }

        public Form1()
        {
            InitializeComponent();
            _clienteService = new ClienteService(); // O algún mock/dummy
            _entrenadorService = new EntrenadorService(); // O algún mock/dummy
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void botonLogin_Click(object sender, EventArgs e)
        {
            string email = textEmail.Text;
            string password = textContraseña.Text;

            var entrenador = _entrenadorService.TraerTodos()
                              .FirstOrDefault(en => en.email == email
                                                 && en.dni.ToString() == password);

            if (entrenador != null)
            {
                var formEntrenador = new EntrenadorForm(entrenador);
                formEntrenador.Show();
                this.Hide();
                return;
            }

            var cliente = _clienteService.TraerTodos()
                          .FirstOrDefault(cl => cl.email == email
                                              && cl.dni.ToString() == password);

            if (cliente != null)
            {
                var formCliente = new ClienteForm(cliente);
                formCliente.Show();
                this.Hide();
                return;
            }

            MessageBox.Show("Email o contraseña incorrectos",
                            "Error de inicio de sesión",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            var formRegister = new RegisterForm();
            formRegister.Show();
            this.Hide();
            return;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
