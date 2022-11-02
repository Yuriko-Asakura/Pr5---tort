using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tortik
{
    internal class glazyr
    {
        private int f = 0;
        private int a = 100;
        private int b = 200;
        private int c = 300;
        private int n = 150;
        private int m = 120;
        private int y = 230;
        static int posit = 0;

        static public int PriceG;

        public void vab8()
        {
            ConsoleKeyInfo clavisha = Console.ReadKey();
            while (clavisha.Key != ConsoleKey.Enter)
            {
                if (clavisha.Key == ConsoleKey.DownArrow)
                {
                    if (posit < 4)
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
                Console.WriteLine("  Шоколадная - 150");
                Console.WriteLine("  Молочная - 230 ");
                Console.WriteLine("  Сливочная - 300 ");
                Console.WriteLine("  Сметанная - 200 ");
                Console.SetCursorPosition(0, posit);
                Console.WriteLine("->");
                clavisha = Console.ReadKey();
            }
        }
        public void summa8()
        {
            if (posit == 0)
            {
                Console.WriteLine("Ничего не выбрано из глазури: " + f);
                PriceG = f;
                hi.tort.Glazur = "Ничего не выбрано из глазури";
            }
            else
            if (posit == 1)
            {
                Console.WriteLine("Выбрана шоколадная глазурь : " + n);
                PriceG = n;
                hi.tort.Glazur = "Выбрана шоколадная глазурь";
            }
            else
            if (posit == 2)
            {
                Console.WriteLine("Выбрана молочная глазурь : " + y);
                PriceG = y;
                hi.tort.Glazur = "Выбрана молочная глазурь";
            }
            else
            if (posit == 3)
            {
                Console.WriteLine("Выбрана сливочная глазурь: " + c);
                PriceG = c;
                hi.tort.Glazur = "Выбрана сливочная глазурь";
            }
            else
            if (posit == 3)
            {
                Console.WriteLine("Выбрана сметанная глазурь: " + b);
                PriceG = b;
                hi.tort.Glazur = "Выбрана сметанная глазурь";
            }
        }
        public void gitog()
        {
            glazyr glazyr = new glazyr();
            glazyr.summa8();
        }
    }
}
