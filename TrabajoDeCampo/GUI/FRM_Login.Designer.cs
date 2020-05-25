namespace GUI
{
    partial class FRM_Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblUsuarioMail = new System.Windows.Forms.Label();
            this.lblClave = new System.Windows.Forms.Label();
            this.txtUsuarioMail = new System.Windows.Forms.TextBox();
            this.txtUsuarioClave = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(135, 127);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblUsuarioMail
            // 
            this.lblUsuarioMail.AutoSize = true;
            this.lblUsuarioMail.Location = new System.Drawing.Point(28, 52);
            this.lblUsuarioMail.Name = "lblUsuarioMail";
            this.lblUsuarioMail.Size = new System.Drawing.Size(26, 13);
            this.lblUsuarioMail.TabIndex = 1;
            this.lblUsuarioMail.Text = "Mail";
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(28, 92);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(61, 13);
            this.lblClave.TabIndex = 2;
            this.lblClave.Text = "Contraseña";
            // 
            // txtUsuarioMail
            // 
            this.txtUsuarioMail.Location = new System.Drawing.Point(98, 45);
            this.txtUsuarioMail.Name = "txtUsuarioMail";
            this.txtUsuarioMail.Size = new System.Drawing.Size(215, 20);
            this.txtUsuarioMail.TabIndex = 3;
            this.txtUsuarioMail.Text = "ariel@mail.com";
            // 
            // txtUsuarioClave
            // 
            this.txtUsuarioClave.Location = new System.Drawing.Point(98, 89);
            this.txtUsuarioClave.Name = "txtUsuarioClave";
            this.txtUsuarioClave.PasswordChar = '*';
            this.txtUsuarioClave.Size = new System.Drawing.Size(215, 20);
            this.txtUsuarioClave.TabIndex = 4;
            this.txtUsuarioClave.Text = "Admin123";
            // 
            // FRM_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 208);
            this.Controls.Add(this.txtUsuarioClave);
            this.Controls.Add(this.txtUsuarioMail);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.lblUsuarioMail);
            this.Controls.Add(this.btnLogin);
            this.MaximizeBox = false;
            this.Name = "FRM_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblUsuarioMail;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox txtUsuarioMail;
        private System.Windows.Forms.TextBox txtUsuarioClave;
    }
}

