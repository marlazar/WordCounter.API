using WordCounter.Core.DataContext;
using WordCounter.Data.Repository.Definition;
using WordCounter.Data.Repository.Implementation;

namespace WordCounter.Data.UnitOfWork
{
    public class WordCounterUnitOfWork : IUnitOfWork
    {
        private readonly WordCounterDataContext context;

        public WordCounterUnitOfWork(WordCounterDataContext context)
        {
            this.context = context;
            ReadingInstance = new RepositoryReadingInstance(context);
        }

        public IRepositoryReadingInstance ReadingInstance { get; set; }

        public void Commit()
        {
            context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
