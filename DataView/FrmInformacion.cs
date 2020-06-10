using DataLogic;
using DataModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DataView
{
    public partial class FrmInformacion : Form
    {
        public OpenFileDialog examinar = new OpenFileDialog();
        public static string NAME;
        DLInformacion _dli = new DLInformacion();
        Archivo _archivo = new Archivo();
        public FrmInformacion()
        {
            InitializeComponent();
            this.CargarNombres();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new FrmPrincipal().Show();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                examinar.Filter = "Archivo PDF|*.pdf";
                DialogResult res = examinar.ShowDialog();
                if (res == DialogResult.OK)
                    _archivo.Nombre = examinar.FileName;
                axAcroPDF.src = examinar.FileName;
                FileStream stream = new FileStream(_archivo.Nombre, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(stream);
                FileInfo fi = new FileInfo(_archivo.Nombre);
                byte[] binData = new byte[stream.Length];
                stream.Read(binData, 0, Convert.ToInt32(stream.Length));
                _archivo.Imagen = binData;
                
                int result = _dli.AgregarArchivo(_archivo);
                if (result == 1)
                {
                    MessageBox.Show("Registro agregado correctamente", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch
            {
                MessageBox.Show("Error al cargar archivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            Dispose();
            new FrmEnvioCorreo().Show();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                examinar.Filter = "Archivo PDF|*.pdf";
                DialogResult res = examinar.ShowDialog();
                if (res == DialogResult.OK)
                axAcroPDF.src = examinar.FileName;
                txtNombreArch.Text = examinar.FileName;
                NAME = examinar.FileName;
            }
            catch
            {
                MessageBox.Show("Error al cargar archivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboxArchivos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Archivo arch;
            try
            {
                arch = _dli.ObtenerArchivo(cboxArchivos.SelectedItem.ToString().Trim());
                if (arch.ID != 0)
                {
                    txtNombreArch.Text = arch.Nombre;
                    string directorio = System.AppDomain.CurrentDomain.BaseDirectory + "temp.pdf";
                    ConvertirArchivo(arch.Imagen, directorio);
                    axAcroPDF.src = directorio;
                    NAME = arch.Nombre;
                }
            }
            catch 
            {
                MessageBox.Show("Error al cargar el archivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConvertirArchivo(byte[] pdf, string dire) {
            try
            {
                int size = pdf.Length;
                FileStream stream = new FileStream(dire, FileMode.OpenOrCreate, FileAccess.Write);
                stream.Write(pdf, 0, size);
                stream.Close();
            }
            catch
            {
                throw;
            }
        }

        private void CargarNombres() {
            List<Archivo> archivos = _dli.ConsultarArchivos();
            cboxArchivos.Items.Insert(0, "Seleccione un archivo");
            cboxArchivos.SelectedIndex = 0;
            foreach (Archivo arch in archivos)
            {
                cboxArchivos.Items.Add(arch.Nombre);
            }
        }
    }
}
