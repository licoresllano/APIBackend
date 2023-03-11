using ENTIDADES;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class clienteDAL
    {
        SqlConnection conn = new SqlConnection();
        public List<clientes> obtenerClientes()
        {
            try
            {
                conn = ConectionDAL.Singleton.ConnetionFactory;
                conn.Open();
                SqlCommand cmd = new SqlCommand("[dbo].[ObtenerClientes]");
                cmd.CommandType = CommandType.StoredProcedure;

                DataTable dt = new DataTable(); 
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);


                List<clientes> listaCliente = new List<clientes>();

                listaCliente = (from DataRow dr in dt.Rows

                                select new clientes
                                {
                                     nombre = dr["nombre"].ToString(),
                                     apellidos = dr["apellidos"].ToString(),
                                     direccion = dr["direccion"].ToString(),
                                     identificacion = dr["identificacion"].ToString(),
                                    email = dr["email"].ToString(),
                                    celular = dr["celular"].ToString()
                                }).ToList();

                return listaCliente;



            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
