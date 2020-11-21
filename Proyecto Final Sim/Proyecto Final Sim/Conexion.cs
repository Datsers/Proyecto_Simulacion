using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Proyecto_Final_Sim
{
    class Conexion
    {
        public SqlConnection cn;
        public SqlCommand cmmd;
        public SqlDataReader dr;
        public SqlDataAdapter da;
        public DataTable dt;
        public static string path = @"server = DESKTOP-DCPQ1CO\SQLEXPRESS; database = EXERCISE_SIMULATOR; uid = helmer; pwd = 123";

        public void Conectar()
        {
            cn = new SqlConnection(path);
            cmmd = cn.CreateCommand();
            cn.Open();

        }
        public bool comprobarConexion()
        {
            bool conectado = true;
            try
            {
                cn = new SqlConnection(path);
                cn.Open();
                cmmd = cn.CreateCommand();
            }
            catch (Exception)
            {

                conectado = false;
            }
            return conectado;
        }
    }
}

