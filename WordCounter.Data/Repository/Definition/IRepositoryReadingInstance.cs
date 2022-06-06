using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordCounter.Core.Models;

namespace WordCounter.Data.Repository.Definition
{
    public interface IRepositoryReadingInstance : IRepository<ReadingInstance>
    {
        ReadingInstance ReturnReadingInstance(int instanceId);
        List<ReadingInstance> ReturnAllInstances();
    }
}
