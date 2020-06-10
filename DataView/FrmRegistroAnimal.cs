using DataModel;
using DataLogic;
using System;
using System.IO;
using System.Transactions;
using System.Windows.Forms;

namespace DataView
{
    public partial class FrmRegistroAnimal : Form
    {
        
        public OpenFileDialog examinar = new OpenFileDialog();
        Animal _animal = new Animal();
        DLAnimal _dla = new DLAnimal();
        public FrmRegistroAnimal()
        {
            InitializeComponent();
            
            LlenarBoxEdad();
            LlenarBoxEspecies();
            LlenarFecha();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new FrmPrincipal().Show();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            examinar.Filter = "Archivos de imagen|*.jpg;*.png;*.gif;";
            DialogResult dres1 = examinar.ShowDialog();
            if (dres1 == DialogResult.Abort)
                return;
            if (dres1 == DialogResult.Cancel)
                return;
            txtRutaImagen.Text = examinar.FileName;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    if (VerificarCampos())
                    {
                        FileStream stream = new FileStream(txtRutaImagen.Text, FileMode.Open, FileAccess.Read);
                        BinaryReader br = new BinaryReader(stream);
                        FileInfo fi = new FileInfo(txtRutaImagen.Text);
                        byte[] binData = new byte[stream.Length];
                        stream.Read(binData, 0, Convert.ToInt32(stream.Length));
                        _animal.CodigoAnimal = txtCodigo.Text;
                        if (rbPequeno.Checked == true)
                        {
                            _animal.Tamano = "Pequeño";
                        }
                        else if (rbMediano.Checked == true)
                        {
                            _animal.Tamano = "Mediano";
                        }
                        else {
                            _animal.Tamano = "Grande";
                        }
                        _animal.EdadAprox = CBXEdad.SelectedItem.ToString();
                        _animal.PesoAprox = txtPeso.Text ;
                        _animal.Color = txtColor.Text;
                        if (chBoxAdoptado.Checked == true)
                        {
                            _animal.Estado = "Adoptado";
                        }
                        else if (chBoxAlbergue.Checked == true)
                        {
                            _animal.Estado= "Albergue";
                        }
                        else
                        {
                            _animal.Estado = "Fallecido";
                        }
                        _animal.Descripcion = txtDescripcion.Text;
                        _animal.Especie = cboxEspecie.SelectedItem.ToString();
                        _animal.FechaIngreso = DateTime.Today;
                        _animal.Imagen = binData;
                        _animal.IDUsuario = 1;
                    }
                    int resultado = _dla.AgregarAnimal(_animal);
                    if (resultado == 1)
                    {
                        GVAnimales.Refresh();
                        MessageBox.Show("Registro agregado correctamente", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        scope.Complete();
                        
                    }
                    else
                    {
                        MessageBox.Show("Error al crear registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Limpiar();
                    errorProvider.Clear();
                }
            }
            catch
            {
                MessageBox.Show("Error al crear el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void LlenarBoxEdad()
        {
            CBXEdad.Items.Insert(0, "Seleccionar");
            //cboxEspecie.SelectedIndex = 0;
            for (int i = 0; i <= 96; i++)
            {
                CBXEdad.Items.Add(i);
            }
        }

        public void LlenarBoxEspecies() {
            cboxEspecie.Items.Insert(0, "Seleccionar");
            cboxEspecie.SelectedIndex = 0;
            cboxEspecie.Items.Add("Perro");
            cboxEspecie.Items.Add("Gato");
            cboxEspecie.Items.Add("Halcón");
            cboxEspecie.Items.Add("Coballo");
            cboxEspecie.Items.Add("Paloma");
            cboxEspecie.Items.Add("Tortuga");
            cboxEspecie.Items.Add("Garrobo");
            cboxEspecie.Items.Add("Conejo");
            cboxEspecie.Items.Add("Ardilla");
            cboxEspecie.Items.Add("Otro");
        }

        public void LlenarFecha() {
            string dateString = DateTime.Now.ToString("dd/MM/yyyy");
            string anno = DateTime.Now.ToString("yyyy");
            txtCodigo.Text = anno+"-";
            txtFecha.Text = dateString;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope()) {
                    if (VerificarCampos())
                    {
                        _animal.CodigoAnimal = txtCodigo.Text;
                        if (rbPequeno.Checked == true)
                        {
                            _animal.Tamano = "Pequeño";
                        }
                        else if (rbMediano.Checked == true)
                        {
                            _animal.Tamano = "Mediano";
                        }
                        else
                        {
                            _animal.Tamano = "Grande";
                        }
                        _animal.EdadAprox = CBXEdad.SelectedItem.ToString();
                        _animal.PesoAprox = txtPeso.Text;
                        _animal.Color = txtColor.Text;
                        if (chBoxAdoptado.Checked == true)
                        {
                            _animal.Estado = "Adoptado";
                        }
                        else if (chBoxAlbergue.Checked == true)
                        {
                            _animal.Estado = "Albergue";
                        }
                        else
                        {
                            _animal.Estado = "Fallecido";
                        }
                        _animal.Descripcion = txtDescripcion.Text;
                        _animal.Especie = cboxEspecie.SelectedItem.ToString();
                        _animal.FechaIngreso = DateTime.Today;
                        _animal.IDUsuario = 1;
                    }
                    int resultado = _dla.ModificarAnimal(_animal);
                    if (resultado == 1)
                    {
                        GVAnimales.Refresh();
                        MessageBox.Show("Registro modificado correctamente", "Modificación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        scope.Complete();
                    }
                    else
                    {
                        MessageBox.Show("Error al modificar registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Limpiar();
                    errorProvider.Clear();
                }
                btnRegistrar.Enabled = true;
                btnModificar.Enabled = false;
                txtCodigo.Enabled = true;
                cboxEspecie.Enabled = true;
                txtColor.Enabled = true;
                btnSeleccionar.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Error en la modificación del registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            LlenarGrid();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCodigo.Text.Trim() == "")
                {
                    errorProvider.SetError(txtCodigo, "Debe ingresar un código de animal");
                }
                else
                {
                    Animal animal = _dla.BuscarAnimal(txtCodigo.Text.Trim());
                    if (animal.CodigoAnimal != "2020-")
                    {
                        btnRegistrar.Enabled = false;
                        btnModificar.Enabled = true;
                        txtFecha.Text = animal.FechaIngreso.ToString();
                        cboxEspecie.SelectedItem = animal.Especie;
                        txtColor.Text = animal.Color;
                        CBXEdad.SelectedIndex = Convert.ToInt32(animal.EdadAprox);
                        txtPeso.Text = animal.PesoAprox;
                        if (animal.Tamano == "Pequeño")
                        {
                            rbPequeno.Checked = true;
                        }
                        else if (animal.Tamano == "Mediano")
                        {
                            rbMediano.Checked = true;
                        }
                        else
                        {
                            rbGrande.Checked = true;
                        }
                        txtDescripcion.Text = animal.Descripcion;
                        if (animal.Estado.Equals("Adoptado"))
                        {
                            chBoxAdoptado.Checked = true;
                        }
                        else if (animal.Estado.Equals("Albergue"))
                        {
                            chBoxAlbergue.Checked = true;
                        }
                        else
                        {
                            chBoxFallecido.Checked = true;
                        }
                        txtRutaImagen.Text = Convert.ToString(animal.Imagen);
                        txtCodigo.Enabled = false;
                        cboxEspecie.Enabled = false;
                        txtColor.Enabled = false;
                        btnSeleccionar.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("El código de animal no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        LlenarFecha();
                    }
                } 
            }
            catch
            {
                MessageBox.Show("No hay registros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LlenarFecha();
            }
        }

        public void Limpiar() {
            txtCodigo.Clear();
            txtColor.Clear();
            txtDescripcion.Clear();
            txtPeso.Clear();
            LlenarFecha();
            txtRutaImagen.Clear();
            rbGrande.Checked = true;
            rbMediano.Checked = false;
            rbPequeno.Checked = false;
            chBoxAdoptado.Checked = false;
            chBoxAlbergue.Checked = true;
            chBoxFallecido.Checked = false;
            cboxEspecie.ResetText();
            CBXEdad.ResetText();
        }

        public void LlenarGrid()
        {
            GVAnimales.DataSource = _dla.ConsultarAnimales();
        }

        private bool VerificarCampos() {
            bool ok = true;
            if (this.txtCodigo.Text.Trim() == "" || this.txtCodigo.Text.Trim() == "2020-")
            {
                ok = false;
                errorProvider.SetError(txtCodigo, "Debe ingresar un código");
            }
            if (this.txtFecha.Text.Trim() == "")
            {
                ok = false;
                errorProvider.SetError(txtFecha, "Debe ingresar una fecha");
            }
            if (this.cboxEspecie.SelectedIndex == -1)
            {
                ok = false;
                errorProvider.SetError(cboxEspecie, "Debe seleccionar una especie");
            }
            if (this.txtColor.Text.Trim() == "")
            {
                ok = false;
                errorProvider.SetError(txtColor, "Debe ingresar un color");
            }
            if (this.txtPeso.Text.Trim() == "")
            {
                ok = false;
                errorProvider.SetError(txtPeso, "Debe ingresar un peso");
            }
            if (this.CBXEdad.SelectedIndex == -1)
            {
                ok = false;
                errorProvider.SetError(CBXEdad, "Debe seleccionar una edad");
            }
            if (this.txtDescripcion.Text.Trim() == "")
            {
                ok = false;
                errorProvider.SetError(txtDescripcion, "Debe ingresar una descripción");
            }
            if (this.txtRutaImagen.Text.Trim() == "")
            {
                ok = false;
                errorProvider.SetError(txtRutaImagen, "Debe seleccionar una imagen");
            }
            return ok;
        }
    }
}

