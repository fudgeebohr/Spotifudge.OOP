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
                new Track { trackName = "Here With Me", artistName = "d4vd", lengthMin = 4, 
                            lengthSec = 12, albumName = "Petals to Thorns", genre = "Bedroom Pop" },
                new Track { trackName = "golden hour", artistName = "JVKE", lengthMin = 2, 
                            lengthSec = 39, albumName = "golden hour", genre = "Modern Indie Pop" },
                new Track { trackName = "Romantic Homicide", artistName = "d4vd", lengthMin = 2, 
                            lengthSec = 212, albumName = "Romantic Homicide", genre = "Bedroom Pop" },
                new Track { trackName = "Those Eyes", artistName = "New West", lengthMin = 3,
                            lengthSec = 40, albumName = "Those Eyes", genre = "Toronto Indie" },
                new Track { trackName = "Sparks", artistName = "Coldplay", lengthMin = 3, 
                            lengthSec = 47, albumName = "Parachutes", genre = "Permanent Wave" },
                new Track { trackName = "better for you", artistName = "siopaolo", lengthMin = 4, 
                            lengthSec = 49, albumName = "better for you", genre = "Bedroom R&B" },
                new Track { trackName = "Lover", artistName = "Taylor Swift", lengthMin = 3, 
                            lengthSec = 41, albumName = "Lover", genre = "Pop" },
                new Track { trackName = "Glimpse of Us", artistName = "Joji", lengthMin = 3, 
                            lengthSec = 53, albumName = "Glimpse of Us", genre = "Viral Pop" },
                new Track { trackName = "As It Was", artistName = "Harry Styles", lengthMin = 2, 
                            lengthSec = 47, albumName = "As It Was", genre = "Pop" },
                new Track { trackName = "Sofia", artistName = "Clairo", lengthMin = 3, 
                            lengthSec = 18, albumName = "Immunity", genre = "Indie Pop"},
                new Track { trackName = "Reckless", artistName = "Madison Beer", lengthMin = 3, 
                            lengthSec = 23, albumName = "Reckless", genre = "Pop" },
                new Track { trackName = "Hymn for the Weekend", artistName = "Coldplay", lengthMin = 4, 
                            lengthSec = 18, albumName = "A Head Full of Deams", genre = "Pop" },
                new Track { trackName = "Homage", artistName = "Mild High Club", lengthMin = 2, 
                            lengthSec = 57, albumName = "Skiptracing", genre = "Indie Garage Rock" },
                new Track { trackName = "Blue Spirits", artistName = "DWLLRS", lengthMin = 3, 
                            lengthSec = 18, albumName = "Blue Spirits", genre = "Chill Pop" },
                new Track { trackName = "LIMBO", artistName = "keshi", lengthMin = 3, 
                            lengthSec = 33, albumName = "GABRIEL", genre = "Chill R&B" },
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
                " ",
            };

            foreach (string i in discoverWeekly)
            {
                Console.WriteLine(i);
            }

            bool exit = false;
            while (!exit)
            {
                for (int i = 0; i < tracks.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {tracks[i].trackName} - {tracks[i].artistName}");
                }

                Console.WriteLine(" ");
                Console.Write("Enter track number or type 'exit' to quit: ");
                string input = Console.ReadLine();

                if (input.ToLower() == "exit")
                {
                    Console.WriteLine(" ");
                    Console.WriteLine(">> Terminating Session...");
                    exit = true;
                }
                else
                {
                    int selectedTrackIndex;
                    if (int.TryParse(input, out selectedTrackIndex))
                    {
                        if (selectedTrackIndex >= 1 && selectedTrackIndex <= tracks.Length)
                        {
                            Track selectedTrack = tracks[selectedTrackIndex - 1];
                            Console.WriteLine(" ");
                            Console.WriteLine("Track Details:");
                            Console.WriteLine($"Title: {selectedTrack.trackName}");
                            Console.WriteLine($"Artist: {selectedTrack.artistName}");
                            Console.WriteLine($"Length: {selectedTrack.lengthMin}:{selectedTrack.lengthSec}");
                            Console.WriteLine($"Album: {selectedTrack.albumName}");
                            Console.WriteLine($"Genre: {selectedTrack.genre}");

                            PlaybackOptions(selectedTrack, tracks);
                        }
                        else
                        {
                            Console.WriteLine("Invalid track selection.");
                            Console.WriteLine(" ");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Unrecognized input. Try again.");
                        Console.WriteLine(" ");
                    }
                }
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

        public static void PlaybackOptions(Track selectedTrack, Track[] tracks)
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Playback Options:");
                Console.WriteLine("1. Play");
                Console.WriteLine("2. Shuffle");
                Console.WriteLine("3. Repeat");
                Console.WriteLine("4. Add to Playlist");
                Console.WriteLine("5. Return");
                Console.WriteLine(" ");

                Console.Write("Select an option (enter the number): ");
                string input = Console.ReadLine();
                int selectedOption;
                if (int.TryParse(input, out selectedOption))
                {
                    switch (selectedOption)
                    {
                        case 1:
                            PlayTrack(selectedTrack);
                            break;
                        case 2:
                            ShuffleTracks(tracks);
                            break;
                        case 3:
                            Console.WriteLine("Repeating track...");
                            break;
                        case 4:
                            Console.WriteLine("Adding track to playlist...");
                            break;
                        case 5:
                            Console.WriteLine(" ");
                            Console.WriteLine("Returning to track selection...");
                            Console.WriteLine(" ");
                            exit = true;
                            break;
                        default:
                            Console.WriteLine(" ");
                            Console.WriteLine("Invalid option.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Invalid input. Please enter a valid option number.");
                }
            }
        }

        public static void PlayTrack(Track selectedTrack)
        {
            Console.WriteLine(" ");
            Console.WriteLine($"Now Playing: {selectedTrack.trackName}");
            Console.WriteLine($"by: {selectedTrack.artistName}");
            Console.WriteLine($"from: {selectedTrack.albumName}");
        }

        public static void ShuffleTracks(Track[] tracks)
        {
            Random random = new Random();
            int trackIndex = random.Next(0, tracks.Length);
            Track shuffledTrack = tracks[trackIndex];

            Console.WriteLine(" ");
            Console.WriteLine("Shuffling tracks...");
            Console.WriteLine(" ");
            Console.WriteLine($"Now Playing: {shuffledTrack.trackName}");
            Console.WriteLine($"by: {shuffledTrack.artistName}");
            Console.WriteLine($"from: {shuffledTrack.albumName}");
        }
    }
}
