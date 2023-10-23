using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazarCalculator.AudioVisualEffects
{
    public class LightShow
    {
        // Properties, what the class has
        public ConsoleColor ForeGround { get; set; }
        public ConsoleColor Background { get; set; }


        // Constructor, how the class is built
        public LightShow(ConsoleColor _foreGround, ConsoleColor _background) { 
            // Set the properties based upon instructions (values) that were passed in for creating the class
            ForeGround = _foreGround;
            Background = _background;
        }

        // Methods, what the class does

        public void Play()
        {
            // Call the private methods to do the work
            FlashLights();
            SetConsoleColors();
            Thread.Sleep(250); // add a delay

            Console.Clear(); // Clear the console;
            WriteAsciiArt();
        }


        // Private methods, break down the work into smaller pieces
        // the private methods are only available to the class itself
        private void FlashLights()
        {
            foreach (ConsoleColor color in Enum.GetValues(typeof(ConsoleColor)))
            {
                Console.BackgroundColor = color;
                Console.Clear();
                Thread.Sleep(1);
            }
        }

        private void SetConsoleColors()
        {
            Console.ForegroundColor = ForeGround;
            Console.BackgroundColor = Background;
        }

        private void WriteAsciiArt()
        {

            Console.WriteLine("***********************************************************************************************************");
            Console.WriteLine("*** ** *                       __                        _____            _                        * ** ***");
            Console.WriteLine("*** ** *                      / /   __ _ ______ _ _ __  /__   \\___   ___ | |___                    * ** ***");
            Console.WriteLine("*** ** *                     / /   / _` | _ / _' | '__|   / /\\/ _ \\ / _ \\| / __|                   * ** ***");
            Console.WriteLine("*** ** *                    / /___| (_| |/ / (_| | |     / / | (_) | (_) | \\__ \\                   * ** ***");
            Console.WriteLine("*** ** *                    \\_____/\\__,_/___\\__,_|_|     \\/   \\___/ \\___/|_|___/                   * ** ***");
            Console.WriteLine("*** ** *                                                                                           * ** ***");
            Console.WriteLine("***********************************************************************************************************");
        }
    }
}
