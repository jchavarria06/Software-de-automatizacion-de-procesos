namespace DataView
{
    partial class FrmDonaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDonaciones));
            this.label1 = new System.Windows.Forms.Label();
            this.lbMontoT = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.GVMontos = new System.Windows.Forms.DataGridView();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cboxAnimales = new System.Windows.Forms.ComboBox();
            this.pBoxFoto = new System.Windows.Forms.PictureBox();
            this.nMonto = new System.Windows.Forms.NumericUpDown();
            this.txtMontoT = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GVMontos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMonto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Donaciones";
            // 
            // lbMontoT
            // 
            this.lbMontoT.AutoSize = true;
            this.lbMontoT.Font = new System.Drawing.Font("Lucida Fax", 10.8F, System.Drawing.FontStyle.Bold);
            this.lbMontoT.Location = new System.Drawing.Point(113, 246);
            this.lbMontoT.Name = "lbMontoT";
            this.lbMontoT.Size = new System.Drawing.Size(130, 22);
            this.lbMontoT.TabIndex = 1;
            this.lbMontoT.Text = "Monto total:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 10.8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(53, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Codigo del animal:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Fax", 10.8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(165, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Monto:";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Lucida Fax", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnRegistrar.Image = global::DataView.Properties.Resources.registrar_32;
            this.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrar.Location = new System.Drawing.Point(64, 498);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(133, 48);
            this.btnRegistrar.TabIndex = 6;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // GVMontos
            // 
            this.GVMontos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVMontos.Location = new System.Drawing.Point(44, 334);
            this.GVMontos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GVMontos.Name = "GVMontos";
            this.GVMontos.RowHeadersWidth = 51;
            this.GVMontos.RowTemplate.Height = 24;
            this.GVMontos.Size = new System.Drawing.Size(565, 158);
            this.GVMontos.TabIndex = 9;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Lucida Fax", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Image = global::DataView.Properties.Resources.paloma;
            this.btnRegresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegresar.Location = new System.Drawing.Point(481, 498);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(129, 53);
            this.btnRegresar.TabIndex = 8;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DataView.Properties.Resources.LOGO_Colitas_Esparza_pequeño;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // cboxAnimales
            // 
            this.cboxAnimales.FormattingEnabled = true;
            this.cboxAnimales.Location = new System.Drawing.Point(266, 158);
            this.cboxAnimales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboxAnimales.Name = "cboxAnimales";
            this.cboxAnimales.Size = new System.Drawing.Size(157, 24);
            this.cboxAnimales.TabIndex = 13;
            this.cboxAnimales.SelectedIndexChanged += new System.EventHandler(this.cboxAnimales_SelectedIndexChanged);
            // 
            // pBoxFoto
            // 
            this.pBoxFoto.Location = new System.Drawing.Point(455, 86);
            this.pBoxFoto.Margin = new System.Windows.Forms.Padding(4);
            this.pBoxFoto.Name = "pBoxFoto";
            this.pBoxFoto.Size = new System.Drawing.Size(178, 204);
            this.pBoxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxFoto.TabIndex = 27;
            this.pBoxFoto.TabStop = false;
            // 
            // nMonto
            // 
            this.nMonto.CausesValidation = false;
            this.nMonto.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nMonto.Location = new System.Drawing.Point(263, 206);
            this.nMonto.Margin = new System.Windows.Forms.Padding(4);
            this.nMonto.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nMonto.Name = "nMonto";
            this.nMonto.Size = new System.Drawing.Size(160, 22);
            this.nMonto.TabIndex = 28;
            this.nMonto.ThousandsSeparator = true;
            this.nMonto.Leave += new System.EventHandler(this.nMonto_Leave);
            // 
            // txtMontoT
            // 
            this.txtMontoT.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtMontoT.Enabled = false;
            this.txtMontoT.Location = new System.Drawing.Point(263, 246);
            this.txtMontoT.Name = "txtMontoT";
            this.txtMontoT.Size = new System.Drawing.Size(160, 22);
            this.txtMontoT.TabIndex = 29;
            // 
            // FrmDonaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(208)))));
            this.ClientSize = new System.Drawing.Size(663, 577);
            this.Controls.Add(this.txtMontoT);
            this.Controls.Add(this.nMonto);
            this.Controls.Add(this.pBoxFoto);
            this.Controls.Add(this.cboxAnimales);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.GVMontos);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbMontoT);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmDonaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Donaciones";
            ((System.ComponentModel.ISupportInitialize)(this.GVMontos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMonto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbMontoT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.DataGridView GVMontos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cboxAnimales;
        private System.Windows.Forms.PictureBox pBoxFoto;
        private System.Windows.Forms.NumericUpDown nMonto;
        private System.Windows.Forms.TextBox txtMontoT;
    }
}