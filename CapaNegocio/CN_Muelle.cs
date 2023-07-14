using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Muelle
    {
        private CD_Muelle ObjCapaDatos = new CD_Muelle();

        public List<Muelle> Listar()
        {
            return ObjCapaDatos.Listar();
        }
    }
}
