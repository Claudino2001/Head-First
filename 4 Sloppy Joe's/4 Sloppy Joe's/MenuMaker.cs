using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Sloppy_Joe_s
{
    internal class MenuMaker
    {
        public Random Randomizer;
        string[] Meats = {"Roast beef", "Salami", "Turkey", "Ham", "Pastrami"};
        string[] Condiments = {"yellow mustard", "brown mustard", "honey mustard", "mayo", "relish", "french dressing" };
        string[] Breads = { "rye", "white", "wheat", "pumpernickel", "italian bread", "a roll"};
        
        public string GetMenuItem()
        {
            string randomMeat = Meats[Randomizer.Next(Meats.Length)];
            string ranromCondiment = Condiments[Randomizer.Next(Condiments.Length)];
            string ranromBreads = Condiments[Randomizer.Next(Breads.Length)];

            return randomMeat + " with " + ranromCondiment + " on "+ ranromBreads + ".";
        }

    }
}
