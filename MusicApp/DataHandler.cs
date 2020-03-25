using System;
using System.Collections.Generic;
using System.Text;

namespace MusicApp
{
    class DataHandler
    {
        public List<Artist> artists = new List<Artist>();
        public List<Album> albums = new List<Album>();

        public void insertExampleArtists()
        {
            this.artists.Add(new Artist("Pink Floyd"));
            this.artists.Add(new Artist("Nirvana"));
        }

        public Artist createNewArtist()
        {
            Console.WriteLine("Anna artistin nimi");

            string artisti = Console.ReadLine();

            Artist newArtist = new Artist(artisti);

            // TESTAUS alkaa: siirto AddArtistToList():sta
            this.artists.Add(newArtist);

            Console.WriteLine("\nArtisti lisätty listaan");
            // TESTAUS päättyy: siirto AddArtistToList():sta

            Console.ReadKey();

            return newArtist;
        }

        //public Artist addArtistToList()
        //{
        //    var artist = createNewArtist();

        //    this.artists.Add(artist);

        //    Console.WriteLine("Artisti lisätty listaan");

        //    return artist;
        //}

        public void printArtistList()
        {
            Console.Clear();

            Console.WriteLine("ARTISTIT");
            
            for (int i = 0; i < this.artists.Count; i++)
            {
                Console.WriteLine($"{i+1}: {this.artists[i].artistName}");
            }

            Console.WriteLine("\n");

            Console.WriteLine("Syötetäänkö uusi artisti (K / E)?\n");

            string valinta = Console.ReadLine();

            if (valinta == "k" || valinta == "K")
            {
                Console.WriteLine("");
                createNewArtist();


            }
        }
    }
}
