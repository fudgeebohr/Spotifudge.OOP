using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifudgeOOP
{
    class Track
    {
        public string trackName { get; set; }
        public string artistName { get; set; }
        public int lengthMin { get; set; }
        public int lengthSec { get; set; }
        public string albumName { get; set; }
        public string genre { get; set; }

        private bool isPlaying;
        private bool isPaused;
        private bool isRepeated;

        public void Play()
        {
            if (!isPlaying)
            {
                Console.WriteLine("Playing: " + trackName);
                isPlaying = true;
                isPaused = false;
            }
            else
            {
                Console.WriteLine("Track is already playing.");
            }
        }

        public void Pause()
        {
            if (isPlaying && !isPaused)
            {
                Console.WriteLine("Pausing: " + trackName);
                isPaused = true;
            }
            else if (!isPlaying)
            {
                Console.WriteLine("Cannot pause. Track is not currently playing.");
            }
            else
            {
                Console.WriteLine("Track is already paused.");
            }
        }

        public void Shuffle()
        {

        }

        public void Repeat()
        {
            if (!isRepeated)
            {
                Console.WriteLine("Repeating: " + trackName);
                isRepeated = true;
            }
            else
            {
                Console.WriteLine("Track is already set to repeat.");
            }
        }

        public void Skip()
        {

        }

        public void Rewind()
        {

        }
        
        public void AddToPlaylist()
        {

        }

        public void RemoveFromPlaylist()
        {

        }
    }
}
