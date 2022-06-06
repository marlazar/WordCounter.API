using WordCounter.Data.Repository.Definition;

namespace WordCounter.Data.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        public IRepositoryReadingInstance ReadingInstance { get; set; }
        void Commit();
    }
}
