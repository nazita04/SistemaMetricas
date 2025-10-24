using SistemaMetricas.Models;
using SistemaMetricas.Services.Services;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaMetricas
{
    public partial class frmTickets : Form
    {
        TicketService ticketService = new TicketService();
        string idUpdate = string.Empty;

        public frmTickets()
        {
            InitializeComponent();
        }

        private void grdTickets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = grdTickets.Rows[e.RowIndex];
            string id = row.Cells["Id"].Value.ToString();
            idUpdate = id;
            string descripcion = row.Cells["Descripcion"].Value.ToString();
            string estado = row.Cells["Estado"].Value.ToString();

            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                pnlPanel.Visible = true;
                txtDescripcion.Text = descripcion;
                lblEstado.Visible = true;
                cmbEstado.Visible = true;
                cmdModificarTicket.Text = "Actualizar Ticket";
            }
        }

        private void cmdCancelar_Click(object sender, System.EventArgs e)
        {
            pnlPanel.Visible = false;
            lblEstado.Visible = false;
            cmbEstado.Visible = false;

        }

        private void frmTickets_Load(object sender, System.EventArgs e)
        {
            GetTickets();
        }

        private void GetTickets()
        {
            grdTickets.DataSource = ticketService.GetTickets();
        }

        private void cmdModificarTicket_Click(object sender, System.EventArgs e)
        {
            bool respuesta = false;
            Tickets ticketUpdate = new Tickets();
            ticketUpdate.Id = Convert.ToInt32(idUpdate);
            ticketUpdate.Descripcion = txtDescripcion.Text;
            ticketUpdate.Estado = cmbEstado.Text;
            respuesta = ticketService.EditarTicket(ticketUpdate);

            if (respuesta)
            {
                GetTickets();
                pnlPanel.Visible = false;
            }
            else
            {
                MessageBox.Show("Ocurrio un problema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void grdDatos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                string estado = grdTickets.Rows[e.RowIndex].Cells["Estado"].Value.ToString();

                switch (estado.ToLower())
                {
                    case "terminado":
                        grdTickets.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Green;
                        break;
                    case "pendiente":
                        grdTickets.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Yellow;
                        break;
                    case "rechazado":
                        grdTickets.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Red;
                        break;
                    default:
                        break;
                }

            }

        }
    }

}
