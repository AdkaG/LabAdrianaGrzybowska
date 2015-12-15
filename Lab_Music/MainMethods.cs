using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Music
{
    static class MainMethods
    {
        public static Album GetAlbumIndex(Album[] albums)
        {
            bool loop = true;
            do
            {
                //wylistuj albumy
                Console.WriteLine("Enter number of album you want to remove:");
                int albumIndex;
                if (!int.TryParse(Console.ReadLine(), out albumIndex))
                    throw new Exception("Something went wrong. Try again.");
                if (albumIndex > 0 && albumIndex <= albums.Length)
                {
                    return albums[albumIndex - 1];
                    loop = false;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            } while (loop);
        }
        public static Member GetMemberIndex(Member[] members)
        {
            bool loop = true;
            do
            {
                //wylistuj members
                Console.WriteLine("Enter number of member you want to remove:");
                int memberIndex;
                if (!int.TryParse(Console.ReadLine(), out memberIndex))
                    throw new Exception("Something went wrong. Try again.");
                if (memberIndex > 0 && memberIndex <= members.Length)
                {
                    return members[memberIndex - 1];
                    loop = false;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            } while (loop);

        }

        public static Artist GetArtistIndex(Artist[] artists)
        {
            //wylistuj artystow
            Console.WriteLine("");//po nazwie czy po nr?
        }

        public static void PrintArtistsByGenre(Artist[] artists)
        {
            for (int i = 0; i < artists.Length; i++)
            {
                Console.WriteLine($"{i + 1}: {artists[i]}");
            }
        }
    }
}
