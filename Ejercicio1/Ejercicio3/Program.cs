using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Crear un array de 10 ints. 
             * Usar un for para asignar los valores de 20 a 11 a las 10 posiciones 
             * (en orden descendente). 
             * Usar un for para mostrar los 10 valores en pantalla.
*/
            //int[] arrayOfInts = new int[10];
            //int value = 20;
            //for (int i = 0; i < arrayOfInts.Length; i++)
            //{
            //    arrayOfInts[i] = value;
            //    value -= 1;
            //}
            //for (int i = 0; i < arrayOfInts.Length; i++)
            //{
            //    Console.Write(arrayOfInts[i] + " ");
            //}
            ///* ++++++++++++++++++++++++++++++++++++++++++++++++++*/

            //int veinte = 20;
            //int[] vs = new int[10];

            //for (int i = 0; i < 10; i++)
            //{
            //    veinte--;
            //    vs[i] = veinte;
            //    Console.WriteLine(vs[i]);

            //}



            //int j = 0;
            //int[] array = new int[10];
            //for (int i = 20; i > array.Length; i--)
            //{
            //    array[j] = i;
            //    j++;
            //}
            //for (int i = 0; i < array.Length; i++)

            //{
            //    Console.Write(array[i] + " ");
            //}




            Random aleatorio = new Random();
            //int aleatorio20 = aleatorio.Next(18, 36);

            Console.WriteLine(aleatorio.Next(18, 36));
            Console.WriteLine(aleatorio.Next(18, 36));
















        }
    }
}
