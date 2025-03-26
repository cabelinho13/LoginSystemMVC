using System;
using System.Windows.Forms;

namespace LoginSystemMVC
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtLogin;
        private TextBox txtSenha;
        private Button btnEntrar;
        private Label lblLogin;
        private Label lblSenha;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtLogin = new TextBox();
            this.txtSenha = new TextBox();
            this.btnEntrar = new Button();
            this.lblLogin = new Label();
            this.lblSenha = new Label();
            this.SuspendLayout();

            // Login
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(30, 30);
            this.lblLogin.Text = "Login";
            this.txtLogin.Location = new System.Drawing.Point(30, 50);
            this.txtLogin.Size = new System.Drawing.Size(200, 23);

            // Senha
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(30, 90);
            this.lblSenha.Text = "Senha";
            this.txtSenha.Location = new System.Drawing.Point(30, 110);
            this.txtSenha.Size = new System.Drawing.Size(200, 23);
            this.txtSenha.UseSystemPasswordChar = true;

            // Botão
            this.btnEntrar.Location = new System.Drawing.Point(30, 150);
            this.btnEntrar.Size = new System.Drawing.Size(200, 30);
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.Click += new EventHandler(this.btnEntrar_Click);

            // Form
            this.ClientSize = new System.Drawing.Size(280, 220);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.btnEntrar);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
