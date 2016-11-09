using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLists
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList MovieL = new ArrayList();
            MovieL.Add(new Movie("Citizen Kane", "drama"));
            MovieL.Add(new Movie("Casablanca", "drama"));
            MovieL.Add(new Movie("The Godfather", "drama"));
            MovieL.Add(new Movie("Gone With The Wind", "drama"));

            MovieL.Add(new Movie("Snow White And The Seven Dwarfs", "animated"));
            MovieL.Add(new Movie("Fantasia", "animated"));

            MovieL.Add(new Movie("King Kong", "horror"));
            MovieL.Add(new Movie("Jaws", "horror"));

            MovieL.Add(new Movie("A Clockwork Orange", "scifi"));
            MovieL.Add(new Movie("Close Encounters Of The Third Kind", "scifi"));


        }
        public void Search(ArrayList MovieLis, string category)
        {

            for (int i = 0; i < MovieLis.Count; i++)
            {
                if (MovieLis[i].category == category)
                {
                    Console.WriteLine("I found the Movie {0} ", MovieLis[i].title);

                }
            }
        }
    }
}
