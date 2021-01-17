using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
      
        static void Main(string[] args)
        {
            int operando1;
            int operando2;
            string valor;
            int menu;

            Console.WriteLine("Ingrese primer operando: ");
            valor = Console.ReadLine();
            operando1 = Convert.ToInt32(valor);
            Console.WriteLine("Ingrese segundo operando ");
            valor = Console.ReadLine();
            operando2 = Convert.ToInt32(valor);
            do
            {           
                Imprime_menu();
                valor = Console.ReadLine();
                menu = Convert.ToInt32(valor);

                switch (menu)
                {
                    case 1:
                        Sumador(operando1, operando2);                        
                        break;
                    case 2:
                        Restador(operando1, operando2);                        
                        break;
                    case 3:
                        Multiplicador(operando1, operando2);
                        break;
                    case 4:
                        Divisor(operando1, operando2);
                        break;
                    case 5:
                        Console.WriteLine("Ingrese primer operando: ");
                        valor = Console.ReadLine();
                        operando1 = Convert.ToInt32(valor);
                        Console.WriteLine("Ingrese segundo operando ");
                        valor = Console.ReadLine();
                        operando2 = Convert.ToInt32(valor);
                        break;
                }
            } while (menu != 6);                     

        }// main

        static void Imprime_menu()
        {
            Console.WriteLine("Ingrese opcion del menu ");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplica");
            Console.WriteLine("4. Divide");
            Console.WriteLine("5. Reingresar numeros");
            Console.WriteLine("6. Salir");
        }
        static void Sumador(int a, int b)
        {
            int rdo = a + b;
            Console.WriteLine("Resultado de la suma: {0}", rdo);
         }
        static void Restador(int a, int b)
        {
            int rdo = a - b;
            Console.WriteLine("Resultado de la resta: {0}", rdo);
        }
        static void Multiplicador(int a, int b)
        {
            int rdo = a * b;
            Console.WriteLine("Resultado de la multiplicacion: {0}", rdo);
        }
        static void Divisor(int a, int b)
        {
            int rdo;
            if(b != 0)
            {
                rdo = a / b;
                Console.WriteLine("Resultado de la division: {0}", rdo);
            }
            else
            {
                Console.WriteLine("Error, no se puede dividir por cero");
            }  
        }       
    }
}
