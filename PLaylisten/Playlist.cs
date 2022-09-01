using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLaylisten
{
    internal class Playlist
    {
        //Creates a linkedlist
        public LinkedList<Track> playlist = new LinkedList<Track>();

        //Public method called AddTrack, that Adds a track to the buttom of the linkedlist
        public void AddTrack(string trackName)
        {
            Track track = new Track(trackName);
            playlist.AddLast(track);
        }

        //Public method called RemoveTrack, that removes a track
        public void RemoveTrack(Track track)
        {
            playlist.Remove(track);
        }
        //Public method called AddTrackAtTop, that adds a track at the top of the linkedlist
        public void AddTrackAtTop(string trackName)
        {
            Track track = new Track(trackName);
            playlist.AddFirst(track);
        }
    }
}
