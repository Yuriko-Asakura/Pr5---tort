using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tortik
{
    internal class vkys
    {
        private int f = 0;
        private int a = 100;
        private int b = 200;
        private int c = 300;
        private int n = 150;
        private int m = 120;
        private int y = 230;
        static int posit = 0;

        static public int PriceV;

        public void vab6()
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
                Console.WriteLine("  Ванильный - 150");
                Console.WriteLine("  Шоколадный - 200 ");
                Console.WriteLine("  Ягодный - 300 ");
                Console.SetCursorPosition(0, posit);
                Console.WriteLine("->");
                clavisha = Console.ReadKey();
            }
        }
        public void summa6()
        {
            if (posit == 0)
            {
                Console.WriteLine("Ничего не выбрано из вкуса: " + f);
                PriceV = f;
            }
            else
            if (posit == 1)
            {
                Console.WriteLine("Выбран ванильный вкус : " + n);
                PriceV = n;
                hi.tort.Vkus = "ванильный вкус";
            }
            else
            if (posit == 2)
            {
                hi.tort.Vkus = "Шоколадный вкус";
                Console.WriteLine("Выбран шоколадный вкус : " + b);
                PriceV = b;
            }
            else
            if (posit == 3)
            {
                Console.WriteLine("Выбран ягодный вкус: " + c);
                PriceV = c;
                hi.tort.Vkus = "ягодный вкус";
            }
        }
        public void vitog()
        {
            vkys vkys = new vkys();
            vkys.summa6();
        }

    }
}
