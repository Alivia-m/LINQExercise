using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQExercise
{ }
class Program
{
    static void Main(string[] args)
    {
        List<string> videoGames = new List<string>
            {"Horizon Zero Dawn", "Forza", "Infamous", "Overwatch"};

        foreach (string game in SortByLength(videoGames))
        {
            Console.WriteLine(game);
        }
        static IEnumerable<string>
            SortByLength(IEnumerable<string> e)
            {
            var sorted = from game in e
                         orderby game.Length ascending
                         select game;
            return sorted;
        }
    } 
}
