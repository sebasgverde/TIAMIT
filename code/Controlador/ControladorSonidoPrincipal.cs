/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SoundCapture;
using SelectDevice;
using System.Windows.Forms;
using Frecuencias;


namespace Vista
{
    ///////////////////////////////////////////////////////////
    //  Original author: sebastian
    ///////////////////////////////////////////////////////////
    public class ControladorSonidoPrincipal
    {
        public Interpretacion interpretacion;
        public GestionarInterpretacionControlador interpCont;

        public ControladorSonidoPrincipal()
        {
            //interpretacion = inter;
            iniciarEsaVaina();
        }

        public void graphics_DeviceDisposing(object sender, EventArgs e)
        {
            if (IsListenning)
            {
                StopListenning();
            }
        }

        /*todas los metodos y cosas del detector de frecuencias
        ---------------------------------------------------------------------------------------
        ---------------------------------------------------------------------------------------
        ---------------------------------------------------------------------------------------
        ---------------------------------------------------------------------------------------
        bool isListenning = false;

        public bool IsListenning
        {
            get { return isListenning; }
        }

        FrequencyInfoSource frequencyInfoSource;

        public void StopListenning()
        {
            isListenning = false;
            frequencyInfoSource.Stop();
            frequencyInfoSource.FrequencyDetected -= new EventHandler<FrequencyDetectedEventArgs>(frequencyInfoSource_FrequencyDetected);
            frequencyInfoSource = null;
        }

        private void StartListenning(SoundCaptureDevice device)
        {
            isListenning = true;
            frequencyInfoSource = new SoundFrequencyInfoSource(device);
            frequencyInfoSource.FrequencyDetected += new EventHandler<FrequencyDetectedEventArgs>(frequencyInfoSource_FrequencyDetected);
            frequencyInfoSource.Listen();
        }

        void frequencyInfoSource_FrequencyDetected(object sender, FrequencyDetectedEventArgs e)
        {
            UpdateFrequecyDisplays(e.Frequency);
        }

        private void UpdateFrequecyDisplays(double frequency)
        {

            if (frequency > 0)
            {
                double closestFrequency;
                string noteName;
                FindClosestNote(frequency, out closestFrequency, out noteName);
                string cosilla = frequency.ToString("f3") + " " + closestFrequency.ToString("f3") + " " + noteName;
                //interpretacion.Frecuen = cosilla;
                interpCont.verificarNotaDetectada(noteName);
            }
        }

        static string[] NoteNames = { "A", "A#", "B/H", "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#" };
        static double ToneStep = Math.Pow(2, 1.0 / 12);

        private void FindClosestNote(double frequency, out double closestFrequency, out string noteName)
        {
            const double AFrequency = 440.0;
            const int ToneIndexOffsetToPositives = 120;

            int toneIndex = (int)Math.Round(Math.Log(frequency / AFrequency, ToneStep));
            noteName = NoteNames[(ToneIndexOffsetToPositives + toneIndex) % NoteNames.Length];
            closestFrequency = Math.Pow(ToneStep, toneIndex) * AFrequency;
        }

        private void iniciarEsaVaina()
        {
            SoundCaptureDevice device = null;
            using (SelectDeviceForm form = new SelectDeviceForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    device = form.SelectedDevice;
                }
            }

            if (device != null)
            {
                StartListenning(device);
            }
        }
        
        no se para que puse esto
         * 
         * public event EventHandler<EventArgs> Disposed;*/


        /*
         * esto detenia los procesos al cerrar el formulario pero aqui no funciona
         * debemos buscar como hacerlo al cerrar xna
         * 
         * private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
         {
             if (IsListenning)
             {
                 StopListenning();
             }
         }*/
/*
       ---------------------------------------------------------------------------------------
         ---------------------------------------------------------------------------------------
         ---------------------------------------------------------------------------------------
         ---------------------------------------------------------------------------------------
    }
}
*/