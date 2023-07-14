using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    // Se declara una instancia  de negocio por si hay que aplicar  logica . Actualmente  devuelve la lista que se genero en la instacia
    // de datos.
    //Esto Aplica para todas  las clases de la capa entidad
    public class CN_ControlCabecera
    {
        private CD_ControlCabecera ObjCapaDatos = new CD_ControlCabecera();
        public List<ControlCabecera> Listar(string Muelle)
        {
            return ObjCapaDatos.Listar(Muelle);
        }
    }
}
