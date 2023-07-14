using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;


namespace CapaNegocio
{
    public class CN_ControlPendientes
    {
        private CD_ControlPendiente ObjCapaDatos = new CD_ControlPendiente();

        public List<ControlPendientes> Listar(string Muelle)
        {
            return ObjCapaDatos.Listar(Muelle);
        }
    }
}
