using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriented
{
    internal class Song
    {
        public string title;
        public string artist;
        public int duration;
        public static int songCount = 0;  // the static keyword let us directly means it belongs to the class
        /* static means it is attribute about class not the object */
        public Song(string  aTitle , string aArtist , int aDuration) { 
           title = aTitle;
           artist = aArtist;
           duration = aDuration;
           songCount++;
        }

        public int getSongCount ()
        {
            return songCount;  // This is if you want the object to access the static variable 
        }
    }
}
