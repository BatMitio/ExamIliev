namespace Data;

public interface IRepository<T, K>
{
    void Create(T data);
    T Read(K key);
    IEnumerable<T> ReadAll();
    void Update(T data);
    void Delete(K key);
}