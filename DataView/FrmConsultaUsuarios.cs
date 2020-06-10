using DataLogic;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;

namespace DataView
{
    public partial class FrmConsultaUsuarios : Form
    {
        DLUsuario _dlu = new DLUsuario();
        public FrmConsultaUsuarios()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new FrmUsuarios().Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            LlenarGridPorCed(txtCedula.Text);
        }

        public void LlenarGridPorCed(string ced)
        {
            try { 
                GVUsuarios.DataSource = _dlu.BuscarUsuarioCed(txtCedula.Text.Trim());
            }
            catch
            {
                MessageBox.Show("Error al cargar tabla de consulta ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LlenarGridGeneral()
        {
            try
            {
                GVUsuarios.DataSource = _dlu.ConsultarUsuarios();
            }
            catch
            {
                MessageBox.Show("Error al cargar tabla de consulta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbCedula_CheckedChanged(object sender, EventArgs e)
        {
            LlenarGridPorCed(txtCedula.Text);
        }

        private void rbGeneral_CheckedChanged(object sender, EventArgs e)
        {
            LlenarGridGeneral();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            PrintDocument doc = new PrintDocument();
            doc.DefaultPageSettings.Landscape = false;
            doc.PrinterSettings.PrinterName = "Microsoft Print to PDF";

            PrintPreviewDialog ppd = new PrintPreviewDialog { Document = doc };
            ((Form)ppd).WindowState = FormWindowState.Maximized;

            doc.PrintPage += delegate (object ev, PrintPageEventArgs ep)
            {
                const int DGV_ALTO = 35;
                int left = ep.MarginBounds.Left, top = ep.MarginBounds.Top, right = ep.MarginBounds.Right;

                foreach (DataGridViewColumn col in GVUsuarios.Columns)
                {
                    ep.Graphics.DrawString(col.HeaderText, new Font("Segoe UI", 16, FontStyle.Bold), Brushes.Black, left, top);
                    left += col.Width;

                    if (col.Index < GVUsuarios.ColumnCount - 1)
                        ep.Graphics.DrawLine(Pens.Gray, left - 5, top, left - 5, top + 43 + (GVUsuarios.RowCount - 1) * DGV_ALTO);
                }
                left = ep.MarginBounds.Left;
                ep.Graphics.FillRectangle(Brushes.Black, left, top + 40, ep.MarginBounds.Right - left, 3);
                top += 43;

                foreach (DataGridViewRow row in GVUsuarios.Rows)
                {
                    if (row.Index == GVUsuarios.RowCount - 1) break;
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
