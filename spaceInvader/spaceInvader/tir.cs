using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spaceInvader
{
    internal class Tir
    {
        private int _x;
        private int _y;
        private string _tir = " | ";
        public string _Tir
        {
            get { return _tir; }
            set { _tir = value; }
        }

        public Tir(int X, int Y)
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

    }
}
