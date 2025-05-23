using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClaseC;

namespace Figuras
{
    internal class ClsTriangulo : ClsFigura
    {
        //atributos
        private float Lado1;
        private float Lado2;
        private float Lado3;

        //propiedades
        public float _Lado1
        {
            get { return Lado1; }
            set { Lado1 = value; }
        }

        public float _Lado2
        {
            get { return Lado2; }
            set { Lado2 = value; }
        }

        public float _Lado3
        {
            get { return Lado3; }
            set { Lado3 = value; }
        }

        //constructor
        public ClsTriangulo()
        {
            Lado1 = 0;
            Lado2 = 0;
            Lado3 = 0;
        }

        //definimos metodos
        public bool FormarTriangulo()
        {
            bool FormarTriangulo = false;
            if (Lado1 >= Lado2 && Lado1 >= Lado3) 
            {
                if (Lado1 >= (Lado2 + Lado3))
                {
                    FormarTriangulo = true;
                }
            }
            if (Lado2 >= Lado1 && Lado2 >= Lado3)
            {
                if (Lado2 >= (Lado1 + Lado3))
                {
                    FormarTriangulo = true;
                }
            }
            if (Lado3 >= Lado2 && Lado3 >= Lado1)
            {
                if (Lado3 >= (Lado1 + Lado2))
                {
                    FormarTriangulo = true;
                }
            }
                return FormarTriangulo;
        }

        public double Area()
        {
            float semiperimetro = 0;
            double res;

            semiperimetro = Perimetro()/2;
            res = Math.Sqrt(semiperimetro*(semiperimetro - Lado1)*(semiperimetro - Lado2)*(semiperimetro - Lado3));
            return res;
        }

        public float Perimetro()
        {
            float res = 0;
            res = Lado1 + Lado2 + Lado3;
            return res;
        }

        public string Tipo_Triangulo()
        {
            if (Lado1 == Lado2 && Lado2 == Lado3 && Lado3 == Lado1)
            {
                return "El Triangulo es Equilatero";
            }
            if ((Lado1 != Lado2 || Lado1 != Lado3 || Lado2 != Lado3) && (Lado1 == Lado2 || Lado1 == Lado3 || Lado2 == Lado3) && (Lado1 == Lado2 || Lado1 == Lado3 || Lado2 == Lado3))
            {
                return "El Triangulo es Isóceles";
            }
            else
            {
                return "El Triangulo es Escaleno";
            }
        }
    }
}
