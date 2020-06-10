namespace DataView
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroAnimalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroAdoptanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expedienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expedienteMedicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expedienteDeRescatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrosToolStripMenuItem,
            this.expedienteToolStripMenuItem,
            this.informacionToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registrosToolStripMenuItem
            // 
            this.registrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroAnimalToolStripMenuItem,
            this.registroAdoptanteToolStripMenuItem,
            this.registroUsuarioToolStripMenuItem});
            this.registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            this.registrosToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.registrosToolStripMenuItem.Text = "Registros";
            // 
            // registroAnimalToolStripMenuItem
            // 
            this.registroAnimalToolStripMenuItem.Image = global::DataView.Properties.Resources.Turtle_32;
            this.registroAnimalToolStripMenuItem.Name = "registroAnimalToolStripMenuItem";
            this.registroAnimalToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.registroAnimalToolStripMenuItem.Text = "Registro Animal";
            this.registroAnimalToolStripMenuItem.Click += new System.EventHandler(this.registroAnimalToolStripMenuItem_Click);
            // 
            // registroAdoptanteToolStripMenuItem
            // 
            this.registroAdoptanteToolStripMenuItem.Image = global::DataView.Properties.Resources.conejo32;
            this.registroAdoptanteToolStripMenuItem.Name = "registroAdoptanteToolStripMenuItem";
            this.registroAdoptanteToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.registroAdoptanteToolStripMenuItem.Text = "Registro Adoptante";
            this.registroAdoptanteToolStripMenuItem.Click += new System.EventHandler(this.registroAdoptanteToolStripMenuItem_Click);
            // 
            // registroUsuarioToolStripMenuItem
            // 
            this.registroUsuarioToolStripMenuItem.Image = global::DataView.Properties.Resources.perro_32;
            this.registroUsuarioToolStripMenuItem.Name = "registroUsuarioToolStripMenuItem";
            this.registroUsuarioToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.registroUsuarioToolStripMenuItem.Text = "Registro Usuario";
            this.registroUsuarioToolStripMenuItem.Click += new System.EventHandler(this.registroUsuarioToolStripMenuItem_Click);
            // 
            // expedienteToolStripMenuItem
            // 
            this.expedienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.expedienteMedicoToolStripMenuItem,
            this.expedienteDeRescatesToolStripMenuItem});
            this.expedienteToolStripMenuItem.Name = "expedienteToolStripMenuItem";
            this.expedienteToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.expedienteToolStripMenuItem.Text = "Expediente";
            // 
            // expedienteMedicoToolStripMenuItem
            // 
            this.expedienteMedicoToolStripMenuItem.Image = global::DataView.Properties.Resources.ardilla_32;
            this.expedienteMedicoToolStripMenuItem.Name = "expedienteMedicoToolStripMenuItem";
            this.expedienteMedicoToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.expedienteMedicoToolStripMenuItem.Text = "Expediente médico";
            this.expedienteMedicoToolStripMenuItem.Click += new System.EventHandler(this.expedienteMedicoToolStripMenuItem_Click);
            // 
            // expedienteDeRescatesToolStripMenuItem
            // 
            this.expedienteDeRescatesToolStripMenuItem.Image = global::DataView.Properties.Resources.tucan;
            this.expedienteDeRescatesToolStripMenuItem.Name = "expedienteDeRescatesToolStripMenuItem";
            this.expedienteDeRescatesToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.expedienteDeRescatesToolStripMenuItem.Text = "Expediente de rescates";
            this.expedienteDeRescatesToolStripMenuItem.Click += new System.EventHandler(this.expedienteDeRescatesToolStripMenuItem_Click);
            // 
            // informacionToolStripMenuItem
            // 
            this.informacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.donacionesToolStripMenuItem,
            this.archivosToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.informacionToolStripMenuItem.Name = "informacionToolStripMenuItem";
            this.informacionToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.informacionToolStripMenuItem.Text = "Información";
            // 
            // donacionesToolStripMenuItem
            // 
            this.donacionesToolStripMenuItem.Image = global::DataView.Properties.Resources.paloma;
            this.donacionesToolStripMenuItem.Name = "donacionesToolStripMenuItem";
            this.donacionesToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.donacionesToolStripMenuItem.Text = "Donaciones";
            this.donacionesToolStripMenuItem.Click += new System.EventHandler(this.donacionesToolStripMenuItem_Click);
            // 
            // archivosToolStripMenuItem
            // 
            this.archivosToolStripMenuItem.Image = global::DataView.Properties.Resources.coballo_32;
            this.archivosToolStripMenuItem.Name = "archivosToolStripMenuItem";
            this.archivosToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.archivosToolStripMenuItem.Text = "Archivos";
            this.archivosToolStripMenuItem.Click += new System.EventHandler(this.archivosToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Image = global::DataView.Properties.Resources.iconfinder_cat_285654;
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.reportesToolStripMenuItem.Text = "Reportes";
            this.reportesToolStripMenuItem.Click += new System.EventHandler(this.reportesToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DataView.Properties.Resources.LOGO_Colitas_Esparza_pequeño;
            this.pictureBox1.Location = new System.Drawing.Point(199, 103);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(373, 249);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(208)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroAnimalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroAdoptanteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expedienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expedienteMedicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expedienteDeRescatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem archivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}