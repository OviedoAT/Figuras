using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseC
{
    class ClsCuadrado : ClsFigura
    {
        //atributos
        private float Lado;
        //propuedades
        public float getLado()
        {
            return Lado;
        }

        public void setLado(float valor)
        {
            Lado = valor;
        }

        //constructor
        public ClsCuadrado()
        {
            Lado = 0;
        }
        //metodos

        public float Area()
        {
            float res = 0;
            res = Lado * Lado;
            return res;
        }

        public float Perimetro()
        {
            float res = 0;
            res = Lado * 4;
            return res;
        }
    }
}