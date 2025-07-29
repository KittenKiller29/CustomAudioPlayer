using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace CustomAudioPlayer
{
    class GraphicHandler
    {
        //Массив, хранящий текущую высоту каждого столбца анимации
        static public int[] PillarsArray = {
            10, 10, 10,
            10, 10, 10,
            10, 10, 10,
            10, 10, 10,
            10, 10, 10,
            10, 10, 10
        };

        static public int PillarsCount { get; } = 18;

        static public SolidColorBrush[] PillarsColorsArray = {
            Brushes.Tomato, Brushes.Violet, Brushes.SkyBlue,
            Brushes.ForestGreen, Brushes.DarkOrange, Brushes.GreenYellow,
            Brushes.Purple, Brushes.Cyan, Brushes.DeepSkyBlue,
            Brushes.Yellow, Brushes.Brown, Brushes.Magenta,
            Brushes.Crimson, Brushes.MintCream, Brushes.Pink,
            Brushes.PaleVioletRed, Brushes.White, Brushes.Lime
        };


    }
}
