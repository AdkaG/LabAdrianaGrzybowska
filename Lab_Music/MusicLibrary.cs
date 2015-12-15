using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Music
{
    class MusicLibrary
    {
        Artist[] artists = new Artist[0];

        public Artist this[int index]
        {
            get
            {
                if (index >= 0 && index < artists.Length)
                {
                    return artists[index];
                }
                throw new IndexOutOfRangeException();
            }

        }

        public Artist[] GetAllArtistsByGenre(Genre genre)
        {

            int lengthOfArray = 0;
            for (int i = 0; i < artists.Length; i++)
            {
                for (int j = 0; j < artists[i].albums.Length; j++)
                {
                    if (artists[i][j].Genre == genre)
                    {
                        lengthOfArray++;
                        break;
                    }
                }
            }
            Artist[] artistOfGenre = new Artist[lengthOfArray];
            int k = 0;
            for (int i = 0; i < artists.Length; i++)
            {
                for (int j = 0; j < artists[i].albums.Length; j++)
                {
                    if (artists[i][j].Genre == genre)
                    {
                        artistOfGenre[k] = artists[i];
                        k++;
                        break;
                    }
                }
            }
            return artistOfGenre;
        }

        public void AddArtist(Artist artist)
        {
            Artist[] temporaryArtists = new Artist[artists.Length + 1];
            for (int i = 0; i < artists.Length; i++)
            {
                temporaryArtists[i] = artists[i];
            }
            temporaryArtists[temporaryArtists.Length - 1] = artist;
            artists = temporaryArtists;
        }

        public void RemoveArtist(Artist artist)
        {
            
        }
    }
}
