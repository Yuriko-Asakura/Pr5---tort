using System.Drawing;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Tortik
{
    /// <summary>
    /// Форма торта
    /// </summary>
    internal class pod
    {
        private int f = 0;
        private int a = 100;
        private int b = 200;
        private int c = 300;
        private int n = 150;
        private int m = 120;
        private int y = 230;

        public static int PriceF;

        static int posit = 0;
        public void vab4()
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
                Console.WriteLine("  Круг - 100");
                Console.WriteLine("  Квадрат - 200 ");
                Console.WriteLine("  Треугольник - 230 ");
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
                    PriceF = f;
                }
                else if (posit == 1)
                {
                    Console.WriteLine("Выбрана форма круг: " + a);
                    hi.tort.Forma = "Форма круг";
                    PriceF = a;
                }
                else if (posit == 2)
                {
                    Console.WriteLine("Выбрана форма квадрат: " + b);
                    hi.tort.Forma = "Форма квадрат";
                    PriceF = b;
                }
                else if (posit == 3)
                {
                    Console.WriteLine("Выбрана форма треугольник: " + y);
                    hi.tort.Forma = "Форма треугольник";
                    PriceF = y;
                }
        }
        public void yitog()
        {
            pod pod = new pod();
            pod.summa4();
        }
    }
}