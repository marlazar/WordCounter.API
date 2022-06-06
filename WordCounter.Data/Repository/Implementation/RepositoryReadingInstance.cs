using System.Linq.Expressions;
using WordCounter.Core.DataContext;
using WordCounter.Core.Models;
using WordCounter.Data.Repository.Definition;

namespace WordCounter.Data.Repository.Implementation
{
    public class RepositoryReadingInstance : IRepositoryReadingInstance
    {
        private WordCounterDataContext context;

        public RepositoryReadingInstance(WordCounterDataContext context)
        {
            this.context = context;
        }

        public void Add(ReadingInstance r)
        {
            context.ReadingInstance.Add(r);
            context.SaveChanges();
        }


        public void Delete(ReadingInstance r)
        {
            context.ReadingInstance.Remove(r);
            context.SaveChanges();
        }

        public ReadingInstance FindById(int id)
        {
            throw new NotImplementedException();
        }

        public List<ReadingInstance> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<ReadingInstance> ReturnAllInstances()
        {
            return context.ReadingInstance.ToList();
        }

        public ReadingInstance ReturnReadingInstance(int InstanceId)
        {
            return context.ReadingInstance.Where(ri => ri.InstanceId == InstanceId).FirstOrDefault();
        }

        public List<ReadingInstance> Search(Expression<Func<ReadingInstance, bool>> pred)
        {
            throw new NotImplementedException();
        }
    }
}
