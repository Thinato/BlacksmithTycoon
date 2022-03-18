using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlacksmithSimulator
{
    public class Player
    {
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
        public Dictionary<Item, int> Inventory { get; set; }

        // Additional stats
        public int Blacksmithing { get; set; }
        public int Mining { get; set; }
        public int Luck { get; set; }

        public enum Ability
        {
            Blacksmithing,
            Mining,
            Level
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

        }
        public void LevelUp(Ability ability)
        {
            Level++;
            Exp -= ExpMax;
            ExpDiff += 50 + Convert.ToInt32(ExpMax * .05);
            ExpMax += ExpDiff;
        }
        public void GainExp(Ability ability, int quantity)
        {
            switch (ability)
            {
                case Ability.Blacksmithing:
                    break;
                case Ability.Mining:
                    break;
                case Ability.Level:
                    Exp += quantity;
                    if (Exp >= ExpMax)
                        LevelUp(Ability.Level);
                    break;
            }
        }
    }
}
