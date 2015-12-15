using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Music
{
    class Album
    {
        Song[] songs = new Song[0];
        public Genre Genre { get; set; }

        public Song this[int index]
        {
            get
            {
                if (index >= 0 && index < songs.Length)
                {
                    return songs[index];
                }
                throw  new IndexOutOfRangeException();
                
            }

        }

        public void AddSong(Song song)
        {
            Song[] temporarySongs = new Song[songs.Length + 1];
            for (int i = 0; i < songs.Length; i++)
            {
                temporarySongs[i] = songs[i];
            }
            temporarySongs[temporarySongs.Length - 1] = song;
            songs = temporarySongs;
        }

        public void RemoveSong(Song song)
        {
            int indexToRemove = GetSongIndex(song);
            Song[] temporarySongs = new Song[songs.Length - 1];
            for (int i = 0, j= 0; i < songs.Length; i++)
            {
                
                if(i == indexToRemove)
                    continue;
                temporarySongs[j] = songs[i];
                j++;
            }
            songs = temporarySongs;

        }

        private int GetSongIndex(Song song)
        {
            for (int i = 0; i < songs.Length; i++)
            {
                if (songs[i] == song)
                    return i;
            }
            return -1;
        }

        public override string ToString()
        {
            string allSongsInAlbum = "";
            foreach (var item in songs)
            {
                allSongsInAlbum += item;
            }
            return $"Genre: {Genre}, {allSongsInAlbum}";
        }
    }
}
