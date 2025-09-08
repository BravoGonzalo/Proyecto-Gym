namespace Proyecto_Gym.WinForms
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Label labelTitle;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDni;
        private TextBox txtDireccion;
        private TextBox txtTelefono;
        private TextBox txtEmail;
        private ComboBox cmbGenero;
        private CheckBox chkPago;
        private Button btnRegistrarCliente;
        private Button btnRegistrarEntrenador;
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SuspendLayout();

            // Label Título
            this.labelTitle = new Label();
            this.labelTitle.Text = "Registro de Usuario";
            this.labelTitle.Font = new Font("Roboto", 28F, FontStyle.Bold);
            this.labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.labelTitle.Location = new Point(100, 10);
            this.labelTitle.Size = new Size(600, 50);

            // TextBoxes
            this.txtNombre = new TextBox { Font = new Font("Roboto", 14F), PlaceholderText = "Nombre", Location = new Point(200, 80), Size = new Size(400, 35) };
            this.txtApellido = new TextBox { Font = new Font("Roboto", 14F), PlaceholderText = "Apellido", Location = new Point(200, 130), Size = new Size(400, 35) };
            this.txtDni = new TextBox { Font = new Font("Roboto", 14F), PlaceholderText = "DNI", Location = new Point(200, 180), Size = new Size(400, 35) };
            this.txtDireccion = new TextBox { Font = new Font("Roboto", 14F), PlaceholderText = "Dirección", Location = new Point(200, 230), Size = new Size(400, 35) };
            this.txtTelefono = new TextBox { Font = new Font("Roboto", 14F), PlaceholderText = "Teléfono", Location = new Point(200, 280), Size = new Size(400, 35) };
            this.txtEmail = new TextBox { Font = new Font("Roboto", 14F), PlaceholderText = "Email", Location = new Point(200, 330), Size = new Size(400, 35) };

            // ComboBox Género
            this.cmbGenero = new ComboBox { Font = new Font("Roboto", 14F), Location = new Point(200, 380), Size = new Size(400, 35), DropDownStyle = ComboBoxStyle.DropDownList };
            this.cmbGenero.Items.AddRange(new object[] { "Masculino", "Femenino", "Indefinido" });

            // CheckBox Pago (solo cliente)
            this.chkPago = new CheckBox { Text = "Pago activo", Font = new Font("Roboto", 12F), Location = new Point(200, 430), Size = new Size(150, 30) };

            // Botones
            this.btnRegistrarCliente = new Button
            {
                Text = "Registrarse como Cliente",
                Font = new Font("Roboto", 14F, FontStyle.Bold),
                Location = new Point(150, 480),
                Size = new Size(250, 50),
                Cursor = Cursors.Hand
            };
            this.btnRegistrarCliente.Click += new EventHandler(this.btnRegistrarCliente_Click);

            this.btnRegistrarEntrenador = new Button
            {
                Text = "Registrarse como Entrenador",
                Font = new Font("Roboto", 14F, FontStyle.Bold),
                Location = new Point(450, 480),
                Size = new Size(250, 50),
                Cursor = Cursors.Hand
            };
            this.btnRegistrarEntrenador.Click += new EventHandler(this.btnRegistrarEntrenador_Click);

            // Agregar controles al Form
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.cmbGenero);
            this.Controls.Add(this.chkPago);
            this.Controls.Add(this.btnRegistrarCliente);
            this.Controls.Add(this.btnRegistrarEntrenador);

            // Propiedades del Form
            this.ClientSize = new Size(900, 600);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Registro de Usuario";

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }

    #endregion
}
