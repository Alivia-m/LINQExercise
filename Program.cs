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

        var sort = videoGames.OrderBy(game => game.Length);
        foreach (var game in sort)
        {
            Console.WriteLine(game);
        }
 } }
