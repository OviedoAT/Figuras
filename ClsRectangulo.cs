using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseC
{
    class ClsRectangulo : ClsFigura
    {
        //atrubutos
        private float Alto;
        private float Ancho;

        //definimos propiedades
        public float getAlto()
        {
            return Alto;
        }
        public void setAlto(float value)
        {
            Alto = value;
        }

        public float _Ancho
        {
            get { return Ancho; }
            set { Ancho = value; }

        }

        //metodo constructor
        public ClsRectangulo()
        {
            Ancho = 0;
            Alto = 0;
        }
        //constructor parametrizado
        public ClsRectangulo(float _base, float _altura)
        {
            Ancho = _base;
            Alto = _altura;
        }
        //definimos metodos
        public float Area()
        {
            float res = 0;
            res = Alto * Ancho;
            return res;
        }

        public float Perimetro()
        {
            float res = 0;
            res = (Alto + Ancho) * 2;
            //res = Alto + Alto + Ancho + Ancho;
            return res;
        }


    }
}