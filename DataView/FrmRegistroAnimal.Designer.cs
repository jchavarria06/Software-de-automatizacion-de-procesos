namespace DataView
{
    partial class FrmRegistroAnimal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistroAnimal));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.GVAnimales = new System.Windows.Forms.DataGridView();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.rbGrande = new System.Windows.Forms.RadioButton();
            this.rbMediano = new System.Windows.Forms.RadioButton();
            this.rbPequeno = new System.Windows.Forms.RadioButton();
            this.CBXEdad = new System.Windows.Forms.ComboBox();
            this.cboxEspecie = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtRutaImagen = new System.Windows.Forms.TextBox();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.chBoxAdoptado = new System.Windows.Forms.CheckBox();
            this.chBoxAlbergue = new System.Windows.Forms.CheckBox();
            this.chBoxFallecido = new System.Windows.Forms.CheckBox();
            this.gbEstado = new System.Windows.Forms.GroupBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GVAnimales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbEstado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(233, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro de animales";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código animal:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha ingreso:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(106, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Especie:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(483, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Peso:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(127, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Color:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(368, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Edad aproximada:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(103, 347);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Tamaño:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(66, 426);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Descripción:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(13, 557);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(165, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "Estado del animal:";
            // 
            // GVAnimales
            // 
            this.GVAnimales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVAnimales.Location = new System.Drawing.Point(58, 604);
            this.GVAnimales.Name = "GVAnimales";
            this.GVAnimales.RowHeadersWidth = 51;
            this.GVAnimales.RowTemplate.Height = 24;
            this.GVAnimales.Size = new System.Drawing.Size(568, 150);
            this.GVAnimales.TabIndex = 10;
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(210, 164);
            this.txtCodigo.Multiline = true;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(201, 28);
            this.txtCodigo.TabIndex = 16;
            // 
            // txtFecha
            // 
            this.txtFecha.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtFecha.Enabled = false;
            this.txtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtFecha.Location = new System.Drawing.Point(210, 210);
            this.txtFecha.Multiline = true;
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(201, 28);
            this.txtFecha.TabIndex = 17;
            // 
            // txtPeso
            // 
            this.txtPeso.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtPeso.Location = new System.Drawing.Point(546, 254);
            this.txtPeso.Multiline = true;
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(63, 28);
            this.txtPeso.TabIndex = 19;
            // 
            // txtColor
            // 
            this.txtColor.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtColor.Location = new System.Drawing.Point(210, 297);
            this.txtColor.Multiline = true;
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(128, 28);
            this.txtColor.TabIndex = 21;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtDescripcion.Location = new System.Drawing.Point(212, 401);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(414, 80);
            this.txtDescripcion.TabIndex = 22;
            // 
            // rbGrande
            // 
            this.rbGrande.AutoSize = true;
            this.rbGrande.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.rbGrande.Location = new System.Drawing.Point(487, 346);
            this.rbGrande.Name = "rbGrande";
            this.rbGrande.Size = new System.Drawing.Size(84, 22);
            this.rbGrande.TabIndex = 28;
            this.rbGrande.Text = "Grande";
            this.rbGrande.UseVisualStyleBackColor = true;
            // 
            // rbMediano
            // 
            this.rbMediano.AutoSize = true;
            this.rbMediano.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.rbMediano.Location = new System.Drawing.Point(352, 346);
            this.rbMediano.Name = "rbMediano";
            this.rbMediano.Size = new System.Drawing.Size(93, 22);
            this.rbMediano.TabIndex = 27;
            this.rbMediano.Text = "Mediano";
            this.rbMediano.UseVisualStyleBackColor = true;
            // 
            // rbPequeno
            // 
            this.rbPequeno.AutoSize = true;
            this.rbPequeno.Checked = true;
            this.rbPequeno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPequeno.Location = new System.Drawing.Point(227, 346);
            this.rbPequeno.Name = "rbPequeno";
            this.rbPequeno.Size = new System.Drawing.Size(95, 22);
            this.rbPequeno.TabIndex = 26;
            this.rbPequeno.TabStop = true;
            this.rbPequeno.Text = "Pequeño";
            this.rbPequeno.UseVisualStyleBackColor = true;
            // 
            // CBXEdad
            // 
            this.CBXEdad.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CBXEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.CBXEdad.FormattingEnabled = true;
            this.CBXEdad.Location = new System.Drawing.Point(546, 297);
            this.CBXEdad.Name = "CBXEdad";
            this.CBXEdad.Size = new System.Drawing.Size(80, 28);
            this.CBXEdad.TabIndex = 30;
            // 
            // cboxEspecie
            // 
            this.cboxEspecie.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cboxEspecie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.cboxEspecie.FormattingEnabled = true;
            this.cboxEspecie.Location = new System.Drawing.Point(210, 254);
            this.cboxEspecie.Name = "cboxEspecie";
            this.cboxEspecie.Size = new System.Drawing.Size(137, 28);
            this.cboxEspecie.TabIndex = 31;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DataView.Properties.Resources.LOGO_Colitas_Esparza_pequeño;
            this.pictureBox1.Location = new System.Drawing.Point(17, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = global::DataView.Properties.Resources.buscar_20;
            this.btnBuscar.Location = new System.Drawing.Point(436, 159);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(38, 36);
            this.btnBuscar.TabIndex = 15;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnRegresar.Image = global::DataView.Properties.Resources.Turtle_32;
            this.btnRegresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegresar.Location = new System.Drawing.Point(524, 773);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(122, 50);
            this.btnRegresar.TabIndex = 14;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnConsultar.Image = global::DataView.Properties.Resources.Consultar_32;
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.Location = new System.Drawing.Point(352, 773);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(136, 50);
            this.btnConsultar.TabIndex = 13;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Enabled = false;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnModificar.Image = global::DataView.Properties.Resources.Modificar_32;
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(186, 773);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(137, 50);
            this.btnModificar.TabIndex = 12;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Image = global::DataView.Properties.Resources.registrar_32;
            this.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrar.Location = new System.Drawing.Point(17, 772);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(135, 51);
            this.btnRegistrar.TabIndex = 11;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtRutaImagen
            // 
            this.txtRutaImagen.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtRutaImagen.Enabled = false;
            this.txtRutaImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtRutaImagen.Location = new System.Drawing.Point(190, 512);
            this.txtRutaImagen.Multiline = true;
            this.txtRutaImagen.Name = "txtRutaImagen";
            this.txtRutaImagen.Size = new System.Drawing.Size(436, 28);
            this.txtRutaImagen.TabIndex = 33;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeleccionar.Location = new System.Drawing.Point(17, 512);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(161, 28);
            this.btnSeleccionar.TabIndex = 34;
            this.btnSeleccionar.Text = "Seleccionar imagen";
            this.btnSeleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // chBoxAdoptado
            // 
            this.chBoxAdoptado.AutoSize = true;
            this.chBoxAdoptado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBoxAdoptado.Location = new System.Drawing.Point(20, 10);
            this.chBoxAdoptado.Name = "chBoxAdoptado";
            this.chBoxAdoptado.Size = new System.Drawing.Size(109, 24);
            this.chBoxAdoptado.TabIndex = 35;
            this.chBoxAdoptado.Text = "Adoptado";
            this.chBoxAdoptado.UseVisualStyleBackColor = true;
            // 
            // chBoxAlbergue
            // 
            this.chBoxAlbergue.AutoSize = true;
            this.chBoxAlbergue.Checked = true;
            this.chBoxAlbergue.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chBoxAlbergue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBoxAlbergue.Location = new System.Drawing.Point(153, 11);
            this.chBoxAlbergue.Name = "chBoxAlbergue";
            this.chBoxAlbergue.Size = new System.Drawing.Size(131, 24);
            this.chBoxAlbergue.TabIndex = 36;
            this.chBoxAlbergue.Text = "En albergue";
            this.chBoxAlbergue.UseVisualStyleBackColor = true;
            // 
            // chBoxFallecido
            // 
            this.chBoxFallecido.AutoSize = true;
            this.chBoxFallecido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBoxFallecido.Location = new System.Drawing.Point(312, 10);
            this.chBoxFallecido.Name = "chBoxFallecido";
            this.chBoxFallecido.Size = new System.Drawing.Size(107, 24);
            this.chBoxFallecido.TabIndex = 37;
            this.chBoxFallecido.Text = "Fallecido";
            this.chBoxFallecido.UseVisualStyleBackColor = true;
            // 
            // gbEstado
            // 
            this.gbEstado.Controls.Add(this.chBoxFallecido);
            this.gbEstado.Controls.Add(this.chBoxAlbergue);
            this.gbEstado.Controls.Add(this.chBoxAdoptado);
            this.gbEstado.Location = new System.Drawing.Point(204, 546);
            this.gbEstado.Name = "gbEstado";
            this.gbEstado.Size = new System.Drawing.Size(424, 38);
            this.gbEstado.TabIndex = 38;
            this.gbEstado.TabStop = false;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FrmRegistroAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(208)))));
            this.ClientSize = new System.Drawing.Size(677, 880);
            this.Controls.Add(this.gbEstado);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.txtRutaImagen);
            this.Controls.Add(this.cboxEspecie);
            this.Controls.Add(this.CBXEdad);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rbGrande);
            this.Controls.Add(this.rbMediano);
            this.Controls.Add(this.rbPequeno);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.GVAnimales);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRegistroAnimal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de animales";
            ((System.ComponentModel.ISupportInitialize)(this.GVAnimales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbEstado.ResumeLayout(false);
            this.gbEstado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView GVAnimales;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.RadioButton rbGrande;
        private System.Windows.Forms.RadioButton rbMediano;
        private System.Windows.Forms.RadioButton rbPequeno;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox CBXEdad;
        private System.Windows.Forms.ComboBox cboxEspecie;
        private System.Windows.Forms.TextBox txtRutaImagen;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.CheckBox chBoxAdoptado;
        private System.Windows.Forms.CheckBox chBoxAlbergue;
        private System.Windows.Forms.CheckBox chBoxFallecido;
        private System.Windows.Forms.GroupBox gbEstado;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}