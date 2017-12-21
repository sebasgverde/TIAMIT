using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Vista
{
#if WINDOWS || XBOX
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            //// To use just the game without forms and database just comment the line and 
            //// un comment one of these, replacing with the corresponding path of a musicXml file
            //// and the instrument string

            //GestionarInterpretacionControlador g = new GestionarInterpretacionControlador("<path>/everyNoteE4E8.xml", "Guitar");
            //GestionarInterpretacionControlador g = new GestionarInterpretacionControlador("<path>/everyNoteE4E8.xml", "diatonicHarmonicaE");
            //GestionarInterpretacionControlador g = new GestionarInterpretacionControlador("<path>/everyNoteE2E6.xml", "OcarinaAltoC");

            TiamitMainFormControlador g = new TiamitMainFormControlador();
        }
    }
#endif
}

