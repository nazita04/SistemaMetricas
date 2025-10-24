using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMetricas.Models
{
    public class FuncRol
    {
        public int RolId { get; set; }
        public int FuncId { get; set; }
        public Roles Rol { get; set; }
        public Func Funcion { get; set; }
    }
}
