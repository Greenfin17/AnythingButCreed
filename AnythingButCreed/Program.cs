using System;
using AnythingButCreed.Compositions;
using System.Collections.Generic;
using System.Linq;

namespace AnythingButCreed
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Song> allSongs = new List<Song>();
            List<Song> goodSongs = new List<Song>();

            Console.WriteLine("\n\n     Anything but Creed!\n");
            var bobby = new Song("Kris Kristofferson", "Janice Joplin", "Me and Bobby McGee");
            var baba = new Song("Pete Townshend", "The Who", "Baba O'Riley");
            var breath = new Song("Mark Tremonti and Scott Stapp", "Creed", "One Last Breath");
            var sacrifice = new Song("Mark Tremonti and Scott Stapp", "Creed", "My Sacrifice");
            var arms = new Song("Mark Tremonti and Scott Stapp", "Creed", "With Arms Wide Open");
            var higher = new Song("Mark Tremonti and Scott Stapp", "Creed", "Higher");
            var woodstock = new Song("Joni Mitchell", "Joni Mitchell", "Woodstock");
            var something = new Song("Chriss Klafford", "Chris Klafford", "Something Like Me");
            var purple = new Song("Jimi Hendrix", "Jimi Hendrix", "Purple Haze");
            var morgens = new Song("Robert Schumann", "Benita Valente", "Mondnacht");
            var blume = new Song("Robert Schumann", "Benita Valente", "Die Blume der Ergebung");
            var soul = new Song("Carlos Santana et al", "Santana", "Soul Sacrifice");

            allSongs.Add(arms);
            allSongs.Add(bobby);
            allSongs.Add(baba);
            allSongs.Add(breath);
            allSongs.Add(woodstock);
            allSongs.Add(something);
            allSongs.Add(purple);
            allSongs.Add(sacrifice);
            allSongs.Add(morgens);
            allSongs.Add(higher);
            allSongs.Add(blume);
            allSongs.Add(soul);

            int i = 1;
            Console.WriteLine("     Here is a list of 12 songs\n");
            allSongs.ForEach(song => Console.WriteLine($"     {i++}. \"{song.Name}\" by {song.Composer}, performed by {song.Artist}"));
            Console.Write('\n');

            goodSongs= allSongs.Where(x => x.Artist != "Creed").ToList();

            i = 1;
            Console.WriteLine("     OK, here are the songs without Creed - \"Anything but Creed!\"\n");
            goodSongs.ForEach(song => Console.WriteLine($"     {i++}. \"{song.Name}\" by {song.Composer}, performed by {song.Artist}"));
            Console.Write('\n');
        }
    }
}
