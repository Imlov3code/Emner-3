using System.Reflection.PortableExecutable;
using Console = System.Console;

namespace HarryPotter
{
    public class Character
    {
        public string Name { get; set; }
        public string House { get; set; }
        public List<string> Inventory { get; set; }

        public Character(string name, string house)
        {
            Name = name;
            House = house;
            Inventory = new List<string>();
        }

        public void ToString()
        {
            Console.WriteLine($"Hello, my name is {Name} and i am a member of {House} house");
            if (!Inventory.Any())
            {
                Console.WriteLine("I dont have any items yet");
                return;
            }

            Console.WriteLine("I have the following items:");
            Inventory.Select(item => $" - {item}")
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }

    public class Shop
    {
        private List<string> pets { get; set; }
        private List<string> wands { get; set; }

        public Shop()
        {
            pets = Addpets();
            wands = Addwands();
        }

        private List<string> Addpets()
        {
            List<string> addList = new List<string>()
            {
               "Owl",
               "Rat",
               "Cat"
            };

            return addList;
        }

        private List<string> Addwands()
        {
            List<string> addWands = new List<string>()
            {
                "Phoenix Wand", 
                "Unicorn Wand", 
                "Troll Wand"
            };

            return addWands;
        }

        public void BuyPets(Character character)
        {
            Console.WriteLine("Availebale pets: " + string.Join(",", pets));
            Console.WriteLine("Enter the pet you want to buy:");

            string pet = Console.ReadLine();
            if (!pets.Contains(pet, StringComparer.OrdinalIgnoreCase))
            {
                Console.WriteLine("Invalid pet.");
                return;
            }

            character.Inventory.Add(pet);
            Console.WriteLine($"{character.Name} now owns a {pet}.");
        }

        public void BuyWand(Character character)
        {
            Console.WriteLine("Available wands: " + string.Join(", ", wands));
            Console.WriteLine("Enter the wand you want to buy:");

            string wand = Console.ReadLine();

            if (!wands.Contains(wand, StringComparer.OrdinalIgnoreCase))
            {
                Console.WriteLine("Invalid wand.");
                return;
            }

            character.Inventory.Add(wand);
            Console.WriteLine($"{character.Name} now owns a {wand}.");
        }

        public void ShopMenu()
        {
            Console.WriteLine("Welcome to the Magic Shop! What would you like to buy?");
            Console.WriteLine("1. Buy a pet");
            Console.WriteLine("2. Buy a wand");
            Console.WriteLine("3. Exit");
        }
    }

    public class Magic
    {
        private Dictionary<string, string> spells { get; set; }

        public Magic()
        {
            spells = Addspells();
        }

        private Dictionary<string, string> Addspells()
        {
            Dictionary<string, string> addSpells = new Dictionary<string, string>()
            {
                { "vingardium leviosa", "You made a feather fly!" },
                { "hokus pokus", "You fired off fireworks!" }
            };

            return addSpells;
        }

        private void ShowSpells()
        {
            string keys = string.Join(", ", spells.Keys);
            Console.WriteLine($"Available wands: {keys}");
        }

        public void CastSpells(string spell)
        {
            ShowSpells();

            string result;

            if (!spells.TryGetValue(spell, out result))
            {
                Console.WriteLine("Unknown spell.");
                return;
            }

            Console.WriteLine(result);
        }

    }

    public class Game
    {
        private Character character;
        private Shop shop;
        private Magic magic;

        public void Start()
        {
            Initializer();
            GameLoop();
        }

        private void Initializer()
        {
            Console.WriteLine("Enter your character's name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your Character's house:");
            string house = Console.ReadLine();

            character = new Character(name, house);
            shop = new Shop();
            magic = new Magic();
        }

        private int GetChoice()
        {
            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input, please enter a number.");
                return 0;
            }

            return choice;
        }

        private void ShowMenu()
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Introduce character");
            Console.WriteLine("2. Visit magic shop");
            Console.WriteLine("3. Cast a spell");
            Console.WriteLine("4. Exit");
        }

        private void GameLoop()
        {
            do
            {
                ShowMenu();

                int choice = GetChoice();
                switch (choice)
                {
                    case 1:
                        character.ToString();
                        break;
                    case 2:
                        VisitShop();
                        break;
                    case 3:
                        CastSpell();
                        break;
                }

            } while (true);
        }

        private void VisitShop()
        {
            shop.ShopMenu();
            int shopChoice = GetChoice();
            switch (shopChoice)
            {
                case 1:
                    shop.BuyPets(character);
                    break;
                case 2:
                    shop.BuyWand(character);
                    break;
                case 3:
                    break;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }

        private void CastSpell()
        {
            Console.WriteLine("Enter the spell you want to cast:");
            string spell = Console.ReadLine();
            magic.CastSpells(spell);
        }
    }
}
