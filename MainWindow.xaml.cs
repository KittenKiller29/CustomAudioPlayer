using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading;

namespace CustomAudioPlayer
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DrawCanvasPillars();
        }
        //Устанавливает дефолтное состояние для анимации c анимацией падения столбцов до минимума
        private void SetDefaultAnimationState()
        {


            Thread.Sleep(10);
        }

        //Отрисовывает текущее состояние столбцов анимации
        private void DrawCanvasPillars()
        {
            int BetweenPillars = 6;
            int WidthPillars = 20;
            int LeftOffset = 4;
            int CanvasHeight = (int)BitAnimation.Height;

            BitAnimation.Children.Clear();
            for (int i = 0; i < GraphicHandler.PillarsCount; i++)
            {
                Rectangle Rect = new Rectangle
                {
                    Width = WidthPillars,
                    Height = GraphicHandler.PillarsArray[i],
                    Fill = GraphicHandler.PillarsColorsArray[i],
                    Stroke = GraphicHandler.PillarsColorsArray[i],
                    StrokeThickness = 2
                };

                Canvas.SetLeft(Rect, LeftOffset);
                Canvas.SetTop(Rect, CanvasHeight - GraphicHandler.PillarsArray[i]);
                BitAnimation.Children.Add(Rect);

                LeftOffset = LeftOffset + BetweenPillars + WidthPillars;
            }
        }
    }
}
