using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Music
{
    class Artist
    {
        public string Name { get; set; }
        internal Album[] albums = new Album[0];

        public Album this[int index]
        {
            get
            {
                if (index >= 0 && index < albums.Length)
                {
                    return albums[index];
                }
                throw new IndexOutOfRangeException();

            }
        }

        public void AddAlbum(Album album)
        {
            Album[] temporaryAlbums = new Album[albums.Length + 1];
            for (int i = 0; i < albums.Length; i++)
            {
                temporaryAlbums[i] = albums[i];
            }
            temporaryAlbums[temporaryAlbums.Length - 1] = album;
            albums = temporaryAlbums;
        }

        public void RemoveAlbum(Album album)
        {
            int indexToRemove = Array.IndexOf(albums, album);
            Album[] temporaryAlbums = new Album[albums.Length - 1];
            for (int i = 0, j= 0; i < albums.Length; i++)
            {
                if(i == indexToRemove)
                    continue;
                temporaryAlbums[j] = albums[i];
                j++;
            }
            albums = temporaryAlbums;
           

        }
    }
}
/*
 
            
            
*/
