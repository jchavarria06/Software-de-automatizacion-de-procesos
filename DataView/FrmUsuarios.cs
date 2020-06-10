using DataLogic;
using DataModel;
using System;
using System.Linq;
using System.Transactions;
using System.Windows.Forms;

namespace DataView
{
    public partial class FrmUsuarios : Form
    {
        Usuario _usuario = new Usuario();
        DLUsuario _dlu = new DLUsuario();
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new FrmPrincipal().Show();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new FrmConsultaUsuarios().Show();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    if (VerificarCampos())
                    {
                        _usuario.NombreCompleto = txtNombre.Text;
                        _usuario.Username = txtNombreUsuario.Text;
                        _usuario.Cedula = txtCedula.Text;
                        _usuario.Correo = txtCorreo.Text;
                        _usuario.Pass = txtContra.Text;
                        int resultado = _dlu.AgregarUsuario(_usuario);
                        if (resultado == 1)
                        {
                            MessageBox.Show("Registro agregado correctamente", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            scope.Complete();
                        }
                        else {
                            MessageBox.Show("Error al crear registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        Limpiar();
                        errorProvider.Clear();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error al crear el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Limpiar()
        {
            txtCedula.Clear();
            txtContra.Clear();
            txtCorreo.Clear();
            txtNombre.Clear();
            txtNombreUsuario.Clear();
            txtNombre.Focus();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    if (VerificarCampos())
                    {
                        _usuario.NombreCompleto = txtNombre.Text;
                        _usuario.Username = txtNombreUsuario.Text;
                        _usuario.Cedula = txtCedula.Text;
                        _usuario.Correo = txtCorreo.Text;
                        _usuario.Pass = txtContra.Text;
                        int resultado = _dlu.ModificarUsuario(_usuario);
                        if (resultado == 1)
                        {
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
                }
                btnRegistrar.Enabled = true;
                btnModificar.Enabled = false;
                txtNombre.Enabled = true;
                txtCedula.Enabled = true;
                txtNombreUsuario.Enabled = true;
                txtCorreo.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Error en la modificación del registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombreUsuario.Text.Trim() == "")
                {
                    errorProvider.SetError(txtNombreUsuario, "Debe ingresar un nombre de usuario");
                }
                else {
                    Usuario _user = _dlu.BuscarUsuario(txtNombreUsuario.Text);
                    if (_user.IDUsuario != 0)
                    {
                        txtNombre.Text = _user.NombreCompleto;
                        txtCedula.Text = _user.Cedula;
                        txtContra.Text = _user.Pass;
                        txtCorreo.Text = _user.Correo;
                        btnRegistrar.Enabled = false;
                        btnModificar.Enabled = true;
                        txtNombre.Enabled = false;
                        txtCedula.Enabled = false;
                        txtNombreUsuario.Enabled = false;
                        txtCorreo.Enabled = false;
                    }
                    else {
                        MessageBox.Show("El nombre de usuario no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    errorProvider.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No hay registros"+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool VerificarCampos()
        {
            bool ok = true;
            if (this.txtCedula.Text.Trim() == "")
            {
                ok = false;
                errorProvider.SetError(txtCedula, "Debe ingresar una cédula");
            }
            if (this.txtContra.Text.Trim() == "")
            {
                ok = false;
                errorProvider.SetError(txtContra, "Debe ingresar una contraseña");
            }
            if (this.txtCorreo.Text.Trim() == "")
            {
                ok = false;
                errorProvider.SetError(txtCorreo, "Debe ingresar un correo");
            }
            if (this.txtNombre.Text.Trim() == "")
            {
                ok = false;
                errorProvider.SetError(txtNombre, "Debe ingresar un nombre");
            }
            if(this.txtNombreUsuario.Text.Trim() == "")
            {
                ok = false;
                errorProvider.SetError(txtNombreUsuario, "Debe ingresar un nombre de usuario");
            }
            return ok;
        }
    }
}

        

