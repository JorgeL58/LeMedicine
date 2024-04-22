namespace LeMedicine.Helpers
{
    public class SQLiteHelper<T> : SQLiteBase where T : BaseModel, new()
    {
        public List<T> GetAllData()
        {
            return connection.Table<T>().ToList();
        }
        public int Add(T entity)
        {
            connection.Insert(entity);
            return 0;
        }
        public int Update(T entity)
        {
            return connection.Update(entity);
        }
        public int Delete(T entity)
        {
            return connection.Delete(entity);
        }
        public T Get(int id)
        {
            return connection.Table<T>().Where(t => t.Id == id).FirstOrDefault();
        }
    }
}
