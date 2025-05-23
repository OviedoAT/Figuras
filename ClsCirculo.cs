using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClaseC;

namespace Figuras
{
    internal class ClsCirculo : ClsFigura
    {
        //atributos
        private float Radio;

        //Definimos propiedades
        public float _Radio
        {
            get { return Radio; }
            set { Radio = value; }
        }

        //Constructor
        public ClsCirculo()
        {
            Radio = 0;
        }

        //Definimos metodos
        public double Area()
        {
            double res = 0;
            res = Math.PI*(Radio*Radio);
            return res;
        }

        public double Perimetro()
        {
            double Peri = 0;
            Peri = Math.PI * (Radio + Radio);
            return Peri;
        }
    }
}
