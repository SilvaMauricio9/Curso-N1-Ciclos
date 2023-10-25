using System;

namespace Ciclos5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite 20 números
            //y luego emitir por pantalla el máximo de los números pares y el mínimo de los números impares.
            int n, par = 0, impar = 0, maximo = 0, minimo = 0;

            for (int x = 0; x < 20; x++){
            Console.WriteLine("Ingrese un numero: ");
            n = int.Parse(Console.ReadLine());
            if(n % 2 == 0){
                maximo = n;
                 if(par < maximo)
                par = maximo;
            }  
        
            else{
                minimo++;
                if(minimo == 1)
                impar = n;
                else if(n < impar)
                impar = n;
            }
            }
            Console.WriteLine("El mayor par es: " + par);
            Console.WriteLine("El menor impar es: " + impar);
        }
    }
        
}