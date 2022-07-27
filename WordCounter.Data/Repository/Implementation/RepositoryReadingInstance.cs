using System.Linq.Expressions;
using WordCounter.Core.DataContext;
using WordCounter.Core.Models;
using WordCounter.Data.Repository.Definition;

namespace WordCounter.Data.Repository.Implementation
{
    public class RepositoryReadingInstance : IRepositoryReadingInstance
    {
        private WordCounterDataContext _context;

        public RepositoryReadingInstance(WordCounterDataContext context)
        {
            this._context = context;
        }

        public void Add(ReadingInstance r)
        {
            _context.ReadingInstance.Add(r);
            _context.SaveChanges();
        }


        public void Delete(ReadingInstance r)
        {
            _context.ReadingInstance.Remove(r);
            _context.SaveChanges();
        }


        public List<ReadingInstance> ReturnAllInstances()
        {
            return _context.ReadingInstance.ToList();
        }

        public ReadingInstance ReturnReadingInstance(int InstanceId)
        {
            return _context.ReadingInstance.Where(ri => ri.InstanceId == InstanceId).FirstOrDefault();
        }

    }
}
