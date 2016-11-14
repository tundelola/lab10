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

            Boolean response = true;
            while (true)
            {
                Console.WriteLine("Welcome to the Movie List application");

                Console.WriteLine("There are 100 movies in this list,\n\nPlease What category are you interested in?,\n\nanimated, scifi, drama, musical or comedy");
                string category = Console.ReadLine();
                if (category != null)
                {
                    Console.WriteLine("\nMovie is in this category\n");
                    search(category);
                    Console.WriteLine("Do you want to continue?(y/n)");// validates more input sentence from the user
                    string userRes = Console.ReadLine();
                    if (userRes == "Y" || userRes == "y")
                    {
                        response = true;

                    }
                    else
                    {

                        response = false;
                        break;
                    }

                }

            }

        }



        public static void search(string category)
        {

            for (int i = 0; i < 100; i++)
            {

                if (Movies.getMovie(i).CATEGORY == category)
                {
                    Console.WriteLine(Movies.getMovie(i).TITLE);
                }
            }
        }
    }
}

