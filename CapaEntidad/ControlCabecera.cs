using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{

    //Clase Entidad para  poder capturar los datos de la  Data Base
    public class ControlCabecera
    {
        public string IdRemito { get; set; }
        public string IdCiente { get; set; }
        public string Descripcion { get; set; }
    }
}
