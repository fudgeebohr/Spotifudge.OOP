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

        public static Track[] Tracklist()
        {
            return new Track[]
            {
                new Track { trackName = "Here With Me", 
                            artistName = "d4vd", 
                            lengthMin = 4, 
                            lengthSec = 12, 
                            albumName = "Petals to Thorns", 
                            genre = "Bedroom Pop" },

                new Track { trackName = "golden hour", 
                            artistName = "JVKE", 
                            lengthMin = 2, 
                            lengthSec = 39, 
                            albumName = "golden hour", 
                            genre = "Modern Indie Pop" },

                new Track { trackName = "Romantic Homicide", 
                            artistName = "d4vd", 
                            lengthMin = 2, 
                            lengthSec = 212, 
                            albumName = "Romantic Homicide", 
                            genre = "Bedroom Pop" },

                new Track { trackName = "Those Eyes", 
                            artistName = "New West", 
                            lengthMin = 3,
                            lengthSec = 40, 
                            albumName = "Those Eyes", 
                            genre = "Toronto Indie" },

                new Track { trackName = "Sparks", 
                            artistName = "Coldplay", 
                            lengthMin = 3, 
                            lengthSec = 47, 
                            albumName = "Parachutes", 
                            genre = "Permanent Wave" },

                new Track { trackName = "better for you", 
                            artistName = "siopaolo", 
                            lengthMin = 4, 
                            lengthSec = 49, 
                            albumName = "better for you", 
                            genre = "Bedroom R&B" },

                new Track { trackName = "Lover", 
                            artistName = "Taylor Swift", 
                            lengthMin = 3, 
                            lengthSec = 41, 
                            albumName = "Lover", 
                            genre = "Pop" },

                new Track { trackName = "Glimpse of Us", 
                            artistName = "Joji", 
                            lengthMin = 3, 
                            lengthSec = 53, 
                            albumName = "Glimpse of Us", 
                            genre = "Viral Pop" },

                new Track { trackName = "As It Was", 
                            artistName = "Harry Styles", 
                            lengthMin = 2, 
                            lengthSec = 47, 
                            albumName = "As It Was", 
                            genre = "Pop" },

                new Track { trackName = "Sofia", 
                            artistName = "Clairo", 
                            lengthMin = 3, 
                            lengthSec = 18, 
                            albumName = "Immunity", 
                            genre = "Indie Pop"},

                new Track { trackName = "Reckless", 
                            artistName = "Madison Beer", 
                            lengthMin = 3, 
                            lengthSec = 23, 
                            albumName = "Reckless", 
                            genre = "Pop" },

                new Track { trackName = "Hymn for the Weekend", 
                            artistName = "Coldplay", 
                            lengthMin = 4, 
                            lengthSec = 18, 
                            albumName = "A Head Full of Deams", 
                            genre = "Pop" },

                new Track { trackName = "Homage", 
                            artistName = "Mild High Club", 
                            lengthMin = 2, 
                            lengthSec = 57, 
                            albumName = "Skiptracing", 
                            genre = "Indie Garage Rock" },

                new Track { trackName = "Blue Spirits", 
                            artistName = "DWLLRS", 
                            lengthMin = 3, 
                            lengthSec = 18, 
                            albumName = "Blue Spirits", 
                            genre = "Chill Pop" },

                new Track { trackName = "LIMBO", 
                            artistName = "keshi", 
                            lengthMin = 3, 
                            lengthSec = 33, 
                            albumName = "GABRIEL", 
                            genre = "Chill R&B" },
            };
        }
    }
}
