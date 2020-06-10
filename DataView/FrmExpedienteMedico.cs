using DataLogic;
using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DataView
{
    public partial class FrmExpedienteMedico : Form
    {
        DLAnimal _dla = new DLAnimal();
        public FrmExpedienteMedico()
        {
            InitializeComponent();
            LlenarFecha();
            LlenarBox();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new FrmPrincipal().Show();
        }

        public bool BuscarAnimal()
        {
            Animal _animal = _dla.BuscarAnimal(cboxAnimales.SelectedItem.ToString());
            if (_animal != null)
            {
                string estado = _animal.Estado;
                if (estado == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            return false;
        }
        public void LlenarFecha()
        {
            string dateString = DateTime.Now.ToString("dd/MM/yyyy");
            txtFecha.Text = dateString;
        }

        public void LlenarBox() {
            List<Animal> _animal = _dla.CargarAnimales();
            cboxAnimales.Items.Insert(0, "Seleccionar");
            cboxAnimales.SelectedIndex = 0;
            foreach (Animal animal in _animal)
            {
                this.cboxAnimales.Items.Add(animal.CodigoAnimal);
            }
        }
    }
}
