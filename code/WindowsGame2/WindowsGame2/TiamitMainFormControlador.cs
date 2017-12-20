using System;
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
        validUserForm valiUsu;
        registUsurForm regUsu;
        Usuario usuari;
        public TiamitMainFormControlador()
        {
            valiUsu = new validUserForm();
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
            TiamitMainForm tiamitMainForm = new TiamitMainForm();
            tiamitMainForm.ShowDialog();

            while (tiamitMainForm.DialogResult != DialogResult.Cancel)
            {
                int marcador = tiamitMainForm.marcadorCancionElegida;
                GestionarInterpretacionControlador g = new GestionarInterpretacionControlador(tiamitMainForm.ruta, tiamitMainForm.instrument);
                int puntaje = g.puntaje;
                InterpretacionDao intDao = new InterpretacionDao();
                intDao.insertPerformance(Convert.ToInt32(usuari.id), puntaje, marcador);
                tiamitMainForm = new TiamitMainForm();
                tiamitMainForm.ShowDialog();
            }
        }
    }
}
