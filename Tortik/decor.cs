using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tortik
{
    internal class decor
    {
        private int f = 0;
        private int a = 100;
        private int b = 200;
        private int c = 300;
        private int n = 150;
        private int m = 120;
        private int y = 230;
        private int w = 530;
        static int posit = 0;

        static public int PriceD;

        public void vab9() 
        {
            ConsoleKeyInfo clavisha = Console.ReadKey();
            while (clavisha.Key != ConsoleKey.Enter)
            {
                if (clavisha.Key == ConsoleKey.DownArrow)
                {
                    if (posit < 6)
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
                Console.WriteLine("  Весенний - 230");
                Console.WriteLine("  Зимний - 230 ");
                Console.WriteLine("  Летний - 300 ");
                Console.WriteLine("  Осенний - 150");
                Console.WriteLine("  Анимешный - 300 ");
                Console.WriteLine("  Мультяшный - 530 ");
                Console.SetCursorPosition(0, posit);
                Console.WriteLine("->");
                clavisha = Console.ReadKey();
            }
        }
        public void summa9()
        {
            if (posit == 0)
            {
                Console.WriteLine("Ничего не выбрано из декора: " + f);
                PriceD = f;
                hi.tort.Decor = "Ничего не выбрано из декора";
            }
            else
            if (posit == 1)
            {
                Console.WriteLine("Выбран весенний декор : " + y);
                PriceD = y;
                hi.tort.Decor = "Выбран весенний декор";
            }
            else
            if (posit == 2)
            {
                Console.WriteLine("Выбран зимний декор: " + y);
                PriceD = y;
                hi.tort.Decor = "Выбран зимний декор";
            }
            else
            if (posit == 3)
            {
                Console.WriteLine("Выбран летний декор: " + c);
                PriceD = c;
                hi.tort.Decor = "Выбран летний декор";
            }
            else
            if (posit == 4)
            {
                Console.WriteLine("Выбран осенний декор: " + n);
                PriceD = n;
                hi.tort.Decor = "Выбран осенний декор";
            }
            else
            if (posit == 5)
            {
                Console.WriteLine("Выбран анимешный декора: " + c);
                PriceD = c;
                hi.tort.Decor = "Выбран анимешный декор";
            }
            else
            if (posit == 6)
            {
                Console.WriteLine("Выбран мультяшный декора: " + w);
                PriceD = w;
                hi.tort.Decor = "Выбран мультяшный декор";
            }
        }
        public void ditog()
        {
            decor decor = new decor();
            decor.summa9();
        }
    }
} 
