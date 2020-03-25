using System;

namespace MusicApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var dh = new DataHandler();

            dh.insertExampleArtists();

            MainMenu mainMenu = new MainMenu(dh);
            mainMenu.InitializeMainMenu();

        }
    }
}
