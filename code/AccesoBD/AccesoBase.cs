using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using ConexionBD;

namespace AccesoBD
{
    public class AccesoBase
    {
        SqlCommand comand;
        string sql;
        Conexion ObjCnx = new Conexion();
        SqlDataAdapter da;
        public DataSet dt;

        public void consultar(string proc, string param)
        {
            ObjCnx.Conectar();
            sql = " " + proc + " " + param + " ";
            dt = new DataSet();
            da = new SqlDataAdapter(sql, ObjCnx.cn);
            da.Fill(dt, "Resultado");

        }

        public void cambiosbd(string proc, string param)
        {
            ObjCnx.Conectar();
            sql = "" + proc + " " + param + "";
            comand = new SqlCommand(sql, ObjCnx.cn);
            comand.ExecuteNonQuery();
        } 
    }
}
