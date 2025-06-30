namespace BLL.Interface
{
    public interface IService <T>
    {
        Task Create(T entity);
        Task<List<T>> Read();
        void Update(T entity);
        Task Delete(T entity);
        Task<T?> GetById(string id);
    }
}
