using System;
using System.Collections.Generic;
using System.Linq;

namespace AnythingButCreed
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare creed songs
            var song1 = new Song("Queen", "Your Pointy Hat");
            var song2 = new Song("Nickelback", "Don't Send Me Pointy Hats Anymore");
            var song3 = new Song("The Rolling Stones", "Tall People");
            var song4 = new Song("Panic! At The Disco", "There's a Good Reason Sausages are Numbered, Emily");
            var song5 = new Song("Creed", "My Hotel on My Mind");
            var song6 = new Song("Captian Jack Sparrow", "Where Has All The Rum Gone?");
            var song7 = new Song("Creed", "Ghost in My Key");
            var song8 = new Song("Fall Out Boy", "Don't Eat Sausages Off The Sidewalk");
            var song9 = new Song("Creed", "Free Circus");
            var song10 = new Song("Creed", "Best Fireworks");
            var song11 = new Song("Metallica", "She Hopes She Loves You");
            var song12 = new Song("Nirvana", "Sky of Anything");

            // declare song lists
            var goodSongs = new List<Song>();

            var allSongs = new List<Song>()
            {
                song1,
                song2,
                song3,
                song4,
                song5,
                song6,
                song7,
                song8,
                song9,
                song10,
                song11,
                song12
            };

            goodSongs = allSongs.Where(Song => Song.Artist != "Creed").ToList();

            foreach (var song in goodSongs)
            {
                Console.WriteLine($"{song.Artist}: {song.Name}");
            }
        }
    }
}
