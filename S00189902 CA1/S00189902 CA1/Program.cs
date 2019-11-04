using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S00189902_CA1
{
    class Program
    {
        private static Random r = new Random();
        
        static void Main(string[] args)
        {


           // Creating song objects 
            Song song1 = new Song("Disengage", "Suicide Silence", 4.16, Genre.Rock);
            Song song2 = new Song("Schism", "Tool", 6.46, Genre.Rock);
            Song song3 = new Song("Leglock", "Shakewell",2.05, Genre.Pop);
            Song song4 = new Song("What you wont do for love", "Bobby Caldwell", 4.47, Genre.Other);
            Song song5 = new Song("Vicarious", "Tool", 7.06, Genre.Rock);

            //creating song list
            List<Song> Playlist = new List<Song>();

            // Adding objects to list
            Playlist.Add(song1);
            Playlist.Add(song2);
            Playlist.Add(song3);
            Playlist.Add(song4);
            Playlist.Add(song5);

            // using display method
            Display(Playlist);

            // Sorting using CompareTo method in song class
            Playlist.Sort();

            Console.WriteLine();
            Console.WriteLine("Sorting playlist by Artist, then song title");
            Console.WriteLine();

            // Using Display again to show sorted objects
            Display(Playlist);
           
            // Using Shuffle method
            Shuffle(Playlist);

            

            Console.WriteLine();
            Console.WriteLine("Shuffling the playlist");
            Display(Playlist);
            Console.WriteLine();


            
            
        }

        public static void Display(List<Song> songs)
        {
            Console.WriteLine("{0,-30}{1,-40}{2,-20}{3,-15}","Song","Artist","Duration","Genre");
            foreach(Song s in songs)
                Console.WriteLine(s);
        }
        public static void Shuffle(List<Song> songs)
        {
            if (songs.Count > 1)
            {
                for (int i = songs.Count - 1; i >= 0; i--)
                {
                    Song temp = songs[i];
                    // Storing of temp song Object
                    int randoIndex = r.Next(i + 1);

                    // Swaps around both objects
                    songs[i] = songs[randoIndex];
                    songs[randoIndex] = temp;
                }
            }
            
        }

    }
}
