using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spaceInvader
{
    internal class vaissau
    {
        private int _x;
        private int _y;
        private static string[] _joueur = new string[3]
        {
            " ^ ",
            " █ ",
            "███"
        };

        public vaissau(int X, int Y)
        {
            _x = X;
            _y = Y;
        }
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
        public string[] Joueur
        {
            get { return _joueur; }
        }
    }
}
