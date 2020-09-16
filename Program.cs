using System;
using System.ComponentModel.Design.Serialization;
using static ChristianCSharpAPICheatSheet.Movie;

namespace ChristianCSharpAPICheatSheet
{
    class Program
    {
        static void Main(string[] args)
        {
            movieRquest();
        }

        public static void movieRquest()
        {
            Console.Clear();

            ApiRequest apiRequest = new ApiRequest();
            Root Movie = apiRequest.GetMovies();
            foreach (var item in Movie.results)
            {
                Console.WriteLine($"Title: {item.original_title}");
            }
            Console.ReadLine();
        }
    }
}
