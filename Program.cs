using ClaseC;

namespace Figuras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creamos el objeto de la clase rectangulo
            ClsRectangulo miRectangulo = new ClsRectangulo();
            ClsRectangulo Rectangulo2 = new ClsRectangulo();
            ClsCuadrado miCuadro = new ClsCuadrado();
            ClsFigura figura = new ClsRectangulo();
            ClsTriangulo Triangulo = new ClsTriangulo();
            ClsCirculo circulo = new ClsCirculo();
            ClsPentagono Pentagono = new ClsPentagono();

            int option = 0;
            char op = ' ', SuperOp=' ';

            do
            {
                Console.WriteLine("Seleccione la figura que desea trabajar");
                Console.WriteLine("1.- Cuadrado");
                Console.WriteLine("2.- Rectángulo");
                Console.WriteLine("3.- Triángulo");
                Console.WriteLine("4.- Círculo");
                Console.WriteLine("5.- Pentágono");
                Console.WriteLine("6.- Salir");
                Console.Write("Opción: ");
                option = int.Parse(Console.ReadLine());

                Console.Clear();

                switch (option)
                {
                    case 1:
                        do
                        {
                            Console.WriteLine("Ingresa el tamaño del lado : ");
                            miCuadro.setLado(float.Parse(Console.ReadLine()));

                            Console.Clear();

                            Console.WriteLine("El área del cuadrado es : " + miCuadro.Area());
                            Console.WriteLine("El perímetro del cuadrado es : " + miCuadro.Perimetro());
                            Console.WriteLine("¿Desea realizar otra operación con la misma figura? (S)(N)");
                            op = char.Parse(Console.ReadLine());
                            Console.Clear();
                        } while (op == ('S' | 's'));
                        break;

                    case 2:
                        do
                        {
                            Console.WriteLine("Captura el ancho que tendra el rectangulo");
                            miRectangulo._Ancho = float.Parse(Console.ReadLine());

                            Console.WriteLine("Captura el Alto del rectangulo");
                            miRectangulo.setAlto(float.Parse(Console.ReadLine()));

                            Console.Clear();

                            Console.WriteLine("El area del rectangulo es : " + miRectangulo.Area() + " m2");
                            Console.WriteLine("El Perimetro del rectangulo es : " + miRectangulo.Perimetro() + " m");
                            Console.WriteLine("¿Desea realizar otra operación con la misma figura? (S)(N)");
                            op = char.Parse(Console.ReadLine());
                            Console.Clear();
                        } while (op == ('S' | 's'));
                        break;

                    case 3:
                        do
                        {
                            do
                            {
                                Console.WriteLine("Ingrese el tamaño del lado 1:");
                                Triangulo._Lado1 = float.Parse(Console.ReadLine());

                                Console.WriteLine("Ingrese el tamaño del lado 2:");
                                Triangulo._Lado2 = float.Parse(Console.ReadLine());

                                Console.WriteLine("Ingrese el tamaño del lado 3:");
                                Triangulo._Lado3 = float.Parse(Console.ReadLine());

                                Console.Clear();
                            } while (Triangulo.FormarTriangulo() == true);

                            Console.WriteLine("El área del triangulo es : " + Triangulo.Area());
                            Console.WriteLine("El perimetro del triangulo es : " + Triangulo.Perimetro());
                            Console.WriteLine("El tipo de triangulo es : " + Triangulo.Tipo_Triangulo());
                            Console.WriteLine("¿Desea realizar otra operación con la misma figura? (S)(N)");
                            op = char.Parse(Console.ReadLine());
                            Console.Clear();
                        } while (op == ('S' | 's'));
                        break;

                    case 4:
                        do
                        {

                        } while (op == ('S' | 's'));
                        Console.WriteLine("Ingrese el valor del radio: ");
                        circulo._Radio = float.Parse(Console.ReadLine());

                        Console.WriteLine("El area del circulo es : " + circulo.Area());
                        Console.WriteLine("El perímetro o circunferencia del circulo es : " + circulo.Perimetro());
                        Console.WriteLine("¿Desea realizar otra operación con la misma figura? (S)(N)");
                        op = char.Parse(Console.ReadLine());
                        Console.Clear();
                        break;

                    case 5:
                        do
                        {

                        } while (op == ('S' | 's'));
                        Console.WriteLine("Ingrese el valor de un lado:");
                        Pentagono._Lado = float.Parse(Console.ReadLine());

                        Console.WriteLine("Ingrese el valor del apotema:");
                        Pentagono._Apotema = float.Parse(Console.ReadLine());

                        Console.WriteLine("El Area del pentágono es: " + Pentagono.Area());
                        Console.WriteLine("El Perímetro del pentágono es: " + Pentagono.Perimetro());
                        Console.WriteLine("¿Desea realizar otra operación con la misma figura? (S)(N)");
                        op = char.Parse(Console.ReadLine());
                        Console.Clear();
                        break;

                    case 6:
                        op = 'n';
                        break;
                }
                Console.WriteLine("¿Desea realizar otra operación con alguna otra figura? (S)(N)");
                op = char.Parse(Console.ReadLine());
                Console.Clear();
            } while (op == ('S' | 's'));
        }
    }
}