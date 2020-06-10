using DataLogic;
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
    public partial class FrmEnvioCorreo : Form
    {
        
        DLCorreo _dlc = new DLCorreo();
        public FrmEnvioCorreo()
        {
            InitializeComponent();
            EstablecerRuta();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Dispose();
            new FrmInformacion().Show();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                MessageBox.Show(_dlc.EnviarCorreo(txtEmisor.Text, txtPass.Text, txtReceptor.Text, txtRuta.Text, txtMensaje.Text, txtAsunto.Text), "Mensaje enviado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Limpiar();
            }
        }

        private bool ValidarCampos()
        {
            bool ok = true;
            if (this.txtEmisor.Text.Trim().Equals(""))
            {
                ok = false;
                errorProvider.SetError(txtEmisor, "Debe ingresar un correo");
            }
            if (this.txtPass.Text.Trim().Equals(""))
            {
                ok = false;
                errorProvider.SetError(txtPass, "Debe ingresar la contraseña");
            }
            if (this.txtReceptor.Text.Trim().Equals(""))
            {
                ok = false;
                errorProvider.SetError(txtReceptor, "Debe ingresar un destinatario");
            }
            if (this.txtRuta.Text.Trim().Equals(""))
            {
                ok = false;
                errorProvider.SetError(txtRuta, "Debe seleccionar un archivo");
            }
            return ok;
        }

        private void EstablecerRuta() {
            txtRuta.Text = FrmInformacion.NAME;
        }

        private void Limpiar() {
            this.txtAsunto.Clear();
            this.txtEmisor.Clear();
            this.txtPass.Clear();
            this.txtReceptor.Clear();
            this.txtRuta.Clear();
            this.txtMensaje.Clear();
            FrmInformacion.NAME = "";
        }
    }
}
