using System;

namespace Ciclos2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite el ingreso de 10 números y que muestre el mayor de ellos por pantalla. 
            //Solo se debe emitir UN valor por pantalla.
        
            int N;
            int Mayor = 0;
            for (int x = 0; x < 10; x++){
            Console.WriteLine("Ingrese un numero: ");
            N = int.Parse(Console.ReadLine());

            if(x == 0)
                Mayor = N;

            if (Mayor < N)
            {
                Mayor = N;
            }
            
            }
            Console.WriteLine("El mayor valor es: " + Mayor);
        }
    }
}
