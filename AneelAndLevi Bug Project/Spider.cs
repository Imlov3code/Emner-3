using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AneelAndLevi_Bug_Project {
    public class Spider : IDangerBug {
        public string Name { get; set; }
        public bool CanBite { get; set; }
        public bool Legs { get; set; }
        public bool CanMove { get; set; }
        public string GoodStuff { get; set; }
        public PlagueType Plague { get; set; }

        public Spider(string name, bool canBite, bool legs, bool canMove, string goodstuff, PlagueType plague) {
            Name = name;
            CanBite = canBite;
            Legs = legs;
            CanMove = canMove;
            GoodStuff = goodstuff;
            Plague = plague;
        }

        public void DisplayProperties() {
            Console.WriteLine($"Name: {Name} CanBite: {CanBite} Legs: {Legs} CanMove: {CanMove} Goodstuff: {GoodStuff} PlagueType: {Plague}");
        }
    }
}
