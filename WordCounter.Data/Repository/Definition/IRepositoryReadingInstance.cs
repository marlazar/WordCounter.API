using WordCounter.Core.Models;

namespace WordCounter.Data.Repository.Definition
{
    public interface IRepositoryReadingInstance : IRepository<ReadingInstance>
    {
        ReadingInstance ReturnReadingInstance(int instanceId);
        List<ReadingInstance> ReturnAllInstances();
    }
}
