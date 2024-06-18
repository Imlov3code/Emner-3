using Microsoft.Data.SqlClient;

namespace ConsoleSQLApp {
    public class DataService : IDataSerivce
    {
        private readonly string _connectionString;

        public DataService(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IEnumerable<DataModel> GetData() {
            List<DataModel> dataList = new List<DataModel>();

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("SELECT Id, Name, Pass FROM MyTable", connection))
            {
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dataList.Add(new DataModel
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("Id")),
                                Name = reader.GetString(reader.GetOrdinal("Name")),
                                Pass = reader.GetString(reader.GetOrdinal("Pass"))

                            }
                        );
                    }
                }
            }

            return dataList;
        }

        public void UpdateData(DataModel data) {
            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("UPDATE MyTable SET Name = @Name, Pass = @Pass WHERE Id = @Id", connection))
            {
                connection.Open();

                command.Parameters.Add(new SqlParameter("@Id", SqlDataTypes.Int)
                {
                    Value = data.Id
                });

                command.Parameters.Add(new SqlParameter("@Name", SqlDataTypes.NVarChar)
                {
                    Value = data.Name
                });

                command.Parameters.Add(new SqlParameter("@Pass", SqlDataTypes.NVarChar)
                {
                    Value = data.Pass
                });

                command.ExecuteNonQuery();
            }
        }
    }
}
