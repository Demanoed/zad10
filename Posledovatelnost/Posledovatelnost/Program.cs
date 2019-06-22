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
            ColorMess.Yellow("\n Введите колличество чисел в последовательности (минимум 2): ");
            n = Input.Check(2, int.MaxValue);
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
        static void Main()
        {
            CreatePosl();
            ColorMess.Yellow("\n Ваша новая последовательность выглядит так: ");

        }
    }
}
