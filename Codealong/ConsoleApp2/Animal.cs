namespace AnimalApp
{
    internal class AnimalData
    {
        public string Name { get; set; }
        public string Art { get; set; }
        public int Age { get; set; }

        public AnimalData(string name, string art, int age)
        {
            Name = name;
            Art = art;
            Age = age;
        }

        string GetName()
        {
            return Name;
        }

        string GetArt()
        {
            return Art;
        }

        int GetAge()
        {
            return Age;
        }

        public void PrintOutAnimal()
        {
            Console.WriteLine($"Name: {Name} Art: {Art} Age: {Age}");
        }
    }

    class AnimalManager
    {
        public void Addanimal(List<AnimalData> animals)
        {
            string name = Console.ReadLine();
            string art = Console.ReadLine();

            int age;

            while (!int.TryParse(Console.ReadLine(), out age))
            {
                Console.WriteLine("invalid input for age");
            }

            AnimalData animal = new AnimalData(name, art, age);
            animals.Add(animal);

            Console.WriteLine("Animal added successfully");
        }

        public void ShowAllAnimals(List<AnimalData> animals)
        {
            if (animals.Count == 0)
            {
                Console.WriteLine("No animals");
                return;
            }

            Console.WriteLine("Animals:");

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.Name);
                Console.WriteLine(animal.Art);
                Console.WriteLine(animal.Age);
            }
        }

        public void SearchArt(List<AnimalData> animals)
        {
            Console.WriteLine("Enter the art to search for: ");
            string art = Console.ReadLine();

            var filtered_animals = animals.Where(a => a.Art.Equals(art, StringComparison.OrdinalIgnoreCase)).ToList();

            if (filtered_animals.Count == 0)
            {
                Console.WriteLine($"No animals found for Art '{art}':");
                return;
            }

            Console.WriteLine($"Animal of Art {art} : ");
            foreach (var animal in filtered_animals)
            {
                Console.WriteLine(animal.Art);
            }
        }
    }
}
