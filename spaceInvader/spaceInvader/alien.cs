using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spaceInvader
{
    internal class Alien
    {
        private int _x;
        private int _y;
        private static string[] _aliens = new string[4]
        {
               "  ▀▄  ▄▀  ",
               " ▄█▀██▀█▄ ",
               "█ █▀▀▀▀█ █",
               "   ▀  ▀   ",
        };
        public int X
        {
            get { return _x; }
            set { _x = value; }
        }
        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }
        public string[] Aliens
        {
            get { return _aliens; }
        }
        public Alien(int X, int Y)
        {
            _x = X;
            _y = Y;
        }
    }
}
