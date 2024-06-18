namespace ConsoleSQLApp {
    internal class Program {
        static void Main(string[] args) {

            string connectionString = "Server=127.0.0.1;Database=LeviDataBase;User Id=sa;Password=1234567Levi;";

            var dataService = new DataService(connectionString);
            var data = dataService.GetData();

            Console.WriteLine("Oppdater Info: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Navn: ");
            string name = Console.ReadLine();

            Console.Write("Passord: ");
            string pass = Console.ReadLine();

            var UpdateModel = new DataModel()
            {
                Id = id,
                Name = name,
                Pass = pass
            };

            dataService.UpdateData(UpdateModel);
            Console.WriteLine("Data oppdatert vellykket.");

            foreach (var dbModel in data)
            {
                Console.WriteLine($"Id = {dbModel.Id} Name = {dbModel.Name} Password = {dbModel.Pass}");
            }
        }
    }
}