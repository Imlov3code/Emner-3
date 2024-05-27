namespace Parprogrammeringsoppgaver_Uke_3
{
    class CarDataManager
    {
        public string brand { get; set; }
        public int year { get; set; }
        public string registerationnumber { get; set; }
        public int kilometers { get; set; }

        public CarDataManager(string Brand, int Year, string RegistrationNumber, int KiloMeters)
        {
            brand = Brand;
            year = Year;
            registerationnumber = RegistrationNumber;
            kilometers = KiloMeters;
        }

        public void DisplayOutPut()
        {
            Console.WriteLine($"Brand: {brand}");
            Console.WriteLine($"Year: {year}");
            Console.WriteLine($"RegistrationNumber: {registerationnumber}");
            Console.WriteLine($"KiloMeters: {kilometers}");
        }
    }

    class CarDataHandler
    {
        private List<CarDataManager> carsDataManager = new List<CarDataManager>();

        public void AddCar(CarDataManager car)
        {
            carsDataManager.Add(car);
        }

        public void GetAllCars()
        {
            for (int i = 0; i < carsDataManager.Count; i++)
            {
                carsDataManager[i].DisplayOutPut();
            }
        }

        // finn års modell til kjøretøyet fra årsrange

        public List<CarDataManager> FindCarsByYearRange(int start, int end)
        {
            var result = (from car in carsDataManager 
                where car.year >= start && car.year <= end select car);
            return result.ToList();
        }

        public List<CarDataManager> Find
    }
}
