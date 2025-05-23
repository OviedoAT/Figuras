using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    internal class ClsPentagono
    {
        //Atributos
        private float Lado;
        private float Apotema;

        //Definimos Propiedades
        public float _Lado
        {
            get { return Lado; }
            set { Lado = value; }
        }

        public float _Apotema
        {
            get { return Apotema; }
            set { Apotema = value; }
        }

        //Constructor
        public ClsPentagono()
        {
            Lado = 0;
            Apotema = 0;
        }

        //Definimos Métodos
        public float Area()
        {
            float areaPent = (Perimetro() * Apotema) / 2;
            return areaPent;
        }
        public float Perimetro()
        {
            float perimetroPent = Lado * 5;
            return perimetroPent;
        }
    }
}
