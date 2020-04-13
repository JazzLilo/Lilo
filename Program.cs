using System;
using System.Collections.Generic;
using System.Text;

namespace Fraccion
{
    class Program
    {
        static void Main(string[] args)
        {
            int resp;

            Console.WriteLine("Ingrese la operacion a realizar" +
            "\n1. Crear fracciones" +
            "\n2. suma" +
            "\n3. resta" +
            "\n4. multiplicacion" +
            "\n5. division" +
            "\n6. simplificar" +
            "\n7. salir");
            fraccion z;
            fraccion x = new fraccion(1, 4);
            fraccion y = new fraccion(2, 4);
            do
            {
                resp = Int32.Parse(Console.ReadLine());
                switch (resp)
                {
                    case 1:
                        Console.WriteLine("Procesando........");
                        x.Leer();
                        y.Leer();
                        x.mostrar();
                        y.mostrar();
                        
                        break;
                    case 2:
                        Console.WriteLine("Procesando........");
                        z = x + y;
                        z.mostrar();
                        break;
                    case 3:
                        Console.WriteLine("Procesando........");
                        z = x - y;
                        z.mostrar();
                        break;
                    case 4:
                        Console.WriteLine("Procesando........");
                        z = x * y;
                        z.mostrar();
                        break;
                    case 5:
                        Console.WriteLine("Procesando........");
                        z = x / y;
                        z.mostrar();
                        break;
                    case 6:
                        Console.WriteLine("Procesando........");
                        int q = Int32.Parse(Console.ReadLine());
                        int w = Int32.Parse(Console.ReadLine());
                        z = new fraccion(q, w);
                        z.simplificar();
                        break;
                    default:
                        resp = 7;
                        break;

                }

            } while (resp != 7);
            Console.ReadKey();
        }
    }
}
