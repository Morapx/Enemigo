using System;
using System.Collections.Generic;
using System.Text;

namespace Enemigo
{
    class Caracteristicas
    {
        public int posisionx { get; set; }
        public int posiciony { get; set; }
        private int _puntosG;
        public int puntosG

        {
            get
            {
                return _puntosG;
            }
            set
            {
                if (value == 100)
                {
                    _puntosG = value;
                }
                else
                {
                    throw new Exception("No consiguio los suficientes");
                }

            }


        }

        public void moverse() { }
        public void  disparar() { }
        public void explotar() { }
        

    }
}
