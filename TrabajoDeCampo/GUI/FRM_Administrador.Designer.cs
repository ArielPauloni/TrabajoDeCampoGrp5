namespace GUI
{
    partial class FRM_Administrador
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
            this.lblHolaAdmin = new System.Windows.Forms.Label();
            this.trvPermisos = new System.Windows.Forms.TreeView();
            this.lblPermiso = new System.Windows.Forms.Label();
            this.grpPermisos = new System.Windows.Forms.GroupBox();
            this.btnAgregarPermiso = new System.Windows.Forms.Button();
            this.txtPermiso = new System.Windows.Forms.TextBox();
            this.grpTiposDeUsuario = new System.Windows.Forms.GroupBox();
            this.trvTiposUsuario = new System.Windows.Forms.TreeView();
            this.btnAsignarPermiso = new System.Windows.Forms.Button();
            this.btnQuitarPermiso = new System.Windows.Forms.Button();
            this.btnRelPadreHijo = new System.Windows.Forms.Button();
            this.grpPermisos.SuspendLayout();
            this.grpTiposDeUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHolaAdmin
            // 
            this.lblHolaAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHolaAdmin.Location = new System.Drawing.Point(0, 0);
            this.lblHolaAdmin.Name = "lblHolaAdmin";
            this.lblHolaAdmin.Size = new System.Drawing.Size(790, 13);
            this.lblHolaAdmin.TabIndex = 1;
            this.lblHolaAdmin.Text = "Hola";
            this.lblHolaAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trvPermisos
            // 
            this.trvPermisos.CheckBoxes = true;
            this.trvPermisos.Location = new System.Drawing.Point(9, 19);
            this.trvPermisos.Name = "trvPermisos";
            this.trvPermisos.Size = new System.Drawing.Size(308, 330);
            this.trvPermisos.TabIndex = 2;
            // 
            // lblPermiso
            // 
            this.lblPermiso.AutoSize = true;
            this.lblPermiso.Location = new System.Drawing.Point(9, 365);
            this.lblPermiso.Name = "lblPermiso";
            this.lblPermiso.Size = new System.Drawing.Size(44, 13);
            this.lblPermiso.TabIndex = 3;
            this.lblPermiso.Text = "Permiso";
            // 
            // grpPermisos
            // 
            this.grpPermisos.Controls.Add(this.btnRelPadreHijo);
            this.grpPermisos.Controls.Add(this.btnAgregarPermiso);
            this.grpPermisos.Controls.Add(this.txtPermiso);
            this.grpPermisos.Controls.Add(this.trvPermisos);
            this.grpPermisos.Controls.Add(this.lblPermiso);
            this.grpPermisos.Location = new System.Drawing.Point(3, 16);
            this.grpPermisos.Name = "grpPermisos";
            this.grpPermisos.Size = new System.Drawing.Size(328, 435);
            this.grpPermisos.TabIndex = 4;
            this.grpPermisos.TabStop = false;
            this.grpPermisos.Text = "Permisos";
            // 
            // btnAgregarPermiso
            // 
            this.btnAgregarPermiso.Location = new System.Drawing.Point(12, 399);
            this.btnAgregarPermiso.Name = "btnAgregarPermiso";
            this.btnAgregarPermiso.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarPermiso.TabIndex = 5;
            this.btnAgregarPermiso.Text = "Agregar";
            this.btnAgregarPermiso.UseVisualStyleBackColor = true;
            this.btnAgregarPermiso.Click += new System.EventHandler(this.btnAgregarPermiso_Click);
            // 
            // txtPermiso
            // 
            this.txtPermiso.Location = new System.Drawing.Point(84, 365);
            this.txtPermiso.Name = "txtPermiso";
            this.txtPermiso.Size = new System.Drawing.Size(233, 20);
            this.txtPermiso.TabIndex = 4;
            // 
            // grpTiposDeUsuario
            // 
            this.grpTiposDeUsuario.Controls.Add(this.trvTiposUsuario);
            this.grpTiposDeUsuario.Location = new System.Drawing.Point(448, 17);
            this.grpTiposDeUsuario.Name = "grpTiposDeUsuario";
            this.grpTiposDeUsuario.Size = new System.Drawing.Size(330, 434);
            this.grpTiposDeUsuario.TabIndex = 5;
            this.grpTiposDeUsuario.TabStop = false;
            this.grpTiposDeUsuario.Text = "Tipos de Usuario";
            // 
            // trvTiposUsuario
            // 
            this.trvTiposUsuario.CheckBoxes = true;
            this.trvTiposUsuario.Location = new System.Drawing.Point(16, 18);
            this.trvTiposUsuario.Name = "trvTiposUsuario";
            this.trvTiposUsuario.Size = new System.Drawing.Size(308, 330);
            this.trvTiposUsuario.TabIndex = 6;
            // 
            // btnAsignarPermiso
            // 
            this.btnAsignarPermiso.Location = new System.Drawing.Point(352, 161);
            this.btnAsignarPermiso.Name = "btnAsignarPermiso";
            this.btnAsignarPermiso.Size = new System.Drawing.Size(75, 23);
            this.btnAsignarPermiso.TabIndex = 6;
            this.btnAsignarPermiso.Text = "Agregar ->";
            this.btnAsignarPermiso.UseVisualStyleBackColor = true;
            // 
            // btnQuitarPermiso
            // 
            this.btnQuitarPermiso.Location = new System.Drawing.Point(352, 202);
            this.btnQuitarPermiso.Name = "btnQuitarPermiso";
            this.btnQuitarPermiso.Size = new System.Drawing.Size(75, 23);
            this.btnQuitarPermiso.TabIndex = 7;
            this.btnQuitarPermiso.Text = "<- Quitar";
            this.btnQuitarPermiso.UseVisualStyleBackColor = true;
            // 
            // btnRelPadreHijo
            // 
            this.btnRelPadreHijo.Location = new System.Drawing.Point(242, 400);
            this.btnRelPadreHijo.Name = "btnRelPadreHijo";
            this.btnRelPadreHijo.Size = new System.Drawing.Size(75, 23);
            this.btnRelPadreHijo.TabIndex = 6;
            this.btnRelPadreHijo.Text = "Relacionar";
            this.btnRelPadreHijo.UseVisualStyleBackColor = true;
            this.btnRelPadreHijo.Click += new System.EventHandler(this.btnRelPadreHijo_Click);
            // 
            // FRM_Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 451);
            this.Controls.Add(this.btnQuitarPermiso);
            this.Controls.Add(this.btnAsignarPermiso);
            this.Controls.Add(this.grpTiposDeUsuario);
            this.Controls.Add(this.grpPermisos);
            this.Controls.Add(this.lblHolaAdmin);
            this.MaximizeBox = false;
            this.Name = "FRM_Administrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_Administrador";
            this.Load += new System.EventHandler(this.FRM_Administrador_Load);
            this.grpPermisos.ResumeLayout(false);
            this.grpPermisos.PerformLayout();
            this.grpTiposDeUsuario.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHolaAdmin;
        private System.Windows.Forms.TreeView trvPermisos;
        private System.Windows.Forms.Label lblPermiso;
        private System.Windows.Forms.GroupBox grpPermisos;
        private System.Windows.Forms.TextBox txtPermiso;
        private System.Windows.Forms.Button btnAgregarPermiso;
        private System.Windows.Forms.GroupBox grpTiposDeUsuario;
        private System.Windows.Forms.TreeView trvTiposUsuario;
        private System.Windows.Forms.Button btnAsignarPermiso;
        private System.Windows.Forms.Button btnQuitarPermiso;
        private System.Windows.Forms.Button btnRelPadreHijo;
    }
}