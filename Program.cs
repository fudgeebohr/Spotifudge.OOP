using System;

namespace SpotifudgeOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Track Track1 = new Track();
            Track1.trackName = "COOL (Your Raindbow)";
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
            Track2.albumName = "I Miss Mayself, Sometimes";
            Track2.genre = "Alternative/Indie";

            Console.WriteLine(" ");
            Console.WriteLine("Discover Weekly");
            Console.WriteLine(" ");
            Console.WriteLine("Your weekly mixtape of fresh music. Enjoy new discoveries and deep cuts");
            Console.WriteLine("picked just for you. Updates every Monday, so save your favorites!");
            Console.WriteLine(" ");
            Console.WriteLine("By Spotifudge");
            Console.WriteLine(" ");
            Console.WriteLine("1. " + Track1.trackName + " - " + Track1.artistName);
            Console.WriteLine("2. " + Track2.trackName + " - " + Track2.artistName);
        }
    }
}
