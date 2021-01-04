using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guia_conceptosBasicos_01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string nombre;
            Console.WriteLine("Ingrese nombre: ");
            nombre =Console.ReadLine();
            Console.WriteLine("Nombre ingresado: " +nombre);
            */
            int acumulador = 0;
            int numero;
            int i;
            int maximo=0;
            int minimo=0;
            for (i=0; i<5; i++)
            {
                Console.Write("Ingrese numero: ");
                numero = Convert.ToInt32(Console.ReadLine());              
                acumulador += numero;               
                
                if(i==0)
                {
                    maximo = numero;
                    minimo = numero;
                }
                 if(maximo < numero)
                {
                    maximo = numero;
                }
                if(minimo > numero)
                {
                    minimo = numero;
                }
            }            
            Console.WriteLine("Promedio: " +acumulador/i);
            Console.WriteLine("Maximo: " + maximo);
            Console.WriteLine("Minimo: " + minimo);
            Console.ReadKey();
        }
    }
}
