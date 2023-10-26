using System;
using System.Media;
using System.Windows;

namespace LazarCalculator.AudioVisualEffects
{
    public class TitleTune
    {
        public static void PlayTitleTune()
        {
            Console.Beep(440, 50);
            Console.Beep(220, 50);
            Console.Beep(440, 50);
        }
    }
}
