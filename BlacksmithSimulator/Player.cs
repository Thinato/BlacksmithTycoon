using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlacksmithSimulator
{
    public class Player
    {
        public string Name { get; set; }
        public int Gold { get; set; }
        public int Hunger { get; set; }
        public int HungerMax { get; set; }
        public int Sanity { get; set; }
        public int SanityMax { get; set; }
        public int Storage { get; set; }
        public int StorageMax { get; set; }
        public int Exp { get; set; }
        public int ExpMax { get; set; }
        public int ExpDiff { get; set; }
        
        public int Level { get; set; }
        
        public Dictionary<Person, int> Relationships { get; set; }

        public DataTable DataItems;
        public DataTable DataInventory;

        // Additional stats
        public int Blacksmithing { get; set; }
        public int Mining { get; set; }
        public int Luck { get; set; }
        public int LevelPoints { get; set; }
        public bool IsMining { get; set; }

        public enum Ore
        {
            Copper,
            Tin,
            Iron,
            Silver,
            Gold,
            Platinum,
            Mithril,
            Orichalcum,
            Meteorite
        }


        public Player()
        {
            HungerMax = 100;
            SanityMax = 125;
            StorageMax = 150;

            Hunger = HungerMax;
            Sanity = SanityMax;
            Storage = StorageMax;

            Level = 1;

            Exp = 0;
            ExpMax = 100;
            ExpDiff = 150;

            DataInventory = new DataTable();
            DataItems = new DataTable();

        }
        public void LevelUp()
        {
            Level++;
            Exp -= ExpMax;
            ExpDiff += 50 + Convert.ToInt32(ExpMax * .05);
            ExpMax += ExpDiff;
            LevelPoints++;
        }
        public string GainExp( int baseValue)
        {
            if (baseValue < 4)
                throw new ArgumentException();
            Random rand = new Random();
            int value = rand.Next(baseValue - 4, baseValue + 4);
            Exp += value;
            if (Exp >= ExpMax)
            {
                LevelUp();
                return $"+{value} EXP\nLevel Up!\nYou reached level {Level}!\n" ;
            }
              
            return $"+{value} EXP\n";

        }
    }
}
