using DataLogic;
using DataModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Transactions;
using System.Windows.Forms;

namespace DataView
{
    public partial class FrmRegistroAdoptantes : Form
    {
        Adoptante _adop = new Adoptante();
        DLAdoptante _dla = new DLAdoptante();
        DLAnimal _dlan = new DLAnimal();
        public FrmRegistroAdoptantes()
        {
            InitializeComponent();
            CargarCombo();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new FrmPrincipal().Show();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new FrmConsultaAdoptantes().Show();
        }

        private void btnBuscarAdoptante_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCedula.Text.Trim() == "")
                {
                    errorProvider.SetError(txtCedula, "Debe ingresar un número de cédula");
                }
                else
                {
                    Adoptante _adop = _dla.BuscarAdoptante(txtCedula.Text);

                    if (_adop.IDAdoptante != 0)
                    {
                        txtNombre.Text = _adop.NombreCompleto;
                        txtTelefono.Text = _adop.Telefono;
                        txtCorreo.Text = _adop.Correo;
                        txtDomicilio.Text = _adop.Direccion;
                        if (_adop.EstadoCalificacion == "Califica")
                        {
                            rbCalifica.Checked = true;
                        }
                        else
                        {
                            rbNoCalifica.Checked = true;
                        }
                        cboxAnimales.Text = _adop.CodigoAnimal;
                        txtCedula.Enabled = false;
                        txtNombre.Enabled = false;
                        cboxAnimales.Enabled = false;
                        btnModificar.Enabled = true;
                    }
                    else {
                        MessageBox.Show("La cédula ingresada no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch
            {
                MessageBox.Show("No hay registros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                using (TransactionScope scope  = new TransactionScope()) {
                    
                    if (VerificarCampos())
                    {
                        _adop.Cedula = txtCedula.Text;
                        _adop.NombreCompleto = txtNombre.Text;
                        _adop.Telefono = txtTelefono.Text;
                        _adop.Correo = txtCorreo.Text;
                        _adop.Direccion = txtDomicilio.Text;
                        if (rbCalifica.Checked == true)
                        {
                            _adop.EstadoCalificacion = "Califica";
                        }
                        else {
                            _adop.EstadoCalificacion = "No Califica";
                        }
                        if (BuscarAnimal())
                        {
                            _adop.CodigoAnimal = cboxAnimales.SelectedItem.ToString();
                        }
                        _adop.IDUsuario = 1;
                        int resultado = _dla.AgregarAdoptante(_adop);
                        if (resultado == 2)
                        {
                            MessageBox.Show("Registro agregado correctamente", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            scope.Complete();
                        }
                        else
                        {
                            MessageBox.Show("Error al crear registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        Limpiar();
                        errorProvider.Clear();
                        btnRegistrar.Enabled = false;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error al crear el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope()) {
                    if (VerificarCampos())
                    {
                        _adop.Cedula = txtCedula.Text;
                        _adop.NombreCompleto = txtNombre.Text;
                        _adop.Telefono = txtTelefono.Text;
                        _adop.Correo = txtCorreo.Text;
                        _adop.Direccion = txtDomicilio.Text;
                        if (rbCalifica.Checked == true)
                        {
                            _adop.EstadoCalificacion = "Califica";
                        }
                        else
                        {
                            _adop.EstadoCalificacion = "No Califica";
                        }
                        if (BuscarAnimal())
                        {
                            _adop.CodigoAnimal = cboxAnimales.SelectedItem.ToString();
                        }
                        _adop.IDUsuario = 1;
                        int resultado = _dla.ModificarAdoptante(_adop);
                        if (resultado == 1)
                        {
                            MessageBox.Show("Registro modificado correctamente", "Modificación Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            scope.Complete();
                        }
                        else
                        {
                            MessageBox.Show("Error al modificar registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        Limpiar();
                        errorProvider.Clear();
                    }
                }
                btnModificar.Enabled = false;
                txtCedula.Enabled = true;
                txtNombre.Enabled = true;
                cboxAnimales.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Error en la modificación del registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool BuscarAnimal() {
            Animal _animal = _dlan.BuscarAnimal(cboxAnimales.SelectedItem.ToString());
            if (_animal!= null)
            {
                string estado = _animal.Estado;
                if (estado == null)
                {
                    return false;
                }
                else {
                    return true;
                }
            }
            return false;
        }

        private bool VerificarCampos()
        {
            bool ok = true;
            if (this.txtCedula.Text.Trim() == "")
            {
                ok = false;
                errorProvider.SetError(txtCedula, "Debe ingresar una cédula");
            }
            if (this.txtNombre.Text.Trim() == "")
            {
                ok = false;
                errorProvider.SetError(txtNombre, "Debe ingresar el nombre del adoptante");
            }
            if (this.txtTelefono.Text.Trim() == "")
            {
                ok = false;
                errorProvider.SetError(txtTelefono, "Debe ingresar un número de teléfono");
            }
            if (this.txtCorreo.Text.Trim() == "")
            {
                ok = false;
                errorProvider.SetError(txtCorreo, "Debe ingresar un correo electrónico");
            }
            if (this.txtDomicilio.Text.Trim() == "")
            {
                ok = false;
                errorProvider.SetError(txtDomicilio, "Debe ingresar una dirección");
            }
            return ok;
        }

        private void Limpiar() {
            txtCedula.Clear();
            cboxAnimales.Refresh();
            txtCorreo.Clear();
            txtDomicilio.Clear();
            txtNombre.Clear();
            txtTelefono.Clear();
            rbCalifica.Focus();
            rbNoCalifica.Checked = false;
        }

        private void cboxAnimales_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboxAnimales.SelectedIndex != 0)
                {
                    List<Animal> _list = _dlan.CargarAnimales();
                    foreach (Animal animal in _list)
                    {
                        if (animal.CodigoAnimal.Equals(cboxAnimales.SelectedItem))
                        {
                            byte[] img = animal.Imagen;
                            MemoryStream ms = new MemoryStream(img);
                            Image imagen = Image.FromStream(ms);
                            pBoxFoto.Image = imagen;
                            lblEstadoAnimal.Text = animal.Estado;
                            if (animal.Estado == "Albergue")
                            {
                                btnRegistrar.Enabled = true;
                                MessageBox.Show("El animal se encuentra disponible para adopción", "Información", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                break;
                            }
                            else
                            {
                                btnRegistrar.Enabled = false;
                                MessageBox.Show("El animal NO se encuentra disponible para adopcion", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch 
            {
                MessageBox.Show("Debe seleccionar un código", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarCombo() {
            List<Animal> _animal = _dlan.CargarAnimales();
            cboxAnimales.Items.Insert(0, "Seleccionar");
            cboxAnimales.SelectedIndex = 0;
            foreach (Animal animal in _animal)
            {
                this.cboxAnimales.Items.Add(animal.CodigoAnimal);
            }
        }
    }
}
