using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S00189902_CA1
{
   public enum Genre
    {
        Rock,
        Pop,
        Dance,
        Other
    }

   public class Song:IComparable<Song>
    {

        // Properties
        public string title { get; set; }
        public string artist { get; set; }
        public double duration { get; set; }
        public Genre genre { get; set; }

        // First Constructor
        public Song(string title,string artist,double duration,Genre genre)
        {
            this.title = title;
            this.artist = artist;
            this.duration = duration;
            this.genre = genre;
        }

        // Second Constructor leading to first
        public Song(string title,string artist):this(title,artist,duration:0.00,genre:Genre.Other)
        {

        }

        // Third Constuctor 
        public Song():this("N/A","N/A",0.00,Genre.Other)
        {

        }

        // Overirde of ToString
        public override string ToString()
        {
            return string.Format("{0,-30}{1,-40}{2,-20}{3,-15}",title,artist,duration,genre);
        }

        // Implement CompareTo
        public int CompareTo(Song other)
        {
            //Sorts Alphabetically
            if (this.artist == other.artist)
                return this.artist.CompareTo(other.artist);
            return this.artist.CompareTo(other.artist);
        }
        
    }
}
