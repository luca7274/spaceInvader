using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spaceInvader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(113, 51);
            Console.Write(Menu.TITLE);
            Console.Write(Menu.PLAY);
            Console.Write(Menu.OPTION);
            Console.Write(Menu.HIGHSCORE);
            Console.Write(Menu.ABOUT);
            Console.Write(Menu.LEAVE);

            int positionX = 30;
            int positionY = 15;
            Console.SetCursorPosition(positionX,positionY);
            while (true)
            {
                ConsoleKeyInfo keys = Console.ReadKey();
                if(keys.Key == ConsoleKey.DownArrow)
                {
                    if(positionY > 14)
                    Console.SetCursorPosition(1, 1);
                }
            }
            Console.ReadLine();
        }
    }
}
