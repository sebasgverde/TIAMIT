using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AccesoBD;

namespace TiamitDAO
{
    public class InterpretacionDao
    {
        AccesoBase acces = new AccesoBase();

        int usuario;
        int puntaje;
        string fecha;

        public InterpretacionDao()
        {
        }

        public void insertPerformance(int nom, int punt, int marc)
        {
            usuario = nom;
            puntaje = punt;
            fecha = DateTime.Today.ToString();
            string param = "'" + usuario + "','" + puntaje + "','" + fecha + "','" + marc + "'";
            acces.cambiosbd("insertPerformance", param);
 
        }
        
        public List<String> getPerformanceByCountry(int pais)
        {
            List<String> listaPaises = new List<String>();
            acces.consultar("getPerformanceByCountry", Convert.ToString(pais));
            for (int i = 0; i < acces.dt.Tables["Resultado"].Rows.Count; i++)
            {
                listaPaises.Add(acces.dt.Tables["Resultado"].Rows[i].ItemArray[0].ToString() + "    "
                    + acces.dt.Tables["Resultado"].Rows[i].ItemArray[1].ToString() + "    "
                    + acces.dt.Tables["Resultado"].Rows[i].ItemArray[2].ToString() + "    "
                    + acces.dt.Tables["Resultado"].Rows[i].ItemArray[3].ToString() + "    "
                    + acces.dt.Tables["Resultado"].Rows[i].ItemArray[4].ToString());
            }
            return listaPaises;
        }
        public List<String> getPerformanceBySong(int cancion)
        {
            List<String> listaPaises = new List<String>();
            acces.consultar("getPerformanceBySong", Convert.ToString(cancion));
            for (int i = 0; i < acces.dt.Tables["Resultado"].Rows.Count; i++)
            {
                listaPaises.Add(acces.dt.Tables["Resultado"].Rows[i].ItemArray[0].ToString() + "    "
                    + acces.dt.Tables["Resultado"].Rows[i].ItemArray[1].ToString() + "    "
                    + acces.dt.Tables["Resultado"].Rows[i].ItemArray[2].ToString() + "    "
                    + acces.dt.Tables["Resultado"].Rows[i].ItemArray[3].ToString() + "    "
                    + acces.dt.Tables["Resultado"].Rows[i].ItemArray[4].ToString());
            }
            return listaPaises;
        }

        public List<String> listarPais()
        {
            List<String> listaPaises = new List<String>();
            acces.consultar("listCountries", null);
            for (int i = 0; i < acces.dt.Tables["Resultado"].Rows.Count; i++)
            {
                listaPaises.Add(acces.dt.Tables["Resultado"].Rows[i].ItemArray[3].ToString());
            }
            return listaPaises;
        }
        public List<string> listSongs()
        {
            List<String> listaPaises = new List<String>();
            acces.consultar("listSongs", null);
            for (int i = 0; i < acces.dt.Tables["Resultado"].Rows.Count; i++)
            {
                listaPaises.Add(acces.dt.Tables["Resultado"].Rows[i].ItemArray[0].ToString());
            }
            return listaPaises;
        }
    }
}
