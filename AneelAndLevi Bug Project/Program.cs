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
                Console.WriteLine("1. See list of bugs");

                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        for (int i = 0; i<buglist.Count; i++)
                        {
                            buglist[i].DisplayProperties();
                        }
                      
                        break;
                }
            }
        }
    }
}