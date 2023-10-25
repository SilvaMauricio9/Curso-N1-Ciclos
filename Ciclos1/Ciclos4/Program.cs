using System;

namespace Ciclos4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite UN número y luego calcule y emita un cartel aclaratorio si el mismo es primo o no es primo.  
            //Nota: un numero es primo cuando es divisible únicamente por 1 y por sí mismo.
            int N;
            int Contador = 0;
            Console.WriteLine("Ingrese numero: ");
            N = int.Parse(Console.ReadLine());

            for (int x = 1; x <= N; x++)
            {
                if(N % x == 0)
                
                    Contador++;
            }
            if (Contador == 2){
                Console.WriteLine("Es numero primo");
            }else
                {
                    Console.WriteLine("No es numero primo");
                }
            Console.WriteLine("Fin del programa...");
            
        }
    }
}
