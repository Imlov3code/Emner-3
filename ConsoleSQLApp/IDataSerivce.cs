namespace ConsoleSQLApp {
    public interface IDataSerivce
    {
        IEnumerable<DataModel> GetData();
        void UpdateData(DataModel data);
    }
}
