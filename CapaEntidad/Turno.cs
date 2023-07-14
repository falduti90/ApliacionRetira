using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Turno
    {
        public string IdTurno { get; set; }
        public string RazonSocial { get; set; }
        public DateTime Fecha { get; set; }
        public string Estado { get; set; }
    }
}
