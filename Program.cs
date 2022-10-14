using System;

namespace actividad5TP7_Funciones
{
    class Program
    {
        static void Main(string[] args)
        {
            string valor = "";
            int numero = 0;

            Console.WriteLine("Para calcular el factorial de un Número ingrese el '1'");
            valor = Console.ReadLine();
            numero = Convert.ToInt32(valor);

            if (numero == 1)
            {
                calculoFactorial(numero);
            }
        }

        static void calculoFactorial(int numero)
        {
            int n = 0;
            int numero1 = 0;
            int factorial = 1;
            string valor = "";

            Console.WriteLine("Ingrese un Número para calcularle su factorial");
            valor = Console.ReadLine();
            numero1 = Convert.ToInt32(valor);

            for (n = numero1; n >= 1; n--)
            {
                factorial *= n;
            }

            Console.Clear();

            Console.WriteLine("El factorial de {0} es {1}", numero1, factorial);
        }
    }
}