using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore.Models
{
    public class MusicCD : Product
    {
        //Field
        private List<Track> tracks = new List<Track>();

        // Prop
        public List<Track> Tracks
        {
            get { return tracks; }
        }

        public string Artist { get; set; }
        public string Label { get; set; }
        public short Released { get; set; }

        public MusicCD() { }

        public MusicCD(string title, string artist, string label, short released, decimal price, string imageUrl) : base(title, price, imageUrl)
        {
            Artist = artist;
            Label = label;
            Released = released;
        }

        //Method
        public void AddTrack(Track track)
        {
            Tracks.Add(track);
        }


        public TimeSpan GetPlayingTime()
        {
            TimeSpan result = new TimeSpan(0, 0, 0);
            foreach (Track track in tracks)
            {
                result = track.Length + result;
            }
            return result;
        }
    }
}
