using Newtonsoft.Json;
using SistemaMetricas.Models;
using SistemaMetricas.Services.Handlers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMetricas.Services
{
    public class DashBoardServices
    {
        public DashBoard GetDashBoard(string area)  
        {
            DashBoard dashboard = new DashBoard();
            
            dashboard.Pendientes = SqliteHandler.GetScalar($"select count  (*) as Total from tickets where Area = '{area}' and Estado = 'Pendiente'");
            dashboard.En_Curso = SqliteHandler.GetScalar($"select count  (*) as Total from tickets where Area = '{area}' and Estado = 'En_Curso'");
            dashboard.Terminados = SqliteHandler.GetScalar($"select count  (*) as Total from tickets where Area = '{area}' and Estado = 'Terminado'");
            dashboard.Rechazados = SqliteHandler.GetScalar($"select count  (*) as Total from tickets where Area = '{area}' and Estado = 'Rechazado'");
            dashboard.Total = SqliteHandler.GetScalar($"select count  (*) as Total from tickets where Area = '{area}'");
            return dashboard;   
        }

        public DataTable GetDashBoardData(string estado, string area)
        {
            return SqliteHandler.GetDt($"select * from Tickets where Estado = '{estado}' and Area = '{area}'");
        }

        public DataTable BuscarPorFiltro(string clave, string valor) //le paso de parametros la columna y el valor

        {
            string query = $"select * from Tickets where {clave} like '%{valor}%'";
            return SqliteHandler.GetDt(query);

        }
    }
}
