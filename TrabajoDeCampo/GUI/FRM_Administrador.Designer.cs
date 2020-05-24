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
            this.SuspendLayout();
            // 
            // lblHolaAdmin
            // 
            this.lblHolaAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHolaAdmin.Location = new System.Drawing.Point(0, 0);
            this.lblHolaAdmin.Name = "lblHolaAdmin";
            this.lblHolaAdmin.Size = new System.Drawing.Size(800, 13);
            this.lblHolaAdmin.TabIndex = 1;
            this.lblHolaAdmin.Text = "Hola";
            this.lblHolaAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FRM_Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblHolaAdmin);
            this.Name = "FRM_Administrador";
            this.Text = "FRM_Administrador";
            this.Load += new System.EventHandler(this.FRM_Administrador_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHolaAdmin;
    }
}