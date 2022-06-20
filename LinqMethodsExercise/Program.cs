using System;
using System.Linq;
using System.Collections.Generic;

namespace LinqMethodsExercise
{
    class Program
    {
        static void  Main(string[] args)
        {
            var videoGames = new List<string>() { "Call of Duty", "Destiny2", "Elder Scrolls", "Red Dead Redemption" };

            var lengthOfVideoGames = videoGames.OrderBy(x => x.Length);

           foreach(var num in lengthOfVideoGames)
            {
                Console.WriteLine(num);
            }

        }
    }
}

