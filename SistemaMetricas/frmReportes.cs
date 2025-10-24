using SistemaMetricas.Handlers;
using SistemaMetricas.Models;
using SistemaMetricas.Services;
using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace SistemaMetricas
{
    public partial class frmReportes : Form
    {
        DashBoardServices dashBoardServices = new DashBoardServices();

        public frmReportes()
        {
            InitializeComponent();
            LoadDashBoardData();
        }

        private void GetDashBoard()
        {
            DashBoard dashBoard = dashBoardServices.GetDashBoard(DatosGlobales.AreaUsuario);
            lblTotal.Text = $"Total: '{dashBoard.Total}'";
            btnPendientes.Text = $"Pendientes:  ('{dashBoard.Pendientes}')";
            btnEnCurso.Text = $"En Curso: ('{dashBoard.En_Curso}')";
            btnRechazados.Text = $"Rechazados: ('{dashBoard.Rechazados}')";
            btnTerminados.Text = $"Terminados: ('{dashBoard.Terminados}')";
        }

        public void LoadDashBoardData()
        {
            grdDatos.DataSource = dashBoardServices.GetDashBoardData("Area", "Estado");
        }

        private void frmReportes_Load(object sender, EventArgs e)
        {
            GetDashBoard();
            btnTotal.PerformClick();
        }

        private void grdDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPendientes_Click(object sender, EventArgs e)
        {
            grdDatos.DataSource = dashBoardServices.GetDashBoardData("Pendiente", DatosGlobales.AreaUsuario);
        }

        private void btnTerminados_Click(object sender, EventArgs e)
        {
            grdDatos.DataSource = dashBoardServices.GetDashBoardData("Terminado", DatosGlobales.AreaUsuario);
        }

        private void btnRechazados_Click(object sender, EventArgs e)
        {
            grdDatos.DataSource = dashBoardServices.GetDashBoardData("Rechazado", DatosGlobales.AreaUsuario);
        }

        private void btnEnCurso_Click(object sender, EventArgs e)
        {
            grdDatos.DataSource = dashBoardServices.GetDashBoardData("En_Curso", DatosGlobales.AreaUsuario);
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
                //llamo a un servicio para pasarle el texto qu estoy usando y el contenido 
                string clave = cmbFiltro.Text;
                string valor = txtFiltro.Text;

                grdDatos.DataSource = dashBoardServices.BuscarPorFiltro(clave, valor);
        }

        private void cmbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFiltro.Text == "Todos")
            {
                txtFiltro.Text = "";
                btnTotal.PerformClick();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            //capturamos en una variable la ruta relativa donde etsa el escritorio  de windows
            string escritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); //capturo la ruta de escritorio 
            string archivo = Path.Combine(escritorio, "ReporteHtml.html");
            ExportarHtml(grdDatos, archivo); //pasamos los datos de la grilla y del archivo 
        }


        public static void ExportarHtml(DataGridView datagrid, string path)
        {
            StringBuilder html = new StringBuilder(); // sirve para crear archivos de todo tipo 

            //le agrego lineas con la funcion append
            html.Append("<html>");
            html.Append("<head>");
            html.Append("<style>");
            html.Append("<html>");
            html.Append("table { width 100%; border-collapse: collapse; }");
            html.Append("th, td { border: 1px solid black; padding: 8px; text-aling: left; }");
            html.Append("th { background-color: #f2f2f2; }");
            html.Append("</style>");
            html.Append("</head>");
            html.Append("</body>");
            
            html.Append("<table>");
            html.Append("<tr>");
            foreach(DataGridViewColumn column in datagrid.Columns)  //columnas
            {
                html.AppendFormat("<th>{0}</th>", column.HeaderText);
            }
            html.Append("<tr>");

            foreach (DataGridViewRow row in datagrid.Rows) //filas
            {
                if (row.IsNewRow) continue;

                html.Append("<tr>");
                foreach (DataGridViewCell cell in row.Cells)
                {  //celdas

                    html.AppendFormat("<td>{0}</td> ", cell.Value?.ToString() ?? string.Empty); 
                }
                html.Append("</tr>");

            }

            // contenido del html 
            html.Append("</table>");
            html.Append("</body>");
            html.Append("</html>");

            File.WriteAllText(path, html.ToString());

            MessageBox.Show("Reporte exportado correctamente", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);    





        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening_1(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}
