using System;
using System.Collections.Generic;
using System.Text;

namespace MusicApp
{
    class Album
    {
        public string albumName;
        public Artist artist;

        public Album()
        {

        }

        public Album(string albumName, Artist artist)
        {
            this.albumName = albumName;
            this.artist = artist;
        }
    }
}
