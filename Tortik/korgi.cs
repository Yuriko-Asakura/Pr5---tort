using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tortik
{
    internal class korgi
    {
        private int f = 0;
        private int a = 100;
        private int b = 200;
        private int c = 300;
        private int n = 150;
        private int m = 120;
        private int y = 230;
        static int posit = 0;

        static public int PriceK;

        public void vab7()
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
                Console.WriteLine("  1 коржик - 150");
                Console.WriteLine("  2 коржик - 230 ");
                Console.WriteLine("  3 коржик - 300 ");
                Console.SetCursorPosition(0, posit);
                Console.WriteLine("->");
                clavisha = Console.ReadKey();
            }
        }
        public void summa7()
        {
            if (posit == 0)
            {
                Console.WriteLine("Ничего не выбрано из кол-ва коржей: " + f);
                PriceK = f;

            }
            else
            if (posit == 1)
            {
                Console.WriteLine("Выбран 1 коржик : " + n);
                PriceK = n;
                hi.tort.Korgi = "Выбран 1 коржик";
            }
            else
            if (posit == 2)
            {
                Console.WriteLine("Выбран 2 коржика : " + y);
                PriceK = y;
                hi.tort.Korgi = "Выбран 2 коржика";
            }
            else
            if (posit == 3)
            {
                Console.WriteLine("Выбран 3 коржика: " + c);
                PriceK = c;
                hi.tort.Korgi = "Выбран 3 коржика";
            }
        }
        public void kitog()
        {
            korgi korgi = new korgi();
            korgi.summa7();
        }
    }
}
