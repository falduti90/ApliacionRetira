using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_ControlCabecera
    {
        private CD_ControlCabecera ObjCapaDatos = new CD_ControlCabecera();

        public List<ControlCabecera> Listar(string Muelle)
        {
            return ObjCapaDatos.Listar(Muelle);
        }
    }
}
