using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorYuar.Data
{
    public class Game
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public string Category { get; set; }
        public string Country { get; set; }


        public Game(string name, int year, string category, string country)
        {            
            name = Name;
            year = Year;
            category = Category;
            country = Country;
        }

        public Game()
        {
        }

        public static List<Game> AddGem()
        {
            List<Game> g = new List<Game>();
            g.Add(new Game() { Name = "Counter-strike", Year = 2000, Category = "Shooter", Country = "USA" });
            g.Add(new Game() { Name = "World of tanks", Year = 2008, Category = "MMO, Simulation", Country = "Russia" });
            g.Add(new Game() { Name = "Clash of clans", Year = 2011, Category = "Strategy", Country = "USA" });
            g.Add(new Game() { Name = "Bunker", Year = 2020, Category = "Strategy", Country = "USA" });           
            return g;
        }
    }
}
