using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AccesoBD;
using Modelo;

namespace TiamitDAO
{
    public class UsuarioDao
    {
        private string contraseña;
        private string nombre;
        private int pais;

        Usuario usuar;
        AccesoBase acces = new AccesoBase();

        public UsuarioDao(string nom, string contr)
        {
            contraseña = contr;
            nombre = nom;
        }

        public bool userValidation()
        {
            string param = "'" + nombre+ "','"+contraseña+"'";
            acces.consultar("userValidation", param);
            return (acces.dt.Tables["Resultado"].Rows.Count > 0);
        }

        public void insertNewUser(int pai)
        {
            pais = pai;
            string param = "'" + nombre + "','" + contraseña + "','" + pais + "'";
            acces.cambiosbd("insertNewUser", param);

        }

        public bool existingUserValidation()
        {
            string param = nombre;
            acces.consultar("existingUserValidation", param);
            return (acces.dt.Tables["Resultado"].Rows.Count > 0);
        }

        public Usuario crearUsuario()
        {
            string param = nombre;
            acces.consultar("existingUserValidation", param);
            usuar = new Usuario(acces.dt.Tables["Resultado"].Rows[0].ItemArray[0].ToString(),
                acces.dt.Tables["Resultado"].Rows[0].ItemArray[1].ToString(),
                acces.dt.Tables["Resultado"].Rows[0].ItemArray[2].ToString(),
                acces.dt.Tables["Resultado"].Rows[0].ItemArray[3].ToString());
            return usuar;
        }
    }
}
