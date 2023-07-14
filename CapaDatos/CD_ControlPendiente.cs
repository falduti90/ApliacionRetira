using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CD_ControlPendiente
    {
        //Funcion que devuelve una lista con todos los articulos pendiente de entrega , esto varia dependiendo del remito.
        //Esta lista llena la parte izquirda de la tabla 'Pendietes'.
        public List<ControlPendientes> Listar(string Muelle)
        {
  
            
            List<ControlPendientes> lista = new List<ControlPendientes>();
            try
            {
                
                using (SqlConnection oconexion = new SqlConnection(Conexion.cn))
                {

                    SqlCommand cmd = new SqlCommand("_AC_SP_EntregasRetiraControlPendientes", oconexion);
                    cmd.Parameters.AddWithValue("IdMuelle ", Muelle.ToString());
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add
                            (
                                new ControlPendientes()
                                {
                                    IdMaterial = dr["IdMaterial"].ToString(),
                                    Descripcion = dr["DescripcionMaterial"].ToString(),
                                    CantidadPendiente = Convert.ToInt32(dr["CantidadPendiente"]),
                                }
                             );

                        }

                    }

                }
            }
            catch(Exception ex)
            {
                lista = new List<ControlPendientes>();

            }

            return lista;
        }
    }
}
