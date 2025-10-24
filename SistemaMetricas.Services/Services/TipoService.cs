using SistemaMetricas.Services.Handlers;
using System.Data;

namespace SistemaMetricas.Services.Services
{
    public class TipoService
    {
        public DataTable GetTipos()
        {
            return SqliteHandler.GetDt("select * from tipos");
        }
    }
}
