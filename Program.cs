using System;
using System.Threading;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = Segundos => 10s = 10 segundos");
            Console.WriteLine("M = Minuto => 1m = 1 minuto");
            Console.WriteLine("Quanto tempo deseja cronometrar?");


            string data = Console.ReadLine().ToLower(); // convertendo para minusculo 
            char type = char.Parse(data.Substring(data.Length - 1, 1)); // acessando o ultimo caracter 'm' ou 's'
            int time = int.Parse(data.Substring(0, data.Length - 1)); // acessando a quantidade de segundos ou minutos 
            int multiplier = 1;

            if (type == 'm')
                multiplier = 60;

            PreStart(time * multiplier);
        }
        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go!");
            Thread.Sleep(1100);

            Start(time);
        }
        static void Start(int time)
        {
            int currentTime = 0;
            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine("Stopwatch finalizado");
            Thread.Sleep(2500);

        }
    }
}
