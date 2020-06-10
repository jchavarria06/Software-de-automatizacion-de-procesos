using DataLogic;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace DataView
{
    public partial class FrmReportes : Form
    {
        DLReporte _dlr = new DLReporte();
        public FrmReportes()
        {
            InitializeComponent();
            LlenarBoxEspecies();
        }

        public void LlenarBoxEspecies()
        {
            cBoxTipoAnimal.Items.Insert(0, "Seleccionar");
            cBoxTipoAnimal.SelectedIndex = 0;
            cBoxTipoAnimal.Items.Add("Perro");
            cBoxTipoAnimal.Items.Add("Gato");
            cBoxTipoAnimal.Items.Add("Halcón");
            cBoxTipoAnimal.Items.Add("Coballo");
            cBoxTipoAnimal.Items.Add("Paloma");
            cBoxTipoAnimal.Items.Add("Tortuga");
            cBoxTipoAnimal.Items.Add("Garrobo");
            cBoxTipoAnimal.Items.Add("Conejo");
            cBoxTipoAnimal.Items.Add("Ardilla");
            cBoxTipoAnimal.Items.Add("Otro");
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new FrmPrincipal().Show();
        }

        private void rbCodigo_CheckedChanged(object sender, EventArgs e)
        {
            LlenarGridPorCod(txtCodigo.Text);
        }

        private void rbFechaIngreso_CheckedChanged(object sender, EventArgs e)
        {
            LlenarGridPorFecha();
        }

        private void rbTipoAnimal_CheckedChanged(object sender, EventArgs e)
        {
            LlenarGridPorEspecie();
        }

        private void rbConsultaGeneral_CheckedChanged(object sender, EventArgs e)
        {
            LlenarGridGeneral();
        }

        private void LlenarGridPorCod(string cod)
        {
            
            try
            {
                
                GVReportes.DataSource = _dlr.LlenarGridPorCod(txtCodigo.Text);
                GVReportes.Refresh();
                
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar tabla de consulta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LlenarGridPorFecha()
        {
            
            try
            {
                GVReportes.DataSource = _dlr.LlenarGridPorFecha();
                GVReportes.Refresh();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar tabla de consulta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LlenarGridPorEspecie()
        {
            
            try
            {
                GVReportes.DataSource = _dlr.LlenarGridPorEspecie(cBoxTipoAnimal.SelectedItem.ToString());
                GVReportes.Refresh();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar tabla de consulta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LlenarGridGeneral()
        {
            
            try
            {
                GVReportes.DataSource = _dlr.LlenarGridGeneral();
                GVReportes.Refresh();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar tabla de consulta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            PrintDocument doc = new PrintDocument();
            doc.DefaultPageSettings.Landscape = true;
            doc.PrinterSettings.PrinterName = "Microsoft Print to PDF";

            PrintPreviewDialog ppd = new PrintPreviewDialog { Document = doc };
            ((Form)ppd).WindowState = FormWindowState.Maximized;

            doc.PrintPage += delegate (object ev, PrintPageEventArgs ep)
            {
                const int DGV_ALTO = 35;
                int left = ep.MarginBounds.Left, top = ep.MarginBounds.Top;

                foreach (DataGridViewColumn col in GVReportes.Columns)
                {
                    ep.Graphics.DrawString(col.HeaderText, new Font("Segoe UI", 16, FontStyle.Bold), Brushes.Black, left, top);
                    left += col.Width;

                    if (col.Index < GVReportes.ColumnCount - 1)
                        ep.Graphics.DrawLine(Pens.Gray, left - 5, top, left - 5, top + 43 + (GVReportes.RowCount - 1) * DGV_ALTO);
                }
                left = ep.MarginBounds.Left;
                ep.Graphics.FillRectangle(Brushes.Black, left, top + 40, ep.MarginBounds.Right - left, 3);
                top += 43;

                foreach (DataGridViewRow row in GVReportes.Rows)
                {
                    if (row.Index == GVReportes.RowCount - 1) break;
                    left = ep.MarginBounds.Left;
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        ep.Graphics.DrawString(Convert.ToString(cell.Value), new Font("Segoe UI", 13), Brushes.Black, left, top + 4);
                        left += cell.OwningColumn.Width;
                    }
                    top += DGV_ALTO;
                    ep.Graphics.DrawLine(Pens.Gray, ep.MarginBounds.Left, top, ep.MarginBounds.Right, top);
                }
            };
            ppd.ShowDialog();
        }
    }
}
