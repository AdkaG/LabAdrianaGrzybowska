using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Music
{
    struct Song
    {
        public string Name { get; set; }
        public int Duration { get; set; }

        public static bool operator ==(Song firstSong, Song secondSong) => firstSong.Name.ToLower() == secondSong.Name.ToLower();
        public static bool operator !=(Song firstSong, Song secondSong) => firstSong.Name.ToLower() != secondSong.Name.ToLower();
        public override string ToString() => $"Name: {Name}, Duration: {Duration}";
    }
}
