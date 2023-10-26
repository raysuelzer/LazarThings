using LazarCalculator.AudioVisualEffects;
using LazarCalculator.Helpers;
using LazarCalculator.Tools;
using System;
using System.Diagnostics;


namespace LazarCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Combine the title tune and light show to play the intro
            // If you want to change intro you can do it in PlayIntro();
            PlayIntro();

            // Main menu
            LazarMenu();
        }

        static void PlayIntro()
        {
            // here is an example of creating a class and not using a static class
            // 98% of the time you will do this. You can imagine that you could reuse this class
            // but pass in a different ascii art or color
            var lightShow = new LightShow(ConsoleColor.Green, ConsoleColor.Black);
            lightShow.Play();


            // This is an example of using a static class becuase I am lazy            
            TitleTune.PlayTitleTune();
        }

        public static void LazarMenu()
        {
            // Display the menu and get user input            
            int menuChoice = ProgramMenu.MainMenuSelector();

            if (menuChoice == 1)
            {
                NoobCalculator.Start();
            }
            else if (menuChoice == 2)
            {
                BoltCircleCalc.Start();
            }
            else if (menuChoice == 3)
            {
                TitleTune.PlayTitleTune();
                LazarMenu();
            }
            else if (menuChoice == 4)
            {
                TJLoader.Start();
            }
            else if (menuChoice == 0)
            {
                Environment.Exit(0);
            }
            else
            {
                LazarMenu();
            }
        }
    }
}