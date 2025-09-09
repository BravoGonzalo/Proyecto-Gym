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
            lblTitulo = new Label();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblApellido = new Label();
            txtApellido = new TextBox();
            lblDni = new Label();
            txtDni = new TextBox();
            lblDireccion = new Label();
            txtDireccion = new TextBox();
            lblTelefono = new Label();
            txtTelefono = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblGenero = new Label();
            cmbGenero = new ComboBox();
            btnRegistrarEntrenador = new Button();
            btnVolverLogin = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Roboto", 20F, FontStyle.Bold);
            lblTitulo.Location = new Point(200, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(400, 40);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Registro de Usuario";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(150, 80);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(300, 80);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(250, 23);
            txtNombre.TabIndex = 2;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(150, 120);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(54, 15);
            lblApellido.TabIndex = 3;
            lblApellido.Text = "Apellido:";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(300, 120);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(250, 23);
            txtApellido.TabIndex = 4;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(150, 160);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(30, 15);
            lblDni.TabIndex = 5;
            lblDni.Text = "DNI:";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(300, 160);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(250, 23);
            txtDni.TabIndex = 6;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(150, 200);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(60, 15);
            lblDireccion.TabIndex = 7;
            lblDireccion.Text = "Dirección:";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(300, 200);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(250, 23);
            txtDireccion.TabIndex = 8;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(150, 240);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(55, 15);
            lblTelefono.TabIndex = 9;
            lblTelefono.Text = "Teléfono:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(300, 240);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(250, 23);
            txtTelefono.TabIndex = 10;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(150, 280);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 11;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(300, 280);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(250, 23);
            txtEmail.TabIndex = 12;
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Location = new Point(150, 320);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(48, 15);
            lblGenero.TabIndex = 13;
            lblGenero.Text = "Género:";
            // 
            // cmbGenero
            // 
            cmbGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGenero.Items.AddRange(new object[] { "Masculino", "Femenino", "Indefinido" });
            cmbGenero.Location = new Point(300, 320);
            cmbGenero.Name = "cmbGenero";
            cmbGenero.Size = new Size(250, 23);
            cmbGenero.TabIndex = 14;
            // 
            // btnRegistrarEntrenador
            // 
            btnRegistrarEntrenador.Location = new Point(335, 382);
            btnRegistrarEntrenador.Name = "btnRegistrarEntrenador";
            btnRegistrarEntrenador.Size = new Size(170, 40);
            btnRegistrarEntrenador.TabIndex = 17;
            btnRegistrarEntrenador.Text = "Registrar Entrenador";
            btnRegistrarEntrenador.Click += btnRegistrarEntrenador_Click;
            // 
            // btnVolverLogin
            // 
            btnVolverLogin.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnVolverLogin.Location = new Point(20, 20);
            btnVolverLogin.Name = "btnVolverLogin";
            btnVolverLogin.Size = new Size(120, 35);
            btnVolverLogin.TabIndex = 18;
            btnVolverLogin.Text = "Volver al Login";
            btnVolverLogin.UseVisualStyleBackColor = true;
            btnVolverLogin.Click += new EventHandler(btnVolverLogin_Click);
            // 
            // RegisterForm
            // 
            ClientSize = new Size(750, 500);
            Controls.Add(lblTitulo);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Controls.Add(lblApellido);
            Controls.Add(txtApellido);
            Controls.Add(lblDni);
            Controls.Add(txtDni);
            Controls.Add(lblDireccion);
            Controls.Add(txtDireccion);
            Controls.Add(lblTelefono);
            Controls.Add(txtTelefono);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblGenero);
            Controls.Add(cmbGenero);
            Controls.Add(btnRegistrarEntrenador);
            Controls.Add(btnVolverLogin);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro";
            ResumeLayout(false);
            PerformLayout();
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
        private Button btnRegistrarEntrenador;
        private System.Windows.Forms.Button btnVolverLogin;
    }
}