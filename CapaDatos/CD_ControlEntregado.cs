using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_ControlEntregado
    {
        public List<ControlEntregadas> Listar(string Muelle)
        {


            List<ControlEntregadas> lista = new List<ControlEntregadas>();
            try
            {

                using (SqlConnection oconexion = new SqlConnection(Conexion.cn))
                {

                    SqlCommand cmd = new SqlCommand("_AC_SP_EntregasRetiraControlEntregadas", oconexion);
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
                                new ControlEntregadas()
                                {
                                    IdMaterial = dr["IdMaterial"].ToString(),
                                    Descripcion = dr["DescripcionMaterial"].ToString(),
                                    CantidadEntregada = dr["CantidadEntregada"].ToString()

                                }
                             );

                        }

                    }

                }
            }
            catch (Exception ex)
            {
                lista = new List<ControlEntregadas>();

            }

            return lista;
        }
    }
}
