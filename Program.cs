using System;
using System.Collections.Generic;

namespace SpotifudgeOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = Login();

            Track[] tracks = new Track[]
            {
                new Track { trackName = "COOL (Your Rainbow)", artistName = "NMIXX", 
                            lengthMin = 2, lengthSec = 50, albumName = "ENTWURF", genre = "K-Pop" },
                new Track { trackName = "Wish I Could Be Your Girl", artistName = "Kristiane", 
                            lengthMin = 2, lengthSec = 27, albumName = "I Miss Myself, Sometimes", genre = "Alternative/Indie" },
                new Track { trackName = "That's Hilarious", artistName = "Charlie Puth", 
                            lengthMin = 2, lengthSec = 24, albumName = "CHARLIE", genre = "Pop" },
                new Track { trackName = "She's In The Rain", artistName = "The Rose", 
                            lengthMin = 3, lengthSec = 57, albumName = "Dawn", genre = "Korean Rock/Alt" },
                new Track { trackName = "apollo", artistName = "Faith Zapata", 
                            lengthMin = 5, lengthSec = 12, albumName = "apollo", genre = "Alternative/Indie" },
                new Track { trackName = "Deja Vu", artistName = "Uki Violeta, PrettyPatterns", 
                            lengthMin = 4, lengthSec = 38, albumName = "Deja Vu", genre = "Alternative/Indie" },
                new Track { trackName = "Good enough", artistName = "Xdinary Heroes", 
                            lengthMin = 3, lengthSec = 57, albumName = "Deadlock", genre = "Korean Rock/Alt" },
                new Track { trackName = "Make Me Happy", artistName = "Whee In", 
                            lengthMin = 3, lengthSec = 17, albumName = "WHEE", genre = "K-Pop" },
                new Track { trackName = "Huwag Muna Tayong Umuwi", artistName = "BINI", 
                            lengthMin = 4, lengthSec = 57, albumName = "Feel Good", genre = "P-Pop" },
            };

            var discoverWeekly = new List<string>()
            {
                " ",
                "Discover Weekly",
                " ",
                "Your weekly mixtape of fresh music. Enjoy new discoveries and deep cuts",
                "picked just for you. Updates every Monday, so save your favorites!",
                " ",
                $"Made for {User.Username}",
                "By Spotifudge",
                " "
            };

            foreach (string i in discoverWeekly)
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i < tracks.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {tracks[i].trackName} - {tracks[i].artistName}");
            }

            Console.WriteLine(" ");
            Console.Write("Select a track (enter the number): ");
            string input = Console.ReadLine();
            int selectedTrackIndex;
            if (int.TryParse(input, out selectedTrackIndex))
            {
                if (selectedTrackIndex >= 1 && selectedTrackIndex <= tracks.Length)
                {
                    Track selectedTrack = tracks[selectedTrackIndex - 1];
                    Console .WriteLine(" ");
                    Console.WriteLine("Track Details:");
                    Console.WriteLine($"Title: {selectedTrack.trackName}");
                    Console.WriteLine($"Artist: {selectedTrack.artistName}");
                    Console.WriteLine($"Length: {selectedTrack.lengthMin}:{selectedTrack.lengthSec}");
                    Console.WriteLine($"Album: {selectedTrack.albumName}");
                    Console.WriteLine($"Genre: {selectedTrack.genre}");

                    PlaybackOptions();
                }
                else
                {
                    Console.WriteLine("Invalid track selection.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid track number.");
            }
        }

        private static User Login()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Log in to Spotifudge.");
            string username = GetUsername();

            return new User(username);
        }

        public static string GetUsername()
        {
            Console.Write("Username: ");
            return Console.ReadLine();
        }

        public static void PlaybackOptions()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Playback Options:");
            Console.WriteLine("1. Play");
            Console.WriteLine("2. Shuffle");
            Console.WriteLine("3. Repeat");
            Console.WriteLine("4. Add to Playlist");
            Console.WriteLine("5. Exit");
            Console.WriteLine(" ");

            Console.Write("Select an option (enter the number): ");
            string input = Console.ReadLine();
            int selectedOption;
            if (int.TryParse(input, out selectedOption))
            {
                switch (selectedOption)
                {
                    case 1:
                        Console.WriteLine("Playing track...");
                        break;
                    case 2:
                        Console.WriteLine("Shuffling track...");
                        break;
                    case 3:
                        Console.WriteLine("Repeating track...");
                        break;
                    case 4:
                        Console.WriteLine("Adding track to playlist...");
                        break;
                    case 5:
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid option number.");
            }
        }
    }
}
