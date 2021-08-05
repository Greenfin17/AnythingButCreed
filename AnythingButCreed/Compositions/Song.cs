using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnythingButCreed.Compositions
{
    class Song
    {
        public string Artist { get; set; }
        public string Name { get; set; }
        public string Composer { get; set; }

        public Song(string composer, string artist, string name)
        {
            Artist = artist;
            Name = name;
            Composer = composer;
        }
    }
}
