using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace GuíaPráctica1_E3
{
    internal class Program
    {
        static void Dividir()
        {
            double num, div, result;

            Console.WriteLine("\n\t -------------------------------------------------------------------------------------");
            Console.WriteLine("\t   Ha seleccionado la opcion de dividir (Recordar que no se puede dividir entre 0)");
            Console.WriteLine("\t -------------------------------------------------------------------------------------");
            Console.Write("\n\t Digitar el número dividendo : ");
            num = Convert.ToDouble(Console.ReadLine());

            Console.Write("\t Digitar el número divisor   : ");
            div = Convert.ToDouble(Console.ReadLine());

            if (div > 0)
            {
                result = num / div;
                Console.WriteLine("\n\t ---------------------------------------------------------");
                Console.WriteLine($"\t      El resultado de la division de {num} entre {div} es: " + result);
                Console.WriteLine("\t ---------------------------------------------------------\n");
            }
            else
            {
                Console.WriteLine("\n\t ----------------------------------------------------------------------------------------");
                Console.WriteLine("\t Lo sentimos, no se puede realizar la operación debido a que no se puede dividir entre 0");
                Console.WriteLine("\t ----------------------------------------------------------------------------------------\n");
            }
        }

        static void Cubo()
        {
            double num;

            Console.WriteLine("\n\t ---------------------------------------------------------");
            Console.WriteLine("\t   Ha seleccionado la opcion de Potencia al cubo [  x³ ]");
            Console.WriteLine("\t ---------------------------------------------------------");
            Console.Write("\n\t Digitar el número que desea elevar al cubo : ");
            num = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n\t ---------------------------------------------------------");
            Console.WriteLine($"\t    El resultado de la potencia al cubo de {num} es: " + (num * num * num));
            Console.WriteLine("\t ---------------------------------------------------------\n");
        }

        static void Imc()
        {
            double peso, altura, imc;

            Console.WriteLine("\n\t ---------------------------------------------------------");
            Console.WriteLine("\t   Ha seleccionado la opción de Índice de Masa Corporal ");
            Console.WriteLine("\t ---------------------------------------------------------");

            Console.Write("\n\t Digitar su peso en kilgramos (kg) : ");
            peso = Convert.ToDouble(Console.ReadLine());

            Console.Write("\n\t Digitar altura en metros (m)      : ");
            altura = Convert.ToDouble(Console.ReadLine());

            imc = Math.Round((peso / (altura * altura)),3) ;
            Console.WriteLine("\n\t ---------------------------------------------------------");
            Console.WriteLine($"\t      Su índice de masa corporal es de: {imc} kg/m²");
            Console.WriteLine("\t ---------------------------------------------------------\n");
        }

        static void Salir()
        {
            Console.WriteLine("\n\t ------------------------------------------------");
            Console.WriteLine("\t -------         TEN UN BUEN DÍA          -------");
            Console.WriteLine("\t -------         Enter para salir         -------");
            Console.WriteLine("\t ------------------------------------------------");
            Console.ReadKey();
            Environment.Exit(0);
            
        }

        static void menu()
        {
            Console.WriteLine("\n\t -------------- Bienvenido al Menu --------------");
            Console.WriteLine("\t --  Puede realizar las siguientes operaciones --");
            Console.WriteLine("\t --           Favor, Elegir un numero          --");
            Console.WriteLine("\t --    a. Division                             --");
            Console.WriteLine("\t --    b. Potencia al cubo                     --");
            Console.WriteLine("\t --    c. Índice de masa corporal              --");
            Console.WriteLine("\t --    d. Salir                                --");
            Console.WriteLine("\t ------------------------------------------------\n");
            Console.Write("Opción : ");
        }

        static void Main(string[] args)
        {
            string op;
            do
            {
                menu();
                op = Console.ReadLine();

                switch (op)
                {
                    case "a":
                        Dividir();
                        break;
                    case "b":
                        Cubo();
                        break;
                    case "c":
                        Imc();
                        break;
                    case "d":
                        Salir();
                        break;
                    default:
                        Console.WriteLine("Opción no valida");
                        break;
                }
            }
            while (op != "d");
            Salir();
            Console.ReadKey();
        }
    }
}
