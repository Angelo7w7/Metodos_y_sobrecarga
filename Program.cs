using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int num3;
            int num4;
            int resultado;
            Console.WriteLine("Cuantos numeros quieres sumar?");
            Console.WriteLine("Presiona 0: Sumar 2 numeros");
            Console.WriteLine("Presiona 1: Sumar 3 numeros");
            Console.WriteLine("Presiona 2: Sumar 4 numeros");
            Console.WriteLine("Otra tecla-Salir");
            int op = int.Parse(Console.ReadLine());
            switch (op)
            {
                case 0:
                    Console.WriteLine("Ingresa el primer numero");
                    num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa el segundo numero");
                    num2 = int.Parse(Console.ReadLine());
                    resultado = Suma(num1,num2);
                    Console.WriteLine("El resultado es: " + resultado);
                break; 
                case 1: 
                    Console.WriteLine("Ingresa el primer numero");
                    num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa el segundo numero");
                    num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa el tercer numero");
                    num3 = int.Parse(Console.ReadLine());
                    resultado = Suma(num1, num2, num3);
                    Console.WriteLine("El resultado es: " + resultado);
                break;
                case 2: 
                    Console.WriteLine("Ingresa el primer numero");
                    num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa el segundo numero");
                    num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa el tercer numero");
                    num3 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa el cuarto numero");
                    num4 = int.Parse(Console.ReadLine());
                    resultado = Suma(num1, num2, num3,num4);
                    Console.WriteLine("El resultado es: " + resultado);
                break;
            }
        }
        static int Suma(int n1, int n2) {
            return  n1 + n2;
        }
        static int Suma(int n1, int n2, int n3) { 
            return n1 + n2 + n3;
        }
        static int Suma(int n1, int n2, int n3,int n4)
        {
            return n1 + n2 + n3 + n4;
        }
    }
}