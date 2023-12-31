using System;
using System.Collections.Generic;

namespace SpotifudgeOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = Login();

            Track[] tracks = Track.Tracklist();

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
            bool repeat = false;
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
                            repeat = !repeat;
                            Console.WriteLine(" ");
                            Console.WriteLine("Repeat status: " + (repeat ? "Enabled" : "Disabled"));
                            break;
                        case 4:
                            AddToPlaylist(selectedTrack);
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

        public static void AddToPlaylist(Track selectedTrack)
        {
            Console.WriteLine();
            Console.WriteLine("Select Playlist:");
            Console.WriteLine("1. coding_Dflat");
            Console.WriteLine("2. keycaps cereals");
            Console.WriteLine("3. indie_qnakaya");
            Console.WriteLine();

            Console.Write("Enter your choice: ");
            int playlistOption = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            switch (playlistOption)
            {
                case 1:
                    Console.WriteLine("Added to playlist 'coding_Dflat'");
                    break;
                case 2:
                    Console.WriteLine("Added to playlist 'keycaps cereals'");
                    break;
                case 3:
                    Console.WriteLine("Added to playlist 'indie_qnakaya'");
                    break;
                default:
                    Console.WriteLine("Invalid playlist option.");
                    break;
            }
        }
    }
}
