using System.Drawing;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Tortik
{
    internal class pod
    {
        private int f = 0;
        private int a = 100;
        private int b = 200;
        private int c = 300;
        private int n = 150;
        private int m = 120;
        private int y = 230;
        static int posit = 0;
        public void vab4()
        {
            ConsoleKeyInfo clavisha = Console.ReadKey();
            while (true)
            {
                if (clavisha.Key == ConsoleKey.DownArrow)
                {
                    if (posit < 2)
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
                if (clavisha.Key == ConsoleKey.Enter)
                {
                    return;
                }
                else
                if (clavisha.Key == ConsoleKey.S)
                {
                    break;
                }
                Console.Clear();
                Console.WriteLine("Пункты:");
                Console.WriteLine("  Круг - 100");
                Console.WriteLine("  Квадрат - 200 ");
                Console.SetCursorPosition(0, posit);
                Console.WriteLine("->");
                clavisha = Console.ReadKey();
            }
        }
        public void summa4()
        {
            if (posit == 0)
            {
                Console.WriteLine("Ничего не выбрано из формы: " + f);
            }
            else if (posit == 1)
            {
                Console.WriteLine("Выбрана форма круг: " + a);
            }
            else if (posit == 2)
            {
                Console.WriteLine("Выбрана форма квадрат: " + b);
            }

        }
        public void yitog()
        {
            pod pod = new pod();
            pod.summa4();
        }
    }
}