using System;
using System.Collections.Generic;

namespace SpotifudgeOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Track Track1 = new Track();
            Track1.trackName = "COOL (Your Rainbow)";
            Track1.artistName = "NMIXX";
            Track1.lengthMin = 2;
            Track1.lengthSec = 50;
            Track1.albumName = "ENTWURF";
            Track1.genre = "K-Pop";

            Track Track2 = new Track();
            Track2.trackName = "Wish I Could Be Your Girl";
            Track2.artistName = "Kristiane";
            Track2.lengthMin = 2;
            Track2.lengthSec = 27;
            Track2.albumName = "I Miss Myself, Sometimes";
            Track2.genre = "Alternative/Indie";

            Track Track3 = new Track();
            Track3.trackName = "That's Hilarious";
            Track3.artistName = "Charlie Puth";
            Track3.lengthMin = 2;
            Track3.lengthSec = 24;
            Track3.albumName = "CHARLIE";
            Track3.genre = "Pop";

            var discoverWeekly = new List <string>()
            {" ", "Discover Weekly", " ", "Your weekly mixtape of fresh music. Enjoy new discoveries and deep cuts", "picked just for you. Updates every Monday, so save your favorites!", " ", "By Spotifudge", " "};
            foreach(string i in discoverWeekly)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("1. " + Track1.trackName + " - " + Track1.artistName);
            Console.WriteLine("2. " + Track2.trackName + " - " + Track2.artistName);
            Console.WriteLine("3. " + Track3.trackName + " - " + Track3.artistName);
        }
    }
}
