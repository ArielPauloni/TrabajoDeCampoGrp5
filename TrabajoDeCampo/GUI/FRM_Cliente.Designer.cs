namespace GUI
{
    partial class FRM_Cliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.lblHolaCliente = new System.Windows.Forms.Label();
            this.btnComprar = new System.Windows.Forms.Button();
            this.btnReservar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHolaCliente
            // 
            this.lblHolaCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHolaCliente.Location = new System.Drawing.Point(0, 0);
            this.lblHolaCliente.Name = "lblHolaCliente";
            this.lblHolaCliente.Size = new System.Drawing.Size(800, 13);
            this.lblHolaCliente.TabIndex = 2;
            this.lblHolaCliente.Text = "Hola";
            this.lblHolaCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(363, 191);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(75, 23);
            this.btnComprar.TabIndex = 3;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            // 
            // btnReservar
            // 
            this.btnReservar.Location = new System.Drawing.Point(363, 243);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(75, 23);
            this.btnReservar.TabIndex = 4;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.UseVisualStyleBackColor = true;
            this.btnReservar.Visible = false;
            // 
            // FRM_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReservar);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.lblHolaCliente);
            this.Name = "FRM_Cliente";
            this.Text = "FRM_Cliente";
            this.Load += new System.EventHandler(this.FRM_Cliente_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHolaCliente;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Button btnReservar;
    }
}