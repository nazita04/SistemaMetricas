using Newtonsoft.Json;
using SistemaMetricas.Models;
using SistemaMetricas.Models.DTO;
using SistemaMetricas.Services.Handlers;
using System;
using System.Collections.Generic;
using System.Data;

namespace SistemaMetricas.Services.Services
{
    public class TicketService
    {
        public List<Tickets> GetTickets() 
        {
            string json = SqliteHandler.GetJson("select * from Tickets");
            List<Tickets> lista = JsonConvert.DeserializeObject< List<Tickets>>(json);
            return lista;
        }

        public string GetPendientesByArea(string pendiente)
        {
            return "";

        }

        public DataTable GetTicketsDt()
        {
            return SqliteHandler.GetDt("select * from Tickets");
        }

        public bool CreateTicket(TicketDTO ticket)
        {
            string insert = $"insert into Tickets values (null, " +
                $"'{ticket.Titulo}'," +
                $"'{ticket.Area}'," +
                $"'{ticket.Prioridad}'," +
                $"'{ticket.Tipo}'," +
                $"'{ticket.Descripcion}'," +
                $"'{DateTime.Now.ToString()}','','Rechazado')";

            return SqliteHandler.Exec(insert);
        }

        public bool EditarTicket(Tickets ticket)
        {
            string query = $"update Tickets set Descripcion = '{ticket.Descripcion}'," +
                           $" Estado = '{ticket.Estado}'," +
                           $" FechaAlta = '{DateTime.Now.ToString()}' where Id = {ticket.Id}";
            return SqliteHandler.Exec(query);
        }
    }
}
