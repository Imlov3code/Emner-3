namespace AneelAndLevi_Bug_Project {
    internal class Program {
        static void Main(string[] args)
        {
            List<IDangerBug> buglist = new List<IDangerBug>()
            {
                new Mosquito("Mosquito", true, true, true, "None", PlagueType.Itchiness),
                new HouseFly("HouseFly", true, true, true, "None", PlagueType.DeseaseSpread),
                new Spider("Spider", true, true, true, "Eat Mosquito or Housefly", PlagueType.SeriousIllness),
                new Tick("Tick", true, true, true, "None", PlagueType.SeriousIllness),
                new Wasp("Wasp", true, true, true, "None", PlagueType.AllergyOrDisease)
            };

            while (true)
            {
                Console.WriteLine("Choose an option: ");
                Console.WriteLine("press 1 See list of bugs");
                Console.WriteLine("press 2 add new bug");
                Console.WriteLine("press 5 to exit");

                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        for (int i = 0; i<buglist.Count; i++)
                        {
                            buglist[i].DisplayProperties();
                        }
                        break;
                    case "2":
                        AddNewBug();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("wrong choice!");
                        break;
                }
            }
            
              void AddNewBug()
            {

                Console.Write("Enter name: ");
                string name = Console.ReadLine();
                Console.Write("can bite: ");
                bool canBite = (Console.ReadLine().ToLower()=="yes");
                Console.Write("has legs: ");
                bool hasLegs = (Console.ReadLine().ToLower()=="yes");
                Console.Write("can move: ");
                bool canMove = (Console.ReadLine().ToLower()=="yes");
                Console.Write("good stuff: ");
                string goodStuff = Console.ReadLine();
                Console.Write($"enter plague type: \nenter 0 for none\nenter 1 for Itchiness\nenter 2 for DeseaseSpread\nenter 3 for SeriousIllness\nenter 4 for Venomous\nenter 5 for AllergyOrDisease: ");
                int plague = Convert.ToInt32(Console.ReadLine());
                //var plagueType = Enum.GetValues(typeof(PlagueType);
                var plagueType =   Enum.GetName(typeof(PlagueType), plague);
                
                buglist.Add(new CustomBug(name,canBite,hasLegs,canMove,
                    goodStuff,plagueType) );
            
            }
        }

        
    }
}