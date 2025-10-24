using BotChat.Servicios;
using ChatBot.Models;
using SistemaMetricas.Models.DTO;
using SistemaMetricas.Services.Services;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaMetricas
{
    public partial class frmNuevoTickets : Form
    {
        TicketService ticketService = new TicketService();
        AreaService areaService = new AreaService();
        TipoService tipoService = new TipoService();


        public frmNuevoTickets()
        {
            InitializeComponent();
            getAreas();
            getTipos();
        }

        private void getAreas()
        {
            cmbAreas.DataSource = areaService.GetAreas();
            //lo que la persona ve en la lista desplegabkle
            cmbAreas.DisplayMember = "Area";
            //el valor de la clave            //se esribe lo mismo en ambas para que el valor de la key del combo me traifga las areas que quiero
            cmbAreas.ValueMember = "Area";
        }

        private void getTipos()
        {
            cmbTipos.DataSource = tipoService.GetTipos();
            //lo que la persona ve en la lista desplegabkle
            cmbTipos.DisplayMember = "Tipo";
            //el valor de la clave            //se esribe lo mismo en ambas para que el valor de la key del combo me traifga las areas que quiero
            cmbTipos.ValueMember = "Tipo";
        }


        private void CreateTicket()
        {
            if (txtTitulo.Text == "" || txtDescripcion.Text == "") {
                lblAlert.Text = "Los datos son obligatorios";
                lblAlert.BackColor = Color.Crimson;
                return;
            }


            TicketDTO nuevoTicket = new TicketDTO();

            //creo los objetos
            nuevoTicket.Titulo = txtTitulo.Text; //le asigno los valores de input
            nuevoTicket.Area = cmbAreas.Text;
            nuevoTicket.Prioridad = cmbPrioridad.Text;
            nuevoTicket.Tipo = cmbTipos.Text;
            nuevoTicket.Descripcion = txtDescripcion.Text;
            bool respuesta = ticketService.CreateTicket(nuevoTicket);


            if (respuesta)
            {
                lblAlert.Text = "Ticket creado correctamente";
                lblAlert.ForeColor = Color.ForestGreen;
            }
            else
            {
                lblAlert.Text = "la operacion no puedo completarse";
                lblAlert.ForeColor = Color.Crimson;

            }


        }

        private void frmNuevoTickets_Load(object sender, EventArgs e)
        {
            getAreas();
            getTipos();
        }

        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {
            if (txtTitulo.Text != "")
            {
                lblAlert.Text = txtTitulo.Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateTicket();
        }

        private void cmbAreas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbTipos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string userInput = txtInput.Text;

            BotChatResponse response = BotChatService.Predict("Bot1", userInput);

            chatTextBox.AppendText(Environment.NewLine + "Chatbot:" + response.Respuesta);

            txtInput.Text = "";
        }
    }
}
