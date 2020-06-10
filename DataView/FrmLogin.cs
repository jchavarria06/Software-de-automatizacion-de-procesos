using DataLogic;
using DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataView
{
    public partial class FrmLogin : Form
    {
        private FrmPrincipal frmPrincipal;
        DLUsuario _dlu = new DLUsuario();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            this.Log();
        }

        private void Restablecer() {
            txtUsuario.Focus();
            txtUsuario.Clear();
            txtContra.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar la aplicación?", "Cerrar aplicación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txtContra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                this.Log();
            }
        }

        private void Log() {
            try
            {
                Usuario _user = _dlu.BuscarUsuario(txtUsuario.Text.Trim());
                if (_user.IDUsuario == 0)
                {
                    if (txtContra.Text == "" && txtUsuario.Text == "")
                    {
                        MessageBox.Show("Verifique que no haya espacios vacíos", "Error al iniciar sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    else
                    {
                        if (txtUsuario.Text == "Admin" && txtContra.Text == "Admin")
                        {
                            Hide();
                            new FrmPrincipal().Show();
                        }
                        else
                        {
                            MessageBox.Show("El nombre de usuario y/o contraseña es incorrecto", "Error al iniciar sesión", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Restablecer();
                        }
                    }
                }
                else
                {
                    if (txtContra.Text == "" && txtUsuario.Text == "")
                    {
                        MessageBox.Show("Verifique que no haya espacios vacíos", "Error al iniciar sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    else
                    {
                        if (txtUsuario.Text == _user.Username && txtContra.Text == _user.Pass)
                        {
                            Hide();
                            frmPrincipal = new FrmPrincipal();
                            string s = _user.NombreCompleto;
                            frmPrincipal.setUsuario(_user);
                            frmPrincipal.Show();
                        }
                        else
                        {
                            MessageBox.Show("El nombre de usuario y/o contraseña es incorrecto", "Error al iniciar sesión", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Restablecer();
                        }
                    }
                }

            }
            catch
            {
                MessageBox.Show("Contacte con el desarrollador para verificar el problema", "Error al iniciar sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
