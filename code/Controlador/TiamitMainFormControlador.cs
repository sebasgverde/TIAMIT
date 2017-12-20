/*using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Controlador;
using Modelo;
using TiamitDAO;

namespace Vista
{
   
    class TiamitMainFormControlador
    {
        validUsurForm valiUsu;
        registUsurForm regUsu;
        Usuario usuari;
        public TiamitMainFormControlador()
        {
            valiUsu = new validUsurForm();
            valiUsu.ShowDialog();
            if (valiUsu.DialogResult == DialogResult.OK)
            {

                iniciarSesion(valiUsu.user);
            }
            else if (valiUsu.DialogResult == DialogResult.Retry)
            {
                regUsu = new registUsurForm();
                regUsu.ShowDialog();
                if (regUsu.DialogResult == DialogResult.OK)
                {
                    iniciarSesion(regUsu.user);
                }
            }
        }

        public void iniciarSesion(Usuario u)
        {
            usuari = u;
            TiamitMainForm a = new TiamitMainForm();
            a.ShowDialog();
            while (a.DialogResult != DialogResult.Cancel)
            {
                int marcador = a.marcadorCancionElegida;
                GestionarInterpretacionControlador g = new GestionarInterpretacionControlador(a.ruta);
                int puntaje = g.puntaje;
                MessageBox.Show("oeeeeeeeeeeee");
                InterpretacionDao intDao = new InterpretacionDao();
                intDao.ingresarInterpretacion(Convert.ToInt32(usuari.id), puntaje, marcador);
                a = new TiamitMainForm();
                a.ShowDialog();
            }
        }
    }
}*/
