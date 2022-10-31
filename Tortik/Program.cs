using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tortik;

namespace Tortik
{
    internal class hi
    {
        static int posit = 5;
       
        static void Main()
        {
            
            ConsoleKeyInfo clavisha = Console.ReadKey();
            while (clavisha.Key != ConsoleKey.Enter)
            {
                if (clavisha.Key == ConsoleKey.DownArrow)
                {
                    if (posit < 10)
                    {
                        posit++;
                    }
                }
                else
                if (clavisha.Key == ConsoleKey.UpArrow)
                {
                    if (posit > 4)
                    {
                        posit--;
                    }
                }
                Console.Clear();
                Console.WriteLine("Добро пожпловать в конструктов тортов!" +
                      "\nДля того что бы выберить пункт используйте стрелки вверх и вниз.\n" +
                       "Что бы зайти в пункт нажмите энтер, что бы вернуться нажмите на клавишу s");
                Console.WriteLine("Выберите один из пунктов");
                Console.WriteLine("  Форма");
                Console.WriteLine("  Размер");
                Console.WriteLine("  Вкус");
                Console.WriteLine("  Количество коржей");
                Console.WriteLine("  Глазурь");
                Console.WriteLine("  Декор");
                Console.WriteLine("  Я закончил :3 ");
                Console.WriteLine("--------");
                Razmer Razmer = new Razmer();
                Razmer.itog();
                pod pod = new pod();
                pod.yitog();
                vkys vkys = new vkys();
                vkys.vitog();
                korgi korgi = new korgi();
                korgi.kitog();
                glazyr glazyr = new glazyr();
                glazyr.gitog();
                decor decor = new decor();
                decor.ditog();
                Console.SetCursorPosition(0, posit);
                Console.WriteLine("->");
                clavisha = Console.ReadKey();
            }
            gag();
        }
        static void gag()
        {
            ConsoleKeyInfo clavisha = Console.ReadKey();
            if (posit == 10)
            {
                Console.Clear();
                Console.WriteLine("Вы вышли из программы!\n Ваш заказ:");
                Razmer Razmer = new Razmer();
                Razmer.itog();
                pod pod = new pod();
                pod.yitog();
                vkys vkys = new vkys();
                vkys.vitog();
                korgi korgi = new korgi();
                korgi.kitog();
                glazyr glazyr = new glazyr();
                glazyr.gitog();
                decor decor = new decor();
                decor.ditog();
            }
            if (posit == 4)
            {
                Console.Clear();
                pod pod = new pod();
                pod.vab4();
                if (clavisha.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    Main();
                }
                if (clavisha.Key == ConsoleKey.S)
                {
                    Console.Clear();
                    Main();
                }
            }
            else
            if (posit == 5)
            {
                Console.Clear();
                Razmer Razmer = new Razmer();
                Razmer.vab5();
                if (clavisha.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    Main();
                }
                if (clavisha.Key == ConsoleKey.S)
                {
                    Console.Clear();
                    Main();
                }
            }
            else
            if (posit == 6)
            {
                Console.Clear();
                vkys vkys = new vkys();
                vkys.vab6();
                if (clavisha.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    Main();
                }
                if (clavisha.Key == ConsoleKey.S)
                {
                    Console.Clear();
                    Main();
                }
            }
            else
            if (posit == 7)
            {
                Console.Clear();
                korgi korgi = new korgi();
                korgi.vab7();
                if (clavisha.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    Main();
                }
                if (clavisha.Key == ConsoleKey.S)
                {
                    Console.Clear();
                    Main();
                }
            }
            else
            if (posit == 8)
            {
                Console.Clear();
                glazyr glazyr = new glazyr();
                glazyr.vab8();
                if (clavisha.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    Main();
                }
                if (clavisha.Key == ConsoleKey.S)
                {
                    Console.Clear();
                    Main();
                }
            }
            else
            if (posit == 9)
            {
                Console.Clear();
                decor decor = new decor();
                decor.vab9();
                if (clavisha.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    Main();
                }
                if (clavisha.Key == ConsoleKey.S)
                {
                    Console.Clear();
                    Main();
                }
            }
        }
    }
}
