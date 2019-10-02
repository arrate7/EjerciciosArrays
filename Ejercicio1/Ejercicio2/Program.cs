using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] array = new string[3];

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Introduce el valor {i+1}:");
                array[i] = Console.ReadLine();
            }

                Console.WriteLine($"En la posición 2: {array[1]}");
                Console.WriteLine($"En la posición 3: {array[2]}");
                Console.WriteLine($"En la posición 1 : {array[0]}");

        }
    }
}
