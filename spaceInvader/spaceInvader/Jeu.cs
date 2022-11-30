using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spaceInvader
{
    internal class Jeu
    {
        private vaissau _vaissau = new vaissau(56, 48); 
        public void jeu()
        {
            Console.Clear();
            int playerSpeed = 3;
            afficherVaissau();
            while (true)
            {
                #region[flecheDroit]
                ConsoleKeyInfo keys = Console.ReadKey();
                if (keys.Key == ConsoleKey.RightArrow)
                {
                    effacerVaissau();
                    _vaissau.X += playerSpeed;
                    if(_vaissau.X < 113)
                    {
                        afficherVaissau();
                    }
                    else
                    {
                        _vaissau.X -= playerSpeed;
                        afficherVaissau();
                    }
                }
                #endregion
                #region[flecheGauche]
                if (keys.Key == ConsoleKey.LeftArrow)
                {
                    effacerVaissau();
                    _vaissau.X -= playerSpeed;
                    if(_vaissau.X > 0)
                    {
                        afficherVaissau();
                    }
                    else
                    {
                        _vaissau.X += playerSpeed;
                        afficherVaissau();
                    }
                }
                #endregion
            }


        }
        #region[afficherVaissau]
        public void afficherVaissau()
        {
            for (int i = 0; i < _vaissau.Joueur.Length; i++)
            {
                Console.SetCursorPosition(_vaissau.X, _vaissau.Y + i);
                Console.Write(_vaissau.Joueur[i]);
            }
        }
        #endregion
        #region[effacerVaissau]
        public void effacerVaissau()
        {
            for (int i = 0; i < _vaissau.Joueur.Length; i++)
            {
                Console.SetCursorPosition(_vaissau.X, _vaissau.Y + i);
                Console.Write("   ");
            }
        }
        #endregion
        //todo generer les aliens
    }
}
