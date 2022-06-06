using System.Linq.Expressions;

namespace WordCounter.Data.Repository.Definition
{
    public interface IRepository<T>
    {
        void Add(T t);
        List<T> GetAll();
        T FindById(int id);
        void Delete(T t);
        List<T> Search(Expression<Func<T, bool>> pred);
    }
}
