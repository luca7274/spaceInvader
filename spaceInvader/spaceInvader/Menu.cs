using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace spaceInvader
{
    internal class Menu
    {
        #region[tritre]
        public const string TITLE = @"
                     (                               (                                        
                     )\ )                            )\ )                     (               
                    (()/(           )         (     (()/(         )       )   )\ )   (   (    
                     /(_))`  )   ( /(   (    ))\     /(_)) (     /((   ( /(  (()/(  ))\  )(   
                    (_))  /(/(   )(_))  )\  /((_)   (_))   )\ ) (_))\  )(_))  ((_))/((_)(()\  
                    / __|((_)_\ ((_)_  ((_)(_))     |_ _| _(_/( _)((_)((_)_   _| |(_))   ((_) 
                    \__ \| '_ \)/ _` |/ _| / -_)     | | | ' \))\ V / / _` |/ _` |/ -_) | '_| 
                    |___/| .__/ \__,_|\__| \___|    |___||_||_|  \_/  \__,_|\__,_|\___| |_|   
                         |_|                                                                
                                                                        ";

        public const string PLAY = @"
                                           _                           
                                          (_)                          
                                           _   ___   _   _   ___  _ __ 
                                          | | / _ \ | | | | / _ \| '__|
                                          | || (_) || |_| ||  __/| |   
                                          | | \___/  \__,_| \___||_|   
                                         _/ |                          
                                        |__/                           ";
        public const string OPTION = @"
                                                     _    _               
                                                    | |  (_)              
                                        ___   _ __  | |_  _   ___   _ __  
                                       / _ \ | '_ \ | __|| | / _ \ | '_ \ 
                                      | (_) || |_) || |_ | || (_) || | | |
                                       \___/ | .__/  \__||_| \___/ |_| |_|
                                             | |                          
                                             |_|                         ";
        public const string HIGHSCORE = @"                                                        
                                           ___   ___  ___   _ __  ___ 
                                          / __| / __|/ _ \ | '__|/ _ \
                                          \__ \| (__| (_) || |  |  __/
                                          |___/ \___|\___/ |_|   \___|     

                                                                          ";
        public const string ABOUT = @"                                      
                                    __ _   _ __   _ __  ___   _ __    ___   ___ 
                                   / _` | | '_ \ | '__|/ _ \ | '_ \  / _ \ / __|
                                  | (_| | | |_) || |  | (_) || |_) || (_) |\__ \
                                   \__,_| | .__/ |_|   \___/ | .__/  \___/ |___/
                                          | |                | |                
                                          |_|                |_|          ";
        public const string LEAVE = @"
                                                    _  _    _              
                                                   (_)| |  | |             
                                       __ _  _   _  _ | |_ | |_  ___  _ __ 
                                      / _` || | | || || __|| __|/ _ \| '__|
                                     | (_| || |_| || || |_ | |_|  __/| |   
                                      \__, | \__,_||_| \__| \__|\___||_|   
                                         | |                               
                                         |_|                               ";
        public const string SURETOLEAVE = @"
                                           _                                           
                                          | |                                          
                         __   _____  _   _| | ___ ____  ______  __   _____  _   _ ___  
                         \ \ / / _ \| | | | |/ _ \_  / |______| \ \ / / _ \| | | / __| 
                          \ V / (_) | |_| | |  __// /            \ V / (_) | |_| \__ \ 
                           \_/ \___/ \__,_|_|\___/___|            \_/ \___/ \__,_|___/ 
                                                    _ _   _                            
                                                   (_) | | |                           
                                         __ _ _   _ _| |_| |_ ___ _ __                 
                                        / _` | | | | | __| __/ _ \ '__|                
                                       | (_| | |_| | | |_| ||  __/ |                   
                                        \__, |\__,_|_|\__|\__\___|_|                   
                                           | |                                         
                                           |_|                                         
                                                                          ";
        public const string YESNO = @"
                                              _                                
                                             (_)                               
                                   ___  _   _ _              _ __   ___  _ __  
                                  / _ \| | | | |            | '_ \ / _ \| '_ \ 
                                 | (_) | |_| | |            | | | | (_) | | | |
                                  \___/ \__,_|_|            |_| |_|\___/|_| |_|
                                                                          ";
        public const string BESTSCORE = @"
                                        _ _ _                                           
                         _ __ ___   ___(_) | | ___ _   _ _ __   ___  ___ ___  _ __ ___  
                        | '_ ` _ \ / _ \ | | |/ _ \ | | | '__| / __|/ __/ _ \| '__/ _ \ 
                        | | | | | |  __/ | | |  __/ |_| | |    \__ \ (_| (_) | | |  __/ 
                        |_| |_| |_|\___|_|_|_|\___|\__,_|_|    |___/\___\___/|_|  \___| 
                                                                          ";
        public const string LASTSCORE = @"
                              _                 _                                     
                           __| | ___ _ __ _ __ (_) ___ _ __   ___  ___ ___  _ __ ___  
                          / _` |/ _ \ '__| '_ \| |/ _ \ '__| / __|/ __/ _ \| '__/ _ \ 
                         | (_| |  __/ |  | | | | |  __/ |    \__ \ (_| (_) | | |  __/ 
                          \__,_|\___|_|  |_| |_|_|\___|_|    |___/\___\___/|_|  \___| 
                                                                          ";
        public const string MUSIC = @"              
                                                         _               _
                                           _____ _ _ ___|_|___ _ _ ___  |_|
                                          |     | | |_ -| | . | | | -_|  _
                                          |_|_|_|___|___|_|_  |___|___| |_|
                                                            |_|        
                                                                          ";
        public const string DIFICULTY = @"    
                                         _ _ ___ ___ _         _ _         _
                                       _| |_|  _|  _|_|___ _ _| | |_ ___  |_|
                                      | . | |  _|  _| |  _| | | |  _| -_|  _
                                      |___|_|_| |_| |_|___|___|_|_| |___| |_|
                                                                          ";
        public const string EASY = @"        
                                               ___         _ _     
                                              |  _|___ ___|_| |___ 
                                              |  _| .'|  _| | | -_|
                                              |_| |__,|___|_|_|___|
                                                                          ";
        public const string HARD = @"
                                             _ _ ___ ___ _     _ _     
                                           _| |_|  _|  _|_|___|_| |___ 
                                          | . | |  _|  _| |  _| | | -_|
                                          |___|_|_| |_| |_|___|_|_|___|
                                                                          ";
        public const string ON = @"
                                                                                                
                                                                                                
                                                                                 ___ ___       
                                                                                | . |   |        
                                                                                |___|_|_|      
                                                                          ";
        public const string OFF = @"
                                                                                     ___ ___ 
                                                                                 ___|  _|  _|
                                                                                | . |  _|  _|
                                                                                |___|_| |_|  
                                                                          ";
        #endregion

        #region[menuPrincipal]
        public void MenuPrincipal()
        {
            Console.SetWindowSize(113, 51);
            Console.Clear();
            Console.Write(Menu.TITLE);
            Console.Write(Menu.PLAY);
            Console.Write(Menu.OPTION);
            Console.Write(Menu.HIGHSCORE);
            Console.Write(Menu.ABOUT);
            Console.Write(Menu.LEAVE);

            string fleche = "--->";
            int positionX = 29;
            int positionY = 15;
            Console.SetCursorPosition(positionX, positionY);
            Console.Write(fleche);
            Console.SetCursorPosition(positionX, positionY);
            while (true)
            {
                #region[flecheBas]
                ConsoleKeyInfo keys = Console.ReadKey();
                if (keys.Key == ConsoleKey.DownArrow)
                {
                    Console.Write("   ");
                    switch (positionY)
                    {
                        case 15:
                            Console.Write("   ");
                            positionY += 8;
                            Console.SetCursorPosition(positionX, positionY);
                            Console.Write(fleche);
                            Console.SetCursorPosition(positionX, positionY);
                            break;
                        case 23:
                            Console.SetCursorPosition(positionX, positionY);
                            Console.Write("   ");
                            positionY += 7;
                            Console.SetCursorPosition(positionX, positionY);
                            Console.Write(fleche);
                            Console.SetCursorPosition(positionX, positionY);
                            break;
                        case 30:
                            positionY += 6;
                            Console.SetCursorPosition(positionX, positionY);
                            Console.Write(fleche);
                            Console.SetCursorPosition(positionX, positionY);
                            break;
                        case 36:
                            positionY += 8;
                            Console.SetCursorPosition(positionX, positionY);
                            Console.Write(fleche);
                            Console.SetCursorPosition(positionX, positionY);
                            break;
                        case 44:
                            positionY = 15;
                            Console.SetCursorPosition(positionX, positionY);
                            Console.Write(fleche);
                            Console.SetCursorPosition(positionX, positionY);
                            break;
                    }
                }
                #endregion
                #region[flecheHaut]
                if (keys.Key == ConsoleKey.UpArrow)
                {
                    switch (positionY)
                    {
                        case 15:
                            Console.Write("   ");
                            positionY = 44;
                            Console.SetCursorPosition(positionX, positionY);
                            Console.Write(fleche);
                            Console.SetCursorPosition(positionX, positionY);
                            Console.SetCursorPosition(positionX, positionY);
                            break;
                        case 23:
                            Console.Write("   ");
                            positionY -= 8;
                            Console.SetCursorPosition(positionX, positionY);
                            Console.Write(fleche);
                            Console.SetCursorPosition(positionX, positionY);
                            break;
                        case 30:
                            Console.Write("   ");
                            positionY -= 7;
                            Console.SetCursorPosition(positionX, positionY);
                            Console.Write(fleche);
                            Console.SetCursorPosition(positionX, positionY);
                            break;
                        case 36:
                            Console.Write("   ");
                            positionY -= 6;
                            Console.SetCursorPosition(positionX, positionY);
                            Console.Write(fleche);
                            Console.SetCursorPosition(positionX, positionY);
                            break;
                        case 44:
                            Console.Write("   ");
                            positionY -= 8;
                            Console.SetCursorPosition(positionX, positionY);
                            Console.Write(fleche);
                            Console.SetCursorPosition(positionX, positionY);
                            break;
                    }
                }
                #endregion
                #region[enter]
                if (keys.Key == ConsoleKey.Enter)
                {
                    switch (positionY)
                    {
                        case 15:

                            break;
                        case 23:
                            MenuOption();
                            break;
                        case 30:
                            MenuScore();
                            break;
                        case 36:
                            MenuAPropos();
                            break;
                        case 44:
                            MenuQuitter();
                            break;
                    }
                }
                #endregion

            }
        }
        #endregion
        #region[menuOption]
        public void MenuOption()
        {
            Console.Clear();
            Console.Write(OPTION + "\n\n\n");
            Console.Write(OFF);
            Console.SetCursorPosition(0,11);
            Console.Write(MUSIC + "\n\n");
            Console.Write(DIFICULTY + "\n\n");
            Console.Write(EASY + "\n\n");
            Console.Write(HARD + "\n\n");

            bool music = false;
            bool hard = false;

            int positionX = 46;
            int positionY = 31;
            Console.SetCursorPosition(positionX, positionY);
            Console.Write("_____________________");

            string fleche = "--->";
            positionX = 34;
            positionY = 14;
            Console.SetCursorPosition(positionX, positionY);
            Console.Write(fleche);
            Console.SetCursorPosition(positionX, positionY);
            while (true)
            {
                #region[flecheBas]
                ConsoleKeyInfo keys = Console.ReadKey();
                if (keys.Key == ConsoleKey.DownArrow)
                {
                    Console.Write("   ");
                    switch (positionY)
                    {
                        case 14:
                            Console.Write("   ");
                            positionY += 15;
                            Console.SetCursorPosition(positionX, positionY);
                            Console.Write(fleche);
                            Console.SetCursorPosition(positionX, positionY);
                            break;
                        case 29:
                            Console.SetCursorPosition(positionX, positionY);
                            Console.Write("   ");
                            positionY += 7;
                            Console.SetCursorPosition(positionX, positionY);
                            Console.Write(fleche);
                            Console.SetCursorPosition(positionX, positionY);
                            break;
                        case 36:
                            positionY = 14;
                            Console.SetCursorPosition(positionX, positionY);
                            Console.Write(fleche);
                            Console.SetCursorPosition(positionX, positionY);
                            break;
                    }
                }
                #endregion
                #region[flecheHaut]
                if (keys.Key == ConsoleKey.UpArrow)
                {
                    Console.Write("   ");
                    switch (positionY)
                    {
                        case 14:
                            Console.Write("   ");
                            positionY = 36;
                            Console.SetCursorPosition(positionX, positionY);
                            Console.Write(fleche);
                            Console.SetCursorPosition(positionX, positionY);
                            break;
                        case 29:
                            Console.SetCursorPosition(positionX, positionY);
                            Console.Write("   ");
                            positionY -= 15;
                            Console.SetCursorPosition(positionX, positionY);
                            Console.Write(fleche);
                            Console.SetCursorPosition(positionX, positionY);
                            break;
                        case 36:
                            positionY -= 7;
                            Console.SetCursorPosition(positionX, positionY);
                            Console.Write(fleche);
                            Console.SetCursorPosition(positionX, positionY);
                            break;
                    }
                }
                #endregion
                #region[flecheEnter]
                if (keys.Key == ConsoleKey.Enter)
                {
                    switch (positionY)
                    {
                        case 14:
                            if(music == false)
                            {
                                music = true;
                                Console.SetCursorPosition(0,10);
                                Console.Write(ON);
                                Console.SetCursorPosition(0, 11);
                                Console.Write(MUSIC);
                                Console.SetCursorPosition(positionX, positionY);
                            }
                            else
                            {
                                music = false;
                                Console.SetCursorPosition(0, 11);
                                Console.Write(OFF);
                                Console.SetCursorPosition(0, 11);
                                Console.Write(MUSIC);
                                Console.SetCursorPosition(positionX, positionY);
                            }

                            break;
                        case 29:
                            if(hard == false)
                            {
                                Console.SetCursorPosition(positionX, positionY);
                            }
                            else
                            {
                                hard = false;
                                positionX = 42;
                                positionY = 38;
                                Console.SetCursorPosition(positionX, positionY);
                                Console.Write("                             ");

                                positionX = 46;
                                positionY = 31;
                                Console.SetCursorPosition(positionX, positionY);
                                Console.Write("_____________________");
                                positionX = 34;
                                positionY = 29;
                                Console.SetCursorPosition(positionX, positionY);
                            }
                            break;
                        case 36:
                            if(hard == false)
                            {
                                hard = true;
                                positionX = 46;
                                positionY = 31;
                                Console.SetCursorPosition(positionX, positionY);
                                Console.Write("                      ");

                                positionX = 42;
                                positionY = 38;
                                Console.SetCursorPosition(positionX, positionY);
                                Console.Write("_____________________________");
                                positionX = 34;
                                positionY = 36;
                                Console.SetCursorPosition(positionX, positionY);
                            }
                            else
                            {
                                Console.SetCursorPosition(positionX, positionY);
                            }
                            break;
                    }
                }
                #endregion
                #region[backspace]
                if (keys.Key == ConsoleKey.Backspace)
                {
                    string path = "optionData.txt";
                    string text = "music: " + music + Environment.NewLine + "hard: " + hard;
                    File.WriteAllText(path, text);
                    //permet de lire le fichier txt et de verrifier les valleur

                    //foreach (string line in File.ReadAllLines(path))
                    //{
                    //    if (line == "music: True")
                    //    {
                    //        Console.WriteLine("ca marche");
                    //    }
                    //}
                    MenuPrincipal();
                }
                #endregion
            }

        }
        #endregion
        #region[menuScore]
        public void MenuScore()
        {
            Console.Clear();
            Console.Write(HIGHSCORE + "\n\n\n\n\n");
            Console.Write(BESTSCORE + "\n\n\n\n\n\n\n\n\n\n\n\n\n");
            Console.Write(LASTSCORE);
            //todo
            string path = "scoreData.txt";
            string[] message = { "hello", "toi" };
            File.WriteAllLines(path, message);
            string[] lignes = File.ReadAllLines(path);
            foreach(string ligneline in lignes)
            {
                Console.WriteLine(ligneline[1]);
            }
            foreach(string line in File.ReadLines(path))
            {
                if (line.Contains("test2"))
                {
                    Console.WriteLine(line);
                }
            }
            //fin todo

            ConsoleKeyInfo keys = Console.ReadKey();
            if (keys.Key == ConsoleKey.Backspace)
            {
                MenuPrincipal();
            }
        }
        #endregion
        #region[menuAPropos]
        public void MenuAPropos()
        {
            Console.Clear();
            Console.Write(ABOUT + "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");


            ConsoleKeyInfo keys = Console.ReadKey();
            if (keys.Key == ConsoleKey.Backspace)
            {
                MenuPrincipal();
            }
        }
        #endregion
        #region[menuQuitter]
        public void MenuQuitter()
        {
            Console.Clear();
            Console.Write(SURETOLEAVE + "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
            Console.Write(YESNO);

            string fleche = "--->";
            int positionX = 27;
            int positionY = 40;
            Console.SetCursorPosition(positionX, positionY);
            Console.Write(fleche);
            Console.SetCursorPosition(positionX, positionY);

            while (true)
            {
                #region[fleche droit]
                ConsoleKeyInfo keys = Console.ReadKey();
                if (keys.Key == ConsoleKey.RightArrow)
                {
                    switch (positionX)
                    {
                        case 27:
                            Console.Write("   ");
                            positionX += 27;
                            Console.SetCursorPosition(positionX, positionY);
                            Console.Write(fleche);
                            Console.SetCursorPosition(positionX, positionY);
                            break;
                    }
                }
                #endregion
                #region[fleche gauche]
                if (keys.Key == ConsoleKey.LeftArrow)
                {
                    switch (positionX)
                    {
                        case 54:
                            Console.Write("   ");
                            positionX -= 27;
                            Console.SetCursorPosition(positionX, positionY);
                            Console.Write(fleche);
                            Console.SetCursorPosition(positionX, positionY);
                            break;
                    }
                }
                #endregion
                #region[enter]
                if (keys.Key == ConsoleKey.Enter)
                {
                    switch (positionX)
                    {
                        case 27:
                            Environment.Exit(0);
                            break;
                        case 54:
                            MenuPrincipal();
                            break;
                    }
                }
                #endregion
            }
        }
        #endregion
    }
}
