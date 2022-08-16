using System;

namespace Ejercicio_7
{
    class Program
    {
        static int numero1 = 0, numero2 = 0;
        static void Main(string[] args)

        {
            int option;
            bool ejecutar = true;
            Console.WriteLine("Calculadora");
            do
            {
                Console.WriteLine("seleccione una operación:");
                Console.WriteLine("1, Sumar");
                Console.WriteLine("2, Restar");
                Console.WriteLine("3, Dividir");
                Console.WriteLine("4,Multiplicar");
                Console.WriteLine("5, Cerrar");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        SolicitarDatos();
                        Console.WriteLine($"El resultado es {Suma(numero1,  numero2)} ");
                        break;
                    case 2:
                        SolicitarDatos();
                        Console.WriteLine($"El resultado es {Resta(numero1,  numero2)} ");
                        break;
                    case 3:
                        SolicitarDatos();
                        Console.WriteLine($"El resultado es {División(numero1, numero2)} ");
                        break;
                    case 4:
                        SolicitarDatos();
                        Console.WriteLine($"El resultado es {Multi(numero1, numero2)}");
                        break;
                    case 5:
                        ejecutar = false;
                        break;
                    default:
                        Console.WriteLine("Opción invalida ");
                        break;
                }
               
            } while (ejecutar);

            static void SolicitarDatos()

             {
                Console.WriteLine("Ingrese el número 1");
                numero1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el número 2");
                numero2 = int.Parse(Console.ReadLine());
             }

            static int Suma(int numero1, int numero2) => numero1 + numero2;

            static int Resta(int numero1, int numero2) => numero1 - numero2;

            static int Multi(int numero1, int numero2) => numero1 * numero2;

            static int División(int numero1, int numero2) => numero1 / numero2;


        }
    }
}
