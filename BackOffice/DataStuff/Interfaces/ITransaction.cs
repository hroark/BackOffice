namespace BackOffice.DataStuff.Interfaces
{
    public interface ITransaction<T>
    {
        void SaveToDatabase(T item);
        ITransaction<T> GetFromDatabase(int id);
        void ToJson();
        T FromJson();
    }
}
