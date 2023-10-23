using System;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Long Tune with Console Beeps in 16-bit Fighting Game Style";
            Console.WriteLine("Press any key to start the tune...");
            Console.ReadKey();

            int[] frequencies = { 440, 494, 523, 587, 659, 698, 784, 880 };
            int[] durations = { 500, 500, 500, 500, 500, 500, 1000, 1000 };

            for (int i = 0; i < frequencies.Length; i++)
            {
                Console.Beep(frequencies[i], durations[i]);
                Thread.Sleep(50);
            }

            Console.WriteLine("Tune complete!");
            Console.ReadKey();
        }
    }
}