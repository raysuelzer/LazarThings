using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazarCalculator.AudioVisualEffects
{
    public class TitleTune
    {
        public static void PlayTitleTune()
        {
            Console.Beep(784, 225);
            Console.Beep(392, 225);
            Console.Beep(784, 225);
            Console.Beep(330, 225);
            Console.Beep(784, 225);
            Console.Beep(659, 225);
            Console.Beep(1047, 675);

            Thread.Sleep(2000);
            Console.Clear();
        }
    }
}
