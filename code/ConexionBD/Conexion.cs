using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace ConexionBD
{
    public class Conexion
    {
        string cadena;
        public SqlConnection cn; //variable de tipo sql, para crear la coneccion 

        public void Conectar()
        {
            // this is a example with a local sql server instance
            // the most importatnt is the Initial Catalog (database name) and
            // Data Source (server name) params. In case of use a remote DB
            // just replace with the corresponding connection string

            cadena = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=TIAMIT;Data Source=sebastian-pc";

            cn = new SqlConnection(cadena); //para conectar cn a la bd
            cn.Open(); //activa o abre la bd que se especifico en cadena 

        }
    }
}
