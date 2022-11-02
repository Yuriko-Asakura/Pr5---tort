using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tortik
{
    internal class Razmer
    {
        private int f = 0;
        private int a = 100;
        private int b = 200;
        private int c = 300;
        private int n = 150;
        private int m = 120;
        private int y = 230;
        static int posit = 0;

        public static int PriceR;

        public void vab5()
        {
            ConsoleKeyInfo clavisha = Console.ReadKey();
            while (clavisha.Key != ConsoleKey.Enter)
            {
                if (clavisha.Key == ConsoleKey.DownArrow)
                {
                    if (posit < 3)
                    {
                        posit++;
                    }
                }
                else
                if (clavisha.Key == ConsoleKey.UpArrow)
                {
                    if (posit > 0)
                    {
                        posit--;
                    }
                }
                Console.Clear();
                Console.WriteLine("  Вернуться в главное меню:");
                Console.WriteLine("  Маленький - 100");
                Console.WriteLine("  Средний - 200 ");
                Console.WriteLine("  Большой - 300 ");
                Console.SetCursorPosition(0, posit);
                Console.WriteLine("->");
                clavisha = Console.ReadKey();
            }
        }
        public void summa5()
        {
            if (posit == 0)
            {
                Console.WriteLine("Ничего не выбрано из размера: " + f);
                PriceR = f;
            }
            else
            if (posit == 1)
            {
                PriceR = a;
                hi.tort.Razmer = "Маленький";
                Console.WriteLine("Выбрпн маленький размер: " + a);
            }
            else
            if (posit == 2)
            {
                PriceR = b;
                hi.tort.Razmer = "Средний";
                Console.WriteLine("Выбран средний размер: " + b);
            }
            else
            if (posit == 3)
            {
                PriceR = c;
                hi.tort.Razmer = "Большой";
                Console.WriteLine("Выбран большой размер: " + c);
            }
        }
        public void itog()
        {
            Razmer Razmer = new Razmer();
            Razmer.summa5();
        }
    }
}
