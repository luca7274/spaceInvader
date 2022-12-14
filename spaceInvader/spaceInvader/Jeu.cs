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
        private bool alienDroite = true;
        private bool alienFin = false;
        private int alienBas = 6;
        private int alieSpeed = 2;

        int playerSpeed = 3;
        int alienMillisecond1 = 250;
        int alienMillisecond2 = 500;
        int alienMillisecond3 = 750;
        int alienMillisecond4 = 0;

        public void jeu()
        {
            Console.Clear();
            int nbAlienUneLigne = 7;
            int nbAlien = nbAlienUneLigne * 12;
            for(int x = 1; x < nbAlien; x += 13)
            {
                for(int y = 1; y <= 8; y += 4)
                {
                    alienList.Add(new Alien(x, y));

                }

            }

            afficherVaissau();
            afficherAlien();
            while (true)
            {
                bougerVaissau();
                bougerAlien();
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
        #region[bougerVaissau]
        public void bougerVaissau()
        {
            while (Console.KeyAvailable)
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
        #region[effacerAlien]
        public void effacerAlien()
        {
            for (int i = 0; i < alienList.Count; i++)

                for (int j = 0; j < alienList[i].ennemis.Length; j++)
                {
                    Console.SetCursorPosition(alienList[i].X, alienList[i].Y + j);
                    Console.Write("          ");
                }
        }
        #endregion
        #region[modifierPositionAlien]
        public void modifierPositionAlien()
        {
            int derAlien = alienList.Count - 1;
            int premAlien = 0;
            if (alienDroite == true && alienFin == false)
            {
                foreach (var alien in alienList)
                {
                    alien.X += alieSpeed;
                }
            }
            if(alienDroite == false && alienFin == false)
            {
                foreach (var alien in alienList)
                {
                    alien.X -= alieSpeed;
                }
            }
            if (alienList[derAlien].X >= 105)
            {
                alienDroite = false;
                foreach (var alien in alienList)
                {
                    alien.X -= 2;
                    alien.Y += alienBas;
                }
            }
            if (alienList[premAlien].X < 0)
            {
                alienDroite = true;
                foreach (var alien in alienList)
                {
                    alien.X += 2;
                    alien.Y += alienBas;
                }
            }
            if (alienList[derAlien].Y > 45)
            {
                alienFin = true;
            }
            if(alienFin == true)
            {
                foreach (var alien in alienList)
                {
                    afficherAlien();
                    Thread.Sleep(2000);
                    Menu menu = new Menu();
                    menu.MenuGameOver();
                }
            }
        }
        #endregion
        #region[bougerAlien]
        public void bougerAlien()
        {
            //date mise à jour à chaque appelle de la methode
            DateTime date = DateTime.Now;
            if(date.Millisecond == alienMillisecond1 || date.Millisecond == alienMillisecond2 || date.Millisecond == alienMillisecond3 || date.Millisecond == alienMillisecond4)
            {
                effacerAlien();
                modifierPositionAlien();
                afficherAlien();
            }
        }
        #endregion
        //todo generer les aliens
    }
}
