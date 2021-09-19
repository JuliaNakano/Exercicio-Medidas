using System;

namespace Exercicio_Medidas
{
    class Program
    {
        static void Main(string[] args)
        {
            double metros= 0;
            double cm=0;
            double km=0;

            Console.ForegroundColor = ConsoleColor. DarkBlue;
            Console.WriteLine("Após digitar um numero ele será convertido nas unidades de medidas cm e km");
            Console.WriteLine("");
            Console.ResetColor();
            
            Console.Write("Digite um numero na unidade de medida metro: ");
            metros=double.Parse(Console.ReadLine());

            cm = metros * 100;
            km = metros / 1000;

            Console.WriteLine($"--- Equivalência ---\n{cm} cm \n{metros} m \n{km} km");

            

        }    
    }
}
