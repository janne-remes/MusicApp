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

        public Artist insertNewArtist()
        {
            Console.WriteLine("Anna artistin nimi");

            string artisti = Console.ReadLine();

            Artist newArtist = new Artist(artisti);

            return newArtist
        }
    }
}
