namespace BackOffice.Models.Stations.Interfaces
{
    public interface ITransaction<T>
    {
        void SaveToDatabase(T item);
        string ToJson();
        T FromJson(string json);
    }
}
