namespace Proyecto_Gym.WinForms
{
    partial class RegisterForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitulo = new Label();
            this.lblNombre = new Label();
            this.txtNombre = new TextBox();
            this.lblApellido = new Label();
            this.txtApellido = new TextBox();
            this.lblDni = new Label();
            this.txtDni = new TextBox();
            this.lblDireccion = new Label();
            this.txtDireccion = new TextBox();
            this.lblTelefono = new Label();
            this.txtTelefono = new TextBox();
            this.lblEmail = new Label();
            this.txtEmail = new TextBox();
            this.lblGenero = new Label();
            this.cmbGenero = new ComboBox();
            this.chkPago = new CheckBox();
            this.btnRegistrarCliente = new Button();
            this.btnRegistrarEntrenador = new Button();

            this.SuspendLayout();

            // lblTitulo
            this.lblTitulo.Font = new Font("Roboto", 20F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblTitulo.Location = new Point(200, 20);
            this.lblTitulo.Size = new Size(400, 40);
            this.lblTitulo.Text = "Registro de Usuario";
            this.lblTitulo.TextAlign = ContentAlignment.MiddleCenter;

            // lblNombre
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.Location = new Point(150, 80);
            this.lblNombre.AutoSize = true;

            // txtNombre
            this.txtNombre.Location = new Point(300, 80);
            this.txtNombre.Size = new Size(250, 23);

            // lblApellido
            this.lblApellido.Text = "Apellido:";
            this.lblApellido.Location = new Point(150, 120);
            this.lblApellido.AutoSize = true;

            // txtApellido
            this.txtApellido.Location = new Point(300, 120);
            this.txtApellido.Size = new Size(250, 23);

            // lblDni
            this.lblDni.Text = "DNI:";
            this.lblDni.Location = new Point(150, 160);
            this.lblDni.AutoSize = true;

            // txtDni
            this.txtDni.Location = new Point(300, 160);
            this.txtDni.Size = new Size(250, 23);

            // lblDireccion
            this.lblDireccion.Text = "Dirección:";
            this.lblDireccion.Location = new Point(150, 200);
            this.lblDireccion.AutoSize = true;

            // txtDireccion
            this.txtDireccion.Location = new Point(300, 200);
            this.txtDireccion.Size = new Size(250, 23);

            // lblTelefono
            this.lblTelefono.Text = "Teléfono:";
            this.lblTelefono.Location = new Point(150, 240);
            this.lblTelefono.AutoSize = true;

            // txtTelefono
            this.txtTelefono.Location = new Point(300, 240);
            this.txtTelefono.Size = new Size(250, 23);

            // lblEmail
            this.lblEmail.Text = "Email:";
            this.lblEmail.Location = new Point(150, 280);
            this.lblEmail.AutoSize = true;

            // txtEmail
            this.txtEmail.Location = new Point(300, 280);
            this.txtEmail.Size = new Size(250, 23);

            // lblGenero
            this.lblGenero.Text = "Género:";
            this.lblGenero.Location = new Point(150, 320);
            this.lblGenero.AutoSize = true;

            // cmbGenero
            this.cmbGenero.Location = new Point(300, 320);
            this.cmbGenero.Size = new Size(250, 23);
            this.cmbGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbGenero.Items.AddRange(new object[] { "Masculino", "Femenino", "Indefinido" });

            // chkPago
            this.chkPago.Text = "Pago al día";
            this.chkPago.Location = new Point(300, 360);
            this.chkPago.AutoSize = true;

            // btnRegistrarCliente
            this.btnRegistrarCliente.Text = "Registrar Cliente";
            this.btnRegistrarCliente.Location = new Point(200, 420);
            this.btnRegistrarCliente.Size = new Size(150, 40);
            this.btnRegistrarCliente.Click += btnRegistrarCliente_Click;

            // btnRegistrarEntrenador
            this.btnRegistrarEntrenador.Text = "Registrar Entrenador";
            this.btnRegistrarEntrenador.Location = new Point(400, 420);
            this.btnRegistrarEntrenador.Size = new Size(170, 40);
            this.btnRegistrarEntrenador.Click += btnRegistrarEntrenador_Click;

            // RegisterForm
            this.ClientSize = new Size(750, 500);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.cmbGenero);
            this.Controls.Add(this.chkPago);
            this.Controls.Add(this.btnRegistrarCliente);
            this.Controls.Add(this.btnRegistrarEntrenador);

            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Registro";

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblApellido;
        private TextBox txtApellido;
        private Label lblDni;
        private TextBox txtDni;
        private Label lblDireccion;
        private TextBox txtDireccion;
        private Label lblTelefono;
        private TextBox txtTelefono;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblGenero;
        private ComboBox cmbGenero;
        private CheckBox chkPago;
        private Button btnRegistrarCliente;
        private Button btnRegistrarEntrenador;
    }
}