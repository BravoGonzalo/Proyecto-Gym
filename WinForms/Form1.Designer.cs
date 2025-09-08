namespace Proyecto_Gym
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textEmail = new TextBox();
            label2 = new Label();
            textContraseña = new TextBox();
            botonLogin = new Button();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Roboto", 36F, FontStyle.Bold);
            label1.Location = new Point(200, 20);
            label1.Name = "label1";
            label1.Size = new Size(500, 70);
            label1.TabIndex = 0;
            label1.Text = "Inicio de Sesión";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textEmail
            // 
            textEmail.Font = new Font("Roboto", 14F);
            textEmail.Location = new Point(200, 150);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(500, 30);
            textEmail.TabIndex = 2;
            // 
            // label2
            // 
            label2.Font = new Font("Roboto", 16F);
            label2.Location = new Point(200, 200);
            label2.Name = "label2";
            label2.Size = new Size(500, 30);
            label2.TabIndex = 1;
            label2.Text = "DNI:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            label2.Click += label2_Click;
            // 
            // textContraseña
            // 
            textContraseña.Font = new Font("Roboto", 14F);
            textContraseña.Location = new Point(200, 230);
            textContraseña.Name = "textContraseña";
            textContraseña.Size = new Size(500, 30);
            textContraseña.TabIndex = 3;
            textContraseña.UseSystemPasswordChar = true;
            // 
            // botonLogin
            // 
            botonLogin.Cursor = Cursors.Hand;
            botonLogin.Font = new Font("Roboto", 16F, FontStyle.Bold);
            botonLogin.Location = new Point(350, 300);
            botonLogin.Name = "botonLogin";
            botonLogin.Size = new Size(200, 50);
            botonLogin.TabIndex = 4;
            botonLogin.Text = "Login";
            botonLogin.UseVisualStyleBackColor = true;
            botonLogin.Click += botonLogin_Click;
            // 
            // label4
            // 
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Roboto", 14F, FontStyle.Underline);
            label4.ForeColor = Color.Blue;
            label4.Location = new Point(350, 370);
            label4.Name = "label4";
            label4.Size = new Size(200, 30);
            label4.TabIndex = 5;
            label4.Text = "Registrarse";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Roboto", 16F);
            label3.Location = new Point(200, 117);
            label3.Name = "label3";
            label3.Size = new Size(500, 30);
            label3.TabIndex = 6;
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Font = new Font("Roboto", 16F);
            label5.Location = new Point(200, 108);
            label5.Name = "label5";
            label5.Size = new Size(500, 30);
            label5.TabIndex = 7;
            label5.Text = "EMAIL:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            ClientSize = new Size(900, 450);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(textEmail);
            Controls.Add(label2);
            Controls.Add(textContraseña);
            Controls.Add(botonLogin);
            Controls.Add(label4);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio de Sesión";
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Label label1;
        private TextBox textEmail;
        private Label label2;
        private Label label3;
        private TextBox textContraseña;
        private Label label4;
        private Button botonLogin;
        private Label label5;
    }
}
