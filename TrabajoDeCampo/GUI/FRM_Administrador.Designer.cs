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
            this.components = new System.ComponentModel.Container();
            this.lblHolaAdmin = new System.Windows.Forms.Label();
            this.trvPermisos = new System.Windows.Forms.TreeView();
            this.lblPermiso = new System.Windows.Forms.Label();
            this.grpPermisos = new System.Windows.Forms.GroupBox();
            this.grpEditarPermisos = new System.Windows.Forms.GroupBox();
            this.btnRomperRelPadreHijo = new System.Windows.Forms.Button();
            this.txtPermiso = new System.Windows.Forms.TextBox();
            this.btnLimpiarSeleccion = new System.Windows.Forms.Button();
            this.lblHijo = new System.Windows.Forms.Label();
            this.btnAgregarPermiso = new System.Windows.Forms.Button();
            this.lblPadre = new System.Windows.Forms.Label();
            this.btnRelPadreHijo = new System.Windows.Forms.Button();
            this.txtHijo = new System.Windows.Forms.TextBox();
            this.txtPadre = new System.Windows.Forms.TextBox();
            this.chkEditPermisos = new System.Windows.Forms.CheckBox();
            this.grpTiposDeUsuario = new System.Windows.Forms.GroupBox();
            this.cboTipoUsuarios = new System.Windows.Forms.ComboBox();
            this.lblTipoUsuario = new System.Windows.Forms.Label();
            this.trvTiposUsuario = new System.Windows.Forms.TreeView();
            this.btnAsignarPermiso = new System.Windows.Forms.Button();
            this.btnQuitarPermiso = new System.Windows.Forms.Button();
            this.tooltipRelacionar = new System.Windows.Forms.ToolTip(this.components);
            this.grpPermisos.SuspendLayout();
            this.grpEditarPermisos.SuspendLayout();
            this.grpTiposDeUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHolaAdmin
            // 
            this.lblHolaAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHolaAdmin.Location = new System.Drawing.Point(0, 0);
            this.lblHolaAdmin.Name = "lblHolaAdmin";
            this.lblHolaAdmin.Size = new System.Drawing.Size(924, 13);
            this.lblHolaAdmin.TabIndex = 1;
            this.lblHolaAdmin.Text = "Hola";
            this.lblHolaAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trvPermisos
            // 
            this.trvPermisos.CheckBoxes = true;
            this.trvPermisos.Location = new System.Drawing.Point(9, 19);
            this.trvPermisos.Name = "trvPermisos";
            this.trvPermisos.Size = new System.Drawing.Size(400, 270);
            this.trvPermisos.TabIndex = 2;
            this.trvPermisos.DoubleClick += new System.EventHandler(this.trvPermisos_DoubleClick);
            // 
            // lblPermiso
            // 
            this.lblPermiso.AutoSize = true;
            this.lblPermiso.Location = new System.Drawing.Point(13, 22);
            this.lblPermiso.Name = "lblPermiso";
            this.lblPermiso.Size = new System.Drawing.Size(44, 13);
            this.lblPermiso.TabIndex = 3;
            this.lblPermiso.Text = "Permiso";
            // 
            // grpPermisos
            // 
            this.grpPermisos.Controls.Add(this.grpEditarPermisos);
            this.grpPermisos.Controls.Add(this.chkEditPermisos);
            this.grpPermisos.Controls.Add(this.trvPermisos);
            this.grpPermisos.Location = new System.Drawing.Point(3, 16);
            this.grpPermisos.Name = "grpPermisos";
            this.grpPermisos.Size = new System.Drawing.Size(415, 465);
            this.grpPermisos.TabIndex = 4;
            this.grpPermisos.TabStop = false;
            this.grpPermisos.Text = "Permisos";
            // 
            // grpEditarPermisos
            // 
            this.grpEditarPermisos.Controls.Add(this.btnRomperRelPadreHijo);
            this.grpEditarPermisos.Controls.Add(this.txtPermiso);
            this.grpEditarPermisos.Controls.Add(this.btnLimpiarSeleccion);
            this.grpEditarPermisos.Controls.Add(this.lblPermiso);
            this.grpEditarPermisos.Controls.Add(this.lblHijo);
            this.grpEditarPermisos.Controls.Add(this.btnAgregarPermiso);
            this.grpEditarPermisos.Controls.Add(this.lblPadre);
            this.grpEditarPermisos.Controls.Add(this.btnRelPadreHijo);
            this.grpEditarPermisos.Controls.Add(this.txtHijo);
            this.grpEditarPermisos.Controls.Add(this.txtPadre);
            this.grpEditarPermisos.Location = new System.Drawing.Point(0, 318);
            this.grpEditarPermisos.Name = "grpEditarPermisos";
            this.grpEditarPermisos.Size = new System.Drawing.Size(415, 146);
            this.grpEditarPermisos.TabIndex = 8;
            this.grpEditarPermisos.TabStop = false;
            this.grpEditarPermisos.Text = "Editar Permisos";
            // 
            // btnRomperRelPadreHijo
            // 
            this.btnRomperRelPadreHijo.Location = new System.Drawing.Point(337, 78);
            this.btnRomperRelPadreHijo.Name = "btnRomperRelPadreHijo";
            this.btnRomperRelPadreHijo.Size = new System.Drawing.Size(75, 23);
            this.btnRomperRelPadreHijo.TabIndex = 13;
            this.btnRomperRelPadreHijo.Text = "Desvincular";
            this.tooltipRelacionar.SetToolTip(this.btnRomperRelPadreHijo, "Doble click al permiso que desee seleccionar");
            this.btnRomperRelPadreHijo.UseVisualStyleBackColor = true;
            this.btnRomperRelPadreHijo.Click += new System.EventHandler(this.btnRomperRelPadreHijo_Click);
            // 
            // txtPermiso
            // 
            this.txtPermiso.Location = new System.Drawing.Point(88, 19);
            this.txtPermiso.Name = "txtPermiso";
            this.txtPermiso.Size = new System.Drawing.Size(233, 20);
            this.txtPermiso.TabIndex = 4;
            // 
            // btnLimpiarSeleccion
            // 
            this.btnLimpiarSeleccion.Location = new System.Drawing.Point(246, 117);
            this.btnLimpiarSeleccion.Name = "btnLimpiarSeleccion";
            this.btnLimpiarSeleccion.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiarSeleccion.TabIndex = 12;
            this.btnLimpiarSeleccion.Text = "Limpiar";
            this.btnLimpiarSeleccion.UseVisualStyleBackColor = true;
            this.btnLimpiarSeleccion.Click += new System.EventHandler(this.btnLimpiarSeleccion_Click);
            // 
            // lblHijo
            // 
            this.lblHijo.AutoSize = true;
            this.lblHijo.Location = new System.Drawing.Point(13, 81);
            this.lblHijo.Name = "lblHijo";
            this.lblHijo.Size = new System.Drawing.Size(25, 13);
            this.lblHijo.TabIndex = 11;
            this.lblHijo.Text = "Hijo";
            // 
            // btnAgregarPermiso
            // 
            this.btnAgregarPermiso.Location = new System.Drawing.Point(337, 17);
            this.btnAgregarPermiso.Name = "btnAgregarPermiso";
            this.btnAgregarPermiso.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarPermiso.TabIndex = 5;
            this.btnAgregarPermiso.Text = "Agregar";
            this.btnAgregarPermiso.UseVisualStyleBackColor = true;
            this.btnAgregarPermiso.Click += new System.EventHandler(this.btnAgregarPermiso_Click);
            // 
            // lblPadre
            // 
            this.lblPadre.AutoSize = true;
            this.lblPadre.Location = new System.Drawing.Point(13, 55);
            this.lblPadre.Name = "lblPadre";
            this.lblPadre.Size = new System.Drawing.Size(35, 13);
            this.lblPadre.TabIndex = 10;
            this.lblPadre.Text = "Padre";
            // 
            // btnRelPadreHijo
            // 
            this.btnRelPadreHijo.Location = new System.Drawing.Point(337, 52);
            this.btnRelPadreHijo.Name = "btnRelPadreHijo";
            this.btnRelPadreHijo.Size = new System.Drawing.Size(75, 23);
            this.btnRelPadreHijo.TabIndex = 6;
            this.btnRelPadreHijo.Text = "Vincular";
            this.tooltipRelacionar.SetToolTip(this.btnRelPadreHijo, "Doble click al permiso que desee seleccionar");
            this.btnRelPadreHijo.UseVisualStyleBackColor = true;
            this.btnRelPadreHijo.Click += new System.EventHandler(this.btnRelPadreHijo_Click);
            // 
            // txtHijo
            // 
            this.txtHijo.Location = new System.Drawing.Point(88, 81);
            this.txtHijo.Name = "txtHijo";
            this.txtHijo.ReadOnly = true;
            this.txtHijo.Size = new System.Drawing.Size(233, 20);
            this.txtHijo.TabIndex = 9;
            this.tooltipRelacionar.SetToolTip(this.txtHijo, "Doble click al permiso que desee seleccionar");
            this.txtHijo.MouseEnter += new System.EventHandler(this.txtHijo_MouseEnter);
            this.txtHijo.MouseLeave += new System.EventHandler(this.txtHijo_MouseLeave);
            // 
            // txtPadre
            // 
            this.txtPadre.Location = new System.Drawing.Point(88, 55);
            this.txtPadre.Name = "txtPadre";
            this.txtPadre.ReadOnly = true;
            this.txtPadre.Size = new System.Drawing.Size(233, 20);
            this.txtPadre.TabIndex = 8;
            this.tooltipRelacionar.SetToolTip(this.txtPadre, "Doble click al permiso que desee seleccionar");
            this.txtPadre.MouseEnter += new System.EventHandler(this.txtPadre_MouseEnter);
            this.txtPadre.MouseLeave += new System.EventHandler(this.txtPadre_MouseLeave);
            // 
            // chkEditPermisos
            // 
            this.chkEditPermisos.AutoSize = true;
            this.chkEditPermisos.Location = new System.Drawing.Point(6, 295);
            this.chkEditPermisos.Name = "chkEditPermisos";
            this.chkEditPermisos.Size = new System.Drawing.Size(95, 17);
            this.chkEditPermisos.TabIndex = 7;
            this.chkEditPermisos.Text = "EditarPermisos";
            this.chkEditPermisos.UseVisualStyleBackColor = true;
            this.chkEditPermisos.CheckedChanged += new System.EventHandler(this.chkEditPermisos_CheckedChanged);
            // 
            // grpTiposDeUsuario
            // 
            this.grpTiposDeUsuario.Controls.Add(this.cboTipoUsuarios);
            this.grpTiposDeUsuario.Controls.Add(this.lblTipoUsuario);
            this.grpTiposDeUsuario.Controls.Add(this.trvTiposUsuario);
            this.grpTiposDeUsuario.Location = new System.Drawing.Point(505, 16);
            this.grpTiposDeUsuario.Name = "grpTiposDeUsuario";
            this.grpTiposDeUsuario.Size = new System.Drawing.Size(415, 465);
            this.grpTiposDeUsuario.TabIndex = 5;
            this.grpTiposDeUsuario.TabStop = false;
            this.grpTiposDeUsuario.Text = "Tipos de Usuario";
            // 
            // cboTipoUsuarios
            // 
            this.cboTipoUsuarios.FormattingEnabled = true;
            this.cboTipoUsuarios.Location = new System.Drawing.Point(99, 19);
            this.cboTipoUsuarios.Name = "cboTipoUsuarios";
            this.cboTipoUsuarios.Size = new System.Drawing.Size(311, 21);
            this.cboTipoUsuarios.TabIndex = 8;
            this.cboTipoUsuarios.SelectedIndexChanged += new System.EventHandler(this.cboTipoUsuarios_SelectedIndexChanged);
            // 
            // lblTipoUsuario
            // 
            this.lblTipoUsuario.AutoSize = true;
            this.lblTipoUsuario.Location = new System.Drawing.Point(7, 19);
            this.lblTipoUsuario.Name = "lblTipoUsuario";
            this.lblTipoUsuario.Size = new System.Drawing.Size(82, 13);
            this.lblTipoUsuario.TabIndex = 7;
            this.lblTipoUsuario.Text = "Tipo de Usuario";
            // 
            // trvTiposUsuario
            // 
            this.trvTiposUsuario.CheckBoxes = true;
            this.trvTiposUsuario.Location = new System.Drawing.Point(10, 46);
            this.trvTiposUsuario.Name = "trvTiposUsuario";
            this.trvTiposUsuario.Size = new System.Drawing.Size(400, 243);
            this.trvTiposUsuario.TabIndex = 6;
            // 
            // btnAsignarPermiso
            // 
            this.btnAsignarPermiso.Location = new System.Drawing.Point(424, 147);
            this.btnAsignarPermiso.Name = "btnAsignarPermiso";
            this.btnAsignarPermiso.Size = new System.Drawing.Size(75, 23);
            this.btnAsignarPermiso.TabIndex = 6;
            this.btnAsignarPermiso.Text = "Agregar ->";
            this.btnAsignarPermiso.UseVisualStyleBackColor = true;
            this.btnAsignarPermiso.Click += new System.EventHandler(this.btnAsignarPermiso_Click);
            // 
            // btnQuitarPermiso
            // 
            this.btnQuitarPermiso.Location = new System.Drawing.Point(424, 176);
            this.btnQuitarPermiso.Name = "btnQuitarPermiso";
            this.btnQuitarPermiso.Size = new System.Drawing.Size(75, 23);
            this.btnQuitarPermiso.TabIndex = 7;
            this.btnQuitarPermiso.Text = "<- Quitar";
            this.btnQuitarPermiso.UseVisualStyleBackColor = true;
            this.btnQuitarPermiso.Click += new System.EventHandler(this.btnQuitarPermiso_Click);
            // 
            // FRM_Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 491);
            this.Controls.Add(this.btnQuitarPermiso);
            this.Controls.Add(this.btnAsignarPermiso);
            this.Controls.Add(this.grpTiposDeUsuario);
            this.Controls.Add(this.grpPermisos);
            this.Controls.Add(this.lblHolaAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FRM_Administrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_Administrador";
            this.Load += new System.EventHandler(this.FRM_Administrador_Load);
            this.grpPermisos.ResumeLayout(false);
            this.grpPermisos.PerformLayout();
            this.grpEditarPermisos.ResumeLayout(false);
            this.grpEditarPermisos.PerformLayout();
            this.grpTiposDeUsuario.ResumeLayout(false);
            this.grpTiposDeUsuario.PerformLayout();
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
        private System.Windows.Forms.CheckBox chkEditPermisos;
        private System.Windows.Forms.Label lblHijo;
        private System.Windows.Forms.Label lblPadre;
        private System.Windows.Forms.TextBox txtHijo;
        private System.Windows.Forms.TextBox txtPadre;
        private System.Windows.Forms.Button btnLimpiarSeleccion;
        private System.Windows.Forms.ToolTip tooltipRelacionar;
        private System.Windows.Forms.Button btnRomperRelPadreHijo;
        private System.Windows.Forms.GroupBox grpEditarPermisos;
        private System.Windows.Forms.ComboBox cboTipoUsuarios;
        private System.Windows.Forms.Label lblTipoUsuario;
    }
}