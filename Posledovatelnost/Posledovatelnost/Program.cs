using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemanT_Library;

namespace Posledovatelnost
{
    class Program
    {
        private static int[] Posl;
        private static int n;
        private static void CreatePosl()
        {
            ColorMess.Yellow("\n Введите колличество чисел в последовательности (от 2 до 10): ");
            n = Input.Check(2, 10);
            Posl = new int[n];
            for(int i = 0; i<n; i++)
            {
                Console.Clear();
                ColorMess.Yellow("\n Введите " + (i+1) + " число последовательности: ");
                Posl[i] = Input.Check(int.MinValue, int.MaxValue);
            }
        }
        private static void PrintPosl()
        {
            for (int i = 0; i < n; i++)
                ColorMess.White(" " + Posl[i]);
        }
        private static void UpdatePosl()
        {
            for(int i = 0; i<n-1; i++)
                Posl[i] = Posl[i] - Posl[n-1];
        }
        static void Main()
        {
            CreatePosl();
            UpdatePosl();
            Console.Clear();
            ColorMess.Cyan("\n Ваша новая последовательность выглядит так: ");
            PrintPosl();
            Message.GoToBack();
        }
    }
}
