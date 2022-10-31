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
                    if (posit > 1)
                    {
                        posit--;
                    }
                }
                else
                if (clavisha.Key == ConsoleKey.S)
                {
                    Console.Clear();
                    return;
                }
                else
                if (clavisha.Key == ConsoleKey.Enter)
                {
                    return;
                }
                Console.Clear();
                Console.WriteLine("Пункты:");
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
            }
            else
            if (posit == 1)
            {
                Console.WriteLine("Выбран весенний декора : " + y);
            }
            else
            if (posit == 2)
            {
                Console.WriteLine("Выбран зимний декора: " + y);
            }
            else
            if (posit == 3)
            {
                Console.WriteLine("Выбран летний декора: " + c);
            }
            else
            if (posit == 4)
            {
                Console.WriteLine("Выбран осеннтй декора: " + n);
            }
            else
            if (posit == 5)
            {
                Console.WriteLine("Выбран анимешный декора: " + c);
            }
            else
            if (posit == 6)
            {
                Console.WriteLine("Выбран мультяшный декора: " + w);
            }
        }
        public void ditog()
        {
            decor decor = new decor();
            decor.summa9();
        }
    }
} 
