using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_ControlEntregadas
    {
        private CD_ControlEntregado ObjCapaDatos = new CD_ControlEntregado();

        public List<ControlEntregadas> Listar(string Muelle)
        {
            return ObjCapaDatos.Listar(Muelle);
        }

    }
}
