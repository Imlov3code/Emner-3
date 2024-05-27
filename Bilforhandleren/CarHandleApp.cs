
namespace Bilforhandleren
{
    class CarDataManager
    {
        private string _brand { get; set; }
        private int _years { get; set; }
        private string _regNr { get; set; }
        private int _km { get; set; }

        public CarDataManager(string brand, int years, string regNr, int km)
        {
            _brand = brand;
            _years = years;
            _regNr = regNr;
            _km = km;
        }

        public string GetBrand()
        {
            return _brand;
        }

        public int GetYears()
        {
            return _years;
        }

        public string GetRegNr()
        {
            return _regNr;
        }

        public int GetKm()
        {
            return _km;
        }

        public void PrintCar()
        {
            Console.WriteLine($"Brand: {_brand}");
            Console.WriteLine($"Year: {_years}");
            Console.WriteLine($"Registration Number: {_regNr}");
            Console.WriteLine($"Kilometers: {_km}");
        }
    }

    class CarHandleManager {
        private List<CarDataManager> cars { get; set; }

        public CarHandleManager()
        {
            cars = AddCar();
        }

        private List<CarDataManager> AddCar()
        {
            List<CarDataManager> cars = new List<CarDataManager>()
            {
                new("Toyota", 2000, "BR20123", 30000),
                new("Volvo", 2006, "BT45266", 4566),
                new("Subaru", 2010, "EE33566", 76400),
            };

            return cars;
        }

        public void GetAllCars()
        {
            foreach (CarDataManager car in cars)
            {
                car.PrintCar();
            }
        }

        public List<CarDataManager> FindCarsByYear(int start_year, int end_year)
        {
            var result = cars.Where(car => car.GetYears() >= start_year && car.GetYears() <= end_year);
            return result.ToList();
        }

        public List<CarDataManager> FindCarsByKilometer(int kilometers)
        {
            var result = cars.Where(car => car.GetKm() <= kilometers);
            return result.ToList();
        }

        public List<CarDataManager> FindCarsByRegistrationNumber(string registrationNumber)
        {
            var result = cars.Where(c => c.GetRegNr() == registrationNumber).ToList();
            return result;
        }

        public void PrintOutCarsRegistration(string registrationNumber)
        {
            var car = FindCarsByRegistrationNumber(registrationNumber).FirstOrDefault();
            if (car == null)
            {
                Console.WriteLine("Car not found.");
                return;
            }

            car.PrintCar();
        }
    }
}
