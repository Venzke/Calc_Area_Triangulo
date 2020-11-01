using System;
using System.Globalization;

namespace Aula_5h
{
    class Program
    {
        static void Main(string[] args)
        {
            double xA, xB, xC, yA, yB, yC;

            //Triângulo X

            Console.WriteLine("Entre com as medidas do triângulo X.");
            Console.WriteLine();

            Console.Write("Medida A: ");
            xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.Write("Medida B: ");
            xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.Write("Medida C: ");
            xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Triângulo Y

            Console.WriteLine();
            Console.WriteLine("Entre com as medidas do triângulo Y.");
            Console.WriteLine();

            Console.Write("Medida A: ");
            yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.Write("Medida B: ");
            yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.Write("Medida C: ");
            yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Calculo

            double p;

            p = (xA + xB + xC) / 2; //Caculo pX

            //Calculo da área do triângulo X

            double areaX, areaY;

            areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

            //Calculo da área do triângulo Y

            p = (yA + yB + yC) / 2; //Calculo pY

            areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

            //Impressão dos dados processados

            Console.WriteLine("Área do triângulo X: {0}", areaX);
            Console.WriteLine("Área do trinângulo Y {0}", areaY);

            Console.WriteLine();

            if (areaX > areaY)
            {
                Console.WriteLine("A área do triângulo X é maior que a do Y.");
            }
            else
            {
                Console.WriteLine("A área do triângulo Y é maior que a do X.");
            }

        }
    }
}