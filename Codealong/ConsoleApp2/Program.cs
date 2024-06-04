namespace AnimalApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<AnimalData> animals = new List<AnimalData>();
           AnimalManager manager = new AnimalManager();

           while (true)
           {
               Console.WriteLine("\nMenu");
               Console.WriteLine("1. Add a new animals");
               Console.WriteLine("2. Show all animals");
               Console.WriteLine("3. Search by Art");

               int choice;

               if (!int.TryParse(Console.ReadLine(), out choice))
               {
                   Console.WriteLine("invalid choice");
                   continue;
               }

               switch (choice)
               {
                    case 1:
                        manager.Addanimal(animals);
                        break;

                    case 2:
                        manager.ShowAllAnimals(animals);
                        break;

                    case 3:
                        manager.SearchArt(animals);
                        break;

               }
           }
        }
    }
}