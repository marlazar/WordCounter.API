using System.Linq.Expressions;

namespace WordCounter.Data.Repository.Definition
{
    public interface IRepository<T>
    {
        void Add(T t);
        void Delete(T t);
    }
}
