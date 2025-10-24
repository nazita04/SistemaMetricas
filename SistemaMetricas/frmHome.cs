using Sistema_de_Ventas;
using SistemaMetricas.Handlers;
using SistemaMetricas.Models;
using SistemaMetricas.Services.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Timer = System.Timers.Timer;


namespace SistemaMetricas
{
    public partial class frmHome : Form
    {
        AreaService areaService = new AreaService();
        SecurityService securityService = new SecurityService();
        TicketService ticketService = new TicketService();

        public frmHome()
        {
            InitializeComponent();
        }

        Timer timer;
        private void frmHome_Load(object sender, EventArgs e)
        {
            string rol = areaService.GetRolByLogin((DatosGlobales.UsuarioLogeado));

            List<Func> lista = securityService.GetFuncRolList(rol);

            for (int i = 0; i < lista.Count; i++)
            {
                switch (lista[i].FuncId)
                {
                    case 1:
                        tsbAreas.Visible = true;
                        break;
                    case 2:
                        tsbTipos.Visible = true;
                        break;
                    case 3:
                        tbsTickets.Visible = true;
                        break;
                    case 4: 
                        tsbNuevoTicket.Visible = true;
                        break;
                    case 5:
                        tbsReportes.Visible = true;
                        break;
                    case 6:
                        tsbUsuarios.Visible = true;
                        break;


                }
            }


            lblUser.Text = "Usuario Logeado: " + DatosGlobales.UsuarioLogeado + "Area" + DatosGlobales.AreaUsuario;
            tsbAreas.PerformClick();

            timer = new Timer(10000);
            timer.Elapsed += OnTimeEvent;
            timer.AutoReset = true;
            timer.Enabled = true; 
        }

        private void OnTimeEvent(object sender, EventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                MessageBox.Show(tbsReportes.Text);
                ticketService.GetPendientesByArea(DatosGlobales.AreaUsuario);
                tbsReportes.Text = $"Reportes";
            });
        }


        private void tsbAreas_Click(object sender, EventArgs e)
        {
            frmAreas areas = new frmAreas();
            LlenarContenedor(areas);
        }
        private void LlenarContenedor(Form form)
        {
            pnlContainer.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(form);
            form.Show();
        }

        private void tsbTipos_Click(object sender, EventArgs e)
        {
            frmBuilder tipos = new frmBuilder("Tipos", "Administracion de Tipos"); 
            LlenarContenedor(tipos);
        }

        private void tsbNuevoTicket_Click(object sender, EventArgs e)
        {//creamos un objeto de la nueva pantalla
            frmNuevoTickets nuevoTickets = new frmNuevoTickets();
            LlenarContenedor(nuevoTickets);


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tsbTickets_Click(object sender, EventArgs e)
        {
            frmTickets tickets = new frmTickets();
            LlenarContenedor(tickets);
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        
        private void tsbReportes_Click(object sender, EventArgs e)
        {
            frmReportes reportes = new frmReportes();
            LlenarContenedor(reportes);


        }

        private void tsbUsuarios_Click(object sender, EventArgs e)
        {
            frmUsuarios usuarios = new frmUsuarios();
            LlenarContenedor(usuarios);
        }
    }
}
