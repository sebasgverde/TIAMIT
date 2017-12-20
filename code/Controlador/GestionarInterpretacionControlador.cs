/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Modelo;
using Controlador;
using System.Windows.Forms;

namespace Vista
{
    ///////////////////////////////////////////////////////////
    //  Original author: sebastian
    ///////////////////////////////////////////////////////////
    public class GestionarInterpretacionControlador
    {
       /* public int puntaje;
        public Cancion miCancion;
        public ControladorSonidoPrincipal controlSon;
        public Interpretacion interp;
        CargarCancionControlador controlCargar;
        public int i, posX;
        public System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        public GestionarInterpretacionControlador(string ruta)
        {
            
            controlCargar = new CargarCancionControlador(ruta);
            miCancion = controlCargar.canc;
            interp = new Interpretacion(miCancion.notas[0]);
            controlSon = new ControladorSonidoPrincipal();
            controlSon.interpCont = this;

            interp.graphics.DeviceDisposing += new EventHandler<EventArgs>(deviceDisposing);
            timer.Interval = 20;
            timer.Tick += new EventHandler(timer_Tick);
            interp.sobrepasarPantalla += new Interpretacion.handlerZonasCriticas(interp_sobrepasarPantalla);
            interp.sobrepasarMargenSig += new Interpretacion.handlerZonasCriticas(interp_sobrepasarMargenSig);
            interp.terminarJuego += new Interpretacion.handlerZonasCriticas(interp_terminarJuego);
            interp.pausar += new Interpretacion.handlerZonasCriticas(interp_pausar);
            i = 0;
            posX = 700;
            timer.Enabled = true;
            interp.Run();
        }

        void interp_pausar()
        {
            if (timer.Enabled)
                timer.Stop();
            else
                timer.Start();
        }

        void interp_terminarJuego()
        {
            puntaje = interp.puntaje;
            controlSon.StopListenning();
            interp.Exit();
        }

        void interp_sobrepasarMargenSig()
        {
            i++;
            if (i < miCancion.notas.Count)
            {
                miCancion.notas[i].posicionX = posX + miCancion.notas[i - 1].margenSigNota;
                interp.cambiarNotaSig(miCancion.notas[i]);
            }
        }

        public void interp_sobrepasarPantalla()
        {
            /* i += 1;
             posX = 700;
             actualizar();*/
         /*   if (interp.notasVisualizadas.Count > 1)
                posX = interp.notasVisualizadas[1].posicionX;
            interp.eliminarNotaSobrepasada();
        }

        public void timer_Tick(object sender, EventArgs e)
        {
            posX -= 4;
            interp.actualizarSpriPos(posX);
            interp.comprobar();
        }

        public void deviceDisposing(object sender, EventArgs e)
        {
            timer.Enabled = false;
            controlSon.graphics_DeviceDisposing(sender,e);     
        }

        public void verificarNotaDetectada(string nomNota)
        {
            if (interp.notasVisualizadas.Count > 0)
            {
                if (nomNota == interp.notasVisualizadas[0]._nombre && interp.notasVisualizadas[0].posicionX < 211)
                {
                    interp.Frecuen = "correcto";
                    interp_sobrepasarPantalla();
                    interp.puntaje++;
                }
            }
            else
                interp.Frecuen = "error";
        }*//*
    }
}
*/