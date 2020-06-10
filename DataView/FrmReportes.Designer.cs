namespace DataView
{
    partial class FrmReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReportes));
            this.label1 = new System.Windows.Forms.Label();
            this.rbCodigo = new System.Windows.Forms.RadioButton();
            this.rbFechaIngreso = new System.Windows.Forms.RadioButton();
            this.rbTipoAnimal = new System.Windows.Forms.RadioButton();
            this.rbConsultaGeneral = new System.Windows.Forms.RadioButton();
            this.GVReportes = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.cBoxTipoAnimal = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.GVReportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(320, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reportes";
            // 
            // rbCodigo
            // 
            this.rbCodigo.AutoSize = true;
            this.rbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCodigo.Location = new System.Drawing.Point(653, 126);
            this.rbCodigo.Name = "rbCodigo";
            this.rbCodigo.Size = new System.Drawing.Size(94, 24);
            this.rbCodigo.TabIndex = 1;
            this.rbCodigo.Text = " Código";
            this.rbCodigo.UseVisualStyleBackColor = true;
            this.rbCodigo.CheckedChanged += new System.EventHandler(this.rbCodigo_CheckedChanged);
            // 
            // rbFechaIngreso
            // 
            this.rbFechaIngreso.AutoSize = true;
            this.rbFechaIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFechaIngreso.Location = new System.Drawing.Point(41, 164);
            this.rbFechaIngreso.Name = "rbFechaIngreso";
            this.rbFechaIngreso.Size = new System.Drawing.Size(175, 24);
            this.rbFechaIngreso.TabIndex = 2;
            this.rbFechaIngreso.Text = "Fecha de ingreso";
            this.rbFechaIngreso.UseVisualStyleBackColor = true;
            this.rbFechaIngreso.CheckedChanged += new System.EventHandler(this.rbFechaIngreso_CheckedChanged);
            // 
            // rbTipoAnimal
            // 
            this.rbTipoAnimal.AutoSize = true;
            this.rbTipoAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTipoAnimal.Location = new System.Drawing.Point(464, 126);
            this.rbTipoAnimal.Name = "rbTipoAnimal";
            this.rbTipoAnimal.Size = new System.Drawing.Size(97, 24);
            this.rbTipoAnimal.TabIndex = 3;
            this.rbTipoAnimal.Text = "Especie";
            this.rbTipoAnimal.UseVisualStyleBackColor = true;
            this.rbTipoAnimal.CheckedChanged += new System.EventHandler(this.rbTipoAnimal_CheckedChanged);
            // 
            // rbConsultaGeneral
            // 
            this.rbConsultaGeneral.AutoSize = true;
            this.rbConsultaGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbConsultaGeneral.Location = new System.Drawing.Point(240, 162);
            this.rbConsultaGeneral.Name = "rbConsultaGeneral";
            this.rbConsultaGeneral.Size = new System.Drawing.Size(172, 24);
            this.rbConsultaGeneral.TabIndex = 4;
            this.rbConsultaGeneral.Text = "Consulta general";
            this.rbConsultaGeneral.UseVisualStyleBackColor = true;
            this.rbConsultaGeneral.CheckedChanged += new System.EventHandler(this.rbConsultaGeneral_CheckedChanged);
            // 
            // GVReportes
            // 
            this.GVReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVReportes.Location = new System.Drawing.Point(40, 212);
            this.GVReportes.Name = "GVReportes";
            this.GVReportes.RowTemplate.Height = 24;
            this.GVReportes.Size = new System.Drawing.Size(719, 198);
            this.GVReportes.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DataView.Properties.Resources.LOGO_Colitas_Esparza_pequeño;
            this.pictureBox1.Location = new System.Drawing.Point(56, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Image = global::DataView.Properties.Resources.iconfinder_cat_285654;
            this.btnRegresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegresar.Location = new System.Drawing.Point(617, 425);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(130, 49);
            this.btnRegresar.TabIndex = 7;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarReporte.Image = global::DataView.Properties.Resources.reporte32;
            this.btnGenerarReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerarReporte.Location = new System.Drawing.Point(56, 425);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(177, 49);
            this.btnGenerarReporte.TabIndex = 6;
            this.btnGenerarReporte.Text = "Generar reporte";
            this.btnGenerarReporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGenerarReporte.UseVisualStyleBackColor = true;
            this.btnGenerarReporte.Click += new System.EventHandler(this.btnGenerarReporte_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(648, 164);
            this.txtCodigo.Multiline = true;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(123, 29);
            this.txtCodigo.TabIndex = 9;
            // 
            // cBoxTipoAnimal
            // 
            this.cBoxTipoAnimal.FormattingEnabled = true;
            this.cBoxTipoAnimal.Location = new System.Drawing.Point(454, 164);
            this.cBoxTipoAnimal.Name = "cBoxTipoAnimal";
            this.cBoxTipoAnimal.Size = new System.Drawing.Size(150, 24);
            this.cBoxTipoAnimal.TabIndex = 10;
            // 
            // FrmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(208)))));
            this.ClientSize = new System.Drawing.Size(797, 493);
            this.Controls.Add(this.cBoxTipoAnimal);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnGenerarReporte);
            this.Controls.Add(this.GVReportes);
            this.Controls.Add(this.rbConsultaGeneral);
            this.Controls.Add(this.rbTipoAnimal);
            this.Controls.Add(this.rbFechaIngreso);
            this.Controls.Add(this.rbCodigo);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Módulo de reportes";
            ((System.ComponentModel.ISupportInitialize)(this.GVReportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbCodigo;
        private System.Windows.Forms.RadioButton rbFechaIngreso;
        private System.Windows.Forms.RadioButton rbTipoAnimal;
        private System.Windows.Forms.RadioButton rbConsultaGeneral;
        private System.Windows.Forms.DataGridView GVReportes;
        private System.Windows.Forms.Button btnGenerarReporte;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.ComboBox cBoxTipoAnimal;
    }
}