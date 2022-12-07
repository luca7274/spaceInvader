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
            Menu menu = new Menu();
            //a enlever plus tard--------
            Console.SetWindowSize(113, 51);
            Jeu jeu = new Jeu();
            jeu.jeu();
            //---------------------------
            while (true)
            {
                //Console.CursorVisible = false;
                menu.MenuPrincipal();
            }
        }
    }
}
