using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace spaceInvader
{
    internal class Jeu
    {
        private vaissau _vaissau = new vaissau(56, 48);
        private List<Alien> alienList = new List<Alien>();
        //private Alien _alien = new Alien(1, 1);
        public void jeu()
        {
            Console.Clear();
            int playerSpeed = 3;
            int nbAlienUneLigne = 2;
            int nbAlien = nbAlienUneLigne * 12;
            for(int x = 1; x < nbAlien; x += 13)
            {
                for(int y = 1; y <= 8; y += 4)
                {
                    alienList.Add(new Alien(x, y));

                }

            }
            for(int i = 0; i < alienList.Count; i++)
            {
                Console.WriteLine(alienList[i].X + " " + alienList[i].Y);

            }
            afficherAlien();



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

        #region[afficherAlein]
        public void afficherAlien()
        {
            for(int i = 0; i < alienList.Count; i++)
            {
                for(int j = 0; j < alienList[i].ennemis.Length; j++)
                {
                    Console.SetCursorPosition(alienList[i].X, alienList[i].Y + j);
                    Console.Write(alienList[i].ennemis[j]);
                }
            }
        }
        #endregion

        //#region[effacerAlien]
        //public void effacerAlien()
        //{
        //    for(int i = 0; i < alienList.Count; i++)

        //    for (int i = 0; i < _alien.ennemis.Length; i++)
        //    {
        //        Console.SetCursorPosition(_alien.X, _alien.Y + i);
        //        Console.Write("          ");
        //    }
        //}
        //#endregion
        //todo generer les aliens
    }
}
