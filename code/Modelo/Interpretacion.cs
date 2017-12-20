using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    class Interpretacion
    {
        int usuario;
        int puntaje;
        string fecha;
        
        public Interpretacion(int us, int pun, string fec)
        {
            usuario = us;
            puntaje = pun;
            fecha = fec;
        }

        public int _usuario
        {
            get
            {
                return usuario;
            }
            set
            {
                usuario = value;
            }
        }

        public int _puntaje
        {
            get
            {
                return puntaje;
            }
            set
            {
                puntaje = value;
            }
        }

        public string _fecha
        {
            get
            {
                return fecha;
            }
            set
            {
                fecha = value;
            }
        }
    }
}
