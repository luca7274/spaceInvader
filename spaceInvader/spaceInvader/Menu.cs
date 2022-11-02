using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spaceInvader
{
    internal class Menu
    {
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
                                             |_|                          ";
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
                                          |_|                |_|                ";
        public const string LEAVE = @"
                                                    _  _    _              
                                                   (_)| |  | |             
                                       __ _  _   _  _ | |_ | |_  ___  _ __ 
                                      / _` || | | || || __|| __|/ _ \| '__|
                                     | (_| || |_| || || |_ | |_|  __/| |   
                                      \__, | \__,_||_| \__| \__|\___||_|   
                                         | |                               
                                         |_|                               ";


    public void MenuPrincipal()
        {
            Console.SetWindowSize(113, 51);
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
            }
        }
    }
}
