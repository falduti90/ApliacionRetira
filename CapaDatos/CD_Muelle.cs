using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Muelle
    {
        public List<Muelle> Listar()
        {


            List<Muelle> lista = new List<Muelle>();
            try
            {

                using (SqlConnection oconexion = new SqlConnection(Conexion.cn))
                {

                    SqlCommand cmd = new SqlCommand("_AC_SP_EntregasRetiraMuelles ", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add
                            (
                                new Muelle()
                                {
                                    IdMuelle=dr["MuelleUbicacion"].ToString(),
                                    Descripcion = dr["MuelleUbicacion"].ToString(),

                                }
                             );

                        }

                    }

                }
            }
            catch (Exception ex)
            {
                lista = new List<Muelle>();

            }

            return lista;
        }
    }
}
