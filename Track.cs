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

        public Track() { }

        public Track(Track track)
        {
            trackName = track.trackName;
            artistName = track.artistName;
            lengthMin = track.lengthMin;
            lengthSec = track.lengthSec;
            albumName = track.albumName;
            genre = track.genre;
        }
    }
}
