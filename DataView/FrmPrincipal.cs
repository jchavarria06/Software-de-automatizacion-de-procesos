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
    public partial class FrmPrincipal : Form
    {
        Usuario us;
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        public void setUsuario(Usuario us) {
            this.us = us;
        }

        public Usuario getUsuario() {
            return us;
        }

        private void registroAnimalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
            new FrmRegistroAnimal().Show();
        }

        private void registroAdoptanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
            new FrmRegistroAdoptantes().Show();
        }

        private void registroUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
            new FrmUsuarios().Show();
        }

        private void expedienteMedicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
            new FrmExpedienteMedico().Show();
        }

        private void expedienteDeRescatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
            new FrmRescates().Show();
        }

        private void donacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            new FrmDonaciones(getUsuario(),this).Show();
        }

        private void archivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
            new FrmInformacion().Show();
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
            new FrmReportes().Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar sesión?", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
                new FrmLogin().Show();
            }
        }
    }
}
