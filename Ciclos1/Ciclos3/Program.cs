using System;

namespace Ciclos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite 20 edades y luego calcule el promedio de edad de aquellas personas mayores a 18 años.
            float suma = 0;
            float mayor = 0;
            int edad, contador = 0;
            for (int x = 0; x < 20; x++){
            Console.WriteLine("Ingrese edad: ");
            edad = int.Parse(Console.ReadLine());

            if (edad > 18){
                mayor = edad;
                suma += mayor;
                contador++;
            }
            }
            suma = suma / contador;
            Console.WriteLine("El promedio es: " + suma);
            
        }

    }
}
