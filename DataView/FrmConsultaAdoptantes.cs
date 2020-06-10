using DataLogic;
using System;

using System.Windows.Forms;

namespace DataView
{
    public partial class FrmConsultaAdoptantes : Form
    {
        DLAdoptante _dla = new DLAdoptante();
        public FrmConsultaAdoptantes()
        {
            InitializeComponent();
            CargarTabla();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new FrmRegistroAdoptantes().Show();
        }

        private void CargarTabla() {
            GVAdoptantes.DataSource = _dla.ConsultarAdoptantes();
            GVAdoptantes.Refresh();
        }
    }
}
