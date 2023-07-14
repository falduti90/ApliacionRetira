using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CD_ControlCabecera
    {
        //funcion que devuelve una lista con los datos de la cabecera .  Devuelve  3  campos que se usan para  mostrar datos.
        //Esto quedo definido para separar los datos  de la cabecera 
        public List<ControlCabecera> Listar(string Muelle)
        {


            List<ControlCabecera> lista = new List<ControlCabecera>();
            try
            {

                using (SqlConnection oconexion = new SqlConnection(Conexion.cn))
                {

                    SqlCommand cmd = new SqlCommand("_AC_SP_EntregasRetiraControlCabecera", oconexion);
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
                                new ControlCabecera()
                                {
                                    IdRemito = dr["IdRemito"].ToString(),
                                    IdCiente= dr["IdCliente"].ToString(),
                                    Descripcion = dr["DescripcionCliente"].ToString()
                           
                                }
                             );

                        }

                    }

                }
            }
            catch (Exception ex)
            {
                lista = new List<ControlCabecera>();

            }

            return lista;
        }
    }
}
