using System;

namespace EjercicioArray
{
    class Program
    {
        static void Main(string[] args, int multiplos)
        {
            int mul;
		    int tamArreglo = 0;
		    int num = 0;

            Console.WriteLine("Tamaño del arreglo: ");
		    tamArreglo=int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese un nuemero para hallar sus multiplos ");
		    num=int.Parse(Console.ReadLine());

		    for(int i =0; i < tamArreglo; i++)
            {
                mul = (i+1)*num;
		    }

    }
}
