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
            Console.SetWindowSize(113, 51);
            //a enlever plus tard--------
            //Jeu jeu = new Jeu();
            //jeu.jeu();
            //---------------------------
            while (true)
            {
                //Console.CursorVisible = false;
                menu.MenuPrincipal();
            }
        }
    }
}
