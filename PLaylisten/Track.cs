using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLaylisten
{
    internal class Track
    {
        //Instance variables
        private string trackName;
        public string TrackName { get { return trackName; } }


        //Konstuckter
        public Track (string trackName)
        {
            this.trackName = trackName;
        }
    }
}
