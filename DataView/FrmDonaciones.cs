using System;
using DataLogic;
using System.Windows.Forms;
using System.Data;
using DataModel;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace DataView
{
    public partial class FrmDonaciones : Form
    {
        DLAnimal _dlan = new DLAnimal();
        DLDonacion _dld = new DLDonacion();
        Donacion _dn;
        Animal animal;
        List<Animal> _listAnimal;

        Usuario usuario;
        FrmPrincipal frmPrincipal;
        public FrmDonaciones(Usuario us,FrmPrincipal frmPrincipal)
        {
            InitializeComponent();
            _listAnimal = _dlan.CargarAnimales();
            fillDDLCodigos();
            setUsuario(us);
            this.frmPrincipal = frmPrincipal;
        }
        private void setUsuario(Usuario usuario)
        {
            this.usuario = usuario;
        }
        private void fillDDLCodigos()
        {
            List<Animal> _list = _listAnimal;
            cboxAnimales.Items.Insert(0, "Seleccione el destinatario");

            cboxAnimales.Items.Insert(1,"Donación General");
            cboxAnimales.SelectedIndex = 0;
            foreach (Animal animal in _list)
            {
                this.cboxAnimales.Items.Add(animal.CodigoAnimal);

            }
            cboxAnimales.Items.Remove("0");

        }
        private Image extraerImg(byte[] img)
        {

            MemoryStream ms = new MemoryStream(img);
            Image imagen = Image.FromStream(ms);
            return imagen;
        }
        private int GetAnimal(string id)
        {
            List<Animal> _list = _listAnimal;
            int verifica = 0;
            foreach (Animal _animal in _list)
            {
                if (_animal.CodigoAnimal.Equals(id))
                {
                   animal=_animal;
                    verifica = 1;
                }
            }
            
            return verifica;
        }
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmPrincipal.Show();
            this.Dispose();
        }

        private void cboxAnimales_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cboxAnimales.SelectedIndex != 0)
            {

                if (cboxAnimales.SelectedItem.ToString() == "Donación General")
                {
                    btnRegistrar.Enabled = true;
                    LlenarGrid("0");
                }
                else
                {
                    if (GetAnimal(cboxAnimales.SelectedItem.ToString())!=0)
                    {

                        pBoxFoto.Image = extraerImg(animal.Imagen);
                        LlenarGrid (animal.CodigoAnimal);

                        if (animal.Estado == "Albergue")
                        {
                            btnRegistrar.Enabled = true;
                           
                        }
                        else
                        {
                            btnRegistrar.Enabled = false;
                            MessageBox.Show("El animal NO se encuentra disponible para donación", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (verficar())
            {
                DialogResult resultado = MessageBox.Show("Desea registrar la donancion con la siguiente información:\n" + "Código:" + cboxAnimales.SelectedItem.ToString() + "\nMonto:" + nMonto.Value.ToString(), "FRMDonaciones", MessageBoxButtons.YesNoCancel);

                if (resultado == DialogResult.Yes)
                {
                    registrar();
                    LlenarGrid(cboxAnimales.SelectedItem.ToString());


                }
                if (resultado == DialogResult.No)
                {
                    clear(true);
                }
            }
            else {
                MessageBox.Show("Seleccione un código", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void clear(bool  v)
        {
            if (v)
            {
                cboxAnimales.SelectedIndex = 0;
                nMonto.Value = 0;

            }
            else { 
                nMonto.Value = 0;
            }
        }
        public bool verficar()
        {
            bool ok=false;

            if (cboxAnimales.SelectedIndex != 0)
            {
                ok = true;
            }
            return ok;
        }

        public void LlenarGrid(string id)
        {
            GVMontos.DataSource = _dld.ConsultarDonacionesID(id);
            MontoT(_dld.ConsultarDonacionesID(id));
        }
        public void MontoT(List<Donacion> _dn)
        {
            decimal sumatoria = 0;
            foreach (Donacion dn in _dn)
            {
                sumatoria += dn.monto;
            }
            txtMontoT.Text = sumatoria.ToString();
        }
        public DateTime LlenarFecha()
        {
            string fecha = DateTime.Now.ToString("dd/MM/yyyy");
            return DateTime.Parse(fecha);
        }
        private void registrar()
        {
            _dn = new Donacion();
            _dn.monto = Convert.ToDecimal(nMonto.Value.ToString());
            _dn.fecha = LlenarFecha();
            if (cboxAnimales.SelectedIndex == 0)
            {
                _dn.codigoAnimal = cboxAnimales.SelectedIndex.ToString();

            }
            else
            {
                _dn.codigoAnimal = cboxAnimales.SelectedItem.ToString();

            }
            _dn.idUsuario = usuario.IDUsuario;
            int resultado = _dld.AgregarDonacion(_dn);
            if (resultado == 1)
            {
                clear(false);
                MessageBox.Show("Registro agregado correctamente", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            else
            {
                clear(false);
                MessageBox.Show("Error al crear registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void nMonto_Leave(object sender, EventArgs e)
        {
            if (nMonto.Value == nMonto.Maximum)
            { 
            MessageBox.Show("El monto a almacenar no puede ser mayor a "+nMonto.Maximum.ToString(), "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }
    }
}
