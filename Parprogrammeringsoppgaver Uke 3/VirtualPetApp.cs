namespace Parprogrammeringsoppgaver_Uke_3
{
    enum eMood
    {
        Sulten = 1,
        TrengerOppmerksomhet = 2,
        MåPåDo = 3,
        Fornøyd = 4,
    }

    public class VirtualPet
    {
        // seter & geter

        public string Name { get; set; }
        public int Age { get; set; }
        public bool Hungry;
        public bool Attention;
        public bool Toilet;
        public string Mood;
        
        public VirtualPet(string name, int age)
        {
            Name = name;
            Age = age;
            Hungry = false;
            Attention = false;
            Toilet = false;

            setMood();
        }

        public void PrintStauts()
        {
            PetManager.Print($"Stauts på {Name}: ");
            PetManager.Print($"Sulten: {Hungry}");
            PetManager.Print($"Trenger oppmerksomhet: {Attention}");
            PetManager.Print($"Må på do: {Toilet}");
            PetManager.Print($"Humør: {Mood}");
        }

        public void Feed()
        {
            Hungry = false;
            PetManager.Print($"{Name} er mett og fornøyd");
            setMood();
        }

        public void Cuddle()
        {
            Attention = false;
            PetManager.Print($"{Name} smiler!");
            setMood();
        }

        public void CheckToilet()
        {
            if (Toilet)
            {
                PetManager.Print($"{Name} må på do");
                Toilet = false;
            }
            else
            {
                PetManager.Print($"{Name} trenger ikke å gå på do");
            }

            setMood();
        }

        public void setMood()
        {
            if (Hungry && Attention)
            {
                Mood = "Sulten og trenger oppmerksomhet";
            }
            else if (Hungry)
            {
                Mood = "Sulten";
            }
            else if (Attention)
            {
                Mood = "Trenger oppmerkesomhet";
            }
            else if (Toilet)
            {
                Mood = "Må på do";
            }
            else
            {
                Mood = "Not Bad !";
            }
        }

        public void setRandomEvent()
        {
            Random random = new Random();
            int rand_roll = random.Next(1, 5); // random seed from 1 -> 4

            if (rand_roll == Convert.ToInt32(eMood.Sulten))
            {
                Hungry = true;
                PetManager.Print($"{Name} ble plutselig sulten!");
            }
            else if (rand_roll == Convert.ToInt32(eMood.TrengerOppmerksomhet))
            {
                Attention = true;
                PetManager.Print($"{Name} vil ha oppmerksomhet!");
            }
            else if (rand_roll == Convert.ToInt32(eMood.MåPåDo))
            {
                Toilet = true;
                PetManager.Print($"{Name} må på do!");
            }
            else if (rand_roll == Convert.ToInt32(eMood.Fornøyd))
            {

                PetManager.Print($"{Name} har det fint.");
            }

            setMood();
        }

    }

    class PetManager
    {
        // Innkapsle Output Logs

        public static void Print(string message)
        {
            Console.WriteLine(message);
        }

        public void ManagePet()
        {
            PetManager.Print("Hvilket dyr vil du ta vare på?");
            string petName = Console.ReadLine();
            VirtualPet pet = new VirtualPet(petName, 0);

            bool continueLoop = true;
            do
            {
                PetManager.Print($"\nVelg en handling for {pet.Name}:");
                PetManager.Print("1. Gi mat");
                PetManager.Print("2. Kos med kjæledyret");
                PetManager.Print("3. Sjekk om kjæledyret må på do");
                PetManager.Print("4. Vis kjæledyrets status");
                PetManager.Print("5. Tilbake til hovedmenyen");

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    PetManager.Print("Ugyldig valg, prøv igjen.");
                    continue;
                }

                if (choice == 1)
                {
                    pet.Feed();
                }
                else if (choice == 2)
                {
                    pet.Cuddle();
                }
                else if (choice == 3)
                {
                    pet.CheckToilet();
                }
                else if (choice == 4)
                {
                    pet.PrintStauts();
                }
                else if (choice == 5)
                {
                    continueLoop = false;
                }
                else
                {
                    PetManager.Print("Ugyldig valg, prøv igjen.");
                }

                if (continueLoop)
                {
                    pet.setRandomEvent();
                }
            } while (continueLoop);
        }
    }
}
