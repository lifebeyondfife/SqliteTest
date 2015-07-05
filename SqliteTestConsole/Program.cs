using SqliteTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqliteTestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var sArtists = Sqlite.GetArtists("S");

            foreach (var artistName in sArtists)
                Console.WriteLine(artistName);

            Console.ReadKey();
        }
    }
}
