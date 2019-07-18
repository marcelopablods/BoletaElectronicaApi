using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Pdf417.ConexionBD
{
    public class Conexion
    {
        public static SqlConnection conectar()
        {

            SqlConnection con = new SqlConnection(@"Data Source=andinacls;Initial Catalog=efactura;User ID=sa;Password=a51nk0");
            SqlConnection.ClearAllPools();
            Console.WriteLine(con.ToString());
            return con;
        }

        public static DataSet ejecutar_select(string query)
        {
            conectar().Open();
            SqlDataAdapter da = new SqlDataAdapter(query, conectar());
            DataSet ds = new DataSet();
            da.Fill(ds);
            conectar().Close();
            return ds;
        }


        public static bool ejecutar_comando(string comando)
        {
            conectar().Open();
            SqlCommand cm = new SqlCommand(comando, conectar());
            bool rta;
            try
            {
                cm.Connection.Open();
                cm.ExecuteNonQuery();
                rta = true;
            }
            catch (Exception ex)
            {
                rta = false;
                Console.Write(ex);
            }
            return rta;
        }
    }
}