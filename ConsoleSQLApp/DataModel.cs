using System.Data;

namespace ConsoleSQLApp {
    public class DataModel {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Pass { get; set; }
        // Legg til flere typer etter behov
    }

    public static class SqlDataTypes {
        public const SqlDbType Int = SqlDbType.Int;
        public const SqlDbType NVarChar = SqlDbType.NVarChar;
        public const SqlDbType DateTime = SqlDbType.DateTime;
        // Legg til flere typer etter behov
    }
}
