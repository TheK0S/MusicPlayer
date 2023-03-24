using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
    internal class SongList
    {
        public string Name { get; set; }

        public List<string> Songs = new List<string>();

        public SongList(string name, List<string> songs)
        {
            Name = name;
            Songs = songs;
        }
    }
}
