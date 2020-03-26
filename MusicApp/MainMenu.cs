using System;
using System.Collections.Generic;
using System.Text;

namespace MusicApp
{
    class MainMenu
    {
        public DataHandler dh;

        public MainMenu(DataHandler datahandler)
        {
            this.dh = datahandler;
        }

        public void InitializeMainMenu()
        {
            bool ShowMenu = true;

            while (ShowMenu)
            {
                ShowMenu = ShowMainMenu();
            }
        }

        private bool ShowMainMenu()
        {
            Console.Clear();

            Console.Write("-", Console.ForegroundColor = ConsoleColor.Red);
            Console.Write("-", Console.ForegroundColor = ConsoleColor.Blue);
            Console.Write("-", Console.ForegroundColor = ConsoleColor.Red);
            Console.Write("-", Console.ForegroundColor = ConsoleColor.Blue);
            Console.Write("-", Console.ForegroundColor = ConsoleColor.Red);
            Console.Write("-", Console.ForegroundColor = ConsoleColor.Blue);
            Console.Write("-", Console.ForegroundColor = ConsoleColor.Red);
            Console.Write("-", Console.ForegroundColor = ConsoleColor.Blue);
            Console.Write("-", Console.ForegroundColor = ConsoleColor.Red);

            Console.WriteLine("");
            Console.WriteLine("MUSIC APP", Console.ForegroundColor = ConsoleColor.Magenta);

            Console.Write("-", Console.ForegroundColor = ConsoleColor.Blue);
            Console.Write("-", Console.ForegroundColor = ConsoleColor.Red);
            Console.Write("-", Console.ForegroundColor = ConsoleColor.Blue);
            Console.Write("-", Console.ForegroundColor = ConsoleColor.Red);
            Console.Write("-", Console.ForegroundColor = ConsoleColor.Blue);
            Console.Write("-", Console.ForegroundColor = ConsoleColor.Red);
            Console.Write("-", Console.ForegroundColor = ConsoleColor.Blue);
            Console.Write("-", Console.ForegroundColor = ConsoleColor.Red);
            Console.Write("-", Console.ForegroundColor = ConsoleColor.Blue);
            Console.WriteLine("");

            Console.ResetColor();

            Console.WriteLine("");
            Console.WriteLine("1 Anna artisti");
            Console.WriteLine("\t2 Tulosta artistilista");
            Console.WriteLine("3 Anna albumi");
            Console.WriteLine("\t4 Tulosta albumilista");

            //Console.WriteLine("\nLopeta [X]");

            Console.WriteLine("");
            Console.Write("Syötä valintasi: ");
            string selection = Console.ReadLine();
            int value;

            Console.WriteLine("");

            if(!int.TryParse(selection, out value)){
                Console.WriteLine("Et syöttänyt numeroa!", Console.ForegroundColor = ConsoleColor.Green);
                Console.ResetColor();
                Console.ReadKey();
            }

            else if (int.Parse(selection) != 1 && int.Parse(selection) != 2)
            {
                Console.WriteLine("Valitse joko 1 tai 2!", Console.ForegroundColor = ConsoleColor.Green);
                Console.ResetColor();
                Console.ReadKey();
            }

            else
            {
                int usersChoice = int.Parse(selection);

                switch (usersChoice)
                {
                    case 1:
                        dh.createNewArtist();
                        break;
                    default:
                        Console.Clear();
                        break;
                }
            }
            
            return true;
        }
    }
}
