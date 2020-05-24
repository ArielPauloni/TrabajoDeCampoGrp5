namespace GUI
{
    partial class FRM_WebMaster
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
            this.lblHolaWebMaster = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHolaWebMaster
            // 
            this.lblHolaWebMaster.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHolaWebMaster.Location = new System.Drawing.Point(0, 0);
            this.lblHolaWebMaster.Name = "lblHolaWebMaster";
            this.lblHolaWebMaster.Size = new System.Drawing.Size(800, 13);
            this.lblHolaWebMaster.TabIndex = 2;
            this.lblHolaWebMaster.Text = "Hola";
            this.lblHolaWebMaster.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FRM_WebMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblHolaWebMaster);
            this.Name = "FRM_WebMaster";
            this.Text = "FRM_WebMaster";
            this.Load += new System.EventHandler(this.FRM_WebMaster_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHolaWebMaster;
    }
}