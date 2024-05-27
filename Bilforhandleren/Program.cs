using System.Collections.Generic;

namespace Bilforhandleren
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarHandleManager handleManager = new CarHandleManager();

            while (true)
            {
                Console.WriteLine("\nChoose an action");
                Console.WriteLine("1. Search cars by year");
                Console.WriteLine("2. View all cars");
                Console.WriteLine("3. Show cars kilometers");

                int Choose;

                if (!int.TryParse(Console.ReadLine(), out Choose)) {
                    Console.WriteLine("Invalid choice, please try again.");
                    continue;
                }

                if (Choose == 1)
                {
                    int startYear = int.Parse(Console.ReadLine());
                    int endYear = int.Parse(Console.ReadLine());

                    List<CarDataManager> CarbyYear = handleManager.FindCarsByYear(startYear, endYear);
                    foreach (var car in CarbyYear)
                    {
                        
                        car.PrintCar();
                    }
                }
                else if (Choose == 2)
                {
                    handleManager.GetAllCars();
                }
                else if (Choose == 3)
                {
                    int kilometers = int.Parse(Console.ReadLine());
                    List<CarDataManager> CarByKilometer = handleManager.FindCarsByKilometer(kilometers);

                    foreach (var car in CarByKilometer)
                    {
                        car.PrintCar();
                    }
                }
                else if (Choose == 4)
                {
                    string RegistrationNumber = Console.ReadLine();
                    handleManager.PrintOutCarsRegistration(RegistrationNumber);
                 
                }
            }
        }
    }
}